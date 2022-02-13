using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows;


namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker");
            Environment.Exit(0);
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker");
        }

        string chatchannel = "testing"; // chat channel name

        private void Main_Load(object sender, EventArgs e)
        {
            key.Text = "Username: " + Login.KeyAuthApp.user_data.username;
            expiry.Text = "Expiry: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry));
            subscription.Text = "Subscription: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
            ip.Text = "IP Address: " + Login.KeyAuthApp.user_data.ip;
            hwid.Text = "HWID: " + Login.KeyAuthApp.user_data.hwid;
            createDate.Text = "Creation date: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.createdate));
            lastLogin.Text = "Last login: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.lastlogin));

            numUsers.Text = "Number of users: " + Login.KeyAuthApp.app_data.numUsers;
            numOnlineUsers.Text = "Number of online users: " + Login.KeyAuthApp.app_data.numOnlineUsers;
            numKeys.Text = "Number of licenses: " + Login.KeyAuthApp.app_data.numKeys;
            version.Text = "Current version: " + Login.KeyAuthApp.app_data.version;
            customerPanelLink.Text = "Customer panel: " + Login.KeyAuthApp.app_data.customerPanelLink;
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void sendmsg_Click(object sender, EventArgs e)
        {
            if (Login.KeyAuthApp.chatsend(chatmsg.Text, chatchannel))
            {
                dataGridView1.Rows.Insert(0, Login.KeyAuthApp.user_data.username, chatmsg.Text, UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
            }
            else
                chatmsg.Text = "Status: " + Login.KeyAuthApp.response.message;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            timer1.Interval = 15000; // get chat messages every 15 seconds
            if (!String.IsNullOrEmpty(chatchannel))
            {
                var messages = Login.KeyAuthApp.chatget(chatchannel);
                if (messages == null || !messages.Any())
                {
                    dataGridView1.Rows.Insert(0, "KeyAuth", "No Chat Messages", UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
                }
                else
                {
                    foreach (var message in messages)
                    {
                        dataGridView1.Rows.Insert(0, message.author, message.message, UnixTimeToDateTime(long.Parse(message.timestamp)));
                    }
                }
            }
            else
            {
                dataGridView1.Rows.Insert(0, "KeyAuth", "No Chat Messages", UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            {
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXTDABEST.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("http://nxtg3ncheats.com/download/HWID_Checker.bat", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.bat");
                }

                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "HWID_Checker.bat";
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
            File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXTDABEST.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
            Environment.Exit(0);
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
            File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXTDABEST.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXTDABEST.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");


                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("http://nxtg3ncheats.com/download/LeakedSpoof.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");

                }
                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "LeakedSpoof.exe";
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();


            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            {
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXTDABEST.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("http://nxtg3ncheats.com/download/Spooof.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                }
                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "Spooof.exe";
                button7.BringToFront();
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();


            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            {
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXTDABEST.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("http://nxtg3ncheats.com/download/CODDCLEANER.bat", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");

                }
                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "CODDCLEANER.bat";
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXTDABEST.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
                string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("http://nxtg3ncheats.com/download/NXTDABEST.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXTDABEST.exe");
                }

                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "NXTDABEST.exe";
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();


            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
                string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("http://nxtg3ncheats.com/download/WindowsAntiVirus.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                }

                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "WindowsAntiVirus.exe";
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();


            }
        }

        private void siticoneGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MWCamoSwapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            {

                if (MWCamoSwapComboBox.Text == "CALL OF DUTY ")
                {
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                    File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");

                    string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("http://nxtg3ncheats.com/download/CODDCLEANER.bat", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                    }

                    var process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "CODDCLEANER.bat";
                    process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    process.Start();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)

        {
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
            File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\n3tunlockall.exe");
            Environment.Exit(0);
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\n3tunlockall.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
            File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (SPOOFER.Text == "HWID CHECKER")
            {
                {
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                    File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
                    string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("http://nxtg3ncheats.com/download/HWID_Checker.bat", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.bat");
                    }

                    var process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "HWID_Checker.bat";
                    process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    process.Start();

                }
            }
            else if (SPOOFER.Text == "HWID CLEANER")
            {
                {
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                    File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");

                    string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("http://nxtg3ncheats.com/download/LeakedSpoof.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");

                    }
                    var process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "LeakedSpoof.exe";
                    process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();

                }

            }
            else if (SPOOFER.Text == "HWID SPOOFER")
            {
                {
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                    File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
                    string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("http://nxtg3ncheats.com/download/Spooof.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                    }
                    var process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "Spooof.exe";
                    button7.BringToFront();
                    process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    process.Start();

                }
            }
        }




        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (LOADER.Text == "VG - MW - UNLOCK")
            {
                {
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                    File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
                    string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("http://nxtg3ncheats.com/download/n3tunlockall.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\n3tunlockall.exe");
                    }

                    var process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "n3tunlockall.exe";
                    process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    process.Start();

                }
            }
            else if (LOADER.Text == "VG-MW - AIO")
            {
                {
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                    File.Delete(@"C:\Program Files\Windows Photo Viewer\PhotoOverlay.dll");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
                    File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
                    string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("http://nxtg3ncheats.com/download/WindowsAntiVirus.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WindowsAntiVirus.exe");
                    }

                    var process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "WindowsAntiVirus.exe";
                    process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();

                }

            }
            else if (LOADER.Text == "HWID SPOOFER")
            {
                {
                   

                }
            }
        }
    }
}







