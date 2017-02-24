

// Generated on 02/23/2017 16:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MoodSmileyRequestMessage : NetworkMessage
    {
        public override ushort Id => 6192;
        
        
        public ushort smileyId;
        
        public MoodSmileyRequestMessage()
        {
        }
        
        public MoodSmileyRequestMessage(ushort smileyId)
        {
            this.smileyId = smileyId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)smileyId);
        }
        
        public override void Deserialize(IReader reader)
        {
            smileyId = reader.ReadVarUhShort();
        }
        
    }
    
}