

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GoldItem : Item
    {
        public override short TypeId => 123;
        
        public double sum;
        
        public GoldItem()
        {
        }
        
        public GoldItem(double sum)
        {
            this.sum = sum;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(sum);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            sum = reader.ReadVarUhLong();
        }
        
    }
    
}