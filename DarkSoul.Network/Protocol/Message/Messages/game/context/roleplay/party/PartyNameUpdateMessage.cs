

// Generated on 02/23/2017 16:53:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyNameUpdateMessage : AbstractPartyMessage
    {
        public override ushort Id => 6502;
        
        
        public string partyName;
        
        public PartyNameUpdateMessage()
        {
        }
        
        public PartyNameUpdateMessage(uint partyId, string partyName)
         : base(partyId)
        {
            this.partyName = partyName;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(partyName);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            partyName = reader.ReadUTF();
        }
        
    }
    
}