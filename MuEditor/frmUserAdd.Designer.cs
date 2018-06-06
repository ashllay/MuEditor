namespace MuEditor
{
	// Token: 0x02000008 RID: 8
	public partial class frmUserAdd : global::MuEditor.frmBase
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000022F7 File Offset: 0x000004F7
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000060C4 File Offset: 0x000042C4
		private void InitializeComponent()
		{
			label3 = new global::System.Windows.Forms.Label();
			txtAccount = new global::MuEditor.TextBox();
			label1 = new global::System.Windows.Forms.Label();
			txtPwd = new global::MuEditor.TextBox();
			cbMD5 = new global::System.Windows.Forms.CheckBox();
			btnOK = new global::System.Windows.Forms.Button();
			btnClear = new global::System.Windows.Forms.Button();
			btnClose = new global::System.Windows.Forms.Button();
			groupBox1 = new global::System.Windows.Forms.GroupBox();
			label2 = new global::System.Windows.Forms.Label();
			txtArea = new global::MuEditor.TextBox();
			label7 = new global::System.Windows.Forms.Label();
			txtEMail = new global::MuEditor.TextBox();
			groupBox1.SuspendLayout();
			base.SuspendLayout();
			label3.AutoSize = true;
			label3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label3.Location = new global::System.Drawing.Point(7, 19);
			label3.Name = "label3";
			label3.Size = new global::System.Drawing.Size(41, 12);
			label3.TabIndex = 1;
			label3.Text = "帐号：";
			txtAccount.IsOnlyNumber = false;
			txtAccount.Location = new global::System.Drawing.Point(67, 15);
			txtAccount.MaxLength = 15;
			txtAccount.Name = "txtAccount";
			txtAccount.Size = new global::System.Drawing.Size(108, 21);
			txtAccount.TabIndex = 2;
			label1.AutoSize = true;
			label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label1.Location = new global::System.Drawing.Point(7, 46);
			label1.Name = "label1";
			label1.Size = new global::System.Drawing.Size(41, 12);
			label1.TabIndex = 3;
			label1.Text = "密码：";
			txtPwd.IsOnlyNumber = false;
			txtPwd.Location = new global::System.Drawing.Point(67, 42);
			txtPwd.MaxLength = 10;
			txtPwd.Name = "txtPwd";
			txtPwd.Size = new global::System.Drawing.Size(108, 21);
			txtPwd.TabIndex = 4;
			cbMD5.AutoSize = true;
			cbMD5.Checked = true;
			cbMD5.CheckState = global::System.Windows.Forms.CheckState.Checked;
			cbMD5.Enabled = false;
			cbMD5.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			cbMD5.Location = new global::System.Drawing.Point(67, 121);
			cbMD5.Name = "cbMD5";
			cbMD5.Size = new global::System.Drawing.Size(90, 16);
			cbMD5.TabIndex = 9;
			cbMD5.Text = "是否支持MD5";
			cbMD5.UseVisualStyleBackColor = true;
			btnOK.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnOK.Location = new global::System.Drawing.Point(9, 143);
			btnOK.Name = "btnOK";
			btnOK.Size = new global::System.Drawing.Size(51, 21);
			btnOK.TabIndex = 10;
			btnOK.Text = "创 建";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += new global::System.EventHandler(btnOK_Click);
			btnClear.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnClear.Location = new global::System.Drawing.Point(67, 143);
			btnClear.Name = "btnClear";
			btnClear.Size = new global::System.Drawing.Size(51, 21);
			btnClear.TabIndex = 11;
			btnClear.Text = "重 填";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += new global::System.EventHandler(btnClear_Click);
			btnClose.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnClose.Location = new global::System.Drawing.Point(124, 143);
			btnClose.Name = "btnClose";
			btnClose.Size = new global::System.Drawing.Size(51, 21);
			btnClose.TabIndex = 12;
			btnClose.Text = "关 闭";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += new global::System.EventHandler(btnClose_Click);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtArea);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(btnClose);
			groupBox1.Controls.Add(txtAccount);
			groupBox1.Controls.Add(btnClear);
			groupBox1.Controls.Add(txtPwd);
			groupBox1.Controls.Add(cbMD5);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(btnOK);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(txtEMail);
			groupBox1.Location = new global::System.Drawing.Point(4, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new global::System.Drawing.Size(182, 172);
			groupBox1.TabIndex = 67;
			groupBox1.TabStop = false;
			groupBox1.Text = "添加帐号";
			label2.AutoSize = true;
			label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label2.Location = new global::System.Drawing.Point(7, 97);
			label2.Name = "label2";
			label2.Size = new global::System.Drawing.Size(41, 12);
			label2.TabIndex = 7;
			label2.Text = "大区：";
			txtArea.IsOnlyNumber = true;
			txtArea.Location = new global::System.Drawing.Point(67, 94);
			txtArea.MaxLength = 2;
			txtArea.Name = "txtArea";
			txtArea.Size = new global::System.Drawing.Size(108, 21);
			txtArea.TabIndex = 8;
			txtArea.Text = "1";
			label7.AutoSize = true;
			label7.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label7.Location = new global::System.Drawing.Point(7, 72);
			label7.Name = "label7";
			label7.Size = new global::System.Drawing.Size(47, 12);
			label7.TabIndex = 5;
			label7.Text = "EMail：";
			txtEMail.Enabled = false;
			txtEMail.IsOnlyNumber = false;
			txtEMail.Location = new global::System.Drawing.Point(67, 69);
			txtEMail.MaxLength = 50;
			txtEMail.Name = "txtEMail";
			txtEMail.Size = new global::System.Drawing.Size(108, 21);
			txtEMail.TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(192, 180);
			base.Controls.Add(groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmUserAdd";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "添加帐号";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(frmUserAdd_FormClosed);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400004C RID: 76
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400004E RID: 78
		private global::MuEditor.TextBox txtAccount;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000050 RID: 80
		private global::MuEditor.TextBox txtPwd;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.CheckBox cbMD5;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Button btnClear;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000057 RID: 87
		private global::MuEditor.TextBox txtEMail;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000059 RID: 89
		private global::MuEditor.TextBox txtArea;
	}
}
