namespace MuEditor
{
	// Token: 0x0200000C RID: 12
	public partial class frmGuildUser : global::MuEditor.frmBase
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00002845 File Offset: 0x00000A45
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000141C0 File Offset: 0x000123C0
		private void InitializeComponent()
		{
			btnSearch = new global::System.Windows.Forms.Button();
			txtName = new global::MuEditor.TextBox();
			groupBox1 = new global::System.Windows.Forms.GroupBox();
			groupBox1.SuspendLayout();
			base.SuspendLayout();
			btnSearch.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnSearch.Location = new global::System.Drawing.Point(144, 20);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new global::System.Drawing.Size(50, 23);
			btnSearch.TabIndex = 10;
			btnSearch.Text = "确 定";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += new global::System.EventHandler(btnSearch_Click);
			txtName.IsOnlyNumber = false;
			txtName.Location = new global::System.Drawing.Point(8, 21);
			txtName.MaxLength = 50;
			txtName.Name = "txtName";
			txtName.Size = new global::System.Drawing.Size(130, 21);
			txtName.TabIndex = 9;
			txtName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(txtName_KeyPress);
			groupBox1.Controls.Add(btnSearch);
			groupBox1.Controls.Add(txtName);
			groupBox1.Location = new global::System.Drawing.Point(8, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new global::System.Drawing.Size(200, 60);
			groupBox1.TabIndex = 14;
			groupBox1.TabStop = false;
			groupBox1.Text = "请输入角色名";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(215, 74);
			base.Controls.Add(groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmGuildUser";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "添加战盟成员";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000129 RID: 297
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.Button btnSearch;

		// Token: 0x0400012B RID: 299
		private global::MuEditor.TextBox txtName;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
