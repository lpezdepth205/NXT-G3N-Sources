using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Forms;
using Guna.UI2.WinForms;
using Memory;

namespace COD2019TOOL
{
    // Token: 0x02000004 RID: 4
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        // Token: 0x0600000C RID: 12 RVA: 0x000024A3 File Offset: 0x000006A3
        public MainForm()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600000D RID: 13 RVA: 0x000024BC File Offset: 0x000006BC
        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.ProcOpen = this.m.OpenProcess("ModernWarfare");
            Thread.Sleep(600);
            this.BGWorker.ReportProgress(0);
            using (Process currentProcess = Process.GetCurrentProcess())
            {
                currentProcess.PriorityClass = ProcessPriorityClass.High;
            }
        }

        // Token: 0x0600000E RID: 14 RVA: 0x00002524 File Offset: 0x00000724
        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.BGWorker.RunWorkerAsync();
        }

        // Token: 0x0600000F RID: 15 RVA: 0x00002534 File Offset: 0x00000734
        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (this.ProcOpen)
            {
                this.ProcOpenLabel.ForeColor = Color.Green;
                this.ProcOpenLabel.Text = "Found!";
                return;
            }
            this.ProcOpenLabel.ForeColor = Color.Red;
            this.ProcOpenLabel.Text = "Not Found!";
        }

        // Token: 0x06000010 RID: 16 RVA: 0x000025AA File Offset: 0x000007AA
        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.BGWorker.RunWorkerAsync();
        }

        // Token: 0x06000011 RID: 17 RVA: 0x000025B8 File Offset: 0x000007B8
        private void ApplyMW_Click(object sender, EventArgs e)
        {
            if (!this.ProcOpen)
            {
                DarkMessageBox.ShowError("Please Open MW/WZ First", "Error", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "")
            {
                DarkMessageBox.ShowError("Please select a camo first.", "Error", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "MW Gold")
            {
                this.m.WriteMemory("base+22E67804,50,90C,7", "bytes", "63 61 6D 6F 5F 31 31 61 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00", "", null);
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Gold.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "MW Platinum")
            {
                this.m.WriteMemory("base+22E67804,50,90C,7", "bytes", "63 61 6D 6F 5F 31 31 62 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00", "", null);
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Platinum.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "MW Damascus")
            {
                this.m.WriteMemory("base+22E67804,50,90C,7", "bytes", "63 61 6D 6F 5F 31 31 63 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00", "", null);
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Damascus.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "MW Obsidian")
            {
                this.m.WriteMemory("base+22E67804,50,90C,7", "bytes", "63 61 6D 6F 5F 31 31 64 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00", "", null);
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Obsidian.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "CW Gold")
            {
                this.m.WriteMemory("base+1A7F4000,2BC,58,A97", "bytes", "63 61 6D 6F 5F 30 31 61 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00", "", null);
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to CW Gold.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "CW Diamond")
            {
                this.m.WriteMemory("base+1A7F4000,2BC,58,A97", "bytes", "63 61 6D 6F 5F 30 31 61 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00", "", null);
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to CW Diamond.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "CW DM Ultra")
            {
                this.m.WriteMemory("base+1A7F4000,2BC,58,A97", "bytes", "63 61 6D 6F 5F 30 31 61 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00", "", null);
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to CW DM Ultra.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "ZM Golden Viper")
            {
                DarkMessageBox.ShowWarning("Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                this.m.WriteMemory("base+1A7F4000,2BC,58,A97", "bytes", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 67 6F 6C 64 00 41 54 54 45 52 00 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00", "", null);
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray Paint' category and equip 'Desert Snake' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "ZM Plague Diamond")
            {
                DarkMessageBox.ShowWarning("Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                this.m.WriteMemory("base+1A7F4000,2BC,58,A97", "bytes", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 64 69 61 6D 6F 6E 64 00 45 52 00 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00", "", null);
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray Paint' category and equip 'Desert Snake' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                return;
            }
            if (this.MWCamoCombobox.Text == "ZM Dark Aether")
            {
                DarkMessageBox.ShowWarning("Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                this.m.WriteMemory("base+1A7F4000,2BC,58,A97", "bytes", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 64 61 72 6B 6D 61 74 74 65 72 00 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00", "", null);
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray Paint' category and equip 'Desert Snake' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT", DarkDialogButton.Ok);
            }
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002984 File Offset: 0x00000B84
        private void ResetMW_Click(object sender, EventArgs e)
        {
            if (this.ProcOpen)
            {
                this.m.WriteMemory("base+1A7F4000,2BC,58,A97", "bytes", "63 61 6D 6F 5F 30 31 61 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00", "", null);
                DarkMessageBox.ShowInformation("MW Camos reset successfully.", "Success", DarkDialogButton.Ok);
                return;
            }
            DarkMessageBox.ShowError("Please Open MW/WZ First", "Error", DarkDialogButton.Ok);
        }

        // Token: 0x06000013 RID: 19 RVA: 0x000029E0 File Offset: 0x00000BE0
        private void ApplyCW_Click(object sender, EventArgs e)
        {
            if (!this.ProcOpen)
            {
                DarkMessageBox.ShowError("Please Open MW/WZ First", "Error", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "")
            {
                DarkMessageBox.ShowError("Please select a camo first.", "Error", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "MW Gold")
            {
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to MW Gold.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "MW Platinum")
            {
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to MW Platinum.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "MW Damascus")
            {
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to MW Damascus.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "MW Obsidian")
            {
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to MW Obsidian.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "CW Gold")
            {
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6d 6f 5f 6d 70 5f 74 39 6d 61 73 74 65 72 79 5f 67 6f 6c 64 00", "", null);
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to CW Gold.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "CW Diamond")
            {
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to CW Diamond.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "CW DM Ultra")
            {
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to CW DM Ultra.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "ZM Golden Viper")
            {
                DarkMessageBox.ShowWarning("Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray' category and equip 'Shards' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                DarkMessageBox.ShowWarning("The camo should now be on the gun, but it will not stick and you can't save it as a blueprint yet. So, simply copy and paste the class you are doing this in, and the camo should be permanent in the pasted class. Press Ok once you have pasted the class.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                DarkMessageBox.ShowInformation("CW 'Shards' camo set to CW Golden Viper. Now, RESET CAMOS TO DEFAULT OR YOU MAY NOT BE ABLE TO JOIN GAMES.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "ZM Plague Diamond")
            {
                DarkMessageBox.ShowWarning("Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6d 6f 5f 7a 6d 5f 74 39 6d 61 73 74 65 72 79 5f 64 69 61 6d 6f 6e 64 00", "", null);
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray' category and equip 'Shards' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                return;
            }
            if (this.CWCamoCombobox.Text == "ZM Dark Aether")
            {
                DarkMessageBox.ShowWarning("Zombies camos are special, as you must be in the camo menu while you apply the camo. Press Ok once you are in the camo menu with all of the camo categories.", "Warning | IMPORTANT", DarkDialogButton.Ok);
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6d 6f 5f 7a 6d 5f 74 39 6d 61 73 74 65 72 79 5f 64 61 72 6b 6d 61 74 74 65 72 00", "", null);
                DarkMessageBox.ShowWarning("The camo has been applied. Now, click the 'Spray' category and equip 'Shards' camo. Press Ok once you have equipped the camo.", "Warning | IMPORTANT", DarkDialogButton.Ok);
            }
        }

        // Token: 0x06000014 RID: 20 RVA: 0x00002DAC File Offset: 0x00000FAC
        private void ResetCW_Click(object sender, EventArgs e)
        {
            if (this.ProcOpen)
            {
                this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
                DarkMessageBox.ShowInformation("CW Camos reset successfully.", "Success", DarkDialogButton.Ok);
                return;
            }
            DarkMessageBox.ShowError("Please Open MW/WZ First", "Error", DarkDialogButton.Ok);
        }

        // Token: 0x04000008 RID: 8
        public Mem m = new Mem();

        // Token: 0x04000009 RID: 9
        private bool ProcOpen;

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you have any questions or issues with this tool please contact us: skywalker tools");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/vchCTT446n");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void darkButton5_Click(object sender, EventArgs e)
        {
            if (!this.ProcOpen)
            {
                DarkMessageBox.ShowError("Please Open MW/WZ First", "Error", DarkDialogButton.Ok);
                return;
            }
            if (this.VGCamoSwapComboBox.Text == "")
            {
                DarkMessageBox.ShowError("Please select a camo first.", "Error", DarkDialogButton.Ok);
                return;
            }
            if (this.VGCamoSwapComboBox.Text == "Gold(VG)")
            {
                this.m.WriteMemory("base+22E67804,50,90C,7", "bytes", "73 34 5F 63 61 6D 6F 5F 31 31 61", "", null);
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Gold.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.VGCamoSwapComboBox.Text == "Diamond(VG)")
            {
                this.m.WriteMemory("base+22E67804,50,90C,7", "bytes", "73 34 5F 63 61 6D 6F 5F 31 31 62", "", null);
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Platinum.", "Success", DarkDialogButton.Ok);
                return;
            }
            if (this.VGCamoSwapComboBox.Text == "Automic(VG)")
            {
                this.m.WriteMemory("base+22E67804,50,90C,7", "bytes", "73 34 5F 63 61 6D 6F 5F 31 31 63", "", null);
                DarkMessageBox.ShowInformation("MW 'Desert Snake' camo set to MW Damascus.", "Success", DarkDialogButton.Ok);
                return;
            }
        }

        private void darkButton8_Click(object sender, EventArgs e)
        {
            this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
        }

        private void darkButton7_Click(object sender, EventArgs e)
        {
            this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
        }

        private void darkButton9_Click(object sender, EventArgs e)
        {
            this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
        }

        private void darkButton10_Click(object sender, EventArgs e)
        {
            this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
        }

        private void darkButton6_Click(object sender, EventArgs e)
        {
            this.m.WriteMemory("base+1A4D27F0,38,788,0", "bytes", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 32", "", null);
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void darkButton12_Click(object sender, EventArgs e)
        {

        }
    }
}



   