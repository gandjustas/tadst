﻿namespace TADST
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabServerDetails = new System.Windows.Forms.TabPage();
            this.chkAutoinit = new System.Windows.Forms.CheckBox();
            this.chkPersistentBattlefield = new System.Windows.Forms.CheckBox();
            this.chkLoopback = new System.Windows.Forms.CheckBox();
            this.chkEnableUpnp = new System.Windows.Forms.CheckBox();
            this.btnPortCheck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtLocalIp = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtHeadlessIp = new System.Windows.Forms.TextBox();
            this.chkHeadlessEnabled = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.VoN = new System.Windows.Forms.GroupBox();
            this.chkDisableVon = new System.Windows.Forms.CheckBox();
            this.lblCodeQuality = new System.Windows.Forms.Label();
            this.numCodecQuality = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMonitorNetLog = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.btnMonitorRpt = new System.Windows.Forms.Button();
            this.btnRotateNetLog = new System.Windows.Forms.Button();
            this.btnDeleteNetLog = new System.Windows.Forms.Button();
            this.btnOpenNetLog = new System.Windows.Forms.Button();
            this.btnDeleteRpt = new System.Windows.Forms.Button();
            this.cmbTimeStampFormat = new System.Windows.Forms.ComboBox();
            this.btnOpenRpt = new System.Windows.Forms.Button();
            this.btnOpenPidFile = new System.Windows.Forms.Button();
            this.lblTimeStampFormat = new System.Windows.Forms.Label();
            this.btnOpenRankingFile = new System.Windows.Forms.Button();
            this.btnOpenLogFile = new System.Windows.Forms.Button();
            this.lblRankingFile = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.txtRankingFile = new System.Windows.Forms.TextBox();
            this.txtConsoleLogfile = new System.Windows.Forms.TextBox();
            this.txtPidfile = new System.Windows.Forms.TextBox();
            this.lblConsoleLogfile = new System.Windows.Forms.Label();
            this.chkNetlog = new System.Windows.Forms.CheckBox();
            this.lblMaxPLayers = new System.Windows.Forms.Label();
            this.numMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.tabServerRules = new System.Windows.Forms.TabPage();
            this.chkKickClientsOnSlowNetwork = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbKickClientsOnSlowNetwork = new System.Windows.Forms.ComboBox();
            this.numMaxPing = new System.Windows.Forms.NumericUpDown();
            this.chkMaxPing = new System.Windows.Forms.CheckBox();
            this.numMaxDesync = new System.Windows.Forms.NumericUpDown();
            this.chkMaxDesync = new System.Windows.Forms.CheckBox();
            this.numMaxPacketLoss = new System.Windows.Forms.NumericUpDown();
            this.chkMaxPacketloss = new System.Windows.Forms.CheckBox();
            this.chkDisconnectTimeout = new System.Windows.Forms.CheckBox();
            this.numDisconnectTimeOut = new System.Windows.Forms.NumericUpDown();
            this.chkBattlEye = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbAllowedFilePatching = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbVerifySignatures = new System.Windows.Forms.ComboBox();
            this.txtRequiredBuild = new System.Windows.Forms.TextBox();
            this.chkRequiredBuild = new System.Windows.Forms.CheckBox();
            this.grpMotd = new System.Windows.Forms.GroupBox();
            this.lblMotdInterval = new System.Windows.Forms.Label();
            this.numMotdInterval = new System.Windows.Forms.NumericUpDown();
            this.txtMotd = new System.Windows.Forms.TextBox();
            this.grpVoting = new System.Windows.Forms.GroupBox();
            this.lblVotingEnabled = new System.Windows.Forms.Label();
            this.chkEnableVoting = new System.Windows.Forms.CheckBox();
            this.lblVoteMissionPlayers = new System.Windows.Forms.Label();
            this.numVoteMissionPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblVoteThreshold = new System.Windows.Forms.Label();
            this.numVoteThreshold = new System.Windows.Forms.NumericUpDown();
            this.chkKickDuplicates = new System.Windows.Forms.CheckBox();
            this.tabMissions = new System.Windows.Forms.TabPage();
            this.grpMissions = new System.Windows.Forms.GroupBox();
            this.btnAllMissionsDiff = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblSelectedMissions = new System.Windows.Forms.Label();
            this.lblNumOfMissions = new System.Windows.Forms.Label();
            this.btnMissionDown = new System.Windows.Forms.Button();
            this.btnMissionUp = new System.Windows.Forms.Button();
            this.lblMissionFilter = new System.Windows.Forms.Label();
            this.cmbMissionFilter = new System.Windows.Forms.ComboBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblAvailableMissions = new System.Windows.Forms.Label();
            this.btnRefreshMissions = new System.Windows.Forms.Button();
            this.btnSelectNoneMissions = new System.Windows.Forms.Button();
            this.btnSelectAllMissions = new System.Windows.Forms.Button();
            this.btnInvertMissionSelection = new System.Windows.Forms.Button();
            this.lstMissions = new System.Windows.Forms.CheckedListBox();
            this.tabMods = new System.Windows.Forms.TabPage();
            this.grpMods = new System.Windows.Forms.GroupBox();
            this.btnSortMods = new System.Windows.Forms.Button();
            this.lblSelectedMods = new System.Windows.Forms.Label();
            this.lblNumOfMods = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeModBTN = new System.Windows.Forms.Button();
            this.modUpBTN = new System.Windows.Forms.Button();
            this.modDownBTN = new System.Windows.Forms.Button();
            this.btnSelectNoneMods = new System.Windows.Forms.Button();
            this.btnSelectAllMods = new System.Windows.Forms.Button();
            this.btnInvertMods = new System.Windows.Forms.Button();
            this.btnRefreshMods = new System.Windows.Forms.Button();
            this.btnAddModFolder = new System.Windows.Forms.Button();
            this.lstMods = new System.Windows.Forms.CheckedListBox();
            this.tabDiffSettings = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblProfileDifficultyInfo = new System.Windows.Forms.Label();
            this.grpProfileDifficulty = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAILevelPreset = new System.Windows.Forms.ComboBox();
            this.resetProfile = new System.Windows.Forms.Button();
            this.numPrecisionAI = new System.Windows.Forms.NumericUpDown();
            this.numSkillAI = new System.Windows.Forms.NumericUpDown();
            this.clbDifficultyItems = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbDefaultDifficulty = new System.Windows.Forms.ComboBox();
            this.tabPerformance = new System.Windows.Forms.TabPage();
            this.chkEnableHT = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numTerrainGrid = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numViewDistance = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtPerformanceInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMaxPacketSize = new System.Windows.Forms.TextBox();
            this.btnResetPerformance = new System.Windows.Forms.Button();
            this.MinErrorToSendNearLBL = new System.Windows.Forms.Label();
            this.txtMinErrorToSendNear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minBandwidthLBL2 = new System.Windows.Forms.Label();
            this.MaxCustomFileSize = new System.Windows.Forms.Label();
            this.txtMaxCustomFileSize = new System.Windows.Forms.TextBox();
            this.MinErrorToSendLBL = new System.Windows.Forms.Label();
            this.txtMinErrorToSend = new System.Windows.Forms.TextBox();
            this.MaxBandwidthLBL = new System.Windows.Forms.Label();
            this.txtMaxBandwidth = new System.Windows.Forms.TextBox();
            this.MinBandwidthLBL = new System.Windows.Forms.Label();
            this.txtMinBandwidth = new System.Windows.Forms.TextBox();
            this.MaxSizeNonguaranteedLBL = new System.Windows.Forms.Label();
            this.txtMaxSizeNonguaranteed = new System.Windows.Forms.TextBox();
            this.MaxSizeGuaranteedLBL = new System.Windows.Forms.Label();
            this.txtMaxSizeGuaranteed = new System.Windows.Forms.TextBox();
            this.MaxMsgSendLBL = new System.Windows.Forms.Label();
            this.txtMaxMessagesSend = new System.Windows.Forms.TextBox();
            this.tabServerScripts = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDoubleIdDetected = new System.Windows.Forms.TextBox();
            this.onDifferentDataLBL = new System.Windows.Forms.Label();
            this.txtOnUserConnected = new System.Windows.Forms.TextBox();
            this.doubleIdDetectedLBL = new System.Windows.Forms.Label();
            this.txtOnDifferentData = new System.Windows.Forms.TextBox();
            this.regularCheckLBL = new System.Windows.Forms.Label();
            this.onUserConnectedLBL = new System.Windows.Forms.Label();
            this.txtOnUnsignedData = new System.Windows.Forms.TextBox();
            this.txtOnHackedData = new System.Windows.Forms.TextBox();
            this.txtRegularCheck = new System.Windows.Forms.TextBox();
            this.txtOnUserDisconnected = new System.Windows.Forms.TextBox();
            this.onUnSignedDataLBL = new System.Windows.Forms.Label();
            this.onHackedDataLBL = new System.Windows.Forms.Label();
            this.onUserDisconnectedLBL = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtServerCommandPassword = new System.Windows.Forms.TextBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lblParameters = new System.Windows.Forms.Label();
            this.txtExtraParameters = new System.Windows.Forms.TextBox();
            this.lblServerExe = new System.Windows.Forms.Label();
            this.btnBrowseExe = new System.Windows.Forms.Button();
            this.txtServerExe = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.chkAutoExit = new System.Windows.Forms.CheckBox();
            this.chkTooltips = new System.Windows.Forms.CheckBox();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnProfileSave = new System.Windows.Forms.Button();
            this.btnProfileNew = new System.Windows.Forms.Button();
            this.cmbProfiles = new System.Windows.Forms.ComboBox();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtStartupParameters = new System.Windows.Forms.TextBox();
            this.chkStartAsIs = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabContainer.SuspendLayout();
            this.tabServerDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.VoN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCodecQuality)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).BeginInit();
            this.tabServerRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDesync)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPacketLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDisconnectTimeOut)).BeginInit();
            this.grpMotd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMotdInterval)).BeginInit();
            this.grpVoting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVoteMissionPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoteThreshold)).BeginInit();
            this.tabMissions.SuspendLayout();
            this.grpMissions.SuspendLayout();
            this.tabMods.SuspendLayout();
            this.grpMods.SuspendLayout();
            this.tabDiffSettings.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.grpProfileDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecisionAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillAI)).BeginInit();
            this.tabPerformance.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTerrainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numViewDistance)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabServerScripts.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.tabServerDetails);
            this.tabContainer.Controls.Add(this.tabServerRules);
            this.tabContainer.Controls.Add(this.tabMissions);
            this.tabContainer.Controls.Add(this.tabMods);
            this.tabContainer.Controls.Add(this.tabDiffSettings);
            this.tabContainer.Controls.Add(this.tabPerformance);
            this.tabContainer.Controls.Add(this.tabServerScripts);
            this.tabContainer.ImageList = this.imageList1;
            this.tabContainer.Location = new System.Drawing.Point(2, 3);
            this.tabContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(858, 614);
            this.tabContainer.TabIndex = 0;
            this.tabContainer.Click += new System.EventHandler(this.tabContainer_Click);
            // 
            // tabServerDetails
            // 
            this.tabServerDetails.BackColor = System.Drawing.Color.DarkOrange;
            this.tabServerDetails.Controls.Add(this.chkAutoinit);
            this.tabServerDetails.Controls.Add(this.chkPersistentBattlefield);
            this.tabServerDetails.Controls.Add(this.chkLoopback);
            this.tabServerDetails.Controls.Add(this.chkEnableUpnp);
            this.tabServerDetails.Controls.Add(this.btnPortCheck);
            this.tabServerDetails.Controls.Add(this.groupBox1);
            this.tabServerDetails.Controls.Add(this.txtPort);
            this.tabServerDetails.Controls.Add(this.VoN);
            this.tabServerDetails.Controls.Add(this.groupBox2);
            this.tabServerDetails.Controls.Add(this.lblMaxPLayers);
            this.tabServerDetails.Controls.Add(this.numMaxPlayers);
            this.tabServerDetails.Controls.Add(this.lblPort);
            this.tabServerDetails.Controls.Add(this.lblAdminPassword);
            this.tabServerDetails.Controls.Add(this.txtAdminPassword);
            this.tabServerDetails.Controls.Add(this.txtPassword);
            this.tabServerDetails.Controls.Add(this.lblPassword);
            this.tabServerDetails.Controls.Add(this.lblHostName);
            this.tabServerDetails.Controls.Add(this.txtServerName);
            this.tabServerDetails.ImageIndex = 0;
            this.tabServerDetails.Location = new System.Drawing.Point(4, 29);
            this.tabServerDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabServerDetails.Name = "tabServerDetails";
            this.tabServerDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabServerDetails.Size = new System.Drawing.Size(850, 581);
            this.tabServerDetails.TabIndex = 0;
            this.tabServerDetails.Text = "Details";
            // 
            // chkAutoinit
            // 
            this.chkAutoinit.AutoSize = true;
            this.chkAutoinit.Enabled = false;
            this.chkAutoinit.Location = new System.Drawing.Point(606, 192);
            this.chkAutoinit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutoinit.Name = "chkAutoinit";
            this.chkAutoinit.Size = new System.Drawing.Size(91, 24);
            this.chkAutoinit.TabIndex = 69;
            this.chkAutoinit.Text = "AutoInit";
            this.toolTip1.SetToolTip(this.chkAutoinit, "If Persistent Battlefield is enabled this option automatically initialize mission" +
        " just like first client does.\r\nNote that only default mission parameters values " +
        "are used!\r\n\r\nDefault is off\r\n");
            this.chkAutoinit.UseVisualStyleBackColor = true;
            this.chkAutoinit.CheckedChanged += new System.EventHandler(this.chkAutoinit_CheckedChanged);
            // 
            // chkPersistentBattlefield
            // 
            this.chkPersistentBattlefield.AutoSize = true;
            this.chkPersistentBattlefield.Location = new System.Drawing.Point(578, 162);
            this.chkPersistentBattlefield.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPersistentBattlefield.Name = "chkPersistentBattlefield";
            this.chkPersistentBattlefield.Size = new System.Drawing.Size(181, 24);
            this.chkPersistentBattlefield.TabIndex = 67;
            this.chkPersistentBattlefield.Text = "Persistent Battlefield";
            this.toolTip1.SetToolTip(this.chkPersistentBattlefield, "Missions will continue to run even after the last player disconnected. \r\nThe miss" +
        "ion must either have base or instant respawn.\r\n\r\nDefault is off\r\n");
            this.chkPersistentBattlefield.UseVisualStyleBackColor = true;
            this.chkPersistentBattlefield.CheckedChanged += new System.EventHandler(this.chkPersistentBattlefield_CheckedChanged);
            // 
            // chkLoopback
            // 
            this.chkLoopback.AutoSize = true;
            this.chkLoopback.Location = new System.Drawing.Point(578, 251);
            this.chkLoopback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLoopback.Name = "chkLoopback";
            this.chkLoopback.Size = new System.Drawing.Size(105, 24);
            this.chkLoopback.TabIndex = 39;
            this.chkLoopback.Text = "Loopback";
            this.toolTip1.SetToolTip(this.chkLoopback, resources.GetString("chkLoopback.ToolTip"));
            this.chkLoopback.UseVisualStyleBackColor = true;
            this.chkLoopback.CheckedChanged += new System.EventHandler(this.chkLoopback_CheckedChanged);
            // 
            // chkEnableUpnp
            // 
            this.chkEnableUpnp.AutoSize = true;
            this.chkEnableUpnp.Location = new System.Drawing.Point(735, 109);
            this.chkEnableUpnp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEnableUpnp.Name = "chkEnableUpnp";
            this.chkEnableUpnp.Size = new System.Drawing.Size(78, 24);
            this.chkEnableUpnp.TabIndex = 66;
            this.chkEnableUpnp.Text = "UPNP";
            this.toolTip1.SetToolTip(this.chkEnableUpnp, "Automatically creates port mapping on UPNP/IGD enabled router. \r\nThis option allo" +
        "ws you to create a server behind NAT \r\n(your router must have public IP and supp" +
        "ort UPNP/IGD protocol).");
            this.chkEnableUpnp.UseVisualStyleBackColor = true;
            this.chkEnableUpnp.CheckedChanged += new System.EventHandler(this.chkEnableUpnp_CheckedChanged);
            // 
            // btnPortCheck
            // 
            this.btnPortCheck.Location = new System.Drawing.Point(732, 62);
            this.btnPortCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPortCheck.Name = "btnPortCheck";
            this.btnPortCheck.Size = new System.Drawing.Size(87, 35);
            this.btnPortCheck.TabIndex = 63;
            this.btnPortCheck.Text = "Port  info";
            this.toolTip1.SetToolTip(this.btnPortCheck, "See if all needed ports are open or forwarded\r\ncorrectly.");
            this.btnPortCheck.UseVisualStyleBackColor = true;
            this.btnPortCheck.Click += new System.EventHandler(this.btnPortCheck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtLocalIp);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtHeadlessIp);
            this.groupBox1.Controls.Add(this.chkHeadlessEnabled);
            this.groupBox1.Location = new System.Drawing.Point(12, 437);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(825, 126);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Headless Client";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(51, 77);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(126, 20);
            this.label24.TabIndex = 67;
            this.label24.Text = "Local Clients IPs";
            // 
            // txtLocalIp
            // 
            this.txtLocalIp.Enabled = false;
            this.txtLocalIp.Location = new System.Drawing.Point(188, 72);
            this.txtLocalIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocalIp.Name = "txtLocalIp";
            this.txtLocalIp.Size = new System.Drawing.Size(626, 26);
            this.txtLocalIp.TabIndex = 66;
            this.toolTip1.SetToolTip(this.txtLocalIp, "Add Headless Clients IP\'s .\r\nIf more than one, separate with commas\r\n\r\nDoubleclic" +
        "k for default: 127.0.0.1");
            this.txtLocalIp.TextChanged += new System.EventHandler(this.txtLocalIp_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(118, 31);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 20);
            this.label23.TabIndex = 65;
            this.label23.Text = "HC IPs";
            // 
            // txtHeadlessIp
            // 
            this.txtHeadlessIp.Enabled = false;
            this.txtHeadlessIp.Location = new System.Drawing.Point(188, 26);
            this.txtHeadlessIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeadlessIp.Name = "txtHeadlessIp";
            this.txtHeadlessIp.Size = new System.Drawing.Size(626, 26);
            this.txtHeadlessIp.TabIndex = 65;
            this.toolTip1.SetToolTip(this.txtHeadlessIp, "Add Headless Clients IP\'s .\r\nIf more than one, separate with commas\r\n\r\nDoubleclic" +
        "k for default: 127.0.0.1");
            this.txtHeadlessIp.TextChanged += new System.EventHandler(this.txtHeadlessIp_TextChanged);
            this.txtHeadlessIp.DoubleClick += new System.EventHandler(this.txtHeadlessIp_DoubleClick);
            // 
            // chkHeadlessEnabled
            // 
            this.chkHeadlessEnabled.AutoSize = true;
            this.chkHeadlessEnabled.Location = new System.Drawing.Point(15, 29);
            this.chkHeadlessEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHeadlessEnabled.Name = "chkHeadlessEnabled";
            this.chkHeadlessEnabled.Size = new System.Drawing.Size(85, 24);
            this.chkHeadlessEnabled.TabIndex = 15;
            this.chkHeadlessEnabled.Text = "Enable";
            this.toolTip1.SetToolTip(this.chkHeadlessEnabled, "Check to enable headless client support on server");
            this.chkHeadlessEnabled.UseVisualStyleBackColor = true;
            this.chkHeadlessEnabled.CheckedChanged += new System.EventHandler(this.chkHeadlessEnabled_CheckedChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(614, 65);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(96, 26);
            this.txtPort.TabIndex = 60;
            this.toolTip1.SetToolTip(this.txtPort, "The port for the game server. \r\n* Make sure it\'s forwarded by your router/firewal" +
        "l\r\n\r\nDefault is 2302");
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged_1);
            this.txtPort.DoubleClick += new System.EventHandler(this.txtPort_DoubleClick);
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // VoN
            // 
            this.VoN.BackColor = System.Drawing.Color.DarkOrange;
            this.VoN.Controls.Add(this.chkDisableVon);
            this.VoN.Controls.Add(this.lblCodeQuality);
            this.VoN.Controls.Add(this.numCodecQuality);
            this.VoN.Location = new System.Drawing.Point(578, 302);
            this.VoN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoN.Name = "VoN";
            this.VoN.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoN.Size = new System.Drawing.Size(260, 126);
            this.VoN.TabIndex = 59;
            this.VoN.TabStop = false;
            this.VoN.Text = "Voice Over Net";
            // 
            // chkDisableVon
            // 
            this.chkDisableVon.AutoSize = true;
            this.chkDisableVon.Location = new System.Drawing.Point(26, 74);
            this.chkDisableVon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDisableVon.Name = "chkDisableVon";
            this.chkDisableVon.Size = new System.Drawing.Size(123, 24);
            this.chkDisableVon.TabIndex = 14;
            this.chkDisableVon.Text = "Disable VoN";
            this.toolTip1.SetToolTip(this.chkDisableVon, "Check to disable Voice over Net on server.\r\nDefault is enabled.");
            this.chkDisableVon.UseVisualStyleBackColor = true;
            this.chkDisableVon.CheckedChanged += new System.EventHandler(this.chkDisableVon_CheckedChanged);
            // 
            // lblCodeQuality
            // 
            this.lblCodeQuality.AutoSize = true;
            this.lblCodeQuality.Location = new System.Drawing.Point(22, 40);
            this.lblCodeQuality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeQuality.Name = "lblCodeQuality";
            this.lblCodeQuality.Size = new System.Drawing.Size(107, 20);
            this.lblCodeQuality.TabIndex = 38;
            this.lblCodeQuality.Text = "Codec Quality";
            // 
            // numCodecQuality
            // 
            this.numCodecQuality.Location = new System.Drawing.Point(158, 37);
            this.numCodecQuality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCodecQuality.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numCodecQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCodecQuality.Name = "numCodecQuality";
            this.numCodecQuality.Size = new System.Drawing.Size(64, 26);
            this.numCodecQuality.TabIndex = 13;
            this.toolTip1.SetToolTip(this.numCodecQuality, "Sets Voice-over-Net codec quality. \r\n\r\nValue range is from 1 to 30. \r\n8kHz is 0-1" +
        "0, \r\n16kHz is 11-20\r\n32kHz is 21-30\r\n\r\nDefault is 3. ");
            this.numCodecQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCodecQuality.ValueChanged += new System.EventHandler(this.numCodecQuality_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox2.Controls.Add(this.btnMonitorNetLog);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btnMonitorRpt);
            this.groupBox2.Controls.Add(this.btnRotateNetLog);
            this.groupBox2.Controls.Add(this.btnDeleteNetLog);
            this.groupBox2.Controls.Add(this.btnOpenNetLog);
            this.groupBox2.Controls.Add(this.btnDeleteRpt);
            this.groupBox2.Controls.Add(this.cmbTimeStampFormat);
            this.groupBox2.Controls.Add(this.btnOpenRpt);
            this.groupBox2.Controls.Add(this.btnOpenPidFile);
            this.groupBox2.Controls.Add(this.lblTimeStampFormat);
            this.groupBox2.Controls.Add(this.btnOpenRankingFile);
            this.groupBox2.Controls.Add(this.btnOpenLogFile);
            this.groupBox2.Controls.Add(this.lblRankingFile);
            this.groupBox2.Controls.Add(this.lblPid);
            this.groupBox2.Controls.Add(this.txtRankingFile);
            this.groupBox2.Controls.Add(this.txtConsoleLogfile);
            this.groupBox2.Controls.Add(this.txtPidfile);
            this.groupBox2.Controls.Add(this.lblConsoleLogfile);
            this.groupBox2.Controls.Add(this.chkNetlog);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(552, 285);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Logging";
            // 
            // btnMonitorNetLog
            // 
            this.btnMonitorNetLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitorNetLog.ImageIndex = 18;
            this.btnMonitorNetLog.ImageList = this.imageList1;
            this.btnMonitorNetLog.Location = new System.Drawing.Point(444, 222);
            this.btnMonitorNetLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonitorNetLog.Name = "btnMonitorNetLog";
            this.btnMonitorNetLog.Size = new System.Drawing.Size(96, 37);
            this.btnMonitorNetLog.TabIndex = 919;
            this.btnMonitorNetLog.Text = "Monitor";
            this.btnMonitorNetLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnMonitorNetLog, "Live monitor of netlog");
            this.btnMonitorNetLog.UseVisualStyleBackColor = true;
            this.btnMonitorNetLog.Click += new System.EventHandler(this.btnMonitorNetLog_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "server");
            this.imageList1.Images.SetKeyName(1, "rules");
            this.imageList1.Images.SetKeyName(2, "missions");
            this.imageList1.Images.SetKeyName(3, "mods");
            this.imageList1.Images.SetKeyName(4, "diff");
            this.imageList1.Images.SetKeyName(5, "performance");
            this.imageList1.Images.SetKeyName(6, "Command Prompt.png");
            this.imageList1.Images.SetKeyName(7, "Save.png");
            this.imageList1.Images.SetKeyName(8, "plus_2.png");
            this.imageList1.Images.SetKeyName(9, "crossout.png");
            this.imageList1.Images.SetKeyName(10, "refresh.png");
            this.imageList1.Images.SetKeyName(11, "zoom.png");
            this.imageList1.Images.SetKeyName(12, "export_black.png");
            this.imageList1.Images.SetKeyName(13, "info.png");
            this.imageList1.Images.SetKeyName(14, "Up.png");
            this.imageList1.Images.SetKeyName(15, "Down.png");
            this.imageList1.Images.SetKeyName(16, "sortascend");
            this.imageList1.Images.SetKeyName(17, "Apply.png");
            this.imageList1.Images.SetKeyName(18, "action_log.png");
            this.imageList1.Images.SetKeyName(19, "Open.png");
            this.imageList1.Images.SetKeyName(20, "rotate-cw.png");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(60, 228);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 918;
            this.label16.Text = "Netlog";
            // 
            // btnMonitorRpt
            // 
            this.btnMonitorRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitorRpt.ImageIndex = 18;
            this.btnMonitorRpt.ImageList = this.imageList1;
            this.btnMonitorRpt.Location = new System.Drawing.Point(444, 172);
            this.btnMonitorRpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonitorRpt.Name = "btnMonitorRpt";
            this.btnMonitorRpt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMonitorRpt.Size = new System.Drawing.Size(96, 37);
            this.btnMonitorRpt.TabIndex = 27;
            this.btnMonitorRpt.Text = "Monitor";
            this.btnMonitorRpt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnMonitorRpt, "Live monitor of RPT file");
            this.btnMonitorRpt.UseVisualStyleBackColor = true;
            this.btnMonitorRpt.Click += new System.EventHandler(this.btnMonitorRpt_Click);
            // 
            // btnRotateNetLog
            // 
            this.btnRotateNetLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRotateNetLog.ImageIndex = 20;
            this.btnRotateNetLog.ImageList = this.imageList1;
            this.btnRotateNetLog.Location = new System.Drawing.Point(153, 222);
            this.btnRotateNetLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRotateNetLog.Name = "btnRotateNetLog";
            this.btnRotateNetLog.Size = new System.Drawing.Size(93, 37);
            this.btnRotateNetLog.TabIndex = 30;
            this.btnRotateNetLog.Text = "Rotate";
            this.btnRotateNetLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRotateNetLog, resources.GetString("btnRotateNetLog.ToolTip"));
            this.btnRotateNetLog.UseVisualStyleBackColor = true;
            this.btnRotateNetLog.Click += new System.EventHandler(this.btnRotateNetLog_Click);
            // 
            // btnDeleteNetLog
            // 
            this.btnDeleteNetLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNetLog.ImageIndex = 9;
            this.btnDeleteNetLog.ImageList = this.imageList1;
            this.btnDeleteNetLog.Location = new System.Drawing.Point(346, 222);
            this.btnDeleteNetLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteNetLog.Name = "btnDeleteNetLog";
            this.btnDeleteNetLog.Size = new System.Drawing.Size(90, 37);
            this.btnDeleteNetLog.TabIndex = 29;
            this.btnDeleteNetLog.Text = "Delete";
            this.btnDeleteNetLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteNetLog, resources.GetString("btnDeleteNetLog.ToolTip"));
            this.btnDeleteNetLog.UseVisualStyleBackColor = true;
            this.btnDeleteNetLog.Click += new System.EventHandler(this.btnDeleteNetLog_Click);
            // 
            // btnOpenNetLog
            // 
            this.btnOpenNetLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenNetLog.ImageIndex = 19;
            this.btnOpenNetLog.ImageList = this.imageList1;
            this.btnOpenNetLog.Location = new System.Drawing.Point(254, 222);
            this.btnOpenNetLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenNetLog.Name = "btnOpenNetLog";
            this.btnOpenNetLog.Size = new System.Drawing.Size(86, 37);
            this.btnOpenNetLog.TabIndex = 28;
            this.btnOpenNetLog.Text = "Open";
            this.btnOpenNetLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnOpenNetLog, "Open netlog file.\r\n");
            this.btnOpenNetLog.UseVisualStyleBackColor = true;
            this.btnOpenNetLog.Click += new System.EventHandler(this.btnOpenNetLog_Click);
            // 
            // btnDeleteRpt
            // 
            this.btnDeleteRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRpt.ImageIndex = 9;
            this.btnDeleteRpt.ImageList = this.imageList1;
            this.btnDeleteRpt.Location = new System.Drawing.Point(346, 172);
            this.btnDeleteRpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteRpt.Name = "btnDeleteRpt";
            this.btnDeleteRpt.Size = new System.Drawing.Size(90, 37);
            this.btnDeleteRpt.TabIndex = 26;
            this.btnDeleteRpt.Text = "Delete";
            this.btnDeleteRpt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteRpt, resources.GetString("btnDeleteRpt.ToolTip"));
            this.btnDeleteRpt.UseVisualStyleBackColor = true;
            this.btnDeleteRpt.Click += new System.EventHandler(this.btnDeleteRpt_Click);
            // 
            // cmbTimeStampFormat
            // 
            this.cmbTimeStampFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeStampFormat.FormattingEnabled = true;
            this.cmbTimeStampFormat.Location = new System.Drawing.Point(153, 174);
            this.cmbTimeStampFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTimeStampFormat.Name = "cmbTimeStampFormat";
            this.cmbTimeStampFormat.Size = new System.Drawing.Size(90, 28);
            this.cmbTimeStampFormat.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cmbTimeStampFormat, "Set the timestamp format used on each report line in server-side RPT file.\r\nPossi" +
        "ble values are \"none\", \"short\" or \"full\".\r\n\r\nDefault is \"none\"\r\n");
            this.cmbTimeStampFormat.SelectedIndexChanged += new System.EventHandler(this.cmbTimeStampFormat_SelectedIndexChanged);
            // 
            // btnOpenRpt
            // 
            this.btnOpenRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenRpt.ImageIndex = 19;
            this.btnOpenRpt.ImageList = this.imageList1;
            this.btnOpenRpt.Location = new System.Drawing.Point(254, 172);
            this.btnOpenRpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenRpt.Name = "btnOpenRpt";
            this.btnOpenRpt.Size = new System.Drawing.Size(86, 37);
            this.btnOpenRpt.TabIndex = 25;
            this.btnOpenRpt.Text = "Open";
            this.btnOpenRpt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnOpenRpt, resources.GetString("btnOpenRpt.ToolTip"));
            this.btnOpenRpt.UseVisualStyleBackColor = true;
            this.btnOpenRpt.Click += new System.EventHandler(this.btnOpenRpt_Click);
            // 
            // btnOpenPidFile
            // 
            this.btnOpenPidFile.Location = new System.Drawing.Point(454, 123);
            this.btnOpenPidFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenPidFile.Name = "btnOpenPidFile";
            this.btnOpenPidFile.Size = new System.Drawing.Size(86, 35);
            this.btnOpenPidFile.TabIndex = 24;
            this.btnOpenPidFile.Text = "Open";
            this.btnOpenPidFile.UseVisualStyleBackColor = true;
            this.btnOpenPidFile.Click += new System.EventHandler(this.btnOpenPidFile_Click);
            // 
            // lblTimeStampFormat
            // 
            this.lblTimeStampFormat.AutoSize = true;
            this.lblTimeStampFormat.Location = new System.Drawing.Point(16, 180);
            this.lblTimeStampFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeStampFormat.Name = "lblTimeStampFormat";
            this.lblTimeStampFormat.Size = new System.Drawing.Size(129, 20);
            this.lblTimeStampFormat.TabIndex = 40;
            this.lblTimeStampFormat.Text = "RPT Time Stamp";
            // 
            // btnOpenRankingFile
            // 
            this.btnOpenRankingFile.Location = new System.Drawing.Point(454, 80);
            this.btnOpenRankingFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenRankingFile.Name = "btnOpenRankingFile";
            this.btnOpenRankingFile.Size = new System.Drawing.Size(86, 35);
            this.btnOpenRankingFile.TabIndex = 23;
            this.btnOpenRankingFile.Text = "Open";
            this.btnOpenRankingFile.UseVisualStyleBackColor = true;
            this.btnOpenRankingFile.Click += new System.EventHandler(this.btnOpenRankingFile_Click);
            // 
            // btnOpenLogFile
            // 
            this.btnOpenLogFile.Location = new System.Drawing.Point(454, 37);
            this.btnOpenLogFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenLogFile.Name = "btnOpenLogFile";
            this.btnOpenLogFile.Size = new System.Drawing.Size(86, 35);
            this.btnOpenLogFile.TabIndex = 22;
            this.btnOpenLogFile.Text = "Open";
            this.btnOpenLogFile.UseVisualStyleBackColor = true;
            this.btnOpenLogFile.Click += new System.EventHandler(this.btnOpenLogFile_Click);
            // 
            // lblRankingFile
            // 
            this.lblRankingFile.AutoSize = true;
            this.lblRankingFile.Location = new System.Drawing.Point(51, 88);
            this.lblRankingFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRankingFile.Name = "lblRankingFile";
            this.lblRankingFile.Size = new System.Drawing.Size(97, 20);
            this.lblRankingFile.TabIndex = 34;
            this.lblRankingFile.Text = "Ranking File";
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(82, 131);
            this.lblPid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(65, 20);
            this.lblPid.TabIndex = 33;
            this.lblPid.Text = "PID File";
            // 
            // txtRankingFile
            // 
            this.txtRankingFile.Location = new System.Drawing.Point(153, 82);
            this.txtRankingFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRankingFile.Name = "txtRankingFile";
            this.txtRankingFile.Size = new System.Drawing.Size(289, 26);
            this.txtRankingFile.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtRankingFile, "Game stats log file.\r\nDoubleclick text field to insert:  ranking.log");
            this.txtRankingFile.TextChanged += new System.EventHandler(this.txtRankingFile_TextChanged);
            this.txtRankingFile.DoubleClick += new System.EventHandler(this.txtRankingFile_DoubleClick);
            this.txtRankingFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRankingFile_KeyPress);
            // 
            // txtConsoleLogfile
            // 
            this.txtConsoleLogfile.Location = new System.Drawing.Point(153, 38);
            this.txtConsoleLogfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConsoleLogfile.Name = "txtConsoleLogfile";
            this.txtConsoleLogfile.Size = new System.Drawing.Size(289, 26);
            this.txtConsoleLogfile.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtConsoleLogfile, "Enables output of dedicated server console into textfile.\r\nDefault location of lo" +
        "g is same as crash dumps and other logs. (Local settings)\r\nDoubleclick text fiel" +
        "d to insert:  server_console.log");
            this.txtConsoleLogfile.TextChanged += new System.EventHandler(this.txtConsoleLogfile_TextChanged);
            this.txtConsoleLogfile.DoubleClick += new System.EventHandler(this.txtConsoleLogfile_DoubleClick);
            this.txtConsoleLogfile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsoleLogfile_KeyPress);
            // 
            // txtPidfile
            // 
            this.txtPidfile.Location = new System.Drawing.Point(153, 125);
            this.txtPidfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPidfile.Name = "txtPidfile";
            this.txtPidfile.Size = new System.Drawing.Size(289, 26);
            this.txtPidfile.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtPidfile, "Specifies a file to write the server\'s PID (process ID) to.\r\nBy default the file " +
        "is created in game folder and is deleted when the server is stopped.\r\nDoubleclic" +
        "k in text field to insert:   pid.log");
            this.txtPidfile.TextChanged += new System.EventHandler(this.txtPidfile_TextChanged);
            this.txtPidfile.DoubleClick += new System.EventHandler(this.txtPidfile_DoubleClick);
            this.txtPidfile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPidfile_KeyPress);
            // 
            // lblConsoleLogfile
            // 
            this.lblConsoleLogfile.AutoSize = true;
            this.lblConsoleLogfile.Location = new System.Drawing.Point(32, 45);
            this.lblConsoleLogfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsoleLogfile.Name = "lblConsoleLogfile";
            this.lblConsoleLogfile.Size = new System.Drawing.Size(118, 20);
            this.lblConsoleLogfile.TabIndex = 27;
            this.lblConsoleLogfile.Text = "Console Logfile";
            // 
            // chkNetlog
            // 
            this.chkNetlog.AutoSize = true;
            this.chkNetlog.Location = new System.Drawing.Point(122, 228);
            this.chkNetlog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNetlog.Name = "chkNetlog";
            this.chkNetlog.Size = new System.Drawing.Size(22, 21);
            this.chkNetlog.TabIndex = 10;
            this.chkNetlog.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.chkNetlog, "Enable multiplayer network traffic logging.\r\nThe file \'net.log\' is created in gam" +
        "e folder.");
            this.chkNetlog.UseVisualStyleBackColor = true;
            this.chkNetlog.CheckedChanged += new System.EventHandler(this.chkNetlog_CheckedChanged);
            // 
            // lblMaxPLayers
            // 
            this.lblMaxPLayers.AutoSize = true;
            this.lblMaxPLayers.Location = new System.Drawing.Point(513, 111);
            this.lblMaxPLayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxPLayers.Name = "lblMaxPLayers";
            this.lblMaxPLayers.Size = new System.Drawing.Size(93, 20);
            this.lblMaxPLayers.TabIndex = 55;
            this.lblMaxPLayers.Text = "Max Players";
            // 
            // numMaxPlayers
            // 
            this.numMaxPlayers.Location = new System.Drawing.Point(614, 105);
            this.numMaxPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numMaxPlayers.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMaxPlayers.Name = "numMaxPlayers";
            this.numMaxPlayers.Size = new System.Drawing.Size(98, 26);
            this.numMaxPlayers.TabIndex = 3;
            this.toolTip1.SetToolTip(this.numMaxPlayers, "The maximum number of players that can connect to server.\r\nThe mission player slo" +
        "ts override this setting.\r\n");
            this.numMaxPlayers.ValueChanged += new System.EventHandler(this.numMaxPlayers_ValueChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(570, 71);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 20);
            this.lblPort.TabIndex = 53;
            this.lblPort.Text = "Port";
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Location = new System.Drawing.Point(22, 109);
            this.lblAdminPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(127, 20);
            this.lblAdminPassword.TabIndex = 49;
            this.lblAdminPassword.Text = "Admin Password";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(154, 103);
            this.txtAdminPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(300, 26);
            this.txtAdminPassword.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtAdminPassword, "Password to login as administrator on server.\r\nUse \'#login password\' in game chat" +
        "\r\n");
            this.txtAdminPassword.TextChanged += new System.EventHandler(this.txtAdminPassword_TextChanged);
            this.txtAdminPassword.DoubleClick += new System.EventHandler(this.txtAdminPassword_DoubleClick);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(154, 63);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 26);
            this.txtPassword.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPassword, "Password used by players to connect to server.");
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.DoubleClick += new System.EventHandler(this.txtPassword_DoubleClick);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(70, 69);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 47;
            this.lblPassword.Text = "Password";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(46, 29);
            this.lblHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(101, 20);
            this.lblHostName.TabIndex = 45;
            this.lblHostName.Text = "Server Name";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(154, 23);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(662, 26);
            this.txtServerName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtServerName, "Servername visible in the game browser.");
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            this.txtServerName.DoubleClick += new System.EventHandler(this.txtServerName_DoubleClick);
            // 
            // tabServerRules
            // 
            this.tabServerRules.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabServerRules.Controls.Add(this.chkKickClientsOnSlowNetwork);
            this.tabServerRules.Controls.Add(this.label26);
            this.tabServerRules.Controls.Add(this.label25);
            this.tabServerRules.Controls.Add(this.label21);
            this.tabServerRules.Controls.Add(this.cmbKickClientsOnSlowNetwork);
            this.tabServerRules.Controls.Add(this.numMaxPing);
            this.tabServerRules.Controls.Add(this.chkMaxPing);
            this.tabServerRules.Controls.Add(this.numMaxDesync);
            this.tabServerRules.Controls.Add(this.chkMaxDesync);
            this.tabServerRules.Controls.Add(this.numMaxPacketLoss);
            this.tabServerRules.Controls.Add(this.chkMaxPacketloss);
            this.tabServerRules.Controls.Add(this.chkDisconnectTimeout);
            this.tabServerRules.Controls.Add(this.numDisconnectTimeOut);
            this.tabServerRules.Controls.Add(this.chkBattlEye);
            this.tabServerRules.Controls.Add(this.label19);
            this.tabServerRules.Controls.Add(this.cmbAllowedFilePatching);
            this.tabServerRules.Controls.Add(this.label14);
            this.tabServerRules.Controls.Add(this.cmbVerifySignatures);
            this.tabServerRules.Controls.Add(this.txtRequiredBuild);
            this.tabServerRules.Controls.Add(this.chkRequiredBuild);
            this.tabServerRules.Controls.Add(this.grpMotd);
            this.tabServerRules.Controls.Add(this.grpVoting);
            this.tabServerRules.Controls.Add(this.chkKickDuplicates);
            this.tabServerRules.ImageIndex = 1;
            this.tabServerRules.Location = new System.Drawing.Point(4, 29);
            this.tabServerRules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabServerRules.Name = "tabServerRules";
            this.tabServerRules.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabServerRules.Size = new System.Drawing.Size(850, 581);
            this.tabServerRules.TabIndex = 1;
            this.tabServerRules.Text = "Rules";
            // 
            // chkKickClientsOnSlowNetwork
            // 
            this.chkKickClientsOnSlowNetwork.AutoSize = true;
            this.chkKickClientsOnSlowNetwork.Location = new System.Drawing.Point(10, 503);
            this.chkKickClientsOnSlowNetwork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKickClientsOnSlowNetwork.Name = "chkKickClientsOnSlowNetwork";
            this.chkKickClientsOnSlowNetwork.Size = new System.Drawing.Size(179, 44);
            this.chkKickClientsOnSlowNetwork.TabIndex = 86;
            this.chkKickClientsOnSlowNetwork.Text = "Kick Clients On Slow\r\nNetwork";
            this.toolTip1.SetToolTip(this.chkKickClientsOnSlowNetwork, "Optional setting for handling  maxPing, maxDesync, \r\nmaxPacketloss and disconnect" +
        "Timeout commands\r\n0 - Will only log warnings\r\n1 - Will log warnings and kick cli" +
        "ents\r\n\r\nDefault is off");
            this.chkKickClientsOnSlowNetwork.UseVisualStyleBackColor = true;
            this.chkKickClientsOnSlowNetwork.CheckedChanged += new System.EventHandler(this.chkKickClientsOnSlowNetwork_CheckedChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(272, 469);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 20);
            this.label26.TabIndex = 84;
            this.label26.Text = "seconds";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(278, 434);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 20);
            this.label25.TabIndex = 83;
            this.label25.Text = "%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(272, 362);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 20);
            this.label21.TabIndex = 82;
            this.label21.Text = "ms";
            // 
            // cmbKickClientsOnSlowNetwork
            // 
            this.cmbKickClientsOnSlowNetwork.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbKickClientsOnSlowNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKickClientsOnSlowNetwork.Enabled = false;
            this.cmbKickClientsOnSlowNetwork.FormattingEnabled = true;
            this.cmbKickClientsOnSlowNetwork.Items.AddRange(new object[] {
            "0 - Log only ",
            "1 - Log & kick"});
            this.cmbKickClientsOnSlowNetwork.Location = new System.Drawing.Point(206, 506);
            this.cmbKickClientsOnSlowNetwork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbKickClientsOnSlowNetwork.Name = "cmbKickClientsOnSlowNetwork";
            this.cmbKickClientsOnSlowNetwork.Size = new System.Drawing.Size(134, 28);
            this.cmbKickClientsOnSlowNetwork.TabIndex = 80;
            this.toolTip1.SetToolTip(this.cmbKickClientsOnSlowNetwork, "Optional setting for handling  maxPing, maxDesync, \r\nmaxPacketloss and disconnect" +
        "Timeout commands\r\n0 - Will only log warnings\r\n1 - Will log warnings and kick cli" +
        "ents\r\n\r\nDefault is off\r\n");
            this.cmbKickClientsOnSlowNetwork.SelectedIndexChanged += new System.EventHandler(this.cmbKickClientsOnSlowNetwork_SelectedIndexChanged);
            // 
            // numMaxPing
            // 
            this.numMaxPing.Enabled = false;
            this.numMaxPing.Location = new System.Drawing.Point(206, 355);
            this.numMaxPing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numMaxPing.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMaxPing.Name = "numMaxPing";
            this.numMaxPing.Size = new System.Drawing.Size(63, 26);
            this.numMaxPing.TabIndex = 77;
            this.toolTip1.SetToolTip(this.numMaxPing, "Sets default value for server command #MaxPing\r\n\r\nDefault is 0 (disabled)\r\n");
            this.numMaxPing.ValueChanged += new System.EventHandler(this.numMaxPing_ValueChanged);
            // 
            // chkMaxPing
            // 
            this.chkMaxPing.AutoSize = true;
            this.chkMaxPing.Location = new System.Drawing.Point(10, 360);
            this.chkMaxPing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMaxPing.Name = "chkMaxPing";
            this.chkMaxPing.Size = new System.Drawing.Size(99, 24);
            this.chkMaxPing.TabIndex = 76;
            this.chkMaxPing.Text = "Max Ping";
            this.toolTip1.SetToolTip(this.chkMaxPing, "Sets default value for server command #MaxPing\r\n\r\nDefault is 0 (disabled)");
            this.chkMaxPing.UseVisualStyleBackColor = true;
            this.chkMaxPing.CheckedChanged += new System.EventHandler(this.chkMaxPing_CheckedChanged);
            // 
            // numMaxDesync
            // 
            this.numMaxDesync.Enabled = false;
            this.numMaxDesync.Location = new System.Drawing.Point(206, 391);
            this.numMaxDesync.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numMaxDesync.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMaxDesync.Name = "numMaxDesync";
            this.numMaxDesync.Size = new System.Drawing.Size(63, 26);
            this.numMaxDesync.TabIndex = 75;
            this.toolTip1.SetToolTip(this.numMaxDesync, "Sets default value for server command #MaxDesync.\r\nMaximal threshold value is 100" +
        "k (100000).\r\n\r\nDefault: 0");
            this.numMaxDesync.ValueChanged += new System.EventHandler(this.numMaxDesync_ValueChanged);
            // 
            // chkMaxDesync
            // 
            this.chkMaxDesync.AutoSize = true;
            this.chkMaxDesync.Location = new System.Drawing.Point(10, 395);
            this.chkMaxDesync.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMaxDesync.Name = "chkMaxDesync";
            this.chkMaxDesync.Size = new System.Drawing.Size(121, 24);
            this.chkMaxDesync.TabIndex = 74;
            this.chkMaxDesync.Text = "Max Desync";
            this.toolTip1.SetToolTip(this.chkMaxDesync, "Sets default value for server command #MaxDesync.\r\nMaximal threshold value is 100" +
        "k (100000).\r\n\r\nDefault: 0");
            this.chkMaxDesync.UseVisualStyleBackColor = true;
            this.chkMaxDesync.CheckedChanged += new System.EventHandler(this.chkMaxDesync_CheckedChanged);
            // 
            // numMaxPacketLoss
            // 
            this.numMaxPacketLoss.Enabled = false;
            this.numMaxPacketLoss.Location = new System.Drawing.Point(206, 428);
            this.numMaxPacketLoss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numMaxPacketLoss.Name = "numMaxPacketLoss";
            this.numMaxPacketLoss.Size = new System.Drawing.Size(63, 26);
            this.numMaxPacketLoss.TabIndex = 73;
            this.toolTip1.SetToolTip(this.numMaxPacketLoss, "Sets default value for server command #MaxPacketloss.\r\nValue is percents 0-100\r\n\r" +
        "\nDefault: 0\r\n");
            this.numMaxPacketLoss.ValueChanged += new System.EventHandler(this.numMaxPacketLoss_ValueChanged);
            // 
            // chkMaxPacketloss
            // 
            this.chkMaxPacketloss.AutoSize = true;
            this.chkMaxPacketloss.Location = new System.Drawing.Point(10, 432);
            this.chkMaxPacketloss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMaxPacketloss.Name = "chkMaxPacketloss";
            this.chkMaxPacketloss.Size = new System.Drawing.Size(155, 24);
            this.chkMaxPacketloss.TabIndex = 72;
            this.chkMaxPacketloss.Text = "Max Packet Loss";
            this.toolTip1.SetToolTip(this.chkMaxPacketloss, "Sets default value for server command #MaxPacketloss.\r\nValue is percents 0-100\r\n\r" +
        "\nDefault: 0");
            this.chkMaxPacketloss.UseVisualStyleBackColor = true;
            this.chkMaxPacketloss.CheckedChanged += new System.EventHandler(this.chkMaxPacketloss_CheckedChanged);
            // 
            // chkDisconnectTimeout
            // 
            this.chkDisconnectTimeout.AutoSize = true;
            this.chkDisconnectTimeout.Location = new System.Drawing.Point(10, 468);
            this.chkDisconnectTimeout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDisconnectTimeout.Name = "chkDisconnectTimeout";
            this.chkDisconnectTimeout.Size = new System.Drawing.Size(176, 24);
            this.chkDisconnectTimeout.TabIndex = 71;
            this.chkDisconnectTimeout.Text = "Disconnect Timeout";
            this.toolTip1.SetToolTip(this.chkDisconnectTimeout, "Sets default value for server #disconnectTimeout.\r\nValue is threshold in seconds\r" +
        "\n\r\nDefault: 0\r\n");
            this.chkDisconnectTimeout.UseVisualStyleBackColor = true;
            this.chkDisconnectTimeout.CheckedChanged += new System.EventHandler(this.chkDisonnectTimeout_CheckedChanged);
            // 
            // numDisconnectTimeOut
            // 
            this.numDisconnectTimeOut.Enabled = false;
            this.numDisconnectTimeOut.Location = new System.Drawing.Point(206, 463);
            this.numDisconnectTimeOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numDisconnectTimeOut.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numDisconnectTimeOut.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDisconnectTimeOut.Name = "numDisconnectTimeOut";
            this.numDisconnectTimeOut.Size = new System.Drawing.Size(63, 26);
            this.numDisconnectTimeOut.TabIndex = 39;
            this.toolTip1.SetToolTip(this.numDisconnectTimeOut, "Sets default value for server #disconnectTimeout.\r\nValue is threshold in seconds\r" +
        "\n\r\nDefault: 0");
            this.numDisconnectTimeOut.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numDisconnectTimeOut.ValueChanged += new System.EventHandler(this.numDisconnectTimeOut_ValueChanged);
            // 
            // chkBattlEye
            // 
            this.chkBattlEye.AutoSize = true;
            this.chkBattlEye.Location = new System.Drawing.Point(10, 325);
            this.chkBattlEye.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBattlEye.Name = "chkBattlEye";
            this.chkBattlEye.Size = new System.Drawing.Size(95, 24);
            this.chkBattlEye.TabIndex = 69;
            this.chkBattlEye.Text = "BattlEye";
            this.toolTip1.SetToolTip(this.chkBattlEye, "Enables or disables the BattlEye anti-cheat engine. \r\nNote that this requires spe" +
        "cific dlls to be installed on the server and all clients joining the game.\r\n\r\nDe" +
        "fault is off");
            this.chkBattlEye.UseVisualStyleBackColor = true;
            this.chkBattlEye.CheckedChanged += new System.EventHandler(this.chkBattlEye_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 212);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(159, 20);
            this.label19.TabIndex = 52;
            this.label19.Text = "Allowed File Patching";
            // 
            // cmbAllowedFilePatching
            // 
            this.cmbAllowedFilePatching.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllowedFilePatching.FormattingEnabled = true;
            this.cmbAllowedFilePatching.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbAllowedFilePatching.Location = new System.Drawing.Point(206, 208);
            this.cmbAllowedFilePatching.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAllowedFilePatching.Name = "cmbAllowedFilePatching";
            this.cmbAllowedFilePatching.Size = new System.Drawing.Size(134, 28);
            this.cmbAllowedFilePatching.TabIndex = 51;
            this.cmbAllowedFilePatching.SelectedIndexChanged += new System.EventHandler(this.cmbAllowedFilePatching_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 171);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Verify Signatures";
            // 
            // cmbVerifySignatures
            // 
            this.cmbVerifySignatures.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbVerifySignatures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVerifySignatures.FormattingEnabled = true;
            this.cmbVerifySignatures.Items.AddRange(new object[] {
            "none",
            "v1",
            "v2"});
            this.cmbVerifySignatures.Location = new System.Drawing.Point(206, 166);
            this.cmbVerifySignatures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVerifySignatures.Name = "cmbVerifySignatures";
            this.cmbVerifySignatures.Size = new System.Drawing.Size(134, 28);
            this.cmbVerifySignatures.TabIndex = 45;
            this.cmbVerifySignatures.SelectedIndexChanged += new System.EventHandler(this.cmbVerifySignatures_SelectedIndexChanged);
            // 
            // txtRequiredBuild
            // 
            this.txtRequiredBuild.Enabled = false;
            this.txtRequiredBuild.Location = new System.Drawing.Point(206, 249);
            this.txtRequiredBuild.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRequiredBuild.MaxLength = 6;
            this.txtRequiredBuild.Name = "txtRequiredBuild";
            this.txtRequiredBuild.Size = new System.Drawing.Size(134, 26);
            this.txtRequiredBuild.TabIndex = 44;
            this.txtRequiredBuild.TextChanged += new System.EventHandler(this.txtRequiredBuild_TextChanged);
            this.txtRequiredBuild.DoubleClick += new System.EventHandler(this.txtRequiredBuild_DoubleClick);
            this.txtRequiredBuild.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRequiredBuild_KeyPress);
            // 
            // chkRequiredBuild
            // 
            this.chkRequiredBuild.AutoSize = true;
            this.chkRequiredBuild.Location = new System.Drawing.Point(10, 252);
            this.chkRequiredBuild.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRequiredBuild.Name = "chkRequiredBuild";
            this.chkRequiredBuild.Size = new System.Drawing.Size(139, 24);
            this.chkRequiredBuild.TabIndex = 43;
            this.chkRequiredBuild.Text = "Required Build";
            this.chkRequiredBuild.UseVisualStyleBackColor = true;
            this.chkRequiredBuild.CheckedChanged += new System.EventHandler(this.chkRequiredBuild_CheckedChanged);
            // 
            // grpMotd
            // 
            this.grpMotd.Controls.Add(this.lblMotdInterval);
            this.grpMotd.Controls.Add(this.numMotdInterval);
            this.grpMotd.Controls.Add(this.txtMotd);
            this.grpMotd.Location = new System.Drawing.Point(351, 18);
            this.grpMotd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMotd.Name = "grpMotd";
            this.grpMotd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMotd.Size = new System.Drawing.Size(483, 529);
            this.grpMotd.TabIndex = 42;
            this.grpMotd.TabStop = false;
            this.grpMotd.Text = "Message Of The Day";
            // 
            // lblMotdInterval
            // 
            this.lblMotdInterval.AutoSize = true;
            this.lblMotdInterval.Location = new System.Drawing.Point(170, 488);
            this.lblMotdInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotdInterval.Name = "lblMotdInterval";
            this.lblMotdInterval.Size = new System.Drawing.Size(214, 20);
            this.lblMotdInterval.TabIndex = 37;
            this.lblMotdInterval.Text = "Seconds between messages";
            // 
            // numMotdInterval
            // 
            this.numMotdInterval.Location = new System.Drawing.Point(393, 485);
            this.numMotdInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numMotdInterval.Maximum = new decimal(new int[] {
            31536000,
            0,
            0,
            0});
            this.numMotdInterval.Name = "numMotdInterval";
            this.numMotdInterval.Size = new System.Drawing.Size(81, 26);
            this.numMotdInterval.TabIndex = 6;
            this.numMotdInterval.ValueChanged += new System.EventHandler(this.numMotdInterval_ValueChanged);
            // 
            // txtMotd
            // 
            this.txtMotd.AllowDrop = true;
            this.txtMotd.Location = new System.Drawing.Point(9, 34);
            this.txtMotd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMotd.Multiline = true;
            this.txtMotd.Name = "txtMotd";
            this.txtMotd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMotd.Size = new System.Drawing.Size(463, 444);
            this.txtMotd.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtMotd, "MOTD will scroll by in the server chat, line by line.\r\nBlank lines will count as " +
        "emtpy linebreak and takr the time of\r\na normal line.");
            this.txtMotd.WordWrap = false;
            this.txtMotd.TextChanged += new System.EventHandler(this.txtMotd_TextChanged);
            // 
            // grpVoting
            // 
            this.grpVoting.Controls.Add(this.lblVotingEnabled);
            this.grpVoting.Controls.Add(this.chkEnableVoting);
            this.grpVoting.Controls.Add(this.lblVoteMissionPlayers);
            this.grpVoting.Controls.Add(this.numVoteMissionPlayers);
            this.grpVoting.Controls.Add(this.lblVoteThreshold);
            this.grpVoting.Controls.Add(this.numVoteThreshold);
            this.grpVoting.Location = new System.Drawing.Point(15, 18);
            this.grpVoting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVoting.Name = "grpVoting";
            this.grpVoting.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVoting.Size = new System.Drawing.Size(327, 138);
            this.grpVoting.TabIndex = 41;
            this.grpVoting.TabStop = false;
            this.grpVoting.Text = "Voting";
            // 
            // lblVotingEnabled
            // 
            this.lblVotingEnabled.AutoSize = true;
            this.lblVotingEnabled.Location = new System.Drawing.Point(87, 25);
            this.lblVotingEnabled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVotingEnabled.Name = "lblVotingEnabled";
            this.lblVotingEnabled.Size = new System.Drawing.Size(118, 20);
            this.lblVotingEnabled.TabIndex = 38;
            this.lblVotingEnabled.Text = "Voting Enabled";
            // 
            // chkEnableVoting
            // 
            this.chkEnableVoting.AutoSize = true;
            this.chkEnableVoting.Location = new System.Drawing.Point(214, 23);
            this.chkEnableVoting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEnableVoting.Name = "chkEnableVoting";
            this.chkEnableVoting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkEnableVoting.Size = new System.Drawing.Size(22, 21);
            this.chkEnableVoting.TabIndex = 37;
            this.chkEnableVoting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.chkEnableVoting, "Enable mission voting on server");
            this.chkEnableVoting.UseVisualStyleBackColor = true;
            this.chkEnableVoting.CheckedChanged += new System.EventHandler(this.chkEnableVoting_CheckedChanged);
            // 
            // lblVoteMissionPlayers
            // 
            this.lblVoteMissionPlayers.AutoSize = true;
            this.lblVoteMissionPlayers.Location = new System.Drawing.Point(51, 58);
            this.lblVoteMissionPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoteMissionPlayers.Name = "lblVoteMissionPlayers";
            this.lblVoteMissionPlayers.Size = new System.Drawing.Size(159, 20);
            this.lblVoteMissionPlayers.TabIndex = 3;
            this.lblVoteMissionPlayers.Text = "Vote Mission Players ";
            // 
            // numVoteMissionPlayers
            // 
            this.numVoteMissionPlayers.Enabled = false;
            this.numVoteMissionPlayers.Location = new System.Drawing.Point(214, 54);
            this.numVoteMissionPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numVoteMissionPlayers.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numVoteMissionPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVoteMissionPlayers.Name = "numVoteMissionPlayers";
            this.numVoteMissionPlayers.Size = new System.Drawing.Size(63, 26);
            this.numVoteMissionPlayers.TabIndex = 1;
            this.numVoteMissionPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVoteMissionPlayers.ValueChanged += new System.EventHandler(this.numVoteMissionPlayers_ValueChanged);
            // 
            // lblVoteThreshold
            // 
            this.lblVoteThreshold.AutoSize = true;
            this.lblVoteThreshold.Location = new System.Drawing.Point(76, 98);
            this.lblVoteThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoteThreshold.Name = "lblVoteThreshold";
            this.lblVoteThreshold.Size = new System.Drawing.Size(135, 20);
            this.lblVoteThreshold.TabIndex = 1;
            this.lblVoteThreshold.Text = "Vote Threshold %";
            // 
            // numVoteThreshold
            // 
            this.numVoteThreshold.Enabled = false;
            this.numVoteThreshold.Location = new System.Drawing.Point(214, 94);
            this.numVoteThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numVoteThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVoteThreshold.Name = "numVoteThreshold";
            this.numVoteThreshold.Size = new System.Drawing.Size(63, 26);
            this.numVoteThreshold.TabIndex = 2;
            this.numVoteThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVoteThreshold.ValueChanged += new System.EventHandler(this.numVoteThreshold_ValueChanged);
            // 
            // chkKickDuplicates
            // 
            this.chkKickDuplicates.AutoSize = true;
            this.chkKickDuplicates.Location = new System.Drawing.Point(10, 289);
            this.chkKickDuplicates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKickDuplicates.Name = "chkKickDuplicates";
            this.chkKickDuplicates.Size = new System.Drawing.Size(143, 24);
            this.chkKickDuplicates.TabIndex = 40;
            this.chkKickDuplicates.Text = "Kick Duplicates";
            this.chkKickDuplicates.UseVisualStyleBackColor = true;
            this.chkKickDuplicates.CheckedChanged += new System.EventHandler(this.chkKickDuplicates_CheckedChanged);
            // 
            // tabMissions
            // 
            this.tabMissions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabMissions.Controls.Add(this.grpMissions);
            this.tabMissions.ImageIndex = 2;
            this.tabMissions.Location = new System.Drawing.Point(4, 29);
            this.tabMissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMissions.Name = "tabMissions";
            this.tabMissions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMissions.Size = new System.Drawing.Size(850, 581);
            this.tabMissions.TabIndex = 2;
            this.tabMissions.Text = "Missions";
            // 
            // grpMissions
            // 
            this.grpMissions.Controls.Add(this.btnAllMissionsDiff);
            this.grpMissions.Controls.Add(this.btnSort);
            this.grpMissions.Controls.Add(this.lblSelectedMissions);
            this.grpMissions.Controls.Add(this.lblNumOfMissions);
            this.grpMissions.Controls.Add(this.btnMissionDown);
            this.grpMissions.Controls.Add(this.btnMissionUp);
            this.grpMissions.Controls.Add(this.lblMissionFilter);
            this.grpMissions.Controls.Add(this.cmbMissionFilter);
            this.grpMissions.Controls.Add(this.lblDifficulty);
            this.grpMissions.Controls.Add(this.cmbDifficulty);
            this.grpMissions.Controls.Add(this.lblSelected);
            this.grpMissions.Controls.Add(this.lblAvailableMissions);
            this.grpMissions.Controls.Add(this.btnRefreshMissions);
            this.grpMissions.Controls.Add(this.btnSelectNoneMissions);
            this.grpMissions.Controls.Add(this.btnSelectAllMissions);
            this.grpMissions.Controls.Add(this.btnInvertMissionSelection);
            this.grpMissions.Controls.Add(this.lstMissions);
            this.grpMissions.Location = new System.Drawing.Point(18, 17);
            this.grpMissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMissions.Name = "grpMissions";
            this.grpMissions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMissions.Size = new System.Drawing.Size(812, 546);
            this.grpMissions.TabIndex = 4;
            this.grpMissions.TabStop = false;
            this.grpMissions.Text = "Mission Cycle List";
            // 
            // btnAllMissionsDiff
            // 
            this.btnAllMissionsDiff.ImageIndex = 17;
            this.btnAllMissionsDiff.ImageList = this.imageList1;
            this.btnAllMissionsDiff.Location = new System.Drawing.Point(528, 498);
            this.btnAllMissionsDiff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAllMissionsDiff.Name = "btnAllMissionsDiff";
            this.btnAllMissionsDiff.Size = new System.Drawing.Size(45, 38);
            this.btnAllMissionsDiff.TabIndex = 52;
            this.btnAllMissionsDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAllMissionsDiff, "Apply selected difficulty to all missions");
            this.btnAllMissionsDiff.UseVisualStyleBackColor = true;
            this.btnAllMissionsDiff.Click += new System.EventHandler(this.btnAllMissionsDiff_Click);
            // 
            // btnSort
            // 
            this.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSort.ImageIndex = 16;
            this.btnSort.ImageList = this.imageList1;
            this.btnSort.Location = new System.Drawing.Point(604, 498);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(80, 38);
            this.btnSort.TabIndex = 51;
            this.btnSort.Text = "Sort";
            this.btnSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSort, "Sort missions by name");
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblSelectedMissions
            // 
            this.lblSelectedMissions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedMissions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedMissions.Location = new System.Drawing.Point(729, 25);
            this.lblSelectedMissions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedMissions.Name = "lblSelectedMissions";
            this.lblSelectedMissions.Size = new System.Drawing.Size(64, 31);
            this.lblSelectedMissions.TabIndex = 50;
            this.lblSelectedMissions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblSelectedMissions, "Amount of selected missions");
            // 
            // lblNumOfMissions
            // 
            this.lblNumOfMissions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumOfMissions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumOfMissions.Location = new System.Drawing.Point(576, 25);
            this.lblNumOfMissions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfMissions.Name = "lblNumOfMissions";
            this.lblNumOfMissions.Size = new System.Drawing.Size(64, 31);
            this.lblNumOfMissions.TabIndex = 49;
            this.lblNumOfMissions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblNumOfMissions, "Amount of available missions");
            // 
            // btnMissionDown
            // 
            this.btnMissionDown.ImageIndex = 15;
            this.btnMissionDown.ImageList = this.imageList1;
            this.btnMissionDown.Location = new System.Drawing.Point(278, 498);
            this.btnMissionDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMissionDown.Name = "btnMissionDown";
            this.btnMissionDown.Size = new System.Drawing.Size(45, 38);
            this.btnMissionDown.TabIndex = 48;
            this.btnMissionDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMissionDown.UseVisualStyleBackColor = true;
            this.btnMissionDown.Click += new System.EventHandler(this.btnMissionDown_Click);
            // 
            // btnMissionUp
            // 
            this.btnMissionUp.ImageIndex = 14;
            this.btnMissionUp.ImageList = this.imageList1;
            this.btnMissionUp.Location = new System.Drawing.Point(224, 498);
            this.btnMissionUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMissionUp.Name = "btnMissionUp";
            this.btnMissionUp.Size = new System.Drawing.Size(45, 38);
            this.btnMissionUp.TabIndex = 47;
            this.btnMissionUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMissionUp.UseVisualStyleBackColor = true;
            this.btnMissionUp.Click += new System.EventHandler(this.btnMissionUp_Click);
            // 
            // lblMissionFilter
            // 
            this.lblMissionFilter.AutoSize = true;
            this.lblMissionFilter.Location = new System.Drawing.Point(165, 32);
            this.lblMissionFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMissionFilter.Name = "lblMissionFilter";
            this.lblMissionFilter.Size = new System.Drawing.Size(109, 20);
            this.lblMissionFilter.TabIndex = 46;
            this.lblMissionFilter.Text = "Filter by island";
            // 
            // cmbMissionFilter
            // 
            this.cmbMissionFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMissionFilter.FormattingEnabled = true;
            this.cmbMissionFilter.Location = new System.Drawing.Point(278, 26);
            this.cmbMissionFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMissionFilter.Name = "cmbMissionFilter";
            this.cmbMissionFilter.Size = new System.Drawing.Size(194, 28);
            this.cmbMissionFilter.TabIndex = 45;
            this.cmbMissionFilter.SelectionChangeCommitted += new System.EventHandler(this.cmbMissionFilter_SelectionChangeCommitted);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(346, 508);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(69, 20);
            this.lblDifficulty.TabIndex = 44;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "recruit",
            "regular",
            "veteran",
            "custom"});
            this.cmbDifficulty.Location = new System.Drawing.Point(420, 502);
            this.cmbDifficulty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(98, 28);
            this.cmbDifficulty.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cmbDifficulty, "Set the difficulty for cycled missions");
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(652, 29);
            this.lblSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(72, 20);
            this.lblSelected.TabIndex = 9;
            this.lblSelected.Text = "Selected";
            // 
            // lblAvailableMissions
            // 
            this.lblAvailableMissions.AutoSize = true;
            this.lblAvailableMissions.Location = new System.Drawing.Point(498, 29);
            this.lblAvailableMissions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableMissions.Name = "lblAvailableMissions";
            this.lblAvailableMissions.Size = new System.Drawing.Size(72, 20);
            this.lblAvailableMissions.TabIndex = 7;
            this.lblAvailableMissions.Text = "Available";
            // 
            // btnRefreshMissions
            // 
            this.btnRefreshMissions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshMissions.ImageIndex = 10;
            this.btnRefreshMissions.ImageList = this.imageList1;
            this.btnRefreshMissions.Location = new System.Drawing.Point(693, 498);
            this.btnRefreshMissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshMissions.Name = "btnRefreshMissions";
            this.btnRefreshMissions.Size = new System.Drawing.Size(100, 38);
            this.btnRefreshMissions.TabIndex = 6;
            this.btnRefreshMissions.Text = "Refresh";
            this.btnRefreshMissions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRefreshMissions, "Refresh the missions list");
            this.btnRefreshMissions.UseVisualStyleBackColor = true;
            this.btnRefreshMissions.Click += new System.EventHandler(this.btnRefreshMissions_Click);
            // 
            // btnSelectNoneMissions
            // 
            this.btnSelectNoneMissions.Location = new System.Drawing.Point(76, 498);
            this.btnSelectNoneMissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectNoneMissions.Name = "btnSelectNoneMissions";
            this.btnSelectNoneMissions.Size = new System.Drawing.Size(64, 38);
            this.btnSelectNoneMissions.TabIndex = 3;
            this.btnSelectNoneMissions.Text = "None";
            this.btnSelectNoneMissions.UseVisualStyleBackColor = true;
            this.btnSelectNoneMissions.Click += new System.EventHandler(this.btnSelectNoneMissions_Click);
            // 
            // btnSelectAllMissions
            // 
            this.btnSelectAllMissions.Location = new System.Drawing.Point(21, 498);
            this.btnSelectAllMissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllMissions.Name = "btnSelectAllMissions";
            this.btnSelectAllMissions.Size = new System.Drawing.Size(46, 38);
            this.btnSelectAllMissions.TabIndex = 2;
            this.btnSelectAllMissions.Text = "All";
            this.btnSelectAllMissions.UseVisualStyleBackColor = true;
            this.btnSelectAllMissions.Click += new System.EventHandler(this.btnSelectAllMissions_Click);
            // 
            // btnInvertMissionSelection
            // 
            this.btnInvertMissionSelection.Location = new System.Drawing.Point(150, 498);
            this.btnInvertMissionSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInvertMissionSelection.Name = "btnInvertMissionSelection";
            this.btnInvertMissionSelection.Size = new System.Drawing.Size(64, 38);
            this.btnInvertMissionSelection.TabIndex = 4;
            this.btnInvertMissionSelection.Text = "Invert";
            this.btnInvertMissionSelection.UseVisualStyleBackColor = true;
            this.btnInvertMissionSelection.Click += new System.EventHandler(this.btnInvertMissionSelection_Click);
            // 
            // lstMissions
            // 
            this.lstMissions.AllowDrop = true;
            this.lstMissions.CheckOnClick = true;
            this.lstMissions.FormattingEnabled = true;
            this.lstMissions.HorizontalScrollbar = true;
            this.lstMissions.Location = new System.Drawing.Point(21, 80);
            this.lstMissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMissions.Name = "lstMissions";
            this.lstMissions.Size = new System.Drawing.Size(770, 395);
            this.lstMissions.TabIndex = 1;
            this.lstMissions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstMissions_ItemCheck);
            this.lstMissions.SelectedIndexChanged += new System.EventHandler(this.lstMissions_SelectedIndexChanged);
            this.lstMissions.DragOver += new System.Windows.Forms.DragEventHandler(this.lstMissions_DragOver);
            this.lstMissions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstMissions_MouseDown);
            this.lstMissions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstMissions_MouseUp);
            // 
            // tabMods
            // 
            this.tabMods.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabMods.Controls.Add(this.grpMods);
            this.tabMods.ImageIndex = 3;
            this.tabMods.Location = new System.Drawing.Point(4, 29);
            this.tabMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMods.Name = "tabMods";
            this.tabMods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMods.Size = new System.Drawing.Size(850, 581);
            this.tabMods.TabIndex = 3;
            this.tabMods.Text = "Mods";
            // 
            // grpMods
            // 
            this.grpMods.Controls.Add(this.btnSortMods);
            this.grpMods.Controls.Add(this.lblSelectedMods);
            this.grpMods.Controls.Add(this.lblNumOfMods);
            this.grpMods.Controls.Add(this.label3);
            this.grpMods.Controls.Add(this.label4);
            this.grpMods.Controls.Add(this.removeModBTN);
            this.grpMods.Controls.Add(this.modUpBTN);
            this.grpMods.Controls.Add(this.modDownBTN);
            this.grpMods.Controls.Add(this.btnSelectNoneMods);
            this.grpMods.Controls.Add(this.btnSelectAllMods);
            this.grpMods.Controls.Add(this.btnInvertMods);
            this.grpMods.Controls.Add(this.btnRefreshMods);
            this.grpMods.Controls.Add(this.btnAddModFolder);
            this.grpMods.Controls.Add(this.lstMods);
            this.grpMods.Location = new System.Drawing.Point(18, 15);
            this.grpMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMods.Name = "grpMods";
            this.grpMods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMods.Size = new System.Drawing.Size(812, 548);
            this.grpMods.TabIndex = 2;
            this.grpMods.TabStop = false;
            this.grpMods.Text = "Available Mods";
            // 
            // btnSortMods
            // 
            this.btnSortMods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortMods.ImageIndex = 16;
            this.btnSortMods.ImageList = this.imageList1;
            this.btnSortMods.Location = new System.Drawing.Point(604, 500);
            this.btnSortMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortMods.Name = "btnSortMods";
            this.btnSortMods.Size = new System.Drawing.Size(80, 38);
            this.btnSortMods.TabIndex = 55;
            this.btnSortMods.Text = "Sort";
            this.btnSortMods.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSortMods, "Sort mods by name");
            this.btnSortMods.UseVisualStyleBackColor = true;
            this.btnSortMods.Click += new System.EventHandler(this.btnSortMods_Click);
            // 
            // lblSelectedMods
            // 
            this.lblSelectedMods.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedMods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedMods.Location = new System.Drawing.Point(729, 26);
            this.lblSelectedMods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedMods.Name = "lblSelectedMods";
            this.lblSelectedMods.Size = new System.Drawing.Size(64, 31);
            this.lblSelectedMods.TabIndex = 54;
            this.lblSelectedMods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumOfMods
            // 
            this.lblNumOfMods.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumOfMods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumOfMods.Location = new System.Drawing.Point(576, 26);
            this.lblNumOfMods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfMods.Name = "lblNumOfMods";
            this.lblNumOfMods.Size = new System.Drawing.Size(64, 31);
            this.lblNumOfMods.TabIndex = 53;
            this.lblNumOfMods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Selected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Available";
            // 
            // removeModBTN
            // 
            this.removeModBTN.ImageIndex = 9;
            this.removeModBTN.ImageList = this.imageList1;
            this.removeModBTN.Location = new System.Drawing.Point(531, 500);
            this.removeModBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeModBTN.Name = "removeModBTN";
            this.removeModBTN.Size = new System.Drawing.Size(45, 38);
            this.removeModBTN.TabIndex = 20;
            this.toolTip1.SetToolTip(this.removeModBTN, "Hide selected folder from list. ");
            this.removeModBTN.UseVisualStyleBackColor = true;
            this.removeModBTN.Click += new System.EventHandler(this.removeModBTN_Click);
            // 
            // modUpBTN
            // 
            this.modUpBTN.ImageIndex = 14;
            this.modUpBTN.ImageList = this.imageList1;
            this.modUpBTN.Location = new System.Drawing.Point(224, 500);
            this.modUpBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modUpBTN.Name = "modUpBTN";
            this.modUpBTN.Size = new System.Drawing.Size(45, 38);
            this.modUpBTN.TabIndex = 19;
            this.modUpBTN.UseVisualStyleBackColor = true;
            this.modUpBTN.Click += new System.EventHandler(this.modUpBTN_Click);
            // 
            // modDownBTN
            // 
            this.modDownBTN.ImageIndex = 15;
            this.modDownBTN.ImageList = this.imageList1;
            this.modDownBTN.Location = new System.Drawing.Point(278, 500);
            this.modDownBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modDownBTN.Name = "modDownBTN";
            this.modDownBTN.Size = new System.Drawing.Size(45, 38);
            this.modDownBTN.TabIndex = 18;
            this.modDownBTN.UseVisualStyleBackColor = true;
            this.modDownBTN.Click += new System.EventHandler(this.modDownBTN_Click);
            // 
            // btnSelectNoneMods
            // 
            this.btnSelectNoneMods.Location = new System.Drawing.Point(76, 500);
            this.btnSelectNoneMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectNoneMods.Name = "btnSelectNoneMods";
            this.btnSelectNoneMods.Size = new System.Drawing.Size(64, 38);
            this.btnSelectNoneMods.TabIndex = 16;
            this.btnSelectNoneMods.Text = "None";
            this.btnSelectNoneMods.UseVisualStyleBackColor = true;
            this.btnSelectNoneMods.Click += new System.EventHandler(this.btnSelectNoneMods_Click);
            // 
            // btnSelectAllMods
            // 
            this.btnSelectAllMods.Location = new System.Drawing.Point(21, 500);
            this.btnSelectAllMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllMods.Name = "btnSelectAllMods";
            this.btnSelectAllMods.Size = new System.Drawing.Size(46, 38);
            this.btnSelectAllMods.TabIndex = 15;
            this.btnSelectAllMods.Text = "All";
            this.btnSelectAllMods.UseVisualStyleBackColor = true;
            this.btnSelectAllMods.Click += new System.EventHandler(this.btnSelectAllMods_Click);
            // 
            // btnInvertMods
            // 
            this.btnInvertMods.Location = new System.Drawing.Point(150, 500);
            this.btnInvertMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInvertMods.Name = "btnInvertMods";
            this.btnInvertMods.Size = new System.Drawing.Size(64, 38);
            this.btnInvertMods.TabIndex = 17;
            this.btnInvertMods.Text = "Invert";
            this.btnInvertMods.UseVisualStyleBackColor = true;
            this.btnInvertMods.Click += new System.EventHandler(this.btnInvertMods_Click);
            // 
            // btnRefreshMods
            // 
            this.btnRefreshMods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshMods.ImageIndex = 10;
            this.btnRefreshMods.ImageList = this.imageList1;
            this.btnRefreshMods.Location = new System.Drawing.Point(693, 500);
            this.btnRefreshMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshMods.Name = "btnRefreshMods";
            this.btnRefreshMods.Size = new System.Drawing.Size(100, 38);
            this.btnRefreshMods.TabIndex = 14;
            this.btnRefreshMods.Text = "Refresh";
            this.btnRefreshMods.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRefreshMods, "Refresh the mods list");
            this.btnRefreshMods.UseVisualStyleBackColor = true;
            this.btnRefreshMods.Click += new System.EventHandler(this.btnRefreshMods_Click);
            // 
            // btnAddModFolder
            // 
            this.btnAddModFolder.ImageIndex = 8;
            this.btnAddModFolder.ImageList = this.imageList1;
            this.btnAddModFolder.Location = new System.Drawing.Point(477, 500);
            this.btnAddModFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddModFolder.Name = "btnAddModFolder";
            this.btnAddModFolder.Size = new System.Drawing.Size(45, 38);
            this.btnAddModFolder.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAddModFolder, "Add mod folder from disk");
            this.btnAddModFolder.UseVisualStyleBackColor = true;
            this.btnAddModFolder.Click += new System.EventHandler(this.btnAddModFolder_Click);
            // 
            // lstMods
            // 
            this.lstMods.AllowDrop = true;
            this.lstMods.BackColor = System.Drawing.SystemColors.Window;
            this.lstMods.CheckOnClick = true;
            this.lstMods.FormattingEnabled = true;
            this.lstMods.Location = new System.Drawing.Point(21, 82);
            this.lstMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMods.Name = "lstMods";
            this.lstMods.Size = new System.Drawing.Size(770, 395);
            this.lstMods.TabIndex = 0;
            this.lstMods.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstMods_ItemCheck);
            this.lstMods.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstMods_DragDrop);
            this.lstMods.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstMods_DragEnter);
            this.lstMods.DragOver += new System.Windows.Forms.DragEventHandler(this.lstMods_DragOver);
            this.lstMods.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstMods_MouseDown);
            // 
            // tabDiffSettings
            // 
            this.tabDiffSettings.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabDiffSettings.Controls.Add(this.groupBox9);
            this.tabDiffSettings.Controls.Add(this.grpProfileDifficulty);
            this.tabDiffSettings.Controls.Add(this.label22);
            this.tabDiffSettings.Controls.Add(this.cmbDefaultDifficulty);
            this.tabDiffSettings.ImageIndex = 4;
            this.tabDiffSettings.Location = new System.Drawing.Point(4, 29);
            this.tabDiffSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDiffSettings.Name = "tabDiffSettings";
            this.tabDiffSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDiffSettings.Size = new System.Drawing.Size(850, 581);
            this.tabDiffSettings.TabIndex = 4;
            this.tabDiffSettings.Text = "Difficulty";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblProfileDifficultyInfo);
            this.groupBox9.Location = new System.Drawing.Point(546, 15);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Size = new System.Drawing.Size(284, 492);
            this.groupBox9.TabIndex = 33;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Info";
            // 
            // lblProfileDifficultyInfo
            // 
            this.lblProfileDifficultyInfo.Location = new System.Drawing.Point(9, 45);
            this.lblProfileDifficultyInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileDifficultyInfo.Name = "lblProfileDifficultyInfo";
            this.lblProfileDifficultyInfo.Size = new System.Drawing.Size(266, 425);
            this.lblProfileDifficultyInfo.TabIndex = 0;
            this.lblProfileDifficultyInfo.Click += new System.EventHandler(this.lblProfileDifficultyInfo_Click);
            // 
            // grpProfileDifficulty
            // 
            this.grpProfileDifficulty.Controls.Add(this.label10);
            this.grpProfileDifficulty.Controls.Add(this.cmbAILevelPreset);
            this.grpProfileDifficulty.Controls.Add(this.resetProfile);
            this.grpProfileDifficulty.Controls.Add(this.numPrecisionAI);
            this.grpProfileDifficulty.Controls.Add(this.numSkillAI);
            this.grpProfileDifficulty.Controls.Add(this.clbDifficultyItems);
            this.grpProfileDifficulty.Controls.Add(this.label9);
            this.grpProfileDifficulty.Controls.Add(this.label8);
            this.grpProfileDifficulty.Location = new System.Drawing.Point(18, 15);
            this.grpProfileDifficulty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpProfileDifficulty.Name = "grpProfileDifficulty";
            this.grpProfileDifficulty.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpProfileDifficulty.Size = new System.Drawing.Size(519, 548);
            this.grpProfileDifficulty.TabIndex = 32;
            this.grpProfileDifficulty.TabStop = false;
            this.grpProfileDifficulty.Text = "Custom Difficulty Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "AI Level Preset";
            // 
            // cmbAILevelPreset
            // 
            this.cmbAILevelPreset.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbAILevelPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAILevelPreset.FormattingEnabled = true;
            this.cmbAILevelPreset.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbAILevelPreset.Location = new System.Drawing.Point(422, 29);
            this.cmbAILevelPreset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAILevelPreset.Name = "cmbAILevelPreset";
            this.cmbAILevelPreset.Size = new System.Drawing.Size(80, 28);
            this.cmbAILevelPreset.TabIndex = 54;
            this.cmbAILevelPreset.SelectedIndexChanged += new System.EventHandler(this.cmbAILevelPreset_SelectedIndexChanged);
            this.cmbAILevelPreset.Click += new System.EventHandler(this.cmbAILevelPreset_Click);
            // 
            // resetProfile
            // 
            this.resetProfile.Location = new System.Drawing.Point(418, 485);
            this.resetProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetProfile.Name = "resetProfile";
            this.resetProfile.Size = new System.Drawing.Size(86, 35);
            this.resetProfile.TabIndex = 10;
            this.resetProfile.Text = "Reset";
            this.toolTip1.SetToolTip(this.resetProfile, "Reset selected difficulty settings to default");
            this.resetProfile.UseVisualStyleBackColor = true;
            this.resetProfile.Click += new System.EventHandler(this.resetProfile_Click);
            // 
            // numPrecisionAI
            // 
            this.numPrecisionAI.DecimalPlaces = 2;
            this.numPrecisionAI.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numPrecisionAI.Location = new System.Drawing.Point(424, 142);
            this.numPrecisionAI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPrecisionAI.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrecisionAI.Name = "numPrecisionAI";
            this.numPrecisionAI.Size = new System.Drawing.Size(80, 26);
            this.numPrecisionAI.TabIndex = 46;
            this.numPrecisionAI.ValueChanged += new System.EventHandler(this.numPrecisionAI_ValueChanged);
            this.numPrecisionAI.Click += new System.EventHandler(this.numPrecisionAI_Click);
            // 
            // numSkillAI
            // 
            this.numSkillAI.DecimalPlaces = 2;
            this.numSkillAI.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numSkillAI.Location = new System.Drawing.Point(424, 85);
            this.numSkillAI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSkillAI.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSkillAI.Name = "numSkillAI";
            this.numSkillAI.Size = new System.Drawing.Size(80, 26);
            this.numSkillAI.TabIndex = 42;
            this.numSkillAI.ValueChanged += new System.EventHandler(this.numSkillAI_ValueChanged);
            this.numSkillAI.Click += new System.EventHandler(this.numSkillAI_Click);
            // 
            // clbDifficultyItems
            // 
            this.clbDifficultyItems.BackColor = System.Drawing.SystemColors.Control;
            this.clbDifficultyItems.FormattingEnabled = true;
            this.clbDifficultyItems.Location = new System.Drawing.Point(9, 29);
            this.clbDifficultyItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbDifficultyItems.Name = "clbDifficultyItems";
            this.clbDifficultyItems.Size = new System.Drawing.Size(284, 487);
            this.clbDifficultyItems.TabIndex = 25;
            this.clbDifficultyItems.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbDifficultyItems_ItemCheck);
            this.clbDifficultyItems.SelectedIndexChanged += new System.EventHandler(this.clbDifficultyItems_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "AI Precision";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "AI Skill";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(597, 535);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(125, 20);
            this.label22.TabIndex = 52;
            this.label22.Text = "Default Difficulty";
            // 
            // cmbDefaultDifficulty
            // 
            this.cmbDefaultDifficulty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbDefaultDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefaultDifficulty.FormattingEnabled = true;
            this.cmbDefaultDifficulty.Items.AddRange(new object[] {
            "Recruit",
            "Regular",
            "Veteran",
            "Custom"});
            this.cmbDefaultDifficulty.Location = new System.Drawing.Point(729, 531);
            this.cmbDefaultDifficulty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDefaultDifficulty.Name = "cmbDefaultDifficulty";
            this.cmbDefaultDifficulty.Size = new System.Drawing.Size(98, 28);
            this.cmbDefaultDifficulty.TabIndex = 51;
            this.cmbDefaultDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDefaultDifficulty_SelectedIndexChanged);
            // 
            // tabPerformance
            // 
            this.tabPerformance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPerformance.Controls.Add(this.chkEnableHT);
            this.tabPerformance.Controls.Add(this.groupBox3);
            this.tabPerformance.Controls.Add(this.groupBox10);
            this.tabPerformance.Controls.Add(this.groupBox7);
            this.tabPerformance.ImageIndex = 5;
            this.tabPerformance.Location = new System.Drawing.Point(4, 29);
            this.tabPerformance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPerformance.Size = new System.Drawing.Size(850, 581);
            this.tabPerformance.TabIndex = 5;
            this.tabPerformance.Text = "Performance";
            this.tabPerformance.Click += new System.EventHandler(this.tabPerformance_Click);
            // 
            // chkEnableHT
            // 
            this.chkEnableHT.AutoSize = true;
            this.chkEnableHT.Location = new System.Drawing.Point(436, 442);
            this.chkEnableHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEnableHT.Name = "chkEnableHT";
            this.chkEnableHT.Size = new System.Drawing.Size(110, 24);
            this.chkEnableHT.TabIndex = 32;
            this.chkEnableHT.Text = "Enable HT";
            this.toolTip1.SetToolTip(this.chkEnableHT, "-enableHT instructs Arma 3 to use all hyper-threaded CPU cores.\r\n\r\nUse of this pa" +
        "rameter may increase the game\'s performance, \r\nespecially on Dedicated Servers w" +
        "ith high amount of players");
            this.chkEnableHT.UseVisualStyleBackColor = true;
            this.chkEnableHT.CheckedChanged += new System.EventHandler(this.chkEnableHT_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numTerrainGrid);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.numViewDistance);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(436, 308);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(390, 125);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terrain";
            // 
            // numTerrainGrid
            // 
            this.numTerrainGrid.DecimalPlaces = 1;
            this.numTerrainGrid.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numTerrainGrid.Location = new System.Drawing.Point(134, 29);
            this.numTerrainGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numTerrainGrid.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numTerrainGrid.Name = "numTerrainGrid";
            this.numTerrainGrid.Size = new System.Drawing.Size(105, 26);
            this.numTerrainGrid.TabIndex = 25;
            this.toolTip1.SetToolTip(this.numTerrainGrid, "Sets the server default terrain quality. \r\nVery High:10, Low:50\r\nThis maybe overi" +
        "dden by the mission ");
            this.numTerrainGrid.ValueChanged += new System.EventHandler(this.numTerrainGrid_ValueChanged);
            this.numTerrainGrid.Click += new System.EventHandler(this.numTerrainGrid_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(248, 77);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "meters";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Terrain Grid";
            // 
            // numViewDistance
            // 
            this.numViewDistance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numViewDistance.Location = new System.Drawing.Point(134, 72);
            this.numViewDistance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numViewDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numViewDistance.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numViewDistance.Name = "numViewDistance";
            this.numViewDistance.Size = new System.Drawing.Size(105, 26);
            this.numViewDistance.TabIndex = 26;
            this.numViewDistance.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numViewDistance.ValueChanged += new System.EventHandler(this.numViewDistance_ValueChanged);
            this.numViewDistance.Click += new System.EventHandler(this.numViewDistance_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 77);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "View Distance";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtPerformanceInfo);
            this.groupBox10.Location = new System.Drawing.Point(434, 9);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Size = new System.Drawing.Size(394, 289);
            this.groupBox10.TabIndex = 27;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Info";
            // 
            // txtPerformanceInfo
            // 
            this.txtPerformanceInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPerformanceInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPerformanceInfo.Location = new System.Drawing.Point(12, 23);
            this.txtPerformanceInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerformanceInfo.Name = "txtPerformanceInfo";
            this.txtPerformanceInfo.ReadOnly = true;
            this.txtPerformanceInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtPerformanceInfo.Size = new System.Drawing.Size(374, 249);
            this.txtPerformanceInfo.TabIndex = 16;
            this.txtPerformanceInfo.Text = "";
            this.txtPerformanceInfo.Click += new System.EventHandler(this.txtPerformanceInfo_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.txtMaxPacketSize);
            this.groupBox7.Controls.Add(this.btnResetPerformance);
            this.groupBox7.Controls.Add(this.MinErrorToSendNearLBL);
            this.groupBox7.Controls.Add(this.txtMinErrorToSendNear);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.minBandwidthLBL2);
            this.groupBox7.Controls.Add(this.MaxCustomFileSize);
            this.groupBox7.Controls.Add(this.txtMaxCustomFileSize);
            this.groupBox7.Controls.Add(this.MinErrorToSendLBL);
            this.groupBox7.Controls.Add(this.txtMinErrorToSend);
            this.groupBox7.Controls.Add(this.MaxBandwidthLBL);
            this.groupBox7.Controls.Add(this.txtMaxBandwidth);
            this.groupBox7.Controls.Add(this.MinBandwidthLBL);
            this.groupBox7.Controls.Add(this.txtMinBandwidth);
            this.groupBox7.Controls.Add(this.MaxSizeNonguaranteedLBL);
            this.groupBox7.Controls.Add(this.txtMaxSizeNonguaranteed);
            this.groupBox7.Controls.Add(this.MaxSizeGuaranteedLBL);
            this.groupBox7.Controls.Add(this.txtMaxSizeGuaranteed);
            this.groupBox7.Controls.Add(this.MaxMsgSendLBL);
            this.groupBox7.Controls.Add(this.txtMaxMessagesSend);
            this.groupBox7.Location = new System.Drawing.Point(20, 9);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(399, 458);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Performance Tuning Settings";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(60, 371);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(164, 20);
            this.label20.TabIndex = 24;
            this.label20.Text = "Maximum Packet Size";
            // 
            // txtMaxPacketSize
            // 
            this.txtMaxPacketSize.Location = new System.Drawing.Point(231, 365);
            this.txtMaxPacketSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxPacketSize.Name = "txtMaxPacketSize";
            this.txtMaxPacketSize.Size = new System.Drawing.Size(94, 26);
            this.txtMaxPacketSize.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txtMaxPacketSize, resources.GetString("txtMaxPacketSize.ToolTip"));
            this.txtMaxPacketSize.Click += new System.EventHandler(this.txtMaxPacketSize_Click);
            this.txtMaxPacketSize.TextChanged += new System.EventHandler(this.txtMaxPacketSize_TextChanged);
            this.txtMaxPacketSize.DoubleClick += new System.EventHandler(this.txtMaxPacketSize_DoubleClick);
            // 
            // btnResetPerformance
            // 
            this.btnResetPerformance.Location = new System.Drawing.Point(231, 414);
            this.btnResetPerformance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetPerformance.Name = "btnResetPerformance";
            this.btnResetPerformance.Size = new System.Drawing.Size(96, 35);
            this.btnResetPerformance.TabIndex = 22;
            this.btnResetPerformance.Text = "Reset";
            this.toolTip1.SetToolTip(this.btnResetPerformance, "Reset performance tuning settings to default");
            this.btnResetPerformance.UseVisualStyleBackColor = true;
            this.btnResetPerformance.Click += new System.EventHandler(this.btnResetPerformance_Click);
            // 
            // MinErrorToSendNearLBL
            // 
            this.MinErrorToSendNearLBL.AutoSize = true;
            this.MinErrorToSendNearLBL.Location = new System.Drawing.Point(12, 285);
            this.MinErrorToSendNearLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinErrorToSendNearLBL.Name = "MinErrorToSendNearLBL";
            this.MinErrorToSendNearLBL.Size = new System.Drawing.Size(213, 20);
            this.MinErrorToSendNearLBL.TabIndex = 21;
            this.MinErrorToSendNearLBL.Text = "Minimum Error To Send Near";
            // 
            // txtMinErrorToSendNear
            // 
            this.txtMinErrorToSendNear.Location = new System.Drawing.Point(231, 278);
            this.txtMinErrorToSendNear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinErrorToSendNear.Name = "txtMinErrorToSendNear";
            this.txtMinErrorToSendNear.Size = new System.Drawing.Size(94, 26);
            this.txtMinErrorToSendNear.TabIndex = 20;
            this.txtMinErrorToSendNear.Click += new System.EventHandler(this.txtMinErrorToSendNear_Click);
            this.txtMinErrorToSendNear.TextChanged += new System.EventHandler(this.txtMinErrorToSendNear_TextChanged);
            this.txtMinErrorToSendNear.DoubleClick += new System.EventHandler(this.txtMinErrorToSendNear_DoubleClick);
            this.txtMinErrorToSendNear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinErrorToSendNear_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Bytes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bytes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "kB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "mbit/s";
            // 
            // minBandwidthLBL2
            // 
            this.minBandwidthLBL2.AutoSize = true;
            this.minBandwidthLBL2.Location = new System.Drawing.Point(338, 163);
            this.minBandwidthLBL2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minBandwidthLBL2.Name = "minBandwidthLBL2";
            this.minBandwidthLBL2.Size = new System.Drawing.Size(46, 20);
            this.minBandwidthLBL2.TabIndex = 15;
            this.minBandwidthLBL2.Text = "kbit/s";
            // 
            // MaxCustomFileSize
            // 
            this.MaxCustomFileSize.AutoSize = true;
            this.MaxCustomFileSize.Location = new System.Drawing.Point(30, 328);
            this.MaxCustomFileSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxCustomFileSize.Name = "MaxCustomFileSize";
            this.MaxCustomFileSize.Size = new System.Drawing.Size(199, 20);
            this.MaxCustomFileSize.TabIndex = 14;
            this.MaxCustomFileSize.Text = "Maximum Custom File Size";
            // 
            // txtMaxCustomFileSize
            // 
            this.txtMaxCustomFileSize.Location = new System.Drawing.Point(231, 322);
            this.txtMaxCustomFileSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxCustomFileSize.Name = "txtMaxCustomFileSize";
            this.txtMaxCustomFileSize.Size = new System.Drawing.Size(94, 26);
            this.txtMaxCustomFileSize.TabIndex = 7;
            this.txtMaxCustomFileSize.Click += new System.EventHandler(this.txtMaxCustomFileSize_Click);
            this.txtMaxCustomFileSize.TextChanged += new System.EventHandler(this.txtMaxCustomFileSize_TextChanged);
            this.txtMaxCustomFileSize.DoubleClick += new System.EventHandler(this.txtMaxCustomFileSize_DoubleClick);
            this.txtMaxCustomFileSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxCustomFileSize_KeyPress);
            // 
            // MinErrorToSendLBL
            // 
            this.MinErrorToSendLBL.AutoSize = true;
            this.MinErrorToSendLBL.Location = new System.Drawing.Point(51, 245);
            this.MinErrorToSendLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinErrorToSendLBL.Name = "MinErrorToSendLBL";
            this.MinErrorToSendLBL.Size = new System.Drawing.Size(175, 20);
            this.MinErrorToSendLBL.TabIndex = 12;
            this.MinErrorToSendLBL.Text = "Minimum Error To Send";
            // 
            // txtMinErrorToSend
            // 
            this.txtMinErrorToSend.Location = new System.Drawing.Point(231, 238);
            this.txtMinErrorToSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinErrorToSend.Name = "txtMinErrorToSend";
            this.txtMinErrorToSend.Size = new System.Drawing.Size(94, 26);
            this.txtMinErrorToSend.TabIndex = 6;
            this.txtMinErrorToSend.Click += new System.EventHandler(this.txtMinErrorToSend_Click);
            this.txtMinErrorToSend.TextChanged += new System.EventHandler(this.txtMinErrorToSend_TextChanged);
            this.txtMinErrorToSend.DoubleClick += new System.EventHandler(this.txtMinErrorToSend_DoubleClick);
            this.txtMinErrorToSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinErrorToSend_KeyPress);
            // 
            // MaxBandwidthLBL
            // 
            this.MaxBandwidthLBL.AutoSize = true;
            this.MaxBandwidthLBL.Location = new System.Drawing.Point(70, 205);
            this.MaxBandwidthLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxBandwidthLBL.Name = "MaxBandwidthLBL";
            this.MaxBandwidthLBL.Size = new System.Drawing.Size(155, 20);
            this.MaxBandwidthLBL.TabIndex = 10;
            this.MaxBandwidthLBL.Text = "Maximum Bandwidth";
            // 
            // txtMaxBandwidth
            // 
            this.txtMaxBandwidth.Location = new System.Drawing.Point(231, 198);
            this.txtMaxBandwidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxBandwidth.Name = "txtMaxBandwidth";
            this.txtMaxBandwidth.Size = new System.Drawing.Size(94, 26);
            this.txtMaxBandwidth.TabIndex = 5;
            this.txtMaxBandwidth.Click += new System.EventHandler(this.txtMaxBandwidth_Click);
            this.txtMaxBandwidth.TextChanged += new System.EventHandler(this.txtMaxBandwidth_TextChanged);
            this.txtMaxBandwidth.DoubleClick += new System.EventHandler(this.txtMaxBandwidth_DoubleClick);
            this.txtMaxBandwidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxBandwidth_KeyPress);
            // 
            // MinBandwidthLBL
            // 
            this.MinBandwidthLBL.AutoSize = true;
            this.MinBandwidthLBL.Location = new System.Drawing.Point(75, 165);
            this.MinBandwidthLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinBandwidthLBL.Name = "MinBandwidthLBL";
            this.MinBandwidthLBL.Size = new System.Drawing.Size(151, 20);
            this.MinBandwidthLBL.TabIndex = 8;
            this.MinBandwidthLBL.Text = "Minimum Bandwidth";
            // 
            // txtMinBandwidth
            // 
            this.txtMinBandwidth.Location = new System.Drawing.Point(231, 158);
            this.txtMinBandwidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinBandwidth.Name = "txtMinBandwidth";
            this.txtMinBandwidth.Size = new System.Drawing.Size(94, 26);
            this.txtMinBandwidth.TabIndex = 4;
            this.txtMinBandwidth.Click += new System.EventHandler(this.txtMinBandwidth_Click);
            this.txtMinBandwidth.TextChanged += new System.EventHandler(this.txtMinBandwidth_TextChanged);
            this.txtMinBandwidth.DoubleClick += new System.EventHandler(this.txtMinBandwidth_DoubleClick);
            this.txtMinBandwidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinBandwidth_KeyPress);
            // 
            // MaxSizeNonguaranteedLBL
            // 
            this.MaxSizeNonguaranteedLBL.AutoSize = true;
            this.MaxSizeNonguaranteedLBL.Location = new System.Drawing.Point(36, 125);
            this.MaxSizeNonguaranteedLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxSizeNonguaranteedLBL.Name = "MaxSizeNonguaranteedLBL";
            this.MaxSizeNonguaranteedLBL.Size = new System.Drawing.Size(188, 20);
            this.MaxSizeNonguaranteedLBL.TabIndex = 6;
            this.MaxSizeNonguaranteedLBL.Text = "Max Size Nonguaranteed";
            // 
            // txtMaxSizeNonguaranteed
            // 
            this.txtMaxSizeNonguaranteed.Location = new System.Drawing.Point(231, 118);
            this.txtMaxSizeNonguaranteed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxSizeNonguaranteed.Name = "txtMaxSizeNonguaranteed";
            this.txtMaxSizeNonguaranteed.Size = new System.Drawing.Size(94, 26);
            this.txtMaxSizeNonguaranteed.TabIndex = 3;
            this.txtMaxSizeNonguaranteed.Click += new System.EventHandler(this.txtMaxSizeNonguaranteed_Click);
            this.txtMaxSizeNonguaranteed.TextChanged += new System.EventHandler(this.txtMaxSizeNonguaranteed_TextChanged);
            this.txtMaxSizeNonguaranteed.DoubleClick += new System.EventHandler(this.txtMaxSizeNonguaranteed_DoubleClick);
            this.txtMaxSizeNonguaranteed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxSizeNonguaranteed_KeyPress);
            // 
            // MaxSizeGuaranteedLBL
            // 
            this.MaxSizeGuaranteedLBL.AutoSize = true;
            this.MaxSizeGuaranteedLBL.Location = new System.Drawing.Point(63, 85);
            this.MaxSizeGuaranteedLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxSizeGuaranteedLBL.Name = "MaxSizeGuaranteedLBL";
            this.MaxSizeGuaranteedLBL.Size = new System.Drawing.Size(163, 20);
            this.MaxSizeGuaranteedLBL.TabIndex = 4;
            this.MaxSizeGuaranteedLBL.Text = "Max Size Guaranteed";
            // 
            // txtMaxSizeGuaranteed
            // 
            this.txtMaxSizeGuaranteed.Location = new System.Drawing.Point(231, 78);
            this.txtMaxSizeGuaranteed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxSizeGuaranteed.Name = "txtMaxSizeGuaranteed";
            this.txtMaxSizeGuaranteed.Size = new System.Drawing.Size(94, 26);
            this.txtMaxSizeGuaranteed.TabIndex = 2;
            this.txtMaxSizeGuaranteed.Click += new System.EventHandler(this.txtMaxSizeGuaranteed_Click);
            this.txtMaxSizeGuaranteed.TextChanged += new System.EventHandler(this.txtMaxSizeGuaranteed_TextChanged);
            this.txtMaxSizeGuaranteed.DoubleClick += new System.EventHandler(this.txtMaxSizeGuaranteed_DoubleClick);
            this.txtMaxSizeGuaranteed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxSizeGuaranteed_KeyPress);
            // 
            // MaxMsgSendLBL
            // 
            this.MaxMsgSendLBL.AutoSize = true;
            this.MaxMsgSendLBL.Location = new System.Drawing.Point(32, 45);
            this.MaxMsgSendLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxMsgSendLBL.Name = "MaxMsgSendLBL";
            this.MaxMsgSendLBL.Size = new System.Drawing.Size(195, 20);
            this.MaxMsgSendLBL.TabIndex = 1;
            this.MaxMsgSendLBL.Text = "Maximum Messages Send";
            // 
            // txtMaxMessagesSend
            // 
            this.txtMaxMessagesSend.Location = new System.Drawing.Point(231, 38);
            this.txtMaxMessagesSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxMessagesSend.Name = "txtMaxMessagesSend";
            this.txtMaxMessagesSend.Size = new System.Drawing.Size(94, 26);
            this.txtMaxMessagesSend.TabIndex = 1;
            this.txtMaxMessagesSend.Click += new System.EventHandler(this.txtMaxMessagesSend_Click);
            this.txtMaxMessagesSend.TextChanged += new System.EventHandler(this.txtMaxMessagesSend_TextChanged);
            this.txtMaxMessagesSend.DoubleClick += new System.EventHandler(this.txtMaxMessagesSend_DoubleClick);
            this.txtMaxMessagesSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxMessagesSend_KeyPress);
            // 
            // tabServerScripts
            // 
            this.tabServerScripts.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabServerScripts.Controls.Add(this.groupBox4);
            this.tabServerScripts.Controls.Add(this.label18);
            this.tabServerScripts.Controls.Add(this.txtServerCommandPassword);
            this.tabServerScripts.ImageIndex = 6;
            this.tabServerScripts.Location = new System.Drawing.Point(4, 29);
            this.tabServerScripts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabServerScripts.Name = "tabServerScripts";
            this.tabServerScripts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabServerScripts.Size = new System.Drawing.Size(850, 581);
            this.tabServerScripts.TabIndex = 6;
            this.tabServerScripts.Text = "Server Side Scripting";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDoubleIdDetected);
            this.groupBox4.Controls.Add(this.onDifferentDataLBL);
            this.groupBox4.Controls.Add(this.txtOnUserConnected);
            this.groupBox4.Controls.Add(this.doubleIdDetectedLBL);
            this.groupBox4.Controls.Add(this.txtOnDifferentData);
            this.groupBox4.Controls.Add(this.regularCheckLBL);
            this.groupBox4.Controls.Add(this.onUserConnectedLBL);
            this.groupBox4.Controls.Add(this.txtOnUnsignedData);
            this.groupBox4.Controls.Add(this.txtOnHackedData);
            this.groupBox4.Controls.Add(this.txtRegularCheck);
            this.groupBox4.Controls.Add(this.txtOnUserDisconnected);
            this.groupBox4.Controls.Add(this.onUnSignedDataLBL);
            this.groupBox4.Controls.Add(this.onHackedDataLBL);
            this.groupBox4.Controls.Add(this.onUserDisconnectedLBL);
            this.groupBox4.Location = new System.Drawing.Point(10, 98);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(828, 465);
            this.groupBox4.TabIndex = 68;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Server Scripts";
            // 
            // txtDoubleIdDetected
            // 
            this.txtDoubleIdDetected.Location = new System.Drawing.Point(218, 48);
            this.txtDoubleIdDetected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDoubleIdDetected.Name = "txtDoubleIdDetected";
            this.txtDoubleIdDetected.Size = new System.Drawing.Size(595, 26);
            this.txtDoubleIdDetected.TabIndex = 26;
            this.txtDoubleIdDetected.TextChanged += new System.EventHandler(this.txtDoubleIdDetected_TextChanged);
            // 
            // onDifferentDataLBL
            // 
            this.onDifferentDataLBL.AutoSize = true;
            this.onDifferentDataLBL.Location = new System.Drawing.Point(72, 271);
            this.onDifferentDataLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.onDifferentDataLBL.Name = "onDifferentDataLBL";
            this.onDifferentDataLBL.Size = new System.Drawing.Size(137, 20);
            this.onDifferentDataLBL.TabIndex = 35;
            this.onDifferentDataLBL.Text = "onDifferentData =";
            // 
            // txtOnUserConnected
            // 
            this.txtOnUserConnected.Location = new System.Drawing.Point(218, 103);
            this.txtOnUserConnected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOnUserConnected.Name = "txtOnUserConnected";
            this.txtOnUserConnected.Size = new System.Drawing.Size(595, 26);
            this.txtOnUserConnected.TabIndex = 27;
            this.txtOnUserConnected.TextChanged += new System.EventHandler(this.txtOnUserConnected_TextChanged);
            // 
            // doubleIdDetectedLBL
            // 
            this.doubleIdDetectedLBL.AutoSize = true;
            this.doubleIdDetectedLBL.Location = new System.Drawing.Point(57, 52);
            this.doubleIdDetectedLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doubleIdDetectedLBL.Name = "doubleIdDetectedLBL";
            this.doubleIdDetectedLBL.Size = new System.Drawing.Size(150, 20);
            this.doubleIdDetectedLBL.TabIndex = 36;
            this.doubleIdDetectedLBL.Text = "doubleIdDetected =";
            // 
            // txtOnDifferentData
            // 
            this.txtOnDifferentData.Location = new System.Drawing.Point(218, 266);
            this.txtOnDifferentData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOnDifferentData.Name = "txtOnDifferentData";
            this.txtOnDifferentData.Size = new System.Drawing.Size(595, 26);
            this.txtOnDifferentData.TabIndex = 30;
            this.txtOnDifferentData.TextChanged += new System.EventHandler(this.txtOnDifferentData_TextChanged);
            // 
            // regularCheckLBL
            // 
            this.regularCheckLBL.AutoSize = true;
            this.regularCheckLBL.Location = new System.Drawing.Point(90, 378);
            this.regularCheckLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regularCheckLBL.Name = "regularCheckLBL";
            this.regularCheckLBL.Size = new System.Drawing.Size(116, 20);
            this.regularCheckLBL.TabIndex = 39;
            this.regularCheckLBL.Text = "regularCheck =";
            this.regularCheckLBL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // onUserConnectedLBL
            // 
            this.onUserConnectedLBL.AutoSize = true;
            this.onUserConnectedLBL.Location = new System.Drawing.Point(56, 108);
            this.onUserConnectedLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.onUserConnectedLBL.Name = "onUserConnectedLBL";
            this.onUserConnectedLBL.Size = new System.Drawing.Size(152, 20);
            this.onUserConnectedLBL.TabIndex = 37;
            this.onUserConnectedLBL.Text = "onUserConnected =";
            // 
            // txtOnUnsignedData
            // 
            this.txtOnUnsignedData.Location = new System.Drawing.Point(218, 320);
            this.txtOnUnsignedData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOnUnsignedData.Name = "txtOnUnsignedData";
            this.txtOnUnsignedData.Size = new System.Drawing.Size(595, 26);
            this.txtOnUnsignedData.TabIndex = 31;
            this.txtOnUnsignedData.TextChanged += new System.EventHandler(this.txtOnUnsignedData_TextChanged);
            // 
            // txtOnHackedData
            // 
            this.txtOnHackedData.Location = new System.Drawing.Point(218, 211);
            this.txtOnHackedData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOnHackedData.Name = "txtOnHackedData";
            this.txtOnHackedData.Size = new System.Drawing.Size(595, 26);
            this.txtOnHackedData.TabIndex = 29;
            this.txtOnHackedData.TextChanged += new System.EventHandler(this.txtOnHackedData_TextChanged);
            // 
            // txtRegularCheck
            // 
            this.txtRegularCheck.Location = new System.Drawing.Point(218, 374);
            this.txtRegularCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegularCheck.Name = "txtRegularCheck";
            this.txtRegularCheck.Size = new System.Drawing.Size(595, 26);
            this.txtRegularCheck.TabIndex = 32;
            this.txtRegularCheck.TextChanged += new System.EventHandler(this.txtRegularCheck_TextChanged);
            // 
            // txtOnUserDisconnected
            // 
            this.txtOnUserDisconnected.Location = new System.Drawing.Point(218, 157);
            this.txtOnUserDisconnected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOnUserDisconnected.Name = "txtOnUserDisconnected";
            this.txtOnUserDisconnected.Size = new System.Drawing.Size(595, 26);
            this.txtOnUserDisconnected.TabIndex = 28;
            this.txtOnUserDisconnected.TextChanged += new System.EventHandler(this.txtOnUserDisconnected_TextChanged);
            // 
            // onUnSignedDataLBL
            // 
            this.onUnSignedDataLBL.AutoSize = true;
            this.onUnSignedDataLBL.Location = new System.Drawing.Point(62, 325);
            this.onUnSignedDataLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.onUnSignedDataLBL.Name = "onUnSignedDataLBL";
            this.onUnSignedDataLBL.Size = new System.Drawing.Size(147, 20);
            this.onUnSignedDataLBL.TabIndex = 33;
            this.onUnSignedDataLBL.Text = "onUnsignedData = ";
            this.onUnSignedDataLBL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // onHackedDataLBL
            // 
            this.onHackedDataLBL.AutoSize = true;
            this.onHackedDataLBL.Location = new System.Drawing.Point(75, 215);
            this.onHackedDataLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.onHackedDataLBL.Name = "onHackedDataLBL";
            this.onHackedDataLBL.Size = new System.Drawing.Size(130, 20);
            this.onHackedDataLBL.TabIndex = 34;
            this.onHackedDataLBL.Text = "onHackedData =";
            // 
            // onUserDisconnectedLBL
            // 
            this.onUserDisconnectedLBL.AutoSize = true;
            this.onUserDisconnectedLBL.Location = new System.Drawing.Point(34, 162);
            this.onUserDisconnectedLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.onUserDisconnectedLBL.Name = "onUserDisconnectedLBL";
            this.onUserDisconnectedLBL.Size = new System.Drawing.Size(172, 20);
            this.onUserDisconnectedLBL.TabIndex = 38;
            this.onUserDisconnectedLBL.Text = "onUserDisconnected =";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 34);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(205, 20);
            this.label18.TabIndex = 67;
            this.label18.Text = "Server Command Password";
            // 
            // txtServerCommandPassword
            // 
            this.txtServerCommandPassword.Location = new System.Drawing.Point(228, 29);
            this.txtServerCommandPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServerCommandPassword.Name = "txtServerCommandPassword";
            this.txtServerCommandPassword.Size = new System.Drawing.Size(300, 26);
            this.txtServerCommandPassword.TabIndex = 66;
            this.toolTip1.SetToolTip(this.txtServerCommandPassword, "Password required by alternate syntax of serverCommand server-side scripting.");
            this.txtServerCommandPassword.TextChanged += new System.EventHandler(this.txtServerCommandPassword_TextChanged);
            this.txtServerCommandPassword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtServerCommandPassword_MouseDoubleClick);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.SystemColors.Control;
            this.btnLaunch.Location = new System.Drawing.Point(729, 948);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(105, 66);
            this.btnLaunch.TabIndex = 38;
            this.btnLaunch.Text = "LAUNCH";
            this.toolTip1.SetToolTip(this.btnLaunch, "Launch server with selected settings");
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.Location = new System.Drawing.Point(8, 708);
            this.lblParameters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(132, 20);
            this.lblParameters.TabIndex = 920;
            this.lblParameters.Text = "Extra Parameters";
            this.lblParameters.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtExtraParameters
            // 
            this.txtExtraParameters.Location = new System.Drawing.Point(141, 703);
            this.txtExtraParameters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExtraParameters.Name = "txtExtraParameters";
            this.txtExtraParameters.Size = new System.Drawing.Size(690, 26);
            this.txtExtraParameters.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtExtraParameters, "Add any custom parameters here");
            this.txtExtraParameters.Click += new System.EventHandler(this.txtExtraParameters_Click);
            this.txtExtraParameters.TextChanged += new System.EventHandler(this.txtExtraParameters_TextChanged);
            // 
            // lblServerExe
            // 
            this.lblServerExe.AutoSize = true;
            this.lblServerExe.Location = new System.Drawing.Point(52, 754);
            this.lblServerExe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerExe.Name = "lblServerExe";
            this.lblServerExe.Size = new System.Drawing.Size(84, 20);
            this.lblServerExe.TabIndex = 916;
            this.lblServerExe.Text = "Server File";
            this.lblServerExe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBrowseExe
            // 
            this.btnBrowseExe.Location = new System.Drawing.Point(790, 746);
            this.btnBrowseExe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseExe.Name = "btnBrowseExe";
            this.btnBrowseExe.Size = new System.Drawing.Size(45, 35);
            this.btnBrowseExe.TabIndex = 31;
            this.btnBrowseExe.Text = "...";
            this.toolTip1.SetToolTip(this.btnBrowseExe, "Browse for server file");
            this.btnBrowseExe.UseVisualStyleBackColor = true;
            this.btnBrowseExe.Click += new System.EventHandler(this.btnBrowseExe_Click);
            // 
            // txtServerExe
            // 
            this.txtServerExe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtServerExe.Location = new System.Drawing.Point(141, 749);
            this.txtServerExe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServerExe.Name = "txtServerExe";
            this.txtServerExe.Size = new System.Drawing.Size(638, 26);
            this.txtServerExe.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtServerExe, "Server executable.");
            this.txtServerExe.TextChanged += new System.EventHandler(this.txtServerExe_TextChanged);
            this.txtServerExe.DoubleClick += new System.EventHandler(this.txtServerExe_DoubleClick);
            // 
            // btnExport
            // 
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.ImageIndex = 12;
            this.btnExport.ImageList = this.imageList1;
            this.btnExport.Location = new System.Drawing.Point(729, 852);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 37);
            this.btnExport.TabIndex = 36;
            this.btnExport.Text = "Export  ";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnExport, "Export all configuration files and parameters for manual use.");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.ImageIndex = 11;
            this.btnPreview.ImageList = this.imageList1;
            this.btnPreview.Location = new System.Drawing.Point(729, 900);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(105, 37);
            this.btnPreview.TabIndex = 37;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPreview, "Generate config files without launching server. Also opens profile folder for you" +
        " to browse the files.\r\n");
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.ImageIndex = 13;
            this.btnHelp.ImageList = this.imageList1;
            this.btnHelp.Location = new System.Drawing.Point(729, 806);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(106, 37);
            this.btnHelp.TabIndex = 928;
            this.btnHelp.Text = "What?  ";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnHelp, "Click me!");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // chkAutoExit
            // 
            this.chkAutoExit.AutoSize = true;
            this.chkAutoExit.Location = new System.Drawing.Point(578, 988);
            this.chkAutoExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutoExit.Name = "chkAutoExit";
            this.chkAutoExit.Size = new System.Drawing.Size(119, 24);
            this.chkAutoExit.TabIndex = 20;
            this.chkAutoExit.Text = "Exit on start";
            this.toolTip1.SetToolTip(this.chkAutoExit, "Check if you want to close the laucher when the server is started.");
            this.chkAutoExit.UseVisualStyleBackColor = true;
            this.chkAutoExit.CheckedChanged += new System.EventHandler(this.chkAutoExit_CheckedChanged);
            // 
            // chkTooltips
            // 
            this.chkTooltips.AutoSize = true;
            this.chkTooltips.Checked = true;
            this.chkTooltips.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTooltips.Location = new System.Drawing.Point(578, 917);
            this.chkTooltips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTooltips.Name = "chkTooltips";
            this.chkTooltips.Size = new System.Drawing.Size(90, 24);
            this.chkTooltips.TabIndex = 19;
            this.chkTooltips.Text = "Tooltips";
            this.toolTip1.SetToolTip(this.chkTooltips, "Toggle tool tips on/off");
            this.chkTooltips.UseVisualStyleBackColor = true;
            this.chkTooltips.CheckedChanged += new System.EventHandler(this.chkTooltips_CheckedChanged);
            // 
            // grpProfile
            // 
            this.grpProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpProfile.BackColor = System.Drawing.SystemColors.Control;
            this.grpProfile.Controls.Add(this.label1);
            this.grpProfile.Controls.Add(this.btnDeleteProfile);
            this.grpProfile.Controls.Add(this.btnProfileSave);
            this.grpProfile.Controls.Add(this.btnProfileNew);
            this.grpProfile.Controls.Add(this.cmbProfiles);
            this.grpProfile.Controls.Add(this.btnResetSettings);
            this.grpProfile.Location = new System.Drawing.Point(18, 869);
            this.grpProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpProfile.Size = new System.Drawing.Size(531, 152);
            this.grpProfile.TabIndex = 939;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "Profile";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name";
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProfile.ImageIndex = 9;
            this.btnDeleteProfile.ImageList = this.imageList1;
            this.btnDeleteProfile.Location = new System.Drawing.Point(418, 92);
            this.btnDeleteProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(93, 37);
            this.btnDeleteProfile.TabIndex = 35;
            this.btnDeleteProfile.Text = "Delete";
            this.btnDeleteProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteProfile, "Delete selected profile");
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnProfileSave
            // 
            this.btnProfileSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfileSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfileSave.ImageIndex = 7;
            this.btnProfileSave.ImageList = this.imageList1;
            this.btnProfileSave.Location = new System.Drawing.Point(75, 92);
            this.btnProfileSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProfileSave.Name = "btnProfileSave";
            this.btnProfileSave.Size = new System.Drawing.Size(93, 37);
            this.btnProfileSave.TabIndex = 32;
            this.btnProfileSave.Text = "Save";
            this.btnProfileSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnProfileSave, "Save all settings to selected profile");
            this.btnProfileSave.UseVisualStyleBackColor = true;
            this.btnProfileSave.Click += new System.EventHandler(this.btnProfileSave_Click);
            // 
            // btnProfileNew
            // 
            this.btnProfileNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfileNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfileNew.ImageIndex = 8;
            this.btnProfileNew.ImageList = this.imageList1;
            this.btnProfileNew.Location = new System.Drawing.Point(189, 92);
            this.btnProfileNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProfileNew.Name = "btnProfileNew";
            this.btnProfileNew.Size = new System.Drawing.Size(93, 37);
            this.btnProfileNew.TabIndex = 33;
            this.btnProfileNew.Text = "New...";
            this.btnProfileNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnProfileNew, "Save new profile with current settings.");
            this.btnProfileNew.UseVisualStyleBackColor = true;
            this.btnProfileNew.Click += new System.EventHandler(this.btnProfileNew_Click);
            // 
            // cmbProfiles
            // 
            this.cmbProfiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfiles.FormattingEnabled = true;
            this.cmbProfiles.Location = new System.Drawing.Point(75, 42);
            this.cmbProfiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProfiles.Name = "cmbProfiles";
            this.cmbProfiles.Size = new System.Drawing.Size(434, 28);
            this.cmbProfiles.TabIndex = 18;
            this.toolTip1.SetToolTip(this.cmbProfiles, "Available TADST profiles");
            this.cmbProfiles.SelectionChangeCommitted += new System.EventHandler(this.cmbProfiles_SelectionChangeCommitted);
            this.cmbProfiles.Enter += new System.EventHandler(this.cmbProfiles_Enter);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetSettings.Location = new System.Drawing.Point(303, 92);
            this.btnResetSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(93, 37);
            this.btnResetSettings.TabIndex = 34;
            this.btnResetSettings.Text = "Reset";
            this.toolTip1.SetToolTip(this.btnResetSettings, "Reset all settings to deafult values for current profile.\r\n");
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // txtStartupParameters
            // 
            this.txtStartupParameters.Location = new System.Drawing.Point(141, 626);
            this.txtStartupParameters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStartupParameters.Multiline = true;
            this.txtStartupParameters.Name = "txtStartupParameters";
            this.txtStartupParameters.ReadOnly = true;
            this.txtStartupParameters.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtStartupParameters.Size = new System.Drawing.Size(691, 59);
            this.txtStartupParameters.TabIndex = 942;
            this.toolTip1.SetToolTip(this.txtStartupParameters, "Add any custom parameters here");
            this.txtStartupParameters.WordWrap = false;
            // 
            // chkStartAsIs
            // 
            this.chkStartAsIs.AutoSize = true;
            this.chkStartAsIs.Location = new System.Drawing.Point(578, 952);
            this.chkStartAsIs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkStartAsIs.Name = "chkStartAsIs";
            this.chkStartAsIs.Size = new System.Drawing.Size(124, 24);
            this.chkStartAsIs.TabIndex = 941;
            this.chkStartAsIs.Text = "Launch as is";
            this.toolTip1.SetToolTip(this.chkStartAsIs, "Do not generate any new config file");
            this.chkStartAsIs.UseVisualStyleBackColor = true;
            this.chkStartAsIs.CheckedChanged += new System.EventHandler(this.chkStartAsIs_CheckedChanged);
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(578, 882);
            this.chkDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(83, 24);
            this.chkDebug.TabIndex = 944;
            this.chkDebug.Text = "Debug";
            this.toolTip1.SetToolTip(this.chkDebug, "Check to run with -beta commandline\r\n* Only applies to Arma2/OA beta sevrers");
            this.chkDebug.UseVisualStyleBackColor = true;
            this.chkDebug.CheckedChanged += new System.EventHandler(this.chkDebug_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(46, 631);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 20);
            this.label17.TabIndex = 943;
            this.label17.Text = "Parameters";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 1040);
            this.Controls.Add(this.chkDebug);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtStartupParameters);
            this.Controls.Add(this.chkStartAsIs);
            this.Controls.Add(this.grpProfile);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.chkAutoExit);
            this.Controls.Add(this.chkTooltips);
            this.Controls.Add(this.lblParameters);
            this.Controls.Add(this.txtExtraParameters);
            this.Controls.Add(this.lblServerExe);
            this.Controls.Add(this.btnBrowseExe);
            this.Controls.Add(this.txtServerExe);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.tabContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(874, 850);
            this.Name = "MainForm";
            this.Text = "TADST v3.1.0  - Tophe\'s Arma Dedicated Server Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabContainer.ResumeLayout(false);
            this.tabServerDetails.ResumeLayout(false);
            this.tabServerDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.VoN.ResumeLayout(false);
            this.VoN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCodecQuality)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).EndInit();
            this.tabServerRules.ResumeLayout(false);
            this.tabServerRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDesync)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPacketLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDisconnectTimeOut)).EndInit();
            this.grpMotd.ResumeLayout(false);
            this.grpMotd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMotdInterval)).EndInit();
            this.grpVoting.ResumeLayout(false);
            this.grpVoting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVoteMissionPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoteThreshold)).EndInit();
            this.tabMissions.ResumeLayout(false);
            this.grpMissions.ResumeLayout(false);
            this.grpMissions.PerformLayout();
            this.tabMods.ResumeLayout(false);
            this.grpMods.ResumeLayout(false);
            this.grpMods.PerformLayout();
            this.tabDiffSettings.ResumeLayout(false);
            this.tabDiffSettings.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.grpProfileDifficulty.ResumeLayout(false);
            this.grpProfileDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecisionAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillAI)).EndInit();
            this.tabPerformance.ResumeLayout(false);
            this.tabPerformance.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTerrainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numViewDistance)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabServerScripts.ResumeLayout(false);
            this.tabServerScripts.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabServerDetails;
        private System.Windows.Forms.TabPage tabServerRules;
        private System.Windows.Forms.TabPage tabMissions;
        private System.Windows.Forms.TabPage tabMods;
        private System.Windows.Forms.TabPage tabDiffSettings;
        private System.Windows.Forms.TabPage tabPerformance;
        private System.Windows.Forms.TabPage tabServerScripts;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Label lblParameters;
        private System.Windows.Forms.TextBox txtExtraParameters;
        private System.Windows.Forms.Label lblServerExe;
        private System.Windows.Forms.Button btnBrowseExe;
        private System.Windows.Forms.TextBox txtServerExe;
        private System.Windows.Forms.GroupBox VoN;
        private System.Windows.Forms.CheckBox chkDisableVon;
        private System.Windows.Forms.Label lblCodeQuality;
        private System.Windows.Forms.NumericUpDown numCodecQuality;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMonitorRpt;
        private System.Windows.Forms.Button btnRotateNetLog;
        private System.Windows.Forms.Button btnDeleteNetLog;
        private System.Windows.Forms.Button btnOpenNetLog;
        private System.Windows.Forms.Button btnDeleteRpt;
        private System.Windows.Forms.ComboBox cmbTimeStampFormat;
        private System.Windows.Forms.Button btnOpenRpt;
        private System.Windows.Forms.Button btnOpenPidFile;
        private System.Windows.Forms.Label lblTimeStampFormat;
        private System.Windows.Forms.Button btnOpenRankingFile;
        private System.Windows.Forms.Button btnOpenLogFile;
        private System.Windows.Forms.Label lblRankingFile;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.TextBox txtRankingFile;
        private System.Windows.Forms.TextBox txtConsoleLogfile;
        private System.Windows.Forms.TextBox txtPidfile;
        private System.Windows.Forms.Label lblConsoleLogfile;
        private System.Windows.Forms.CheckBox chkNetlog;
        private System.Windows.Forms.Label lblMaxPLayers;
        private System.Windows.Forms.NumericUpDown numMaxPlayers;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox chkAutoExit;
        private System.Windows.Forms.CheckBox chkTooltips;
        private System.Windows.Forms.TextBox txtRequiredBuild;
        private System.Windows.Forms.CheckBox chkRequiredBuild;
        private System.Windows.Forms.GroupBox grpMotd;
        private System.Windows.Forms.Label lblMotdInterval;
        private System.Windows.Forms.NumericUpDown numMotdInterval;
        private System.Windows.Forms.TextBox txtMotd;
        private System.Windows.Forms.GroupBox grpVoting;
        private System.Windows.Forms.Label lblVotingEnabled;
        private System.Windows.Forms.CheckBox chkEnableVoting;
        private System.Windows.Forms.Label lblVoteMissionPlayers;
        private System.Windows.Forms.NumericUpDown numVoteMissionPlayers;
        private System.Windows.Forms.Label lblVoteThreshold;
        private System.Windows.Forms.NumericUpDown numVoteThreshold;
        private System.Windows.Forms.CheckBox chkKickDuplicates;
        private System.Windows.Forms.GroupBox grpMissions;
        private System.Windows.Forms.Button btnMissionDown;
        private System.Windows.Forms.Button btnMissionUp;
        private System.Windows.Forms.Label lblMissionFilter;
        private System.Windows.Forms.ComboBox cmbMissionFilter;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblAvailableMissions;
        private System.Windows.Forms.Button btnRefreshMissions;
        private System.Windows.Forms.Button btnSelectNoneMissions;
        private System.Windows.Forms.Button btnSelectAllMissions;
        private System.Windows.Forms.Button btnInvertMissionSelection;
        private System.Windows.Forms.CheckedListBox lstMissions;
        private System.Windows.Forms.Label lblSelectedMissions;
        private System.Windows.Forms.Label lblNumOfMissions;
        private System.Windows.Forms.GroupBox grpMods;
        private System.Windows.Forms.Label lblSelectedMods;
        private System.Windows.Forms.Label lblNumOfMods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeModBTN;
        private System.Windows.Forms.Button modUpBTN;
        private System.Windows.Forms.Button modDownBTN;
        private System.Windows.Forms.Button btnSelectNoneMods;
        private System.Windows.Forms.Button btnSelectAllMods;
        private System.Windows.Forms.Button btnInvertMods;
        private System.Windows.Forms.Button btnRefreshMods;
        private System.Windows.Forms.Button btnAddModFolder;
        private System.Windows.Forms.CheckedListBox lstMods;
        private System.Windows.Forms.GroupBox grpProfileDifficulty;
        private System.Windows.Forms.Button resetProfile;
        private System.Windows.Forms.NumericUpDown numPrecisionAI;
        private System.Windows.Forms.NumericUpDown numSkillAI;
        private System.Windows.Forms.CheckedListBox clbDifficultyItems;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numViewDistance;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label MinErrorToSendNearLBL;
        private System.Windows.Forms.TextBox txtMinErrorToSendNear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minBandwidthLBL2;
        private System.Windows.Forms.Label MaxCustomFileSize;
        private System.Windows.Forms.TextBox txtMaxCustomFileSize;
        private System.Windows.Forms.Label MinErrorToSendLBL;
        private System.Windows.Forms.TextBox txtMinErrorToSend;
        private System.Windows.Forms.Label MaxBandwidthLBL;
        private System.Windows.Forms.TextBox txtMaxBandwidth;
        private System.Windows.Forms.Label MinBandwidthLBL;
        private System.Windows.Forms.TextBox txtMinBandwidth;
        private System.Windows.Forms.Label MaxSizeNonguaranteedLBL;
        private System.Windows.Forms.TextBox txtMaxSizeNonguaranteed;
        private System.Windows.Forms.Label MaxSizeGuaranteedLBL;
        private System.Windows.Forms.TextBox txtMaxSizeGuaranteed;
        private System.Windows.Forms.Label MaxMsgSendLBL;
        private System.Windows.Forms.TextBox txtMaxMessagesSend;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numTerrainGrid;
        private System.Windows.Forms.Label doubleIdDetectedLBL;
        private System.Windows.Forms.Label regularCheckLBL;
        private System.Windows.Forms.TextBox txtOnUnsignedData;
        private System.Windows.Forms.TextBox txtRegularCheck;
        private System.Windows.Forms.Label onUnSignedDataLBL;
        private System.Windows.Forms.Label onUserDisconnectedLBL;
        private System.Windows.Forms.Label onHackedDataLBL;
        private System.Windows.Forms.TextBox txtOnUserDisconnected;
        private System.Windows.Forms.TextBox txtOnHackedData;
        private System.Windows.Forms.Label onUserConnectedLBL;
        private System.Windows.Forms.TextBox txtOnDifferentData;
        private System.Windows.Forms.TextBox txtOnUserConnected;
        private System.Windows.Forms.Label onDifferentDataLBL;
        private System.Windows.Forms.TextBox txtDoubleIdDetected;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnProfileSave;
        private System.Windows.Forms.Button btnProfileNew;
        private System.Windows.Forms.ComboBox cmbProfiles;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.ComboBox cmbVerifySignatures;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox txtPerformanceInfo;
        private System.Windows.Forms.Button btnResetPerformance;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSortMods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkStartAsIs;
        private System.Windows.Forms.TextBox txtStartupParameters;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnMonitorNetLog;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMaxPacketSize;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbDefaultDifficulty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtHeadlessIp;
        private System.Windows.Forms.CheckBox chkHeadlessEnabled;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAllMissionsDiff;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblProfileDifficultyInfo;
        private System.Windows.Forms.CheckBox chkEnableHT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPortCheck;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtServerCommandPassword;
        private System.Windows.Forms.CheckBox chkEnableUpnp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbAllowedFilePatching;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtLocalIp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAILevelPreset;
        private System.Windows.Forms.CheckBox chkLoopback;
        private System.Windows.Forms.CheckBox chkAutoinit;
        private System.Windows.Forms.CheckBox chkPersistentBattlefield;
        private System.Windows.Forms.CheckBox chkBattlEye;
        private System.Windows.Forms.CheckBox chkDisconnectTimeout;
        private System.Windows.Forms.NumericUpDown numDisconnectTimeOut;
        private System.Windows.Forms.NumericUpDown numMaxPacketLoss;
        private System.Windows.Forms.CheckBox chkMaxPacketloss;
        private System.Windows.Forms.NumericUpDown numMaxPing;
        private System.Windows.Forms.CheckBox chkMaxPing;
        private System.Windows.Forms.NumericUpDown numMaxDesync;
        private System.Windows.Forms.CheckBox chkMaxDesync;
        private System.Windows.Forms.ComboBox cmbKickClientsOnSlowNetwork;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox chkKickClientsOnSlowNetwork;
    }
}

