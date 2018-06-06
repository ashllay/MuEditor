using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace MuEditor
{
	// Token: 0x02000008 RID: 8
	public partial class frmUserAdd : frmBase
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002316 File Offset: 0x00000516
		private frmUserAdd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002324 File Offset: 0x00000524
		public static frmUserAdd GetInstance()
		{
			if (frmUserAdd.form == null)
			{
				frmUserAdd.form = new frmUserAdd();
			}
			return frmUserAdd.form;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002238 File Offset: 0x00000438
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000233C File Offset: 0x0000053C
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.txtAccount.Text = "";
			this.txtEMail.Text = "";
			this.txtPwd.Text = "";
			this.cbMD5.Checked = false;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00006900 File Offset: 0x00004B00
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (frmBase.Me_Conn.State != ConnectionState.Open)
			{
				return;
			}
			string text = "SELECT memb_guid FROM MEMB_INFO WHERE memb___id = '{0}'";
			try
			{
				if (!Validator.UserName(this.txtAccount.Text.Trim()))
				{
					Utils.WarningMessage("帐号为4-10位数字、字母或下划线！");
				}
				else if (!Validator.PassWord(this.txtPwd.Text.Trim()))
				{
					Utils.WarningMessage("密码为4-10位字符！");
				}
				else
				{
					text = string.Format(text, this.txtAccount.Text.Trim());
					OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					if (oleDbDataReader.Read())
					{
						Utils.WarningMessage("对不起，帐号[" + this.txtAccount.Text.Trim() + "]已被注册！");
						oleDbDataReader.Close();
					}
					else
					{
						oleDbDataReader.Close();
						text = string.Format("DECLARE @Result_Data tinyint; EXEC [dbo].[CreateAccount] @memb___id = N'{0}', @memb__pwd = N'{1}', @mail_addr = N'{2}', @GiftAmount = {3}, @Area_Code = {4}, @Result_Data = @Result_Data OUTPUT; SELECT @Result_Data as N'@Result_Data'", new object[]
						{
							this.txtAccount.Text.Trim(),
							this.txtPwd.Text.Trim(),
							this.txtAccount.Text.Trim() + "@kemp.tw",
							0,
							(Convert.ToInt32(this.txtArea.Text) - 1).ToString()
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

		// Token: 0x06000037 RID: 55 RVA: 0x0000237A File Offset: 0x0000057A
		private void frmUserAdd_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmUserAdd.form = null;
		}

		// Token: 0x0400005A RID: 90
		private static frmUserAdd form;
	}
}
