

// Generated on 02/23/2017 16:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class OrnamentGainedMessage : NetworkMessage
    {
        public override ushort Id => 6368;
        
        
        public short ornamentId;
        
        public OrnamentGainedMessage()
        {
        }
        
        public OrnamentGainedMessage(short ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(ornamentId);
        }
        
        public override void Deserialize(IReader reader)
        {
            ornamentId = reader.ReadShort();
        }
        
    }
    
}