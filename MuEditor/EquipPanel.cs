using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MuEditor
{
    public partial class EquipPanel : UserControl
    {

        public const int pixels = 26;
        private int xnum;

        private int ynum;

        private DrawingUnit[,] units;

        private bool[,] flags;

        private DrawingUnit curUnit = new DrawingUnit();

        private DrawingUnit activeUnit;

        private DrawingUnit selectedUnit;

        private DrawingUnit deleteUnit;

        private int lastedX;

        private int lastedY;

        private bool isShowTip;

        private int lastedTipX = -1;

        private int lastedTipY = -1;

        private EquipEditor editor;
        public EquipEditor Editor
        {
            set
            {
                this.editor = value;
            }
        }

        public int XNum
        {
            get
            {
                return this.xnum;
            }
        }

        public int YNum
        {
            get
            {
                return this.ynum;
            }
        }

        public IList Items
        {
            get
            {
                return this.getItems();
            }
        }

        public EquipPanel()
        {
            this.InitializeComponent();
        }

        public EquipPanel(int xnum, int ynum, EquipEditor editor)
        {
            this.InitializeComponent();
            this.setSize(xnum, ynum);
            this.editor = editor;
            this.curUnit.Item = editor.EditItem;
        }

        public void setSize(int xnum, int ynum)
        {
            this.xnum = xnum;
            this.ynum = ynum;
            this.resizePanel();
            this.units = new DrawingUnit[xnum, ynum];
            this.flags = new bool[xnum, ynum];
            for (int i = 0; i < xnum; i++)
            {
                for (int j = 0; j < ynum; j++)
                {
                    this.units[i, j] = null;
                    this.flags[i, j] = false;
                }
            }
        }

        public void clearData()
        {
            this.activeUnit = null;
            this.selectedUnit = null;
            this.lastedX = 0;
            this.lastedY = 0;
            for (int i = 0; i < this.xnum; i++)
            {
                for (int j = 0; j < this.ynum; j++)
                {
                    this.units[i, j] = null;
                    this.flags[i, j] = false;
                }
            }
        }

        protected void resizePanel()
        {
            base.Width = this.xnum * 26;
            base.Height = this.ynum * 26;
        }

        public bool loadItemsByCodes(byte[] codes, int offset, int len)
        {
            if (offset >= 0 && len >= this.xnum * this.ynum * 16 && codes != null)
            {
                for (int i = 0; i < this.ynum; i++)
                {
                    for (int j = 0; j < this.xnum; j++)
                    {
                        EquipItem item;
                        if ((item = EquipItem.createItem(codes, offset + (i * this.xnum + j) * 16, 16)) != null)
                        {
                            this.units[j, i] = new DrawingUnit(item, j, i);
                            this.putItem(this.units[j, i], false);
                        }
                    }
                }
                base.Invalidate();
                return true;
            }
            base.Invalidate();
            return false;
        }

        public bool loadItemsByCodes(byte[] codes)
        {
            return this.loadItemsByCodes(codes, 0, codes.Length);
        }

        public bool putItems(EquipItem[] items, bool isCopy)
        {
            bool flag = true;
            if (this.canPutItems(items))
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] != null)
                    {
                        flag = (flag && this.putItem(items[i], true, isCopy));
                    }
                }
                return flag;
            }
            return false;
        }

        public bool putItems(int nums)
        {
            bool flag = true;
            this.editor.updateData(this.curUnit.Item);
            for (int i = 0; i < nums; i++)
            {
                flag = (flag && this.putItem(this.curUnit.Item, true, false));
            }
            return flag;
        }

        public bool putItems()
        {
            bool flag = true;
            this.editor.updateData(this.curUnit.Item);
            EquipItem equipItem = new EquipItem();
            string text = "7,8,9,10,11";
            string b = "0";
            ushort code = this.curUnit.Item.Code;
            if (code <= 32)
            {
                if (code <= 20)
                {
                    if (code != 15 && code != 20)
                    {
                        goto IL_BC;
                    }
                }
                else if (code != 23 && code != 32)
                {
                    goto IL_BC;
                }
            }
            else
            {
                if (code > 48)
                {
                    switch (code)
                    {
                        case 59:
                        case 60:
                        case 61:
                            break;
                        default:
                            switch (code)
                            {
                                case 71:
                                    goto IL_AE;
                                case 72:
                                    break;
                                default:
                                    goto IL_BC;
                            }
                            break;
                    }
                    b = "10";
                    goto IL_BC;
                }
                if (code != 37)
                {
                    switch (code)
                    {
                        case 47:
                        case 48:
                            break;
                        default:
                            goto IL_BC;
                    }
                }
            }
        IL_AE:
            b = "7";
        IL_BC:
            foreach (string text2 in text.Split(new char[]
            {
                ','
            }))
            {
                if (!(text2 == b) && EquipEditor.xItem[(int)((ushort)Convert.ToByte(text2) * 512 + this.curUnit.Item.Code)] != null)
                {
                    equipItem.assign(EquipItem.createItem(this.curUnit.Item.Code, (ushort)Convert.ToByte(text2)));
                    equipItem.Code = this.curUnit.Item.Code;
                    equipItem.Type = (ushort)Convert.ToByte(text2);
                    this.editor.updateData(equipItem);
                    flag = (flag && this.putItem(equipItem, true, false));
                }
            }
            return flag;
        }

        public bool canPutItems(EquipItem[] items)
        {
            bool[,] array = (bool[,])this.flags.Clone();
            foreach (EquipItem equipItem in items)
            {
                if (equipItem != null)
                {
                    for (int j = 0; j < this.ynum; j++)
                    {
                        for (int k = 0; k < this.xnum; k++)
                        {
                            if (!array[k, j] && this.canPutItem(equipItem, k, j, array) && this.tryPutItem(equipItem, k, j, array))
                            {
                                goto IL_68;
                            }
                        }
                    }
                    return false;
                }
            IL_68:;
            }
            return true;
        }

        public bool tryPutItem(EquipItem item, int x, int y, bool[,] flags)
        {
            if ((int)item.Width + x > this.xnum || (int)item.Height + y > this.ynum || x < 0 || y < 0)
            {
                return false;
            }
            if (flags[x, y])
            {
                return false;
            }
            for (int i = 0; i < (int)item.Width; i++)
            {
                for (int j = 0; j < (int)item.Height; j++)
                {
                    if (flags[i + x, j + y])
                    {
                        return false;
                    }
                    flags[i + x, j + y] = true;
                }
            }
            return true;
        }

        public bool canPutItem(EquipItem item, int x, int y, bool[,] flags)
        {
            if ((int)item.Width + x > this.xnum || (int)item.Height + y > this.ynum || x < 0 || y < 0)
            {
                return false;
            }
            if (flags[x, y])
            {
                return false;
            }
            for (int i = 0; i < (int)item.Width; i++)
            {
                for (int j = 0; j < (int)item.Height; j++)
                {
                    if (flags[i + x, j + y])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool putItem(EquipItem item, bool add, bool isCopy)
        {
            DrawingUnit drawingUnit;
            if (isCopy)
            {
                drawingUnit = new DrawingUnit(new EquipItem(), 0, 0);
                drawingUnit.Item.assign(item);
            }
            else if (add)
            {
                drawingUnit = new DrawingUnit(new EquipItem(), 0, 0);
                drawingUnit.Item.assign(item);
                Utils.SN--;
                drawingUnit.Item.SN = Utils.SN;
                if (!Utils.ListWareHouse.Contains(drawingUnit.Item.ToString()))
                {
                    Utils.ListWareHouse.Add(drawingUnit.Item.ToString());
                }
            }
            else
            {
                drawingUnit = new DrawingUnit(item, 0, 0);
            }
            for (int i = 0; i < this.ynum; i++)
            {
                for (int j = 0; j < this.xnum; j++)
                {
                    if (!this.flags[j, i])
                    {
                        drawingUnit.X = j;
                        drawingUnit.Y = i;
                        if (this.canPutItem(drawingUnit))
                        {
                            return this.putItem(drawingUnit, false);
                        }
                    }
                }
            }
            return false;
        }

        public bool putItem(DrawingUnit unit, bool add)
        {
            int x = unit.X;
            int y = unit.Y;
            if (add)
            {
                this.units[x, y] = new DrawingUnit(new EquipItem(), x, y);
                this.units[x, y].Item.assign(unit.Item);
                Utils.SN--;
                this.units[x, y].Item.SN = Utils.SN;
            }
            else
            {
                this.units[x, y] = unit;
            }
            for (int i = 0; i < (int)unit.Item.Width; i++)
            {
                for (int j = 0; j < (int)unit.Item.Height; j++)
                {
                    this.flags[i + x, j + y] = true;
                }
            }
            return true;
        }

        public bool removeItem(DrawingUnit unit)
        {
            if (unit == null)
            {
                return true;
            }
            int x = unit.X;
            int y = unit.Y;
            this.units[x, y] = null;
            for (int i = 0; i < (int)unit.Item.Width; i++)
            {
                for (int j = 0; j < (int)unit.Item.Height; j++)
                {
                    this.flags[i + x, j + y] = false;
                }
            }
            return true;
        }

        public bool moveItem(DrawingUnit unit, int x, int y)
        {
            if (unit == null || unit.Item == null)
            {
                return false;
            }
            int x2 = unit.X;
            int y2 = unit.Y;
            this.removeItem(unit);
            unit.X = x;
            unit.Y = y;
            if (this.canPutItem(unit) && this.putItem(unit, false))
            {
                return true;
            }
            unit.X = x2;
            unit.Y = y2;
            this.putItem(unit, false);
            return false;
        }

        public bool canPutItem(DrawingUnit unit)
        {
            EquipItem item = unit.Item;
            int x = unit.X;
            int y = unit.Y;
            if ((int)item.Width + x > this.xnum || (int)item.Height + y > this.ynum || x < 0 || y < 0)
            {
                return false;
            }
            if (this.flags[x, y])
            {
                return false;
            }
            for (int i = 0; i < (int)item.Width; i++)
            {
                for (int j = 0; j < (int)item.Height; j++)
                {
                    if (this.flags[i + x, j + y])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool canPutItem(EquipItem item, int x, int y)
        {
            if ((int)item.Width + x > this.xnum || (int)item.Height + y > this.ynum || x < 0 || y < 0)
            {
                return false;
            }
            if (this.flags[x, y])
            {
                return false;
            }
            for (int i = 0; i < (int)item.Width; i++)
            {
                for (int j = 0; j < (int)item.Height; j++)
                {
                    if (this.flags[i + x, j + y])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        protected DrawingUnit findUnit(int x, int y)
        {
            if (this.flags[x, y])
            {
                for (int i = 0; i < this.xnum; i++)
                {
                    for (int j = 0; j < this.ynum; j++)
                    {
                        DrawingUnit drawingUnit;
                        if ((drawingUnit = this.units[i, j]) != null && drawingUnit.contains(x, y))
                        {
                            return drawingUnit;
                        }
                    }
                }
            }
            return null;
        }

        private void EquipPanel_Paint(object sender, PaintEventArgs e)
        {
            if (this.units == null)
            {
                return;
            }
            Graphics graphics = e.Graphics;
            for (int i = 0; i < this.xnum; i++)
            {
                for (int j = 0; j < this.ynum; j++)
                {
                    DrawingUnit drawingUnit;
                    if ((drawingUnit = this.units[i, j]) != null && drawingUnit.Item != null)
                    {
                        this.drawUnit(graphics, this.units[i, j]);
                    }
                }
            }
            if (this.activeUnit != null && this.activeUnit.Item != null)
            {
                EquipItem item = this.activeUnit.Item;
                int x = this.activeUnit.X;
                int y = this.activeUnit.Y;
                graphics.DrawImage(item.Img, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                Brush brush = new SolidBrush(Color.FromArgb(60, 128, 128, 128));
                graphics.FillRectangle(brush, this.activeUnit.X * 26, this.activeUnit.Y * 26, (int)(this.activeUnit.Item.Width * 26), (int)(this.activeUnit.Item.Height * 26));
                graphics.DrawRectangle(Pens.Blue, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
            }
        }

        private void drawUnit(Graphics g, DrawingUnit unit)
        {
            int x = unit.X;
            int y = unit.Y;
            EquipItem item = unit.Item;
            g.DrawImage(item.Img, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
            if (item.Level > 0)
            {
                g.DrawString(string.Format("+{0}", item.Level), new Font("Arial", 8f), Brushes.White, (float)(x * 26), (float)(y * 26));
            }
            else if (item.IsNoDurability && item.Durability > 1)
            {
                g.DrawString(Convert.ToString(item.Durability), new Font("Arial", 6f), Brushes.White, (float)(x * 26), (float)(y * 26));
            }
            if (item.SN < 0)
            {
                g.DrawRectangle(Pens.White, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if (item.XQ1 > 0 && (int)item.XQ1 < EquipEditor.xSocket.Length && item.XQ2 > 0 && (int)item.XQ2 < EquipEditor.xSocket.Length && item.XQ3 > 0 && (int)item.XQ3 < EquipEditor.xSocket.Length && item.XQ4 > 0 && (int)item.XQ4 < EquipEditor.xSocket.Length && item.XQ5 > 0 && (int)item.XQ5 < EquipEditor.xSocket.Length && item.YG > 0 && (int)item.YG < Utils.YGS.Length - 1 && (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6))
            {
                g.DrawRectangle(Pens.Fuchsia, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if (((item.XQ1 > 0 && (int)item.XQ1 < EquipEditor.xSocket.Length) || (item.XQ2 > 0 && (int)item.XQ2 < EquipEditor.xSocket.Length) || (item.XQ3 > 0 && (int)item.XQ3 < EquipEditor.xSocket.Length) || (item.XQ4 > 0 && (int)item.XQ4 < EquipEditor.xSocket.Length) || (item.XQ5 > 0 && (int)item.XQ5 < EquipEditor.xSocket.Length) || (item.YG > 0 && (int)item.YG < Utils.YGS.Length - 1)) && (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6))
            {
                g.DrawRectangle(Pens.Violet, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if ((item.XQ1 > 0 && (int)item.XQ1 < EquipEditor.xSocket.Length) || (item.XQ2 > 0 && (int)item.XQ2 < EquipEditor.xSocket.Length) || (item.XQ3 > 0 && (int)item.XQ3 < EquipEditor.xSocket.Length) || (item.XQ4 > 0 && (int)item.XQ4 < EquipEditor.xSocket.Length) || (item.XQ5 > 0 && (int)item.XQ5 < EquipEditor.xSocket.Length) || (item.YG > 0 && (int)item.YG < Utils.YGS.Length - 1))
            {
                g.DrawRectangle(Pens.Pink, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if (item.PlusLevel > 0 && item.SetVal > 0 && item.ZY1 && item.ZY2 && item.ZY3 && item.ZY4 && item.ZY5 && item.ZY6)
            {
                g.DrawRectangle(Pens.Aqua, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if ((item.SetVal > 0 && item.ZY1 && item.ZY2 && item.ZY3 && item.ZY4 && item.ZY5 && item.ZY6) || (item.PlusLevel > 0 && item.ZY1 && item.ZY2 && item.ZY3 && item.ZY4 && item.ZY5 && item.ZY6))
            {
                g.DrawRectangle(Pens.Turquoise, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if (item.ZY1 && item.ZY2 && item.ZY3 && item.ZY4 && item.ZY5 && item.ZY6)
            {
                g.DrawRectangle(Pens.LawnGreen, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if (item.PlusLevel > 0 && item.SetVal > 0 && (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6))
            {
                g.DrawRectangle(Pens.Gold, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if ((item.PlusLevel > 0 && (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6)) || (item.SetVal > 0 && (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6)))
            {
                g.DrawRectangle(Pens.Yellow, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6)
            {
                g.DrawRectangle(Pens.YellowGreen, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if (item.PlusLevel > 0)
            {
                g.DrawRectangle(Pens.SkyBlue, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
                return;
            }
            if (item.SetVal > 0)
            {
                g.DrawRectangle(Pens.Khaki, x * 26, y * 26, (int)(item.Width * 26), (int)(item.Height * 26));
            }
        }

        private bool addEditItem(int x, int y)
        {
            if (this.curUnit == null || this.curUnit.Item == null || this.curUnit.Item.Img == null)
            {
                return false;
            }
            this.curUnit.X = x;
            this.curUnit.Y = y;
            this.editor.updateData(this.curUnit.Item);
            if (this.canPutItem(this.curUnit) && this.putItem(this.curUnit, true))
            {
                return true;
            }
            Utils.WarningMessage("没有足够的空间放下物品[" + this.curUnit.Item.Name + "]");
            return false;
        }

        private void setEquipProperty(DrawingUnit unit)
        {
            if (unit != null)
            {
                this.Cursor = Cursors.WaitCursor;
                EquipProperty equipProperty = new EquipProperty(unit.Item);
                equipProperty.ShowDialog();
                equipProperty.Dispose();
                this.Cursor = Cursors.Default;
            }
        }

        private void EquipPanel_MouseClick(object sender, MouseEventArgs e)
        {
            int num = e.X / 26;
            int num2 = e.Y / 26;
            if (e.Button == MouseButtons.Right)
            {
                DrawingUnit drawingUnit;
                if (this.activeUnit != null)
                {
                    this.activeUnit.X = this.lastedX;
                    this.activeUnit.Y = this.lastedY;
                    if (this.canPutItem(this.activeUnit) && this.putItem(this.activeUnit, false))
                    {
                        this.selectedUnit = null;
                        this.activeUnit = null;
                        if ((drawingUnit = this.findUnit(num, num2)) != null)
                        {
                            this.deleteUnit = drawingUnit;
                            this.popMenu.Show(this, e.X, e.Y);
                        }
                        else
                        {
                            this.muCopy.Show(this, e.X, e.Y);
                        }
                    }
                }
                else if ((drawingUnit = this.findUnit(num, num2)) != null)
                {
                    this.deleteUnit = drawingUnit;
                    this.popMenu.Show(this, e.X, e.Y);
                }
                else
                {
                    this.muCopy.Show(this, e.X, e.Y);
                }
            }
            else if (this.activeUnit == null)
            {
                DrawingUnit drawingUnit = this.findUnit(num, num2);
                this.activeUnit = drawingUnit;
                if (this.activeUnit != null)
                {
                    this.removeItem(this.activeUnit);
                }
                if (!this.flags[num, num2] && this.selectedUnit != null)
                {
                    this.removeItem(this.selectedUnit);
                    this.activeUnit = this.selectedUnit;
                    this.lastedX = this.selectedUnit.X;
                    this.lastedY = this.selectedUnit.Y;
                    this.selectedUnit = null;
                }
                if (drawingUnit != null)
                {
                    if (base.Parent.Parent.Controls.Find("tabcInfo", false).Length > 0)
                    {
                        ((TabControl)base.Parent.Parent.Controls.Find("tabcInfo", false)[0]).SelectedIndex = 2;
                    }
                    this.selectedUnit = drawingUnit;
                    this.lastedX = this.selectedUnit.X;
                    this.lastedY = this.selectedUnit.Y;
                    this.editor.updateUI(drawingUnit.Item);
                }
            }
            else
            {
                this.activeUnit.X = num;
                this.activeUnit.Y = num2;
                if (this.canPutItem(this.activeUnit) && this.putItem(this.activeUnit, false))
                {
                    this.selectedUnit = null;
                    this.activeUnit = null;
                }
                else
                {
                    this.activeUnit.X = this.lastedX;
                    this.activeUnit.Y = this.lastedY;
                    if (this.canPutItem(this.activeUnit) && this.putItem(this.activeUnit, false))
                    {
                        this.selectedUnit = null;
                        this.activeUnit = null;
                    }
                    this.EquipPanel_MouseClick(sender, e);
                }
            }
            base.Invalidate();
        }

        private void EquipPanel_MouseDBClick(object sender, MouseEventArgs e)
        {
            int num = e.X / 26;
            int num2 = e.Y / 26;
            if (!this.flags[num, num2] && this.selectedUnit == null)
            {
                if (this.editor.AllPart)
                {
                    this.putItems();
                    this.editor.AllPart = false;
                }
                else
                {
                    this.putItems(this.editor.AddNum);
                }
            }
            base.Invalidate();
        }

        private void EquipPanel_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                int num = e.X / 26;
                int num2 = e.Y / 26;
                if (this.lastedTipX != num || this.lastedTipY != num2)
                {
                    this.isShowTip = false;
                    this.ttInfo.Hide(this);
                }
                if (this.flags[num, num2])
                {
                    this.Cursor = Cursors.Default;
                    if (this.findUnit(num, num2) != null && !this.isShowTip)
                    {
                        this.isShowTip = true;
                        this.lastedTipX = num;
                        this.lastedTipY = num2;
                        this.ttInfo.Show(Utils.GetEquipInfo(this.findUnit(num, num2).Item), this, e.X + 20, e.Y + 20);
                    }
                }
                else
                {
                    if (this.activeUnit != null)
                    {
                        this.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                    }
                    this.isShowTip = false;
                    this.ttInfo.Hide(this);
                }
            }
            catch
            {
            }
            base.Invalidate();
        }

        private void EquipPanel_MouseEnter(object sender, EventArgs e)
        {
            this.curUnit.Item = this.editor.EditItem;
        }

        private void EquipPanel_MouseLeave(object sender, EventArgs e)
        {
            this.curUnit.Item = null;
            this.isShowTip = false;
            this.ttInfo.Hide(this);
            base.Invalidate();
        }

        public void DownItem()
        {
            if (this.activeUnit != null)
            {
                this.activeUnit.X = this.lastedX;
                this.activeUnit.Y = this.lastedY;
                if (this.canPutItem(this.activeUnit) && this.putItem(this.activeUnit, false))
                {
                    this.selectedUnit = null;
                    this.activeUnit = null;
                }
            }
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            this.removeItem(this.deleteUnit);
            Utils.ListWareHouse.Remove(this.deleteUnit.Item.ToString());
            this.deleteUnit = null;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.setEquipProperty(this.deleteUnit);
            this.deleteUnit = null;
        }

        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.deleteUnit.Item.ToString(), true);
            this.removeItem(this.deleteUnit);
            this.deleteUnit = null;
        }

        public IList getItems()
        {
            IList list = new ArrayList();
            for (int i = 0; i < this.ynum; i++)
            {
                for (int j = 0; j < this.xnum; j++)
                {
                    if (this.units[j, i] != null && this.units[j, i].Item != null)
                    {
                        list.Add(this.units[j, i].Item);
                    }
                }
            }
            return list;
        }

        public EquipItem[] getEquipItems()
        {
            IList items = this.getItems();
            EquipItem[] array = new EquipItem[items.Count];
            for (int i = 0; i < items.Count; i++)
            {
                array[i] = (EquipItem)items[i];
            }
            return array;
        }

        public string getEquipCodes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < this.ynum; i++)
            {
                for (int j = 0; j < this.xnum; j++)
                {
                    if (this.units[j, i] != null && this.units[j, i].Item != null)
                    {
                        stringBuilder.Append(this.units[j, i].Item.ToString());
                    }
                    else
                    {
                        stringBuilder.Append("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
                    }
                }
            }
            return stringBuilder.ToString();
        }

        private void toolStripMenuItem_2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("&" + this.deleteUnit.Item.ToString(), true);
        }

        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            IDataObject dataObject = Clipboard.GetDataObject();
            if (dataObject.GetDataPresent(DataFormats.Text))
            {
                string text = ((string)dataObject.GetData(DataFormats.Text)).Replace("&", "").Replace("0x", "");
                if (text.Length == 32 && Validator.HexString(text) && !text.StartsWith("FF"))
                {
                    EquipItem equipItem = EquipItem.createItem(text);
                    if (equipItem != null && this.putItem(equipItem, false, true))
                    {
                        return;
                    }
                }
                else if (text.Length % 32 == 0 && Validator.HexString(text))
                {
                    EquipItem[] array = new EquipItem[text.Length / 32];
                    for (int i = 0; i < text.Length / 32; i++)
                    {
                        string text2 = text.Substring(i * 32, 32);
                        if (!text2.StartsWith("FF"))
                        {
                            array[i] = EquipItem.createItem(text2);
                        }
                    }
                    if (!this.putItems(array, true))
                    {
                        Utils.WarningMessage("没有足够的空间放置这些物品，请先清理出足够的空间！");
                    }
                }
            }
        }

        private bool hasDataInClipboard()
        {
            IDataObject dataObject = Clipboard.GetDataObject();
            if (dataObject.GetDataPresent(DataFormats.Text))
            {
                string text = ((string)dataObject.GetData(DataFormats.Text)).Replace("&", "").Replace("0x", "");
                if (text.Length == 32 && Validator.HexString(text) && !text.StartsWith("FF"))
                {
                    return true;
                }
                if (text.Length % 32 == 0 && Validator.HexString(text))
                {
                    return true;
                }
            }
            return false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("&" + this.getEquipCodes(), true);
        }

        private void muCopy_Opening(object sender, CancelEventArgs e)
        {
            this.toolStripMenuItem_3.Enabled = this.hasDataInClipboard();
        }

        private void toolStripMenuItem_5_Click(object sender, EventArgs e)
        {
            this.clearData();
            base.Invalidate();
        }

        private void toolStripMenuItem_6_Click(object sender, EventArgs e)
        {
            this.DownItem();
            EquipItem[] equipItems = this.getEquipItems();
            this.clearData();
            this.putItems(equipItems, true);
            base.Invalidate();
        }
    }
}
