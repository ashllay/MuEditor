using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MuEditor
{
    public partial class EquipEditor : UserControl
    {

        private const int CB_FINDSTRING = 332;
        private ArrayList itemTypes = new ArrayList();
        private EquipItem editItem;
        private byte defDurability = byte.MaxValue;
        public static ITEM_ATTRIBUTE[] xItem;
        public static ITEM_SOCKETITEM[] xSocket;
        public EquipEditor()
        {
            string text = "Data\\Item.bmd";
            if (!File.Exists(text))
            {
                text = "MuEdit\\bin\\Release\\" + text;
            }
            ItemClass itemClass = new ItemClass(text);
            EquipEditor.xItem = itemClass.ItemAttribute;
            text = "Data\\SocketItem.bmd";
            if (!File.Exists(text))
            {
                text = "MuEdit\\bin\\Release\\" + text;
            }
            SocketItemClass socketItemClass = new SocketItemClass(text);
            EquipEditor.xSocket = socketItemClass.cSocket;
        }
        

        public EquipItem EditItem
        {
            get
            {
                return editItem;
            }
        }

        public bool AllPart
        {
            get
            {
                switch (cboEquipType.SelectedIndex)
                {
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        return chkAllPart.Checked;
                    default:
                        return false;
                }
            }
            set
            {
                chkAllPart.Checked = value;
            }
        }

        public int AddNum
        {
            get
            {
                return Convert.ToInt32(AddNums.Text);
            }
        }

        public byte DefaultDurability
        {
            get
            {
                return defDurability;
            }
            set
            {
                defDurability = value;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            chkEquipZY1.Checked = chkEquipZY1.Enabled;
            chkEquipZY2.Checked = chkEquipZY2.Enabled;
            chkEquipZY3.Checked = chkEquipZY3.Enabled;
            chkEquipZY4.Checked = chkEquipZY4.Enabled;
            chkEquipZY5.Checked = chkEquipZY5.Enabled;
            chkEquipZY6.Checked = chkEquipZY6.Enabled;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chkEquipZY1.Checked = false;
            chkEquipZY2.Checked = false;
            chkEquipZY3.Checked = false;
            chkEquipZY4.Checked = false;
            chkEquipZY5.Checked = false;
            chkEquipZY6.Checked = false;
        }

        protected bool loadItemTypes(IList itemTypes)
        {
            itemTypes.Clear();
            try
            {
                itemTypes.Add(new EquipItemType(0, "剑刃类"));
                itemTypes.Add(new EquipItemType(1, "斧头类"));
                itemTypes.Add(new EquipItemType(2, "锤/权杖"));
                itemTypes.Add(new EquipItemType(3, "矛/镰刀"));
                itemTypes.Add(new EquipItemType(4, "弓/弩类"));
                itemTypes.Add(new EquipItemType(5, "法杖类"));
                itemTypes.Add(new EquipItemType(6, "盾牌类"));
                itemTypes.Add(new EquipItemType(7, "头盔类"));
                itemTypes.Add(new EquipItemType(8, "铠甲类"));
                itemTypes.Add(new EquipItemType(9, "护腿类"));
                itemTypes.Add(new EquipItemType(10, "护手类"));
                itemTypes.Add(new EquipItemType(11, "靴子类"));
                itemTypes.Add(new EquipItemType(12, "翅膀/宝石/卷轴"));
                itemTypes.Add(new EquipItemType(13, "守护/首饰/其他"));
                itemTypes.Add(new EquipItemType(14, "药水/消耗"));
                itemTypes.Add(new EquipItemType(15, "技能书类"));
                return true;
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "itemTypes.Add：\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
                Application.Exit();
            }
            return false;
        }

        private void cboEquipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                EquipItemType equipItemType = (EquipItemType)cboEquipType.SelectedItem;
                equipItemType.ItemNames = new ArrayList();
                loadItemNamesByType(equipItemType.ItemNames, cboEquipType.SelectedIndex, cbZhiye.SelectedIndex);
                cboEquipName.Items.Clear();
                foreach (object obj in equipItemType.ItemNames)
                {
                    string item = (string)obj;
                    cboEquipName.Items.Add(item);
                }
                if ((cbZhiye.SelectedIndex != 4 || cboEquipType.SelectedIndex != 2) && (cbZhiye.SelectedIndex != 7 || cboEquipType.SelectedIndex != 5) && (cbZhiye.SelectedIndex != 7 || cboEquipType.SelectedIndex != 1))
                {
                    cboEquipName.SelectedIndex = 0;
                }
                EquipItem item2 = EquipImageCache.Instance.getItem(cboEquipName.Text);
                if (item2 != null)
                {
                    if (editItem == null)
                    {
                        editItem = new EquipItem();
                    }
                    editItem.assign(item2);
                }
                SetUIbyCob(item2);
                cboPlusType.SelectedIndex = 0;
                cboPlusLevel.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "Error:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
        }

        protected bool loadItemNamesByType(IList itemNames, int index, int type)
        {
            itemTypes.Clear();
            cboEquipName.Items.Clear();
            try
            {
                for (int i = 0; i < EquipEditor.xItem.Length; i++)
                {
                    if (EquipEditor.xItem[i] != null && (int)EquipEditor.xItem[i].Group == index)
                    {
                        switch (type)
                        {
                            case 1:
                                if (EquipEditor.xItem[i].iClassNumber.WIZARD != 0)
                                {
                                    itemNames.Add(frmMain.ByteToString(EquipEditor.xItem[i].Name, 30));
                                }
                                break;
                            case 2:
                                if (EquipEditor.xItem[i].iClassNumber.KNIGHT != 0)
                                {
                                    itemNames.Add(frmMain.ByteToString(EquipEditor.xItem[i].Name, 30));
                                }
                                break;
                            case 3:
                                if (EquipEditor.xItem[i].iClassNumber.ELF != 0)
                                {
                                    itemNames.Add(frmMain.ByteToString(EquipEditor.xItem[i].Name, 30));
                                }
                                break;
                            case 4:
                                if (EquipEditor.xItem[i].iClassNumber.MAGUMSA != 0)
                                {
                                    itemNames.Add(frmMain.ByteToString(EquipEditor.xItem[i].Name, 30));
                                }
                                break;
                            case 5:
                                if (EquipEditor.xItem[i].iClassNumber.DARKLORD != 0)
                                {
                                    itemNames.Add(frmMain.ByteToString(EquipEditor.xItem[i].Name, 30));
                                }
                                break;
                            case 6:
                                if (EquipEditor.xItem[i].iClassNumber.SUMMONER != 0)
                                {
                                    itemNames.Add(frmMain.ByteToString(EquipEditor.xItem[i].Name, 30));
                                }
                                break;
                            case 7:
                                if (EquipEditor.xItem[i].iClassNumber.MONK != 0)
                                {
                                    itemNames.Add(frmMain.ByteToString(EquipEditor.xItem[i].Name, 30));
                                }
                                break;
                            default:
                                itemNames.Add(frmMain.ByteToString(EquipEditor.xItem[i].Name, 30));
                                break;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "loadItemNamesByType：\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
            return false;
        }

        [DllImport("USER32.dll")]
        private static extern int SendMessageA(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);

        public void updateUI(EquipItem item)
        {
            try
            {
                cbZhiye.SelectedIndex = 0;
                cboEquipType.SelectedIndex = (int)item.Type;
                cboEquipName.Text = item.Name;
                cboEquipLevel.SelectedIndex = (int)item.Level;
                cboEquipExt.SelectedIndex = item.Ext;
                if (item.PlusType < cboPlusType.Items.Count)
                {
                    cboPlusType.SelectedIndex = item.PlusType;
                }
                if (item.PlusLevel < cboPlusLevel.Items.Count)
                {
                    cboPlusLevel.SelectedIndex = item.PlusLevel;
                }
                chkEquipJN.Checked = item.JN;
                chkEquipXY.Checked = item.XY;
                chkEquipZY1.Checked = item.ZY1;
                chkEquipZY2.Checked = item.ZY2;
                chkEquipZY3.Checked = item.ZY3;
                chkEquipZY4.Checked = item.ZY4;
                chkEquipZY5.Checked = item.ZY5;
                chkEquipZY6.Checked = item.ZY6;
                cbSetVal.SelectedItem = string.Concat(item.SetVal);
                chk380.Checked = item.Is380;
                txtDurability.Text = Convert.ToString(item.Durability);
                txtCode.Text = "H:" + item.ToString();
                if (gbXQ.Enabled)
                {
                    cboPlusType.SelectedIndex = 0;
                    cboPlusLevel.SelectedIndex = 0;
                    byte itemKindA = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindA;
                    byte itemKindB = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindB;
                    byte itemCategory = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemCategory;
                    if (itemKindA == 8)
                    {
                        if (itemKindB == 0)
                        {
                            if (item.XQ1 == 255)
                            {
                                cbInlay1b.SelectedIndex = 0;
                            }
                            else if (item.XQ1 == 0)
                            {
                                cbInlay1b.SelectedIndex = 0;
                            }
                            if (item.XQ2 == 255)
                            {
                                cbInlay2b.SelectedIndex = 0;
                            }
                            else if (item.XQ2 == 0)
                            {
                                cbInlay2b.SelectedIndex = 0;
                            }
                            if (item.XQ3 == 255)
                            {
                                cbInlay3b.SelectedIndex = 0;
                            }
                            else if (item.XQ3 == 0)
                            {
                                cbInlay3b.SelectedIndex = 0;
                            }
                            if (item.XQ4 == 255)
                            {
                                cbInlay4b.SelectedIndex = 0;
                            }
                            else if (item.XQ4 == 0)
                            {
                                cbInlay4b.SelectedIndex = 0;
                            }
                            if (item.XQ5 == 255)
                            {
                                cbInlay5b.SelectedIndex = 0;
                            }
                            else if (item.XQ5 == 0)
                            {
                                cbInlay5b.SelectedIndex = 0;
                            }
                        }
                        else if (itemKindB == 43)
                        {
                            if (item.XQ1 == 255)
                            {
                                cbInlay1b.SelectedIndex = 0;
                            }
                            else if (item.XQ1 == 254)
                            {
                                cbInlay1b.SelectedIndex = 1;
                            }
                            else
                            {
                                cbInlay1b.SelectedIndex = 2;
                            }
                            if (item.XQ2 == 255)
                            {
                                cbInlay2b.SelectedIndex = 0;
                            }
                            else if (item.XQ2 == 254)
                            {
                                cbInlay2b.SelectedIndex = 1;
                            }
                            else
                            {
                                cbInlay2b.SelectedIndex = 2;
                            }
                            if (item.XQ3 == 255)
                            {
                                cbInlay3b.SelectedIndex = 0;
                            }
                            else if (item.XQ3 == 254)
                            {
                                cbInlay3b.SelectedIndex = 1;
                            }
                            else
                            {
                                cbInlay3b.SelectedIndex = 2;
                            }
                            if (item.XQ4 == 255)
                            {
                                cbInlay4b.SelectedIndex = 0;
                            }
                            else if (item.XQ4 == 254)
                            {
                                cbInlay4b.SelectedIndex = 1;
                            }
                            else
                            {
                                cbInlay4b.SelectedIndex = 2;
                            }
                            if (item.XQ5 == 255)
                            {
                                cbInlay5b.SelectedIndex = 0;
                            }
                            else if (item.XQ5 == 254)
                            {
                                cbInlay5b.SelectedIndex = 1;
                            }
                            else
                            {
                                cbInlay5b.SelectedIndex = 2;
                            }
                        }
                        else if (itemKindB == 44)
                        {
                            if (item.XQ1 == 255)
                            {
                                cbInlay1b.SelectedIndex = 0;
                            }
                            else if (item.XQ1 == 17)
                            {
                                cbInlay1b.SelectedIndex = 1;
                            }
                            else if (item.XQ1 == 33)
                            {
                                cbInlay1b.SelectedIndex = 2;
                            }
                            else if (item.XQ1 == 49)
                            {
                                cbInlay1b.SelectedIndex = 3;
                            }
                            else if (item.XQ1 == 65)
                            {
                                cbInlay1b.SelectedIndex = 4;
                            }
                            else if (item.XQ1 == 81)
                            {
                                cbInlay1b.SelectedIndex = 5;
                            }
                            else if (item.XQ1 == 97)
                            {
                                cbInlay1b.SelectedIndex = 6;
                            }
                            else if (item.XQ1 == 113)
                            {
                                cbInlay1b.SelectedIndex = 7;
                            }
                            else if (item.XQ1 == 129)
                            {
                                cbInlay1b.SelectedIndex = 8;
                            }
                            else if (item.XQ1 == 145)
                            {
                                cbInlay1b.SelectedIndex = 9;
                            }
                            else
                            {
                                cbInlay1b.SelectedIndex = 10;
                            }
                            if (item.XQ2 == 255)
                            {
                                cbInlay2b.SelectedIndex = 0;
                            }
                            else if (item.XQ2 == 17)
                            {
                                cbInlay2b.SelectedIndex = 1;
                            }
                            else if (item.XQ2 == 33)
                            {
                                cbInlay2b.SelectedIndex = 2;
                            }
                            else if (item.XQ2 == 49)
                            {
                                cbInlay2b.SelectedIndex = 3;
                            }
                            else if (item.XQ2 == 65)
                            {
                                cbInlay2b.SelectedIndex = 4;
                            }
                            else if (item.XQ2 == 81)
                            {
                                cbInlay2b.SelectedIndex = 5;
                            }
                            else if (item.XQ2 == 97)
                            {
                                cbInlay2b.SelectedIndex = 6;
                            }
                            else if (item.XQ2 == 113)
                            {
                                cbInlay2b.SelectedIndex = 7;
                            }
                            else if (item.XQ2 == 129)
                            {
                                cbInlay2b.SelectedIndex = 8;
                            }
                            else if (item.XQ2 == 145)
                            {
                                cbInlay2b.SelectedIndex = 9;
                            }
                            else
                            {
                                cbInlay2b.SelectedIndex = 10;
                            }
                            if (item.XQ3 == 255)
                            {
                                cbInlay3b.SelectedIndex = 0;
                            }
                            else if (item.XQ3 == 17)
                            {
                                cbInlay3b.SelectedIndex = 1;
                            }
                            else if (item.XQ3 == 33)
                            {
                                cbInlay3b.SelectedIndex = 2;
                            }
                            else if (item.XQ3 == 49)
                            {
                                cbInlay3b.SelectedIndex = 3;
                            }
                            else if (item.XQ3 == 65)
                            {
                                cbInlay3b.SelectedIndex = 4;
                            }
                            else if (item.XQ3 == 81)
                            {
                                cbInlay3b.SelectedIndex = 5;
                            }
                            else if (item.XQ3 == 97)
                            {
                                cbInlay3b.SelectedIndex = 6;
                            }
                            else if (item.XQ3 == 113)
                            {
                                cbInlay3b.SelectedIndex = 7;
                            }
                            else if (item.XQ3 == 129)
                            {
                                cbInlay3b.SelectedIndex = 8;
                            }
                            else if (item.XQ3 == 145)
                            {
                                cbInlay3b.SelectedIndex = 9;
                            }
                            else
                            {
                                cbInlay3b.SelectedIndex = 10;
                            }
                            if (item.XQ4 == 255)
                            {
                                cbInlay4b.SelectedIndex = 0;
                            }
                            else if (item.XQ4 == 17)
                            {
                                cbInlay4b.SelectedIndex = 1;
                            }
                            else if (item.XQ4 == 33)
                            {
                                cbInlay4b.SelectedIndex = 2;
                            }
                            else if (item.XQ4 == 49)
                            {
                                cbInlay4b.SelectedIndex = 3;
                            }
                            else if (item.XQ4 == 65)
                            {
                                cbInlay4b.SelectedIndex = 4;
                            }
                            else if (item.XQ4 == 81)
                            {
                                cbInlay4b.SelectedIndex = 5;
                            }
                            else if (item.XQ4 == 97)
                            {
                                cbInlay4b.SelectedIndex = 6;
                            }
                            else if (item.XQ4 == 113)
                            {
                                cbInlay4b.SelectedIndex = 7;
                            }
                            else if (item.XQ4 == 129)
                            {
                                cbInlay4b.SelectedIndex = 8;
                            }
                            else if (item.XQ4 == 145)
                            {
                                cbInlay4b.SelectedIndex = 9;
                            }
                            else
                            {
                                cbInlay4b.SelectedIndex = 10;
                            }
                            if (item.XQ5 == 255)
                            {
                                cbInlay5b.SelectedIndex = 0;
                            }
                            else if (item.XQ5 == 17)
                            {
                                cbInlay5b.SelectedIndex = 1;
                            }
                            else if (item.XQ5 == 33)
                            {
                                cbInlay5b.SelectedIndex = 2;
                            }
                            else if (item.XQ5 == 49)
                            {
                                cbInlay5b.SelectedIndex = 3;
                            }
                            else if (item.XQ5 == 65)
                            {
                                cbInlay5b.SelectedIndex = 4;
                            }
                            else if (item.XQ5 == 81)
                            {
                                cbInlay5b.SelectedIndex = 5;
                            }
                            else if (item.XQ5 == 97)
                            {
                                cbInlay5b.SelectedIndex = 6;
                            }
                            else if (item.XQ5 == 113)
                            {
                                cbInlay5b.SelectedIndex = 7;
                            }
                            else if (item.XQ5 == 129)
                            {
                                cbInlay5b.SelectedIndex = 8;
                            }
                            else if (item.XQ5 == 145)
                            {
                                cbInlay5b.SelectedIndex = 9;
                            }
                            else
                            {
                                cbInlay5b.SelectedIndex = 10;
                            }
                        }
                        Trace.WriteLine("item.YG : " + (int)(item.YG - 17));
                        if (item.YG >= 0 && (int)(item.YG - 17) < Utils.YSS.Length)
                        {
                            cbInlay6b.SelectedIndex = (int)(item.YG - 17);
                        }
                        else
                        {
                            cbInlay6b.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        if (item.XQ1 == 255)
                        {
                            cbInlay1b.SelectedIndex = 0;
                        }
                        else if (item.XQ1 == 254)
                        {
                            cbInlay1b.SelectedIndex = 1;
                        }
                        else
                        {
                            int num = (int)(item.XQ1 % 50);
                            int num2 = ((int)item.XQ1 - num) / 50;
                            string lParam = frmMain.ByteToString(EquipEditor.xSocket[num].byte_0, 64) + " +" + EquipEditor.xSocket[num].uint_4[num2].ToString();
                            cbInlay1b.SelectedIndex = EquipEditor.SendMessageA(cbInlay1b.Handle, 332, IntPtr.Zero, lParam);
                        }
                        if (item.XQ2 == 255)
                        {
                            cbInlay2b.SelectedIndex = 0;
                        }
                        else if (item.XQ2 == 254)
                        {
                            cbInlay2b.SelectedIndex = 1;
                        }
                        else
                        {
                            int num3 = (int)(item.XQ2 % 50);
                            int num4 = ((int)item.XQ2 - num3) / 50;
                            string lParam2 = frmMain.ByteToString(EquipEditor.xSocket[num3].byte_0, 64) + " +" + EquipEditor.xSocket[num3].uint_4[num4].ToString();
                            cbInlay2b.SelectedIndex = EquipEditor.SendMessageA(cbInlay2b.Handle, 332, IntPtr.Zero, lParam2);
                        }
                        if (item.XQ3 == 255)
                        {
                            cbInlay3b.SelectedIndex = 0;
                        }
                        else if (item.XQ3 == 254)
                        {
                            cbInlay3b.SelectedIndex = 1;
                        }
                        else
                        {
                            int num5 = (int)(item.XQ3 % 50);
                            int num6 = ((int)item.XQ3 - num5) / 50;
                            string lParam3 = frmMain.ByteToString(EquipEditor.xSocket[num5].byte_0, 64) + " +" + EquipEditor.xSocket[num5].uint_4[num6].ToString();
                            cbInlay3b.SelectedIndex = EquipEditor.SendMessageA(cbInlay3b.Handle, 332, IntPtr.Zero, lParam3);
                        }
                        if (item.XQ4 == 255)
                        {
                            cbInlay4b.SelectedIndex = 0;
                        }
                        else if (item.XQ4 == 254)
                        {
                            cbInlay4b.SelectedIndex = 1;
                        }
                        else
                        {
                            int num7 = (int)(item.XQ4 % 50);
                            int num8 = ((int)item.XQ4 - num7) / 50;
                            string lParam4 = frmMain.ByteToString(EquipEditor.xSocket[num7].byte_0, 64) + " +" + EquipEditor.xSocket[num7].uint_4[num8].ToString();
                            cbInlay4b.SelectedIndex = EquipEditor.SendMessageA(cbInlay4b.Handle, 332, IntPtr.Zero, lParam4);
                        }
                        if (item.XQ5 == 255)
                        {
                            cbInlay5b.SelectedIndex = 0;
                        }
                        else if (item.XQ5 == 254)
                        {
                            cbInlay5b.SelectedIndex = 1;
                        }
                        else
                        {
                            int num9 = (int)(item.XQ5 % 50);
                            int num10 = ((int)item.XQ5 - num9) / 50;
                            string lParam5 = frmMain.ByteToString(EquipEditor.xSocket[num9].byte_0, 64) + " +" + EquipEditor.xSocket[num9].uint_4[num10].ToString();
                            cbInlay5b.SelectedIndex = EquipEditor.SendMessageA(cbInlay5b.Handle, 332, IntPtr.Zero, lParam5);
                        }
                        if (item.YG >= 0 && (int)item.YG < Utils.YGS.Length - 1)
                        {
                            cbInlay6b.SelectedIndex = (int)(item.YG + 1);
                        }
                        else
                        {
                            cbInlay6b.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "Error:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
        }

        public void updateData(EquipItem item)
        {
            item.Level = (byte)cboEquipLevel.SelectedIndex;
            item.Ext = cboEquipExt.SelectedIndex;
            item.PlusType = (int)((byte)cboPlusType.SelectedIndex);
            item.PlusLevel = (int)((byte)((cboPlusType.SelectedIndex <= 0) ? 0 : cboPlusLevel.SelectedIndex));
            item.JN = (chkEquipJN.Checked && chkEquipJN.Enabled);
            item.XY = (chkEquipXY.Checked && chkEquipXY.Enabled);
            item.ZY1 = (chkEquipZY1.Checked && chkEquipZY1.Enabled);
            item.ZY2 = (chkEquipZY2.Checked && chkEquipZY2.Enabled);
            item.ZY3 = (chkEquipZY3.Checked && chkEquipZY3.Enabled);
            item.ZY4 = (chkEquipZY4.Checked && chkEquipZY4.Enabled);
            item.ZY5 = (chkEquipZY5.Checked && chkEquipZY5.Enabled);
            item.ZY6 = (chkEquipZY6.Checked && chkEquipZY6.Enabled);
            item.IsSet = (cbSetVal.SelectedIndex > 0 && cbSetVal.Enabled);
            item.SetVal = (cbSetVal.Enabled ? Convert.ToByte(cbSetVal.SelectedItem) : (byte)0);
            item.Is380 = (chk380.Checked && chk380.Enabled);
            item.Durability = Convert.ToByte(txtDurability.Text);
            if (gbXQ.Enabled)
            {
                item.PlusType = 0;
                item.PlusLevel = 0;
                byte itemKindA = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindA;
                byte itemKindB = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindB;
                byte itemCategory = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemCategory;
                if (itemKindA == 8)
                {
                    ComboBoxItem comboBoxItem = (ComboBoxItem)cbInlay1b.SelectedItem;
                    item.XQ1 = Convert.ToByte(comboBoxItem.Value);
                    ComboBoxItem comboBoxItem2 = (ComboBoxItem)cbInlay2b.SelectedItem;
                    item.XQ2 = Convert.ToByte(comboBoxItem2.Value);
                    ComboBoxItem comboBoxItem3 = (ComboBoxItem)cbInlay3b.SelectedItem;
                    item.XQ3 = Convert.ToByte(comboBoxItem3.Value);
                    ComboBoxItem comboBoxItem4 = (ComboBoxItem)cbInlay4b.SelectedItem;
                    item.XQ4 = Convert.ToByte(comboBoxItem4.Value);
                    ComboBoxItem comboBoxItem5 = (ComboBoxItem)cbInlay5b.SelectedItem;
                    item.XQ5 = Convert.ToByte(comboBoxItem5.Value);
                    item.YG = (byte)(cbInlay6b.SelectedIndex + 17);
                    return;
                }
                ComboBoxItem comboBoxItem6 = (ComboBoxItem)cbInlay1b.SelectedItem;
                item.XQ1 = Convert.ToByte(comboBoxItem6.Value);
                ComboBoxItem comboBoxItem7 = (ComboBoxItem)cbInlay2b.SelectedItem;
                item.XQ2 = Convert.ToByte(comboBoxItem7.Value);
                ComboBoxItem comboBoxItem8 = (ComboBoxItem)cbInlay3b.SelectedItem;
                item.XQ3 = Convert.ToByte(comboBoxItem8.Value);
                ComboBoxItem comboBoxItem9 = (ComboBoxItem)cbInlay4b.SelectedItem;
                item.XQ4 = Convert.ToByte(comboBoxItem9.Value);
                ComboBoxItem comboBoxItem10 = (ComboBoxItem)cbInlay5b.SelectedItem;
                item.XQ5 = Convert.ToByte(comboBoxItem10.Value);
                item.YG = ((cbInlay6b.SelectedIndex > 0) ? ((byte)(cbInlay6b.SelectedIndex - 1)) : byte.MaxValue);
            }
        }

        public void LoadData()
        {
            try
            {
                loadItemTypes(itemTypes);
                cboEquipType.Items.Clear();
                foreach (object obj in itemTypes)
                {
                    EquipItemType item = (EquipItemType)obj;
                    cboEquipType.Items.Add(item);
                }
                cboEquipType.SelectedIndex = 0;
                cboEquipLevel.SelectedIndex = 0;
                cboEquipExt.SelectedIndex = 0;
                cbZhiye.SelectedIndex = 0;
                cboPlusType.SelectedIndex = 0;
                cboPlusLevel.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Utils.WarningMessage("数据库连接错误，错误信息：" + ex.Message);
            }
        }

        private void EquipEditor_Load(object sender, EventArgs e)
        {
            txtDurability.Text = Convert.ToString(defDurability);
        }

        private void Init_EquipEditor()
        {
            cbInlay1b.Items.Clear();
            cbInlay2b.Items.Clear();
            cbInlay3b.Items.Clear();
            cbInlay4b.Items.Clear();
            cbInlay5b.Items.Clear();
            cbInlay1b.Items.Add(new ComboBoxItem("未开孔", "255"));
            cbInlay1b.Items.Add(new ComboBoxItem("无属性", "254"));
            for (int i = 0; i < 50; i++)
            {
                if (EquipEditor.xSocket[i].byte_0[0] != 0)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        string text = frmMain.ByteToString(EquipEditor.xSocket[i].byte_0, 64) + " +" + EquipEditor.xSocket[i].uint_4[j].ToString();
                        string value = (i + j * 50).ToString();
                        cbInlay1b.Items.Add(new ComboBoxItem(text, value));
                    }
                }
            }
            cbInlay2b.Items.Add(new ComboBoxItem("未开孔", "255"));
            cbInlay2b.Items.Add(new ComboBoxItem("无属性", "254"));
            for (int k = 0; k < 50; k++)
            {
                if (EquipEditor.xSocket[k].byte_0[0] != 0)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        string text2 = frmMain.ByteToString(EquipEditor.xSocket[k].byte_0, 64) + " +" + EquipEditor.xSocket[k].uint_4[l].ToString();
                        string value2 = (k + l * 50).ToString();
                        cbInlay2b.Items.Add(new ComboBoxItem(text2, value2));
                    }
                }
            }
            cbInlay3b.Items.Add(new ComboBoxItem("未开孔", "255"));
            cbInlay3b.Items.Add(new ComboBoxItem("无属性", "254"));
            for (int m = 0; m < 50; m++)
            {
                if (EquipEditor.xSocket[m].byte_0[0] != 0)
                {
                    for (int n = 0; n < 5; n++)
                    {
                        string text3 = frmMain.ByteToString(EquipEditor.xSocket[m].byte_0, 64) + " +" + EquipEditor.xSocket[m].uint_4[n].ToString();
                        string value3 = (m + n * 50).ToString();
                        cbInlay3b.Items.Add(new ComboBoxItem(text3, value3));
                    }
                }
            }
            cbInlay4b.Items.Add(new ComboBoxItem("未开孔", "255"));
            cbInlay4b.Items.Add(new ComboBoxItem("无属性", "254"));
            for (int num = 0; num < 50; num++)
            {
                if (EquipEditor.xSocket[num].byte_0[0] != 0)
                {
                    for (int num2 = 0; num2 < 5; num2++)
                    {
                        string text4 = frmMain.ByteToString(EquipEditor.xSocket[num].byte_0, 64) + " +" + EquipEditor.xSocket[num].uint_4[num2].ToString();
                        string value4 = (num + num2 * 50).ToString();
                        cbInlay4b.Items.Add(new ComboBoxItem(text4, value4));
                    }
                }
            }
            cbInlay5b.Items.Add(new ComboBoxItem("未开孔", "255"));
            cbInlay5b.Items.Add(new ComboBoxItem("无属性", "254"));
            for (int num3 = 0; num3 < 50; num3++)
            {
                if (EquipEditor.xSocket[num3].byte_0[0] != 0)
                {
                    for (int num4 = 0; num4 < 5; num4++)
                    {
                        string text5 = frmMain.ByteToString(EquipEditor.xSocket[num3].byte_0, 64) + " +" + EquipEditor.xSocket[num3].uint_4[num4].ToString();
                        string value5 = (num3 + num4 * 50).ToString();
                        cbInlay5b.Items.Add(new ComboBoxItem(text5, value5));
                    }
                }
            }
            cbInlay1b.SelectedIndex = 0;
            cbInlay2b.SelectedIndex = 0;
            cbInlay3b.SelectedIndex = 0;
            cbInlay4b.SelectedIndex = 0;
            cbInlay5b.SelectedIndex = 0;
            cbInlay6b.Items.Clear();
            for (int num5 = 0; num5 < Utils.YGS.Length; num5++)
            {
                cbInlay6b.Items.Add(new ComboBoxItem(Utils.YGS[num5], num5.ToString()));
            }
            cbInlay6b.SelectedIndex = 0;
            cbSetVal.SelectedIndex = 0;
            cboPlusType.SelectedIndex = 0;
            cboPlusLevel.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chkEquipZY1.Checked = Utils.JPZY1;
            chkEquipZY2.Checked = Utils.JPZY2;
            chkEquipZY3.Checked = Utils.JPZY3;
            chkEquipZY4.Checked = Utils.JPZY4;
            chkEquipZY5.Checked = Utils.JPZY5;
            chkEquipZY6.Checked = Utils.JPZY6;
            cboEquipLevel.SelectedIndex = Utils.JPLevel;
            cboEquipExt.SelectedIndex = Utils.JPExt;
            chkEquipJN.Checked = Utils.JPJN;
            chkEquipXY.Checked = Utils.JPXY;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chkEquipZY1.Checked = Utils.DJZY1;
            chkEquipZY2.Checked = Utils.DJZY2;
            chkEquipZY3.Checked = Utils.DJZY3;
            chkEquipZY4.Checked = Utils.DJZY4;
            chkEquipZY5.Checked = Utils.DJZY5;
            chkEquipZY6.Checked = Utils.DJZY6;
            cboEquipLevel.SelectedIndex = Utils.DJLevel;
            cboEquipExt.SelectedIndex = Utils.DJExt;
            chkEquipJN.Checked = Utils.DJJN;
            chkEquipXY.Checked = Utils.DJXY;
        }

        private void setZY(int type)
        {
            if (type == 0)
            {
                chkEquipZY1.Text = "无";
                chkEquipZY2.Text = "无";
                chkEquipZY3.Text = "无";
                chkEquipZY4.Text = "无";
                chkEquipZY5.Text = "无";
                chkEquipZY6.Text = "无";
                return;
            }
            if (type == 1)
            {
                chkEquipZY1.Text = "+魔法值/8";
                chkEquipZY2.Text = "+生命值/8";
                chkEquipZY3.Text = "+速度+7";
                chkEquipZY4.Text = "+2%攻击";
                chkEquipZY5.Text = "等级/20攻击";
                chkEquipZY6.Text = "卓越一击";
                return;
            }
            if (type == 2)
            {
                chkEquipZY1.Text = "金钱 +30%";
                chkEquipZY2.Text = "防御 +10%";
                chkEquipZY3.Text = "反伤";
                chkEquipZY4.Text = "减伤";
                chkEquipZY5.Text = "魔法 +4%";
                chkEquipZY6.Text = "生命 +4%";
                return;
            }
            if (type == 3)
            {
                chkEquipZY1.Text = "加生";
                chkEquipZY2.Text = "加魔";
                chkEquipZY3.Text = "无视";
                chkEquipZY4.Text = "技能最大值";
                chkEquipZY5.Text = "加速";
                chkEquipZY6.Text = "追/回";
                return;
            }
            if (type == 4)
            {
                chkEquipZY1.Text = "无视";
                chkEquipZY2.Text = "反弹攻击";
                chkEquipZY3.Text = "恢复生命";
                chkEquipZY4.Text = "恢复魔法";
                chkEquipZY5.Text = "追/回";
                chkEquipZY6.Text = "追/回";
                return;
            }
            if (type == 5)
            {
                chkEquipZY1.Text = "生命 +50";
                chkEquipZY2.Text = "魔法 +50";
                chkEquipZY3.Text = "无视";
                chkEquipZY4.Text = "追加统率";
                chkEquipZY5.Text = "无";
                chkEquipZY6.Text = "无";
                return;
            }
            if (type == 6)
            {
                chkEquipZY1.Text = "黑狼";
                chkEquipZY2.Text = "青狼";
                chkEquipZY3.Text = "金狼";
                chkEquipZY4.Text = "无";
                chkEquipZY5.Text = "无";
                chkEquipZY6.Text = "无";
            }
        }

        private void cboEquipName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = cboEquipName.Text;
            if (text != null && !("" == text.Trim()))
            {
                EquipItem item = EquipImageCache.Instance.getItem(cboEquipName.Text);
                if (item != null)
                {
                    if (editItem == null)
                    {
                        editItem = new EquipItem();
                    }
                    editItem.assign(item);
                }
                SetUIbyCob(item);
                cboPlusType.SelectedIndex = 0;
                return;
            }
        }

        public void SetUIbyCob(EquipItem item)
        {
            gbXQ.Enabled = Utils.GetQX(item);
            chkAllPart.Enabled = (item.Type >= 7 && item.Type <= 11);
            chkEquipXY.Enabled = (item.Type >= 0 && item.Type <= 11);
            cbSetVal.Enabled = chkEquipXY.Enabled;
            chk380.Enabled = Utils.Get380(item);
            chk380.Checked = chk380.Enabled;
            chkEquipJN.Enabled = Utils.GetJN(item);
            if (item.Type == 5)
            {
                txtDurability.Text = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].MagicDur.ToString();
            }
            else
            {
                txtDurability.Text = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].Dur.ToString();
            }
            if (item.Type >= 0 && item.Type <= 5)
            {
                setZY(1);
                if (item.IsFZ)
                {
                    Utils.GetPlusType(cboPlusType, 3);
                }
                else
                {
                    Utils.GetPlusType(cboPlusType, 1);
                }
            }
            else if (item.Type >= 6 && item.Type <= 11)
            {
                setZY(2);
                Utils.GetPlusType(cboPlusType, 2);
            }
            else
            {
                Utils.GetPlusType(cboPlusType, 0);
            }
            Init_EquipEditor();
            byte itemKindA = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindA;
            byte itemKindB = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindB;
            byte itemCategory = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemCategory;
            switch (item.Type)
            {
                case 12:
                    cbInlay6b.Items.Clear();
                    if (itemKindA == 8)
                    {
                        if (itemKindB == 0)
                        {
                            cbInlay1b.Items.Clear();
                            cbInlay1b.Items.Add(new ComboBoxItem("无属性", "0"));
                            cbInlay2b.Items.Clear();
                            cbInlay2b.Items.Add(new ComboBoxItem("无属性", "0"));
                            cbInlay3b.Items.Clear();
                            cbInlay3b.Items.Add(new ComboBoxItem("无属性", "0"));
                            cbInlay4b.Items.Clear();
                            cbInlay4b.Items.Add(new ComboBoxItem("无属性", "0"));
                            cbInlay5b.Items.Clear();
                            cbInlay5b.Items.Add(new ComboBoxItem("无属性", "0"));
                        }
                        else if (itemKindB == 43)
                        {
                            cbInlay1b.Items.Clear();
                            cbInlay1b.Items.Add(new ComboBoxItem("未开孔", "255"));
                            cbInlay1b.Items.Add(new ComboBoxItem("愤怒的元素之魂", "254"));
                            cbInlay1b.Items.Add(new ComboBoxItem("愤怒的元素之魂(镶嵌)", "0"));
                            cbInlay2b.Items.Clear();
                            cbInlay2b.Items.Add(new ComboBoxItem("未开孔", "255"));
                            cbInlay2b.Items.Add(new ComboBoxItem("庇护的元素之魂", "254"));
                            cbInlay2b.Items.Add(new ComboBoxItem("庇护的元素之魂(镶嵌)", "1"));
                            cbInlay3b.Items.Clear();
                            cbInlay3b.Items.Add(new ComboBoxItem("未开孔", "255"));
                            cbInlay3b.Items.Add(new ComboBoxItem("高贵的元素之魂", "254"));
                            cbInlay3b.Items.Add(new ComboBoxItem("高贵的元素之魂(镶嵌)", "2"));
                            cbInlay4b.Items.Clear();
                            cbInlay4b.Items.Add(new ComboBoxItem("未开孔", "255"));
                            cbInlay4b.Items.Add(new ComboBoxItem("神圣的元素之魂", "254"));
                            cbInlay4b.Items.Add(new ComboBoxItem("神圣的元素之魂(镶嵌)", "3"));
                            cbInlay5b.Items.Clear();
                            cbInlay5b.Items.Add(new ComboBoxItem("未开孔", "255"));
                            cbInlay5b.Items.Add(new ComboBoxItem("狂喜的元素之魂", "254"));
                            cbInlay5b.Items.Add(new ComboBoxItem("狂喜的元素之魂(镶嵌)", "4"));
                        }
                        else if (itemKindB == 44)
                        {
                            cbInlay1b.Items.Clear();
                            cbInlay1b.Items.Add(new ComboBoxItem("无属性", "255"));
                            cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +1", "17"));
                            cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +2", "33"));
                            cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +3", "49"));
                            cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +4", "65"));
                            cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +5", "81"));
                            cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +6", "97"));
                            cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +7", "113"));
                            cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +8", "129"));
                            cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +9", "145"));
                            cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +10", "161"));
                            cbInlay2b.Items.Clear();
                            cbInlay2b.Items.Add(new ComboBoxItem("无属性", "255"));
                            cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +1", "17"));
                            cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +2", "33"));
                            cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +3", "49"));
                            cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +4", "65"));
                            cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +5", "81"));
                            cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +6", "97"));
                            cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +7", "113"));
                            cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +8", "129"));
                            cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +9", "145"));
                            cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +10", "161"));
                            cbInlay3b.Items.Clear();
                            cbInlay3b.Items.Add(new ComboBoxItem("无属性", "255"));
                            cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +1", "17"));
                            cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +2", "33"));
                            cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +3", "49"));
                            cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +4", "65"));
                            cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +5", "81"));
                            cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +6", "97"));
                            cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +7", "113"));
                            cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +8", "129"));
                            cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +9", "145"));
                            cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +10", "161"));
                            cbInlay4b.Items.Clear();
                            cbInlay4b.Items.Add(new ComboBoxItem("无属性", "255"));
                            cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +1", "17"));
                            cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +2", "33"));
                            cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +3", "49"));
                            cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +4", "65"));
                            cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +5", "81"));
                            cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +6", "97"));
                            cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +7", "113"));
                            cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +8", "129"));
                            cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +9", "145"));
                            cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +10", "161"));
                            cbInlay5b.Items.Clear();
                            cbInlay5b.Items.Add(new ComboBoxItem("无属性", "255"));
                            cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +1", "17"));
                            cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +2", "33"));
                            cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +3", "49"));
                            cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +4", "65"));
                            cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +5", "81"));
                            cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +6", "97"));
                            cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +7", "113"));
                            cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +8", "129"));
                            cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +9", "145"));
                            cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +10", "161"));
                        }
                        cbInlay1b.SelectedIndex = 0;
                        cbInlay2b.SelectedIndex = 0;
                        cbInlay3b.SelectedIndex = 0;
                        cbInlay4b.SelectedIndex = 0;
                        cbInlay5b.SelectedIndex = 0;
                        for (int i = 0; i < Utils.YSS.Length; i++)
                        {
                            cbInlay6b.Items.Add(new ComboBoxItem(Utils.YSS[i], i.ToString()));
                        }
                    }
                    else
                    {
                        for (int j = 0; j < Utils.YGS.Length; j++)
                        {
                            cbInlay6b.Items.Add(new ComboBoxItem(Utils.YGS[j], j.ToString()));
                        }
                    }
                    cbInlay6b.SelectedIndex = 0;
                    if (itemCategory == 1)
                    {
                        if (itemKindB == 23)
                        {
                            setZY(0);
                            chkEquipXY.Enabled = true;
                        }
                        else
                        {
                            if (itemKindB != 24)
                            {
                                if (itemKindB != 27)
                                {
                                    if (itemKindB != 25 && itemKindB != 28)
                                    {
                                        if (itemKindB != 60)
                                        {
                                            setZY(0);
                                            chkEquipXY.Enabled = false;
                                            break;
                                        }
                                    }
                                    setZY(4);
                                    chkEquipXY.Enabled = true;
                                    break;
                                }
                            }
                            setZY(3);
                            chkEquipXY.Enabled = true;
                        }
                    }
                    else
                    {
                        setZY(0);
                        chkEquipXY.Enabled = false;
                    }
                    break;
                case 13:
                    if (itemCategory == 1)
                    {
                        if (itemKindB == 26)
                        {
                            setZY(5);
                            chkEquipXY.Enabled = true;
                            cbSetVal.Enabled = false;
                        }
                        else
                        {
                            if (itemKindB != 29)
                            {
                                if (itemKindB != 30)
                                {
                                    if (itemKindB == 31)
                                    {
                                        setZY(2);
                                        cbSetVal.Enabled = true;
                                        break;
                                    }
                                    setZY(0);
                                    cbSetVal.Enabled = false;
                                    break;
                                }
                            }
                            setZY(1);
                            cbSetVal.Enabled = true;
                        }
                    }
                    else if (itemKindA == 5 && itemKindB == 46 && item.Code == 37)
                    {
                        setZY(6);
                        chkEquipJN.Enabled = true;
                    }
                    else
                    {
                        setZY(0);
                        cbSetVal.Enabled = false;
                    }
                    break;
                case 14:
                case 15:
                    setZY(0);
                    break;
            }
            chkEquipZY1.Enabled = (chkEquipZY1.Text != "无");
            chkEquipZY2.Enabled = (chkEquipZY2.Text != "无");
            chkEquipZY3.Enabled = (chkEquipZY3.Text != "无");
            chkEquipZY4.Enabled = (chkEquipZY4.Text != "无");
            chkEquipZY5.Enabled = (chkEquipZY5.Text != "无");
            chkEquipZY6.Enabled = (chkEquipZY6.Text != "无");
        }

        private void cboEquipName_KeyUp(object sender, KeyEventArgs e)
        {
            cboEquipName.DroppedDown = true;
        }
    }
}
