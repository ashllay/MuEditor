using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MuEditor
{
	// Token: 0x02000024 RID: 36
	public partial class EquipProperty : frmBase
	{
		// Token: 0x06000209 RID: 521 RVA: 0x000038F0 File Offset: 0x00001AF0
		public EquipProperty()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000038FE File Offset: 0x00001AFE
		public EquipProperty(EquipItem item)
		{
			this.InitializeComponent();
			this.item = item;
			this.updateUI(item);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00023E74 File Offset: 0x00022074
		private void Init_EquipEditor()
		{
			this.cbInlay1b.Items.Clear();
			this.cbInlay2b.Items.Clear();
			this.cbInlay3b.Items.Clear();
			this.cbInlay4b.Items.Clear();
			this.cbInlay5b.Items.Clear();
			this.cbInlay1b.Items.Add(new ComboBoxItem("未开孔", "255"));
			this.cbInlay1b.Items.Add(new ComboBoxItem("无属性", "254"));
			for (int i = 0; i < 50; i++)
			{
				if (EquipEditor.xSocket[i].byte_0[0] != 0)
				{
					for (int j = 0; j < 5; j++)
					{
						string text = frmMain.ByteToString(EquipEditor.xSocket[i].byte_0, 64) + " +" + EquipEditor.xSocket[i].uint_4[j].ToString();
						string value = (i + j * 50).ToString();
						this.cbInlay1b.Items.Add(new ComboBoxItem(text, value));
					}
				}
			}
			this.cbInlay2b.Items.Add(new ComboBoxItem("未开孔", "255"));
			this.cbInlay2b.Items.Add(new ComboBoxItem("无属性", "254"));
			for (int k = 0; k < 50; k++)
			{
				if (EquipEditor.xSocket[k].byte_0[0] != 0)
				{
					for (int l = 0; l < 5; l++)
					{
						string text2 = frmMain.ByteToString(EquipEditor.xSocket[k].byte_0, 64) + " +" + EquipEditor.xSocket[k].uint_4[l].ToString();
						string value2 = (k + l * 50).ToString();
						this.cbInlay2b.Items.Add(new ComboBoxItem(text2, value2));
					}
				}
			}
			this.cbInlay3b.Items.Add(new ComboBoxItem("未开孔", "255"));
			this.cbInlay3b.Items.Add(new ComboBoxItem("无属性", "254"));
			for (int m = 0; m < 50; m++)
			{
				if (EquipEditor.xSocket[m].byte_0[0] != 0)
				{
					for (int n = 0; n < 5; n++)
					{
						string text3 = frmMain.ByteToString(EquipEditor.xSocket[m].byte_0, 64) + " +" + EquipEditor.xSocket[m].uint_4[n].ToString();
						string value3 = (m + n * 50).ToString();
						this.cbInlay3b.Items.Add(new ComboBoxItem(text3, value3));
					}
				}
			}
			this.cbInlay4b.Items.Add(new ComboBoxItem("未开孔", "255"));
			this.cbInlay4b.Items.Add(new ComboBoxItem("无属性", "254"));
			for (int num = 0; num < 50; num++)
			{
				if (EquipEditor.xSocket[num].byte_0[0] != 0)
				{
					for (int num2 = 0; num2 < 5; num2++)
					{
						string text4 = frmMain.ByteToString(EquipEditor.xSocket[num].byte_0, 64) + " +" + EquipEditor.xSocket[num].uint_4[num2].ToString();
						string value4 = (num + num2 * 50).ToString();
						this.cbInlay4b.Items.Add(new ComboBoxItem(text4, value4));
					}
				}
			}
			this.cbInlay5b.Items.Add(new ComboBoxItem("未开孔", "255"));
			this.cbInlay5b.Items.Add(new ComboBoxItem("无属性", "254"));
			for (int num3 = 0; num3 < 50; num3++)
			{
				if (EquipEditor.xSocket[num3].byte_0[0] != 0)
				{
					for (int num4 = 0; num4 < 5; num4++)
					{
						string text5 = frmMain.ByteToString(EquipEditor.xSocket[num3].byte_0, 64) + " +" + EquipEditor.xSocket[num3].uint_4[num4].ToString();
						string value5 = (num3 + num4 * 50).ToString();
						this.cbInlay5b.Items.Add(new ComboBoxItem(text5, value5));
					}
				}
			}
			this.cbInlay1b.SelectedIndex = 0;
			this.cbInlay2b.SelectedIndex = 0;
			this.cbInlay3b.SelectedIndex = 0;
			this.cbInlay4b.SelectedIndex = 0;
			this.cbInlay5b.SelectedIndex = 0;
			this.cbInlay6b.Items.Clear();
			for (int num5 = 0; num5 < Utils.YGS.Length; num5++)
			{
				this.cbInlay6b.Items.Add(new ComboBoxItem(Utils.YGS[num5], num5.ToString()));
			}
			this.cbInlay6b.SelectedIndex = 0;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000243A8 File Offset: 0x000225A8
		private void button2_Click(object sender, EventArgs e)
		{
			this.chkEquipZY1.Checked = this.chkEquipZY1.Enabled;
			this.chkEquipZY2.Checked = this.chkEquipZY2.Enabled;
			this.chkEquipZY3.Checked = this.chkEquipZY3.Enabled;
			this.chkEquipZY4.Checked = this.chkEquipZY4.Enabled;
			this.chkEquipZY5.Checked = this.chkEquipZY5.Enabled;
			this.chkEquipZY6.Checked = this.chkEquipZY6.Enabled;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0002443C File Offset: 0x0002263C
		private void button3_Click(object sender, EventArgs e)
		{
			this.chkEquipZY1.Checked = false;
			this.chkEquipZY2.Checked = false;
			this.chkEquipZY3.Checked = false;
			this.chkEquipZY4.Checked = false;
			this.chkEquipZY5.Checked = false;
			this.chkEquipZY6.Checked = false;
		}

		// Token: 0x0600020E RID: 526
		[DllImport("USER32.dll")]
		private static extern int SendMessageA(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);

		// Token: 0x0600020F RID: 527 RVA: 0x00024494 File Offset: 0x00022694
		public void updateUI(EquipItem item)
		{
			this.SetUIbyCob(item);
			this.txtName.Text = item.Name;
			this.txtEquipCodes.Text = item.ToString();
			this.txtSN.Text = item.SN.ToString();
			this.cboEquipLevel.SelectedIndex = (int)item.Level;
			this.cboEquipExt.SelectedIndex = item.Ext;
			if (item.PlusType < this.cboPlusType.Items.Count)
			{
				this.cboPlusType.SelectedIndex = item.PlusType;
			}
			if (item.PlusLevel < this.cboPlusLevel.Items.Count)
			{
				this.cboPlusLevel.SelectedIndex = item.PlusLevel;
			}
			this.chkEquipJN.Checked = item.JN;
			this.chkEquipXY.Checked = item.XY;
			this.chkEquipZY1.Checked = item.ZY1;
			this.chkEquipZY2.Checked = item.ZY2;
			this.chkEquipZY3.Checked = item.ZY3;
			this.chkEquipZY4.Checked = item.ZY4;
			this.chkEquipZY5.Checked = item.ZY5;
			this.chkEquipZY6.Checked = item.ZY6;
			this.cbSetVal.SelectedItem = string.Concat(item.SetVal);
			this.chk380.Checked = item.Is380;
			this.txtDurability.Text = Convert.ToString(item.Durability);
			if (this.gbXQ.Enabled)
			{
				this.cboPlusType.SelectedIndex = 0;
				this.cboPlusLevel.SelectedIndex = 0;
				byte itemKindA = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindA;
				byte itemKindB = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindB;
				byte itemCategory = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemCategory;
				if (itemKindA == 8)
				{
					if (itemKindB == 0)
					{
						if (item.XQ1 == 255)
						{
							this.cbInlay1b.SelectedIndex = 0;
						}
						else if (item.XQ1 == 0)
						{
							this.cbInlay1b.SelectedIndex = 0;
						}
						if (item.XQ2 == 255)
						{
							this.cbInlay2b.SelectedIndex = 0;
						}
						else if (item.XQ2 == 0)
						{
							this.cbInlay2b.SelectedIndex = 0;
						}
						if (item.XQ3 == 255)
						{
							this.cbInlay3b.SelectedIndex = 0;
						}
						else if (item.XQ3 == 0)
						{
							this.cbInlay3b.SelectedIndex = 0;
						}
						if (item.XQ4 == 255)
						{
							this.cbInlay4b.SelectedIndex = 0;
						}
						else if (item.XQ4 == 0)
						{
							this.cbInlay4b.SelectedIndex = 0;
						}
						if (item.XQ5 == 255)
						{
							this.cbInlay5b.SelectedIndex = 0;
						}
						else if (item.XQ5 == 0)
						{
							this.cbInlay5b.SelectedIndex = 0;
						}
					}
					else if (itemKindB == 43)
					{
						if (item.XQ1 == 255)
						{
							this.cbInlay1b.SelectedIndex = 0;
						}
						else if (item.XQ1 == 254)
						{
							this.cbInlay1b.SelectedIndex = 1;
						}
						else
						{
							this.cbInlay1b.SelectedIndex = 2;
						}
						if (item.XQ2 == 255)
						{
							this.cbInlay2b.SelectedIndex = 0;
						}
						else if (item.XQ2 == 254)
						{
							this.cbInlay2b.SelectedIndex = 1;
						}
						else
						{
							this.cbInlay2b.SelectedIndex = 2;
						}
						if (item.XQ3 == 255)
						{
							this.cbInlay3b.SelectedIndex = 0;
						}
						else if (item.XQ3 == 254)
						{
							this.cbInlay3b.SelectedIndex = 1;
						}
						else
						{
							this.cbInlay3b.SelectedIndex = 2;
						}
						if (item.XQ4 == 255)
						{
							this.cbInlay4b.SelectedIndex = 0;
						}
						else if (item.XQ4 == 254)
						{
							this.cbInlay4b.SelectedIndex = 1;
						}
						else
						{
							this.cbInlay4b.SelectedIndex = 2;
						}
						if (item.XQ5 == 255)
						{
							this.cbInlay5b.SelectedIndex = 0;
						}
						else if (item.XQ5 == 254)
						{
							this.cbInlay5b.SelectedIndex = 1;
						}
						else
						{
							this.cbInlay5b.SelectedIndex = 2;
						}
					}
					else if (itemKindB == 44)
					{
						if (item.XQ1 == 255)
						{
							this.cbInlay1b.SelectedIndex = 0;
						}
						else if (item.XQ1 == 17)
						{
							this.cbInlay1b.SelectedIndex = 1;
						}
						else if (item.XQ1 == 33)
						{
							this.cbInlay1b.SelectedIndex = 2;
						}
						else if (item.XQ1 == 49)
						{
							this.cbInlay1b.SelectedIndex = 3;
						}
						else if (item.XQ1 == 65)
						{
							this.cbInlay1b.SelectedIndex = 4;
						}
						else if (item.XQ1 == 81)
						{
							this.cbInlay1b.SelectedIndex = 5;
						}
						else if (item.XQ1 == 97)
						{
							this.cbInlay1b.SelectedIndex = 6;
						}
						else if (item.XQ1 == 113)
						{
							this.cbInlay1b.SelectedIndex = 7;
						}
						else if (item.XQ1 == 129)
						{
							this.cbInlay1b.SelectedIndex = 8;
						}
						else if (item.XQ1 == 145)
						{
							this.cbInlay1b.SelectedIndex = 9;
						}
						else
						{
							this.cbInlay1b.SelectedIndex = 10;
						}
						if (item.XQ2 == 255)
						{
							this.cbInlay2b.SelectedIndex = 0;
						}
						else if (item.XQ2 == 17)
						{
							this.cbInlay2b.SelectedIndex = 1;
						}
						else if (item.XQ2 == 33)
						{
							this.cbInlay2b.SelectedIndex = 2;
						}
						else if (item.XQ2 == 49)
						{
							this.cbInlay2b.SelectedIndex = 3;
						}
						else if (item.XQ2 == 65)
						{
							this.cbInlay2b.SelectedIndex = 4;
						}
						else if (item.XQ2 == 81)
						{
							this.cbInlay2b.SelectedIndex = 5;
						}
						else if (item.XQ2 == 97)
						{
							this.cbInlay2b.SelectedIndex = 6;
						}
						else if (item.XQ2 == 113)
						{
							this.cbInlay2b.SelectedIndex = 7;
						}
						else if (item.XQ2 == 129)
						{
							this.cbInlay2b.SelectedIndex = 8;
						}
						else if (item.XQ2 == 145)
						{
							this.cbInlay2b.SelectedIndex = 9;
						}
						else
						{
							this.cbInlay2b.SelectedIndex = 10;
						}
						if (item.XQ3 == 255)
						{
							this.cbInlay3b.SelectedIndex = 0;
						}
						else if (item.XQ3 == 17)
						{
							this.cbInlay3b.SelectedIndex = 1;
						}
						else if (item.XQ3 == 33)
						{
							this.cbInlay3b.SelectedIndex = 2;
						}
						else if (item.XQ3 == 49)
						{
							this.cbInlay3b.SelectedIndex = 3;
						}
						else if (item.XQ3 == 65)
						{
							this.cbInlay3b.SelectedIndex = 4;
						}
						else if (item.XQ3 == 81)
						{
							this.cbInlay3b.SelectedIndex = 5;
						}
						else if (item.XQ3 == 97)
						{
							this.cbInlay3b.SelectedIndex = 6;
						}
						else if (item.XQ3 == 113)
						{
							this.cbInlay3b.SelectedIndex = 7;
						}
						else if (item.XQ3 == 129)
						{
							this.cbInlay3b.SelectedIndex = 8;
						}
						else if (item.XQ3 == 145)
						{
							this.cbInlay3b.SelectedIndex = 9;
						}
						else
						{
							this.cbInlay3b.SelectedIndex = 10;
						}
						if (item.XQ4 == 255)
						{
							this.cbInlay4b.SelectedIndex = 0;
						}
						else if (item.XQ4 == 17)
						{
							this.cbInlay4b.SelectedIndex = 1;
						}
						else if (item.XQ4 == 33)
						{
							this.cbInlay4b.SelectedIndex = 2;
						}
						else if (item.XQ4 == 49)
						{
							this.cbInlay4b.SelectedIndex = 3;
						}
						else if (item.XQ4 == 65)
						{
							this.cbInlay4b.SelectedIndex = 4;
						}
						else if (item.XQ4 == 81)
						{
							this.cbInlay4b.SelectedIndex = 5;
						}
						else if (item.XQ4 == 97)
						{
							this.cbInlay4b.SelectedIndex = 6;
						}
						else if (item.XQ4 == 113)
						{
							this.cbInlay4b.SelectedIndex = 7;
						}
						else if (item.XQ4 == 129)
						{
							this.cbInlay4b.SelectedIndex = 8;
						}
						else if (item.XQ4 == 145)
						{
							this.cbInlay4b.SelectedIndex = 9;
						}
						else
						{
							this.cbInlay4b.SelectedIndex = 10;
						}
						if (item.XQ5 == 255)
						{
							this.cbInlay5b.SelectedIndex = 0;
						}
						else if (item.XQ5 == 17)
						{
							this.cbInlay5b.SelectedIndex = 1;
						}
						else if (item.XQ5 == 33)
						{
							this.cbInlay5b.SelectedIndex = 2;
						}
						else if (item.XQ5 == 49)
						{
							this.cbInlay5b.SelectedIndex = 3;
						}
						else if (item.XQ5 == 65)
						{
							this.cbInlay5b.SelectedIndex = 4;
						}
						else if (item.XQ5 == 81)
						{
							this.cbInlay5b.SelectedIndex = 5;
						}
						else if (item.XQ5 == 97)
						{
							this.cbInlay5b.SelectedIndex = 6;
						}
						else if (item.XQ5 == 113)
						{
							this.cbInlay5b.SelectedIndex = 7;
						}
						else if (item.XQ5 == 129)
						{
							this.cbInlay5b.SelectedIndex = 8;
						}
						else if (item.XQ5 == 145)
						{
							this.cbInlay5b.SelectedIndex = 9;
						}
						else
						{
							this.cbInlay5b.SelectedIndex = 10;
						}
					}
					Trace.WriteLine("item.YG : " + (int)(item.YG - 17));
					if (item.YG >= 0 && (int)(item.YG - 17) < Utils.YSS.Length)
					{
						this.cbInlay6b.SelectedIndex = (int)(item.YG - 17);
						return;
					}
					this.cbInlay6b.SelectedIndex = 0;
					return;
				}
				else
				{
					if (item.XQ1 == 255)
					{
						this.cbInlay1b.SelectedIndex = 0;
					}
					else if (item.XQ1 == 254)
					{
						this.cbInlay1b.SelectedIndex = 1;
					}
					else
					{
						int num = (int)(item.XQ1 % 50);
						int num2 = ((int)item.XQ1 - num) / 50;
						string lParam = frmMain.ByteToString(EquipEditor.xSocket[num].byte_0, 64) + " +" + EquipEditor.xSocket[num].uint_4[num2].ToString();
						this.cbInlay1b.SelectedIndex = EquipProperty.SendMessageA(this.cbInlay1b.Handle, 332, IntPtr.Zero, lParam);
					}
					if (item.XQ2 == 255)
					{
						this.cbInlay2b.SelectedIndex = 0;
					}
					else if (item.XQ2 == 254)
					{
						this.cbInlay2b.SelectedIndex = 1;
					}
					else
					{
						int num3 = (int)(item.XQ2 % 50);
						int num4 = ((int)item.XQ2 - num3) / 50;
						string lParam2 = frmMain.ByteToString(EquipEditor.xSocket[num3].byte_0, 64) + " +" + EquipEditor.xSocket[num3].uint_4[num4].ToString();
						this.cbInlay2b.SelectedIndex = EquipProperty.SendMessageA(this.cbInlay2b.Handle, 332, IntPtr.Zero, lParam2);
					}
					if (item.XQ3 == 255)
					{
						this.cbInlay3b.SelectedIndex = 0;
					}
					else if (item.XQ3 == 254)
					{
						this.cbInlay3b.SelectedIndex = 1;
					}
					else
					{
						int num5 = (int)(item.XQ3 % 50);
						int num6 = ((int)item.XQ3 - num5) / 50;
						string lParam3 = frmMain.ByteToString(EquipEditor.xSocket[num5].byte_0, 64) + " +" + EquipEditor.xSocket[num5].uint_4[num6].ToString();
						this.cbInlay3b.SelectedIndex = EquipProperty.SendMessageA(this.cbInlay3b.Handle, 332, IntPtr.Zero, lParam3);
					}
					if (item.XQ4 == 255)
					{
						this.cbInlay4b.SelectedIndex = 0;
					}
					else if (item.XQ4 == 254)
					{
						this.cbInlay4b.SelectedIndex = 1;
					}
					else
					{
						int num7 = (int)(item.XQ4 % 50);
						int num8 = ((int)item.XQ4 - num7) / 50;
						string lParam4 = frmMain.ByteToString(EquipEditor.xSocket[num7].byte_0, 64) + " +" + EquipEditor.xSocket[num7].uint_4[num8].ToString();
						this.cbInlay4b.SelectedIndex = EquipProperty.SendMessageA(this.cbInlay4b.Handle, 332, IntPtr.Zero, lParam4);
					}
					if (item.XQ5 == 255)
					{
						this.cbInlay5b.SelectedIndex = 0;
					}
					else if (item.XQ5 == 254)
					{
						this.cbInlay5b.SelectedIndex = 1;
					}
					else
					{
						int num9 = (int)(item.XQ5 % 50);
						int num10 = ((int)item.XQ5 - num9) / 50;
						string lParam5 = frmMain.ByteToString(EquipEditor.xSocket[num9].byte_0, 64) + " +" + EquipEditor.xSocket[num9].uint_4[num10].ToString();
						this.cbInlay5b.SelectedIndex = EquipProperty.SendMessageA(this.cbInlay5b.Handle, 332, IntPtr.Zero, lParam5);
					}
					if (item.YG >= 0 && (int)item.YG < Utils.YGS.Length - 1)
					{
						this.cbInlay6b.SelectedIndex = (int)(item.YG + 1);
						return;
					}
					this.cbInlay6b.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00025288 File Offset: 0x00023488
		public void updateData(EquipItem item)
		{
			item.SN = Convert.ToInt32(this.txtSN.Text.Replace(" ", ""));
			item.Level = (byte)this.cboEquipLevel.SelectedIndex;
			item.Ext = this.cboEquipExt.SelectedIndex;
			item.PlusType = (int)((byte)this.cboPlusType.SelectedIndex);
			item.PlusLevel = (int)((byte)((this.cboPlusType.SelectedIndex <= 0) ? 0 : this.cboPlusLevel.SelectedIndex));
			item.JN = (this.chkEquipJN.Checked && this.chkEquipJN.Enabled);
			item.XY = (this.chkEquipXY.Checked && this.chkEquipXY.Enabled);
			item.ZY1 = (this.chkEquipZY1.Checked && this.chkEquipZY1.Enabled);
			item.ZY2 = (this.chkEquipZY2.Checked && this.chkEquipZY2.Enabled);
			item.ZY3 = (this.chkEquipZY3.Checked && this.chkEquipZY3.Enabled);
			item.ZY4 = (this.chkEquipZY4.Checked && this.chkEquipZY4.Enabled);
			item.ZY5 = (this.chkEquipZY5.Checked && this.chkEquipZY5.Enabled);
			item.ZY6 = (this.chkEquipZY6.Checked && this.chkEquipZY6.Enabled);
			item.Is380 = (this.chk380.Checked && this.chk380.Enabled);
			item.IsSet = (this.cbSetVal.SelectedIndex > 0 && this.cbSetVal.Enabled);
			item.SetVal = (this.cbSetVal.Enabled ? Convert.ToByte(this.cbSetVal.SelectedItem) : (byte)0);
			item.Durability = Convert.ToByte(this.txtDurability.Text.Replace(" ", ""));
			if (this.gbXQ.Enabled)
			{
				item.PlusType = 0;
				item.PlusLevel = 0;
				byte itemKindA = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindA;
				byte itemKindB = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindB;
				byte itemCategory = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemCategory;
				if (itemKindA == 8)
				{
					ComboBoxItem comboBoxItem = (ComboBoxItem)this.cbInlay1b.SelectedItem;
					item.XQ1 = Convert.ToByte(comboBoxItem.Value);
					ComboBoxItem comboBoxItem2 = (ComboBoxItem)this.cbInlay2b.SelectedItem;
					item.XQ2 = Convert.ToByte(comboBoxItem2.Value);
					ComboBoxItem comboBoxItem3 = (ComboBoxItem)this.cbInlay3b.SelectedItem;
					item.XQ3 = Convert.ToByte(comboBoxItem3.Value);
					ComboBoxItem comboBoxItem4 = (ComboBoxItem)this.cbInlay4b.SelectedItem;
					item.XQ4 = Convert.ToByte(comboBoxItem4.Value);
					ComboBoxItem comboBoxItem5 = (ComboBoxItem)this.cbInlay5b.SelectedItem;
					item.XQ5 = Convert.ToByte(comboBoxItem5.Value);
					item.YG = (byte)(this.cbInlay6b.SelectedIndex + 17);
					return;
				}
				ComboBoxItem comboBoxItem6 = (ComboBoxItem)this.cbInlay1b.SelectedItem;
				item.XQ1 = Convert.ToByte(comboBoxItem6.Value);
				ComboBoxItem comboBoxItem7 = (ComboBoxItem)this.cbInlay2b.SelectedItem;
				item.XQ2 = Convert.ToByte(comboBoxItem7.Value);
				ComboBoxItem comboBoxItem8 = (ComboBoxItem)this.cbInlay3b.SelectedItem;
				item.XQ3 = Convert.ToByte(comboBoxItem8.Value);
				ComboBoxItem comboBoxItem9 = (ComboBoxItem)this.cbInlay4b.SelectedItem;
				item.XQ4 = Convert.ToByte(comboBoxItem9.Value);
				ComboBoxItem comboBoxItem10 = (ComboBoxItem)this.cbInlay5b.SelectedItem;
				item.XQ5 = Convert.ToByte(comboBoxItem10.Value);
				item.YG = ((this.cbInlay6b.SelectedIndex > 0) ? ((byte)(this.cbInlay6b.SelectedIndex - 1)) : byte.MaxValue);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000256CC File Offset: 0x000238CC
		private void setZY(int type)
		{
			if (type == 0)
			{
				this.chkEquipZY1.Text = "无";
				this.chkEquipZY2.Text = "无";
				this.chkEquipZY3.Text = "无";
				this.chkEquipZY4.Text = "无";
				this.chkEquipZY5.Text = "无";
				this.chkEquipZY6.Text = "无";
				return;
			}
			if (type == 1)
			{
				this.chkEquipZY1.Text = "+魔法值/8";
				this.chkEquipZY2.Text = "+生命值/8";
				this.chkEquipZY3.Text = "+速度+7";
				this.chkEquipZY4.Text = "+2%攻击";
				this.chkEquipZY5.Text = "等级/20攻击";
				this.chkEquipZY6.Text = "卓越一击";
				return;
			}
			if (type == 2)
			{
				this.chkEquipZY1.Text = "金钱 +30%";
				this.chkEquipZY2.Text = "防御 +10%";
				this.chkEquipZY3.Text = "反伤";
				this.chkEquipZY4.Text = "减伤";
				this.chkEquipZY5.Text = "魔法 +4%";
				this.chkEquipZY6.Text = "生命 +4%";
				return;
			}
			if (type == 3)
			{
				this.chkEquipZY1.Text = "加生";
				this.chkEquipZY2.Text = "加魔";
				this.chkEquipZY3.Text = "无视";
				this.chkEquipZY4.Text = "技能最大值";
				this.chkEquipZY5.Text = "加速";
				this.chkEquipZY6.Text = "追/回";
				return;
			}
			if (type == 4)
			{
				this.chkEquipZY1.Text = "无视";
				this.chkEquipZY2.Text = "反弹攻击";
				this.chkEquipZY3.Text = "恢复生命";
				this.chkEquipZY4.Text = "恢复魔法";
				this.chkEquipZY5.Text = "追/回";
				this.chkEquipZY6.Text = "追/回";
				return;
			}
			if (type == 5)
			{
				this.chkEquipZY1.Text = "生命 +50";
				this.chkEquipZY2.Text = "魔法 +50";
				this.chkEquipZY3.Text = "无视";
				this.chkEquipZY4.Text = "追加统率";
				this.chkEquipZY5.Text = "无";
				this.chkEquipZY6.Text = "无";
				return;
			}
			if (type == 6)
			{
				this.chkEquipZY1.Text = "黑狼";
				this.chkEquipZY2.Text = "青狼";
				this.chkEquipZY3.Text = "金狼";
				this.chkEquipZY4.Text = "无";
				this.chkEquipZY5.Text = "无";
				this.chkEquipZY6.Text = "无";
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0002599C File Offset: 0x00023B9C
		public void SetUIbyCob(EquipItem item)
		{
			this.gbXQ.Enabled = Utils.GetQX(item);
			this.chkEquipXY.Enabled = (item.Type >= 0 && item.Type <= 11);
			this.cbSetVal.Enabled = this.chkEquipXY.Enabled;
			this.chk380.Enabled = Utils.Get380(item);
			this.chk380.Checked = this.chk380.Enabled;
			this.chkEquipJN.Enabled = Utils.GetJN(item);
			if (item.Type >= 0 && item.Type <= 5)
			{
				this.setZY(1);
				if (item.IsFZ)
				{
					Utils.GetPlusType(this.cboPlusType, 3);
				}
				else
				{
					Utils.GetPlusType(this.cboPlusType, 1);
				}
			}
			else if (item.Type >= 6 && item.Type <= 11)
			{
				this.setZY(2);
				Utils.GetPlusType(this.cboPlusType, 2);
			}
			else
			{
				Utils.GetPlusType(this.cboPlusType, 0);
			}
			this.Init_EquipEditor();
			byte itemKindA = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindA;
			byte itemKindB = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindB;
			byte itemCategory = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemCategory;
			switch (item.Type)
			{
			case 12:
				this.cbInlay6b.Items.Clear();
				if (itemKindA == 8)
				{
					if (itemKindB == 0)
					{
						this.cbInlay1b.Items.Clear();
						this.cbInlay1b.Items.Add(new ComboBoxItem("无属性", "0"));
						this.cbInlay2b.Items.Clear();
						this.cbInlay2b.Items.Add(new ComboBoxItem("无属性", "0"));
						this.cbInlay3b.Items.Clear();
						this.cbInlay3b.Items.Add(new ComboBoxItem("无属性", "0"));
						this.cbInlay4b.Items.Clear();
						this.cbInlay4b.Items.Add(new ComboBoxItem("无属性", "0"));
						this.cbInlay5b.Items.Clear();
						this.cbInlay5b.Items.Add(new ComboBoxItem("无属性", "0"));
					}
					else if (itemKindB == 43)
					{
						this.cbInlay1b.Items.Clear();
						this.cbInlay1b.Items.Add(new ComboBoxItem("未开孔", "255"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("愤怒的元素之魂", "254"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("愤怒的元素之魂(镶嵌)", "0"));
						this.cbInlay2b.Items.Clear();
						this.cbInlay2b.Items.Add(new ComboBoxItem("未开孔", "255"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("庇护的元素之魂", "254"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("庇护的元素之魂(镶嵌)", "1"));
						this.cbInlay3b.Items.Clear();
						this.cbInlay3b.Items.Add(new ComboBoxItem("未开孔", "255"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("高贵的元素之魂", "254"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("高贵的元素之魂(镶嵌)", "2"));
						this.cbInlay4b.Items.Clear();
						this.cbInlay4b.Items.Add(new ComboBoxItem("未开孔", "255"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("神圣的元素之魂", "254"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("神圣的元素之魂(镶嵌)", "3"));
						this.cbInlay5b.Items.Clear();
						this.cbInlay5b.Items.Add(new ComboBoxItem("未开孔", "255"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("狂喜的元素之魂", "254"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("狂喜的元素之魂(镶嵌)", "4"));
					}
					else if (itemKindB == 44)
					{
						this.cbInlay1b.Items.Clear();
						this.cbInlay1b.Items.Add(new ComboBoxItem("无属性", "255"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +1", "17"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +2", "33"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +3", "49"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +4", "65"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +5", "81"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +6", "97"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +7", "113"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +8", "129"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +9", "145"));
						this.cbInlay1b.Items.Add(new ComboBoxItem("1阶属性 +10", "161"));
						this.cbInlay2b.Items.Clear();
						this.cbInlay2b.Items.Add(new ComboBoxItem("无属性", "255"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +1", "17"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +2", "33"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +3", "49"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +4", "65"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +5", "81"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +6", "97"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +7", "113"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +8", "129"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +9", "145"));
						this.cbInlay2b.Items.Add(new ComboBoxItem("2阶属性 +10", "161"));
						this.cbInlay3b.Items.Clear();
						this.cbInlay3b.Items.Add(new ComboBoxItem("无属性", "255"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +1", "17"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +2", "33"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +3", "49"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +4", "65"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +5", "81"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +6", "97"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +7", "113"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +8", "129"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +9", "145"));
						this.cbInlay3b.Items.Add(new ComboBoxItem("3阶属性 +10", "161"));
						this.cbInlay4b.Items.Clear();
						this.cbInlay4b.Items.Add(new ComboBoxItem("无属性", "255"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +1", "17"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +2", "33"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +3", "49"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +4", "65"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +5", "81"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +6", "97"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +7", "113"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +8", "129"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +9", "145"));
						this.cbInlay4b.Items.Add(new ComboBoxItem("4阶属性 +10", "161"));
						this.cbInlay5b.Items.Clear();
						this.cbInlay5b.Items.Add(new ComboBoxItem("无属性", "255"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +1", "17"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +2", "33"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +3", "49"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +4", "65"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +5", "81"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +6", "97"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +7", "113"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +8", "129"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +9", "145"));
						this.cbInlay5b.Items.Add(new ComboBoxItem("5阶属性 +10", "161"));
					}
					this.cbInlay1b.SelectedIndex = 0;
					this.cbInlay2b.SelectedIndex = 0;
					this.cbInlay3b.SelectedIndex = 0;
					this.cbInlay4b.SelectedIndex = 0;
					this.cbInlay5b.SelectedIndex = 0;
					for (int i = 0; i < Utils.YSS.Length; i++)
					{
						this.cbInlay6b.Items.Add(new ComboBoxItem(Utils.YSS[i], i.ToString()));
					}
				}
				else
				{
					for (int j = 0; j < Utils.YGS.Length; j++)
					{
						this.cbInlay6b.Items.Add(new ComboBoxItem(Utils.YGS[j], j.ToString()));
					}
				}
				this.cbInlay6b.SelectedIndex = 0;
				if (itemCategory == 1)
				{
					if (itemKindB == 23)
					{
						this.setZY(0);
						this.chkEquipXY.Enabled = true;
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
										this.setZY(0);
										this.chkEquipXY.Enabled = false;
										break;
									}
								}
								this.setZY(4);
								this.chkEquipXY.Enabled = true;
								break;
							}
						}
						this.setZY(3);
						this.chkEquipXY.Enabled = true;
					}
				}
				else
				{
					this.setZY(0);
					this.chkEquipXY.Enabled = false;
				}
				break;
			case 13:
				if (itemCategory == 1)
				{
					if (itemKindB == 26)
					{
						this.setZY(5);
						this.chkEquipXY.Enabled = true;
						this.cbSetVal.Enabled = false;
					}
					else
					{
						if (itemKindB != 29)
						{
							if (itemKindB != 30)
							{
								if (itemKindB == 31)
								{
									this.setZY(2);
									this.cbSetVal.Enabled = true;
									break;
								}
								this.setZY(0);
								this.cbSetVal.Enabled = false;
								break;
							}
						}
						this.setZY(1);
						this.cbSetVal.Enabled = true;
					}
				}
				else if (item.Code == 37 && itemKindB == 46)
				{
					this.setZY(6);
					this.chkEquipJN.Enabled = true;
				}
				else
				{
					this.setZY(0);
					this.cbSetVal.Enabled = false;
				}
				break;
			case 14:
			case 15:
				this.setZY(0);
				break;
			}
			this.chkEquipZY1.Enabled = (this.chkEquipZY1.Text != "无");
			this.chkEquipZY2.Enabled = (this.chkEquipZY2.Text != "无");
			this.chkEquipZY3.Enabled = (this.chkEquipZY3.Text != "无");
			this.chkEquipZY4.Enabled = (this.chkEquipZY4.Text != "无");
			this.chkEquipZY5.Enabled = (this.chkEquipZY5.Text != "无");
			this.chkEquipZY6.Enabled = (this.chkEquipZY6.Text != "无");
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000391A File Offset: 0x00001B1A
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (this.item != null)
			{
				this.updateData(this.item);
			}
			this.item = null;
			base.Close();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000393D File Offset: 0x00001B3D
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.item = null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00026888 File Offset: 0x00024A88
		private void button1_Click(object sender, EventArgs e)
		{
			this.chkEquipZY1.Checked = Utils.JPZY1;
			this.chkEquipZY2.Checked = Utils.JPZY2;
			this.chkEquipZY3.Checked = Utils.JPZY3;
			this.chkEquipZY4.Checked = Utils.JPZY4;
			this.chkEquipZY5.Checked = Utils.JPZY5;
			this.chkEquipZY6.Checked = Utils.JPZY6;
			this.cboEquipLevel.SelectedIndex = Utils.JPLevel;
			this.cboEquipExt.SelectedIndex = Utils.JPExt;
			this.chkEquipJN.Checked = Utils.JPJN;
			this.chkEquipXY.Checked = Utils.JPXY;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00026938 File Offset: 0x00024B38
		private void button4_Click(object sender, EventArgs e)
		{
			this.chkEquipZY1.Checked = Utils.DJZY1;
			this.chkEquipZY2.Checked = Utils.DJZY2;
			this.chkEquipZY3.Checked = Utils.DJZY3;
			this.chkEquipZY4.Checked = Utils.DJZY4;
			this.chkEquipZY5.Checked = Utils.DJZY5;
			this.chkEquipZY6.Checked = Utils.DJZY6;
			this.cboEquipLevel.SelectedIndex = Utils.DJLevel;
			this.cboEquipExt.SelectedIndex = Utils.DJExt;
			this.chkEquipJN.Checked = Utils.DJJN;
			this.chkEquipXY.Checked = Utils.DJXY;
		}

		// Token: 0x04000230 RID: 560
		private const int CB_FINDSTRING = 332;

		// Token: 0x04000261 RID: 609
		private EquipItem item;
	}
}
