using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MuEditor.Properties;

namespace MuEditor
{
	// Token: 0x0200000B RID: 11
	public partial class frmInitEquip : frmBase
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00002787 File Offset: 0x00000987
		public frmInitEquip()
		{
			this.InitializeComponent();
			this.init();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000027BE File Offset: 0x000009BE
		public static frmInitEquip GetInstance()
		{
			if (frmInitEquip.form == null)
			{
				frmInitEquip.form = new frmInitEquip();
			}
			return frmInitEquip.form;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00012984 File Offset: 0x00010B84
		private void init()
		{
			string text = "SELECT text FROM sys.syscomments WHERE (id = OBJECT_ID('T_HE_INSERT_Character_Inventory'))";
			try
			{
				OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Mu_Conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				StringBuilder stringBuilder = new StringBuilder();
				while (oleDbDataReader.Read())
				{
					stringBuilder.Append(Convert.ToString(oleDbDataReader.GetValue(0)));
				}
				if (stringBuilder.ToString().Trim() != "")
				{
					string pattern = "CREATE TRIGGER T_HE_INSERT_Character_Inventory\r\nON Character\r\nFOR INSERT\r\nAS\r\nBEGIN TRANSACTION\r\nDECLARE @Cls tinyint, @Lev smallint, @Name varchar\\(10\\)\r\nSELECT @Cls = Class, @Lev = cLevel, @Name = Name FROM INSERTED\r\nIF @Lev > 1\r\nIF @Cls = 0\r\nUPDATE Character SET Inventory = (0x[0-9A-F]{3776}) WHERE (Name = @Name)\r\nELSE IF @Cls = 16\r\nUPDATE Character SET Inventory = (0x[0-9A-F]{3776}) WHERE (Name = @Name)\r\nELSE IF @Cls = 32\r\nUPDATE Character SET Inventory = (0x[0-9A-F]{3776}) WHERE (Name = @Name)\r\nELSE IF @Cls = 48\r\nUPDATE Character SET Inventory = (0x[0-9A-F]{3776}) WHERE (Name = @Name)\r\nELSE IF @Cls = 64\r\nUPDATE Character SET Inventory = (0x[0-9A-F]{3776}) WHERE (Name = @Name)\r\nELSE IF @Cls = 80\r\nUPDATE Character SET Inventory = (0x[0-9A-F]{3776}) WHERE (Name = @Name)\r\nELSE IF @Cls = 96\r\nUPDATE Character SET Inventory = (0x[0-9A-F]{3776}) WHERE (Name = @Name)\r\nELSE\r\nUPDATE Character SET Inventory = (0x[0-9A-F]{3776}) WHERE (Name = @Name)\r\nCOMMIT TRANSACTION";
					Match match = Regex.Match(stringBuilder.ToString(), pattern, RegexOptions.IgnoreCase);
					if (match.Success)
					{
						for (int i = 0; i < this.strCodes.Length; i++)
						{
							this.strCodes[i] = match.Groups[i + 1].Value;
							this.strLoads[i] = this.strCodes[i];
						}
					}
					else
					{
						for (int j = 0; j < this.strCodes.Length; j++)
						{
							this.strCodes[j] = this.strCode;
							this.strLoads[j] = this.strCode;
						}
					}
				}
				else
				{
					for (int k = 0; k < this.strCodes.Length; k++)
					{
						this.strCodes[k] = this.strCode;
						this.strLoads[k] = this.strCode;
					}
				}
			}
			catch (Exception ex)
			{
				Utils.WarningMessage("SQL：" + text + "\nError:" + ex.Message);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000027D6 File Offset: 0x000009D6
		private void frmInitEquip_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmInitEquip.form = null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00012AFC File Offset: 0x00010CFC
		private void cbZhiye_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				byte[] array = Utils.StringToBytes(this.strCodes[this.cbZhiye.SelectedIndex]);
				if (array != null)
				{
					this.charPanel.clearData();
					if (!this.charPanel.loadItemsByCodes(array, 0, 192))
					{
						Utils.WarningMessage("加载角色身上的装备失败，可能数据格式不正确！");
					}
					this.charPanel.Invalidate();
					this.packagePanel.clearData();
					int num = 192;
					if (!this.packagePanel.loadItemsByCodes(array, 192, array.Length - 192))
					{
						Utils.WarningMessage("加载角色包裹里的装备失败，可能数据格式不正确！");
					}
					this.packagePanel.Invalidate();
					this.packagePanelLv1.clearData();
					num += this.packagePanel.XNum * this.packagePanel.YNum * 16;
					if (!this.packagePanelLv1.loadItemsByCodes(array, num, array.Length - num))
					{
						Utils.WarningMessage("加载角色包裹Lv1里的装备失败，可能数据格式不正确！");
					}
					this.packagePanelLv1.Invalidate();
					this.packagePanelLv2.clearData();
					num += this.packagePanelLv1.XNum * this.packagePanelLv1.YNum * 16;
					if (!this.packagePanelLv2.loadItemsByCodes(array, num, array.Length - num))
					{
						Utils.WarningMessage("加载角色包裹Lv2里的装备失败，可能数据格式不正确！");
					}
					this.packagePanelLv2.Invalidate();
					this.packagePanelLv3.clearData();
					num += this.packagePanelLv2.XNum * this.packagePanelLv2.YNum * 16;
					if (!this.packagePanelLv3.loadItemsByCodes(array, num, array.Length - num))
					{
						Utils.WarningMessage("加载角色包裹Lv3里的装备失败，可能数据格式不正确！");
					}
					this.packagePanelLv3.Invalidate();
					this.packagePanelLv4.clearData();
					num += this.packagePanelLv3.XNum * this.packagePanelLv3.YNum * 16;
					if (!this.packagePanelLv4.loadItemsByCodes(array, num, array.Length - num))
					{
						Utils.WarningMessage("加载角色包裹Lv4里的装备失败，可能数据格式不正确！");
					}
					this.packagePanelLv4.Invalidate();
					this.shopPanel.clearData();
					num += this.packagePanelLv4.XNum * this.packagePanelLv4.YNum * 16;
					if (!this.shopPanel.loadItemsByCodes(array, num, array.Length - num))
					{
						Utils.WarningMessage("加载角色商店里的装备失败，可能数据格式不正确！");
					}
					this.shopPanel.Invalidate();
					this.sBookPanel.clearData();
					num += this.shopPanel.XNum * this.shopPanel.YNum * 16;
					if (!this.sBookPanel.loadItemsByCodes(array, num, array.Length - num))
					{
						Utils.WarningMessage("加载角色技能书栏的装备失败，可能数据格式不正确！");
					}
					this.sBookPanel.Invalidate();
				}
			}
			catch (Exception ex)
			{
				Utils.WarningMessage("Error:" + ex.Message);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00012DBC File Offset: 0x00010FBC
		private void btnSave_Click(object sender, EventArgs e)
		{
			string sql = "IF EXISTS (SELECT NAME FROM SYSOBJECTS WHERE XTYPE = 'TR' AND NAME = 'T_HE_INSERT_Character_Inventory')\r\nDROP TRIGGER T_HE_INSERT_Character_Inventory";
			string text = "CREATE TRIGGER T_HE_INSERT_Character_Inventory\r\nON Character\r\nFOR INSERT\r\nAS\r\nBEGIN TRANSACTION\r\nDECLARE @Cls tinyint, @Lev smallint, @Name varchar\\(10\\)\r\nSELECT @Cls = Class, @Lev = cLevel, @Name = Name FROM INSERTED\r\nIF @Lev > 1\r\nIF @Cls = 0\r\nUPDATE Character SET Inventory = {0} WHERE (Name = @Name)\r\nELSE IF @Cls=16\r\nUPDATE Character SET Inventory = {1} WHERE (Name = @Name)\r\nelse if @Cls=32\r\nUPDATE Character SET Inventory = {2} WHERE (Name = @Name)\r\nELSE IF @Cls=48\r\nUPDATE Character SET Inventory = {3} WHERE (Name = @Name)\r\nELSE IF @Cls=64\r\nUPDATE Character SET Inventory = {4} WHERE (Name = @Name)\r\nELSE IF @Cls=80\r\nUPDATE Character SET Inventory = {5} WHERE (Name = @Name)\r\nELSE IF @Cls=96\r\nUPDATE Character SET Inventory = {6} WHERE (Name = @Name)\r\nELSE\r\nUPDATE Character SET Inventory = {0} WHERE (Name = @Name)\r\nCOMMIT TRANSACTION";
			try
			{
				if (this.chkAll.Checked)
				{
					string code = this.getCode();
					for (int i = 0; i < this.strCodes.Length; i++)
					{
						this.strCodes[i] = code;
					}
				}
				text = string.Format(text, this.strCodes);
				if (Mu_ExecuteSQL(sql) && Mu_ExecuteSQL(text))
				{
					for (int j = 0; j < this.strCodes.Length; j++)
					{
						this.strLoads[j] = this.strCodes[j];
					}
					Utils.InfoMessage("操作成功！");
				}
				else
				{
					Utils.WarningMessage("操作失败！");
				}
			}
			catch (Exception ex)
			{
				Utils.WarningMessage("Error:" + ex.Message);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00012E90 File Offset: 0x00011090
		private string getCode()
		{
			return string.Concat(new string[]
			{
				"0x",
				this.charPanel.getEquipCodes(),
				this.packagePanel.getEquipCodes(),
				this.packagePanelLv1.getEquipCodes(),
				this.packagePanelLv2.getEquipCodes(),
				this.packagePanelLv3.getEquipCodes(),
				this.packagePanelLv4.getEquipCodes(),
				this.shopPanel.getEquipCodes(),
				this.sBookPanel.getEquipCodes()
			});
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00012F24 File Offset: 0x00011124
		private void frmInitEquip_Load(object sender, EventArgs e)
		{
			this.charPanel.Editor = this.equipEditor;
			this.packagePanel.setSize(8, 8);
			this.packagePanel.Editor = this.equipEditor;
			this.packagePanelLv1.setSize(8, 4);
			this.packagePanelLv1.Editor = this.equipEditor;
			this.packagePanelLv2.setSize(8, 4);
			this.packagePanelLv2.Editor = this.equipEditor;
			this.packagePanelLv3.setSize(8, 4);
			this.packagePanelLv3.Editor = this.equipEditor;
			this.packagePanelLv4.setSize(8, 4);
			this.packagePanelLv4.Editor = this.equipEditor;
			this.shopPanel.setSize(8, 4);
			this.shopPanel.Editor = this.equipEditor;
			this.sBookPanel.Editor = this.equipEditor;
			this.equipEditor.LoadData();
			this.cbZhiye.SelectedIndex = 0;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000027DE File Offset: 0x000009DE
		private void charPanel_MouseLeave(object sender, EventArgs e)
		{
			this.strCodes[this.cbZhiye.SelectedIndex] = this.getCode();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00013020 File Offset: 0x00011220
		private void packagePanel_MouseLeave(object sender, EventArgs e)
		{
			this.packagePanel.DownItem();
			this.packagePanelLv1.DownItem();
			this.packagePanelLv2.DownItem();
			this.packagePanelLv3.DownItem();
			this.packagePanelLv4.DownItem();
			this.strCodes[this.cbZhiye.SelectedIndex] = this.getCode();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000027F8 File Offset: 0x000009F8
		private void btnClearChar_Click(object sender, EventArgs e)
		{
			this.charPanel.clearData();
			this.charPanel.Invalidate();
			this.sBookPanel.clearData();
			this.sBookPanel.Invalidate();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0001307C File Offset: 0x0001127C
		private void btnClearPackage_Click(object sender, EventArgs e)
		{
			this.packagePanel.clearData();
			this.packagePanel.Invalidate();
			this.packagePanelLv1.clearData();
			this.packagePanelLv1.Invalidate();
			this.packagePanelLv2.clearData();
			this.packagePanelLv2.Invalidate();
			this.packagePanelLv3.clearData();
			this.packagePanelLv3.Invalidate();
			this.packagePanelLv4.clearData();
			this.packagePanelLv4.Invalidate();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000130F8 File Offset: 0x000112F8
		private void btnCleanPackage_Click(object sender, EventArgs e)
		{
			this.packagePanel.DownItem();
			EquipItem[] equipItems = this.packagePanel.getEquipItems();
			this.packagePanel.clearData();
			this.packagePanel.putItems(equipItems, true);
			this.packagePanel.Invalidate();
			this.packagePanelLv1.DownItem();
			EquipItem[] equipItems2 = this.packagePanelLv1.getEquipItems();
			this.packagePanelLv1.clearData();
			this.packagePanelLv1.putItems(equipItems2, true);
			this.packagePanelLv1.Invalidate();
			this.packagePanelLv2.DownItem();
			EquipItem[] equipItems3 = this.packagePanelLv2.getEquipItems();
			this.packagePanelLv2.clearData();
			this.packagePanelLv2.putItems(equipItems3, true);
			this.packagePanelLv2.Invalidate();
			this.packagePanelLv3.DownItem();
			EquipItem[] equipItems4 = this.packagePanelLv3.getEquipItems();
			this.packagePanelLv3.clearData();
			this.packagePanelLv3.putItems(equipItems4, true);
			this.packagePanelLv3.Invalidate();
			this.packagePanelLv4.DownItem();
			EquipItem[] equipItems5 = this.packagePanelLv4.getEquipItems();
			this.packagePanelLv4.clearData();
			this.packagePanelLv4.putItems(equipItems5, true);
			this.packagePanelLv4.Invalidate();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00013230 File Offset: 0x00011430
		private void frmInitEquip_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = false;
			for (int i = 0; i < this.strCodes.Length; i++)
			{
				if (this.strLoads[i] != this.strCodes[i])
				{
					flag = true;
					IL_30:
					if (flag && MessageBox.Show("是否保存当前设置？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						this.btnSave_Click(sender, e);
					}
					return;
				}
			}
			//goto IL_30;
		}

		// Token: 0x04000112 RID: 274
		private static frmInitEquip form;

		// Token: 0x04000113 RID: 275
		private string[] strLoads = new string[7];

		// Token: 0x04000114 RID: 276
		private string[] strCodes = new string[7];

		// Token: 0x04000115 RID: 277
		private string strCode = "0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
	}
}
