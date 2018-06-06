using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Library.Common;
using MuEditor.Properties;

namespace MuEditor
{
    // Token: 0x0200000A RID: 10
    public partial class frmMain : Form
    {
        private bool accountLogin;
        private bool charLogin;
        public static string ME_SERVER = "(local)";
        public static string ME_DB = "Me_MuOnline";
        public static string MU_SERVER = "(local)";
        public static string MU_DB = "MuOnline";
        private string lastAccount = "";
        private string lastCharName = "";
        private string wareHouseCode = "";
        private string wareHouseLv1Code = "";
        private string charPanelCode = "";
        private string packagePanelCode = "";
        private string packagePanelLv1Code = "";
        private string packagePanelLv2Code = "";
        private string packagePanelLv3Code = "";
        private string packagePanelLv4Code = "";
        private string shopPanelCode = "";
        private string sPentagramPanelCode = "";
        private string ExtendedInvenCount = "";
        private bool MD5 = true;
        private frmUser FrmUser;
        private frmGuild FrmGuild;
        private frmInitEquip FrmEquip;
        private T_CashShop_Point T_CashShop;
        public static CMagicDamage[] xMagic = null;
        private int rightPanelFlag;

        public bool LoadedPackage
        {
            get
            {
                return (rightPanelFlag & 8) != 0;
            }
            set
            {
                if (value)
                {
                    rightPanelFlag |= 8;
                    return;
                }
                rightPanelFlag &= 247;
            }
        }

        public bool LoadedWarehouse
        {
            get
            {
                return (rightPanelFlag & 128) != 0;
            }
            set
            {
                if (value)
                {
                    rightPanelFlag |= 128;
                    return;
                }
                rightPanelFlag &= 127;
            }
        }

        public bool ShownPackage
        {
            get
            {
                return (rightPanelFlag & 2) != 0;
            }
            set
            {
                if (value)
                {
                    rightPanelFlag |= 2;
                    return;
                }
                rightPanelFlag &= 253;
            }
        }

        public bool ShownWarehouse
        {
            get
            {
                return (rightPanelFlag & 32) != 0;
            }
            set
            {
                if (value)
                {
                    rightPanelFlag |= 32;
                    return;
                }
                rightPanelFlag &= 223;
            }
        }

        public bool PackageReset
        {
            set
            {
                if (value)
                {
                    rightPanelFlag &= 240;
                }
            }
        }

        public bool WarehouseReset
        {
            set
            {
                if (value)
                {
                    rightPanelFlag &= 15;
                }
            }
        }

        public frmMain()
        {
            InitializeComponent();
            string text = "Data\\Skill.bmd";
            if (!File.Exists(text))
            {
                text = "MuEdit\\bin\\Release\\" + text;
            }
            SkillClass skillClass = new SkillClass(text);
            frmMain.xMagic = skillClass.cMagic;
        }

        private bool CheckTable(OleDbConnection conn, string tableName)
        {
            DataTable schema = conn.GetSchema("Tables");
            DataRow[] array = schema.Select(string.Format("TABLE_TYPE = 'TABLE' and TABLE_NAME = '{0}'", tableName));
            return array.Length > 0;
        }

        public static string ByteToString(byte[] Characters, int cLength)
        {
            return Encoding.GetEncoding("GB2312").GetString(Characters, 0, cLength).Replace("\0", " ").TrimEnd(new char[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(frmMain.ByteToString(frmMain.xMagic[1].Name, 32));
            Console.WriteLine(frmMain.ByteToString(EquipEditor.xItem[1].Name, 30));
            Console.WriteLine(frmMain.ByteToString(EquipEditor.xSocket[1].byte_0, 64));
            IniClass iniClass = new IniClass(".\\DSN.ini");
            string text = "";
            try
            {
                string a = iniClass.IniReadValue("Me_MuOnline", "EnableTrusted", "1");
                frmMain.ME_SERVER = iniClass.IniReadValue("Me_MuOnline", "SERVER", "(local)");
                if (frmMain.ME_SERVER == "(local)" || frmMain.ME_SERVER == "localhost")
                {
                    frmMain.ME_SERVER = Dns.GetHostName().ToUpperInvariant();
                }
                string text2 = iniClass.IniReadValue("Me_MuOnline", "PORT", "1433");
                frmMain.ME_DB = iniClass.IniReadValue("Me_MuOnline", "ME_DB", "Me_MuOnline");
                string text3 = iniClass.IniReadValue("Me_MuOnline", "USER", "sa");
                string text4 = iniClass.IniReadValue("Me_MuOnline", "PASS", "sa");
                text = "";
                if (a == "1")
                {
                    text = string.Format("Provider=SQLOLEDB.1;Data Source={0};Initial Catalog={1};Integrated Security=SSPI;", frmMain.ME_SERVER, frmMain.ME_DB);
                }
                else
                {
                    text = string.Format("Provider=SQLOLEDB.1;Data Source={0},{1};Initial Catalog={2};Uid={3};Pwd={4}", new object[]
                    {
                        frmMain.ME_SERVER,
                        text2,
                        frmMain.ME_DB,
                        text3,
                        text4
                    });
                }
                frmBase.Me_Conn.ConnectionString = text;
                frmBase.Me_Conn.Open();
                a = iniClass.IniReadValue("MuOnline", "EnableTrusted", "1");
                frmMain.MU_SERVER = iniClass.IniReadValue("MuOnline", "SERVER", "(local)");
                if (frmMain.MU_SERVER == "(local)" || frmMain.MU_SERVER == "localhost")
                {
                    frmMain.MU_SERVER = Dns.GetHostName().ToUpperInvariant();
                }
                text2 = iniClass.IniReadValue("MuOnline", "PORT", "1433");
                frmMain.MU_DB = iniClass.IniReadValue("MuOnline", "MU_DB", "MuOnline");
                text3 = iniClass.IniReadValue("MuOnline", "USER", "sa");
                text4 = iniClass.IniReadValue("MuOnline", "PASS", "sa");
                text = "";
                if (a == "1")
                {
                    text = string.Format("Provider=SQLOLEDB.1;Data Source={0};Initial Catalog={1};Integrated Security=SSPI;", frmMain.MU_SERVER, frmMain.MU_DB);
                }
                else
                {
                    text = string.Format("Provider=SQLOLEDB.1;Data Source={0},{1};Initial Catalog={2};Uid={3};Pwd={4}", new object[]
                    {
                        frmMain.MU_SERVER,
                        text2,
                        frmMain.MU_DB,
                        text3,
                        text4
                    });
                }
                frmBase.Mu_Conn.ConnectionString = text;
                frmBase.Mu_Conn.Open();
                if (!CheckTable(frmBase.Mu_Conn, "ItemLog"))
                {
                    string cmdText = "CREATE TABLE [dbo].[ItemLog] (\r\n\t[SEQ] [int] IDENTITY (1, 1) NOT NULL,\r\n\t[Acc] [varchar] (10) COLLATE Chinese_PRC_CS_AS_KS_WS NULL,\r\n\t[Name] [varchar] (10) COLLATE Chinese_PRC_CS_AS_KS_WS NULL,\r\n\t[ItemCode] [varbinary] (32) NULL,\r\n\t[SN] [int] NULL,\r\n\t[iName] [varchar] (50) COLLATE Chinese_PRC_CS_AS_KS_WS NULL,\r\n\t[iLvl] [varchar] (50) COLLATE Chinese_PRC_CS_AS_KS_WS NULL,\r\n\t[iSkill] [smallint] NULL,\r\n\t[iLuck] [smallint] NULL,\r\n\t[iExt] [varchar] (500) COLLATE Chinese_PRC_CS_AS_KS_WS NULL,\r\n\t[iSet] [smallint] NULL,\r\n\t[i380] [smallint] NULL,\r\n\t[iJh] [smallint] NULL,\r\n\t[SentDate] [smalldatetime] NULL \r\n) ON [PRIMARY]\r\nALTER TABLE [dbo].[ItemLog] ADD  DEFAULT (getdate()) FOR [SentDate]\r\n";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, frmBase.Mu_Conn);
                    oleDbCommand.ExecuteNonQuery();
                }
                if (!CheckTable(frmBase.Mu_Conn, "CashLog"))
                {
                    string cmdText2 = "CREATE TABLE [dbo].[CashLog] (\r\n\t[ID] [int] IDENTITY (1, 1) NOT NULL,\r\n\t[UserID] [varchar] (16) COLLATE Chinese_PRC_CS_AS_KS_WS NULL,\r\n\t[Amount] [money] NULL,\r\n\t[SentDate] [smalldatetime] NULL \r\n) ON [PRIMARY]\r\nALTER TABLE [dbo].[CashLog] ADD  DEFAULT (getdate()) FOR [SentDate]\r\n";
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, frmBase.Mu_Conn);
                    oleDbCommand2.ExecuteNonQuery();
                }
                string cmdText3 = "SELECT MIN(SN) AS SN FROM ItemLog";
                OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, frmBase.Mu_Conn);
                object obj = oleDbCommand3.ExecuteScalar();
                Utils.SN = ((obj == DBNull.Value) ? 0 : Convert.ToInt32(obj));
            }
            catch (Exception ex)
            {
                Utils.WarningMessage("数据库连接错误，错误信息：" + ex.Message + "\n数据库连接：" + text);
            }
            charPanel.Editor = equipEditor;
            packagePanel.setSize(8, 8);
            packagePanel.Editor = equipEditor;
            packagePanelLv1.setSize(8, 4);
            packagePanelLv1.Editor = equipEditor;
            packagePanelLv2.setSize(8, 4);
            packagePanelLv2.Editor = equipEditor;
            packagePanelLv3.setSize(8, 4);
            packagePanelLv3.Editor = equipEditor;
            packagePanelLv4.setSize(8, 4);
            packagePanelLv4.Editor = equipEditor;
            shopPanel.setSize(8, 4);
            shopPanel.Editor = equipEditor;
            sPentagramPanel.Editor = equipEditor;
            warehousePanel.setSize(8, 15);
            warehousePanel.Editor = equipEditor;
            warehousePanelLv1.setSize(8, 15);
            warehousePanelLv1.Editor = equipEditor;
            equipEditor.LoadData();
            updateUI();
        }

