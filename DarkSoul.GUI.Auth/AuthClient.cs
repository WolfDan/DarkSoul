﻿using DarkSoul.Core.Crypto;
using DarkSoul.Core.IO;
using DarkSoul.Network;
using DarkSoul.Network.Protocol;
using DarkSoul.Network.Protocol.Messages;
using System;
using System.Net.Sockets;
using System.Threading;

namespace DarkSoul.GUI.Auth
{
    public class AuthClient : BaseClient
    {

        public AuthClient(Socket socket, CancellationToken token) : base(socket, token)
        {
            SendMessage(new ProtocolRequired(1759, 1759)); //Hardcoded on client
            SendMessage(new HelloConnectMessage(RSAProvider.Instance.Salt, RSAProvider.Instance.GetRSAPublicKey()));
        }

        public AuthClient(Socket socket, bool ownsSocket, CancellationToken token) : base(socket, ownsSocket, token) { }

        public override async void SendMessage(NetworkMessage message)
        {
            using (var writer = new BigEndianWriter())
            {
                message.Pack(writer);
                await WriteAsync(writer.Data, 0, writer.Data.Length, Cancelation);
                Console.WriteLine($"Send: {message.GetType().Name}");
            }
        }
    }
}
