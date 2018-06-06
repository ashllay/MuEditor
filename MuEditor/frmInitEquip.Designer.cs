namespace MuEditor
{
	// Token: 0x0200000B RID: 11
	public partial class frmInitEquip : global::MuEditor.frmBase
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00002826 File Offset: 0x00000A26
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00013290 File Offset: 0x00011490
		private void InitializeComponent()
		{
			new global::System.ComponentModel.ComponentResourceManager(typeof(global::MuEditor.frmInitEquip));
			pnlPackage = new global::System.Windows.Forms.Panel();
			sBookPanel = new global::MuEditor.PentagramPanel();
			btnClearChar = new global::System.Windows.Forms.Button();
			btnCleanPackage = new global::System.Windows.Forms.Button();
			btnClearPackage = new global::System.Windows.Forms.Button();
			chkAll = new global::System.Windows.Forms.CheckBox();
			btnSave = new global::System.Windows.Forms.Button();
			label1 = new global::System.Windows.Forms.Label();
			cbZhiye = new global::System.Windows.Forms.ComboBox();
			charPanel = new global::MuEditor.CharPanel();
			packagePanel = new global::MuEditor.EquipPanel();
			packagePanelLv1 = new global::MuEditor.EquipPanel();
			packagePanelLv2 = new global::MuEditor.EquipPanel();
			packagePanelLv3 = new global::MuEditor.EquipPanel();
			packagePanelLv4 = new global::MuEditor.EquipPanel();
			shopPanel = new global::MuEditor.EquipPanel();
			groupBox2 = new global::System.Windows.Forms.GroupBox();
			equipEditor = new global::MuEditor.EquipEditor();
			pnlPackage.SuspendLayout();
			groupBox2.SuspendLayout();
			base.SuspendLayout();
			pnlPackage.BackColor = global::System.Drawing.Color.FromArgb(32, 27, 23);
			pnlPackage.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			pnlPackage.Controls.Add(sBookPanel);
			pnlPackage.Controls.Add(btnClearChar);
			pnlPackage.Controls.Add(btnCleanPackage);
			pnlPackage.Controls.Add(btnClearPackage);
			pnlPackage.Controls.Add(chkAll);
			pnlPackage.Controls.Add(btnSave);
			pnlPackage.Controls.Add(label1);
			pnlPackage.Controls.Add(cbZhiye);
			pnlPackage.Controls.Add(charPanel);
			pnlPackage.Controls.Add(packagePanel);
			pnlPackage.Controls.Add(packagePanelLv1);
			pnlPackage.Controls.Add(packagePanelLv2);
			pnlPackage.Controls.Add(packagePanelLv3);
			pnlPackage.Controls.Add(packagePanelLv4);
			pnlPackage.Controls.Add(shopPanel);
			pnlPackage.Location = new global::System.Drawing.Point(231, 4);
			pnlPackage.Name = "pnlPackage";
			pnlPackage.Size = new global::System.Drawing.Size(509, 497);
			pnlPackage.TabIndex = 21;
			sBookPanel.BackgroundImage = global::MuEditor.Properties.Resources.skillbook;
			sBookPanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			sBookPanel.Cursor = global::System.Windows.Forms.Cursors.Default;
			sBookPanel.Enabled = false;
			sBookPanel.Location = new global::System.Drawing.Point(228, 217);
			sBookPanel.Margin = new global::System.Windows.Forms.Padding(0);
			sBookPanel.Name = "sBookPanel";
			sBookPanel.Prof = -1;
			sBookPanel.Size = new global::System.Drawing.Size(58, 58);
			sBookPanel.TabIndex = 89;
			btnClearChar.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			btnClearChar.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			btnClearChar.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			btnClearChar.ForeColor = global::System.Drawing.Color.White;
			btnClearChar.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnClearChar.Location = new global::System.Drawing.Point(311, 385);
			btnClearChar.Name = "btnClearChar";
			btnClearChar.Size = new global::System.Drawing.Size(65, 25);
			btnClearChar.TabIndex = 84;
			btnClearChar.Text = "清空人物";
			btnClearChar.UseVisualStyleBackColor = false;
			btnClearChar.Click += new global::System.EventHandler(btnClearChar_Click);
			btnCleanPackage.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			btnCleanPackage.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			btnCleanPackage.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			btnCleanPackage.ForeColor = global::System.Drawing.Color.White;
			btnCleanPackage.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnCleanPackage.Location = new global::System.Drawing.Point(453, 385);
			btnCleanPackage.Name = "btnCleanPackage";
			btnCleanPackage.Size = new global::System.Drawing.Size(42, 25);
			btnCleanPackage.TabIndex = 83;
			btnCleanPackage.Text = "整理";
			btnCleanPackage.UseVisualStyleBackColor = false;
			btnCleanPackage.Click += new global::System.EventHandler(btnCleanPackage_Click);
			btnClearPackage.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			btnClearPackage.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			btnClearPackage.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			btnClearPackage.ForeColor = global::System.Drawing.Color.White;
			btnClearPackage.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnClearPackage.Location = new global::System.Drawing.Point(382, 385);
			btnClearPackage.Name = "btnClearPackage";
			btnClearPackage.Size = new global::System.Drawing.Size(65, 25);
			btnClearPackage.TabIndex = 82;
			btnClearPackage.Text = "清空包裹";
			btnClearPackage.UseVisualStyleBackColor = false;
			btnClearPackage.Click += new global::System.EventHandler(btnClearPackage_Click);
			chkAll.AutoSize = true;
			chkAll.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			chkAll.ForeColor = global::System.Drawing.Color.Yellow;
			chkAll.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			chkAll.Location = new global::System.Drawing.Point(311, 441);
			chkAll.Name = "chkAll";
			chkAll.Size = new global::System.Drawing.Size(183, 21);
			chkAll.TabIndex = 81;
			chkAll.Text = "所有职业统一送当前所示装备";
			chkAll.UseVisualStyleBackColor = true;
			btnSave.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			btnSave.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			btnSave.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			btnSave.ForeColor = global::System.Drawing.Color.White;
			btnSave.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			btnSave.Location = new global::System.Drawing.Point(368, 465);
			btnSave.Name = "btnSave";
			btnSave.Size = new global::System.Drawing.Size(73, 25);
			btnSave.TabIndex = 80;
			btnSave.TabStop = false;
			btnSave.Text = "保存设置";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += new global::System.EventHandler(btnSave_Click);
			label1.AutoSize = true;
			label1.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			label1.ForeColor = global::System.Drawing.Color.Yellow;
			label1.Location = new global::System.Drawing.Point(308, 418);
			label1.Name = "label1";
			label1.Size = new global::System.Drawing.Size(68, 17);
			label1.TabIndex = 79;
			label1.Text = "加载数据：";
			cbZhiye.DropDownHeight = 206;
			cbZhiye.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbZhiye.FormattingEnabled = true;
			cbZhiye.IntegralHeight = false;
			cbZhiye.Items.AddRange(new object[]
			{
				"魔法师",
				"剑士",
				"弓箭手",
				"魔剑士",
				"圣导师",
				"召唤",
				"决斗士"
			});
			cbZhiye.Location = new global::System.Drawing.Point(378, 416);
			cbZhiye.Name = "cbZhiye";
			cbZhiye.Size = new global::System.Drawing.Size(69, 20);
			cbZhiye.TabIndex = 78;
			cbZhiye.TabStop = false;
			cbZhiye.SelectedIndexChanged += new global::System.EventHandler(cbZhiye_SelectedIndexChanged);
			charPanel.BackgroundImage = global::MuEditor.Properties.Resources.char_2;
			charPanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			charPanel.Cursor = global::System.Windows.Forms.Cursors.Default;
			charPanel.Location = new global::System.Drawing.Point(0, -1);
			charPanel.Margin = new global::System.Windows.Forms.Padding(0);
			charPanel.Name = "charPanel";
			charPanel.Prof = -1;
			charPanel.Size = new global::System.Drawing.Size(295, 284);
			charPanel.TabIndex = 13;
			charPanel.MouseLeave += new global::System.EventHandler(charPanel_MouseLeave);
			packagePanel.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			packagePanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			packagePanel.Cursor = global::System.Windows.Forms.Cursors.Default;
			packagePanel.Location = new global::System.Drawing.Point(45, 283);
			packagePanel.Margin = new global::System.Windows.Forms.Padding(0);
			packagePanel.Name = "packagePanel";
			packagePanel.Size = new global::System.Drawing.Size(209, 209);
			packagePanel.TabIndex = 14;
			packagePanel.MouseLeave += new global::System.EventHandler(packagePanel_MouseLeave);
			packagePanelLv1.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			packagePanelLv1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			packagePanelLv1.Cursor = global::System.Windows.Forms.Cursors.Default;
			packagePanelLv1.Enabled = false;
			packagePanelLv1.Location = new global::System.Drawing.Point(295, 0);
			packagePanelLv1.Margin = new global::System.Windows.Forms.Padding(0);
			packagePanelLv1.Name = "packagePanelLv1";
			packagePanelLv1.Size = new global::System.Drawing.Size(209, 105);
			packagePanelLv1.TabIndex = 85;
			packagePanelLv2.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			packagePanelLv2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			packagePanelLv2.Cursor = global::System.Windows.Forms.Cursors.Default;
			packagePanelLv2.Enabled = false;
			packagePanelLv2.Location = new global::System.Drawing.Point(295, 107);
			packagePanelLv2.Margin = new global::System.Windows.Forms.Padding(0);
			packagePanelLv2.Name = "packagePanelLv2";
			packagePanelLv2.Size = new global::System.Drawing.Size(209, 105);
			packagePanelLv2.TabIndex = 86;
			packagePanelLv3.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			packagePanelLv3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			packagePanelLv3.Cursor = global::System.Windows.Forms.Cursors.Default;
			packagePanelLv3.Location = new global::System.Drawing.Point(295, 214);
			packagePanelLv3.Margin = new global::System.Windows.Forms.Padding(0);
			packagePanelLv3.Name = "packagePanelLv3";
			packagePanelLv3.Size = new global::System.Drawing.Size(209, 105);
			packagePanelLv3.TabIndex = 87;
			packagePanelLv3.Visible = false;
			packagePanelLv4.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			packagePanelLv4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			packagePanelLv4.Cursor = global::System.Windows.Forms.Cursors.Default;
			packagePanelLv4.Enabled = false;
			packagePanelLv4.Location = new global::System.Drawing.Point(295, 214);
			packagePanelLv4.Margin = new global::System.Windows.Forms.Padding(0);
			packagePanelLv4.Name = "packagePanelLv4";
			packagePanelLv4.Size = new global::System.Drawing.Size(209, 105);
			packagePanelLv4.TabIndex = 88;
			shopPanel.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			shopPanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			shopPanel.Cursor = global::System.Windows.Forms.Cursors.Default;
			shopPanel.Location = new global::System.Drawing.Point(295, 214);
			shopPanel.Margin = new global::System.Windows.Forms.Padding(0);
			shopPanel.Name = "shopPanel";
			shopPanel.Size = new global::System.Drawing.Size(209, 105);
			shopPanel.TabIndex = 58;
			shopPanel.Visible = false;
			groupBox2.Controls.Add(equipEditor);
			groupBox2.Location = new global::System.Drawing.Point(2, 5);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new global::System.Drawing.Size(225, 496);
			groupBox2.TabIndex = 77;
			groupBox2.TabStop = false;
			groupBox2.Text = "人物出生送装备设置";
			equipEditor.AllPart = false;
			equipEditor.DefaultDurability = byte.MaxValue;
			equipEditor.Location = new global::System.Drawing.Point(4, 17);
			equipEditor.Margin = new global::System.Windows.Forms.Padding(0);
			equipEditor.Name = "equipEditor";
			equipEditor.Size = new global::System.Drawing.Size(216, 450);
			equipEditor.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(739, 501);
			base.Controls.Add(groupBox2);
			base.Controls.Add(pnlPackage);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmInitEquip";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "人物出生送装备设置";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(frmInitEquip_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(frmInitEquip_FormClosed);
			base.Load += new global::System.EventHandler(frmInitEquip_Load);
			pnlPackage.ResumeLayout(false);
			pnlPackage.PerformLayout();
			groupBox2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000116 RID: 278
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.Panel pnlPackage;

		// Token: 0x04000118 RID: 280
		private global::MuEditor.CharPanel charPanel;

		// Token: 0x04000119 RID: 281
		private global::MuEditor.EquipPanel packagePanel;

		// Token: 0x0400011A RID: 282
		private global::MuEditor.EquipPanel packagePanelLv1;

		// Token: 0x0400011B RID: 283
		private global::MuEditor.EquipPanel packagePanelLv2;

		// Token: 0x0400011C RID: 284
		private global::MuEditor.EquipPanel packagePanelLv3;

		// Token: 0x0400011D RID: 285
		private global::MuEditor.EquipPanel packagePanelLv4;

		// Token: 0x0400011E RID: 286
		private global::MuEditor.EquipPanel shopPanel;

		// Token: 0x0400011F RID: 287
		private global::MuEditor.PentagramPanel sBookPanel;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000121 RID: 289
		private global::MuEditor.EquipEditor equipEditor;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.ComboBox cbZhiye;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.CheckBox chkAll;

		// Token: 0x04000126 RID: 294
		private global::System.Windows.Forms.Button btnClearChar;

		// Token: 0x04000127 RID: 295
		private global::System.Windows.Forms.Button btnCleanPackage;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.Button btnClearPackage;
	}
}
