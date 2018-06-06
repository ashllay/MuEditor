using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace MuEditor
{
	// Token: 0x0200001C RID: 28
	public partial class frmGuild : frmBase
	{
		// Token: 0x0600019C RID: 412 RVA: 0x00003588 File Offset: 0x00001788
		public static frmGuild GetInstance(frmMain frm)
		{
			if (frmGuild.form == null)
			{
				frmGuild.form = new frmGuild(frm);
			}
			return frmGuild.form;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000035A1 File Offset: 0x000017A1
		private frmGuild(frmMain frm)
		{
			this.InitializeComponent();
			this.frmM = frm;
			this.init();
			this.bind();
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000198FC File Offset: 0x00017AFC
		private void init()
		{
			string text = "SELECT Number, G_Name, G_Score, G_Notice, G_Rival, G_Union FROM Guild";
			try
			{
				OleDbCommand selectCommand = new OleDbCommand(text, frmBase.Mu_Conn);
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
				DataTable dataTable = new DataTable();
				oleDbDataAdapter.Fill(dataTable);
				this.dv = dataTable.DefaultView;
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

		// Token: 0x0600019F RID: 415 RVA: 0x000199B0 File Offset: 0x00017BB0
		private void bind()
		{
			string text = "SELECT DISTINCT a.G_Name FROM Guild AS a INNER JOIN GuildMember AS b ON a.G_Name = b.G_Name COLLATE Chinese_PRC_CS_AS_KS_WS {0}";
			try
			{
				this.cbGuild.Items.Clear();
				this.lbMember.Items.Clear();
				this.lstUnion.Items.Clear();
				this.lstRival.Items.Clear();
				string arg = "where 1=1";
				if (this.txtName.Text.Trim() != "")
				{
					arg = (this.rbMember.Checked ? "Name" : "a.G_Name");
					arg = string.Format("WHERE {0} LIKE '%{1}%'", arg, this.txtName.Text.Trim().Replace("'", "''"));
				}
				OleDbCommand selectCommand = new OleDbCommand(string.Format(text, arg), frmBase.Mu_Conn);
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
				DataTable dataTable = new DataTable();
				oleDbDataAdapter.Fill(dataTable);
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					this.cbGuild.Items.Add(dataRow[0].ToString().Trim());
				}
				this.btnAdd.Enabled = (this.cbGuild.Items.Count > 0);
				this.btnDel.Enabled = (this.cbGuild.Items.Count > 0);
				this.btnJS.Enabled = (this.cbGuild.Items.Count > 0);
				this.btnOK.Enabled = (this.cbGuild.Items.Count > 0);
				if (this.cbGuild.Items.Count > 0)
				{
					this.cbGuild.SelectedIndex = 0;
				}
				else
				{
					this.txtNotice.Text = "";
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

		// Token: 0x060001A0 RID: 416 RVA: 0x000035C2 File Offset: 0x000017C2
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.bind();
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000035E0 File Offset: 0x000017E0
		private void frmGuild_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmGuild.form = null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00019C38 File Offset: 0x00017E38
		private void cbGuild_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.lbMember.Items.Clear();
			string text = "SELECT Name, G_Status FROM GuildMember WHERE (G_Name = '" + this.cbGuild.SelectedItem.ToString().Replace("'", "''") + "') ORDER BY G_Status DESC";
			try
			{
				OleDbCommand selectCommand = new OleDbCommand(text, frmBase.Mu_Conn);
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
				DataTable dataTable = new DataTable();
				oleDbDataAdapter.Fill(dataTable);
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					int num = Convert.ToInt32(dataRow[1]);
					if (num > 0)
					{
						string arg = "盟主";
						if (num == 32)
						{
							arg = "战斗队长";
						}
						else if (num == 64)
						{
							arg = "副盟主";
						}
						this.lbMember.Items.Add(string.Format("{0}[{1}]", dataRow[0].ToString().Trim(), arg));
					}
					else
					{
						this.lbMember.Items.Add(dataRow[0].ToString().Trim());
					}
				}
				this.dv.RowFilter = "(G_Name = '" + this.cbGuild.SelectedItem.ToString().Replace("'", "''") + "')";
				string arg2 = "0";
				string arg3 = "0";
				string arg4 = "0";
				if (this.dv.Count > 0)
				{
					this.txtScore.Text = Convert.ToString(this.dv[0]["G_Score"]);
					this.txtScore.Text = ((this.txtScore.Text == "") ? "0" : this.txtScore.Text);
					this.txtNotice.Text = Convert.ToString(this.dv[0]["G_Notice"]);
					arg2 = Convert.ToString(this.dv[0]["G_Union"]);
					arg3 = Convert.ToString(this.dv[0]["G_Rival"]);
					arg4 = Convert.ToString(this.dv[0]["Number"]);
				}
				this.lstUnion.Items.Clear();
				this.dv.RowFilter = string.Format("(G_Union <> 0 AND G_Name <> '{0}' AND G_Union = {1}) OR (G_Name <> '{0}' AND G_Union = {2})", this.cbGuild.SelectedItem.ToString().Replace("'", "''"), arg2, arg4);
				for (int i = 0; i < this.dv.Count; i++)
				{
					this.lstUnion.Items.Add(Convert.ToString(this.dv[i]["G_Name"]));
				}
				this.lstRival.Items.Clear();
				this.dv.RowFilter = string.Format("(G_Rival <> 0 AND G_Name <> '{0}' AND G_Rival = {1}) OR (G_Name <> '{0}' AND G_Rival = {2})", this.cbGuild.SelectedItem.ToString().Replace("'", "''"), arg3, arg4);
				for (int j = 0; j < this.dv.Count; j++)
				{
					if (!this.lstUnion.Items.Contains(Convert.ToString(this.dv[j]["G_Name"])))
					{
						this.lstRival.Items.Add(Convert.ToString(this.dv[j]["G_Name"]));
					}
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
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001A0A4 File Offset: 0x000182A4
		private void lbMember_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			if (this.lbMember.SelectedItem != null)
			{
				this.frmM.InputCharacter(this.lbMember.SelectedItem.ToString().Split(new char[]
				{
					'['
				})[0]);
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001A104 File Offset: 0x00018304
		private void btnOK_Click(object sender, EventArgs e)
		{
			string text = "";
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (this.cbGuild.SelectedIndex == -1)
				{
					return;
				}
				text = string.Format("UPDATE Guild SET G_Score = {0}, G_Notice = '{1}' WHERE (G_Name = '{2}')", this.txtScore.Text.Replace(" ", ""), this.txtNotice.Text.Replace("'", "''"), this.cbGuild.SelectedItem.ToString().Replace("'", "''"));
				if (frmBase.Mu_ExecuteSQL(text))
				{
					this.init();
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
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000035E8 File Offset: 0x000017E8
		private void lstUnion_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.cbGuild.SelectedItem = this.lstUnion.SelectedItem.ToString();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00003605 File Offset: 0x00001805
		private void lstRival_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.cbGuild.SelectedItem = this.lstRival.SelectedItem.ToString();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001A22C File Offset: 0x0001842C
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string text = "INSERT INTO GuildMember (Name, G_Name, G_Level, G_Status) VALUES ('{0}', '{1}', 1, 0)";
			try
			{
				this.Cursor = Cursors.WaitCursor;
				frmGuild.joinName = "";
				frmGuildUser frmGuildUser = new frmGuildUser();
				frmGuildUser.ShowDialog(this);
				if (frmGuild.joinName != "")
				{
					OleDbCommand oleDbCommand = new OleDbCommand(string.Format("SELECT 1 FROM Character WHERE (Name = '{0}')", frmGuild.joinName), frmBase.Mu_Conn);
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					if (oleDbDataReader.Read())
					{
						if (frmBase.Mu_ExecuteSQL(string.Format(text, frmGuild.joinName, this.cbGuild.SelectedItem.ToString().Replace("'", "''"))))
						{
							string selectedItem = this.cbGuild.SelectedItem.ToString();
							this.init();
							this.bind();
							this.cbGuild.SelectedItem = selectedItem;
							Utils.InfoMessage("操作成功！");
						}
						else
						{
							Utils.WarningMessage("操作失败！");
						}
					}
					else
					{
						Utils.WarningMessage("不存在的角色！");
					}
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
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001A3A0 File Offset: 0x000185A0
		private void btnDel_Click(object sender, EventArgs e)
		{
			string text = "DELETE FROM GuildMember WHERE (Name = '{0}')";
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (this.lbMember.SelectedIndex == -1)
				{
					Utils.WarningMessage("请选择要删除的成员！");
					this.Cursor = Cursors.Default;
					return;
				}
				string text2 = this.lbMember.SelectedItem.ToString();
				if (text2 != "[盟主]" && text2.EndsWith("[盟主]"))
				{
					Utils.WarningMessage("不可以删除盟主！");
					this.Cursor = Cursors.Default;
					return;
				}
				if (frmBase.Mu_ExecuteSQL(string.Format(text, text2.Replace("'", "''").Replace("[副盟主]", "").Replace("[战斗队长]", ""))))
				{
					string selectedItem = this.cbGuild.SelectedItem.ToString();
					this.init();
					this.bind();
					this.cbGuild.SelectedItem = selectedItem;
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
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001A524 File Offset: 0x00018724
		private void btnJS_Click(object sender, EventArgs e)
		{
			string text = "DELETE FROM GuildMember WHERE (G_Name = '{0}');DELETE FROM Guild WHERE (G_Name = '{0}')";
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (MessageBox.Show("你确定要解散当前战盟“" + this.cbGuild.SelectedItem + "”吗？", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (frmBase.Mu_ExecuteSQL(string.Format(text, this.cbGuild.SelectedItem.ToString().Replace("'", "''"))))
					{
						this.init();
						this.bind();
						Utils.InfoMessage("操作成功！");
					}
					else
					{
						Utils.WarningMessage("操作失败！");
					}
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
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00003622 File Offset: 0x00001822
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				this.btnSearch_Click(sender, e);
			}
		}

		// Token: 0x040001C6 RID: 454
		public static string joinName = "";

		// Token: 0x040001C7 RID: 455
		private static frmGuild form = null;

		// Token: 0x040001C8 RID: 456
		private frmMain frmM;

		// Token: 0x040001C9 RID: 457
		private DataView dv;
	}
}
