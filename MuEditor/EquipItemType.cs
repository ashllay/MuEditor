using System;
using System.Collections;

namespace MuEditor
{
    public class EquipItemType
    {
        public EquipItemType()
        {
        }

        public EquipItemType(byte typeId, string name)
        {
            this.typeId = typeId;
            this.name = name;
        }

        public byte TypeId
        {
            get
            {
                return this.typeId;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public IList ItemNames
        {
            get
            {
                return this.itemNames;
            }
            set
            {
                this.itemNames = value;
            }
        }

        public override string ToString()
        {
            return this.name;
        }

        private byte typeId;

        private string name;

        private IList itemNames;
    }
}
