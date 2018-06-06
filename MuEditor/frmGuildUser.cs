using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MuEditor
{
	// Token: 0x0200000C RID: 12
	public partial class frmGuildUser : frmBase
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00002864 File Offset: 0x00000A64
		public frmGuildUser()
		{
			InitializeComponent();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002872 File Offset: 0x00000A72
		private void btnSearch_Click(object sender, EventArgs e)
		{
			frmGuild.joinName = txtName.Text.Trim().Replace("'", "''");
			base.Close();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000289E File Offset: 0x00000A9E
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				btnSearch_Click(sender, e);
			}
		}
	}
}
