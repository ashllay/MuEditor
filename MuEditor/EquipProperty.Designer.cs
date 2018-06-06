namespace MuEditor
{
	// Token: 0x02000024 RID: 36
	public partial class EquipProperty : global::MuEditor.frmBase
	{
		// Token: 0x06000207 RID: 519 RVA: 0x000038D1 File Offset: 0x00001AD1
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00022230 File Offset: 0x00020430
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MuEditor.EquipProperty));
			cboEquipLevel = new global::System.Windows.Forms.ComboBox();
			cboEquipExt = new global::System.Windows.Forms.ComboBox();
			label31 = new global::System.Windows.Forms.Label();
			groupBox3 = new global::System.Windows.Forms.GroupBox();
			button4 = new global::System.Windows.Forms.Button();
			button1 = new global::System.Windows.Forms.Button();
			button3 = new global::System.Windows.Forms.Button();
			button2 = new global::System.Windows.Forms.Button();
			chkEquipZY6 = new global::System.Windows.Forms.CheckBox();
			chkEquipZY4 = new global::System.Windows.Forms.CheckBox();
			chkEquipZY2 = new global::System.Windows.Forms.CheckBox();
			chkEquipZY5 = new global::System.Windows.Forms.CheckBox();
			chkEquipZY3 = new global::System.Windows.Forms.CheckBox();
			chkEquipZY1 = new global::System.Windows.Forms.CheckBox();
			chkEquipXY = new global::System.Windows.Forms.CheckBox();
			chkEquipJN = new global::System.Windows.Forms.CheckBox();
			label30 = new global::System.Windows.Forms.Label();
			label1 = new global::System.Windows.Forms.Label();
			txtName = new global::MuEditor.TextBox();
			btnOK = new global::System.Windows.Forms.Button();
			btnCancel = new global::System.Windows.Forms.Button();
			label2 = new global::System.Windows.Forms.Label();
			txtEquipCodes = new global::MuEditor.TextBox();
			txtDurability = new global::MuEditor.TextBox();
			label4 = new global::System.Windows.Forms.Label();
			cbSetVal = new global::System.Windows.Forms.ComboBox();
			label5 = new global::System.Windows.Forms.Label();
			chk380 = new global::System.Windows.Forms.CheckBox();
			label3 = new global::System.Windows.Forms.Label();
			eee = new global::System.Windows.Forms.Label();
			cboPlusLevel = new global::System.Windows.Forms.ComboBox();
			cboPlusType = new global::System.Windows.Forms.ComboBox();
			gbXQ = new global::System.Windows.Forms.GroupBox();
			cbInlay6b = new global::System.Windows.Forms.ComboBox();
			label11 = new global::System.Windows.Forms.Label();
			label10 = new global::System.Windows.Forms.Label();
			label9 = new global::System.Windows.Forms.Label();
			label8 = new global::System.Windows.Forms.Label();
			label7 = new global::System.Windows.Forms.Label();
			label6 = new global::System.Windows.Forms.Label();
			cbInlay5b = new global::System.Windows.Forms.ComboBox();
			cbInlay4b = new global::System.Windows.Forms.ComboBox();
			cbInlay3b = new global::System.Windows.Forms.ComboBox();
			cbInlay2b = new global::System.Windows.Forms.ComboBox();
			cbInlay1b = new global::System.Windows.Forms.ComboBox();
			label12 = new global::System.Windows.Forms.Label();
			txtSN = new global::MuEditor.TextBox();
			groupBox3.SuspendLayout();
			gbXQ.SuspendLayout();
			base.SuspendLayout();
			cboEquipLevel.DropDownHeight = 206;
			cboEquipLevel.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cboEquipLevel.FormattingEnabled = true;
			cboEquipLevel.IntegralHeight = false;
			cboEquipLevel.Items.AddRange(new object[]
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15"
			});
			cboEquipLevel.Location = new global::System.Drawing.Point(21, 78);
			cboEquipLevel.Name = "cboEquipLevel";
			cboEquipLevel.Size = new global::System.Drawing.Size(48, 20);
			cboEquipLevel.TabIndex = 30;
			cboEquipExt.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cboEquipExt.FormattingEnabled = true;
			cboEquipExt.Items.AddRange(new object[]
			{
				"0",
				"4",
				"8",
				"12",
				"16",
				"20",
				"24",
				"28"
			});
			cboEquipExt.Location = new global::System.Drawing.Point(99, 77);
			cboEquipExt.Name = "cboEquipExt";
			cboEquipExt.Size = new global::System.Drawing.Size(49, 20);
			cboEquipExt.TabIndex = 29;
			label31.AutoSize = true;
			label31.Location = new global::System.Drawing.Point(76, 80);
			label31.Name = "label31";
			label31.Size = new global::System.Drawing.Size(17, 12);
			label31.TabIndex = 28;
			label31.Text = "追";
			groupBox3.Controls.Add(button4);
			groupBox3.Controls.Add(button1);
			groupBox3.Controls.Add(button3);
			groupBox3.Controls.Add(button2);
			groupBox3.Controls.Add(chkEquipZY6);
			groupBox3.Controls.Add(chkEquipZY4);
			groupBox3.Controls.Add(chkEquipZY2);
			groupBox3.Controls.Add(chkEquipZY5);
			groupBox3.Controls.Add(chkEquipZY3);
			groupBox3.Controls.Add(chkEquipZY1);
			groupBox3.Location = new global::System.Drawing.Point(6, 145);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new global::System.Drawing.Size(210, 105);
			groupBox3.TabIndex = 27;
			groupBox3.TabStop = false;
			groupBox3.Text = "卓越属性";
			button4.Location = new global::System.Drawing.Point(156, 76);
			button4.Name = "button4";
			button4.Size = new global::System.Drawing.Size(45, 22);
			button4.TabIndex = 15;
			button4.Text = "道 具";
			button4.UseVisualStyleBackColor = true;
			button4.Click += new global::System.EventHandler(button4_Click);
			button1.Location = new global::System.Drawing.Point(107, 76);
			button1.Name = "button1";
			button1.Size = new global::System.Drawing.Size(45, 22);
			button1.TabIndex = 14;
			button1.Text = "极 品";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new global::System.EventHandler(button1_Click);
			button3.Location = new global::System.Drawing.Point(58, 76);
			button3.Name = "button3";
			button3.Size = new global::System.Drawing.Size(45, 22);
			button3.TabIndex = 11;
			button3.Text = "清 空";
			button3.UseVisualStyleBackColor = true;
			button3.Click += new global::System.EventHandler(button3_Click);
			button2.Location = new global::System.Drawing.Point(9, 76);
			button2.Name = "button2";
			button2.Size = new global::System.Drawing.Size(45, 22);
			button2.TabIndex = 10;
			button2.Text = "全 选";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new global::System.EventHandler(button2_Click);
			chkEquipZY6.AutoSize = true;
			chkEquipZY6.Location = new global::System.Drawing.Point(112, 55);
			chkEquipZY6.Name = "chkEquipZY6";
			chkEquipZY6.Size = new global::System.Drawing.Size(36, 16);
			chkEquipZY6.TabIndex = 9;
			chkEquipZY6.Text = "无";
			chkEquipZY6.UseVisualStyleBackColor = true;
			chkEquipZY4.AutoSize = true;
			chkEquipZY4.Location = new global::System.Drawing.Point(112, 34);
			chkEquipZY4.Name = "chkEquipZY4";
			chkEquipZY4.Size = new global::System.Drawing.Size(36, 16);
			chkEquipZY4.TabIndex = 8;
			chkEquipZY4.Text = "无";
			chkEquipZY4.UseVisualStyleBackColor = true;
			chkEquipZY2.AutoSize = true;
			chkEquipZY2.Location = new global::System.Drawing.Point(112, 14);
			chkEquipZY2.Name = "chkEquipZY2";
			chkEquipZY2.Size = new global::System.Drawing.Size(36, 16);
			chkEquipZY2.TabIndex = 7;
			chkEquipZY2.Text = "无";
			chkEquipZY2.UseVisualStyleBackColor = true;
			chkEquipZY5.AutoSize = true;
			chkEquipZY5.Location = new global::System.Drawing.Point(21, 55);
			chkEquipZY5.Name = "chkEquipZY5";
			chkEquipZY5.Size = new global::System.Drawing.Size(36, 16);
			chkEquipZY5.TabIndex = 6;
			chkEquipZY5.Text = "无";
			chkEquipZY5.UseVisualStyleBackColor = true;
			chkEquipZY3.AutoSize = true;
			chkEquipZY3.Location = new global::System.Drawing.Point(21, 34);
			chkEquipZY3.Name = "chkEquipZY3";
			chkEquipZY3.Size = new global::System.Drawing.Size(36, 16);
			chkEquipZY3.TabIndex = 5;
			chkEquipZY3.Text = "无";
			chkEquipZY3.UseVisualStyleBackColor = true;
			chkEquipZY1.AutoSize = true;
			chkEquipZY1.Location = new global::System.Drawing.Point(21, 14);
			chkEquipZY1.Name = "chkEquipZY1";
			chkEquipZY1.Size = new global::System.Drawing.Size(36, 16);
			chkEquipZY1.TabIndex = 4;
			chkEquipZY1.Text = "无";
			chkEquipZY1.UseVisualStyleBackColor = true;
			chkEquipXY.AutoSize = true;
			chkEquipXY.Location = new global::System.Drawing.Point(96, 102);
			chkEquipXY.Name = "chkEquipXY";
			chkEquipXY.Size = new global::System.Drawing.Size(48, 16);
			chkEquipXY.TabIndex = 26;
			chkEquipXY.Text = "幸运";
			chkEquipXY.UseVisualStyleBackColor = true;
			chkEquipJN.AutoSize = true;
			chkEquipJN.Location = new global::System.Drawing.Point(47, 102);
			chkEquipJN.Name = "chkEquipJN";
			chkEquipJN.Size = new global::System.Drawing.Size(48, 16);
			chkEquipJN.TabIndex = 25;
			chkEquipJN.Text = "技能";
			chkEquipJN.UseVisualStyleBackColor = true;
			label30.AutoSize = true;
			label30.Location = new global::System.Drawing.Point(5, 81);
			label30.Name = "label30";
			label30.Size = new global::System.Drawing.Size(17, 12);
			label30.TabIndex = 24;
			label30.Text = "加";
			label1.AutoSize = true;
			label1.Location = new global::System.Drawing.Point(4, 5);
			label1.Name = "label1";
			label1.Size = new global::System.Drawing.Size(65, 12);
			label1.TabIndex = 31;
			label1.Text = "物品名称：";
			txtName.IsOnlyNumber = false;
			txtName.Location = new global::System.Drawing.Point(70, 2);
			txtName.Name = "txtName";
			txtName.ReadOnly = true;
			txtName.Size = new global::System.Drawing.Size(146, 21);
			txtName.TabIndex = 32;
			btnOK.Location = new global::System.Drawing.Point(21, 420);
			btnOK.Name = "btnOK";
			btnOK.Size = new global::System.Drawing.Size(66, 25);
			btnOK.TabIndex = 33;
			btnOK.Text = "确  定";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += new global::System.EventHandler(btnOK_Click);
			btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			btnCancel.Location = new global::System.Drawing.Point(127, 420);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new global::System.Drawing.Size(69, 25);
			btnCancel.TabIndex = 34;
			btnCancel.Text = "取 消";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += new global::System.EventHandler(btnCancel_Click);
			label2.AutoSize = true;
			label2.Location = new global::System.Drawing.Point(4, 32);
			label2.Name = "label2";
			label2.Size = new global::System.Drawing.Size(65, 12);
			label2.TabIndex = 35;
			label2.Text = "物品代码：";
			txtEquipCodes.IsOnlyNumber = false;
			txtEquipCodes.Location = new global::System.Drawing.Point(70, 27);
			txtEquipCodes.Name = "txtEquipCodes";
			txtEquipCodes.ReadOnly = true;
			txtEquipCodes.Size = new global::System.Drawing.Size(146, 21);
			txtEquipCodes.TabIndex = 36;
			txtDurability.IsOnlyNumber = true;
			txtDurability.Location = new global::System.Drawing.Point(180, 76);
			txtDurability.Name = "txtDurability";
			txtDurability.Size = new global::System.Drawing.Size(36, 21);
			txtDurability.TabIndex = 38;
			txtDurability.Text = "255";
			label4.AutoSize = true;
			label4.Location = new global::System.Drawing.Point(153, 81);
			label4.Name = "label4";
			label4.Size = new global::System.Drawing.Size(29, 12);
			label4.TabIndex = 37;
			label4.Text = "耐：";
			cbSetVal.DropDownHeight = 206;
			cbSetVal.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbSetVal.FormattingEnabled = true;
			cbSetVal.IntegralHeight = false;
			cbSetVal.Items.AddRange(new object[]
			{
				"0",
				"5",
				"6",
				"9",
				"10"
			});
			cbSetVal.Location = new global::System.Drawing.Point(182, 99);
			cbSetVal.Name = "cbSetVal";
			cbSetVal.Size = new global::System.Drawing.Size(35, 20);
			cbSetVal.TabIndex = 45;
			label5.AutoSize = true;
			label5.Location = new global::System.Drawing.Point(141, 103);
			label5.Name = "label5";
			label5.Size = new global::System.Drawing.Size(41, 12);
			label5.TabIndex = 44;
			label5.Text = "套装值";
			chk380.AutoSize = true;
			chk380.Location = new global::System.Drawing.Point(5, 102);
			chk380.Name = "chk380";
			chk380.Size = new global::System.Drawing.Size(42, 16);
			chk380.TabIndex = 46;
			chk380.Text = "380";
			chk380.UseVisualStyleBackColor = true;
			label3.AutoSize = true;
			label3.Location = new global::System.Drawing.Point(146, 125);
			label3.Name = "label3";
			label3.Size = new global::System.Drawing.Size(29, 12);
			label3.TabIndex = 50;
			label3.Text = "等级";
			eee.AutoSize = true;
			eee.Location = new global::System.Drawing.Point(3, 125);
			eee.Name = "eee";
			eee.Size = new global::System.Drawing.Size(29, 12);
			eee.TabIndex = 49;
			eee.Text = "强化";
			cboPlusLevel.DropDownHeight = 206;
			cboPlusLevel.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cboPlusLevel.FormattingEnabled = true;
			cboPlusLevel.IntegralHeight = false;
			cboPlusLevel.Items.AddRange(new object[]
			{
				"+ 0",
				"+ 1",
				"+ 2",
				"+ 3",
				"+ 4",
				"+ 5",
				"+ 6",
				"+ 7",
				"+ 8",
				"+ 9",
				"+10",
				"+11",
				"+12",
				"+13"
			});
			cboPlusLevel.Location = new global::System.Drawing.Point(175, 122);
			cboPlusLevel.Name = "cboPlusLevel";
			cboPlusLevel.Size = new global::System.Drawing.Size(42, 20);
			cboPlusLevel.TabIndex = 48;
			cboPlusType.DropDownHeight = 206;
			cboPlusType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cboPlusType.FormattingEnabled = true;
			cboPlusType.IntegralHeight = false;
			cboPlusType.Location = new global::System.Drawing.Point(33, 122);
			cboPlusType.Name = "cboPlusType";
			cboPlusType.Size = new global::System.Drawing.Size(111, 20);
			cboPlusType.TabIndex = 47;
			gbXQ.Controls.Add(cbInlay6b);
			gbXQ.Controls.Add(label11);
			gbXQ.Controls.Add(label10);
			gbXQ.Controls.Add(label9);
			gbXQ.Controls.Add(label8);
			gbXQ.Controls.Add(label7);
			gbXQ.Controls.Add(label6);
			gbXQ.Controls.Add(cbInlay5b);
			gbXQ.Controls.Add(cbInlay4b);
			gbXQ.Controls.Add(cbInlay3b);
			gbXQ.Controls.Add(cbInlay2b);
			gbXQ.Controls.Add(cbInlay1b);
			gbXQ.Location = new global::System.Drawing.Point(5, 253);
			gbXQ.Name = "gbXQ";
			gbXQ.Size = new global::System.Drawing.Size(210, 162);
			gbXQ.TabIndex = 51;
			gbXQ.TabStop = false;
			gbXQ.Text = "镶嵌属性";
			cbInlay6b.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbInlay6b.FormattingEnabled = true;
			cbInlay6b.Location = new global::System.Drawing.Point(56, 137);
			cbInlay6b.Name = "cbInlay6b";
			cbInlay6b.Size = new global::System.Drawing.Size(150, 20);
			cbInlay6b.TabIndex = 45;
			label11.AutoSize = true;
			label11.Location = new global::System.Drawing.Point(3, 142);
			label11.Name = "label11";
			label11.Size = new global::System.Drawing.Size(53, 12);
			label11.TabIndex = 44;
			label11.Text = "荧光属性";
			label10.AutoSize = true;
			label10.Location = new global::System.Drawing.Point(3, 118);
			label10.Name = "label10";
			label10.Size = new global::System.Drawing.Size(23, 12);
			label10.TabIndex = 43;
			label10.Text = "孔5";
			label9.AutoSize = true;
			label9.Location = new global::System.Drawing.Point(3, 92);
			label9.Name = "label9";
			label9.Size = new global::System.Drawing.Size(23, 12);
			label9.TabIndex = 42;
			label9.Text = "孔4";
			label8.AutoSize = true;
			label8.Location = new global::System.Drawing.Point(3, 68);
			label8.Name = "label8";
			label8.Size = new global::System.Drawing.Size(23, 12);
			label8.TabIndex = 41;
			label8.Text = "孔3";
			label7.AutoSize = true;
			label7.Location = new global::System.Drawing.Point(3, 42);
			label7.Name = "label7";
			label7.Size = new global::System.Drawing.Size(23, 12);
			label7.TabIndex = 40;
			label7.Text = "孔2";
			label6.AutoSize = true;
			label6.Location = new global::System.Drawing.Point(3, 17);
			label6.Name = "label6";
			label6.Size = new global::System.Drawing.Size(23, 12);
			label6.TabIndex = 39;
			label6.Text = "孔1";
			cbInlay5b.DropDownHeight = 206;
			cbInlay5b.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbInlay5b.FormattingEnabled = true;
			cbInlay5b.IntegralHeight = false;
			cbInlay5b.Location = new global::System.Drawing.Point(26, 113);
			cbInlay5b.Name = "cbInlay5b";
			cbInlay5b.Size = new global::System.Drawing.Size(180, 20);
			cbInlay5b.TabIndex = 38;
			cbInlay4b.DropDownHeight = 206;
			cbInlay4b.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbInlay4b.FormattingEnabled = true;
			cbInlay4b.IntegralHeight = false;
			cbInlay4b.Location = new global::System.Drawing.Point(26, 88);
			cbInlay4b.Name = "cbInlay4b";
			cbInlay4b.Size = new global::System.Drawing.Size(180, 20);
			cbInlay4b.TabIndex = 37;
			cbInlay3b.DropDownHeight = 206;
			cbInlay3b.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbInlay3b.FormattingEnabled = true;
			cbInlay3b.IntegralHeight = false;
			cbInlay3b.Location = new global::System.Drawing.Point(26, 63);
			cbInlay3b.Name = "cbInlay3b";
			cbInlay3b.Size = new global::System.Drawing.Size(180, 20);
			cbInlay3b.TabIndex = 36;
			cbInlay2b.DropDownHeight = 206;
			cbInlay2b.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbInlay2b.FormattingEnabled = true;
			cbInlay2b.IntegralHeight = false;
			cbInlay2b.Location = new global::System.Drawing.Point(26, 38);
			cbInlay2b.Name = "cbInlay2b";
			cbInlay2b.Size = new global::System.Drawing.Size(180, 20);
			cbInlay2b.TabIndex = 34;
			cbInlay1b.DropDownHeight = 206;
			cbInlay1b.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			cbInlay1b.FormattingEnabled = true;
			cbInlay1b.IntegralHeight = false;
			cbInlay1b.Location = new global::System.Drawing.Point(26, 13);
			cbInlay1b.Name = "cbInlay1b";
			cbInlay1b.Size = new global::System.Drawing.Size(180, 20);
			cbInlay1b.TabIndex = 32;
			label12.AutoSize = true;
			label12.Location = new global::System.Drawing.Point(3, 58);
			label12.Name = "label12";
			label12.Size = new global::System.Drawing.Size(53, 12);
			label12.TabIndex = 52;
			label12.Text = "系列号：";
			txtSN.IsOnlyNumber = false;
			txtSN.Location = new global::System.Drawing.Point(70, 52);
			txtSN.Name = "txtSN";
			txtSN.Size = new global::System.Drawing.Size(146, 21);
			txtSN.TabIndex = 53;
			base.AcceptButton = btnOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = btnCancel;
			base.ClientSize = new global::System.Drawing.Size(222, 448);
			base.ControlBox = false;
			base.Controls.Add(txtSN);
			base.Controls.Add(label12);
			base.Controls.Add(gbXQ);
			base.Controls.Add(label3);
			base.Controls.Add(eee);
			base.Controls.Add(cboPlusLevel);
			base.Controls.Add(cboPlusType);
			base.Controls.Add(chk380);
			base.Controls.Add(cbSetVal);
			base.Controls.Add(label5);
			base.Controls.Add(txtDurability);
			base.Controls.Add(label4);
			base.Controls.Add(txtEquipCodes);
			base.Controls.Add(label2);
			base.Controls.Add(btnCancel);
			base.Controls.Add(btnOK);
			base.Controls.Add(txtName);
			base.Controls.Add(label1);
			base.Controls.Add(cboEquipLevel);
			base.Controls.Add(cboEquipExt);
			base.Controls.Add(label31);
			base.Controls.Add(groupBox3);
			base.Controls.Add(chkEquipXY);
			base.Controls.Add(chkEquipJN);
			base.Controls.Add(label30);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EquipProperty";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "装备属性";
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			gbXQ.ResumeLayout(false);
			gbXQ.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000231 RID: 561
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000232 RID: 562
		private global::System.Windows.Forms.ComboBox cboEquipLevel;

		// Token: 0x04000233 RID: 563
		private global::System.Windows.Forms.ComboBox cboEquipExt;

		// Token: 0x04000234 RID: 564
		private global::System.Windows.Forms.Label label31;

		// Token: 0x04000235 RID: 565
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000236 RID: 566
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000237 RID: 567
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000238 RID: 568
		private global::System.Windows.Forms.CheckBox chkEquipZY6;

		// Token: 0x04000239 RID: 569
		private global::System.Windows.Forms.CheckBox chkEquipZY4;

		// Token: 0x0400023A RID: 570
		private global::System.Windows.Forms.CheckBox chkEquipZY2;

		// Token: 0x0400023B RID: 571
		private global::System.Windows.Forms.CheckBox chkEquipZY5;

		// Token: 0x0400023C RID: 572
		private global::System.Windows.Forms.CheckBox chkEquipZY3;

		// Token: 0x0400023D RID: 573
		private global::System.Windows.Forms.CheckBox chkEquipZY1;

		// Token: 0x0400023E RID: 574
		private global::System.Windows.Forms.CheckBox chkEquipXY;

		// Token: 0x0400023F RID: 575
		private global::System.Windows.Forms.CheckBox chkEquipJN;

		// Token: 0x04000240 RID: 576
		private global::System.Windows.Forms.Label label30;

		// Token: 0x04000241 RID: 577
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000242 RID: 578
		private global::MuEditor.TextBox txtName;

		// Token: 0x04000243 RID: 579
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x04000244 RID: 580
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000245 RID: 581
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000246 RID: 582
		private global::MuEditor.TextBox txtEquipCodes;

		// Token: 0x04000247 RID: 583
		private global::MuEditor.TextBox txtDurability;

		// Token: 0x04000248 RID: 584
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000249 RID: 585
		private global::System.Windows.Forms.ComboBox cbSetVal;

		// Token: 0x0400024A RID: 586
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400024B RID: 587
		private global::System.Windows.Forms.CheckBox chk380;

		// Token: 0x0400024C RID: 588
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400024D RID: 589
		private global::System.Windows.Forms.Label eee;

		// Token: 0x0400024E RID: 590
		private global::System.Windows.Forms.ComboBox cboPlusLevel;

		// Token: 0x0400024F RID: 591
		private global::System.Windows.Forms.ComboBox cboPlusType;

		// Token: 0x04000250 RID: 592
		private global::System.Windows.Forms.GroupBox gbXQ;

		// Token: 0x04000251 RID: 593
		private global::System.Windows.Forms.ComboBox cbInlay6b;

		// Token: 0x04000252 RID: 594
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000253 RID: 595
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000254 RID: 596
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000255 RID: 597
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000256 RID: 598
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000257 RID: 599
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000258 RID: 600
		private global::System.Windows.Forms.ComboBox cbInlay5b;

		// Token: 0x04000259 RID: 601
		private global::System.Windows.Forms.ComboBox cbInlay4b;

		// Token: 0x0400025A RID: 602
		private global::System.Windows.Forms.ComboBox cbInlay3b;

		// Token: 0x0400025B RID: 603
		private global::System.Windows.Forms.ComboBox cbInlay2b;

		// Token: 0x0400025C RID: 604
		private global::System.Windows.Forms.ComboBox cbInlay1b;

		// Token: 0x0400025D RID: 605
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400025E RID: 606
		private global::MuEditor.TextBox txtSN;

		// Token: 0x0400025F RID: 607
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000260 RID: 608
		private global::System.Windows.Forms.Button button1;
	}
}
