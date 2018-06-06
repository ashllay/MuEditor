namespace MuEditor
{
	// Token: 0x02000002 RID: 2
	public partial class frmBase : global::System.Windows.Forms.Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020E8 File Offset: 0x000002E8
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00003F38 File Offset: 0x00002138
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 262);
			base.Name = "frmBase";
			Text = "frmBase";
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;
	}
}
