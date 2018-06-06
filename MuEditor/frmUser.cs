using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace MuEditor
{
	// Token: 0x02000003 RID: 3
	public partial class frmUser : frmBase
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000214A File Offset: 0x0000034A
		public static frmUser GetInstance(frmMain frm, string IP)
		{
			if (frmUser.form == null)
			{
				frmUser.form = new frmUser(frm, IP);
			}
			return frmUser.form;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00004DE4 File Offset: 0x00002FE4
		private frmUser(frmMain frm, string IP)
		{
			InitializeComponent();
			frmM = frm;
			cbChoise.SelectedIndex = ((IP == "") ? 0 : 2);
			txtAccount.Text = IP;
			cbField.Items.Clear();
			cbField.Items.Add(new ComboBoxItem("", ""));
			if (Utils.AccFieldNames.Length == Utils.AccFieldValues.Length)
			{
				for (int i = 0; i < Utils.AccFieldNames.Length; i++)
				{
					cbField.Items.Add(new ComboBoxItem(Utils.AccFieldNames[i], Utils.AccFieldValues[i]));
				}
				return;
			}
			Utils.WarningMessage("配置文件出错！节点AccFieldNames和AccFieldValues数量不一致！");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00004EB0 File Offset: 0x000030B0
		private void bind()
		{
			string format = "SELECT DISTINCT {0} AS 帐号, {1}[stat].[ConnectStat] AS [在线], {2} AS [被封], [stat].[IP], [AC].[GameID1] AS [角色1], [AC].[GameID2] AS [角色2], [AC].[GameID3] AS [角色3], [AC].[GameID4] AS [角色4], [AC].[GameID5] AS [角色5] FROM {3} {4} ORDER BY {0}";
			string text = "";
			try
			{
				string text2 = "[info].[memb___id]";
				string text3 = "[AC].[GameIDC] AS [当前角色], ";
				string text4 = "[info].[bloc_code]";
				string text5 = string.Concat(new string[]
				{
					" [MEMB_INFO] AS [info] LEFT JOIN [MEMB_STAT] AS [stat] ON [info].[memb___id] = [stat].[memb___id] COLLATE Chinese_PRC_CS_AS_KS_WS LEFT JOIN [",
					frmMain.MU_SERVER,
					"].[",
					frmMain.MU_DB,
					"].[dbo].[AccountCharacter] AS [AC] ON [AC].[Id] = [stat].[memb___id] COLLATE Chinese_PRC_CS_AS_KS_WS"
				});
				string text6 = "WHERE (1 = 1)";
				if (cbOnline.Checked)
				{
					text6 += " AND ([stat].[ConnectStat] = 1)";
				}
				if (cbChoise.SelectedIndex == 0)
				{
					if (cbEnvelop.Checked)
					{
						text6 += " AND ([info].[bloc_code] = 1)";
					}
					if (cbField.SelectedIndex > 0)
					{
						if (cbFilter.SelectedIndex == cbFilter.Items.Count - 1)
						{
							text6 += string.Format(" AND {0} {1} '%{2}%'", ((ComboBoxItem)cbField.SelectedItem).Value, ((ComboBoxItem)cbFilter.SelectedItem).Value, txtAccount.Text.Trim().Replace("'", "''"));
						}
						else
						{
							text6 += string.Format(" AND {0} {1} '{2}'", ((ComboBoxItem)cbField.SelectedItem).Value, ((ComboBoxItem)cbFilter.SelectedItem).Value, txtAccount.Text.Trim().Replace("'", "''"));
						}
					}
					else if (txtAccount.Text.Trim() != "")
					{
						text6 += string.Format(" AND [AC].[Id] LIKE '%{0}%'", txtAccount.Text.Trim().Replace("'", "''"));
					}
				}
				else if (cbChoise.SelectedIndex == 1)
				{
					text2 = "[CC].[AccountID]";
					text3 = "[CC].[Name] AS [当前角色], [CC].[cLevel] AS [等级], ";
					text4 = "[CC].[CtlCode]";
					text5 = string.Concat(new string[]
					{
						"[",
						frmMain.MU_SERVER,
						"].[",
						frmMain.MU_DB,
						"].[dbo].[Character] AS [CC] LEFT JOIN [",
						frmMain.MU_SERVER,
						"].[",
						frmMain.MU_DB,
						"].[dbo].[AccountCharacter] AS [AC] ON [AccountID] = [AC].[Id] COLLATE Chinese_PRC_CS_AS_KS_WS LEFT JOIN [MEMB_INFO] AS [info] ON [Id] = [info].[memb___id] COLLATE Chinese_PRC_CS_AS_KS_WS LEFT JOIN [MEMB_STAT] AS [stat] ON [info].[memb___id] = [stat].[memb___id] COLLATE Chinese_PRC_CS_AS_KS_WS"
					});
					if (cbEnvelop.Checked)
					{
						text6 += " AND ([CC].[CtlCode] = 1)";
					}
					if (cbRed.Checked)
					{
						text6 += " AND ([CC].[PkLevel] > 3)";
					}
					if (cbGM.Checked)
					{
						text6 += " AND ([CC].[CtlCode] > 1)";
					}
					if (cbField.SelectedIndex > 0)
					{
						if (cbFilter.SelectedIndex == cbFilter.Items.Count - 1)
						{
							text6 += string.Format(" AND {0} {1} '%{2}%'", ((ComboBoxItem)cbField.SelectedItem).Value, ((ComboBoxItem)cbFilter.SelectedItem).Value, txtAccount.Text.Trim().Replace("'", "''"));
						}
						else
						{
							text6 += string.Format(" AND {0} {1} '{2}'", ((ComboBoxItem)cbField.SelectedItem).Value, ((ComboBoxItem)cbFilter.SelectedItem).Value, txtAccount.Text.Trim().Replace("'", "''"));
						}
					}
					else if (txtAccount.Text.Trim() != "")
					{
						text6 += string.Format(" AND [info].[Name] LIKE '%{0}%'", txtAccount.Text.Trim().Replace("'", "''"));
					}
				}
				else
				{
					if (cbEnvelop.Checked)
					{
						text6 += " AND ([info].[bloc_code] = 1)";
					}
					if (txtAccount.Text.Trim() != "")
					{
						text6 += string.Format(" AND [info].[IP] LIKE '%{0}%'", txtAccount.Text.Trim().Replace("'", "''"));
					}
				}
				text = string.Format(format, new object[]
				{
					text2,
					text3,
					text4,
					text5,
					text6
				});
				OleDbCommand selectCommand = new OleDbCommand(text, frmBase.Me_Conn);
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
				DataTable dataTable = new DataTable();
				oleDbDataAdapter.Fill(dataTable);
				gvData.DataSource = dataTable;
			}
			catch (Exception ex)
			{
				Utils.WarningMessage(string.Concat(new string[]
				{
					"SQL：",
					text,
					"\nError:",
					ex.Message,
					"\nSource:",
					ex.Source,
					"\nTrace:",
					ex.StackTrace
				}));
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002164 File Offset: 0x00000364
		private void btnSearch_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bind();
			Cursor = Cursors.Default;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00005418 File Offset: 0x00003618
		private void gvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			Rectangle bounds = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, gvData.RowHeadersWidth - 4, e.RowBounds.Height);
			TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), gvData.RowHeadersDefaultCellStyle.Font, bounds, gvData.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000054B4 File Offset: 0x000036B4
		private void cbChoise_SelectedIndexChanged(object sender, EventArgs e)
		{
			gvData.DataSource = null;
			cbFilter.Items.Clear();
			cbField.Items.Clear();
			cbField.Items.Add(new ComboBoxItem("", ""));
			if (cbChoise.SelectedIndex != 0)
			{
				if (cbChoise.SelectedIndex == 1)
				{
					if (Utils.ChaFieldNames.Length == Utils.ChaFieldValues.Length)
					{
						for (int i = 0; i < Utils.ChaFieldNames.Length; i++)
						{
							cbField.Items.Add(new ComboBoxItem(Utils.ChaFieldNames[i], Utils.ChaFieldValues[i]));
						}
						return;
					}
					Utils.WarningMessage("配置文件出错！节点ChaFieldNames和ChaFieldValues数量不一致！");
				}
				return;
			}
			if (Utils.AccFieldNames.Length == Utils.AccFieldValues.Length)
			{
				for (int j = 0; j < Utils.AccFieldNames.Length; j++)
				{
					cbField.Items.Add(new ComboBoxItem(Utils.AccFieldNames[j], Utils.AccFieldValues[j]));
				}
				return;
			}
			Utils.WarningMessage("配置文件出错！节点AccFieldNames和AccFieldValues数量不一致！");
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000055CC File Offset: 0x000037CC
		private string getIDS(int index)
		{
			string text = "''";
			int index2 = cell + index % 2;
			foreach (object obj in gvData.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				object obj2 = text;
				text = string.Concat(new object[]
				{
					obj2,
					",'",
					dataGridViewRow.Cells[index2].Value,
					"'"
				});
			}
			if (text == "''" && gvData.CurrentRow != null)
			{
				object obj3 = text;
				text = string.Concat(new object[]
				{
					obj3,
					",'",
					gvData.CurrentRow.Cells[index2].Value,
					"'"
				});
			}
			if (text == "''")
			{
				Utils.WarningMessage("请选择要操作的行！");
				text = "";
			}
			return text;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000056FC File Offset: 0x000038FC
		private void operate(bool isXX, int val)
		{
			string text = "UPDATE {0} SET {1} = {2} WHERE {3} IN ({4})";
			try
			{
				string text2 = "[MEMB_INFO]";
				string text3 = "[bloc_code]";
				string text4 = "[memb___id]";
				if (isXX)
				{
					text2 = "[MEMB_STAT]";
					text3 = "[ConnectStat]";
				}
				else if (cbChoise.SelectedIndex == 1)
				{
					text2 = "[Character]";
					text3 = "[CtlCode]";
					text4 = "[Name]";
				}
				text = string.Format(text, new object[]
				{
					text2,
					text3,
					val,
					text4,
					getIDS(cbChoise.SelectedIndex)
				});
				if (frmBase.Me_ExecuteSQL(text))
				{
					Utils.InfoMessage("操作成功！");
				}
				else
				{
					Utils.WarningMessage("操作失败！");
				}
			}
			catch (Exception ex)
			{
				Utils.WarningMessage(string.Concat(new string[]
				{
					"SQL：",
					text,
					"\nError:",
					ex.Message,
					"\nSource:",
					ex.Source,
					"\nTrace:",
					ex.StackTrace
				}));
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00005824 File Offset: 0x00003A24
		private void gvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			if (e.RowIndex >= 0)
			{
				frmM.InputAccount(gvData.Rows[e.RowIndex].Cells[cell].Value.ToString());
				if (gvData.Rows[e.RowIndex].Cells[cell + 1].Value != null && gvData.Rows[e.RowIndex].Cells[cell + 1].Value.ToString() != "")
				{
					frmM.InputCharacter(gvData.Rows[e.RowIndex].Cells[cell + 1].Value.ToString());
				}
			}
			Cursor = Cursors.Default;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002182 File Offset: 0x00000382
		private void btnFH_Click(object sender, EventArgs e)
		{
			if (getIDS(0) == "")
			{
				return;
			}
			Cursor = Cursors.WaitCursor;
			operate(false, 1);
			bind();
			Cursor = Cursors.Default;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021BC File Offset: 0x000003BC
		private void btnJF_Click(object sender, EventArgs e)
		{
			if (getIDS(0) == "")
			{
				return;
			}
			Cursor = Cursors.WaitCursor;
			operate(false, 0);
			bind();
			Cursor = Cursors.Default;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021F6 File Offset: 0x000003F6
		private void btnXX_Click(object sender, EventArgs e)
		{
			if (getIDS(0) == "")
			{
				return;
			}
			Cursor = Cursors.WaitCursor;
			operate(true, 0);
			bind();
			Cursor = Cursors.Default;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002230 File Offset: 0x00000430
		private void frmUser_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmUser.form = null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002238 File Offset: 0x00000438
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005938 File Offset: 0x00003B38
		private void cbField_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbFilter.Items.Clear();
			if (cbField.SelectedIndex > 0)
			{
				for (int i = 0; i < Utils.SearchNames.Length; i++)
				{
					cbFilter.Items.Add(new ComboBoxItem(Utils.SearchNames[i], Utils.SearchValues[i]));
				}
				cbFilter.SelectedIndex = 0;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002240 File Offset: 0x00000440
		private void txtAccount_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				btnSearch_Click(sender, e);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002254 File Offset: 0x00000454
		private void gvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				gvData.Rows[e.RowIndex].Selected = true;
			}
		}

		// Token: 0x04000019 RID: 25
		private static frmUser form;

		// Token: 0x0400001A RID: 26
		private frmMain frmM;

		// Token: 0x0400001B RID: 27
		private int cell;
	}
}
