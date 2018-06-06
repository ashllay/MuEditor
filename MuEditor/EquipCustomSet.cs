using System;
using System.Collections;
using System.Text;

namespace MuEditor
{
    public class EquipCustomSet
    {
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public byte ClassType
        {
            get
            {
                return this.classType;
            }
            set
            {
                this.classType = value;
            }
        }

        public byte MembLvl
        {
            get
            {
                return this.membLvl;
            }
            set
            {
                this.membLvl = value;
            }
        }

        public EquipItem[] Items
        {
            get
            {
                return this.items;
            }
        }

        public bool setItem(int pos, string scodes)
        {
            if (pos >= 0 && pos < 15)
            {
                this.items[pos] = EquipItem.createItem(scodes);
                return this.items[pos] != null;
            }
            return false;
        }

        public bool setItems(IList items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                this.items[i] = (EquipItem)items[i];
            }
            return true;
        }

        public string[] getItemsCodes()
        {
            string[] array = new string[15];
            for (int i = 0; i < 15; i++)
            {
                if (this.items[i] == null)
                {
                    array[i] = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
                }
                else
                {
                    array[i] = this.items[i].ToString();
                }
            }
            return array;
        }

        public string GetItemsCodes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 15; i++)
            {
                if (this.items[i] == null)
                {
                    stringBuilder.Append("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
                }
                else
                {
                    stringBuilder.Append(this.items[i].ToString());
                }
            }
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return this.name;
        }

        public const int MAX_ITEM_NUM = 15;

        private string name;

        private byte classType;

        private byte membLvl;

        private EquipItem[] items = new EquipItem[15];
    }
}
