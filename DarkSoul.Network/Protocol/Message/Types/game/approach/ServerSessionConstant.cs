

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ServerSessionConstant
    {
        public virtual short TypeId => 430;
        
        public ushort id;
        
        public ServerSessionConstant()
        {
        }
        
        public ServerSessionConstant(ushort id)
        {
            this.id = id;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)id);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhShort();
        }
        
    }
    
}