namespace MuEditor
{
	// Token: 0x0200000A RID: 10
	public partial class frmMain// : global::MuEditor.frmBase
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000023A1 File Offset: 0x000005A1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00007A4C File Offset: 0x00005C4C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MuEditor.frmMain));
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.SYSTEM_MenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AddAccountID = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CharacterManager = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.CashShopPoint = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.GuildManager = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.OnlineStat = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ExitEditor = new global::System.Windows.Forms.ToolStripMenuItem();
			this.HELP_MenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Help = new global::System.Windows.Forms.ToolStripMenuItem();
			this.About = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cbAll = new global::System.Windows.Forms.CheckBox();
			this.tabPage4 = new global::System.Windows.Forms.TabPage();
			this.cbSaveJN = new global::System.Windows.Forms.CheckBox();
			this.btnExp = new global::System.Windows.Forms.Button();
			this.btnMaster = new global::System.Windows.Forms.Button();
			this.label29 = new global::System.Windows.Forms.Label();
			this.clbCharacter = new global::System.Windows.Forms.CheckedListBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.txtLeaderShip = new global::MuEditor.TextBox();
			this.laName = new global::System.Windows.Forms.Label();
			this.txtChar = new global::MuEditor.TextBox();
			this.cboClass = new global::System.Windows.Forms.ComboBox();
			this.txtLevel = new global::MuEditor.TextBox();
			this.txtPoint = new global::MuEditor.TextBox();
			this.txtExp = new global::MuEditor.TextBox();
			this.txtStrength = new global::MuEditor.TextBox();
			this.txtDexterity = new global::MuEditor.TextBox();
			this.txtEnergy = new global::MuEditor.TextBox();
			this.txtVitality = new global::MuEditor.TextBox();
			this.cboPK = new global::System.Windows.Forms.ComboBox();
			this.cboCode = new global::System.Windows.Forms.ComboBox();
			this.txtPosY = new global::MuEditor.TextBox();
			this.txtPosX = new global::MuEditor.TextBox();
			this.cboMap = new global::System.Windows.Forms.ComboBox();
			this.btnUpdateChar = new global::System.Windows.Forms.Button();
			this.label24 = new global::System.Windows.Forms.Label();
			this.label23 = new global::System.Windows.Forms.Label();
			this.label22 = new global::System.Windows.Forms.Label();
			this.label21 = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label18 = new global::System.Windows.Forms.Label();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.txtServerCode = new global::MuEditor.TextBox();
			this.label37 = new global::System.Windows.Forms.Label();
			this.txtNick = new global::MuEditor.TextBox();
			this.label32 = new global::System.Windows.Forms.Label();
			this.txtJF = new global::MuEditor.TextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.btnAccount = new global::System.Windows.Forms.Button();
			this.chkState = new global::System.Windows.Forms.CheckBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.txtSNO = new global::MuEditor.TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.txtAnswer = new global::MuEditor.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.txtQuestion = new global::MuEditor.TextBox();
			this.txtEMail = new global::MuEditor.TextBox();
			this.txtPassword = new global::MuEditor.TextBox();
			this.txtAcc = new global::MuEditor.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.label35 = new global::System.Windows.Forms.Label();
			this.label34 = new global::System.Windows.Forms.Label();
			this.btnSearchIP = new global::System.Windows.Forms.Button();
			this.lblIP = new global::System.Windows.Forms.Label();
			this.lblOnlineHours = new global::System.Windows.Forms.Label();
			this.lblDisConnectTime = new global::System.Windows.Forms.Label();
			this.lblConnectTime = new global::System.Windows.Forms.Label();
			this.label36 = new global::System.Windows.Forms.Label();
			this.lblState = new global::System.Windows.Forms.Label();
			this.lblServer = new global::System.Windows.Forms.Label();
			this.tabPage5 = new global::System.Windows.Forms.TabPage();
			this.equipEditor = new global::MuEditor.EquipEditor();
			this.tabcInfo = new global::System.Windows.Forms.TabControl();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnChar = new global::System.Windows.Forms.Button();
			this.btnWarehouse = new global::System.Windows.Forms.Button();
			this.txtAccount = new global::System.Windows.Forms.ComboBox();
			this.cmbChar = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pnlPackage = new global::System.Windows.Forms.Panel();
			this.packageExp = new global::System.Windows.Forms.GroupBox();
			this.PackageExpLv2 = new global::System.Windows.Forms.RadioButton();
			this.PackageExpLv1 = new global::System.Windows.Forms.RadioButton();
			this.chkPackageExp = new global::System.Windows.Forms.CheckBox();
			this.btnUpdatePackage = new global::System.Windows.Forms.Button();
			this.btnClearPackage = new global::System.Windows.Forms.Button();
			this.btnClearChar = new global::System.Windows.Forms.Button();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.shopPanel = new global::MuEditor.EquipPanel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.packagePanelLv4 = new global::MuEditor.EquipPanel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.packagePanelLv3 = new global::MuEditor.EquipPanel();
			this.sPentagramPanel = new global::MuEditor.PentagramPanel();
			this.btnCleanPackage = new global::System.Windows.Forms.Button();
			this.btn1YMoney = new global::System.Windows.Forms.Button();
			this.btnMaxMoney = new global::System.Windows.Forms.Button();
			this.charPanel = new global::MuEditor.CharPanel();
			this.panel0 = new global::System.Windows.Forms.Panel();
			this.txtMoney = new global::MuEditor.TextBox();
			this.packagePanel = new global::MuEditor.EquipPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.packagePanelLv1 = new global::MuEditor.EquipPanel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.packagePanelLv2 = new global::MuEditor.EquipPanel();
			this.pnlWarehouse = new global::System.Windows.Forms.Panel();
			this.WarehouseExp = new global::System.Windows.Forms.CheckBox();
			this.warehousePanelLv1 = new global::MuEditor.EquipPanel();
			this.btnClean = new global::System.Windows.Forms.Button();
			this.btnWare1YMoney = new global::System.Windows.Forms.Button();
			this.btnWareMaxMoney = new global::System.Windows.Forms.Button();
			this.label33 = new global::System.Windows.Forms.Label();
			this.txtWareHousePwd = new global::MuEditor.TextBox();
			this.btnClearWarehouse = new global::System.Windows.Forms.Button();
			this.label26 = new global::System.Windows.Forms.Label();
			this.txtWareHouseMoney = new global::MuEditor.TextBox();
			this.warehousePanel = new global::MuEditor.EquipPanel();
			this.label11 = new global::System.Windows.Forms.Label();
			this.btnUpdateWarehouse = new global::System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabcInfo.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pnlPackage.SuspendLayout();
			this.packageExp.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel0.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnlWarehouse.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip1.BackColor = global::System.Drawing.SystemColors.ActiveBorder;
			this.menuStrip1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SYSTEM_MenuItem,
				this.HELP_MenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(1250, 25);
			this.menuStrip1.TabIndex = 14;
			this.menuStrip1.Text = "menuStrip1";
			this.SYSTEM_MenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.AddAccountID,
				this.CharacterManager,
				this.toolStripSeparator2,
				this.CashShopPoint,
				this.toolStripSeparator1,
				this.GuildManager,
				this.toolStripSeparator3,
				this.OnlineStat,
				this.toolStripSeparator5,
				this.ExitEditor
			});
			this.SYSTEM_MenuItem.Name = "SYSTEM_MenuItem";
			this.SYSTEM_MenuItem.Size = new global::System.Drawing.Size(59, 21);
			this.SYSTEM_MenuItem.Text = "系统(&S)";
			this.AddAccountID.Name = "AddAccountID";
			this.AddAccountID.Size = new global::System.Drawing.Size(142, 22);
			this.AddAccountID.Text = "添加帐号(&N)";
			this.AddAccountID.Click += new global::System.EventHandler(this.AddAccountID_Click);
			this.CharacterManager.Name = "CharacterManager";
			this.CharacterManager.Size = new global::System.Drawing.Size(142, 22);
			this.CharacterManager.Text = "人物管理(&A)";
			this.CharacterManager.Click += new global::System.EventHandler(this.CharacterManager_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(139, 6);
			this.CashShopPoint.Name = "CashShopPoint";
			this.CashShopPoint.Size = new global::System.Drawing.Size(142, 22);
			this.CashShopPoint.Text = "积分管理";
			this.CashShopPoint.Click += new global::System.EventHandler(this.CashShopPoint_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(139, 6);
			this.GuildManager.Name = "GuildManager";
			this.GuildManager.Size = new global::System.Drawing.Size(142, 22);
			this.GuildManager.Text = "战盟管理(&G)";
			this.GuildManager.Click += new global::System.EventHandler(this.GuildManager_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(139, 6);
			this.OnlineStat.Name = "OnlineStat";
			this.OnlineStat.Size = new global::System.Drawing.Size(142, 22);
			this.OnlineStat.Text = "在线情况(&U)";
			this.OnlineStat.Click += new global::System.EventHandler(this.OnlineStat_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(139, 6);
			this.ExitEditor.Name = "ExitEditor";
			this.ExitEditor.Size = new global::System.Drawing.Size(142, 22);
			this.ExitEditor.Text = "退出(&X)";
			this.ExitEditor.Click += new global::System.EventHandler(this.ExitEditor_Click);
			this.HELP_MenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.Help,
				this.About
			});
			this.HELP_MenuItem.Name = "HELP_MenuItem";
			this.HELP_MenuItem.Size = new global::System.Drawing.Size(61, 21);
			this.HELP_MenuItem.Text = "帮助(&H)";
			this.Help.Name = "Help";
			this.Help.ShortcutKeys = (global::System.Windows.Forms.Keys)131184;
			this.Help.Size = new global::System.Drawing.Size(191, 22);
			this.Help.Text = "如何使用(&H)";
			this.Help.Click += new global::System.EventHandler(this.Help_Click);
			this.About.Name = "About";
			this.About.Size = new global::System.Drawing.Size(191, 22);
			this.About.Text = "关于(&A)";
			this.About.Click += new global::System.EventHandler(this.About_Click);
			this.cbAll.AutoSize = true;
			this.cbAll.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.cbAll.Location = new global::System.Drawing.Point(15, 211);
			this.cbAll.Name = "cbAll";
			this.cbAll.Size = new global::System.Drawing.Size(48, 16);
			this.cbAll.TabIndex = 55;
			this.cbAll.Text = "全选";
			this.cbAll.UseVisualStyleBackColor = true;
			this.cbAll.CheckedChanged += new global::System.EventHandler(this.cbAll_CheckedChanged);
			this.tabPage4.Controls.Add(this.cbSaveJN);
			this.tabPage4.Controls.Add(this.btnExp);
			this.tabPage4.Controls.Add(this.cbAll);
			this.tabPage4.Controls.Add(this.btnMaster);
			this.tabPage4.Controls.Add(this.label29);
			this.tabPage4.Controls.Add(this.clbCharacter);
			this.tabPage4.Controls.Add(this.label10);
			this.tabPage4.Controls.Add(this.txtLeaderShip);
			this.tabPage4.Controls.Add(this.laName);
			this.tabPage4.Controls.Add(this.txtChar);
			this.tabPage4.Controls.Add(this.cboClass);
			this.tabPage4.Controls.Add(this.txtLevel);
			this.tabPage4.Controls.Add(this.txtPoint);
			this.tabPage4.Controls.Add(this.txtExp);
			this.tabPage4.Controls.Add(this.txtStrength);
			this.tabPage4.Controls.Add(this.txtDexterity);
			this.tabPage4.Controls.Add(this.txtEnergy);
			this.tabPage4.Controls.Add(this.txtVitality);
			this.tabPage4.Controls.Add(this.cboPK);
			this.tabPage4.Controls.Add(this.cboCode);
			this.tabPage4.Controls.Add(this.txtPosY);
			this.tabPage4.Controls.Add(this.txtPosX);
			this.tabPage4.Controls.Add(this.cboMap);
			this.tabPage4.Controls.Add(this.btnUpdateChar);
			this.tabPage4.Controls.Add(this.label24);
			this.tabPage4.Controls.Add(this.label23);
			this.tabPage4.Controls.Add(this.label22);
			this.tabPage4.Controls.Add(this.label21);
			this.tabPage4.Controls.Add(this.label20);
			this.tabPage4.Controls.Add(this.label19);
			this.tabPage4.Controls.Add(this.label18);
			this.tabPage4.Controls.Add(this.label17);
			this.tabPage4.Controls.Add(this.label16);
			this.tabPage4.Controls.Add(this.label15);
			this.tabPage4.Controls.Add(this.label14);
			this.tabPage4.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new global::System.Drawing.Size(216, 461);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "角色";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.cbSaveJN.AutoSize = true;
			this.cbSaveJN.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.cbSaveJN.Location = new global::System.Drawing.Point(66, 391);
			this.cbSaveJN.Name = "cbSaveJN";
			this.cbSaveJN.Size = new global::System.Drawing.Size(72, 16);
			this.cbSaveJN.TabIndex = 62;
			this.cbSaveJN.Text = "保存技能";
			this.cbSaveJN.UseVisualStyleBackColor = true;
			this.btnExp.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnExp.Location = new global::System.Drawing.Point(171, 3);
			this.btnExp.Name = "btnExp";
			this.btnExp.Size = new global::System.Drawing.Size(43, 23);
			this.btnExp.TabIndex = 60;
			this.btnExp.Text = "经验";
			this.btnExp.UseVisualStyleBackColor = true;
			this.btnExp.Click += new global::System.EventHandler(this.btnExp_Click);
			this.btnMaster.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnMaster.Location = new global::System.Drawing.Point(32, 412);
			this.btnMaster.Name = "btnMaster";
			this.btnMaster.Size = new global::System.Drawing.Size(73, 21);
			this.btnMaster.TabIndex = 54;
			this.btnMaster.Text = "更新大师";
			this.btnMaster.UseVisualStyleBackColor = true;
			this.btnMaster.Click += new global::System.EventHandler(this.btnMaster_Click);
			this.label29.AutoSize = true;
			this.label29.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label29.Location = new global::System.Drawing.Point(7, 195);
			this.label29.Name = "label29";
			this.label29.Size = new global::System.Drawing.Size(53, 12);
			this.label29.TabIndex = 53;
			this.label29.Text = "角色技能";
			this.clbCharacter.CheckOnClick = true;
			this.clbCharacter.FormattingEnabled = true;
			this.clbCharacter.Location = new global::System.Drawing.Point(63, 188);
			this.clbCharacter.Name = "clbCharacter";
			this.clbCharacter.Size = new global::System.Drawing.Size(146, 196);
			this.clbCharacter.TabIndex = 52;
			this.label10.AutoSize = true;
			this.label10.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label10.Location = new global::System.Drawing.Point(108, 116);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(29, 12);
			this.label10.TabIndex = 34;
			this.label10.Text = "统率";
			this.txtLeaderShip.IsOnlyNumber = true;
			this.txtLeaderShip.Location = new global::System.Drawing.Point(138, 109);
			this.txtLeaderShip.Name = "txtLeaderShip";
			this.txtLeaderShip.Size = new global::System.Drawing.Size(71, 21);
			this.txtLeaderShip.TabIndex = 33;
			this.laName.AutoSize = true;
			this.laName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.laName.Location = new global::System.Drawing.Point(7, 10);
			this.laName.Name = "laName";
			this.laName.Size = new global::System.Drawing.Size(29, 12);
			this.laName.TabIndex = 32;
			this.laName.Text = "名字";
			this.txtChar.IsOnlyNumber = false;
			this.txtChar.Location = new global::System.Drawing.Point(34, 5);
			this.txtChar.Name = "txtChar";
			this.txtChar.ReadOnly = true;
			this.txtChar.Size = new global::System.Drawing.Size(68, 21);
			this.txtChar.TabIndex = 0;
			this.cboClass.DropDownHeight = 306;
			this.cboClass.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboClass.FormattingEnabled = true;
			this.cboClass.IntegralHeight = false;
			this.cboClass.Items.AddRange(new object[]
			{
				"魔法师",
				"魔导师",
				"神导师",
				"剑士",
				"骑士",
				"神骑士",
				"弓箭手",
				"圣射手",
				"神射手",
				"魔剑士",
				"剑圣",
				"圣导师",
				"祭师",
				"召唤师",
				"圣巫师",
				"神巫师",
				"角斗士",
				"角斗王",
				"未知职业"
			});
			this.cboClass.Location = new global::System.Drawing.Point(33, 32);
			this.cboClass.Name = "cboClass";
			this.cboClass.Size = new global::System.Drawing.Size(69, 20);
			this.cboClass.TabIndex = 21;
			this.cboClass.SelectedIndexChanged += new global::System.EventHandler(this.cboClass_SelectedIndexChanged);
			this.txtLevel.IsOnlyNumber = true;
			this.txtLevel.Location = new global::System.Drawing.Point(139, 4);
			this.txtLevel.Name = "txtLevel";
			this.txtLevel.Size = new global::System.Drawing.Size(30, 21);
			this.txtLevel.TabIndex = 14;
			this.txtPoint.IsOnlyNumber = true;
			this.txtPoint.Location = new global::System.Drawing.Point(33, 57);
			this.txtPoint.Name = "txtPoint";
			this.txtPoint.Size = new global::System.Drawing.Size(69, 21);
			this.txtPoint.TabIndex = 16;
			this.txtExp.IsOnlyNumber = true;
			this.txtExp.Location = new global::System.Drawing.Point(138, 31);
			this.txtExp.Name = "txtExp";
			this.txtExp.Size = new global::System.Drawing.Size(71, 21);
			this.txtExp.TabIndex = 11;
			this.txtStrength.IsOnlyNumber = true;
			this.txtStrength.Location = new global::System.Drawing.Point(138, 58);
			this.txtStrength.Name = "txtStrength";
			this.txtStrength.Size = new global::System.Drawing.Size(71, 21);
			this.txtStrength.TabIndex = 12;
			this.txtDexterity.IsOnlyNumber = true;
			this.txtDexterity.Location = new global::System.Drawing.Point(138, 84);
			this.txtDexterity.Name = "txtDexterity";
			this.txtDexterity.Size = new global::System.Drawing.Size(71, 21);
			this.txtDexterity.TabIndex = 17;
			this.txtEnergy.IsOnlyNumber = true;
			this.txtEnergy.Location = new global::System.Drawing.Point(33, 109);
			this.txtEnergy.Name = "txtEnergy";
			this.txtEnergy.Size = new global::System.Drawing.Size(70, 21);
			this.txtEnergy.TabIndex = 18;
			this.txtVitality.IsOnlyNumber = true;
			this.txtVitality.Location = new global::System.Drawing.Point(33, 84);
			this.txtVitality.Name = "txtVitality";
			this.txtVitality.Size = new global::System.Drawing.Size(69, 21);
			this.txtVitality.TabIndex = 13;
			this.cboPK.FormattingEnabled = true;
			this.cboPK.Items.AddRange(new object[]
			{
				"大侠",
				"英雄",
				"义士",
				"普通",
				"无赖",
				"恶人",
				"魔头"
			});
			this.cboPK.Location = new global::System.Drawing.Point(33, 136);
			this.cboPK.Name = "cboPK";
			this.cboPK.Size = new global::System.Drawing.Size(52, 20);
			this.cboPK.TabIndex = 22;
			this.cboCode.FormattingEnabled = true;
			this.cboCode.Items.AddRange(new object[]
			{
				"普通",
				"锁定",
				"公告",
				"隐形",
				"ＧＭ",
				"活动",
				"所有"
			});
			this.cboCode.Location = new global::System.Drawing.Point(138, 136);
			this.cboCode.Name = "cboCode";
			this.cboCode.Size = new global::System.Drawing.Size(52, 20);
			this.cboCode.TabIndex = 23;
			this.txtPosY.IsOnlyNumber = true;
			this.txtPosY.Location = new global::System.Drawing.Point(175, 162);
			this.txtPosY.Name = "txtPosY";
			this.txtPosY.Size = new global::System.Drawing.Size(31, 21);
			this.txtPosY.TabIndex = 20;
			this.txtPosX.IsOnlyNumber = true;
			this.txtPosX.Location = new global::System.Drawing.Point(138, 162);
			this.txtPosX.Name = "txtPosX";
			this.txtPosX.Size = new global::System.Drawing.Size(31, 21);
			this.txtPosX.TabIndex = 15;
			this.cboMap.DropDownHeight = 306;
			this.cboMap.FormattingEnabled = true;
			this.cboMap.IntegralHeight = false;
			this.cboMap.Items.AddRange(new object[]
			{
				"勇者大陆",
				"地下城",
				"冰风谷",
				"仙踪林",
				"失落之塔",
				"遗忘之地",
				"竞技场",
				"亚特兰蒂斯",
				"死亡沙漠",
				"恶魔广场1234",
				"天空之城",
				"血色城堡 1",
				"血色城堡 2",
				"血色城堡 3",
				"血色城堡 4",
				"血色城堡 5",
				"血色城堡 6",
				"血色城堡 7",
				"赤色要塞 1",
				"赤色要塞 2",
				"赤色要塞 3",
				"赤色要塞 4",
				"赤色要塞 5",
				"赤色要塞 6",
				"卡利马 1",
				"卡利马 2",
				"卡利马 3",
				"卡利马 4",
				"卡利马 5",
				"卡利马 6",
				"罗兰峡谷",
				"魔炼之地",
				"恶魔广场56",
				"幽暗森林",
				"狼嚎要塞",
				"未知地图35",
				"卡利玛7",
				"坎特鲁废墟",
				"坎特鲁遗址",
				"提炼之塔",
				"未知地图40",
				"卡巴斯兵营",
				"卡巴斯休息处",
				"未知地图43",
				"未知地图44",
				"幻影寺院1",
				"幻影寺院2",
				"幻影寺院3",
				"幻影寺院4",
				"幻影寺院5",
				"幻影寺院6",
				"幻术园",
				"血色城堡8",
				"赤色要塞7",
				"未知地图54",
				"未知地图55",
				"安宁池",
				"冰霜之城",
				"孵化魔地",
				"未知地图59",
				"未知地图60",
				"未知地图61",
				"圣诞之地"
			});
			this.cboMap.Location = new global::System.Drawing.Point(33, 162);
			this.cboMap.Name = "cboMap";
			this.cboMap.Size = new global::System.Drawing.Size(96, 20);
			this.cboMap.TabIndex = 24;
			this.btnUpdateChar.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnUpdateChar.Location = new global::System.Drawing.Point(116, 412);
			this.btnUpdateChar.Name = "btnUpdateChar";
			this.btnUpdateChar.Size = new global::System.Drawing.Size(69, 21);
			this.btnUpdateChar.TabIndex = 25;
			this.btnUpdateChar.Text = "更新角色";
			this.btnUpdateChar.UseVisualStyleBackColor = true;
			this.btnUpdateChar.Click += new global::System.EventHandler(this.btnUpdateChar_Click);
			this.label24.AutoSize = true;
			this.label24.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label24.Location = new global::System.Drawing.Point(108, 142);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(29, 12);
			this.label24.TabIndex = 10;
			this.label24.Text = "状态";
			this.label23.AutoSize = true;
			this.label23.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label23.Location = new global::System.Drawing.Point(7, 168);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(29, 12);
			this.label23.TabIndex = 9;
			this.label23.Text = "位置";
			this.label22.AutoSize = true;
			this.label22.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label22.Location = new global::System.Drawing.Point(7, 116);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(29, 12);
			this.label22.TabIndex = 8;
			this.label22.Text = "智力";
			this.label21.AutoSize = true;
			this.label21.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label21.Location = new global::System.Drawing.Point(7, 142);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(29, 12);
			this.label21.TabIndex = 7;
			this.label21.Text = "ＰＫ";
			this.label20.AutoSize = true;
			this.label20.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label20.Location = new global::System.Drawing.Point(108, 90);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(29, 12);
			this.label20.TabIndex = 6;
			this.label20.Text = "敏捷";
			this.label19.AutoSize = true;
			this.label19.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label19.Location = new global::System.Drawing.Point(7, 90);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(29, 12);
			this.label19.TabIndex = 5;
			this.label19.Text = "体力";
			this.label18.AutoSize = true;
			this.label18.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label18.Location = new global::System.Drawing.Point(7, 63);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(29, 12);
			this.label18.TabIndex = 4;
			this.label18.Text = "剩点";
			this.label17.AutoSize = true;
			this.label17.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label17.Location = new global::System.Drawing.Point(108, 65);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(29, 12);
			this.label17.TabIndex = 3;
			this.label17.Text = "力量";
			this.label16.AutoSize = true;
			this.label16.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label16.Location = new global::System.Drawing.Point(7, 37);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(29, 12);
			this.label16.TabIndex = 2;
			this.label16.Text = "职业";
			this.label15.AutoSize = true;
			this.label15.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label15.Location = new global::System.Drawing.Point(107, 10);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(29, 12);
			this.label15.TabIndex = 1;
			this.label15.Text = "等级";
			this.label14.AutoSize = true;
			this.label14.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label14.Location = new global::System.Drawing.Point(108, 37);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(29, 12);
			this.label14.TabIndex = 0;
			this.label14.Text = "经验";
			this.groupBox2.Controls.Add(this.txtServerCode);
			this.groupBox2.Controls.Add(this.label37);
			this.groupBox2.Controls.Add(this.txtNick);
			this.groupBox2.Controls.Add(this.label32);
			this.groupBox2.Controls.Add(this.txtJF);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.btnAccount);
			this.groupBox2.Controls.Add(this.chkState);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.txtSNO);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtAnswer);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtQuestion);
			this.groupBox2.Controls.Add(this.txtEMail);
			this.groupBox2.Controls.Add(this.txtPassword);
			this.groupBox2.Controls.Add(this.txtAcc);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(202, 283);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "帐号信息";
			this.txtServerCode.IsOnlyNumber = true;
			this.txtServerCode.Location = new global::System.Drawing.Point(48, 250);
			this.txtServerCode.Name = "txtServerCode";
			this.txtServerCode.Size = new global::System.Drawing.Size(59, 21);
			this.txtServerCode.TabIndex = 27;
			this.label37.AutoSize = true;
			this.label37.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label37.Location = new global::System.Drawing.Point(12, 253);
			this.label37.Name = "label37";
			this.label37.Size = new global::System.Drawing.Size(41, 12);
			this.label37.TabIndex = 26;
			this.label37.Text = "分区：";
			this.txtNick.IsOnlyNumber = false;
			this.txtNick.Location = new global::System.Drawing.Point(69, 68);
			this.txtNick.MaxLength = 10;
			this.txtNick.Name = "txtNick";
			this.txtNick.Size = new global::System.Drawing.Size(110, 21);
			this.txtNick.TabIndex = 25;
			this.label32.AutoSize = true;
			this.label32.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label32.Location = new global::System.Drawing.Point(13, 71);
			this.label32.Name = "label32";
			this.label32.Size = new global::System.Drawing.Size(41, 12);
			this.label32.TabIndex = 24;
			this.label32.Text = "昵称：";
			this.txtJF.Enabled = false;
			this.txtJF.IsOnlyNumber = true;
			this.txtJF.Location = new global::System.Drawing.Point(48, 222);
			this.txtJF.Name = "txtJF";
			this.txtJF.Size = new global::System.Drawing.Size(59, 21);
			this.txtJF.TabIndex = 23;
			this.label13.AutoSize = true;
			this.label13.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label13.Location = new global::System.Drawing.Point(12, 225);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(41, 12);
			this.label13.TabIndex = 21;
			this.label13.Text = "积分：";
			this.btnAccount.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnAccount.Location = new global::System.Drawing.Point(117, 225);
			this.btnAccount.Name = "btnAccount";
			this.btnAccount.Size = new global::System.Drawing.Size(62, 46);
			this.btnAccount.TabIndex = 15;
			this.btnAccount.Text = "更\u3000新";
			this.btnAccount.UseVisualStyleBackColor = true;
			this.btnAccount.Click += new global::System.EventHandler(this.btnAccount_Click);
			this.chkState.AutoSize = true;
			this.chkState.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.chkState.Location = new global::System.Drawing.Point(59, 201);
			this.chkState.Name = "chkState";
			this.chkState.Size = new global::System.Drawing.Size(48, 16);
			this.chkState.TabIndex = 14;
			this.chkState.Text = "封号";
			this.chkState.UseVisualStyleBackColor = true;
			this.label9.AutoSize = true;
			this.label9.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label9.Location = new global::System.Drawing.Point(12, 200);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(41, 12);
			this.label9.TabIndex = 13;
			this.label9.Text = "状态：";
			this.txtSNO.IsOnlyNumber = false;
			this.txtSNO.Location = new global::System.Drawing.Point(69, 175);
			this.txtSNO.MaxLength = 18;
			this.txtSNO.Name = "txtSNO";
			this.txtSNO.Size = new global::System.Drawing.Size(110, 21);
			this.txtSNO.TabIndex = 12;
			this.label8.AutoSize = true;
			this.label8.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new global::System.Drawing.Point(13, 178);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(53, 12);
			this.label8.TabIndex = 11;
			this.label8.Text = "身份证：";
			this.txtAnswer.IsOnlyNumber = false;
			this.txtAnswer.Location = new global::System.Drawing.Point(69, 148);
			this.txtAnswer.MaxLength = 50;
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new global::System.Drawing.Size(110, 21);
			this.txtAnswer.TabIndex = 10;
			this.label7.AutoSize = true;
			this.label7.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label7.Location = new global::System.Drawing.Point(13, 151);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(41, 12);
			this.label7.TabIndex = 9;
			this.label7.Text = "答案：";
			this.txtQuestion.IsOnlyNumber = false;
			this.txtQuestion.Location = new global::System.Drawing.Point(69, 121);
			this.txtQuestion.MaxLength = 50;
			this.txtQuestion.Name = "txtQuestion";
			this.txtQuestion.Size = new global::System.Drawing.Size(110, 21);
			this.txtQuestion.TabIndex = 8;
			this.txtEMail.IsOnlyNumber = false;
			this.txtEMail.Location = new global::System.Drawing.Point(69, 94);
			this.txtEMail.MaxLength = 50;
			this.txtEMail.Name = "txtEMail";
			this.txtEMail.Size = new global::System.Drawing.Size(110, 21);
			this.txtEMail.TabIndex = 7;
			this.txtPassword.IsOnlyNumber = false;
			this.txtPassword.Location = new global::System.Drawing.Point(69, 41);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new global::System.Drawing.Size(110, 21);
			this.txtPassword.TabIndex = 6;
			this.txtAcc.IsOnlyNumber = false;
			this.txtAcc.Location = new global::System.Drawing.Point(69, 14);
			this.txtAcc.Name = "txtAcc";
			this.txtAcc.ReadOnly = true;
			this.txtAcc.Size = new global::System.Drawing.Size(110, 21);
			this.txtAcc.TabIndex = 5;
			this.label6.AutoSize = true;
			this.label6.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new global::System.Drawing.Point(13, 124);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(41, 12);
			this.label6.TabIndex = 4;
			this.label6.Text = "问题：";
			this.label5.AutoSize = true;
			this.label5.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new global::System.Drawing.Point(13, 97);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(41, 12);
			this.label5.TabIndex = 3;
			this.label5.Text = "邮件：";
			this.label4.AutoSize = true;
			this.label4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new global::System.Drawing.Point(13, 44);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(41, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "密码：";
			this.label3.AutoSize = true;
			this.label3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new global::System.Drawing.Point(13, 20);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(41, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "帐号：";
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Controls.Add(this.groupBox2);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new global::System.Drawing.Size(216, 461);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "帐号";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.groupBox3.Controls.Add(this.label35);
			this.groupBox3.Controls.Add(this.label34);
			this.groupBox3.Controls.Add(this.btnSearchIP);
			this.groupBox3.Controls.Add(this.lblIP);
			this.groupBox3.Controls.Add(this.lblOnlineHours);
			this.groupBox3.Controls.Add(this.lblDisConnectTime);
			this.groupBox3.Controls.Add(this.lblConnectTime);
			this.groupBox3.Controls.Add(this.label36);
			this.groupBox3.Controls.Add(this.lblState);
			this.groupBox3.Controls.Add(this.lblServer);
			this.groupBox3.Location = new global::System.Drawing.Point(6, 295);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(202, 159);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "帐号信息";
			this.label35.AutoSize = true;
			this.label35.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.label35.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label35.Location = new global::System.Drawing.Point(3, 47);
			this.label35.Name = "label35";
			this.label35.Size = new global::System.Drawing.Size(65, 12);
			this.label35.TabIndex = 19;
			this.label35.Text = "帐号状态：";
			this.label34.AutoSize = true;
			this.label34.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.label34.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label34.Location = new global::System.Drawing.Point(3, 138);
			this.label34.Name = "label34";
			this.label34.Size = new global::System.Drawing.Size(65, 12);
			this.label34.TabIndex = 18;
			this.label34.Text = "在线时长：";
			this.btnSearchIP.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnSearchIP.Location = new global::System.Drawing.Point(154, 64);
			this.btnSearchIP.Name = "btnSearchIP";
			this.btnSearchIP.Size = new global::System.Drawing.Size(43, 22);
			this.btnSearchIP.TabIndex = 17;
			this.btnSearchIP.Text = "查 询";
			this.btnSearchIP.UseVisualStyleBackColor = true;
			this.btnSearchIP.Click += new global::System.EventHandler(this.btnSearchIP_Click);
			this.lblIP.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIP.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.lblIP.Location = new global::System.Drawing.Point(55, 66);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new global::System.Drawing.Size(95, 19);
			this.lblIP.TabIndex = 16;
			this.lblIP.Text = "0.0.0.0";
			this.lblIP.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblOnlineHours.AutoSize = true;
			this.lblOnlineHours.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.lblOnlineHours.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.lblOnlineHours.Location = new global::System.Drawing.Point(67, 138);
			this.lblOnlineHours.Name = "lblOnlineHours";
			this.lblOnlineHours.Size = new global::System.Drawing.Size(38, 12);
			this.lblOnlineHours.TabIndex = 15;
			this.lblOnlineHours.Text = "0小时";
			this.lblDisConnectTime.AutoSize = true;
			this.lblDisConnectTime.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.lblDisConnectTime.Location = new global::System.Drawing.Point(3, 115);
			this.lblDisConnectTime.Name = "lblDisConnectTime";
			this.lblDisConnectTime.Size = new global::System.Drawing.Size(65, 12);
			this.lblDisConnectTime.TabIndex = 14;
			this.lblDisConnectTime.Text = "下线时间：";
			this.lblConnectTime.AutoSize = true;
			this.lblConnectTime.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.lblConnectTime.Location = new global::System.Drawing.Point(3, 92);
			this.lblConnectTime.Name = "lblConnectTime";
			this.lblConnectTime.Size = new global::System.Drawing.Size(65, 12);
			this.lblConnectTime.TabIndex = 13;
			this.lblConnectTime.Text = "上线时间：";
			this.label36.AutoSize = true;
			this.label36.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label36.Location = new global::System.Drawing.Point(3, 69);
			this.label36.Name = "label36";
			this.label36.Size = new global::System.Drawing.Size(53, 12);
			this.label36.TabIndex = 12;
			this.label36.Text = "IP地址：";
			this.lblState.AutoSize = true;
			this.lblState.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.lblState.ForeColor = global::System.Drawing.Color.Green;
			this.lblState.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.lblState.Location = new global::System.Drawing.Point(74, 47);
			this.lblState.Name = "lblState";
			this.lblState.Size = new global::System.Drawing.Size(44, 12);
			this.lblState.TabIndex = 11;
			this.lblState.Text = "已下线";
			this.lblServer.AutoSize = true;
			this.lblServer.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.lblServer.Location = new global::System.Drawing.Point(3, 23);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new global::System.Drawing.Size(53, 12);
			this.lblServer.TabIndex = 10;
			this.lblServer.Text = "服务器：";
			this.tabPage5.Controls.Add(this.equipEditor);
			this.tabPage5.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new global::System.Drawing.Size(216, 461);
			this.tabPage5.TabIndex = 2;
			this.tabPage5.Text = "物品";
			this.tabPage5.UseVisualStyleBackColor = true;
			this.equipEditor.AllPart = false;
			this.equipEditor.DefaultDurability = byte.MaxValue;
			this.equipEditor.Location = new global::System.Drawing.Point(-1, 4);
			this.equipEditor.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipEditor.Name = "equipEditor";
			this.equipEditor.Size = new global::System.Drawing.Size(216, 457);
			this.equipEditor.TabIndex = 0;
			this.tabcInfo.Controls.Add(this.tabPage3);
			this.tabcInfo.Controls.Add(this.tabPage4);
			this.tabcInfo.Controls.Add(this.tabPage5);
			this.tabcInfo.Enabled = false;
			this.tabcInfo.Location = new global::System.Drawing.Point(6, 87);
			this.tabcInfo.Name = "tabcInfo";
			this.tabcInfo.SelectedIndex = 0;
			this.tabcInfo.Size = new global::System.Drawing.Size(224, 487);
			this.tabcInfo.TabIndex = 18;
			this.groupBox1.Controls.Add(this.btnChar);
			this.groupBox1.Controls.Add(this.btnWarehouse);
			this.groupBox1.Controls.Add(this.txtAccount);
			this.groupBox1.Controls.Add(this.cmbChar);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(6, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(224, 64);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.btnChar.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnChar.Location = new global::System.Drawing.Point(156, 38);
			this.btnChar.Name = "btnChar";
			this.btnChar.Size = new global::System.Drawing.Size(62, 21);
			this.btnChar.TabIndex = 5;
			this.btnChar.Text = "包 裹";
			this.btnChar.UseVisualStyleBackColor = true;
			this.btnChar.Click += new global::System.EventHandler(this.btnChar_Click);
			this.btnWarehouse.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnWarehouse.Location = new global::System.Drawing.Point(156, 14);
			this.btnWarehouse.Name = "btnWarehouse";
			this.btnWarehouse.Size = new global::System.Drawing.Size(62, 21);
			this.btnWarehouse.TabIndex = 4;
			this.btnWarehouse.Text = "仓 库";
			this.btnWarehouse.UseVisualStyleBackColor = true;
			this.btnWarehouse.Click += new global::System.EventHandler(this.btnWarehouse_Click);
			this.txtAccount.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtAccount.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.txtAccount.FormattingEnabled = true;
			this.txtAccount.Location = new global::System.Drawing.Point(46, 14);
			this.txtAccount.MaxLength = 10;
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new global::System.Drawing.Size(103, 20);
			this.txtAccount.TabIndex = 2;
			this.txtAccount.SelectedIndexChanged += new global::System.EventHandler(this.txtAccount_SelectedIndexChanged);
			this.txtAccount.TextChanged += new global::System.EventHandler(this.txtAccount_TextChanged);
			this.txtAccount.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtAccount_KeyPress);
			this.cmbChar.FormattingEnabled = true;
			this.cmbChar.Location = new global::System.Drawing.Point(46, 39);
			this.cmbChar.MaxLength = 10;
			this.cmbChar.Name = "cmbChar";
			this.cmbChar.Size = new global::System.Drawing.Size(103, 20);
			this.cmbChar.TabIndex = 3;
			this.cmbChar.SelectedIndexChanged += new global::System.EventHandler(this.cmbChar_SelectedIndexChanged);
			this.cmbChar.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.cmbChar_KeyPress);
			this.label2.AutoSize = true;
			this.label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new global::System.Drawing.Point(10, 44);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(35, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "角色:";
			this.label1.AutoSize = true;
			this.label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new global::System.Drawing.Point(10, 18);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(35, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "帐号:";
			this.button2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.button2.Location = new global::System.Drawing.Point(54, 400);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(86, 23);
			this.button2.TabIndex = 16;
			this.button2.Text = "保存仓库";
			this.button2.UseVisualStyleBackColor = true;
			this.pnlPackage.BackColor = global::System.Drawing.Color.FromArgb(32, 27, 23);
			this.pnlPackage.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlPackage.Controls.Add(this.packageExp);
			this.pnlPackage.Controls.Add(this.btnUpdatePackage);
			this.pnlPackage.Controls.Add(this.btnClearPackage);
			this.pnlPackage.Controls.Add(this.btnClearChar);
			this.pnlPackage.Controls.Add(this.panel5);
			this.pnlPackage.Controls.Add(this.panel4);
			this.pnlPackage.Controls.Add(this.panel3);
			this.pnlPackage.Controls.Add(this.sPentagramPanel);
			this.pnlPackage.Controls.Add(this.btnCleanPackage);
			this.pnlPackage.Controls.Add(this.btn1YMoney);
			this.pnlPackage.Controls.Add(this.btnMaxMoney);
			this.pnlPackage.Controls.Add(this.charPanel);
			this.pnlPackage.Controls.Add(this.panel0);
			this.pnlPackage.Controls.Add(this.panel1);
			this.pnlPackage.Controls.Add(this.panel2);
			this.pnlPackage.Location = new global::System.Drawing.Point(656, 26);
			this.pnlPackage.Name = "pnlPackage";
			this.pnlPackage.Size = new global::System.Drawing.Size(595, 548);
			this.pnlPackage.TabIndex = 23;
			this.pnlPackage.Visible = false;
			this.packageExp.Controls.Add(this.PackageExpLv2);
			this.packageExp.Controls.Add(this.PackageExpLv1);
			this.packageExp.Controls.Add(this.chkPackageExp);
			this.packageExp.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.packageExp.ForeColor = global::System.Drawing.Color.Yellow;
			this.packageExp.Location = new global::System.Drawing.Point(312, 404);
			this.packageExp.Name = "packageExp";
			this.packageExp.Size = new global::System.Drawing.Size(200, 100);
			this.packageExp.TabIndex = 89;
			this.packageExp.TabStop = false;
			this.packageExp.Text = "扩展包囊";
			this.PackageExpLv2.AutoSize = true;
			this.PackageExpLv2.Enabled = false;
			this.PackageExpLv2.Location = new global::System.Drawing.Point(42, 68);
			this.PackageExpLv2.Name = "PackageExpLv2";
			this.PackageExpLv2.Size = new global::System.Drawing.Size(69, 21);
			this.PackageExpLv2.TabIndex = 2;
			this.PackageExpLv2.TabStop = true;
			this.PackageExpLv2.Text = "Level 2";
			this.PackageExpLv2.UseVisualStyleBackColor = true;
			this.PackageExpLv2.CheckedChanged += new global::System.EventHandler(this.PackageExpLv2_CheckedChanged);
			this.PackageExpLv1.AutoSize = true;
			this.PackageExpLv1.Enabled = false;
			this.PackageExpLv1.Location = new global::System.Drawing.Point(42, 46);
			this.PackageExpLv1.Name = "PackageExpLv1";
			this.PackageExpLv1.Size = new global::System.Drawing.Size(69, 21);
			this.PackageExpLv1.TabIndex = 1;
			this.PackageExpLv1.TabStop = true;
			this.PackageExpLv1.Text = "Level 1";
			this.PackageExpLv1.UseVisualStyleBackColor = true;
			this.PackageExpLv1.CheckedChanged += new global::System.EventHandler(this.PackageExpLv1_CheckedChanged);
			this.chkPackageExp.AutoSize = true;
			this.chkPackageExp.ForeColor = global::System.Drawing.Color.Red;
			this.chkPackageExp.Location = new global::System.Drawing.Point(20, 24);
			this.chkPackageExp.Name = "chkPackageExp";
			this.chkPackageExp.Size = new global::System.Drawing.Size(75, 21);
			this.chkPackageExp.TabIndex = 0;
			this.chkPackageExp.Text = "扩展包囊";
			this.chkPackageExp.UseVisualStyleBackColor = true;
			this.chkPackageExp.CheckedChanged += new global::System.EventHandler(this.chkPackageExp_CheckedChanged);
			this.btnUpdatePackage.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btnUpdatePackage.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnUpdatePackage.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnUpdatePackage.ForeColor = global::System.Drawing.Color.White;
			this.btnUpdatePackage.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnUpdatePackage.Location = new global::System.Drawing.Point(447, 509);
			this.btnUpdatePackage.Name = "btnUpdatePackage";
			this.btnUpdatePackage.Size = new global::System.Drawing.Size(46, 24);
			this.btnUpdatePackage.TabIndex = 83;
			this.btnUpdatePackage.Text = "保存";
			this.btnUpdatePackage.UseVisualStyleBackColor = false;
			this.btnUpdatePackage.Click += new global::System.EventHandler(this.btnUpdatePackage_Click);
			this.btnClearPackage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnClearPackage.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btnClearPackage.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnClearPackage.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnClearPackage.ForeColor = global::System.Drawing.Color.White;
			this.btnClearPackage.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnClearPackage.Location = new global::System.Drawing.Point(380, 509);
			this.btnClearPackage.Name = "btnClearPackage";
			this.btnClearPackage.Size = new global::System.Drawing.Size(66, 24);
			this.btnClearPackage.TabIndex = 85;
			this.btnClearPackage.Text = "清空包裹";
			this.btnClearPackage.UseVisualStyleBackColor = false;
			this.btnClearPackage.Click += new global::System.EventHandler(this.btnClearPackage_Click);
			this.btnClearChar.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnClearChar.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btnClearChar.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnClearChar.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnClearChar.ForeColor = global::System.Drawing.Color.White;
			this.btnClearChar.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnClearChar.Location = new global::System.Drawing.Point(312, 509);
			this.btnClearChar.Name = "btnClearChar";
			this.btnClearChar.Size = new global::System.Drawing.Size(66, 24);
			this.btnClearChar.TabIndex = 84;
			this.btnClearChar.Text = "清空人物";
			this.btnClearChar.UseVisualStyleBackColor = false;
			this.btnClearChar.Click += new global::System.EventHandler(this.btnClearChar_Click);
			this.panel5.BackgroundImage = global::MuEditor.Properties.Resources.shop;
			this.panel5.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panel5.Controls.Add(this.shopPanel);
			this.panel5.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.panel5.Location = new global::System.Drawing.Point(295, 265);
			this.panel5.Margin = new global::System.Windows.Forms.Padding(0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(295, 133);
			this.panel5.TabIndex = 80;
			this.shopPanel.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			this.shopPanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.shopPanel.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.shopPanel.Location = new global::System.Drawing.Point(43, 15);
			this.shopPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.shopPanel.Name = "shopPanel";
			this.shopPanel.Size = new global::System.Drawing.Size(209, 105);
			this.shopPanel.TabIndex = 59;
			this.panel4.BackgroundImage = global::MuEditor.Properties.Resources.package_exp_2;
			this.panel4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panel4.Controls.Add(this.packagePanelLv4);
			this.panel4.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.panel4.Location = new global::System.Drawing.Point(295, 265);
			this.panel4.Margin = new global::System.Windows.Forms.Padding(0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(295, 133);
			this.panel4.TabIndex = 79;
			this.panel4.Visible = false;
			this.packagePanelLv4.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			this.packagePanelLv4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.packagePanelLv4.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.packagePanelLv4.Enabled = false;
			this.packagePanelLv4.Location = new global::System.Drawing.Point(43, 15);
			this.packagePanelLv4.Margin = new global::System.Windows.Forms.Padding(0);
			this.packagePanelLv4.Name = "packagePanelLv4";
			this.packagePanelLv4.Size = new global::System.Drawing.Size(209, 105);
			this.packagePanelLv4.TabIndex = 67;
			this.panel3.BackgroundImage = global::MuEditor.Properties.Resources.package_exp_2;
			this.panel3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panel3.Controls.Add(this.packagePanelLv3);
			this.panel3.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.panel3.Location = new global::System.Drawing.Point(295, 266);
			this.panel3.Margin = new global::System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(295, 133);
			this.panel3.TabIndex = 78;
			this.panel3.Visible = false;
			this.packagePanelLv3.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			this.packagePanelLv3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.packagePanelLv3.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.packagePanelLv3.Enabled = false;
			this.packagePanelLv3.Location = new global::System.Drawing.Point(43, 15);
			this.packagePanelLv3.Margin = new global::System.Windows.Forms.Padding(0);
			this.packagePanelLv3.Name = "packagePanelLv3";
			this.packagePanelLv3.Size = new global::System.Drawing.Size(209, 105);
			this.packagePanelLv3.TabIndex = 66;
			this.sPentagramPanel.BackgroundImage = global::MuEditor.Properties.Resources.skillbook;
			this.sPentagramPanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.sPentagramPanel.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.sPentagramPanel.Location = new global::System.Drawing.Point(228, 218);
			this.sPentagramPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.sPentagramPanel.Name = "sPentagramPanel";
			this.sPentagramPanel.Prof = -1;
			this.sPentagramPanel.Size = new global::System.Drawing.Size(58, 58);
			this.sPentagramPanel.TabIndex = 67;
			this.btnCleanPackage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCleanPackage.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btnCleanPackage.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnCleanPackage.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnCleanPackage.ForeColor = global::System.Drawing.Color.White;
			this.btnCleanPackage.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnCleanPackage.Location = new global::System.Drawing.Point(231, 509);
			this.btnCleanPackage.Name = "btnCleanPackage";
			this.btnCleanPackage.Size = new global::System.Drawing.Size(44, 24);
			this.btnCleanPackage.TabIndex = 61;
			this.btnCleanPackage.Text = "整理";
			this.btnCleanPackage.UseVisualStyleBackColor = false;
			this.btnCleanPackage.Click += new global::System.EventHandler(this.btnCleanPackage_Click);
			this.btn1YMoney.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btn1YMoney.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btn1YMoney.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btn1YMoney.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btn1YMoney.ForeColor = global::System.Drawing.Color.White;
			this.btn1YMoney.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btn1YMoney.Location = new global::System.Drawing.Point(191, 509);
			this.btn1YMoney.Name = "btn1YMoney";
			this.btn1YMoney.Size = new global::System.Drawing.Size(37, 24);
			this.btn1YMoney.TabIndex = 57;
			this.btn1YMoney.Text = "1亿";
			this.btn1YMoney.UseVisualStyleBackColor = false;
			this.btn1YMoney.Click += new global::System.EventHandler(this.btn1YMoney_Click);
			this.btnMaxMoney.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnMaxMoney.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btnMaxMoney.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnMaxMoney.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnMaxMoney.ForeColor = global::System.Drawing.Color.White;
			this.btnMaxMoney.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnMaxMoney.Location = new global::System.Drawing.Point(143, 509);
			this.btnMaxMoney.Name = "btnMaxMoney";
			this.btnMaxMoney.Size = new global::System.Drawing.Size(45, 24);
			this.btnMaxMoney.TabIndex = 56;
			this.btnMaxMoney.Text = "最大";
			this.btnMaxMoney.UseVisualStyleBackColor = false;
			this.btnMaxMoney.Click += new global::System.EventHandler(this.btnMaxMoney_Click);
			this.charPanel.BackgroundImage = global::MuEditor.Properties.Resources.char_2;
			this.charPanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.charPanel.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.charPanel.Location = new global::System.Drawing.Point(0, 0);
			this.charPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.charPanel.Name = "charPanel";
			this.charPanel.Prof = -1;
			this.charPanel.Size = new global::System.Drawing.Size(295, 284);
			this.charPanel.TabIndex = 13;
			this.panel0.BackgroundImage = global::MuEditor.Properties.Resources.package;
			this.panel0.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panel0.Controls.Add(this.txtMoney);
			this.panel0.Controls.Add(this.packagePanel);
			this.panel0.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.panel0.Location = new global::System.Drawing.Point(0, 284);
			this.panel0.Margin = new global::System.Windows.Forms.Padding(0);
			this.panel0.Name = "panel0";
			this.panel0.Size = new global::System.Drawing.Size(295, 260);
			this.panel0.TabIndex = 68;
			this.txtMoney.BackColor = global::System.Drawing.Color.FromArgb(16, 14, 14);
			this.txtMoney.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMoney.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.txtMoney.ForeColor = global::System.Drawing.Color.Red;
			this.txtMoney.IsOnlyNumber = true;
			this.txtMoney.Location = new global::System.Drawing.Point(43, 226);
			this.txtMoney.Name = "txtMoney";
			this.txtMoney.Size = new global::System.Drawing.Size(96, 23);
			this.txtMoney.TabIndex = 32;
			this.txtMoney.Text = "0";
			this.packagePanel.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			this.packagePanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.packagePanel.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.packagePanel.Location = new global::System.Drawing.Point(43, 6);
			this.packagePanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.packagePanel.Name = "packagePanel";
			this.packagePanel.Size = new global::System.Drawing.Size(209, 209);
			this.packagePanel.TabIndex = 15;
			this.panel1.BackgroundImage = global::MuEditor.Properties.Resources.package_exp_1;
			this.panel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panel1.Controls.Add(this.packagePanelLv1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.panel1.Location = new global::System.Drawing.Point(295, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(295, 133);
			this.panel1.TabIndex = 69;
			this.packagePanelLv1.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			this.packagePanelLv1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.packagePanelLv1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.packagePanelLv1.Location = new global::System.Drawing.Point(43, 15);
			this.packagePanelLv1.Margin = new global::System.Windows.Forms.Padding(0);
			this.packagePanelLv1.Name = "packagePanelLv1";
			this.packagePanelLv1.Size = new global::System.Drawing.Size(209, 105);
			this.packagePanelLv1.TabIndex = 64;
			this.panel2.BackgroundImage = global::MuEditor.Properties.Resources.package_exp_2;
			this.panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panel2.Controls.Add(this.packagePanelLv2);
			this.panel2.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.panel2.Location = new global::System.Drawing.Point(295, 133);
			this.panel2.Margin = new global::System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(295, 133);
			this.panel2.TabIndex = 70;
			this.packagePanelLv2.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			this.packagePanelLv2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.packagePanelLv2.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.packagePanelLv2.Location = new global::System.Drawing.Point(43, 15);
			this.packagePanelLv2.Margin = new global::System.Windows.Forms.Padding(0);
			this.packagePanelLv2.Name = "packagePanelLv2";
			this.packagePanelLv2.Size = new global::System.Drawing.Size(209, 105);
			this.packagePanelLv2.TabIndex = 65;
			this.pnlWarehouse.BackColor = global::System.Drawing.Color.FromArgb(32, 27, 23);
			this.pnlWarehouse.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlWarehouse.Controls.Add(this.WarehouseExp);
			this.pnlWarehouse.Controls.Add(this.warehousePanelLv1);
			this.pnlWarehouse.Controls.Add(this.btnClean);
			this.pnlWarehouse.Controls.Add(this.btnWare1YMoney);
			this.pnlWarehouse.Controls.Add(this.btnWareMaxMoney);
			this.pnlWarehouse.Controls.Add(this.label33);
			this.pnlWarehouse.Controls.Add(this.txtWareHousePwd);
			this.pnlWarehouse.Controls.Add(this.btnClearWarehouse);
			this.pnlWarehouse.Controls.Add(this.label26);
			this.pnlWarehouse.Controls.Add(this.txtWareHouseMoney);
			this.pnlWarehouse.Controls.Add(this.warehousePanel);
			this.pnlWarehouse.Controls.Add(this.label11);
			this.pnlWarehouse.Controls.Add(this.btnUpdateWarehouse);
			this.pnlWarehouse.Location = new global::System.Drawing.Point(233, 26);
			this.pnlWarehouse.Name = "pnlWarehouse";
			this.pnlWarehouse.Size = new global::System.Drawing.Size(425, 548);
			this.pnlWarehouse.TabIndex = 22;
			this.pnlWarehouse.Visible = false;
			this.WarehouseExp.AutoSize = true;
			this.WarehouseExp.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.WarehouseExp.ForeColor = global::System.Drawing.Color.Yellow;
			this.WarehouseExp.Location = new global::System.Drawing.Point(126, 402);
			this.WarehouseExp.Name = "WarehouseExp";
			this.WarehouseExp.Size = new global::System.Drawing.Size(75, 21);
			this.WarehouseExp.TabIndex = 62;
			this.WarehouseExp.Text = "扩展仓库";
			this.WarehouseExp.UseVisualStyleBackColor = true;
			this.warehousePanelLv1.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			this.warehousePanelLv1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.warehousePanelLv1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.warehousePanelLv1.Location = new global::System.Drawing.Point(211, 0);
			this.warehousePanelLv1.Margin = new global::System.Windows.Forms.Padding(0);
			this.warehousePanelLv1.Name = "warehousePanelLv1";
			this.warehousePanelLv1.Size = new global::System.Drawing.Size(209, 392);
			this.warehousePanelLv1.TabIndex = 61;
			this.btnClean.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btnClean.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnClean.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnClean.ForeColor = global::System.Drawing.Color.White;
			this.btnClean.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnClean.Location = new global::System.Drawing.Point(82, 457);
			this.btnClean.Name = "btnClean";
			this.btnClean.Size = new global::System.Drawing.Size(48, 25);
			this.btnClean.TabIndex = 60;
			this.btnClean.Text = "整理";
			this.btnClean.UseVisualStyleBackColor = false;
			this.btnClean.Click += new global::System.EventHandler(this.btnClean_Click);
			this.btnWare1YMoney.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btnWare1YMoney.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnWare1YMoney.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnWare1YMoney.ForeColor = global::System.Drawing.Color.White;
			this.btnWare1YMoney.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnWare1YMoney.Location = new global::System.Drawing.Point(172, 425);
			this.btnWare1YMoney.Name = "btnWare1YMoney";
			this.btnWare1YMoney.Size = new global::System.Drawing.Size(37, 25);
			this.btnWare1YMoney.TabIndex = 59;
			this.btnWare1YMoney.Text = "1亿";
			this.btnWare1YMoney.UseVisualStyleBackColor = false;
			this.btnWare1YMoney.Click += new global::System.EventHandler(this.btnWare1YMoney_Click);
			this.btnWareMaxMoney.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btnWareMaxMoney.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnWareMaxMoney.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnWareMaxMoney.ForeColor = global::System.Drawing.Color.White;
			this.btnWareMaxMoney.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnWareMaxMoney.Location = new global::System.Drawing.Point(124, 425);
			this.btnWareMaxMoney.Name = "btnWareMaxMoney";
			this.btnWareMaxMoney.Size = new global::System.Drawing.Size(46, 25);
			this.btnWareMaxMoney.TabIndex = 58;
			this.btnWareMaxMoney.Text = "最大";
			this.btnWareMaxMoney.UseVisualStyleBackColor = false;
			this.btnWareMaxMoney.Click += new global::System.EventHandler(this.btnWareMaxMoney_Click);
			this.label33.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.label33.ForeColor = global::System.Drawing.Color.Red;
			this.label33.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label33.Location = new global::System.Drawing.Point(1, 499);
			this.label33.Name = "label33";
			this.label33.Size = new global::System.Drawing.Size(200, 40);
			this.label33.TabIndex = 36;
			this.label33.Text = "提示：右键点击物品即可进行修改\r\n\r\n不同区域的物品移动请剪切并粘贴";
			this.txtWareHousePwd.BackColor = global::System.Drawing.Color.FromArgb(16, 14, 14);
			this.txtWareHousePwd.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtWareHousePwd.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.txtWareHousePwd.ForeColor = global::System.Drawing.Color.Red;
			this.txtWareHousePwd.IsOnlyNumber = true;
			this.txtWareHousePwd.Location = new global::System.Drawing.Point(67, 399);
			this.txtWareHousePwd.Name = "txtWareHousePwd";
			this.txtWareHousePwd.Size = new global::System.Drawing.Size(54, 23);
			this.txtWareHousePwd.TabIndex = 35;
			this.txtWareHousePwd.Text = "0";
			this.btnClearWarehouse.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btnClearWarehouse.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnClearWarehouse.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnClearWarehouse.ForeColor = global::System.Drawing.Color.White;
			this.btnClearWarehouse.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnClearWarehouse.Location = new global::System.Drawing.Point(4, 457);
			this.btnClearWarehouse.Name = "btnClearWarehouse";
			this.btnClearWarehouse.Size = new global::System.Drawing.Size(72, 25);
			this.btnClearWarehouse.TabIndex = 17;
			this.btnClearWarehouse.Text = "清空仓库";
			this.btnClearWarehouse.UseVisualStyleBackColor = false;
			this.btnClearWarehouse.Click += new global::System.EventHandler(this.btnClearWarehouse_Click);
			this.label26.AutoSize = true;
			this.label26.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.label26.ForeColor = global::System.Drawing.Color.Yellow;
			this.label26.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label26.Location = new global::System.Drawing.Point(3, 401);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(68, 17);
			this.label26.TabIndex = 34;
			this.label26.Text = "仓库密码：";
			this.txtWareHouseMoney.BackColor = global::System.Drawing.Color.FromArgb(16, 14, 14);
			this.txtWareHouseMoney.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtWareHouseMoney.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.txtWareHouseMoney.ForeColor = global::System.Drawing.Color.Red;
			this.txtWareHouseMoney.IsOnlyNumber = true;
			this.txtWareHouseMoney.Location = new global::System.Drawing.Point(41, 426);
			this.txtWareHouseMoney.Name = "txtWareHouseMoney";
			this.txtWareHouseMoney.Size = new global::System.Drawing.Size(80, 23);
			this.txtWareHouseMoney.TabIndex = 33;
			this.txtWareHouseMoney.Text = "0";
			this.warehousePanel.BackgroundImage = global::MuEditor.Properties.Resources.warehouse_2;
			this.warehousePanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.warehousePanel.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.warehousePanel.Location = new global::System.Drawing.Point(0, 0);
			this.warehousePanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.warehousePanel.Name = "warehousePanel";
			this.warehousePanel.Size = new global::System.Drawing.Size(209, 392);
			this.warehousePanel.TabIndex = 11;
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.label11.ForeColor = global::System.Drawing.Color.Yellow;
			this.label11.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label11.Location = new global::System.Drawing.Point(3, 428);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(44, 17);
			this.label11.TabIndex = 32;
			this.label11.Text = "金钱：";
			this.btnUpdateWarehouse.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.btnUpdateWarehouse.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnUpdateWarehouse.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnUpdateWarehouse.ForeColor = global::System.Drawing.Color.White;
			this.btnUpdateWarehouse.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnUpdateWarehouse.Location = new global::System.Drawing.Point(136, 457);
			this.btnUpdateWarehouse.Name = "btnUpdateWarehouse";
			this.btnUpdateWarehouse.Size = new global::System.Drawing.Size(73, 25);
			this.btnUpdateWarehouse.TabIndex = 10;
			this.btnUpdateWarehouse.Text = "保存仓库";
			this.btnUpdateWarehouse.UseVisualStyleBackColor = false;
			this.btnUpdateWarehouse.Click += new global::System.EventHandler(this.btnUpdateWarehouse_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1250, 576);
			base.Controls.Add(this.pnlPackage);
			base.Controls.Add(this.pnlWarehouse);
			base.Controls.Add(this.menuStrip1);
			base.Controls.Add(this.tabcInfo);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.button2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			base.MaximizeBox = false;
			base.Name = "frmMain";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mu Editor For eX902 - v3.6.0.0";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tabcInfo.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.pnlPackage.ResumeLayout(false);
			this.packageExp.ResumeLayout(false);
			this.packageExp.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel0.ResumeLayout(false);
			this.panel0.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnlWarehouse.ResumeLayout(false);
			this.pnlWarehouse.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400006F RID: 111
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.ToolStripMenuItem SYSTEM_MenuItem;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.ToolStripMenuItem CharacterManager;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.ToolStripMenuItem ExitEditor;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.CheckBox cbAll;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Button btnMaster;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.CheckedListBox clbCharacter;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400007B RID: 123
		private global::MuEditor.TextBox txtLeaderShip;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Label laName;

		// Token: 0x0400007D RID: 125
		private global::MuEditor.TextBox txtChar;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.ComboBox cboClass;

		// Token: 0x0400007F RID: 127
		private global::MuEditor.TextBox txtLevel;

		// Token: 0x04000080 RID: 128
		private global::MuEditor.TextBox txtPoint;

		// Token: 0x04000081 RID: 129
		private global::MuEditor.TextBox txtExp;

		// Token: 0x04000082 RID: 130
		private global::MuEditor.TextBox txtStrength;

		// Token: 0x04000083 RID: 131
		private global::MuEditor.TextBox txtDexterity;

		// Token: 0x04000084 RID: 132
		private global::MuEditor.TextBox txtEnergy;

		// Token: 0x04000085 RID: 133
		private global::MuEditor.TextBox txtVitality;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.ComboBox cboPK;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.ComboBox cboCode;

		// Token: 0x04000088 RID: 136
		private global::MuEditor.TextBox txtPosY;

		// Token: 0x04000089 RID: 137
		private global::MuEditor.TextBox txtPosX;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.ComboBox cboMap;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Button btnUpdateChar;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label label24;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.Label label23;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000098 RID: 152
		private global::MuEditor.TextBox txtJF;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Button btnAccount;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.CheckBox chkState;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400009D RID: 157
		private global::MuEditor.TextBox txtSNO;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400009F RID: 159
		private global::MuEditor.TextBox txtAnswer;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000A1 RID: 161
		private global::MuEditor.TextBox txtQuestion;

		// Token: 0x040000A2 RID: 162
		private global::MuEditor.TextBox txtEMail;

		// Token: 0x040000A3 RID: 163
		private global::MuEditor.TextBox txtPassword;

		// Token: 0x040000A4 RID: 164
		private global::MuEditor.TextBox txtAcc;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x040000AA RID: 170
		private global::MuEditor.EquipEditor equipEditor;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.TabPage tabPage5;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.TabControl tabcInfo;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.Button btnChar;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Button btnWarehouse;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.ComboBox txtAccount;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.ComboBox cmbChar;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000B5 RID: 181
		private global::MuEditor.TextBox txtNick;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Label label32;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Label lblServer;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Label lblDisConnectTime;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.Label lblConnectTime;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.Label label36;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.Label lblState;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.Button btnSearchIP;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.Label lblIP;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.Label lblOnlineHours;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.Label label35;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.Label label34;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.ToolStripMenuItem OnlineStat;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.ToolStripMenuItem GuildManager;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x040000C5 RID: 197
		private global::MuEditor.TextBox txtServerCode;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.Label label37;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.Button btnExp;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.ToolStripMenuItem HELP_MenuItem;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.ToolStripMenuItem Help;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.ToolStripMenuItem About;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.CheckBox cbSaveJN;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.ToolStripMenuItem AddAccountID;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Panel pnlPackage;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.GroupBox packageExp;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.RadioButton PackageExpLv2;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.RadioButton PackageExpLv1;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.CheckBox chkPackageExp;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.Button btnUpdatePackage;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Button btnClearPackage;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Button btnClearChar;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x040000D7 RID: 215
		private global::MuEditor.EquipPanel shopPanel;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x040000D9 RID: 217
		private global::MuEditor.EquipPanel packagePanelLv4;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040000DB RID: 219
		private global::MuEditor.EquipPanel packagePanelLv3;

		// Token: 0x040000DC RID: 220
		private global::MuEditor.PentagramPanel sPentagramPanel;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Button btnCleanPackage;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Button btn1YMoney;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Button btnMaxMoney;

		// Token: 0x040000E0 RID: 224
		private global::MuEditor.CharPanel charPanel;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.Panel panel0;

		// Token: 0x040000E2 RID: 226
		private global::MuEditor.TextBox txtMoney;

		// Token: 0x040000E3 RID: 227
		private global::MuEditor.EquipPanel packagePanel;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000E5 RID: 229
		private global::MuEditor.EquipPanel packagePanelLv1;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040000E7 RID: 231
		private global::MuEditor.EquipPanel packagePanelLv2;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.Panel pnlWarehouse;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.CheckBox WarehouseExp;

		// Token: 0x040000EA RID: 234
		private global::MuEditor.EquipPanel warehousePanelLv1;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.Button btnClean;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.Button btnWare1YMoney;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.Button btnWareMaxMoney;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.Label label33;

		// Token: 0x040000EF RID: 239
		private global::MuEditor.TextBox txtWareHousePwd;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.Button btnClearWarehouse;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.Label label26;

		// Token: 0x040000F2 RID: 242
		private global::MuEditor.TextBox txtWareHouseMoney;

		// Token: 0x040000F3 RID: 243
		private global::MuEditor.EquipPanel warehousePanel;

		// Token: 0x040000F4 RID: 244
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040000F5 RID: 245
		private global::System.Windows.Forms.Button btnUpdateWarehouse;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.ToolStripMenuItem CashShopPoint;
	}
}