        private void LoadSkillList()
        {
            throw new NotImplementedException();
        }

        private bool isOnline()
        {
            string text = "";
            bool result = false;
            try
            {
                Cursor = Cursors.WaitCursor;
                text = "SELECT [ConnectStat] FROM [MEMB_STAT] WHERE ([memb___id] = '" + txtAcc.Text.Trim() + "')";
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    result = (oleDbDataReader.GetValue(0).ToString() == "1");
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
            return result;
        }

        private bool isCharOnline()
        {
            string text = "";
            bool result = false;
            try
            {
                Cursor = Cursors.WaitCursor;
                text = string.Format(string.Concat(new string[]
                {
                    "SELECT [MEMB_STAT].[ConnectStat] FROM [",
                    frmMain.MU_SERVER,
                    "].[",
                    frmMain.MU_DB,
                    "].[dbo].[AccountCharacter] AS [AC] INNER JOIN [dbo].[MEMB_STAT] ON [AC].[Id] = [MEMB_STAT].[memb___id] COLLATE Chinese_PRC_CS_AS_KS_WS WHERE ([AC].[Id] = '{0}') AND ([AC].[GameIDC] = '{1}')"
                }), txtAcc.Text.Trim(), txtChar.Text.Trim());
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    result = (oleDbDataReader.GetValue(0).ToString() == "1");
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
            return result;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string account = txtAcc.Text.Trim();
            saveAccount(account);
            Cursor = Cursors.Default;
        }

        private void saveLast(bool isChar)
        {
            if (isChar)
            {
                packagePanel.DownItem();
                packagePanelLv1.DownItem();
                packagePanelLv2.DownItem();
                packagePanelLv3.DownItem();
                packagePanelLv4.DownItem();
                shopPanel.DownItem();
                if (((packagePanelCode != "" && packagePanelCode != packagePanel.getEquipCodes()) || (packagePanelLv1Code != "" && packagePanelLv1Code != packagePanelLv1.getEquipCodes()) || (packagePanelLv2Code != "" && packagePanelLv2Code != packagePanelLv2.getEquipCodes()) || (packagePanelLv3Code != "" && packagePanelLv3Code != packagePanelLv3.getEquipCodes()) || (packagePanelLv4Code != "" && packagePanelLv4Code != packagePanelLv4.getEquipCodes()) || (charPanelCode != "" && charPanelCode != charPanel.getEquipCodes()) || (shopPanelCode != "" && shopPanelCode != shopPanel.getEquipCodes()) || (sPentagramPanelCode != "" && sPentagramPanelCode != sPentagramPanel.getEquipCodes())) && MessageBox.Show("当前仓库、包裹或商店已改变，是否保存改变？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveInventory(lastCharName);
                    saveAddInventory(lastCharName);
                    return;
                }
            }
            else
            {
                warehousePanel.DownItem();
                warehousePanelLv1.DownItem();
                packagePanel.DownItem();
                packagePanelLv1.DownItem();
                packagePanelLv2.DownItem();
                packagePanelLv3.DownItem();
                packagePanelLv4.DownItem();
                shopPanel.DownItem();
                if (((wareHouseCode != "" && wareHouseCode != warehousePanel.getEquipCodes()) || (wareHouseLv1Code != "" && wareHouseLv1Code != warehousePanelLv1.getEquipCodes()) || (packagePanelCode != "" && packagePanelCode != packagePanel.getEquipCodes()) || (packagePanelLv1Code != "" && packagePanelLv1Code != packagePanelLv1.getEquipCodes()) || (packagePanelLv2Code != "" && packagePanelLv2Code != packagePanelLv2.getEquipCodes()) || (packagePanelLv3Code != "" && packagePanelLv3Code != packagePanelLv3.getEquipCodes()) || (packagePanelLv4Code != "" && packagePanelLv4Code != packagePanelLv4.getEquipCodes()) || (charPanelCode != "" && charPanelCode != charPanel.getEquipCodes()) || (shopPanelCode != "" && shopPanelCode != shopPanel.getEquipCodes()) || (sPentagramPanelCode != "" && sPentagramPanelCode != sPentagramPanel.getEquipCodes())) && MessageBox.Show("当前仓库、包裹或商店已改变，是否保存改变？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveInventory(lastCharName);
                    saveAddInventory(lastCharName);
                    saveWarehouse(lastAccount);
                }
            }
        }

        public void InputAccount(string account)
        {
            Cursor = Cursors.WaitCursor;
            saveLast(false);
            showByAccount(account, "");
            updateUI();
            Cursor = Cursors.Default;
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
                txtAccount.Items.Clear();
                txtAccount.AutoCompleteCustomSource.Clear();
                txtAccount.Text = "";
                while (oleDbDataReader.Read())
                {
                    txtAccount.Items.Add(oleDbDataReader.GetValue(0));
                }
                if (txtAccount.Items.Count > 0)
                {
                    txtAccount.SelectedIndex = 0;
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

        private void txtAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputAccount(txtAccount.Text.Trim());
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            if (txtAccount.Items.Contains(txtAccount.Text) || txtAccount.Text == null)
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
                text = string.Format("SELECT TOP 100 [memb___id] FROM [MEMB_INFO] WHERE [memb___id] LIKE '{0}%'", txtAccount.Text);
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    object value = oleDbDataReader.GetValue(0);
                    if (!txtAccount.Items.Contains(value))
                    {
                        txtAccount.Items.Add(value);
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

        private void txtAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                InputAccount(txtAccount.Text.Trim());
            }
        }

        public void InputCharacter(string charName)
        {
            Cursor = Cursors.WaitCursor;
            saveLast(true);
            showByCharacter(charName);
            updateUI();
            Cursor = Cursors.Default;
        }

        private void cmbChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                InputCharacter(cmbChar.Text.Trim());
            }
        }

        private void clearGDI(bool isChar)
        {
            accountLogin = false;
            charLogin = false;
            btnUpdateChar.Enabled = false;
            btnUpdatePackage.Enabled = false;
            btnClearPackage.Enabled = false;
            charPanel.clearData();
            charPanel.Invalidate();
            packagePanel.clearData();
            packagePanel.Invalidate();
            packagePanelLv1.clearData();
            packagePanelLv1.Invalidate();
            packagePanelLv2.clearData();
            packagePanelLv2.Invalidate();
            packagePanelLv3.clearData();
            packagePanelLv3.Invalidate();
            packagePanelLv4.clearData();
            packagePanelLv4.Invalidate();
            shopPanel.clearData();
            shopPanel.Invalidate();
            sPentagramPanel.clearData();
            sPentagramPanel.Invalidate();
            charPanelCode = "";
            packagePanelCode = "";
            packagePanelLv1Code = "";
            packagePanelLv2Code = "";
            packagePanelLv3Code = "";
            packagePanelLv4Code = "";
            shopPanelCode = "";
            sPentagramPanelCode = "";
            if (!isChar)
            {
                btnUpdateWarehouse.Enabled = false;
                btnClearWarehouse.Enabled = false;
                warehousePanel.clearData();
                warehousePanel.Invalidate();
                wareHouseCode = "";
                warehousePanelLv1.clearData();
                warehousePanelLv1.Invalidate();
                wareHouseLv1Code = "";
            }
        }

        private void showGDI(bool isChar)
        {
            accountLogin = true;
            charLogin = true;
            btnUpdateChar.Enabled = true;
            btnUpdatePackage.Enabled = true;
            btnUpdateWarehouse.Enabled = true;
            btnClearPackage.Enabled = true;
            btnClearWarehouse.Enabled = true;
            showPackageItems();
            if (!isChar)
            {
                showWarehouseItems();
                wareHouseCode = warehousePanel.getEquipCodes();
                wareHouseLv1Code = warehousePanelLv1.getEquipCodes();
            }
            charPanelCode = charPanel.getEquipCodes();
            packagePanelCode = packagePanel.getEquipCodes();
            packagePanelLv1Code = packagePanelLv1.getEquipCodes();
            packagePanelLv2Code = packagePanelLv2.getEquipCodes();
            packagePanelLv3Code = packagePanelLv3.getEquipCodes();
            packagePanelLv4Code = packagePanelLv4.getEquipCodes();
            shopPanelCode = shopPanel.getEquipCodes();
            sPentagramPanelCode = sPentagramPanel.getEquipCodes();
        }

        private void showByAccount(string account, string charName)
        {
            if (account == "")
            {
                return;
            }
            lastAccount = account;
            if (frmBase.Me_Conn.State != ConnectionState.Open)
            {
                return;
            }
            string text = null;
            try
            {
                text = string.Format("SELECT [a].[memb___id], [a].[memb__pwd], [a].[memb_name], [a].[sno__numb], [a].[mail_addr], [a].[fpas_ques], [a].[fpas_answ], [a].[bloc_code], [a].[area_code], [b].[ConnectStat], [b].[ServerName], [b].[IP], [b].[ConnectTM], [b].[DisConnectTM] FROM [MEMB_INFO] AS [a] LEFT OUTER JOIN [MEMB_STAT] AS [b] ON [a].[memb___id] = [b].[memb___id] COLLATE Chinese_PRC_CS_AS_KS_WS WHERE ([a].[memb___id] = '{0}')", account);
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    DataTable schemaTable = oleDbDataReader.GetSchemaTable();
                    foreach (object obj in schemaTable.Rows)
                    {
                        DataRow dataRow = (DataRow)obj;
                        if (Convert.ToString(dataRow["ColumnName"]) == "[memb__pwd]")
                        {
                            MD5 = (Convert.ToString(dataRow["DataType"]) == "System.Byte[]");
                            break;
                        }
                    }
                    txtAccount.Text = (txtAcc.Text = Convert.ToString(oleDbDataReader.GetValue(0)));
                    txtPassword.Text = (MD5 ? "已加密" : oleDbDataReader.GetString(1));
                    txtPassword.BackColor = (MD5 ? Color.Red : Color.Transparent);
                    txtPassword.ForeColor = (MD5 ? Color.Transparent : Color.Red);
                    txtNick.Text = ((Convert.ToString(oleDbDataReader.GetValue(2)) == "") ? "NULL" : Convert.ToString(oleDbDataReader.GetValue(2)));
                    txtSNO.Text = ((Convert.ToString(oleDbDataReader.GetValue(3)) == "") ? "NULL" : Convert.ToString(oleDbDataReader.GetValue(3)));
                    txtEMail.Text = ((Convert.ToString(oleDbDataReader.GetValue(4)) == "") ? "NULL" : Convert.ToString(oleDbDataReader.GetValue(4)));
                    txtQuestion.Text = ((Convert.ToString(oleDbDataReader.GetValue(5)) == "") ? "NULL" : Convert.ToString(oleDbDataReader.GetValue(5)));
                    txtAnswer.Text = ((Convert.ToString(oleDbDataReader.GetValue(6)) == "") ? "NULL" : Convert.ToString(oleDbDataReader.GetValue(6)));
                    string a = Convert.ToString(oleDbDataReader.GetValue(7));
                    chkState.Checked = (a == "1");
                    txtServerCode.Text = Convert.ToString(Convert.ToInt32(oleDbDataReader.GetValue(8)) + 1);
                    string text2 = (oleDbDataReader.GetValue(9).ToString() == "0") ? "已下线" : "在线";
                    lblState.Text = text2;
                    lblState.ForeColor = ((text2.Length == 2) ? Color.Red : Color.Green);
                    lblServer.Text = string.Format("服 务 器：{0}", oleDbDataReader.GetValue(10));
                    lblIP.Text = string.Format("{0}", oleDbDataReader.GetValue(11));
                    lblConnectTime.Text = string.Format("上线时间：{0:F}", oleDbDataReader.GetValue(12));
                    lblDisConnectTime.Text = string.Format("下线时间：{0:F}", oleDbDataReader.GetValue(13));
                    tabcInfo.Enabled = true;
                    pnlPackage.Enabled = true;
                    pnlWarehouse.Enabled = true;
                    showGDI(false);
                    oleDbDataReader.Close();
                    text = string.Concat(new string[]
                    {
                        "SELECT [AC].[GameIDC], [AC].[GameID1], [AC].[GameID2], [AC].[GameID3], [AC].[GameID4], [AC].[GameID5], [AC].[ExtendedWarehouseCount] FROM [dbo].[MEMB_INFO] LEFT OUTER JOIN [",
                        frmMain.MU_SERVER,
                        "].[",
                        frmMain.MU_DB,
                        "].[dbo].[AccountCharacter] AS [AC] ON [MEMB_INFO].[memb___id] = [AC].[Id] COLLATE Chinese_PRC_CS_AS_KS_WS WHERE ([AC].[Id] = '",
                        account,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                    oleDbDataReader = oleDbCommand.ExecuteReader();
                    cmbChar.Items.Clear();
                    cmbChar.Text = "";
                    if (oleDbDataReader.Read())
                    {
                        object value = oleDbDataReader.GetValue(0);
                        for (int i = 1; i <= 5; i++)
                        {
                            value = oleDbDataReader.GetValue(i);
                            if (value != null && value.ToString() != "")
                            {
                                cmbChar.Items.Add(value);
                            }
                        }
                        if (cmbChar.Items.Count > 0)
                        {
                            cmbChar.SelectedIndex = 0;
                        }
                        string a2 = Convert.ToString(oleDbDataReader.GetValue(6));
                        WarehouseExp.Checked = (a2 == "1");
                        showGDI(false);
                    }
                    else
                    {
                        Utils.WarningMessage("对不起，没有找到帐号[" + account + "]对应的角色信息！这是一个空号！");
                        pnlPackage.Enabled = false;
                        clearGDI(true);
                    }
                    oleDbDataReader.Close();
                    text = "SELECT [Account].[MUID], [Account].[Amount] FROM [MEMB_INFO] LEFT OUTER JOIN [Account] ON [MEMB_INFO].[memb___id] = [Account].[UserID] COLLATE Chinese_PRC_CS_AS_KS_WS WHERE ([UserID] = '" + account + "')";
                    oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                    oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        txtJF.Text = Convert.ToString(oleDbDataReader.GetValue(1));
                    }
                    else
                    {
                        text = "INSERT INTO [Account] ([UserID], [Amount], [MUID]) SELECT [memb___id], 0, [memb_guid] FROM [MEMB_INFO] WHERE ([memb___id] = '" + account + "')";
                        frmBase.Me_ExecuteSQL(text);
                    }
                    txtJF.Text = ((txtJF.Text == "") ? "0.0000" : txtJF.Text.Trim());
                    oleDbDataReader.Close();
                    if (charName == "")
                    {
                        charName = cmbChar.Text;
                    }
                    showCharacter(charName);
                }
                else
                {
                    Utils.WarningMessage("对不起，没有找到帐号[" + account + "]对应的帐号信息！");
                    txtAccount.SelectAll();
                    tabcInfo.Enabled = false;
                    pnlPackage.Enabled = false;
                    pnlWarehouse.Enabled = false;
                    clearGDI(false);
                }
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

        private void showByCharacter(string charName)
        {
            if (charName == "")
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
                text = "SELECT [AccountID] FROM [Character] WHERE ([Name] = '" + charName + "')";
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Mu_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    string account = Convert.ToString(oleDbDataReader.GetValue(0));
                    pnlPackage.Enabled = true;
                    oleDbDataReader.Close();
                    showByAccount(account, charName);
                }
                else
                {
                    Utils.WarningMessage("对不起，没有找到角色[" + charName + "]对应的帐号信息！");
                    oleDbDataReader.Close();
                    clearGDI(true);
                    pnlPackage.Enabled = false;
                }
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

        private void showCharacter(string charName)
        {
            if (charName == "")
            {
                return;
            }
            lastCharName = charName;
            if (frmBase.Mu_Conn.State != ConnectionState.Open)
            {
                return;
            }
            string text = null;
            try
            {
                text = "SELECT [AccountID], [cLevel], [LevelUpPoint], [Class], [Experience], [Strength], [Dexterity], [Vitality], [Energy], [Money], [MapNumber], [MapPosX], [MapPosY], [PkCount], [PkLevel], [CtlCode], [Leadership], [ExtendedInvenCount] FROM [Character] WHERE ([Name] = '" + charName + "')";
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Mu_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    Convert.ToString(oleDbDataReader.GetValue(0));
                    txtChar.Text = charName;
                    txtLevel.Text = Convert.ToString(oleDbDataReader.GetValue(1));
                    txtPoint.Text = Convert.ToString(oleDbDataReader.GetValue(2));
                    int num = 0;
                    if (oleDbDataReader.GetValue(3) != DBNull.Value)
                    {
                        num = (int)oleDbDataReader.GetByte(3);
                    }
                    int num2 = num;
                    if (num2 <= 35)
                    {
                        switch (num2)
                        {
                            case 0:
                                cboClass.SelectedIndex = 0;
                                goto IL_2C0;
                            case 1:
                                cboClass.SelectedIndex = 1;
                                goto IL_2C0;
                            case 2:
                                break;
                            case 3:
                                cboClass.SelectedIndex = 2;
                                goto IL_2C0;
                            default:
                                switch (num2)
                                {
                                    case 16:
                                        cboClass.SelectedIndex = 3;
                                        goto IL_2C0;
                                    case 17:
                                        cboClass.SelectedIndex = 4;
                                        goto IL_2C0;
                                    case 18:
                                        break;
                                    case 19:
                                        cboClass.SelectedIndex = 5;
                                        goto IL_2C0;
                                    default:
                                        switch (num2)
                                        {
                                            case 32:
                                                cboClass.SelectedIndex = 6;
                                                goto IL_2C0;
                                            case 33:
                                                cboClass.SelectedIndex = 7;
                                                goto IL_2C0;
                                            case 35:
                                                cboClass.SelectedIndex = 8;
                                                goto IL_2C0;
                                        }
                                        break;
                                }
                                break;
                        }
                    }
                    else if (num2 <= 66)
                    {
                        switch (num2)
                        {
                            case 48:
                                cboClass.SelectedIndex = 9;
                                goto IL_2C0;
                            case 49:
                                break;
                            case 50:
                                cboClass.SelectedIndex = 10;
                                goto IL_2C0;
                            default:
                                switch (num2)
                                {
                                    case 64:
                                        cboClass.SelectedIndex = 11;
                                        goto IL_2C0;
                                    case 66:
                                        cboClass.SelectedIndex = 12;
                                        goto IL_2C0;
                                }
                                break;
                        }
                    }
                    else
                    {
                        switch (num2)
                        {
                            case 80:
                                cboClass.SelectedIndex = 13;
                                goto IL_2C0;
                            case 81:
                                cboClass.SelectedIndex = 14;
                                goto IL_2C0;
                            case 82:
                                break;
                            case 83:
                                cboClass.SelectedIndex = 15;
                                goto IL_2C0;
                            default:
                                switch (num2)
                                {
                                    case 96:
                                        cboClass.SelectedIndex = 16;
                                        goto IL_2C0;
                                    case 97:
                                        cboClass.SelectedIndex = 17;
                                        goto IL_2C0;
                                    case 98:
                                        cboClass.SelectedIndex = 17;
                                        goto IL_2C0;
                                }
                                break;
                        }
                    }
                    cboClass.SelectedIndex = 18;
                IL_2C0:
                    txtExp.Text = Convert.ToInt32(oleDbDataReader.GetValue(4)).ToString();
                    txtStrength.Text = Convert.ToString(oleDbDataReader.GetValue(5));
                    txtDexterity.Text = Convert.ToString(oleDbDataReader.GetValue(6));
                    txtVitality.Text = Convert.ToString(oleDbDataReader.GetValue(7));
                    txtEnergy.Text = Convert.ToString(oleDbDataReader.GetValue(8));
                    txtMoney.Text = Convert.ToString(oleDbDataReader.GetValue(9));
                    int num3 = 0;
                    if (oleDbDataReader.GetValue(10) != DBNull.Value)
                    {
                        num3 = Convert.ToInt32(oleDbDataReader.GetValue(10));
                    }
                    if (num3 < cboMap.Items.Count)
                    {
                        cboMap.SelectedIndex = num3;
                    }
                    txtPosX.Text = Convert.ToString(oleDbDataReader.GetValue(11));
                    txtPosY.Text = Convert.ToString(oleDbDataReader.GetValue(12));
                    Convert.ToInt32(oleDbDataReader.GetValue(13));
                    int selectedIndex = Convert.ToInt32(oleDbDataReader.GetValue(14));
                    cboPK.SelectedIndex = selectedIndex;
                    int @byte = (int)oleDbDataReader.GetByte(15);
                    int num4 = @byte;
                    switch (num4)
                    {
                        case 0:
                            cboCode.SelectedIndex = 0;
                            break;
                        case 1:
                            cboCode.SelectedIndex = 1;
                            break;
                        case 2:
                            cboCode.SelectedIndex = 2;
                            break;
                        case 3:
                        case 5:
                        case 6:
                        case 7:
                            break;
                        case 4:
                            cboCode.SelectedIndex = 3;
                            break;
                        case 8:
                            cboCode.SelectedIndex = 4;
                            break;
                        default:
                            if (num4 != 16)
                            {
                                if (num4 == 32)
                                {
                                    cboCode.SelectedIndex = 6;
                                }
                            }
                            else
                            {
                                cboCode.SelectedIndex = 5;
                            }
                            break;
                    }
                    txtLeaderShip.Text = Convert.ToString(oleDbDataReader.GetValue(16));
                    ExtendedInvenCount = Convert.ToString(oleDbDataReader.GetValue(17));
                    if (ExtendedInvenCount == "1")
                    {
                        chkPackageExp.Checked = true;
                        PackageExpLv1.Checked = true;
                        PackageExpLv2.Checked = false;
                    }
                    else if (ExtendedInvenCount == "2")
                    {
                        chkPackageExp.Checked = true;
                        PackageExpLv1.Checked = false;
                        PackageExpLv2.Checked = true;
                    }
                    else
                    {
                        chkPackageExp.Checked = false;
                        PackageExpLv1.Checked = false;
                        PackageExpLv2.Checked = false;
                    }
                    cmbChar.Text = charName;
                    loadMagic(cboClass.SelectedIndex);
                    pnlPackage.Enabled = true;
                    showGDI(true);
                }
                else
                {
                    Utils.WarningMessage("对不起，没有找到角色[" + charName + "]对应的信息！");
                    pnlPackage.Enabled = false;
                    clearGDI(true);
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

        private bool saveCharacter(string charName)
        {
            string text = null;
            charName = ((charName == null) ? "" : charName.Trim());
            if (charName == "")
            {
                return false;
            }
            if (isCharOnline())
            {
                Utils.WarningMessage(string.Format("当前角色{0}处于在线中，请先下线！", txtChar.Text.Trim()));
                return false;
            }
            try
            {
                int num = Convert.ToInt32(txtLevel.Text.Replace(" ", ""));
                int num2 = Convert.ToInt32(txtPoint.Text.Replace(" ", ""));
                int num3;
                switch (cboClass.SelectedIndex)
                {
                    case 0:
                        num3 = 0;
                        break;
                    case 1:
                        num3 = 1;
                        break;
                    case 2:
                        num3 = 3;
                        break;
                    case 3:
                        num3 = 16;
                        break;
                    case 4:
                        num3 = 17;
                        break;
                    case 5:
                        num3 = 19;
                        break;
                    case 6:
                        num3 = 32;
                        break;
                    case 7:
                        num3 = 33;
                        break;
                    case 8:
                        num3 = 35;
                        break;
                    case 9:
                        num3 = 48;
                        break;
                    case 10:
                        num3 = 50;
                        break;
                    case 11:
                        num3 = 64;
                        break;
                    case 12:
                        num3 = 66;
                        break;
                    case 13:
                        num3 = 80;
                        break;
                    case 14:
                        num3 = 81;
                        break;
                    case 15:
                        num3 = 83;
                        break;
                    case 16:
                        num3 = 96;
                        break;
                    case 17:
                        num3 = 98;
                        break;
                    default:
                        num3 = 99;
                        break;
                }
                string text2 = "0";
                switch (cboCode.SelectedIndex)
                {
                    case 0:
                        text2 = "0";
                        break;
                    case 1:
                        text2 = "1";
                        break;
                    case 2:
                        text2 = "2";
                        break;
                    case 3:
                        text2 = "4";
                        break;
                    case 4:
                        text2 = "8";
                        break;
                    case 5:
                        text2 = "16";
                        break;
                    case 6:
                        text2 = "32";
                        break;
                }
                int num4 = Convert.ToInt32(txtExp.Text.Replace(" ", ""));
                int num5 = Convert.ToInt32(txtStrength.Text.Replace(" ", ""));
                int num6 = Convert.ToInt32(txtDexterity.Text.Replace(" ", ""));
                int num7 = Convert.ToInt32(txtVitality.Text.Replace(" ", ""));
                int num8 = Convert.ToInt32(txtEnergy.Text.Replace(" ", ""));
                int selectedIndex = cboMap.SelectedIndex;
                int num9 = Convert.ToInt32(txtPosX.Text.Replace(" ", ""));
                int num10 = Convert.ToInt32(txtPosY.Text.Replace(" ", ""));
                int selectedIndex2 = cboPK.SelectedIndex;
                int num11 = Convert.ToInt32(txtLeaderShip.Text.Replace(" ", ""));
                StringBuilder stringBuilder = new StringBuilder("0x");
                string text3 = "";
                if (cbSaveJN.Checked)
                {
                    int num12 = 0;
                    for (int i = 0; i < clbCharacter.CheckedItems.Count; i++)
                    {
                        ComboBoxItem comboBoxItem = (ComboBoxItem)clbCharacter.CheckedItems[i];
                        stringBuilder.Append(comboBoxItem.Value);
                    }
                    for (int j = 0; j < Utils.lstSSG.Count; j++)
                    {
                        SKILL_SQL_GS skill_SQL_GS = Utils.lstSSG[j];
                        if (cboClass.SelectedIndex > 15)
                        {
                            if (!stringBuilder.ToString().Contains(Utils.SKILL_GS2SQL(skill_SQL_GS)) && skill_SQL_GS.GSSkillID > 269)
                            {
                                stringBuilder.Append(Utils.SKILL_GS2SQL(skill_SQL_GS));
                                num12++;
                            }
                        }
                        else if (!stringBuilder.ToString().Contains(Utils.SKILL_GS2SQL(skill_SQL_GS)) && skill_SQL_GS.GSSkillID > 255)
                        {
                            stringBuilder.Append(Utils.SKILL_GS2SQL(skill_SQL_GS));
                            num12++;
                        }
                    }
                    for (int k = clbCharacter.CheckedItems.Count + num12; k < 150; k++)
                    {
                        stringBuilder.Append("FF0000");
                    }
                    text3 = ", [MagicList] = " + stringBuilder.ToString();
                }
                text = string.Concat(new object[]
                {
                    "UPDATE [Character] SET [cLevel] = ",
                    num,
                    ", [LevelUpPoint] = ",
                    num2,
                    ", [Class] = ",
                    num3,
                    ", [Experience] = ",
                    num4,
                    ", [Strength] = ",
                    num5,
                    ", [Dexterity] = ",
                    num6,
                    ", [Vitality] = ",
                    num7,
                    ", [Energy] = ",
                    num8,
                    text3,
                    ", [MapNumber] = ",
                    selectedIndex,
                    ", [MapPosX] = ",
                    num9,
                    ", [MapPosY] = ",
                    num10,
                    ", [PkLevel] = ",
                    selectedIndex2,
                    ", [CtlCode] = ",
                    text2,
                    ", [Leadership] = ",
                    num11,
                    " WHERE ([Name] = '",
                    charName,
                    "')"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Mu_Conn);
                oleDbCommand.ExecuteNonQuery();
                Utils.InfoMessage("角色保存成功！");
                return true;
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
            return false;
        }

        private bool saveAccount(string account)
        {
            string text = null;
            try
            {
                account = ((account == null) ? "NULL" : ("'" + account.Trim() + "'"));
                string text2 = (txtPassword.Text.Trim() == "已加密") ? "已加密" : txtPassword.Text.Trim();
                if (text2 != "已加密")
                {
                    if (MD5)
                    {
                        text2 = string.Concat(new string[]
                        {
                            "[memb__pwd] = dbo.UFN_MD5_ENCODEVALUE('",
                            text2,
                            "', ",
                            account,
                            "), "
                        });
                        txtPassword.Text = "已加密";
                    }
                    else
                    {
                        text2 = "[memb__pwd] = '" + text2 + "', ";
                    }
                }
                else
                {
                    text2 = "";
                }
                string text3 = (txtSNO.Text.Trim() == "NULL") ? "NULL" : ("'" + txtSNO.Text.Trim() + "'");
                string text4 = (txtEMail.Text.Trim() == "NULL") ? "NULL" : ("'" + txtEMail.Text.Trim() + "'");
                string text5 = (txtQuestion.Text.Trim() == "NULL") ? "NULL" : ("'" + txtQuestion.Text.Trim() + "'");
                string text6 = (txtAnswer.Text.Trim() == "NULL") ? "NULL" : ("'" + txtAnswer.Text.Trim() + "'");
                string text7 = (txtNick.Text.Trim() == "NULL") ? "NULL" : ("'" + txtNick.Text.Trim() + "'");
                string text8;
                if (chkState.Checked)
                {
                    text8 = "'1'";
                }
                else
                {
                    text8 = "'0'";
                }
                string text9 = (Convert.ToInt32(txtServerCode.Text) < 1) ? "0" : Convert.ToString(Convert.ToInt32(txtServerCode.Text) - 1);
                text = string.Concat(new string[]
                {
                    "UPDATE [MEMB_INFO] SET ",
                    text2,
                    "[sno__numb] = ",
                    text3,
                    ", [memb_name] = ",
                    text7,
                    ", [mail_addr] = ",
                    text4,
                    ", [fpas_ques] = ",
                    text5,
                    ", [fpas_answ] = ",
                    text6,
                    ", [bloc_code] = ",
                    text8,
                    ", [area_code] = ",
                    text9,
                    " FROM [MEMB_INFO] WHERE ([memb___id] = ",
                    account,
                    ")"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                oleDbCommand.ExecuteNonQuery();
                Utils.InfoMessage("帐号保存成功！");
                return true;
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
            return false;
        }

        protected void updateUI()
        {
            btnWarehouse.Enabled = accountLogin;
            btnChar.Enabled = charLogin;
            btnMaster.Enabled = charLogin;
            if (ShownPackage)
            {
                showPackage(true);
            }
            if (ShownWarehouse)
            {
                showWarehouse(true);
            }
            if (ShownPackage || ShownWarehouse)
            {
                tabcInfo.SelectedIndex = 2;
            }
            if (charLogin)
            {
                charPanel.Prof = cboClass.SelectedIndex;
            }
            resizeWindow();
        }

        private void saveItem(string code, bool isChar)
        {
            string text = "INSERT INTO [ItemLog] ([Acc], [Name], [ItemCode], [SN], [iName], [iLvl], [iSkill], [iLuck], [iExt], [iSet], [i380], [iJh]) VALUES ('{0}', '{1}', 0x{2}, '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}');";
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                bool flag = false;
                if (isChar)
                {
                    for (int i = 0; i < Utils.ListPackage.Count; i++)
                    {
                        string text2 = Utils.ListPackage[i];
                        if (text2 != "" && text2 != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" && !stringBuilder.ToString().Contains(text2))
                        {
                            EquipItem equipItem = EquipItem.createItem(text2);
                            if (equipItem != null && equipItem.SN < 0)
                            {
                                stringBuilder.Append(string.Format(text, new object[]
                                {
                                    txtAcc.Text.Trim(),
                                    txtChar.Text.Trim(),
                                    text2,
                                    equipItem.SN,
                                    equipItem.Name,
                                    string.Concat(new object[]
                                    {
                                        "+",
                                        equipItem.Level,
                                        "z",
                                        equipItem.Ext * 4
                                    }),
                                    equipItem.JN ? 1 : 0,
                                    equipItem.XY ? 1 : 0,
                                    equipItem.Name,
                                    (equipItem.SetVal > 0) ? 1 : 0,
                                    equipItem.Is380 ? 1 : 0,
                                    0
                                }));
                                Utils.ListPackage[i] = "";
                                flag = true;
                            }
                        }
                    }
                }
                for (int j = 0; j < Utils.ListWareHouse.Count; j++)
                {
                    string text3 = Utils.ListWareHouse[j];
                    if (text3 != "" && text3 != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" && !stringBuilder.ToString().Contains(text3))
                    {
                        EquipItem equipItem2 = EquipItem.createItem(text3);
                        if (equipItem2 != null && equipItem2.SN < 0)
                        {
                            stringBuilder.Append(string.Format(text, new object[]
                            {
                                txtAcc.Text.Trim(),
                                txtChar.Text.Trim(),
                                text3,
                                equipItem2.SN,
                                equipItem2.Name,
                                string.Concat(new object[]
                                {
                                    "+",
                                    equipItem2.Level,
                                    "z",
                                    equipItem2.Ext
                                }),
                                equipItem2.JN ? 1 : 0,
                                equipItem2.XY ? 1 : 0,
                                equipItem2.Name,
                                (equipItem2.SetVal > 0) ? 1 : 0,
                                equipItem2.Is380 ? 1 : 0,
                                0
                            }));
                            Utils.ListWareHouse[j] = "";
                            flag = true;
                        }
                    }
                }
                if (flag)
                {
                    OleDbCommand oleDbCommand = new OleDbCommand(stringBuilder.ToString(), frmBase.Mu_Conn);
                    oleDbCommand.ExecuteNonQuery();
                }
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

        public bool saveInventory(string charName)
        {
            string text = "";
            try
            {
                if (charName == "" || !btnUpdatePackage.Enabled)
                {
                    return false;
                }
                if (isCharOnline())
                {
                    Utils.WarningMessage(string.Format("当前角色{0}处于在线中，请先下线！", txtChar.Text.Trim()));
                    return false;
                }
                packagePanel.DownItem();
                packagePanelLv1.DownItem();
                packagePanelLv2.DownItem();
                packagePanelLv3.DownItem();
                packagePanelLv4.DownItem();
                shopPanel.DownItem();
                string text2 = string.Concat(new string[]
                {
                    charPanel.getEquipCodes(),
                    packagePanel.getEquipCodes(),
                    packagePanelLv1.getEquipCodes(),
                    packagePanelLv2.getEquipCodes(),
                    packagePanelLv3.getEquipCodes(),
                    packagePanelLv4.getEquipCodes(),
                    shopPanel.getEquipCodes()
                });
                int num = Convert.ToInt32(txtMoney.Text.Replace(" ", ""));
                saveItem(text2, true);
                text = string.Format("UPDATE [Character] SET [Inventory] = 0x{0}, [Money] = {1}, [ExtendedInvenCount] = {2} WHERE ([Name] = '{3}')", new object[]
                {
                    text2,
                    num,
                    ExtendedInvenCount,
                    charName
                });
                return frmBase.Mu_ExecuteSQL(text);
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
            return false;
        }

        public bool saveAddInventory(string charName)
        {
            string text = "";
            try
            {
                if (charName == "" || !btnUpdatePackage.Enabled)
                {
                    return false;
                }
                if (isCharOnline())
                {
                    Utils.WarningMessage(string.Format("当前角色{0}处于在线中，请先下线！", txtChar.Text.Trim()));
                    return false;
                }
                string equipCodes = sPentagramPanel.getEquipCodes();
                Convert.ToInt32(txtMoney.Text.Replace(" ", ""));
                saveItem(equipCodes, true);
                text = string.Format("UPDATE [T_Pentagram] SET [AddInventory] = 0x{0} WHERE ([Name] = '{1}')", equipCodes, charName);
                return frmBase.Mu_ExecuteSQL(text);
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
            return false;
        }

        public bool saveWarehouse(string account)
        {
            string text = "";
            try
            {
                if (account == "" || !btnUpdateWarehouse.Enabled)
                {
                    return false;
                }
                int num = Convert.ToInt32(txtWareHouseMoney.Text.Replace(" ", ""));
                int num2 = Convert.ToInt32(txtWareHousePwd.Text.Replace(" ", ""));
                warehousePanel.DownItem();
                warehousePanelLv1.DownItem();
                string text2 = warehousePanel.getEquipCodes() + warehousePanelLv1.getEquipCodes();
                saveItem(text2, false);
                text = "SELECT [Items] FROM [T_WareHouseInfo] WHERE ([AccountID] = '" + account + "')";
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Mu_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                string arg;
                if (WarehouseExp.Checked)
                {
                    arg = "1";
                }
                else
                {
                    arg = "0";
                }
                text = string.Format("UPDATE [AccountCharacter] SET [ExtendedWarehouseCount] = {0} WHERE ([Id] = '{1}')", arg, account);
                frmBase.Mu_ExecuteSQL(text);
                if (!oleDbDataReader.Read())
                {
                    text = string.Format("INSERT INTO [T_WareHouseInfo] ([AccountID], [Items], [Money], [DbVersion], [pw]) VALUES ('{0}', 0x{1}, {2}, {3}, {4})", new object[]
                    {
                        account,
                        text2,
                        num,
                        3,
                        num2
                    });
                    return frmBase.Mu_ExecuteSQL(text);
                }
                if (isOnline())
                {
                    byte[] array = null;
                    if (oleDbDataReader.GetValue(0) != DBNull.Value)
                    {
                        array = (byte[])oleDbDataReader.GetValue(0);
                    }
                    EquipPanel equipPanel = new EquipPanel();
                    equipPanel.setSize(8, 15);
                    equipPanel.loadItemsByCodes(array, 0, array.Length);
                    EquipPanel equipPanel2 = new EquipPanel();
                    equipPanel2.setSize(8, 15);
                    equipPanel2.loadItemsByCodes(array, 3840, array.Length);
                    if (wareHouseCode != equipPanel.getEquipCodes() || wareHouseLv1Code != equipPanel2.getEquipCodes())
                    {
                        if (MessageBox.Show("当前仓库已被玩家在游戏中改变，是否继续保存？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            text = string.Format("UPDATE [T_WareHouseInfo] SET [Items] = 0x{0}, [Money] = {1}, [pw] = {2} WHERE ([AccountID] = '{3}')", new object[]
                            {
                                text2,
                                num,
                                num2,
                                account
                            });
                            return frmBase.Mu_ExecuteSQL(text);
                        }
                        return false;
                    }
                }
                text = string.Format("UPDATE [T_WareHouseInfo] SET [Items] = 0x{0}, [Money] = {1}, [pw] = {2} WHERE ([AccountID] = '{3}')", new object[]
                {
                    text2,
                    num,
                    num2,
                    account
                });
                return frmBase.Mu_ExecuteSQL(text);
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
            return false;
        }

        protected byte[] loadInventory(string charName)
        {
            string text = null;
            if (charName == "")
            {
                return null;
            }
            byte[] result = null;
            try
            {
                text = "SELECT [Inventory] FROM [Character] WHERE ([Name] = '" + charName + "')";
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Mu_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read() && oleDbDataReader.GetValue(0) != DBNull.Value)
                {
                    result = (byte[])oleDbDataReader.GetValue(0);
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
            return result;
        }

        protected byte[] loadAddInventory(string charName)
        {
            string text = null;
            if (charName == "")
            {
                return null;
            }
            byte[] result = null;
            try
            {
                text = "SELECT [AddInventory] FROM [T_Pentagram] WHERE ([Name] = '" + charName + "')";
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Mu_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read() && oleDbDataReader.GetValue(0) != DBNull.Value)
                {
                    result = (byte[])oleDbDataReader.GetValue(0);
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
            return result;
        }

        protected byte[] loadWarehouse(string account)
        {
            string text = null;
            if (account == "")
            {
                return null;
            }
            byte[] result = null;
            try
            {
                text = "SELECT [Items], [Money], [pw] FROM [T_WareHouseInfo] WHERE ([AccountID] = '" + account + "')";
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Mu_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read() && oleDbDataReader.GetValue(0) != DBNull.Value)
                {
                    result = (byte[])oleDbDataReader.GetValue(0);
                    txtWareHouseMoney.Text = Convert.ToString(oleDbDataReader.GetValue(1));
                    txtWareHousePwd.Text = Convert.ToString(oleDbDataReader.GetValue(2));
                }
                else
                {
                    txtWareHouseMoney.Text = "0";
                    txtWareHousePwd.Text = "0";
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
            return result;
        }

        private void ExitEditor_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void resizeWindow()
        {
            if (!pnlWarehouse.Visible && !pnlPackage.Visible)
            {
                base.Width = 239;
                return;
            }
            if (pnlWarehouse.Visible && pnlPackage.Visible)
            {
                base.Width = 1256;
                pnlWarehouse.Left = 233;
                pnlPackage.Left = 656;
                return;
            }
            if (pnlPackage.Visible)
            {
                base.Width = 834;
                pnlPackage.Left = 233;
                return;
            }
            base.Width = 662;
            pnlWarehouse.Left = 233;
        }

        private void cmbChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            saveLast(true);
            showCharacter(cmbChar.Text);
            LoadedPackage = false;
            if (ShownPackage)
            {
                showPackage(true);
            }
            Cursor = Cursors.Default;
        }

        private void btnUpdateChar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string charName = txtChar.Text.Trim();
            saveCharacter(charName);
            cmbChar_SelectedIndexChanged(sender, e);
            Cursor = Cursors.Default;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                frmBase.Mu_Conn.Close();
                frmBase.Me_Conn.Close();
            }
            catch (Exception)
            {
            }
        }

        private void showPackageItems()
        {
            string text = txtChar.Text.Trim();
            if (text == "")
            {
                return;
            }
            byte[] array = loadInventory(text);
            byte[] array2 = loadAddInventory(text);
            if (array != null)
            {
                LoadedPackage = true;
                charPanel.clearData();
                int num = 192;
                if (!charPanel.loadItemsByCodes(array, 0, 192))
                {
                    Utils.WarningMessage(string.Format("加载角色[{0}]身上的装备失败，可能数据格式不正确！", text));
                    LoadedPackage = false;
                }
                packagePanel.clearData();
                if (!packagePanel.loadItemsByCodes(array, num, array.Length - num))
                {
                    Utils.WarningMessage(string.Format("加载角色[{0}]包裹里的装备失败，可能数据格式不正确！", text));
                    LoadedPackage = false;
                }
                packagePanelLv1.clearData();
                num += packagePanel.XNum * packagePanel.YNum * 16;
                if (!packagePanelLv1.loadItemsByCodes(array, num, array.Length - num))
                {
                    Utils.WarningMessage(string.Format("加载角色[{0}]扩展包裹Lv1里的装备失败，可能数据格式不正确！", text));
                    LoadedPackage = false;
                }
                packagePanelLv2.clearData();
                num += packagePanelLv1.XNum * packagePanelLv1.YNum * 16;
                if (!packagePanelLv2.loadItemsByCodes(array, num, array.Length - num))
                {
                    Utils.WarningMessage(string.Format("加载角色[{0}]扩展包裹Lv2里的装备失败，可能数据格式不正确！", text));
                    LoadedPackage = false;
                }
                packagePanelLv3.clearData();
                num += packagePanelLv2.XNum * packagePanelLv2.YNum * 16;
                if (!packagePanelLv3.loadItemsByCodes(array, num, array.Length - num))
                {
                    Utils.WarningMessage(string.Format("加载角色[{0}]扩展包裹Lv3里的装备失败，可能数据格式不正确！", text));
                    LoadedPackage = false;
                }
                packagePanelLv4.clearData();
                num += packagePanelLv3.XNum * packagePanelLv3.YNum * 16;
                if (!packagePanelLv4.loadItemsByCodes(array, num, array.Length - num))
                {
                    Utils.WarningMessage(string.Format("加载角色[{0}]扩展包裹Lv4里的装备失败，可能数据格式不正确！", text));
                    LoadedPackage = false;
                }
                shopPanel.clearData();
                num += packagePanelLv4.XNum * packagePanelLv4.YNum * 16;
                if (!shopPanel.loadItemsByCodes(array, num, array.Length - num))
                {
                    Utils.WarningMessage(string.Format("加载角色[{0}]商店里的装备失败，可能数据格式不正确！", text));
                    LoadedPackage = false;
                }
                sPentagramPanel.clearData();
                if (array2 == null || array2.Length < 16)
                {
                    return;
                }
                if (!sPentagramPanel.loadItemsByCodes(array2, 0, array2.Length))
                {
                    Utils.WarningMessage(string.Format("加载角色[{0}]技能书栏的装备失败，可能数据格式不正确！", text));
                    LoadedPackage = false;
                }
            }
        }

        private void showWarehouseItems()
        {
            string text = txtAcc.Text.Trim();
            if (text == "")
            {
                return;
            }
            byte[] array = loadWarehouse(text);
            if (array != null)
            {
                LoadedWarehouse = true;
                warehousePanel.clearData();
                if (!warehousePanel.loadItemsByCodes(array, 0, array.Length / 2))
                {
                    Utils.WarningMessage(string.Format("加载帐号[{0}]仓库里的装备失败，可能数据格式不正确！", text));
                    LoadedWarehouse = false;
                }
                warehousePanelLv1.clearData();
                if (!warehousePanelLv1.loadItemsByCodes(array, array.Length / 2, array.Length / 2))
                {
                    Utils.WarningMessage(string.Format("加载帐号[{0}]仓库Lv1里的装备失败，可能数据格式不正确！", text));
                    LoadedWarehouse = false;
                    return;
                }
            }
            else
            {
                LoadedWarehouse = true;
                warehousePanel.clearData();
                warehousePanel.loadItemsByCodes(array, 0, 0);
                warehousePanelLv1.clearData();
                warehousePanelLv1.loadItemsByCodes(array, 3840, 0);
            }
        }

        protected void showPackage(bool flag)
        {
            if (flag)
            {
                tabcInfo.SelectedIndex = 2;
                if (!LoadedPackage)
                {
                    showPackageItems();
                }
            }
            else
            {
                tabcInfo.SelectedIndex = 1;
            }
            pnlPackage.Visible = flag;
            resizeWindow();
            ShownPackage = flag;
        }

        protected void showWarehouse(bool flag)
        {
            if (flag)
            {
                tabcInfo.SelectedIndex = 2;
                if (!LoadedWarehouse)
                {
                    showWarehouseItems();
                }
            }
            else
            {
                tabcInfo.SelectedIndex = 0;
            }
            pnlWarehouse.Visible = flag;
            resizeWindow();
            ShownWarehouse = flag;
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            showPackage(!ShownPackage);
            Cursor = Cursors.Default;
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            showWarehouse(!ShownWarehouse);
            Cursor = Cursors.Default;
        }

        private void btnUpdateWarehouse_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string account = txtAcc.Text.Trim();
            if (saveWarehouse(account))
            {
                Utils.InfoMessage("仓库保存成功！");
                wareHouseCode = warehousePanel.getEquipCodes();
                wareHouseLv1Code = warehousePanelLv1.getEquipCodes();
            }
            else
            {
                Utils.WarningMessage("仓库保存失败！");
            }
            Cursor = Cursors.Default;
        }

        private void btnUpdatePackage_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string charName = txtChar.Text.Trim();
            if (saveInventory(charName) && saveAddInventory(charName))
            {
                Utils.InfoMessage("包裹保存成功！");
                charPanelCode = charPanel.getEquipCodes();
                packagePanelCode = packagePanel.getEquipCodes();
                packagePanelLv1Code = packagePanelLv1.getEquipCodes();
                packagePanelLv2Code = packagePanelLv2.getEquipCodes();
                packagePanelLv3Code = packagePanelLv3.getEquipCodes();
                packagePanelLv4Code = packagePanelLv4.getEquipCodes();
                shopPanelCode = shopPanel.getEquipCodes();
                sPentagramPanelCode = sPentagramPanel.getEquipCodes();
            }
            else
            {
                Utils.WarningMessage("包裹保存失败！");
            }
            Cursor = Cursors.Default;
        }

        private void btnClearPackage_Click(object sender, EventArgs e)
        {
            packagePanel.clearData();
            packagePanel.Invalidate();
            packagePanelLv1.clearData();
            packagePanelLv1.Invalidate();
            packagePanelLv2.clearData();
            packagePanelLv2.Invalidate();
            packagePanelLv3.clearData();
            packagePanelLv3.Invalidate();
            packagePanelLv4.clearData();
            packagePanelLv4.Invalidate();
        }

        private void btnClearWarehouse_Click(object sender, EventArgs e)
        {
            warehousePanel.clearData();
            warehousePanel.Invalidate();
            warehousePanelLv1.clearData();
            warehousePanelLv1.Invalidate();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveLast(false);
        }

        private void CharacterManager_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FrmUser = frmUser.GetInstance(this, "");
            FrmUser.Visible = false;
            FrmUser.Show(this);
            setManagerFrm();
            Cursor = Cursors.Default;
        }

        private void loadMagic(int type)
        {
            clbCharacter.Items.Clear();
            type = ((type < 0) ? 0 : type);
            try
            {
                string cmdText = string.Format("SELECT [MagicList] FROM [Character] WHERE ([AccountID] = '{0}') AND ([Name] = '{1}')", txtAcc.Text.Trim(), txtChar.Text.Trim());
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, frmBase.Mu_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                byte[] array = new byte[3];
                string text = "";
                Utils.lstSSG.Clear();
                if (oleDbDataReader.Read() && oleDbDataReader.GetValue(0) != DBNull.Value)
                {
                    byte[] array2 = (byte[])oleDbDataReader.GetValue(0);
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < array2.Length; i++)
                    {
                        array[i % 3] = array2[i];
                        if (i % 3 == 2)
                        {
                            SKILL_SQL_GS skill_SQL_GS = Utils.SKILL_SQL2GS(array);
                            Utils.lstSSG.Add(skill_SQL_GS);
                            if (cboClass.SelectedIndex > 15)
                            {
                                if ((skill_SQL_GS.GSSkillID > 0 && skill_SQL_GS.GSSkillID < 255) || (skill_SQL_GS.GSSkillID > 258 && skill_SQL_GS.GSSkillID < 269))
                                {
                                    stringBuilder.Append("," + Utils.SKILL_GS2SQL(skill_SQL_GS));
                                }
                            }
                            else if (skill_SQL_GS.GSSkillID > 0 && skill_SQL_GS.GSSkillID < 255)
                            {
                                stringBuilder.Append("," + Utils.SKILL_GS2SQL(skill_SQL_GS));
                            }
                        }
                    }
                    text = stringBuilder.ToString();
                }
                oleDbDataReader.Close();
                for (int j = 0; j < frmMain.xMagic.Length; j++)
                {
                    if (frmMain.xMagic[j] != null && frmMain.xMagic[j].Name[0] != 0)
                    {
                        string value = Utils.SKILL_GS2SQL(new SKILL_SQL_GS
                        {
                            SKillLv = 0,
                            GSSkillID = frmMain.xMagic[j].m_Number
                        });
                        switch (type)
                        {
                            case 0:
                                if (frmMain.xMagic[j].iClassNumber.WIZARD == 1)
                                {
                                    bool isChecked = false;
                                    foreach (string text2 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text2 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS2 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text2));
                                            if (skill_SQL_GS2.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text2;
                                                isChecked = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked);
                                }
                                break;
                            case 1:
                                if (frmMain.xMagic[j].iClassNumber.WIZARD != 0)
                                {
                                    bool isChecked2 = false;
                                    foreach (string text3 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text3 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS3 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text3));
                                            if (skill_SQL_GS3.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text3;
                                                isChecked2 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked2);
                                }
                                break;
                            case 2:
                                if (frmMain.xMagic[j].iClassNumber.WIZARD != 0)
                                {
                                    bool isChecked3 = false;
                                    foreach (string text4 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text4 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS4 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text4));
                                            if (skill_SQL_GS4.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text4;
                                                isChecked3 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked3);
                                }
                                break;
                            case 3:
                                if (frmMain.xMagic[j].iClassNumber.KNIGHT == 1)
                                {
                                    bool isChecked4 = false;
                                    foreach (string text5 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text5 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS5 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text5));
                                            if (skill_SQL_GS5.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text5;
                                                isChecked4 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked4);
                                }
                                break;
                            case 4:
                                if (frmMain.xMagic[j].iClassNumber.KNIGHT != 0)
                                {
                                    bool isChecked5 = false;
                                    foreach (string text6 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text6 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS6 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text6));
                                            if (skill_SQL_GS6.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text6;
                                                isChecked5 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked5);
                                }
                                break;
                            case 5:
                                if (frmMain.xMagic[j].iClassNumber.KNIGHT != 0)
                                {
                                    bool isChecked6 = false;
                                    foreach (string text7 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text7 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS7 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text7));
                                            if (skill_SQL_GS7.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text7;
                                                isChecked6 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked6);
                                }
                                break;
                            case 6:
                                if (frmMain.xMagic[j].iClassNumber.ELF == 1)
                                {
                                    bool isChecked7 = false;
                                    foreach (string text8 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text8 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS8 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text8));
                                            if (skill_SQL_GS8.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text8;
                                                isChecked7 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked7);
                                }
                                break;
                            case 7:
                                if (frmMain.xMagic[j].iClassNumber.ELF != 0)
                                {
                                    bool isChecked8 = false;
                                    foreach (string text9 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text9 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS9 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text9));
                                            if (skill_SQL_GS9.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text9;
                                                isChecked8 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked8);
                                }
                                break;
                            case 8:
                                if (frmMain.xMagic[j].iClassNumber.ELF != 0)
                                {
                                    bool isChecked9 = false;
                                    foreach (string text10 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text10 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS10 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text10));
                                            if (skill_SQL_GS10.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text10;
                                                isChecked9 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked9);
                                }
                                break;
                            case 9:
                                if (frmMain.xMagic[j].iClassNumber.MAGUMSA != 0)
                                {
                                    bool isChecked10 = false;
                                    foreach (string text11 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text11 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS11 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text11));
                                            if (skill_SQL_GS11.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text11;
                                                isChecked10 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked10);
                                }
                                break;
                            case 10:
                                if (frmMain.xMagic[j].iClassNumber.MAGUMSA != 0)
                                {
                                    bool isChecked11 = false;
                                    foreach (string text12 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text12 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS12 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text12));
                                            if (skill_SQL_GS12.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text12;
                                                isChecked11 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked11);
                                }
                                break;
                            case 11:
                                if (frmMain.xMagic[j].iClassNumber.DARKLORD != 0)
                                {
                                    bool isChecked12 = false;
                                    foreach (string text13 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text13 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS13 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text13));
                                            if (skill_SQL_GS13.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text13;
                                                isChecked12 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked12);
                                }
                                break;
                            case 12:
                                if (frmMain.xMagic[j].iClassNumber.DARKLORD != 0)
                                {
                                    bool isChecked13 = false;
                                    foreach (string text14 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text14 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS14 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text14));
                                            if (skill_SQL_GS14.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text14;
                                                isChecked13 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked13);
                                }
                                break;
                            case 13:
                                if (frmMain.xMagic[j].iClassNumber.SUMMONER != 0)
                                {
                                    bool isChecked14 = false;
                                    foreach (string text15 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text15 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS15 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text15));
                                            if (skill_SQL_GS15.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text15;
                                                isChecked14 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked14);
                                }
                                break;
                            case 14:
                                if (frmMain.xMagic[j].iClassNumber.SUMMONER != 0)
                                {
                                    bool isChecked15 = false;
                                    foreach (string text16 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text16 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS16 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text16));
                                            if (skill_SQL_GS16.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text16;
                                                isChecked15 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked15);
                                }
                                break;
                            case 15:
                                if (frmMain.xMagic[j].iClassNumber.SUMMONER != 0)
                                {
                                    bool isChecked16 = false;
                                    foreach (string text17 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text17 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS17 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text17));
                                            if (skill_SQL_GS17.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text17;
                                                isChecked16 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked16);
                                }
                                break;
                            case 16:
                                if (frmMain.xMagic[j].iClassNumber.MONK != 0)
                                {
                                    bool isChecked17 = false;
                                    foreach (string text18 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text18 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS18 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text18));
                                            if (skill_SQL_GS18.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text18;
                                                isChecked17 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked17);
                                }
                                break;
                            case 17:
                                if (frmMain.xMagic[j].iClassNumber.MONK != 0)
                                {
                                    bool isChecked18 = false;
                                    foreach (string text19 in text.Split(new char[]
                                    {
                                    ','
                                    }))
                                    {
                                        if (!(text19 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS19 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text19));
                                            if (skill_SQL_GS19.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text19;
                                                isChecked18 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked18);
                                }
                                break;
                            default:
                                {
                                    bool isChecked19 = false;
                                    foreach (string text20 in text.Split(new char[]
                                    {
                                ','
                                    }))
                                    {
                                        if (!(text20 == ""))
                                        {
                                            SKILL_SQL_GS skill_SQL_GS20 = Utils.SKILL_SQL2GS(Utils.StringToBytes(text20));
                                            if (skill_SQL_GS20.GSSkillID == frmMain.xMagic[j].m_Number)
                                            {
                                                value = text20;
                                                isChecked19 = true;
                                            }
                                        }
                                    }
                                    clbCharacter.Items.Add(new ComboBoxItem(frmMain.ByteToString(frmMain.xMagic[j].Name, 32), value), isChecked19);
                                    break;
                                }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "loadMagic：\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMagic(cboClass.SelectedIndex);
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (isCharOnline())
            {
                Cursor = Cursors.Default;
                Utils.WarningMessage(string.Format("当前角色{0}处于在线中！", txtChar.Text.Trim()));
            }
            frmMasterLevel frmMasterLevel = new frmMasterLevel(txtChar.Text.Trim());
            frmMasterLevel.ShowDialog();
            Cursor = Cursors.Default;
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbCharacter.Items.Count; i++)
            {
                clbCharacter.SetItemChecked(i, cbAll.Checked);
            }
        }

        private void btnMaxMoney_Click(object sender, EventArgs e)
        {
            txtMoney.Text = "2147483647";
        }

        private void btn1YMoney_Click(object sender, EventArgs e)
        {
            txtMoney.Text = "100000000";
        }

        private void btnWareMaxMoney_Click(object sender, EventArgs e)
        {
            txtWareHouseMoney.Text = "2147483647";
        }

        private void btnWare1YMoney_Click(object sender, EventArgs e)
        {
            txtWareHouseMoney.Text = "100000000";
        }

        private void OnlineStat_Click(object sender, EventArgs e)
        {
            string msg = "未查询到任何消息";
            string text = "";
            try
            {
                Cursor = Cursors.WaitCursor;
                text = string.Concat(new string[]
                {
                    "SELECT TOP 1 (SELECT COUNT(1) FROM [MEMB_INFO]) AS [a], (SELECT COUNT(1) FROM [",
                    frmMain.MU_SERVER,
                    "].[",
                    frmMain.MU_DB,
                    "].[dbo].[Character]) AS [b], (SELECT COUNT(1) FROM [MEMB_STAT] WHERE ([ConnectStat] = 1)) AS [c] FROM [dbo].[MEMB_INFO]"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Me_Conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    msg = string.Format("帐号共{0}个，角色共{1}个，{2}人在线！", oleDbDataReader.GetValue(0), oleDbDataReader.GetValue(1), oleDbDataReader.GetValue(2));
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
            Cursor = Cursors.Default;
            Utils.InfoMessage(msg);
        }

        private void setManagerFrm()
        {
            if (!pnlWarehouse.Visible && !pnlPackage.Visible)
            {
                if (FrmUser != null)
                {
                    FrmUser.Top = base.Top;
                    FrmUser.Left = base.Left + base.Width;
                }
                if (FrmGuild != null)
                {
                    FrmGuild.Top = base.Top;
                    FrmGuild.Left = base.Left + base.Width;
                }
                if (FrmEquip != null)
                {
                    FrmEquip.Top = base.Top;
                    FrmEquip.Left = base.Left + base.Width;
                }
            }
            else
            {
                if (FrmUser != null)
                {
                    FrmUser.Top = base.Top + base.Height / 2 - FrmUser.Height / 2;
                    FrmUser.Left = base.Left + base.Width / 2 - FrmUser.Width / 2;
                }
                if (FrmGuild != null)
                {
                    FrmGuild.Top = base.Top + base.Height / 2 - FrmGuild.Height / 2;
                    FrmGuild.Left = base.Left + base.Width / 2 - FrmGuild.Width / 2;
                }
                if (FrmEquip != null)
                {
                    FrmEquip.Top = base.Top + base.Height / 2 - FrmEquip.Height / 2;
                    FrmEquip.Left = base.Left + base.Width / 2 - FrmEquip.Width / 2;
                    return;
                }
            }
        }

        private void btnSearchIP_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FrmUser = frmUser.GetInstance(this, lblIP.Text);
            FrmUser.Visible = false;
            FrmUser.Show(this);
            setManagerFrm();
            Cursor = Cursors.Default;
        }

        private void GuildManager_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FrmGuild = frmGuild.GetInstance(this);
            FrmGuild.Visible = false;
            FrmGuild.Show(this);
            setManagerFrm();
            Cursor = Cursors.Default;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            warehousePanel.DownItem();
            EquipItem[] equipItems = warehousePanel.getEquipItems();
            warehousePanel.clearData();
            warehousePanel.putItems(equipItems, true);
            warehousePanel.Invalidate();
        }

        private void btnClearChar_Click(object sender, EventArgs e)
        {
            charPanel.clearData();
            charPanel.Invalidate();
        }

        private void btnCleanPackage_Click(object sender, EventArgs e)
        {
            packagePanel.DownItem();
            shopPanel.DownItem();
            EquipItem[] equipItems = packagePanel.getEquipItems();
            packagePanel.clearData();
            packagePanel.putItems(equipItems, true);
            packagePanel.Invalidate();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtLevel.Text.Trim());
            if (num <= 255)
            {
                txtExp.Text = string.Concat((num + 9) * num * num * 10);
                return;
            }
            if (num > 255)
            {
                txtExp.Text = string.Concat((num - 255 + 9) * (num - 255) * (num - 255) * 1000 + (num + 9) * num * num * 10);
                return;
            }
            if (num > 400)
            {
                txtExp.Text = "0";
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\使用说明.doc"))
            {
                Process.Start(Application.StartupPath + "\\使用说明.doc");
                return;
            }
            Utils.WarningMessage("找不到帮助文件！");
        }

        private void About_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog(this);
        }

        private void AddAccountID_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmUserAdd instance = frmUserAdd.GetInstance();
            instance.ShowDialog(this);
            Cursor = Cursors.Default;
        }

        private void chkPackageExp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPackageExp.Checked)
            {
                PackageExpLv1.Enabled = true;
                PackageExpLv2.Enabled = true;
                return;
            }
            ExtendedInvenCount = "0";
            PackageExpLv1.Enabled = false;
            PackageExpLv2.Enabled = false;
            PackageExpLv1.Checked = false;
            PackageExpLv2.Checked = false;
        }

        private void PackageExpLv1_CheckedChanged(object sender, EventArgs e)
        {
            if (PackageExpLv1.Checked)
            {
                ExtendedInvenCount = "1";
            }
        }

        private void PackageExpLv2_CheckedChanged(object sender, EventArgs e)
        {
            if (PackageExpLv2.Checked)
            {
                ExtendedInvenCount = "2";
            }
        }

        private void CashShopPoint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            T_CashShop = new T_CashShop_Point();
            T_CashShop.Visible = false;
            T_CashShop.Show(this);
            Cursor = Cursors.Default;
        }
    }
}