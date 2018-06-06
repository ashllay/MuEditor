using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MuEditor
{
    public partial class PentagramPanel : UserControl
    {
        public PentagramPanel()
        {
            InitializeComponent();
        }
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

        // Token: 0x17000019 RID: 25
        // (set) Token: 0x060000D4 RID: 212 RVA: 0x00002A61 File Offset: 0x00000C61
        public EquipEditor Editor
        {
            set
            {
                this.editor = value;
            }
        }

        // Token: 0x060000D5 RID: 213 RVA: 0x00015E40 File Offset: 0x00014040
        //public PentagramPanel()
        // {
        //    this.InitializeComponent();
        //}

        // Token: 0x060000D6 RID: 214 RVA: 0x00015EAC File Offset: 0x000140AC
        public PentagramPanel(EquipEditor editor)
        {
            InitializeComponent();
            this.editor = editor;
        }

        // Token: 0x060000D7 RID: 215 RVA: 0x00015F20 File Offset: 0x00014120
        public void clearData()
        {
            this.selectedUnit = null;
            for (int i = 0; i < 1; i++)
            {
                this.units[i] = null;
            }
        }

        // Token: 0x060000D8 RID: 216 RVA: 0x00002A6A File Offset: 0x00000C6A
        public bool loadItemsByCodes(byte[] codes)
        {
            return this.loadItemsByCodes(codes, 0, codes.Length);
        }

        // Token: 0x060000D9 RID: 217 RVA: 0x00015F4C File Offset: 0x0001414C
        public bool loadItemsByCodes(byte[] codes, int offset, int len)
        {
            if (offset >= 0 && len >= 16 && codes != null)
            {
                for (int i = 0; i < 1; i++)
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

        // Token: 0x060000DA RID: 218 RVA: 0x00015FA4 File Offset: 0x000141A4
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

        // Token: 0x060000DB RID: 219 RVA: 0x000160A4 File Offset: 0x000142A4
        public bool removeItem(DrawingUnit unit)
        {
            int x = unit.X;
            this.units[x] = null;
            return true;
        }

        // Token: 0x060000DC RID: 220 RVA: 0x000160C4 File Offset: 0x000142C4
        public bool canPutItem(DrawingUnit unit)
        {
            EquipItem item = unit.Item;
            int x = unit.X;
            int y = unit.Y;
            return (x >= 0 || x < 1 || this.units[x] == null) &&
                (int)(EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemSlot - 236) == this.index;
        }

        // Token: 0x060000DD RID: 221 RVA: 0x0001612C File Offset: 0x0001432C
        public int findRectangle(int x, int y)
        {
            for (int i = 0; i < 1; i++)
            {
                if (this.positions[i].Contains(x, y))
                {
                    return i;
                }
            }
            return -1;
        }

        // Token: 0x060000DE RID: 222 RVA: 0x00016160 File Offset: 0x00014360
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

        // Token: 0x060000DF RID: 223 RVA: 0x00014AEC File Offset: 0x00012CEC
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

        // Token: 0x060000E0 RID: 224 RVA: 0x00016210 File Offset: 0x00014410
        private void SkillPanel_MouseClick(object sender, MouseEventArgs e)
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

        // Token: 0x060000E1 RID: 225 RVA: 0x00002A77 File Offset: 0x00000C77
        private void SkillPanel_MouseEnter(object sender, EventArgs e)
        {
            this.curUnit.Item = this.editor.EditItem;
        }

        // Token: 0x060000E2 RID: 226 RVA: 0x00002A8F File Offset: 0x00000C8F
        private void SkillPanel_MouseLeave(object sender, EventArgs e)
        {
            this.curUnit.Item = null;
            this.isShowTip = false;
            this.ttInfo.Hide(this);
            base.Invalidate();
        }

        // Token: 0x060000E3 RID: 227 RVA: 0x0001634C File Offset: 0x0001454C
        private void SkillPanel_MouseMove(object sender, MouseEventArgs e)
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

        // Token: 0x060000E4 RID: 228 RVA: 0x00016418 File Offset: 0x00014618
        private void SkillPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            for (int i = 0; i < 1; i++)
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

        // Token: 0x060000E5 RID: 229 RVA: 0x000164A4 File Offset: 0x000146A4
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

        // Token: 0x060000E6 RID: 230 RVA: 0x00002AB6 File Offset: 0x00000CB6
        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            this.removeItem(this.selectedUnit);
            Utils.ListPackage.Remove(this.selectedUnit.Item.ToString());
            this.selectedUnit = null;
        }

        // Token: 0x060000E7 RID: 231 RVA: 0x00002AE7 File Offset: 0x00000CE7
        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            this.setEquipProperty(this.selectedUnit);
        }

        // Token: 0x060000E8 RID: 232 RVA: 0x00002AF5 File Offset: 0x00000CF5
        private void toolStripMenuItem_2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.selectedUnit.Item.ToString(), true);
            this.removeItem(this.selectedUnit);
            this.selectedUnit = null;
        }

        // Token: 0x060000E9 RID: 233 RVA: 0x00016CF4 File Offset: 0x00014EF4
        public string getEquipCodes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 1; i++)
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

        // Token: 0x060000EA RID: 234 RVA: 0x00002B21 File Offset: 0x00000D21
        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("&" + this.selectedUnit.Item.ToString(), true);
        }

        // Token: 0x060000EB RID: 235 RVA: 0x00016D5C File Offset: 0x00014F5C
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

        // Token: 0x060000EC RID: 236 RVA: 0x00002B43 File Offset: 0x00000D43
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("&" + this.getEquipCodes(), true);
        }

        // Token: 0x060000ED RID: 237 RVA: 0x0001572C File Offset: 0x0001392C
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

        // Token: 0x060000EE RID: 238 RVA: 0x00002B5B File Offset: 0x00000D5B
        private void muCopy_Opening(object sender, CancelEventArgs e)
        {
            this.toolStripMenuItem_4.Enabled = this.hasDataInClipboard();
        }

        // Token: 0x060000EF RID: 239 RVA: 0x00016E0C File Offset: 0x0001500C
        private void SkillPanel_MouseDoubleClick(object sender, MouseEventArgs e)
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

        // Token: 0x060000F0 RID: 240 RVA: 0x00002B6E File Offset: 0x00000D6E
        private void toolStripMenuItem_6_Click(object sender, EventArgs e)
        {
            this.clearData();
            base.Invalidate();
        }
    }
}
