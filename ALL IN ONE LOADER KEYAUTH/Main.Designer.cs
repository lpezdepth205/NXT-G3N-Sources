namespace KeyAuth
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation1 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.key = new Siticone.UI.WinForms.SiticoneLabel();
            this.expiry = new Siticone.UI.WinForms.SiticoneLabel();
            this.subscription = new Siticone.UI.WinForms.SiticoneLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendmsg = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.chatmsg = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.ip = new Siticone.UI.WinForms.SiticoneLabel();
            this.hwid = new Siticone.UI.WinForms.SiticoneLabel();
            this.createDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.lastLogin = new Siticone.UI.WinForms.SiticoneLabel();
            this.numUsers = new Siticone.UI.WinForms.SiticoneLabel();
            this.numOnlineUsers = new Siticone.UI.WinForms.SiticoneLabel();
            this.numKeys = new Siticone.UI.WinForms.SiticoneLabel();
            this.version = new Siticone.UI.WinForms.SiticoneLabel();
            this.customerPanelLink = new Siticone.UI.WinForms.SiticoneLabel();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.UnlocksTabPage = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.MWCamoSwapComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.button4 = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.LOADER = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CWCamoSwapComboBox = new Guna.UI2.WinForms.Guna2Button();
            this.SPOOFER = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.key, Siticone.UI.AnimatorNS.DecorationType.None);
            this.key.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.key.Location = new System.Drawing.Point(1221, 82);
            this.key.Margin = new System.Windows.Forms.Padding(2);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(71, 14);
            this.key.TabIndex = 37;
            this.key.Text = "usernameLabel";
            // 
            // expiry
            // 
            this.expiry.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.expiry, Siticone.UI.AnimatorNS.DecorationType.None);
            this.expiry.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expiry.Location = new System.Drawing.Point(1221, 102);
            this.expiry.Margin = new System.Windows.Forms.Padding(2);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(56, 14);
            this.expiry.TabIndex = 38;
            this.expiry.Text = "expiryLabel";
            // 
            // subscription
            // 
            this.subscription.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.subscription, Siticone.UI.AnimatorNS.DecorationType.None);
            this.subscription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subscription.Location = new System.Drawing.Point(1221, 123);
            this.subscription.Margin = new System.Windows.Forms.Padding(2);
            this.subscription.Name = "subscription";
            this.subscription.Size = new System.Drawing.Size(84, 14);
            this.subscription.TabIndex = 39;
            this.subscription.Text = "subscriptionLabel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sender,
            this.Message,
            this.Time});
            this.siticoneTransition1.SetDecoration(this.dataGridView1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.dataGridView1.Location = new System.Drawing.Point(1265, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 227);
            this.dataGridView1.TabIndex = 41;
            // 
            // Sender
            // 
            this.Sender.HeaderText = "Sender";
            this.Sender.Name = "Sender";
            this.Sender.Width = 75;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.Width = 200;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MaxInputLength = 50000;
            this.Time.Name = "Time";
            this.Time.Width = 175;
            // 
            // sendmsg
            // 
            this.sendmsg.BorderColor = System.Drawing.Color.DodgerBlue;
            this.sendmsg.BorderThickness = 1;
            this.sendmsg.CheckedState.Parent = this.sendmsg;
            this.sendmsg.CustomImages.Parent = this.sendmsg;
            this.siticoneTransition1.SetDecoration(this.sendmsg, Siticone.UI.AnimatorNS.DecorationType.None);
            this.sendmsg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.sendmsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendmsg.ForeColor = System.Drawing.Color.White;
            this.sendmsg.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.sendmsg.HoveredState.Parent = this.sendmsg;
            this.sendmsg.Location = new System.Drawing.Point(1607, 510);
            this.sendmsg.Name = "sendmsg";
            this.sendmsg.ShadowDecoration.Parent = this.sendmsg;
            this.sendmsg.Size = new System.Drawing.Size(151, 27);
            this.sendmsg.TabIndex = 42;
            this.sendmsg.Text = "Send";
            this.sendmsg.Click += new System.EventHandler(this.sendmsg_Click);
            // 
            // chatmsg
            // 
            this.chatmsg.AllowDrop = true;
            this.chatmsg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.chatmsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.chatmsg, Siticone.UI.AnimatorNS.DecorationType.None);
            this.chatmsg.DefaultText = "Your message here";
            this.chatmsg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chatmsg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chatmsg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chatmsg.DisabledState.Parent = this.chatmsg;
            this.chatmsg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chatmsg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.chatmsg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatmsg.FocusedState.Parent = this.chatmsg;
            this.chatmsg.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatmsg.HoveredState.Parent = this.chatmsg;
            this.chatmsg.Location = new System.Drawing.Point(1265, 507);
            this.chatmsg.Margin = new System.Windows.Forms.Padding(4);
            this.chatmsg.Name = "chatmsg";
            this.chatmsg.PasswordChar = '\0';
            this.chatmsg.PlaceholderText = "";
            this.chatmsg.SelectedText = "";
            this.chatmsg.ShadowDecoration.Parent = this.chatmsg;
            this.chatmsg.Size = new System.Drawing.Size(335, 30);
            this.chatmsg.TabIndex = 43;
            this.chatmsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.ip, Siticone.UI.AnimatorNS.DecorationType.None);
            this.ip.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ip.Location = new System.Drawing.Point(1221, 141);
            this.ip.Margin = new System.Windows.Forms.Padding(2);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(36, 14);
            this.ip.TabIndex = 44;
            this.ip.Text = "ipLabel";
            // 
            // hwid
            // 
            this.hwid.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.hwid, Siticone.UI.AnimatorNS.DecorationType.None);
            this.hwid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hwid.Location = new System.Drawing.Point(1221, 159);
            this.hwid.Margin = new System.Windows.Forms.Padding(2);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(50, 14);
            this.hwid.TabIndex = 45;
            this.hwid.Text = "hwidLabel";
            // 
            // createDate
            // 
            this.createDate.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.createDate, Siticone.UI.AnimatorNS.DecorationType.None);
            this.createDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createDate.Location = new System.Drawing.Point(1221, 177);
            this.createDate.Margin = new System.Windows.Forms.Padding(2);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(76, 14);
            this.createDate.TabIndex = 46;
            this.createDate.Text = "createDateLabel";
            // 
            // lastLogin
            // 
            this.lastLogin.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.lastLogin, Siticone.UI.AnimatorNS.DecorationType.None);
            this.lastLogin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastLogin.Location = new System.Drawing.Point(1221, 195);
            this.lastLogin.Margin = new System.Windows.Forms.Padding(2);
            this.lastLogin.Name = "lastLogin";
            this.lastLogin.Size = new System.Drawing.Size(69, 14);
            this.lastLogin.TabIndex = 47;
            this.lastLogin.Text = "lastLoginLabel";
            // 
            // numUsers
            // 
            this.numUsers.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.numUsers, Siticone.UI.AnimatorNS.DecorationType.None);
            this.numUsers.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numUsers.Location = new System.Drawing.Point(1526, 82);
            this.numUsers.Margin = new System.Windows.Forms.Padding(2);
            this.numUsers.Name = "numUsers";
            this.numUsers.Size = new System.Drawing.Size(72, 14);
            this.numUsers.TabIndex = 48;
            this.numUsers.Text = "numUsersLabel";
            // 
            // numOnlineUsers
            // 
            this.numOnlineUsers.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.numOnlineUsers, Siticone.UI.AnimatorNS.DecorationType.None);
            this.numOnlineUsers.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOnlineUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numOnlineUsers.Location = new System.Drawing.Point(1526, 102);
            this.numOnlineUsers.Margin = new System.Windows.Forms.Padding(2);
            this.numOnlineUsers.Name = "numOnlineUsers";
            this.numOnlineUsers.Size = new System.Drawing.Size(103, 14);
            this.numOnlineUsers.TabIndex = 49;
            this.numOnlineUsers.Text = "numOnlineUsersLabel";
            // 
            // numKeys
            // 
            this.numKeys.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.numKeys, Siticone.UI.AnimatorNS.DecorationType.None);
            this.numKeys.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKeys.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numKeys.Location = new System.Drawing.Point(1526, 123);
            this.numKeys.Margin = new System.Windows.Forms.Padding(2);
            this.numKeys.Name = "numKeys";
            this.numKeys.Size = new System.Drawing.Size(68, 14);
            this.numKeys.TabIndex = 50;
            this.numKeys.Text = "numKeysLabel";
            // 
            // version
            // 
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.version, Siticone.UI.AnimatorNS.DecorationType.None);
            this.version.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.version.Location = new System.Drawing.Point(1526, 141);
            this.version.Margin = new System.Windows.Forms.Padding(2);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(60, 14);
            this.version.TabIndex = 51;
            this.version.Text = "versionLabel";
            // 
            // customerPanelLink
            // 
            this.customerPanelLink.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.customerPanelLink, Siticone.UI.AnimatorNS.DecorationType.None);
            this.customerPanelLink.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPanelLink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerPanelLink.Location = new System.Drawing.Point(1526, 159);
            this.customerPanelLink.Margin = new System.Windows.Forms.Padding(2);
            this.customerPanelLink.Name = "customerPanelLink";
            this.customerPanelLink.Size = new System.Drawing.Size(115, 14);
            this.customerPanelLink.TabIndex = 52;
            this.customerPanelLink.Text = "customerPanelLinkLabel";
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.UnlocksTabPage);
            this.guna2TabControl1.Controls.Add(this.tabPage5);
            this.guna2TabControl1.Controls.Add(this.tabPage6);
            this.guna2TabControl1.Controls.Add(this.tabPage7);
            this.guna2TabControl1.Controls.Add(this.tabPage8);
            this.guna2TabControl1.Controls.Add(this.tabPage9);
            this.guna2TabControl1.Controls.Add(this.tabPage10);
            this.guna2TabControl1.Controls.Add(this.tabPage11);
            this.guna2TabControl1.Controls.Add(this.tabPage12);
            this.siticoneTransition1.SetDecoration(this.guna2TabControl1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(83, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(836, 62);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(10, 185);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(83, 40);
            this.guna2TabControl1.TabIndex = 92;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // UnlocksTabPage
            // 
            this.UnlocksTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.siticoneTransition1.SetDecoration(this.UnlocksTabPage, Siticone.UI.AnimatorNS.DecorationType.None);
            this.UnlocksTabPage.Location = new System.Drawing.Point(4, 364);
            this.UnlocksTabPage.Name = "UnlocksTabPage";
            this.UnlocksTabPage.Size = new System.Drawing.Size(2, 0);
            this.UnlocksTabPage.TabIndex = 3;
            this.UnlocksTabPage.Text = "                                                          ";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.siticoneTransition1.SetDecoration(this.tabPage5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage5.Location = new System.Drawing.Point(4, 364);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(2, 0);
            this.tabPage5.TabIndex = 4;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage6.Controls.Add(this.button13);
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Controls.Add(this.button14);
            this.tabPage6.Controls.Add(this.button15);
            this.siticoneTransition1.SetDecoration(this.tabPage6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage6.Location = new System.Drawing.Point(4, 364);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(2, 0);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "SPOOFER";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.button13, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(6, 50);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(774, 29);
            this.button13.TabIndex = 115;
            this.button13.Text = "STEP 1 : CLEAN BAN TRACES  - Wait untill beep - Wait 15 seconds";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.siticoneTransition1.SetDecoration(this.button7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(808, 228);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(10, 84);
            this.button7.TabIndex = 92;
            this.button7.Text = "STEP : 3 SPOOFER";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.siticoneTransition1.SetDecoration(this.button3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(906, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 84);
            this.button3.TabIndex = 91;
            this.button3.Text = "STEP : 2 CLEAN BAN TRACES ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.button14, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(6, 14);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(774, 30);
            this.button14.TabIndex = 116;
            this.button14.Text = "CHECK YOUR HWID";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.button15, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(6, 89);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(774, 29);
            this.button15.TabIndex = 117;
            this.button15.Text = "STEP 2 : SPOOF";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.siticoneTransition1.SetDecoration(this.tabPage7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage7.Location = new System.Drawing.Point(4, 364);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(2, 0);
            this.tabPage7.TabIndex = 7;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage8.Controls.Add(this.button6);
            this.tabPage8.Controls.Add(this.button12);
            this.siticoneTransition1.SetDecoration(this.tabPage8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage8.Location = new System.Drawing.Point(4, 364);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(2, 0);
            this.tabPage8.TabIndex = 8;
            this.tabPage8.Text = "LOADER";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.button6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(759, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(10, 52);
            this.button6.TabIndex = 97;
            this.button6.Text = "LOAD IN GAME \r\nUNLOCK ALL TOOL";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.button12, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(758, 10);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(10, 52);
            this.button12.TabIndex = 96;
            this.button12.Text = "LOAD IN GAME \r\nALL IN ONE TOOL\r\n";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.siticoneTransition1.SetDecoration(this.tabPage9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage9.Location = new System.Drawing.Point(4, 364);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(2, 0);
            this.tabPage9.TabIndex = 9;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage10.Controls.Add(this.button8);
            this.tabPage10.Controls.Add(this.button17);
            this.tabPage10.Controls.Add(this.button16);
            this.siticoneTransition1.SetDecoration(this.tabPage10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage10.Location = new System.Drawing.Point(4, 364);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(2, 0);
            this.tabPage10.TabIndex = 10;
            this.tabPage10.Text = "CLEANERS";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.button8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(15, 48);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(754, 29);
            this.button8.TabIndex = 118;
            this.button8.Text = "FORTNITE";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.button17, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(15, 87);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(754, 29);
            this.button17.TabIndex = 120;
            this.button17.Text = "APEX";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.button16, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(15, 12);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(754, 30);
            this.button16.TabIndex = 119;
            this.button16.Text = "CALL OF DUTY ";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.siticoneTransition1.SetDecoration(this.tabPage11, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage11.Location = new System.Drawing.Point(4, 364);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(2, 0);
            this.tabPage11.TabIndex = 11;
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.siticoneTransition1.SetDecoration(this.tabPage12, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage12.Location = new System.Drawing.Point(4, 364);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(2, 0);
            this.tabPage12.TabIndex = 12;
            // 
            // MWCamoSwapComboBox
            // 
            this.MWCamoSwapComboBox.BackColor = System.Drawing.Color.Transparent;
            this.MWCamoSwapComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.MWCamoSwapComboBox.BorderThickness = 2;
            this.siticoneTransition1.SetDecoration(this.MWCamoSwapComboBox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.MWCamoSwapComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MWCamoSwapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MWCamoSwapComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.MWCamoSwapComboBox.FocusedColor = System.Drawing.Color.Transparent;
            this.MWCamoSwapComboBox.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.MWCamoSwapComboBox.FocusedState.Parent = this.MWCamoSwapComboBox;
            this.MWCamoSwapComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MWCamoSwapComboBox.ForeColor = System.Drawing.Color.White;
            this.MWCamoSwapComboBox.HoverState.Parent = this.MWCamoSwapComboBox;
            this.MWCamoSwapComboBox.ItemHeight = 30;
            this.MWCamoSwapComboBox.Items.AddRange(new object[] {
            "CALL OF DUTY ",
            "FORTNITE",
            "APEX"});
            this.MWCamoSwapComboBox.ItemsAppearance.Parent = this.MWCamoSwapComboBox;
            this.MWCamoSwapComboBox.Location = new System.Drawing.Point(12, 117);
            this.MWCamoSwapComboBox.Name = "MWCamoSwapComboBox";
            this.MWCamoSwapComboBox.ShadowDecoration.Parent = this.MWCamoSwapComboBox;
            this.MWCamoSwapComboBox.Size = new System.Drawing.Size(175, 36);
            this.MWCamoSwapComboBox.TabIndex = 98;
            this.MWCamoSwapComboBox.SelectedIndexChanged += new System.EventHandler(this.MWCamoSwapComboBox_SelectedIndexChanged);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.guna2Button7.BorderThickness = 2;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.siticoneTransition1.SetDecoration(this.guna2Button7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.DisabledState.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Location = new System.Drawing.Point(12, 165);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(175, 36);
            this.guna2Button7.TabIndex = 99;
            this.guna2Button7.Text = "Apply";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.siticoneTransition1.SetDecoration(this.button4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(11, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(553, 47);
            this.button4.TabIndex = 120;
            this.button4.Text = "NXT-G3N - SOFTWARE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.siticoneTransition1.SetDecoration(this.guna2Button1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(389, 165);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(175, 36);
            this.guna2Button1.TabIndex = 122;
            this.guna2Button1.Text = "Apply";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // LOADER
            // 
            this.LOADER.BackColor = System.Drawing.Color.Transparent;
            this.LOADER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.LOADER.BorderThickness = 2;
            this.siticoneTransition1.SetDecoration(this.LOADER, Siticone.UI.AnimatorNS.DecorationType.None);
            this.LOADER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LOADER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LOADER.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.LOADER.FocusedColor = System.Drawing.Color.Transparent;
            this.LOADER.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.LOADER.FocusedState.Parent = this.LOADER;
            this.LOADER.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOADER.ForeColor = System.Drawing.Color.White;
            this.LOADER.HoverState.Parent = this.LOADER;
            this.LOADER.ItemHeight = 30;
            this.LOADER.Items.AddRange(new object[] {
            "VG - MW - UNLOCK",
            "VG-MW - AIO",
            "CW - ZOMBIES",
            "FORNITE",
            "SPLITGATE",
            "ROBLOX",
            "CSGO",
            "GTA5"});
            this.LOADER.ItemsAppearance.Parent = this.LOADER;
            this.LOADER.Location = new System.Drawing.Point(389, 117);
            this.LOADER.Name = "LOADER";
            this.LOADER.ShadowDecoration.Parent = this.LOADER;
            this.LOADER.Size = new System.Drawing.Size(175, 36);
            this.LOADER.TabIndex = 121;
            this.LOADER.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // CWCamoSwapComboBox
            // 
            this.CWCamoSwapComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CWCamoSwapComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.CWCamoSwapComboBox.BorderThickness = 2;
            this.CWCamoSwapComboBox.CheckedState.Parent = this.CWCamoSwapComboBox;
            this.CWCamoSwapComboBox.CustomImages.Parent = this.CWCamoSwapComboBox;
            this.siticoneTransition1.SetDecoration(this.CWCamoSwapComboBox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.CWCamoSwapComboBox.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CWCamoSwapComboBox.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CWCamoSwapComboBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CWCamoSwapComboBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CWCamoSwapComboBox.DisabledState.Parent = this.CWCamoSwapComboBox;
            this.CWCamoSwapComboBox.FillColor = System.Drawing.Color.Transparent;
            this.CWCamoSwapComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CWCamoSwapComboBox.ForeColor = System.Drawing.Color.White;
            this.CWCamoSwapComboBox.HoverState.Parent = this.CWCamoSwapComboBox;
            this.CWCamoSwapComboBox.Location = new System.Drawing.Point(202, 165);
            this.CWCamoSwapComboBox.Name = "CWCamoSwapComboBox";
            this.CWCamoSwapComboBox.ShadowDecoration.Parent = this.CWCamoSwapComboBox;
            this.CWCamoSwapComboBox.Size = new System.Drawing.Size(175, 36);
            this.CWCamoSwapComboBox.TabIndex = 124;
            this.CWCamoSwapComboBox.Text = "Apply";
            this.CWCamoSwapComboBox.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // SPOOFER
            // 
            this.SPOOFER.BackColor = System.Drawing.Color.Transparent;
            this.SPOOFER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.SPOOFER.BorderThickness = 2;
            this.siticoneTransition1.SetDecoration(this.SPOOFER, Siticone.UI.AnimatorNS.DecorationType.None);
            this.SPOOFER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SPOOFER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SPOOFER.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SPOOFER.FocusedColor = System.Drawing.Color.Transparent;
            this.SPOOFER.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.SPOOFER.FocusedState.Parent = this.SPOOFER;
            this.SPOOFER.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPOOFER.ForeColor = System.Drawing.Color.White;
            this.SPOOFER.HoverState.Parent = this.SPOOFER;
            this.SPOOFER.ItemHeight = 30;
            this.SPOOFER.Items.AddRange(new object[] {
            "HWID CHECKER",
            "HWID CLEANER",
            "HWID SPOOFER"});
            this.SPOOFER.ItemsAppearance.Parent = this.SPOOFER;
            this.SPOOFER.Location = new System.Drawing.Point(202, 117);
            this.SPOOFER.Name = "SPOOFER";
            this.SPOOFER.ShadowDecoration.Parent = this.SPOOFER;
            this.SPOOFER.Size = new System.Drawing.Size(175, 36);
            this.SPOOFER.TabIndex = 123;
            this.SPOOFER.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.siticoneTransition1.SetDecoration(this.button5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 36);
            this.button5.TabIndex = 125;
            this.button5.Text = "CLEANERS";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.siticoneTransition1.SetDecoration(this.button9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(389, 68);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 36);
            this.button9.TabIndex = 126;
            this.button9.Text = "LOADER";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.siticoneTransition1.SetDecoration(this.button10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(202, 68);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(175, 36);
            this.button10.TabIndex = 127;
            this.button10.Text = "SPOOFER";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(574, 215);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.CWCamoSwapComboBox);
            this.Controls.Add(this.SPOOFER);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.LOADER);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.MWCamoSwapComboBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.customerPanelLink);
            this.Controls.Add(this.version);
            this.Controls.Add(this.numKeys);
            this.Controls.Add(this.numOnlineUsers);
            this.Controls.Add(this.numUsers);
            this.Controls.Add(this.lastLogin);
            this.Controls.Add(this.createDate);
            this.Controls.Add(this.hwid);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.chatmsg);
            this.Controls.Add(this.sendmsg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.subscription);
            this.Controls.Add(this.expiry);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneLabel subscription;
        private Siticone.UI.WinForms.SiticoneLabel expiry;
        private Siticone.UI.WinForms.SiticoneLabel key;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private Siticone.UI.WinForms.SiticoneRoundedButton sendmsg;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox chatmsg;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneLabel ip;
        private Siticone.UI.WinForms.SiticoneLabel hwid;
        private Siticone.UI.WinForms.SiticoneLabel createDate;
        private Siticone.UI.WinForms.SiticoneLabel lastLogin;
        private Siticone.UI.WinForms.SiticoneLabel numUsers;
        private Siticone.UI.WinForms.SiticoneLabel numOnlineUsers;
        private Siticone.UI.WinForms.SiticoneLabel numKeys;
        private Siticone.UI.WinForms.SiticoneLabel customerPanelLink;
        private Siticone.UI.WinForms.SiticoneLabel version;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage UnlocksTabPage;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2ComboBox MWCamoSwapComboBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private Guna.UI2.WinForms.Guna2Button CWCamoSwapComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox SPOOFER;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox LOADER;
    }
}