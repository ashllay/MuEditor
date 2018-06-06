namespace MuEditor
{
	// Token: 0x0200001C RID: 28
	public partial class frmGuild : global::MuEditor.frmBase
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00003569 File Offset: 0x00001769
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00018BD4 File Offset: 0x00016DD4
		private void InitializeComponent()
		{
			cbGuild = new global::System.Windows.Forms.ComboBox();
			groupBox1 = new global::System.Windows.Forms.GroupBox();
			rbMember = new global::System.Windows.Forms.RadioButton();
			rbGuild = new global::System.Windows.Forms.RadioButton();
			btnSearch = new global::System.Windows.Forms.Button();
			txtName = new global::MuEditor.TextBox();
			lbMember = new global::System.Windows.Forms.ListBox();
			txtNotice = new global::MuEditor.TextBox();
			btnOK = new global::System.Windows.Forms.Button();
			label3 = new global::System.Windows.Forms.Label();
			label1 = new global::System.Windows.Forms.Label();
			label2 = new global::System.Windows.Forms.Label();
			label4 = new global::System.Windows.Forms.Label();
			lstUnion = new global::System.Windows.Forms.ListBox();
			lstRival = new global::System.Windows.Forms.ListBox();
			label5 = new global::System.Windows.Forms.Label();
			btnAdd = new global::System.Windows.Forms.Button();
			btnDel = new global::System.Windows.Forms.Button();
			label6 = new global::System.Windows.Forms.Label();
			txtScore = new global::MuEditor.TextBox();
			btnJS = new global::System.Windows.Forms.Button();
			groupBox1.SuspendLayout();
			base.SuspendLayout();
			cbGuild.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			cbGuild.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			cbGuild.DropDownHeight = 306;
			cbGuild.IntegralHeight = false;
			cbGuild.Location = new global::System.Drawing.Point(6, 62);
			cbGuild.Name = "cbGuild";
			cbGuild.Size = new global::System.Drawing.Size(115, 20);
			cbGuild.TabIndex = 2;
			cbGuild.SelectedIndexChanged += new global::System.EventHandler(cbGuild_SelectedIndexChanged);
			groupBox1.Controls.Add(rbMember);
			groupBox1.Controls.Add(rbGuild);
			groupBox1.Controls.Add(btnSearch);
			groupBox1.Controls.Add(txtName);
			groupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			groupBox1.Location = new global::System.Drawing.Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new global::System.Drawing.Size(300, 39);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "查询";
			rbMember.AutoSize = true;
			rbMember.Location = new global::System.Drawing.Point(196, 17);
			rbMember.Name = "rbMember";
			rbMember.Size = new global::System.Drawing.Size(47, 16);
			rbMember.TabIndex = 10;
			rbMember.Text = "成员";
			rbMember.UseVisualStyleBackColor = true;
			rbGuild.AutoSize = true;
			rbGuild.Checked = true;
			rbGuild.Location = new global::System.Drawing.Point(144, 18);
			rbGuild.Name = "rbGuild";
			rbGuild.Size = new global::System.Drawing.Size(47, 16);
			rbGuild.TabIndex = 9;
			rbGuild.TabStop = true;
			rbGuild.Text = "战盟";
			rbGuild.UseVisualStyleBackColor = true;
			btnSearch.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnSearch.Location = new global::System.Drawing.Point(244, 13);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new global::System.Drawing.Size(50, 23);
			btnSearch.TabIndex = 8;
			btnSearch.Text = "查 询";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += new global::System.EventHandler(btnSearch_Click);
			txtName.IsOnlyNumber = false;
			txtName.Location = new global::System.Drawing.Point(7, 15);
			txtName.MaxLength = 50;
			txtName.Name = "txtName";
			txtName.Size = new global::System.Drawing.Size(130, 21);
			txtName.TabIndex = 0;
			txtName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(txtName_KeyPress);
			lbMember.FormattingEnabled = true;
			lbMember.ItemHeight = 12;
			lbMember.Location = new global::System.Drawing.Point(126, 62);
			lbMember.Name = "lbMember";
			lbMember.Size = new global::System.Drawing.Size(167, 184);
			lbMember.TabIndex = 6;
			lbMember.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(lbMember_MouseDoubleClick);
			txtNotice.AcceptsReturn = true;
			txtNotice.IsOnlyNumber = false;
			txtNotice.Location = new global::System.Drawing.Point(70, 282);
			txtNotice.MaxLength = 60;
			txtNotice.Name = "txtNotice";
			txtNotice.Size = new global::System.Drawing.Size(178, 21);
			txtNotice.TabIndex = 7;
			btnOK.Enabled = false;
			btnOK.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnOK.Location = new global::System.Drawing.Point(254, 282);
			btnOK.Name = "btnOK";
			btnOK.Size = new global::System.Drawing.Size(39, 23);
			btnOK.TabIndex = 9;
			btnOK.Text = "更新";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += new global::System.EventHandler(btnOK_Click);
			label3.AutoSize = true;
			label3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label3.Location = new global::System.Drawing.Point(4, 288);
			label3.Name = "label3";
			label3.Size = new global::System.Drawing.Size(65, 12);
			label3.TabIndex = 10;
			label3.Text = "战盟公告：";
			label1.AutoSize = true;
			label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label1.Location = new global::System.Drawing.Point(124, 45);
			label1.Name = "label1";
			label1.Size = new global::System.Drawing.Size(77, 12);
			label1.TabIndex = 11;
			label1.Text = "战盟成员列表";
			label2.AutoSize = true;
			label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label2.Location = new global::System.Drawing.Point(5, 45);
			label2.Name = "label2";
			label2.Size = new global::System.Drawing.Size(53, 12);
			label2.TabIndex = 12;
			label2.Text = "战盟列表";
			label4.AutoSize = true;
			label4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label4.Location = new global::System.Drawing.Point(5, 87);
			label4.Name = "label4";
			label4.Size = new global::System.Drawing.Size(53, 12);
			label4.TabIndex = 13;
			label4.Text = "同盟战盟";
			lstUnion.FormattingEnabled = true;
			lstUnion.ItemHeight = 12;
			lstUnion.Location = new global::System.Drawing.Point(6, 102);
			lstUnion.Name = "lstUnion";
			lstUnion.Size = new global::System.Drawing.Size(115, 64);
			lstUnion.TabIndex = 14;
			lstUnion.SelectedIndexChanged += new global::System.EventHandler(lstUnion_SelectedIndexChanged);
			lstRival.FormattingEnabled = true;
			lstRival.ItemHeight = 12;
			lstRival.Location = new global::System.Drawing.Point(6, 185);
			lstRival.Name = "lstRival";
			lstRival.Size = new global::System.Drawing.Size(115, 64);
			lstRival.TabIndex = 15;
			lstRival.SelectedIndexChanged += new global::System.EventHandler(lstRival_SelectedIndexChanged);
			label5.AutoSize = true;
			label5.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label5.Location = new global::System.Drawing.Point(5, 169);
			label5.Name = "label5";
			label5.Size = new global::System.Drawing.Size(53, 12);
			label5.TabIndex = 16;
			label5.Text = "敌对战盟";
			btnAdd.Enabled = false;
			btnAdd.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnAdd.Location = new global::System.Drawing.Point(125, 251);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new global::System.Drawing.Size(61, 23);
			btnAdd.TabIndex = 17;
			btnAdd.Text = "添加成员";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += new global::System.EventHandler(btnAdd_Click);
			btnDel.Enabled = false;
			btnDel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnDel.Location = new global::System.Drawing.Point(190, 251);
			btnDel.Name = "btnDel";
			btnDel.Size = new global::System.Drawing.Size(61, 23);
			btnDel.TabIndex = 18;
			btnDel.Text = "删除成员";
			btnDel.UseVisualStyleBackColor = true;
			btnDel.Click += new global::System.EventHandler(btnDel_Click);
			label6.AutoSize = true;
			label6.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			label6.Location = new global::System.Drawing.Point(4, 260);
			label6.Name = "label6";
			label6.Size = new global::System.Drawing.Size(65, 12);
			label6.TabIndex = 20;
			label6.Text = "战盟积分：";
			txtScore.IsOnlyNumber = true;
			txtScore.Location = new global::System.Drawing.Point(70, 256);
			txtScore.Name = "txtScore";
			txtScore.Size = new global::System.Drawing.Size(43, 21);
			txtScore.TabIndex = 54;
			btnJS.Enabled = false;
			btnJS.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnJS.Location = new global::System.Drawing.Point(254, 251);
			btnJS.Name = "btnJS";
			btnJS.Size = new global::System.Drawing.Size(39, 23);
			btnJS.TabIndex = 55;
			btnJS.Text = "解散";
			btnJS.UseVisualStyleBackColor = true;
			btnJS.Click += new global::System.EventHandler(btnJS_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(300, 308);
			base.Controls.Add(btnJS);
			base.Controls.Add(txtScore);
			base.Controls.Add(label6);
			base.Controls.Add(btnDel);
			base.Controls.Add(btnAdd);
			base.Controls.Add(label5);
			base.Controls.Add(lstRival);
			base.Controls.Add(lstUnion);
			base.Controls.Add(label4);
			base.Controls.Add(label2);
			base.Controls.Add(label1);
			base.Controls.Add(label3);
			base.Controls.Add(btnOK);
			base.Controls.Add(txtNotice);
			base.Controls.Add(lbMember);
			base.Controls.Add(groupBox1);
			base.Controls.Add(cbGuild);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmGuild";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			Text = "战盟管理";
			base.TopMost = true;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(frmGuild_FormClosed);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001B0 RID: 432
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.ComboBox cbGuild;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.Button btnSearch;

		// Token: 0x040001B4 RID: 436
		private global::MuEditor.TextBox txtName;

		// Token: 0x040001B5 RID: 437
		private global::System.Windows.Forms.RadioButton rbMember;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.RadioButton rbGuild;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.ListBox lbMember;

		// Token: 0x040001B8 RID: 440
		private global::MuEditor.TextBox txtNotice;

		// Token: 0x040001B9 RID: 441
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x040001BA RID: 442
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001BB RID: 443
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001BC RID: 444
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001BD RID: 445
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040001BE RID: 446
		private global::System.Windows.Forms.ListBox lstUnion;

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Forms.ListBox lstRival;

		// Token: 0x040001C0 RID: 448
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040001C1 RID: 449
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040001C2 RID: 450
		private global::System.Windows.Forms.Button btnDel;

		// Token: 0x040001C3 RID: 451
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040001C4 RID: 452
		private global::MuEditor.TextBox txtScore;

		// Token: 0x040001C5 RID: 453
		private global::System.Windows.Forms.Button btnJS;
	}
}
