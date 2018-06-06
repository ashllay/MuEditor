namespace MuEditor
{
	// Token: 0x02000003 RID: 3
	public partial class frmUser : global::MuEditor.frmBase
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000212B File Offset: 0x0000032B
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000040B4 File Offset: 0x000022B4
		private void InitializeComponent()
		{
			components = new global::System.ComponentModel.Container();
			txtAccount = new global::MuEditor.TextBox();
			cbChoise = new global::System.Windows.Forms.ComboBox();
			groupBox1 = new global::System.Windows.Forms.GroupBox();
			cbGM = new global::System.Windows.Forms.CheckBox();
			cbRed = new global::System.Windows.Forms.CheckBox();
			cbFilter = new global::System.Windows.Forms.ComboBox();
			cbField = new global::System.Windows.Forms.ComboBox();
			btnSearch = new global::System.Windows.Forms.Button();
			cbOnline = new global::System.Windows.Forms.CheckBox();
			cbEnvelop = new global::System.Windows.Forms.CheckBox();
			gvData = new global::System.Windows.Forms.DataGridView();
			groupBox2 = new global::System.Windows.Forms.GroupBox();
			btnCancel = new global::System.Windows.Forms.Button();
			btnXX = new global::System.Windows.Forms.Button();
			btnJF = new global::System.Windows.Forms.Button();
			btnFH = new global::System.Windows.Forms.Button();
			ccmsMenu = new global::System.Windows.Forms.ContextMenuStrip(components);
			toolStripMenuItem_0 = new global::System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem_1 = new global::System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem_2 = new global::System.Windows.Forms.ToolStripMenuItem();
			groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)gvData).BeginInit();
			groupBox2.SuspendLayout();
			ccmsMenu.SuspendLayout();
			base.SuspendLayout();
			txtAccount.IsOnlyNumber = false;
			txtAccount.Location = new global::System.Drawing.Point(217, 15);
			txtAccount.MaxLength = 50;
			txtAccount.Name = "txtAccount";
			txtAccount.Size = new global::System.Drawing.Size(127, 21);
			txtAccount.TabIndex = 0;
			txtAccount.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(txtAccount_KeyPress);
			cbChoise.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbChoise.FormattingEnabled = true;
			cbChoise.Items.AddRange(new object[]
			{
				"帐号",
				"角色",
				"IP"
			});
			cbChoise.Location = new global::System.Drawing.Point(12, 15);
			cbChoise.Name = "cbChoise";
			cbChoise.Size = new global::System.Drawing.Size(52, 20);
			cbChoise.TabIndex = 1;
			cbChoise.SelectedIndexChanged += new global::System.EventHandler(cbChoise_SelectedIndexChanged);
			groupBox1.Controls.Add(cbGM);
			groupBox1.Controls.Add(cbRed);
			groupBox1.Controls.Add(cbFilter);
			groupBox1.Controls.Add(cbField);
			groupBox1.Controls.Add(btnSearch);
			groupBox1.Controls.Add(cbOnline);
			groupBox1.Controls.Add(cbEnvelop);
			groupBox1.Controls.Add(cbChoise);
			groupBox1.Controls.Add(txtAccount);
			groupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			groupBox1.Location = new global::System.Drawing.Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new global::System.Drawing.Size(604, 39);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "查询";
			cbGM.AutoSize = true;
			cbGM.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			cbGM.Location = new global::System.Drawing.Point(501, 17);
			cbGM.Name = "cbGM";
			cbGM.Size = new global::System.Drawing.Size(36, 16);
			cbGM.TabIndex = 12;
			cbGM.Text = "GM";
			cbGM.UseVisualStyleBackColor = true;
			cbRed.AutoSize = true;
			cbRed.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			cbRed.Location = new global::System.Drawing.Point(450, 17);
			cbRed.Name = "cbRed";
			cbRed.Size = new global::System.Drawing.Size(48, 16);
			cbRed.TabIndex = 11;
			cbRed.Text = "红名";
			cbRed.UseVisualStyleBackColor = true;
			cbFilter.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbFilter.FormattingEnabled = true;
			cbFilter.Items.AddRange(new object[]
			{
				"帐号",
				"角色",
				"IP"
			});
			cbFilter.Location = new global::System.Drawing.Point(167, 15);
			cbFilter.Name = "cbFilter";
			cbFilter.Size = new global::System.Drawing.Size(46, 20);
			cbFilter.TabIndex = 10;
			cbField.DropDownHeight = 306;
			cbField.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbField.FormattingEnabled = true;
			cbField.IntegralHeight = false;
			cbField.Items.AddRange(new object[]
			{
				"帐号",
				"角色",
				"IP"
			});
			cbField.Location = new global::System.Drawing.Point(69, 15);
			cbField.Name = "cbField";
			cbField.Size = new global::System.Drawing.Size(94, 20);
			cbField.TabIndex = 9;
			cbField.SelectedIndexChanged += new global::System.EventHandler(cbField_SelectedIndexChanged);
			btnSearch.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnSearch.Location = new global::System.Drawing.Point(543, 13);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new global::System.Drawing.Size(50, 23);
			btnSearch.TabIndex = 8;
			btnSearch.Text = "查 询";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += new global::System.EventHandler(btnSearch_Click);
			cbOnline.AutoSize = true;
			cbOnline.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			cbOnline.Location = new global::System.Drawing.Point(399, 17);
			cbOnline.Name = "cbOnline";
			cbOnline.Size = new global::System.Drawing.Size(48, 16);
			cbOnline.TabIndex = 7;
			cbOnline.Text = "在线";
			cbOnline.UseVisualStyleBackColor = true;
			cbEnvelop.AutoSize = true;
			cbEnvelop.Location = new global::System.Drawing.Point(349, 17);
			cbEnvelop.Name = "cbEnvelop";
			cbEnvelop.Size = new global::System.Drawing.Size(48, 16);
			cbEnvelop.TabIndex = 6;
			cbEnvelop.Text = "被封";
			cbEnvelop.UseVisualStyleBackColor = true;
			gvData.AllowUserToAddRows = false;
			gvData.AllowUserToDeleteRows = false;
			gvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gvData.Location = new global::System.Drawing.Point(0, 43);
			gvData.Name = "gvData";
			gvData.ReadOnly = true;
			gvData.RowHeadersWidth = 30;
			gvData.RowTemplate.Height = 23;
			gvData.Size = new global::System.Drawing.Size(604, 279);
			gvData.TabIndex = 6;
			gvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(gvData_CellClick);
			gvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(gvData_CellDoubleClick);
			gvData.RowPostPaint += new global::System.Windows.Forms.DataGridViewRowPostPaintEventHandler(gvData_RowPostPaint);
			groupBox2.Controls.Add(btnCancel);
			groupBox2.Controls.Add(btnXX);
			groupBox2.Controls.Add(btnJF);
			groupBox2.Controls.Add(btnFH);
			groupBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			groupBox2.Location = new global::System.Drawing.Point(0, 328);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new global::System.Drawing.Size(604, 39);
			groupBox2.TabIndex = 7;
			groupBox2.TabStop = false;
			groupBox2.Text = "操作";
			btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			btnCancel.Location = new global::System.Drawing.Point(402, 13);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new global::System.Drawing.Size(50, 23);
			btnCancel.TabIndex = 35;
			btnCancel.Text = "关 闭";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += new global::System.EventHandler(btnCancel_Click);
			btnXX.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnXX.Location = new global::System.Drawing.Point(319, 13);
			btnXX.Name = "btnXX";
			btnXX.Size = new global::System.Drawing.Size(71, 23);
			btnXX.TabIndex = 11;
			btnXX.Text = "批量下线";
			btnXX.UseVisualStyleBackColor = true;
			btnXX.Click += new global::System.EventHandler(btnXX_Click);
			btnJF.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnJF.Location = new global::System.Drawing.Point(236, 13);
			btnJF.Name = "btnJF";
			btnJF.Size = new global::System.Drawing.Size(71, 23);
			btnJF.TabIndex = 10;
			btnJF.Text = "批量解封";
			btnJF.UseVisualStyleBackColor = true;
			btnJF.Click += new global::System.EventHandler(btnJF_Click);
			btnFH.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnFH.Location = new global::System.Drawing.Point(153, 13);
			btnFH.Name = "btnFH";
			btnFH.Size = new global::System.Drawing.Size(71, 23);
			btnFH.TabIndex = 9;
			btnFH.Text = "批量封号";
			btnFH.UseVisualStyleBackColor = true;
			btnFH.Click += new global::System.EventHandler(btnFH_Click);
			ccmsMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				toolStripMenuItem_0,
				toolStripMenuItem_1,
				toolStripMenuItem_2
			});
			ccmsMenu.Name = "ccmsMenu";
			ccmsMenu.Size = new global::System.Drawing.Size(143, 70);
			toolStripMenuItem_0.Name = "批量封号AToolStripMenuItem";
			toolStripMenuItem_0.Size = new global::System.Drawing.Size(142, 22);
			toolStripMenuItem_0.Text = "批量封号(&B)";
			toolStripMenuItem_0.Click += new global::System.EventHandler(btnFH_Click);
			toolStripMenuItem_1.Name = "批量解封DToolStripMenuItem";
			toolStripMenuItem_1.Size = new global::System.Drawing.Size(142, 22);
			toolStripMenuItem_1.Text = "批量解封(&D)";
			toolStripMenuItem_1.Click += new global::System.EventHandler(btnJF_Click);
			toolStripMenuItem_2.Name = "批量下线OToolStripMenuItem";
			toolStripMenuItem_2.Size = new global::System.Drawing.Size(142, 22);
			toolStripMenuItem_2.Text = "批量下线(&O)";
			toolStripMenuItem_2.Click += new global::System.EventHandler(btnXX_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(604, 367);
			base.Controls.Add(groupBox2);
			base.Controls.Add(gvData);
			base.Controls.Add(groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.IsMdiContainer = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmUser";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			Text = "人物管理";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(frmUser_FormClosed);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)gvData).EndInit();
			groupBox2.ResumeLayout(false);
			ccmsMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000005 RID: 5
		private global::MuEditor.TextBox txtAccount;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.ComboBox cbChoise;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.CheckBox cbEnvelop;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Button btnSearch;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.CheckBox cbOnline;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.DataGridView gvData;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button btnXX;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button btnJF;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Button btnFH;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.ComboBox cbField;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.CheckBox cbGM;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.CheckBox cbRed;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ComboBox cbFilter;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ContextMenuStrip ccmsMenu;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_2;
	}
}
