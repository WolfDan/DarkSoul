

// Generated on 02/23/2017 16:53:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AbstractPartyEventMessage : AbstractPartyMessage
    {
        public override ushort Id => 6273;
        
        
        
        public AbstractPartyEventMessage()
        {
        }
        
        public AbstractPartyEventMessage(uint partyId)
         : base(partyId)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}