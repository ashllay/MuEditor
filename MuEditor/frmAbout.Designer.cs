namespace MuEditor
{
	// Token: 0x02000027 RID: 39
	public partial class frmAbout : global::System.Windows.Forms.Form
	{
		// Token: 0x06000229 RID: 553 RVA: 0x00003A41 File Offset: 0x00001C41
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000269E8 File Offset: 0x00024BE8
		private void InitializeComponent()
		{
			txtName = new global::MuEditor.TextBox();
			pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			base.SuspendLayout();
			txtName.IsOnlyNumber = false;
			txtName.Location = new global::System.Drawing.Point(166, 2);
			txtName.Multiline = true;
			txtName.Name = "txtName";
			txtName.ReadOnly = true;
			txtName.Size = new global::System.Drawing.Size(234, 164);
			txtName.TabIndex = 33;
			txtName.Text = "最新版奇迹管理器支持 eX700、eX701、eX702、eX801、eX802、eX902 等版本，完美支持镶嵌属性，包含新武器、新宠物物品等，无任何不良程序（病毒、后门等）\r\n\r\n持续提供更新中。。。欢迎您对本软件提出宝贵意见!   承接各类奇迹网站、软件开发、制作、修改等\r\n\r\nMuEditor V3.6.0.0 By lvtx\r\n\r\n作者QQ：№";
			pictureBox1.BackgroundImage = global::MuEditor.Properties.Resources.Top;
			pictureBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			pictureBox1.InitialImage = null;
			pictureBox1.Location = new global::System.Drawing.Point(2, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new global::System.Drawing.Size(158, 165);
			pictureBox1.TabIndex = 34;
			pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(405, 175);
			base.Controls.Add(pictureBox1);
			base.Controls.Add(txtName);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmAbout";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "About";
			((global::System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400026A RID: 618
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400026B RID: 619
		private global::MuEditor.TextBox txtName;

		// Token: 0x0400026C RID: 620
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
