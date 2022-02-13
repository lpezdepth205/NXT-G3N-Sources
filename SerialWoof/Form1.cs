using Microsoft.Win32;
using SerialWoof.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SerialWoof
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var myForm = new SerialWoof();
            myForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                string dir = @"C:\BlitzWare";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/932404628392402994/Warzone.exe", @"C:\BlitzWare\Warzone.exe");
                }

                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "Warzone.exe";
                process.StartInfo.WorkingDirectory = @"C:\BlitzWare";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                string dir = @"C:\BlitzWare";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/932145425966858301/kdmapper.exe", @"C:\BlitzWare\kdmapper.exe");
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/932145426902188112/driver.sys", @"C:\BlitzWare\driver.sys");
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/932145425765502997/DriverMapper.bat.bat", @"C:\BlitzWare\DriverMapper.bat.bat");
                }

                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "DriverMapper.bat.bat";
                process.StartInfo.WorkingDirectory = @"C:\BlitzWare";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            Hide();
            var myForm = new SerialWoof();
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
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

        private void button1_Click(object sender, EventArgs e)
        {
            {
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
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/925385851599462432/932893755936227338/LeakedSpoof.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");

                }
                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "LeakedSpoof.exe";
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
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
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/933008889635565648/Spooof.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.bat");
            Environment.Exit(0);
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.bat");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            {
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
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/933013186314108988/HWID_Checker.bat", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.bat");
                }

                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "HWID_Checker.bat";
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            {
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

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            {
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

        private void button15_Click_1(object sender, EventArgs e)
        {
            {
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

        private void button8_Click(object sender, EventArgs e)
        {
            {
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

        private void siticoneGradientPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneGradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            {
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

        private void button16_Click(object sender, EventArgs e)
        {
            {
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

        private void button6_Click(object sender, EventArgs e)
        {
            {
                {
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
                        webClient.DownloadFile("http://nxtg3ncheats.com/download/WORKING.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\WORKING.exe");

                    }
                    var process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "WORKING.exe";
                    process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();

                }
            }
        }
    }
}
