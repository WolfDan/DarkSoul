﻿using DarkSoul.Core.Json;
using DarkSoul.Network.Protocol;
using DarkSoul.Network.Protocol.Message;
using System;
using System.Net;
using System.Net.Sockets;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reflection;
using System.Threading;

namespace DarkSoul.Network
{
    public abstract class BaseServer
    {
        public BaseServer(string ip, int port)
        {
            Ip = ip;
            Port = port;
        }

        /// <summary>
        /// Network port to bind
        /// </summary>
        public int Port { get; private set; }

        /// <summary>
        /// Network Ip to bind
        /// </summary>
        public string Ip { get; private set; }

        /// <summary>
        /// Cancelation Token
        /// </summary>
        public CancellationTokenSource Cancel { get; private set; }

        public void Initialize(Assembly assembly)
        {
            MessageHandler.Instance.Initilize(assembly);
            ProtocolTypeManager.Instance.Initialize();
            MessageReceiver.Instance.Build();
            var config = new JsonConfig();
            config.AddAssemblies(assembly, GetType().GetTypeInfo().Assembly);
            config.InitConfig();
            Init();

            // Init socket
            Cancel = new CancellationTokenSource();

            new IPEndPoint(IPAddress.Parse(Ip), Port).ToListenerObservable(10)
                .ObserveOn(TaskPoolScheduler.Default)
                .Subscribe(
                    client =>
                    {
                        BaseClient baseClient = null;
                        client.ToClientObservable(1024)
                            .Finally(() => baseClient?.Disconnect())
                            .Subscribe(ToClientObserver(client, Cancel.Token, out baseClient), Cancel.Token);
                    },
                    error => Console.WriteLine("Error: " + error.Message),
                    () => Console.WriteLine("Socket Disconnected"),
                    Cancel.Token);
        }

        public void Disconnect()
        {
            Cancel.Cancel();
        }

        public abstract void Init();

        public abstract IObserver<ArraySegment<byte>> ToClientObserver(Socket socket, CancellationToken token, out BaseClient client);
    }
}
