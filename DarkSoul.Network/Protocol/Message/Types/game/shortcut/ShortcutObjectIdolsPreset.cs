

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ShortcutObjectIdolsPreset : ShortcutObject
    {
        public override short TypeId => 492;
        
        public sbyte presetId;
        
        public ShortcutObjectIdolsPreset()
        {
        }
        
        public ShortcutObjectIdolsPreset(sbyte slot, sbyte presetId)
         : base(slot)
        {
            this.presetId = presetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(presetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            presetId = reader.ReadSByte();
        }
        
    }
    
}