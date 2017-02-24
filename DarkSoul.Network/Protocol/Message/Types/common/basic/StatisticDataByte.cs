

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class StatisticDataByte : StatisticData
    {
        public override short TypeId => 486;
        
        public sbyte value;
        
        public StatisticDataByte()
        {
        }
        
        public StatisticDataByte(sbyte value)
        {
            this.value = value;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(value);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadSByte();
        }
        
    }
    
}