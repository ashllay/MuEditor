namespace MuEditor
{
    public partial class T_CashShop_Point// : global::MuEditor.frmBase
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MuEditor.T_CashShop_Point));
            this.groupBox1 = new global::System.Windows.Forms.GroupBox();
            this.btn_CashShop = new global::System.Windows.Forms.Button();
            this.WCoinC_Add = new global::MuEditor.TextBox();
            this.label3 = new global::System.Windows.Forms.Label();
            this.WCoinC = new global::System.Windows.Forms.TextBox();
            this.label2 = new global::System.Windows.Forms.Label();
            this.txtAccount = new global::System.Windows.Forms.ComboBox();
            this.label1 = new global::System.Windows.Forms.Label();
            this.groupBox2 = new global::System.Windows.Forms.GroupBox();
            this.CashLog = new global::System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.CashLog).BeginInit();
            base.SuspendLayout();
            this.groupBox1.Controls.Add(this.btn_CashShop);
            this.groupBox1.Controls.Add(this.WCoinC_Add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.WCoinC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new global::System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new global::System.Drawing.Size(490, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "积分商城管理";
            this.btn_CashShop.Location = new global::System.Drawing.Point(12, 52);
            this.btn_CashShop.Name = "btn_CashShop";
            this.btn_CashShop.Size = new global::System.Drawing.Size(466, 23);
            this.btn_CashShop.TabIndex = 6;
            this.btn_CashShop.Text = "确定保存";
            this.btn_CashShop.UseVisualStyleBackColor = true;
            this.btn_CashShop.Click += new global::System.EventHandler(this.btn_CashShop_Click);
            this.WCoinC_Add.IsOnlyNumber = false;
            this.WCoinC_Add.Location = new global::System.Drawing.Point(378, 23);
            this.WCoinC_Add.Name = "WCoinC_Add";
            this.WCoinC_Add.Size = new global::System.Drawing.Size(100, 21);
            this.WCoinC_Add.TabIndex = 5;
            this.WCoinC_Add.Text = "0";
            this.WCoinC_Add.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
            this.label3.AutoSize = true;
            this.label3.Location = new global::System.Drawing.Point(349, 28);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(23, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "+/-";
            this.WCoinC.Location = new global::System.Drawing.Point(241, 24);
            this.WCoinC.Name = "WCoinC";
            this.WCoinC.ReadOnly = true;
            this.WCoinC.Size = new global::System.Drawing.Size(100, 21);
            this.WCoinC.TabIndex = 3;
            this.WCoinC.Text = "0";
            this.WCoinC.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
            this.label2.AutoSize = true;
            this.label2.Location = new global::System.Drawing.Point(191, 28);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "WCoinC：";
            this.txtAccount.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccount.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAccount.FormattingEnabled = true;
            this.txtAccount.Location = new global::System.Drawing.Point(62, 24);
            this.txtAccount.MaxLength = 10;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new global::System.Drawing.Size(121, 20);
            this.txtAccount.TabIndex = 1;
            this.txtAccount.SelectedIndexChanged += new global::System.EventHandler(this.txtAccount_SelectedIndexChanged);
            this.txtAccount.TextChanged += new global::System.EventHandler(this.txtAccount_TextChanged);
            this.txtAccount.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtAccount_KeyPress);
            this.label1.AutoSize = true;
            this.label1.Location = new global::System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "帐\u3000号：";
            this.groupBox2.Controls.Add(this.CashLog);
            this.groupBox2.Location = new global::System.Drawing.Point(8, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new global::System.Drawing.Size(490, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "充值记录";
            this.CashLog.AllowUserToAddRows = false;
            this.CashLog.AllowUserToDeleteRows = false;
            this.CashLog.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CashLog.Location = new global::System.Drawing.Point(12, 20);
            this.CashLog.Name = "CashLog";
            this.CashLog.ReadOnly = true;
            this.CashLog.RowTemplate.Height = 23;
            this.CashLog.Size = new global::System.Drawing.Size(466, 286);
            this.CashLog.TabIndex = 0;
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(507, 419);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "T_CashShop_Point";
            base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "积分商城点数";
            base.Load += new global::System.EventHandler(this.T_CashShop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)this.CashLog).EndInit();
            base.ResumeLayout(false);
        }

        private global::System.ComponentModel.IContainer components;
        private global::System.Windows.Forms.GroupBox groupBox1;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.ComboBox txtAccount;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.TextBox WCoinC;
        private global::MuEditor.TextBox WCoinC_Add;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Button btn_CashShop;
        private global::System.Windows.Forms.GroupBox groupBox2;
        private global::System.Windows.Forms.DataGridView CashLog;
    }
}
