namespace COD2019TOOL
{
	// Token: 0x02000004 RID: 4
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002E05 File Offset: 0x00001005
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002E24 File Offset: 0x00001024
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.ProcOpenLabel = new DarkUI.Controls.DarkLabel();
            this.MWCamoCombobox = new DarkUI.Controls.DarkComboBox();
            this.CWCamoCombobox = new DarkUI.Controls.DarkComboBox();
            this.ApplyMW = new DarkUI.Controls.DarkButton();
            this.ApplyCW = new DarkUI.Controls.DarkButton();
            this.ResetMW = new DarkUI.Controls.DarkButton();
            this.ResetCW = new DarkUI.Controls.DarkButton();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.darkButton4 = new DarkUI.Controls.DarkButton();
            this.darkButton5 = new DarkUI.Controls.DarkButton();
            this.VGCamoSwapComboBox = new DarkUI.Controls.DarkComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProcOpenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcOpenLabel.ForeColor = System.Drawing.Color.Lime;
            this.ProcOpenLabel.Location = new System.Drawing.Point(680, 9);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(70, 13);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "Not Found!";
            // 
            // MWCamoCombobox
            // 
            this.MWCamoCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MWCamoCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MWCamoCombobox.FormattingEnabled = true;
            this.MWCamoCombobox.Items.AddRange(new object[] {
            "Gold (MW)",
            "Platinum (MW)",
            "Damascus (MW)",
            "Obsidian (MW)",
            "Gold (CW)",
            "Diamond (CW)",
            "Dark Matter (CW)",
            "Golden Viper (ZM)",
            "Plague Diamond (ZM)",
            "Dark Aether (ZM)",
            "Cherry Blossom",
            "ActivCamo",
            "Banded",
            "Atlanta FaZe",
            "Chicago Huntsmen",
            "Dallas Empire",
            "Florida Mutineers",
            "Los Angeles Guerrillas",
            "London Royal Ravens",
            "Minnesota RÃ˜KKR",
            "New York Subliners",
            "OpTic Gaming Los Angeles",
            "Paris Legion",
            "Seattle Surge",
            "Toronto Ultra"});
            this.MWCamoCombobox.Location = new System.Drawing.Point(272, 102);
            this.MWCamoCombobox.Name = "MWCamoCombobox";
            this.MWCamoCombobox.Size = new System.Drawing.Size(120, 21);
            this.MWCamoCombobox.TabIndex = 2;
            // 
            // CWCamoCombobox
            // 
            this.CWCamoCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CWCamoCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CWCamoCombobox.FormattingEnabled = true;
            this.CWCamoCombobox.Items.AddRange(new object[] {
            "Gold (MW)",
            "Platinum (MW)",
            "Damascus (MW)",
            "Obsidian (MW)",
            "Gold (CW)",
            "Diamond (CW)",
            "Dark Matter (CW)",
            "Golden Viper (ZM)",
            "Plague Diamond (ZM)",
            "Dark Aether (ZM)",
            "Cherry Blossom",
            "ActivCamo",
            "Banded",
            "Atlanta FaZe",
            "Chicago Huntsmen",
            "Dallas Empire",
            "Florida Mutineers",
            "Los Angeles Guerrillas",
            "London Royal Ravens",
            "Minnesota RÃ˜KKR",
            "New York Subliners",
            "OpTic Gaming Los Angeles",
            "Paris Legion",
            "Seattle Surge",
            "Toronto Ultra"});
            this.CWCamoCombobox.Location = new System.Drawing.Point(509, 102);
            this.CWCamoCombobox.Name = "CWCamoCombobox";
            this.CWCamoCombobox.Size = new System.Drawing.Size(120, 21);
            this.CWCamoCombobox.TabIndex = 3;
            // 
            // ApplyMW
            // 
            this.ApplyMW.BackColor = System.Drawing.Color.Gray;
            this.ApplyMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyMW.ForeColor = System.Drawing.Color.Black;
            this.ApplyMW.Location = new System.Drawing.Point(272, 145);
            this.ApplyMW.Name = "ApplyMW";
            this.ApplyMW.Padding = new System.Windows.Forms.Padding(5);
            this.ApplyMW.Size = new System.Drawing.Size(120, 57);
            this.ApplyMW.TabIndex = 4;
            this.ApplyMW.Text = "APPLY";
            this.ApplyMW.Click += new System.EventHandler(this.ApplyMW_Click);
            // 
            // ApplyCW
            // 
            this.ApplyCW.BackColor = System.Drawing.Color.Transparent;
            this.ApplyCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyCW.Location = new System.Drawing.Point(509, 145);
            this.ApplyCW.Name = "ApplyCW";
            this.ApplyCW.Padding = new System.Windows.Forms.Padding(5);
            this.ApplyCW.Size = new System.Drawing.Size(120, 57);
            this.ApplyCW.TabIndex = 5;
            this.ApplyCW.Text = "APPLY";
            this.ApplyCW.Click += new System.EventHandler(this.ApplyCW_Click);
            // 
            // ResetMW
            // 
            this.ResetMW.BackColor = System.Drawing.Color.Transparent;
            this.ResetMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetMW.Location = new System.Drawing.Point(272, 221);
            this.ResetMW.Name = "ResetMW";
            this.ResetMW.Padding = new System.Windows.Forms.Padding(5);
            this.ResetMW.Size = new System.Drawing.Size(120, 57);
            this.ResetMW.TabIndex = 6;
            this.ResetMW.Text = "RESET";
            this.ResetMW.Click += new System.EventHandler(this.ResetMW_Click);
            // 
            // ResetCW
            // 
            this.ResetCW.BackColor = System.Drawing.Color.Transparent;
            this.ResetCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetCW.Location = new System.Drawing.Point(509, 221);
            this.ResetCW.Name = "ResetCW";
            this.ResetCW.Padding = new System.Windows.Forms.Padding(5);
            this.ResetCW.Size = new System.Drawing.Size(120, 57);
            this.ResetCW.TabIndex = 7;
            this.ResetCW.Text = "RESET";
            this.ResetCW.Click += new System.EventHandler(this.ResetCW_Click);
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.BackColor = System.Drawing.Color.Red;
            this.darkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel2.ForeColor = System.Drawing.Color.Black;
            this.darkLabel2.Location = new System.Drawing.Point(683, 33);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(56, 13);
            this.darkLabel2.TabIndex = 11;
            this.darkLabel2.Text = "Process:";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(40, 29);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 15;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(0, 267);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(40, 45);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 14;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 312);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // darkButton1
            // 
            this.darkButton1.BackColor = System.Drawing.Color.Transparent;
            this.darkButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton1.Location = new System.Drawing.Point(52, 12);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(120, 57);
            this.darkButton1.TabIndex = 13;
            this.darkButton1.Text = "MW";
            // 
            // darkButton2
            // 
            this.darkButton2.BackColor = System.Drawing.Color.Transparent;
            this.darkButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton2.Location = new System.Drawing.Point(509, 12);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(120, 57);
            this.darkButton2.TabIndex = 14;
            this.darkButton2.Text = "CW";
            // 
            // darkButton3
            // 
            this.darkButton3.BackColor = System.Drawing.Color.Transparent;
            this.darkButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton3.Location = new System.Drawing.Point(272, 12);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(129, 57);
            this.darkButton3.TabIndex = 18;
            this.darkButton3.Text = "VG";
            // 
            // darkButton4
            // 
            this.darkButton4.BackColor = System.Drawing.Color.Transparent;
            this.darkButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton4.Location = new System.Drawing.Point(52, 221);
            this.darkButton4.Name = "darkButton4";
            this.darkButton4.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton4.Size = new System.Drawing.Size(121, 64);
            this.darkButton4.TabIndex = 17;
            this.darkButton4.Text = "RESET";
            // 
            // darkButton5
            // 
            this.darkButton5.BackColor = System.Drawing.Color.Gray;
            this.darkButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton5.ForeColor = System.Drawing.Color.Black;
            this.darkButton5.Location = new System.Drawing.Point(51, 145);
            this.darkButton5.Name = "darkButton5";
            this.darkButton5.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton5.Size = new System.Drawing.Size(122, 64);
            this.darkButton5.TabIndex = 16;
            this.darkButton5.Text = "APPLY";
            this.darkButton5.Click += new System.EventHandler(this.darkButton5_Click);
            // 
            // VGCamoSwapComboBox
            // 
            this.VGCamoSwapComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.VGCamoSwapComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VGCamoSwapComboBox.FormattingEnabled = true;
            this.VGCamoSwapComboBox.Items.AddRange(new object[] {
            "Gold (VG)",
            "Diamond  (VG)",
            "Automic  (VG)"});
            this.VGCamoSwapComboBox.Location = new System.Drawing.Point(51, 102);
            this.VGCamoSwapComboBox.Name = "VGCamoSwapComboBox";
            this.VGCamoSwapComboBox.Size = new System.Drawing.Size(121, 21);
            this.VGCamoSwapComboBox.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 310);
            this.Controls.Add(this.darkButton3);
            this.Controls.Add(this.darkButton4);
            this.Controls.Add(this.darkButton5);
            this.Controls.Add(this.VGCamoSwapComboBox);
            this.Controls.Add(this.darkButton2);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.ResetCW);
            this.Controls.Add(this.ResetMW);
            this.Controls.Add(this.ApplyCW);
            this.Controls.Add(this.ApplyMW);
            this.Controls.Add(this.CWCamoCombobox);
            this.Controls.Add(this.MWCamoCombobox);
            this.Controls.Add(this.ProcOpenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "SKYWALKERS\'s | Cross Camo Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400000A RID: 10
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000B RID: 11
		private global::System.ComponentModel.BackgroundWorker BGWorker;

		// Token: 0x0400000D RID: 13
		private global::DarkUI.Controls.DarkLabel ProcOpenLabel;

		// Token: 0x0400000E RID: 14
		private global::DarkUI.Controls.DarkComboBox MWCamoCombobox;

		// Token: 0x0400000F RID: 15
		private global::DarkUI.Controls.DarkComboBox CWCamoCombobox;

		// Token: 0x04000010 RID: 16
		private global::DarkUI.Controls.DarkButton ApplyMW;

		// Token: 0x04000011 RID: 17
		private global::DarkUI.Controls.DarkButton ApplyCW;

		// Token: 0x04000012 RID: 18
		private global::DarkUI.Controls.DarkButton ResetMW;

		// Token: 0x04000013 RID: 19
		private global::DarkUI.Controls.DarkButton ResetCW;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Panel panel1;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkButton darkButton3;
        private DarkUI.Controls.DarkButton darkButton4;
        private DarkUI.Controls.DarkButton darkButton5;
        private DarkUI.Controls.DarkComboBox VGCamoSwapComboBox;
    }
}
