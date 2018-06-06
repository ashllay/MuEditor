using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace MuEditor
{
    public partial class T_CashShop_Point : Form//frmBase
    {
        public T_CashShop_Point()
        {
            this.InitializeComponent();
        }

        private void T_CashShop_Load(object sender, EventArgs e)
        {
        }

        private void txtAccountLoad()
        {
            if (frmBase.Me_Conn.State != ConnectionState.Open)
            {
                return;
            }
            string text = null;
            try
            {
                text = "SELECT TOP 100 [memb___id] FROM [MEMB_INFO]";
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                this.txtAccount.Items.Clear();
                this.txtAccount.AutoCompleteCustomSource.Clear();
                this.txtAccount.Text = "";
                while (oleDbDataReader.Read())
                {
                    this.txtAccount.Items.Add(oleDbDataReader.GetValue(0));
                }
                if (this.txtAccount.Items.Count > 0)
                {
                    this.txtAccount.SelectedIndex = 0;
                }
                oleDbDataReader.Close();
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "SQL：",
                    text,
                    "\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
        }

        public void InputAccount(string account)
        {
            this.Cursor = Cursors.WaitCursor;
            this.showByAccount(account);
            this.Cursor = Cursors.Default;
        }

        private void showByCashLog(string UserID)
        {
            if (UserID == "")
            {
                return;
            }
            if (frmBase.Mu_Conn.State != ConnectionState.Open)
            {
                return;
            }
            string text = null;
            try
            {
                text = string.Format("SELECT [ID] AS [编号], [UserID] AS [游戏账号], [Amount] AS [充值点数], [SentDate] AS [充值时间] FROM [CashLog] WHERE ([UserID] = N'{0}') ORDER BY [ID] DESC", UserID);
                OleDbCommand selectCommand = new OleDbCommand(text, frmBase.Mu_Conn);
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                this.CashLog.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "SQL：",
                    text,
                    "\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
        }

        private void showByAccount(string account)
        {
            if (account == "")
            {
                return;
            }
            if (frmBase.Me_Conn.State != ConnectionState.Open)
            {
                return;
            }
            string text = null;
            try
            {
                text = string.Format("SELECT [Amount] FROM [Account] WHERE ([UserID] = N'{0}')", account);
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.WCoinC.Text = Convert.ToString(oleDbDataReader.GetValue(0));
                }
                else
                {
                    Utils.WarningMessage("对不起，没有找到帐号[" + account + "]对应的积分信息！");
                    this.WCoinC.Text = "0";
                }
                oleDbDataReader.Close();
                this.WCoinC_Add.Text = "0";
                this.showByCashLog(account);
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "SQL：",
                    text,
                    "\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
        }

        private void txtAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InputAccount(this.txtAccount.Text.Trim());
        }

        private void txtAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.InputAccount(this.txtAccount.Text.Trim());
            }
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            if (this.txtAccount.Items.Contains(this.txtAccount.Text) || this.txtAccount.Text == null)
            {
                return;
            }
            if (frmBase.Me_Conn.State != ConnectionState.Open)
            {
                return;
            }
            string text = null;
            try
            {
                text = string.Format("SELECT TOP 100 [memb___id] FROM [MEMB_INFO] WHERE [memb___id] LIKE '{0}%'", this.txtAccount.Text);
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    object value = oleDbDataReader.GetValue(0);
                    if (!this.txtAccount.Items.Contains(value))
                    {
                        this.txtAccount.Items.Add(value);
                    }
                }
                oleDbDataReader.Close();
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "SQL：",
                    text,
                    "\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
        }

        private void btn_CashShop_Click(object sender, EventArgs e)
        {
            if (!(this.txtAccount.Text.Trim() == "") && !(this.WCoinC_Add.Text.Trim() == "0"))
            {
                string text = string.Format("UPDATE Account SET Amount += {0} WHERE (UserID = N'{1}')", this.WCoinC_Add.Text.Trim(), this.txtAccount.Text.Trim());
                try
                {
                    if (frmBase.Me_ExecuteSQL(text))
                    {
                        text = string.Format("INSERT INTO CashLog (UserID, Amount) VALUES ('{0}', {1});", this.txtAccount.Text.Trim(), this.WCoinC_Add.Text.Trim());
                        OleDbCommand oleDbCommand = new OleDbCommand(text.ToString(), frmBase.Mu_Conn);
                        oleDbCommand.ExecuteNonQuery();
                        Utils.InfoMessage("操作成功！");
                        this.InputAccount(this.txtAccount.Text.Trim());
                    }
                    else
                    {
                        Utils.WarningMessage("操作失败！");
                    }
                }
                catch (Exception ex)
                {
                    Utils.WarningMessage(string.Concat(new string[]
                    {
                        "Error:",
                        ex.Message,
                        "\nSource:",
                        ex.Source,
                        "\nTrace:",
                        ex.StackTrace
                    }));
                }
                return;
            }
        }
    }
}
