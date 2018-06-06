using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MuEditor
{
    partial class EquipEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboEquipLevel = new ComboBox();
            cboEquipExt = new ComboBox();
            label31 = new Label();
            cboEquipName = new ComboBox();
            cboEquipType = new ComboBox();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            chkEquipZY6 = new CheckBox();
            chkEquipZY4 = new CheckBox();
            chkEquipZY2 = new CheckBox();
            chkEquipZY5 = new CheckBox();
            chkEquipZY3 = new CheckBox();
            chkEquipZY1 = new CheckBox();
            chk380 = new CheckBox();
            chkEquipXY = new CheckBox();
            chkEquipJN = new CheckBox();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label1 = new Label();
            txtDurability = new TextBox();
            cboPlusType = new ComboBox();
            cboPlusLevel = new ComboBox();
            eee = new Label();
            label3 = new Label();
            chkAllPart = new CheckBox();
            AddNums = new TextBox();
            label2 = new Label();
            txtCode = new TextBox();
            gbXQ = new GroupBox();
            cbInlay6b = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbInlay5b = new ComboBox();
            cbInlay4b = new ComboBox();
            cbInlay3b = new ComboBox();
            cbInlay2b = new ComboBox();
            cbInlay1b = new ComboBox();
            cbZhiye = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbSetVal = new ComboBox();
            groupBox3.SuspendLayout();
            gbXQ.SuspendLayout();
            base.SuspendLayout();
            cboEquipLevel.DropDownHeight = 206;
            cboEquipLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEquipLevel.FormattingEnabled = true;
            cboEquipLevel.IntegralHeight = false;
            cboEquipLevel.Items.AddRange(new object[]
            {
                "0", "1", "2", "3", "4",
                "5", "6", "7", "8", "9",
                "10", "11", "12", "13", "14", "15"
            });
            cboEquipLevel.Location = new Point(25, 75);
            cboEquipLevel.Name = "cboEquipLevel";
            cboEquipLevel.Size = new Size(46, 20);
            cboEquipLevel.TabIndex = 23;
            cboEquipExt.DropDownHeight = 206;
            cboEquipExt.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEquipExt.FormattingEnabled = true;
            cboEquipExt.IntegralHeight = false;
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
            cboEquipExt.Location = new Point(92, 75);
            cboEquipExt.Name = "cboEquipExt";
            cboEquipExt.Size = new Size(50, 20);
            cboEquipExt.TabIndex = 22;
            label31.AutoSize = true;
            label31.Location = new Point(74, 79);
            label31.Name = "label31";
            label31.Size = new Size(17, 12);
            label31.TabIndex = 21;
            label31.Text = "追";
            cboEquipName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEquipName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEquipName.DropDownHeight = 400;
            cboEquipName.FormattingEnabled = true;
            cboEquipName.IntegralHeight = false;
            cboEquipName.Location = new Point(40, 50);
            cboEquipName.Name = "cboEquipName";
            cboEquipName.Size = new Size(115, 20);
            cboEquipName.TabIndex = 20;
            cboEquipName.SelectedIndexChanged += cboEquipName_SelectedIndexChanged;
            cboEquipName.KeyUp += cboEquipName_KeyUp;
            cboEquipType.DropDownHeight = 206;
            cboEquipType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEquipType.FormattingEnabled = true;
            cboEquipType.IntegralHeight = false;
            cboEquipType.Location = new Point(40, 25);
            cboEquipType.Name = "cboEquipType";
            cboEquipType.Size = new Size(115, 20);
            cboEquipType.TabIndex = 19;
            cboEquipType.SelectedIndexChanged += cboEquipType_SelectedIndexChanged;
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
            groupBox3.Location = new Point(5, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(207, 105);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "卓越属性";
            button4.Location = new Point(156, 75);
            button4.Name = "button4";
            button4.Size = new Size(45, 22);
            button4.TabIndex = 13;
            button4.Text = "道 具";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button1.Location = new Point(107, 75);
            button1.Name = "button1";
            button1.Size = new Size(45, 22);
            button1.TabIndex = 12;
            button1.Text = "极 品";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button3.Location = new Point(57, 75);
            button3.Name = "button3";
            button3.Size = new Size(45, 22);
            button3.TabIndex = 11;
            button3.Text = "清 空";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button2.Location = new Point(8, 75);
            button2.Name = "button2";
            button2.Size = new Size(44, 22);
            button2.TabIndex = 10;
            button2.Text = "全 选";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            chkEquipZY6.AutoSize = true;
            chkEquipZY6.Location = new Point(111, 55);
            chkEquipZY6.Name = "chkEquipZY6";
            chkEquipZY6.Size = new Size(48, 16);
            chkEquipZY6.TabIndex = 9;
            chkEquipZY6.Text = "加红";
            chkEquipZY6.UseVisualStyleBackColor = true;
            chkEquipZY4.AutoSize = true;
            chkEquipZY4.Location = new Point(111, 35);
            chkEquipZY4.Name = "chkEquipZY4";
            chkEquipZY4.Size = new Size(48, 16);
            chkEquipZY4.TabIndex = 8;
            chkEquipZY4.Text = "减伤";
            chkEquipZY4.UseVisualStyleBackColor = true;
            chkEquipZY2.AutoSize = true;
            chkEquipZY2.Location = new Point(111, 15);
            chkEquipZY2.Name = "chkEquipZY2";
            chkEquipZY2.Size = new Size(48, 16);
            chkEquipZY2.TabIndex = 7;
            chkEquipZY2.Text = "防10";
            chkEquipZY2.UseVisualStyleBackColor = true;
            chkEquipZY5.AutoSize = true;
            chkEquipZY5.Location = new Point(16, 55);
            chkEquipZY5.Name = "chkEquipZY5";
            chkEquipZY5.Size = new Size(48, 16);
            chkEquipZY5.TabIndex = 6;
            chkEquipZY5.Text = "加蓝";
            chkEquipZY5.UseVisualStyleBackColor = true;
            chkEquipZY3.AutoSize = true;
            chkEquipZY3.Location = new Point(16, 35);
            chkEquipZY3.Name = "chkEquipZY3";
            chkEquipZY3.Size = new Size(48, 16);
            chkEquipZY3.TabIndex = 5;
            chkEquipZY3.Text = "反伤";
            chkEquipZY3.UseVisualStyleBackColor = true;
            chkEquipZY1.AutoSize = true;
            chkEquipZY1.Location = new Point(16, 15);
            chkEquipZY1.Name = "chkEquipZY1";
            chkEquipZY1.Size = new Size(72, 16);
            chkEquipZY1.TabIndex = 4;
            chkEquipZY1.Text = "金钱+40%";
            chkEquipZY1.UseVisualStyleBackColor = true;
            chk380.AutoSize = true;
            chk380.Location = new Point(161, 52);
            chk380.Name = "chk380";
            chk380.Size = new Size(54, 16);
            chk380.TabIndex = 29;
            chk380.Text = "380属";
            chk380.UseVisualStyleBackColor = true;
            chkEquipXY.AutoSize = true;
            chkEquipXY.Location = new Point(69, 128);
            chkEquipXY.Name = "chkEquipXY";
            chkEquipXY.Size = new Size(48, 16);
            chkEquipXY.TabIndex = 17;
            chkEquipXY.Text = "幸运";
            chkEquipXY.UseVisualStyleBackColor = true;
            chkEquipJN.AutoSize = true;
            chkEquipJN.Location = new Point(10, 128);
            chkEquipJN.Name = "chkEquipJN";
            chkEquipJN.Size = new Size(48, 16);
            chkEquipJN.TabIndex = 16;
            chkEquipJN.Text = "技能";
            chkEquipJN.UseVisualStyleBackColor = true;
            label30.AutoSize = true;
            label30.Location = new Point(4, 78);
            label30.Name = "label30";
            label30.Size = new Size(17, 12);
            label30.TabIndex = 15;
            label30.Text = "加";
            label29.AutoSize = true;
            label29.Location = new Point(2, 54);
            label29.Name = "label29";
            label29.Size = new Size(41, 12);
            label29.TabIndex = 14;
            label29.Text = "名称：";
            label28.AutoSize = true;
            label28.Location = new Point(3, 28);
            label28.Name = "label28";
            label28.Size = new Size(41, 12);
            label28.TabIndex = 13;
            label28.Text = "分类：";
            label1.AutoSize = true;
            label1.Location = new Point(147, 78);
            label1.Name = "label1";
            label1.Size = new Size(17, 12);
            label1.TabIndex = 24;
            label1.Text = "耐";
            txtDurability.IsOnlyNumber = true;
            txtDurability.Location = new Point(166, 75);
            txtDurability.Name = "txtDurability";
            txtDurability.Size = new Size(39, 21);
            txtDurability.TabIndex = 25;
            txtDurability.Text = "255";
            txtDurability.TextAlign = HorizontalAlignment.Center;
            cboPlusType.DropDownHeight = 206;
            cboPlusType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlusType.FormattingEnabled = true;
            cboPlusType.IntegralHeight = false;
            cboPlusType.Location = new Point(33, 101);
            cboPlusType.Name = "cboPlusType";
            cboPlusType.Size = new Size(100, 20);
            cboPlusType.TabIndex = 30;
            cboPlusLevel.DropDownHeight = 206;
            cboPlusLevel.DropDownStyle = ComboBoxStyle.DropDownList;
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
            cboPlusLevel.Location = new Point(164, 101);
            cboPlusLevel.Name = "cboPlusLevel";
            cboPlusLevel.Size = new Size(42, 20);
            cboPlusLevel.TabIndex = 31;
            eee.AutoSize = true;
            eee.Location = new Point(3, 104);
            eee.Name = "eee";
            eee.Size = new Size(29, 12);
            eee.TabIndex = 32;
            eee.Text = "强化";
            label3.AutoSize = true;
            label3.Location = new Point(135, 104);
            label3.Name = "label3";
            label3.Size = new Size(29, 12);
            label3.TabIndex = 33;
            label3.Text = "等级";
            chkAllPart.AutoSize = true;
            chkAllPart.Enabled = false;
            chkAllPart.Location = new Point(161, 29);
            chkAllPart.Name = "chkAllPart";
            chkAllPart.Size = new Size(48, 16);
            chkAllPart.TabIndex = 35;
            chkAllPart.Text = "配套";
            chkAllPart.UseVisualStyleBackColor = true;
            AddNums.IsOnlyNumber = true;
            AddNums.Location = new Point(171, 0);
            AddNums.Name = "AddNums";
            AddNums.Size = new Size(39, 21);
            AddNums.TabIndex = 38;
            AddNums.Text = "1";
            label2.AutoSize = true;
            label2.Location = new Point(135, 4);
            label2.Name = "label2";
            label2.Size = new Size(41, 12);
            label2.TabIndex = 37;
            label2.Text = "数量：";
            txtCode.IsOnlyNumber = false;
            txtCode.Location = new Point(3, 425);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(212, 21);
            txtCode.TabIndex = 37;
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
            gbXQ.Location = new Point(3, 259);
            gbXQ.Name = "gbXQ";
            gbXQ.Size = new Size(210, 162);
            gbXQ.TabIndex = 38;
            gbXQ.TabStop = false;
            gbXQ.Text = "镶嵌属性";
            cbInlay6b.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInlay6b.FormattingEnabled = true;
            cbInlay6b.Location = new Point(56, 137);
            cbInlay6b.Name = "cbInlay6b";
            cbInlay6b.Size = new Size(150, 20);
            cbInlay6b.TabIndex = 45;
            label11.AutoSize = true;
            label11.Location = new Point(3, 142);
            label11.Name = "label11";
            label11.Size = new Size(53, 12);
            label11.TabIndex = 44;
            label11.Text = "荧光属性";
            label10.AutoSize = true;
            label10.Location = new Point(3, 118);
            label10.Name = "label10";
            label10.Size = new Size(23, 12);
            label10.TabIndex = 43;
            label10.Text = "孔5";
            label9.AutoSize = true;
            label9.Location = new Point(3, 92);
            label9.Name = "label9";
            label9.Size = new Size(23, 12);
            label9.TabIndex = 42;
            label9.Text = "孔4";
            label8.AutoSize = true;
            label8.Location = new Point(3, 68);
            label8.Name = "label8";
            label8.Size = new Size(23, 12);
            label8.TabIndex = 41;
            label8.Text = "孔3";
            label7.AutoSize = true;
            label7.Location = new Point(3, 42);
            label7.Name = "label7";
            label7.Size = new Size(23, 12);
            label7.TabIndex = 40;
            label7.Text = "孔2";
            label6.AutoSize = true;
            label6.Location = new Point(3, 17);
            label6.Name = "label6";
            label6.Size = new Size(23, 12);
            label6.TabIndex = 39;
            label6.Text = "孔1";
            cbInlay5b.DropDownHeight = 206;
            cbInlay5b.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInlay5b.FormattingEnabled = true;
            cbInlay5b.IntegralHeight = false;
            cbInlay5b.Location = new Point(26, 113);
            cbInlay5b.Name = "cbInlay5b";
            cbInlay5b.Size = new Size(180, 20);
            cbInlay5b.TabIndex = 38;
            cbInlay4b.DropDownHeight = 206;
            cbInlay4b.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInlay4b.FormattingEnabled = true;
            cbInlay4b.IntegralHeight = false;
            cbInlay4b.Location = new Point(26, 88);
            cbInlay4b.Name = "cbInlay4b";
            cbInlay4b.Size = new Size(180, 20);
            cbInlay4b.TabIndex = 37;
            cbInlay3b.DropDownHeight = 206;
            cbInlay3b.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInlay3b.FormattingEnabled = true;
            cbInlay3b.IntegralHeight = false;
            cbInlay3b.Location = new Point(26, 63);
            cbInlay3b.Name = "cbInlay3b";
            cbInlay3b.Size = new Size(180, 20);
            cbInlay3b.TabIndex = 36;
            cbInlay2b.DropDownHeight = 206;
            cbInlay2b.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInlay2b.FormattingEnabled = true;
            cbInlay2b.IntegralHeight = false;
            cbInlay2b.Location = new Point(26, 38);
            cbInlay2b.Name = "cbInlay2b";
            cbInlay2b.Size = new Size(180, 20);
            cbInlay2b.TabIndex = 34;
            cbInlay1b.DropDownHeight = 206;
            cbInlay1b.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInlay1b.FormattingEnabled = true;
            cbInlay1b.IntegralHeight = false;
            cbInlay1b.Location = new Point(26, 13);
            cbInlay1b.Name = "cbInlay1b";
            cbInlay1b.Size = new Size(180, 20);
            cbInlay1b.TabIndex = 32;
            cbZhiye.DropDownHeight = 206;
            cbZhiye.DropDownStyle = ComboBoxStyle.DropDownList;
            cbZhiye.FormattingEnabled = true;
            cbZhiye.IntegralHeight = false;
            cbZhiye.Items.AddRange(new object[]
            {
                "全部",
                "魔法师",
                "剑士",
                "弓箭手",
                "魔剑士",
                "圣导师",
                "召唤师",
                "决斗士"
            });
            cbZhiye.Location = new Point(62, 0);
            cbZhiye.Name = "cbZhiye";
            cbZhiye.Size = new Size(67, 20);
            cbZhiye.TabIndex = 40;
            cbZhiye.SelectedIndexChanged += cboEquipType_SelectedIndexChanged;
            label4.AutoSize = true;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(65, 12);
            label4.TabIndex = 39;
            label4.Text = "职业选择：";
            label5.AutoSize = true;
            label5.Location = new Point(125, 130);
            label5.Name = "label5";
            label5.Size = new Size(41, 12);
            label5.TabIndex = 42;
            label5.Text = "套装值";
            cbSetVal.DropDownHeight = 206;
            cbSetVal.DropDownStyle = ComboBoxStyle.DropDownList;
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
            cbSetVal.Location = new Point(171, 126);
            cbSetVal.Name = "cbSetVal";
            cbSetVal.Size = new Size(35, 20);
            cbSetVal.TabIndex = 43;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.Controls.Add(cbSetVal);
            base.Controls.Add(label5);
            base.Controls.Add(cbZhiye);
            base.Controls.Add(label4);
            base.Controls.Add(AddNums);
            base.Controls.Add(gbXQ);
            base.Controls.Add(label2);
            base.Controls.Add(txtCode);
            base.Controls.Add(chkAllPart);
            base.Controls.Add(label3);
            base.Controls.Add(eee);
            base.Controls.Add(cboPlusLevel);
            base.Controls.Add(cboPlusType);
            base.Controls.Add(txtDurability);
            base.Controls.Add(chk380);
            base.Controls.Add(label1);
            base.Controls.Add(cboEquipLevel);
            base.Controls.Add(cboEquipExt);
            base.Controls.Add(label31);
            base.Controls.Add(cboEquipName);
            base.Controls.Add(cboEquipType);
            base.Controls.Add(groupBox3);
            base.Controls.Add(chkEquipXY);
            base.Controls.Add(chkEquipJN);
            base.Controls.Add(label30);
            base.Controls.Add(label29);
            base.Controls.Add(label28);
            base.Margin = new Padding(0);
            base.Name = "EquipEditor";
            base.Size = new Size(217, 453);
            base.Load += EquipEditor_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gbXQ.ResumeLayout(false);
            gbXQ.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private ComboBox cboEquipLevel;
        private ComboBox cboEquipExt;
        private Label label31;
        private ComboBox cboEquipName;
        private ComboBox cboEquipType;
        private GroupBox groupBox3;
        private Button button2;
        private CheckBox chkEquipZY6;
        private CheckBox chkEquipZY4;
        private CheckBox chkEquipZY2;
        private CheckBox chkEquipZY5;
        private CheckBox chkEquipZY3;
        private CheckBox chkEquipZY1;
        private CheckBox chkEquipXY;
        private CheckBox chkEquipJN;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label1;
        private TextBox txtDurability;
        private CheckBox chk380;
        private ComboBox cboPlusType;
        private ComboBox cboPlusLevel;
        private Label eee;
        private Label label3;
        private Button button4;
        private Button button1;
        private Button button3;
        private TextBox AddNums;
        private Label label2;
        private CheckBox chkAllPart;
        private TextBox txtCode;
        private GroupBox gbXQ;
        private ComboBox cbInlay1b;
        private ComboBox cbInlay3b;
        private ComboBox cbInlay2b;
        private ComboBox cbInlay5b;
        private ComboBox cbInlay4b;
        private ComboBox cbZhiye;
        private Label label4;
        private Label label5;
        private ComboBox cbSetVal;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cbInlay6b;
        #endregion
    }
}
