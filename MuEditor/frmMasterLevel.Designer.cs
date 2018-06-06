namespace MuEditor
{
	// Token: 0x02000009 RID: 9
	public partial class frmMasterLevel : global::MuEditor.frmBase
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002382 File Offset: 0x00000582
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006AF4 File Offset: 0x00004CF4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MuEditor.frmMasterLevel));
			txtPoint = new global::MuEditor.TextBox();
			label32 = new global::System.Windows.Forms.Label();
			txtNextEXP = new global::MuEditor.TextBox();
			label31 = new global::System.Windows.Forms.Label();
			txtEXP = new global::MuEditor.TextBox();
			label30 = new global::System.Windows.Forms.Label();
			txtLevel = new global::MuEditor.TextBox();
			label29 = new global::System.Windows.Forms.Label();
			btnOK = new global::System.Windows.Forms.Button();
			label1 = new global::System.Windows.Forms.Label();
			button1 = new global::System.Windows.Forms.Button();
			txtCharacter = new global::MuEditor.TextBox();
			label2 = new global::System.Windows.Forms.Label();
			rbAll = new global::System.Windows.Forms.RadioButton();
			rbKeep = new global::System.Windows.Forms.RadioButton();
			rbClear = new global::System.Windows.Forms.RadioButton();
			groupBox1 = new global::System.Windows.Forms.GroupBox();
			groupBox1.SuspendLayout();
			base.SuspendLayout();
			txtPoint.IsOnlyNumber = true;
			txtPoint.Location = new global::System.Drawing.Point(70, 124);
			txtPoint.Name = "txtPoint";
			txtPoint.Size = new global::System.Drawing.Size(144, 21);
			txtPoint.TabIndex = 59;
			label32.AutoSize = true;
			label32.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label32.Location = new global::System.Drawing.Point(6, 128);
			label32.Name = "label32";
			label32.Size = new global::System.Drawing.Size(41, 12);
			label32.TabIndex = 58;
			label32.Text = "剩点：";
			txtNextEXP.IsOnlyNumber = true;
			txtNextEXP.Location = new global::System.Drawing.Point(70, 97);
			txtNextEXP.Name = "txtNextEXP";
			txtNextEXP.Size = new global::System.Drawing.Size(144, 21);
			txtNextEXP.TabIndex = 57;
			label31.AutoSize = true;
			label31.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label31.Location = new global::System.Drawing.Point(6, 101);
			label31.Name = "label31";
			label31.Size = new global::System.Drawing.Size(65, 12);
			label31.TabIndex = 56;
			label31.Text = "下级经验：";
			txtEXP.IsOnlyNumber = true;
			txtEXP.Location = new global::System.Drawing.Point(70, 70);
			txtEXP.Name = "txtEXP";
			txtEXP.Size = new global::System.Drawing.Size(144, 21);
			txtEXP.TabIndex = 55;
			label30.AutoSize = true;
			label30.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label30.Location = new global::System.Drawing.Point(6, 74);
			label30.Name = "label30";
			label30.Size = new global::System.Drawing.Size(41, 12);
			label30.TabIndex = 54;
			label30.Text = "经验：";
			txtLevel.IsOnlyNumber = true;
			txtLevel.Location = new global::System.Drawing.Point(71, 43);
			txtLevel.Name = "txtLevel";
			txtLevel.Size = new global::System.Drawing.Size(144, 21);
			txtLevel.TabIndex = 53;
			txtLevel.TextChanged += new global::System.EventHandler(txtLevel_TextChanged);
			label29.AutoSize = true;
			label29.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label29.Location = new global::System.Drawing.Point(6, 47);
			label29.Name = "label29";
			label29.Size = new global::System.Drawing.Size(41, 12);
			label29.TabIndex = 52;
			label29.Text = "等级：";
			btnOK.Location = new global::System.Drawing.Point(41, 186);
			btnOK.Name = "btnOK";
			btnOK.Size = new global::System.Drawing.Size(58, 23);
			btnOK.TabIndex = 60;
			btnOK.Text = "确 定";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += new global::System.EventHandler(btnOK_Click);
			label1.AutoSize = true;
			label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label1.Location = new global::System.Drawing.Point(6, 20);
			label1.Name = "label1";
			label1.Size = new global::System.Drawing.Size(41, 12);
			label1.TabIndex = 61;
			label1.Text = "角色：";
			button1.Location = new global::System.Drawing.Point(118, 186);
			button1.Name = "button1";
			button1.Size = new global::System.Drawing.Size(58, 23);
			button1.TabIndex = 63;
			button1.Text = "关 闭";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new global::System.EventHandler(button1_Click);
			txtCharacter.IsOnlyNumber = false;
			txtCharacter.Location = new global::System.Drawing.Point(71, 16);
			txtCharacter.Name = "txtCharacter";
			txtCharacter.ReadOnly = true;
			txtCharacter.Size = new global::System.Drawing.Size(144, 21);
			txtCharacter.TabIndex = 64;
			label2.AutoSize = true;
			label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label2.Location = new global::System.Drawing.Point(6, 156);
			label2.Name = "label2";
			label2.Size = new global::System.Drawing.Size(65, 12);
			label2.TabIndex = 65;
			label2.Text = "大师技能：";
			rbAll.AutoSize = true;
			rbAll.Location = new global::System.Drawing.Point(71, 156);
			rbAll.Name = "rbAll";
			rbAll.Size = new global::System.Drawing.Size(47, 16);
			rbAll.TabIndex = 66;
			rbAll.Text = "全满";
			rbAll.UseVisualStyleBackColor = true;
			rbKeep.AutoSize = true;
			rbKeep.Checked = true;
			rbKeep.Location = new global::System.Drawing.Point(119, 156);
			rbKeep.Name = "rbKeep";
			rbKeep.Size = new global::System.Drawing.Size(47, 16);
			rbKeep.TabIndex = 67;
			rbKeep.TabStop = true;
			rbKeep.Text = "不变";
			rbKeep.UseVisualStyleBackColor = true;
			rbClear.AutoSize = true;
			rbClear.Location = new global::System.Drawing.Point(169, 156);
			rbClear.Name = "rbClear";
			rbClear.Size = new global::System.Drawing.Size(47, 16);
			rbClear.TabIndex = 68;
			rbClear.Text = "清空";
			rbClear.UseVisualStyleBackColor = true;
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(rbClear);
			groupBox1.Controls.Add(label29);
			groupBox1.Controls.Add(rbKeep);
			groupBox1.Controls.Add(txtLevel);
			groupBox1.Controls.Add(rbAll);
			groupBox1.Controls.Add(label30);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtEXP);
			groupBox1.Controls.Add(txtCharacter);
			groupBox1.Controls.Add(label31);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(txtNextEXP);
			groupBox1.Controls.Add(label32);
			groupBox1.Controls.Add(btnOK);
			groupBox1.Controls.Add(txtPoint);
			groupBox1.Location = new global::System.Drawing.Point(6, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new global::System.Drawing.Size(221, 218);
			groupBox1.TabIndex = 69;
			groupBox1.TabStop = false;
			groupBox1.Text = "修改大师信息";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(233, 227);
			base.Controls.Add(groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmMasterLevel";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "修改大师";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400005B RID: 91
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400005C RID: 92
		private global::MuEditor.TextBox txtPoint;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Label label32;

		// Token: 0x0400005E RID: 94
		private global::MuEditor.TextBox txtNextEXP;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Label label31;

		// Token: 0x04000060 RID: 96
		private global::MuEditor.TextBox txtEXP;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label label30;

		// Token: 0x04000062 RID: 98
		private global::MuEditor.TextBox txtLevel;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000067 RID: 103
		private global::MuEditor.TextBox txtCharacter;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.RadioButton rbAll;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.RadioButton rbKeep;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.RadioButton rbClear;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
