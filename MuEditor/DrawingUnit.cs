using System;

namespace MuEditor
{
    public class DrawingUnit
    {
        public int Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }

        public EquipItem Item
        {
            get
            {
                return this.item;
            }
            set
            {
                this.item = value;
            }
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public DrawingUnit()
        {
        }

        public DrawingUnit(EquipItem item)
        {
            this.item = item;
        }

        public DrawingUnit(EquipItem item, int x, int y)
        {
            this.item = item;
            this.x = x;
            this.y = y;
        }

        public void assign(DrawingUnit unit)
        {
            this.x = unit.X;
            this.y = unit.Y;
            this.item = unit.Item;
        }

        public bool contains(int xx, int yy)
        {
            return this.x <= xx && this.y <= yy && this.x + (int)this.item.Width > xx && this.y + (int)this.item.Height > yy;
        }

        public const int STATUS_DOWN = 0;

        public const int STATUS_COVER = 1;

        public const int STATUS_HOVER = 2;

        private EquipItem item;

        private int x;

        private int y;

        private int status;
    }
}
