

// Generated on 02/23/2017 16:53:48
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildLevelUpMessage : NetworkMessage
    {
        public override ushort Id => 6062;
        
        
        public byte newLevel;
        
        public GuildLevelUpMessage()
        {
        }
        
        public GuildLevelUpMessage(byte newLevel)
        {
            this.newLevel = newLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteByte(newLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            newLevel = reader.ReadByte();
        }
        
    }
    
}