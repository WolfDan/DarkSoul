

// Generated on 02/23/2017 16:53:30
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightReadyMessage : NetworkMessage
    {
        public override ushort Id => 708;
        
        
        public bool isReady;
        
        public GameFightReadyMessage()
        {
        }
        
        public GameFightReadyMessage(bool isReady)
        {
            this.isReady = isReady;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(isReady);
        }
        
        public override void Deserialize(IReader reader)
        {
            isReady = reader.ReadBoolean();
        }
        
    }
    
}