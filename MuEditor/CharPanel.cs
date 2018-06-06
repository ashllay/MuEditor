using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuEditor
{
    public partial class CharPanel : UserControl
    {
        public int Prof
        {
            get
            {
                return this.prof;
            }
            set
            {
                this.prof = value;
            }
        }

        public EquipEditor Editor
        {
            set
            {
                this.editor = value;
            }
        }
        public CharPanel()
        {
            InitializeComponent();
        }
        public CharPanel(EquipEditor editor)
        {
            this.InitializeComponent();
            this.editor = editor;
        }

        public void clearData()
        {
            this.selectedUnit = null;
            for (int i = 0; i < 12; i++)
            {
                this.units[i] = null;
            }
        }

        public bool loadItemsByCodes(byte[] codes)
        {
            return this.loadItemsByCodes(codes, 0, codes.Length);
        }

        public bool loadItemsByCodes(byte[] codes, int offset, int len)
        {
            if (offset >= 0 && len >= 192 && codes != null)
            {
                for (int i = 0; i < 12; i++)
                {
                    EquipItem item;
                    if ((item = EquipItem.createItem(codes, offset + i * 16, 16)) != null)
                    {
                        this.units[i] = new DrawingUnit(item, i, 0);
                    }
                }
                base.Invalidate();
                return true;
            }
            base.Invalidate();
            return false;
        }

        public bool putItem(DrawingUnit unit, bool add, bool isCopy)
        {
            int x = unit.X;
            int y = unit.Y;
            if (isCopy)
            {
                this.units[this.index] = new DrawingUnit(new EquipItem(), this.index, y);
                this.units[this.index].Item.assign(unit.Item);
            }
            else
            {
                if (add)
                {
                    this.units[x] = new DrawingUnit(new EquipItem(), x, y);
                    Utils.SN--;
                    unit.Item.SN = Utils.SN;
                    this.units[x].Item.assign(unit.Item);
                }
                else
                {
                    Utils.SN--;
                    unit.Item.SN = Utils.SN;
                    this.units[x] = unit;
                }
                if (!Utils.ListPackage.Contains(unit.Item.ToString()))
                {
                    Utils.ListPackage.Add(unit.Item.ToString());
                }
            }
            return true;
        }

        public bool removeItem(DrawingUnit unit)
        {
            int x = unit.X;
            this.units[x] = null;
            return true;
        }

        public bool canPutItem(DrawingUnit unit)
        {
            EquipItem item = unit.Item;
            int x = unit.X;
            int y = unit.Y;
            if (x < 0 && x >= 12 && this.units[x] != null)
            {
                return false;
            }
            ushort itemSlot = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemSlot;
            switch (this.index)
            {
                case 0:
                    if (itemSlot == 0)
                    {
                        return true;
                    }
                    break;
                case 1:
                    if (itemSlot == 0 || itemSlot == 1)
                    {
                        return true;
                    }
                    break;
                case 2:
                    if (itemSlot == 2)
                    {
                        return true;
                    }
                    break;
                case 3:
                    if (itemSlot == 3)
                    {
                        return true;
                    }
                    break;
                case 4:
                    if (itemSlot == 4)
                    {
                        return true;
                    }
                    break;
                case 5:
                    if (itemSlot == 5)
                    {
                        return true;
                    }
                    break;
                case 6:
                    if (itemSlot == 6)
                    {
                        return true;
                    }
                    break;
                case 7:
                    if (itemSlot == 7)
                    {
                        return true;
                    }
                    break;
                case 8:
                    if (itemSlot == 8)
                    {
                        return true;
                    }
                    break;
                case 9:
                    if (itemSlot == 9)
                    {
                        return true;
                    }
                    break;
                case 10:
                    if (itemSlot == 10 || itemSlot == 11)
                    {
                        return true;
                    }
                    break;
                case 11:
                    if (itemSlot != 10)
                    {
                        if (itemSlot != 11)
                        {
                            break;
                        }
                    }
                    return true;
            }
            return false;
        }

        public int findRectangle(int x, int y)
        {
            for (int i = 0; i < 12; i++)
            {
                if (this.positions[i].Contains(x, y))
                {
                    return i;
                }
            }
            return -1;
        }

        private bool addEditItem(int index)
        {
            if (this.curUnit == null || this.curUnit.Item == null || this.curUnit.Item.Img == null)
            {
                return false;
            }
            this.curUnit.X = index;
            this.curUnit.Y = 0;
            this.editor.updateData(this.curUnit.Item);
            if (this.canPutItem(this.curUnit) && this.putItem(this.curUnit, true, false))
            {
                return true;
            }
            Utils.WarningMessage("物品[" + this.curUnit.Item.Name + "]不能放置在该位置！");
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

        private void CharPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.index = this.findRectangle(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                if (this.index < 0)
                {
                    this.selectedUnit = null;
                    return;
                }
                if (this.units[this.index] != null)
                {
                    this.selectedUnit = this.units[this.index];
                    this.popMenu.Show(this, e.X, e.Y);
                    return;
                }
                this.muCopy.Show(this, e.X, e.Y);
                this.selectedUnit = null;
                return;
            }
            else
            {
                if (this.index < 0)
                {
                    this.selectedUnit = null;
                    return;
                }
                if (this.units[this.index] != null)
                {
                    if (base.Parent.Parent.Controls.Find("tabcInfo", false).Length > 0)
                    {
                        ((TabControl)base.Parent.Parent.Controls.Find("tabcInfo", false)[0]).SelectedIndex = 2;
                    }
                    this.selectedUnit = this.units[this.index];
                    this.editor.updateUI(this.selectedUnit.Item);
                    return;
                }
                this.selectedUnit = null;
                return;
            }
        }

        private void CharPanel_MouseEnter(object sender, EventArgs e)
        {
            this.curUnit.Item = this.editor.EditItem;
        }

        private void CharPanel_MouseLeave(object sender, EventArgs e)
        {
            this.curUnit.Item = null;
            this.isShowTip = false;
            this.ttInfo.Hide(this);
            base.Invalidate();
        }

        private void CharPanel_MouseMove(object sender, MouseEventArgs e)
        {
            this.index = this.findRectangle(e.X, e.Y);
            if (this.lastedIndex != this.index)
            {
                this.isShowTip = false;
                this.ttInfo.Hide(this);
            }
            if (this.index >= 0)
            {
                if (this.units[this.index] != null && !this.isShowTip)
                {
                    this.isShowTip = true;
                    this.lastedIndex = this.index;
                    this.ttInfo.Show(Utils.GetEquipInfo(this.units[this.index].Item), this, e.X + 20, e.Y + 20);
                }
            }
            else
            {
                this.isShowTip = false;
                this.ttInfo.Hide(this);
            }
            base.Invalidate();
        }

        private void CharPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            for (int i = 0; i < 12; i++)
            {
                if (this.units[i] != null)
                {
                    this.drawUnit(graphics, this.units[i]);
                }
            }
            if (this.selectedUnit != null && this.selectedUnit.Item != null)
            {
                Brush brush = new SolidBrush(Color.FromArgb(60, 128, 128, 128));
                graphics.FillRectangle(brush, this.positions[this.selectedUnit.X]);
            }
        }

        private void drawUnit(Graphics g, DrawingUnit unit)
        {
            int x = unit.X;
            int y = unit.Y;
            EquipItem item = unit.Item;
            int num = Math.Max(this.positions[x].Width - (int)(item.Width * 26) >> 1, 0);
            int num2 = Math.Max(this.positions[x].Height - (int)(item.Height * 26) >> 1, 0);
            int width = Math.Min((int)(item.Width * 26), this.positions[x].Width);
            int height = Math.Min((int)(item.Height * 26), this.positions[x].Height);
            g.DrawImage(item.Img, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
            if (item.Level > 0)
            {
                g.DrawString(string.Format("+{0}", item.Level), new Font("Arial", 8f), Brushes.White, (float)(this.positions[x].X + num), (float)(this.positions[x].Y + num2));
            }
            else if (item.IsNoDurability && item.Durability > 1)
            {
                g.DrawString(Convert.ToString(item.Durability), new Font("Arial", 6f), Brushes.White, (float)(this.positions[x].X + num), (float)(this.positions[x].Y + num2));
            }
            if (item.SN < 0)
            {
                g.DrawRectangle(Pens.White, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if (item.XQ1 > 0 && (int)item.XQ1 < EquipEditor.xSocket.Length && item.XQ2 > 0 && (int)item.XQ2 < EquipEditor.xSocket.Length && item.XQ3 > 0 && (int)item.XQ3 < EquipEditor.xSocket.Length && item.XQ4 > 0 && (int)item.XQ4 < EquipEditor.xSocket.Length && item.XQ5 > 0 && (int)item.XQ5 < EquipEditor.xSocket.Length && item.YG > 0 && (int)item.YG < Utils.YGS.Length - 1 && (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6))
            {
                g.DrawRectangle(Pens.Fuchsia, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if (((item.XQ1 > 0 && (int)item.XQ1 < EquipEditor.xSocket.Length) || (item.XQ2 > 0 && (int)item.XQ2 < EquipEditor.xSocket.Length) || (item.XQ3 > 0 && (int)item.XQ3 < EquipEditor.xSocket.Length) || (item.XQ4 > 0 && (int)item.XQ4 < EquipEditor.xSocket.Length) || (item.XQ5 > 0 && (int)item.XQ5 < EquipEditor.xSocket.Length) || (item.YG > 0 && (int)item.YG < Utils.YGS.Length - 1)) && (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6))
            {
                g.DrawRectangle(Pens.Violet, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if ((item.XQ1 > 0 && (int)item.XQ1 < EquipEditor.xSocket.Length) || (item.XQ2 > 0 && (int)item.XQ2 < EquipEditor.xSocket.Length) || (item.XQ3 > 0 && (int)item.XQ3 < EquipEditor.xSocket.Length) || (item.XQ4 > 0 && (int)item.XQ4 < EquipEditor.xSocket.Length) || (item.XQ5 > 0 && (int)item.XQ5 < EquipEditor.xSocket.Length) || (item.YG > 0 && (int)item.YG < Utils.YGS.Length - 1))
            {
                g.DrawRectangle(Pens.Pink, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if (item.PlusLevel > 0 && item.SetVal > 0 && item.ZY1 && item.ZY2 && item.ZY3 && item.ZY4 && item.ZY5 && item.ZY6)
            {
                g.DrawRectangle(Pens.Aqua, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if ((item.SetVal > 0 && item.ZY1 && item.ZY2 && item.ZY3 && item.ZY4 && item.ZY5 && item.ZY6) || (item.PlusLevel > 0 && item.ZY1 && item.ZY2 && item.ZY3 && item.ZY4 && item.ZY5 && item.ZY6))
            {
                g.DrawRectangle(Pens.Turquoise, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if (item.ZY1 && item.ZY2 && item.ZY3 && item.ZY4 && item.ZY5 && item.ZY6)
            {
                g.DrawRectangle(Pens.LawnGreen, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if (item.PlusLevel > 0 && item.SetVal > 0 && (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6))
            {
                g.DrawRectangle(Pens.Gold, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if ((item.PlusLevel > 0 && (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6)) || (item.SetVal > 0 && (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6)))
            {
                g.DrawRectangle(Pens.Yellow, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if (item.ZY1 || item.ZY2 || item.ZY3 || item.ZY4 || item.ZY5 || item.ZY6)
            {
                g.DrawRectangle(Pens.YellowGreen, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if (item.PlusLevel > 0)
            {
                g.DrawRectangle(Pens.SkyBlue, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
                return;
            }
            if (item.SetVal > 0)
            {
                g.DrawRectangle(Pens.Khaki, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
            }
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            this.removeItem(this.selectedUnit);
            Utils.ListPackage.Remove(this.selectedUnit.Item.ToString());
            this.selectedUnit = null;
        }

        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            this.setEquipProperty(this.selectedUnit);
        }

        private void toolStripMenuItem_2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.selectedUnit.Item.ToString(), true);
            this.removeItem(this.selectedUnit);
            this.selectedUnit = null;
        }

        public string getEquipCodes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 12; i++)
            {
                if (this.units[i] != null && this.units[i].Item != null)
                {
                    stringBuilder.Append(this.units[i].Item.ToString());
                }
                else
                {
                    stringBuilder.Append("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
                }
            }
            return stringBuilder.ToString();
        }

        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("&" + this.selectedUnit.Item.ToString(), true);
        }

        private void toolStripMenuItem_4_Click(object sender, EventArgs e)
        {
            IDataObject dataObject = Clipboard.GetDataObject();
            if (dataObject.GetDataPresent(DataFormats.Text))
            {
                string text = ((string)dataObject.GetData(DataFormats.Text)).Replace("&", "").Replace("0x", "");
                if (text.Length == 32 && Validator.HexString(text) && !text.StartsWith("FF"))
                {
                    EquipItem equipItem = EquipItem.createItem(text);
                    DrawingUnit unit = new DrawingUnit(equipItem);
                    if (equipItem != null && this.canPutItem(unit))
                    {
                        this.putItem(unit, false, true);
                        return;
                    }
                    Utils.WarningMessage("物品[" + equipItem.Name + "]不能放置在该位置！");
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("&" + this.getEquipCodes(), true);
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
            }
            return false;
        }

        private void muCopy_Opening(object sender, CancelEventArgs e)
        {
            this.toolStripMenuItem_4.Enabled = this.hasDataInClipboard();
        }

        private void CharPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.index = this.findRectangle(e.X, e.Y);
            if (this.index >= 0)
            {
                if (this.units[this.index] == null)
                {
                    this.addEditItem(this.index);
                    return;
                }
            }
            else
            {
                this.selectedUnit = null;
            }
        }

        private void toolStripMenuItem_6_Click(object sender, EventArgs e)
        {
            this.clearData();
            base.Invalidate();
        }
    }
}
