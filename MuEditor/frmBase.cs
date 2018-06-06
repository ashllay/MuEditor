using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace MuEditor
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        public static bool Me_ExecuteSQL(string sql)
        {
            try
            {
                OleDbCommand oleDbCommand = new OleDbCommand(sql, Me_Conn);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "SQL：",
                    sql,
                    "\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
            return false;
        }

        public static bool Mu_ExecuteSQL(string sql)
        {
            try
            {
                OleDbCommand oleDbCommand = new OleDbCommand(sql, frmBase.Mu_Conn);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "SQL：",
                    sql,
                    "\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
            return false;
        }

        public static OleDbConnection Me_Conn = new OleDbConnection();
        public static OleDbConnection Mu_Conn = new OleDbConnection();
    }
}
