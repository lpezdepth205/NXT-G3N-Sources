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
    public partial class SerialWoof : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public SerialWoof()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            string dir = @"C:\BlitzWare";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            Process startCE = new Process();
            startCE.StartInfo.FileName = "C:\\Program Files\\Cheat Engine 7.3\\cheatengine-x86_64-SSE4-AVX2.exe";
            startCE.Start();

            if (!File.Exists("C:\\BlitzWare\\mem.txt"))
            {
                File.WriteAllText("C:\\BlitzWare\\mem.txt", Resources.mem);
            }

            Process.Start(@"C:\BlitzWare\mem.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process unloadDriver = new Process();
            unloadDriver.StartInfo.FileName = "C:\\Program Files\\Cheat Engine 7.3\\Kernelmoduleunloader.exe";
            unloadDriver.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string dir = @"C:\BlitzWare";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/897176358776623107/917496027114786856/HWID_Checker.bat", @"C:\BlitzWare\HWID_Checker.bat");
            }
            var process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "HWID_Checker.bat";
            process.StartInfo.WorkingDirectory = @"C:\BlitzWare";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\BlitzWare\\mem.txt"))
            {
                File.Delete("C:\\BlitzWare\\mem.txt");
            }
            var process2 = new Process();
            process2.StartInfo.RedirectStandardInput = true;
            process2.StartInfo.UseShellExecute = false;
            process2.StartInfo.CreateNoWindow = true;
            process2.StartInfo.FileName = "cmd.exe";
            process2.Start();
            process2.StandardInput.WriteLine("del \"C:\\BlitzWare\\HWID_Checker.bat\" /s /f /q");
            var myStreamWriter = process2.StandardInput;
            myStreamWriter.Close();
            process2.WaitForExit();
            string dir = @"C:\BlitzWare";
            if (Directory.Exists(dir))
            {
                Directory.Delete(dir);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void SerialWoof_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void SerialWoof_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void SerialWoof_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // apex cleaning + spoofing
            string[] gpus = new string[]
            {
                "GeForce GTX TITAN Z",
            "NVIDIA TITAN Xp",
            "GeForce GTX 1080 Ti",
            "GeForce GTX TITAN X",
            "GeForce GTX 690",
            "GeForce GTX TITAN Black",
            "GeForce GTX 780 Ti",
            "GeForce GTX 980 Ti",
            "GeForce GTX TITAN",
            "GeForce GTX 1080",
            "GeForce GTX 780",
            "GeForce GTX 980",
            "GeForce GTX 1070",
            "GeForce GTX 970",
            "GeForce GTX 770",
            "GeForce GTX 680",
            "GeForce GTX 760 Ti (OEM)",
            "GeForce GTX 670",
            "GeForce GTX 660 Ti",
            "GeForce GTX 1060 (6GB)",
            "GeForce GTX 960 (OEM)",
            "GeForce GTX 760 192-bit(OEM)",
            "GeForce GTX 760",
            "GeForce GTX 1060 (3GB)",
            "GeForce GTX 660 (OEM)",
            "GeForce GTX 960",
            "GeForce GTX 950 (OEM)",
            "GeForce GTX 590",
            "GeForce GTX 660",
            "GeForce GTX 1050 Ti",
            "GeForce GTX 950",
            "GeForce GTX 650 Ti BOOST",
            "GeForce GTX 650 Ti",
            "GeForce GTX 1050",
            "GeForce GTX 750 Ti",
            "GeForce GTX 645 (OEM)",
            "GeForce GTX 750",
            "GeForce GTX 580",
            "GeForce GTX 480",
            "GeForce GTX 570",
            "GeForce GTX 295",
            "GeForce GTX 470",
            "GeForce GTX 745 (OEM)",
            "GeForce GT 740",
            "GeForce GT 730",
            "GeForce GT 635 (OEM)",
            "GeForce GTX 650",
            "GeForce GTX 560 Ti",
            "GeForce GTX 560 (OEM)",
            "GeForce GT 640",
            "GeForce GTX 465",
            "GeForce GTX 560 Ti (OEM)",
            "GeForce GTX 460",
            "GeForce GTX 560",
            "GeForce GTX 460 SE",
            "GeForce GTX 555 (OEM)",
            "GeForce GTX 285 for Mac",
            "GeForce GTX 285",
            "GeForce GTX 280",
            "GeForce GT 720",
            "GeForce GT 710",
            "GeForce GTS 450",
            "GeForce GTX 550 Ti",
            "GeForce GT 630 (OEM)",
            "GeForce GT 640 (OEM)",
            "GeForce GT 545 GDDR5 (OEM)",
            "GeForce GT 545 DDR3",
            "GeForce GTS 250",
            "GeForce GTS 150",
            "GeForce GTS 240 (OEM Product)",
            "GeForce GT 630",
            "GeForce GT 620",
            "GeForce GT 440",
            "GeForce GT 430",
            "GeForce GT 530 (OEM)",
            "GeForce GT 340 (OEM)",
            "GeForce GT 330 (OEM)",
            "GeForce GT 240",
            "GeForce GT 320 (OEM Product)",
            "GeForce GT 705 (OEM)",
            "GeForce GT 620 (OEM)",
            "GeForce GT 610",
            "GeForce GT 520 (OEM)",
            "GeForce GT 520",
            "GeForce GT 220",
            "GeForce 605 (OEM)",
            "GeForce 510 (OEM)",
            "GeForce 405 (OEM)",
            "GeForce 310 (OEM)"
            };

            Random r = new Random();
            if (!WindowsIdentity.GetCurrent().Owner.IsWellKnown(WellKnownSidType.BuiltinAdministratorsSid))
            {
                throw new Exception("Please run this program as administrator");
            }
            var commonSettings = Registry.CurrentUser.CreateSubKey("Software\\Contoso\\Common Settings");
            var sessionSettings = commonSettings.CreateSubKey("Current Session", (RegistryKeyPermissionCheck)RegistryOptions.Volatile);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "ComputerHardwareId", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 1\\Target Id 0\\Logical Unit Id 0", "Identifier", RandomString(15));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 1\\Target Id 0\\Logical Unit Id 0", "SerialNumber", RandomString(15));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000", "DriverDesc", gpus[r.Next(0, gpus.Length)]);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "BuildGUID", Guid.NewGuid());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductID", string.Concat(new string[]
            {
                randomFromLength(5),
                "-",
                randomFromLength(5),
                "-",
                randomFromLength(5),
                "-",
                randomFromLength(5)
            }));

            string randomFromLength(int length)
            {
                string text = "";
                for (int i = 0; i < length; i++)
                {
                    text += r.Next(0, 15).ToString("X");
                }
                return text;
            }

            string RandomString(int length)
            {
                return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
                                   select s[r.Next(s.Length)]).ToArray<char>());
            }

            // Apex Cleaner
            string dir = Environment.SpecialFolder.ApplicationData + "\\Temp";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/897176358776623107/913084111265087550/Apex_Cleaner.bat", dir);
            }
            Process startApexCleaner = new Process();
            startApexCleaner.StartInfo.UseShellExecute = true;
            startApexCleaner.StartInfo.FileName = "Apex_Cleaner";
            startApexCleaner.StartInfo.WorkingDirectory = dir;
            startApexCleaner.StartInfo.Verb = "runas";
            startApexCleaner.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startApexCleaner.Start();
            startApexCleaner.WaitForExit();
            // Delete after execute
            Process deleteApexCleaner = new Process();
            deleteApexCleaner.StartInfo.RedirectStandardInput = true;
            deleteApexCleaner.StartInfo.UseShellExecute = false;
            deleteApexCleaner.StartInfo.CreateNoWindow = true;
            deleteApexCleaner.StartInfo.FileName = "cmd.exe";
            deleteApexCleaner.Start();
            deleteApexCleaner.StandardInput.WriteLine("del \"" + Environment.SpecialFolder.ApplicationData + "\\Temp\\Apex_Cleaner.bat" + "\" /s /f /q");
            var myStreamWriter = deleteApexCleaner.StandardInput;
            myStreamWriter.Close();
            deleteApexCleaner.WaitForExit();

            Random random = new Random();
            Process changePCName = new Process();
            changePCName.StartInfo.RedirectStandardInput = true;
            changePCName.StartInfo.UseShellExecute = false;
            changePCName.StartInfo.CreateNoWindow = true;
            changePCName.StartInfo.FileName = "cmd.exe";
            changePCName.Start();
            changePCName.StandardInput.WriteLine("WMIC computersystem where caption='%computername%' rename " + random.Next(0, int.MaxValue).ToString());
            var myStreamWriter2 = changePCName.StandardInput;
            myStreamWriter2.Close();
            changePCName.WaitForExit();
            // end of apex cleaning + spoofing
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            Thread.Sleep(1000);

            Random random = new Random();
            Process changePCName = new Process();
            changePCName.StartInfo.RedirectStandardInput = true;
            changePCName.StartInfo.UseShellExecute = false;
            changePCName.StartInfo.CreateNoWindow = true;
            changePCName.StartInfo.FileName = "";
            changePCName.Start();
            changePCName.StandardInput.WriteLine("" + random.Next(0, int.MaxValue).ToString());
            var myStreamWriter2 = changePCName.StandardInput;
            myStreamWriter2.Close();
            changePCName.WaitForExit();

            Random random2 = new Random();
            var motherboardSpoof = new Process();
            motherboardSpoof.StartInfo.RedirectStandardInput = true;
            motherboardSpoof.StartInfo.UseShellExecute = false;
            motherboardSpoof.StartInfo.CreateNoWindow = true;
            motherboardSpoof.StartInfo.FileName = "";
            motherboardSpoof.StartInfo.WorkingDirectory = @"C:\Temp";
            motherboardSpoof.Start();
            motherboardSpoof.StandardInput.WriteLine("");
            motherboardSpoof.StandardInput.WriteLine("A" + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("AMID64.exe /SU auto");
            motherboardSpoof.StandardInput.WriteLine("AMIDEx64.exe /BS " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("AMIDEx64.exe /SK " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("AMIDNx64.exe /SF " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("AMIDNx64.exe /CS " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("AMIDEWIN.exe /PSN " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("t / y");
            motherboardSpoof.StandardInput.WriteLine(" / y");
            motherboardSpoof.StandardInput.WriteLine("");
            motherboardSpoof.StandardInput.WriteLine("");
            var myStreamWriter = motherboardSpoof.StandardInput;
            myStreamWriter.Close();
            motherboardSpoof.WaitForExit();

            if (File.Exists("C:\\Temp\\AMIDN.exe"))
            {
                File.Delete("C:\\Temp\\AMIN.exe");
            }
            if (File.Exists("C:\\Temp\\AMIDNx64.exe"))
            {
                File.Delete("C:\\Temp\\AMINx64.exe");
            }
            if (File.Exists("C:\\Temp\\amidrv64.sys"))
            {
                File.Delete("C:\\Temp\\aldrv64.sys");
            }
            if (File.Exists("C:\\Temp\\D16.exe"))
            {
                File.Delete("C:\\Temp\\DM6.exe");
            }
            if (File.Exists("C:\\Temp\\DMDIT.exe"))
            {
                File.Delete("C:\\Temp\\DMDIT.exe");
            }
            if (File.Exists("C:\\Temp\\UCEDLL.DLL"))
            {
                File.Delete("C:\\Temp\\UREDLL.DLL");
            }
            if (File.Exists("C:\\Temp\\UCESYS.SYS"))
            {
                File.Delete("C:\\Temp\\UCESYS.SYS");
            }
            if (File.Exists("C:\\Temp\\OREVXD.VXD"))
            {
                File.Delete("C:\\Temp\\UCOEVXD.VXD");
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void ProcOpenLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UnlocksTabPage_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
           
            Thread.Sleep(1000);

            Random random = new Random();
            Process changePCName = new Process();
            changePCName.StartInfo.RedirectStandardInput = true;
            changePCName.StartInfo.UseShellExecute = false;
            changePCName.StartInfo.CreateNoWindow = true;
            changePCName.StartInfo.FileName = "cmd.exe";
            changePCName.Start();
            changePCName.StandardInput.WriteLine("WMIC computersystem where caption='%computername%' rename " + random.Next(0, int.MaxValue).ToString());
            var myStreamWriter2 = changePCName.StandardInput;
            myStreamWriter2.Close();
            changePCName.WaitForExit();

            Random random2 = new Random();
            var motherboardSpoof = new Process();
            motherboardSpoof.StartInfo.RedirectStandardInput = true;
            motherboardSpoof.StartInfo.UseShellExecute = false;
            motherboardSpoof.StartInfo.CreateNoWindow = true;
            motherboardSpoof.StartInfo.FileName = "cmd.exe";
            motherboardSpoof.StartInfo.WorkingDirectory = @"C:\Temp";
            motherboardSpoof.Start();
            motherboardSpoof.StandardInput.WriteLine("AMIDEWIN.exe /SU /BS /SS /SK /SF /CS /PSN");
            motherboardSpoof.StandardInput.WriteLine("AMIDEWINx64.exe /SS " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("AMIDEWINx64.exe /SU auto");
            motherboardSpoof.StandardInput.WriteLine("AMIDEWINx64.exe /BS " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("AMIDEWINx64.exe /SK " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("AMIDEWINx64.exe /SF " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("AMIDEWINx64.exe /CS " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("AMIDEWINx64.exe /PSN " + random2.Next(5, 9).ToString());
            motherboardSpoof.StandardInput.WriteLine("net stop winmgmt / y");
            motherboardSpoof.StandardInput.WriteLine("net start winmgmt / y");
            motherboardSpoof.StandardInput.WriteLine("sc stop winmgmt");
            motherboardSpoof.StandardInput.WriteLine("sc start winmgmt");
            var myStreamWriter = motherboardSpoof.StandardInput;
            myStreamWriter.Close();
            motherboardSpoof.WaitForExit();

            if (File.Exists("C:\\Temp\\AMIDEWIN.exe"))
            {
                File.Delete("C:\\Temp\\AMIDEWIN.exe");
            }
            if (File.Exists("C:\\Temp\\AMIDEWINx64.exe"))
            {
                File.Delete("C:\\Temp\\AMIDEWINx64.exe");
            }
            if (File.Exists("C:\\Temp\\amifldrv64.sys"))
            {
                File.Delete("C:\\Temp\\amifldrv64.sys");
            }
            if (File.Exists("C:\\Temp\\DMI16.exe"))
            {
                File.Delete("C:\\Temp\\DMI16.exe");
            }
            if (File.Exists("C:\\Temp\\DMIEDIT.exe"))
            {
                File.Delete("C:\\Temp\\DMIEDIT.exe");
            }
            if (File.Exists("C:\\Temp\\UCOREDLL.DLL"))
            {
                File.Delete("C:\\Temp\\UCOREDLL.DLL");
            }
            if (File.Exists("C:\\Temp\\UCORESYS.SYS"))
            {
                File.Delete("C:\\Temp\\UCORESYS.SYS");
            }
            if (File.Exists("C:\\Temp\\UCOREVXD.VXD"))
            {
                File.Delete("C:\\Temp\\UCOREVXD.VXD");
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            // apex cleaning + spoofing
            string[] gpus = new string[]
            {
                "GeForce GTX TITAN Z",
            "NVIDIA TITAN Xp",
            "GeForce GTX 1080 Ti",
            "GeForce GTX TITAN X",
            "GeForce GTX 690",
            "GeForce GTX TITAN Black",
            "GeForce GTX 780 Ti",
            "GeForce GTX 980 Ti",
            "GeForce GTX TITAN",
            "GeForce GTX 1080",
            "GeForce GTX 780",
            "GeForce GTX 980",
            "GeForce GTX 1070",
            "GeForce GTX 970",
            "GeForce GTX 770",
            "GeForce GTX 680",
            "GeForce GTX 760 Ti (OEM)",
            "GeForce GTX 670",
            "GeForce GTX 660 Ti",
            "GeForce GTX 1060 (6GB)",
            "GeForce GTX 960 (OEM)",
            "GeForce GTX 760 192-bit(OEM)",
            "GeForce GTX 760",
            "GeForce GTX 1060 (3GB)",
            "GeForce GTX 660 (OEM)",
            "GeForce GTX 960",
            "GeForce GTX 950 (OEM)",
            "GeForce GTX 590",
            "GeForce GTX 660",
            "GeForce GTX 1050 Ti",
            "GeForce GTX 950",
            "GeForce GTX 650 Ti BOOST",
            "GeForce GTX 650 Ti",
            "GeForce GTX 1050",
            "GeForce GTX 750 Ti",
            "GeForce GTX 645 (OEM)",
            "GeForce GTX 750",
            "GeForce GTX 580",
            "GeForce GTX 480",
            "GeForce GTX 570",
            "GeForce GTX 295",
            "GeForce GTX 470",
            "GeForce GTX 745 (OEM)",
            "GeForce GT 740",
            "GeForce GT 730",
            "GeForce GT 635 (OEM)",
            "GeForce GTX 650",
            "GeForce GTX 560 Ti",
            "GeForce GTX 560 (OEM)",
            "GeForce GT 640",
            "GeForce GTX 465",
            "GeForce GTX 560 Ti (OEM)",
            "GeForce GTX 460",
            "GeForce GTX 560",
            "GeForce GTX 460 SE",
            "GeForce GTX 555 (OEM)",
            "GeForce GTX 285 for Mac",
            "GeForce GTX 285",
            "GeForce GTX 280",
            "GeForce GT 720",
            "GeForce GT 710",
            "GeForce GTS 450",
            "GeForce GTX 550 Ti",
            "GeForce GT 630 (OEM)",
            "GeForce GT 640 (OEM)",
            "GeForce GT 545 GDDR5 (OEM)",
            "GeForce GT 545 DDR3",
            "GeForce GTS 250",
            "GeForce GTS 150",
            "GeForce GTS 240 (OEM Product)",
            "GeForce GT 630",
            "GeForce GT 620",
            "GeForce GT 440",
            "GeForce GT 430",
            "GeForce GT 530 (OEM)",
            "GeForce GT 340 (OEM)",
            "GeForce GT 330 (OEM)",
            "GeForce GT 240",
            "GeForce GT 320 (OEM Product)",
            "GeForce GT 705 (OEM)",
            "GeForce GT 620 (OEM)",
            "GeForce GT 610",
            "GeForce GT 520 (OEM)",
            "GeForce GT 520",
            "GeForce GT 220",
            "GeForce 605 (OEM)",
            "GeForce 510 (OEM)",
            "GeForce 405 (OEM)",
            "GeForce 310 (OEM)"
            };

            Random r = new Random();
            if (!WindowsIdentity.GetCurrent().Owner.IsWellKnown(WellKnownSidType.BuiltinAdministratorsSid))
            {
                throw new Exception("Please run this program as administrator");
            }
            var commonSettings = Registry.CurrentUser.CreateSubKey("Software\\Contoso\\Common Settings");
            var sessionSettings = commonSettings.CreateSubKey("Current Session", (RegistryKeyPermissionCheck)RegistryOptions.Volatile);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "ComputerHardwareId", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 1\\Target Id 0\\Logical Unit Id 0", "Identifier", RandomString(15));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 1\\Target Id 0\\Logical Unit Id 0", "SerialNumber", RandomString(15));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000", "DriverDesc", gpus[r.Next(0, gpus.Length)]);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "BuildGUID", Guid.NewGuid());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductID", string.Concat(new string[]
            {
                randomFromLength(5),
                "-",
                randomFromLength(5),
                "-",
                randomFromLength(5),
                "-",
                randomFromLength(5)
            }));

            string randomFromLength(int length)
            {
                string text = "";
                for (int i = 0; i < length; i++)
                {
                    text += r.Next(0, 15).ToString("X");
                }
                return text;
            }

            string RandomString(int length)
            {
                return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
                                   select s[r.Next(s.Length)]).ToArray<char>());
            }

            // Apex Cleaner + EAC
            string dir = Environment.SpecialFolder.ApplicationData + "\\Temp";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/897176358776623107/913084111265087550/Apex_Cleaner.bat", dir);
            }
            Process startApexCleaner = new Process();
            startApexCleaner.StartInfo.UseShellExecute = true;
            startApexCleaner.StartInfo.FileName = "Apex_Cleaner.bat";
            startApexCleaner.StartInfo.WorkingDirectory = dir;
            startApexCleaner.StartInfo.Verb = "runas";
            startApexCleaner.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startApexCleaner.Start();
            startApexCleaner.WaitForExit();
            // Delete after execute
            Process deleteApexCleaner = new Process();
            deleteApexCleaner.StartInfo.RedirectStandardInput = true;
            deleteApexCleaner.StartInfo.UseShellExecute = false;
            deleteApexCleaner.StartInfo.CreateNoWindow = true;
            deleteApexCleaner.StartInfo.FileName = "cmd.exe";
            deleteApexCleaner.Start();
            deleteApexCleaner.StandardInput.WriteLine("del \"" + Environment.SpecialFolder.ApplicationData + "\\Temp\\Apex_Cleaner.bat" + "\" /s /f /q");
            var myStreamWriter = deleteApexCleaner.StandardInput;
            myStreamWriter.Close();
            deleteApexCleaner.WaitForExit();

            Random random = new Random();
            Process changePCName = new Process();
            changePCName.StartInfo.RedirectStandardInput = true;
            changePCName.StartInfo.UseShellExecute = false;
            changePCName.StartInfo.CreateNoWindow = true;
            changePCName.StartInfo.FileName = "cmd.exe";
            changePCName.Start();
            changePCName.StandardInput.WriteLine("WMIC computersystem where caption='%computername%' rename " + random.Next(0, int.MaxValue).ToString());
            var myStreamWriter2 = changePCName.StandardInput;
            myStreamWriter2.Close();
            changePCName.WaitForExit();
            // end of apex cleaning + spoofing
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            string dir = @"C:\BlitzWare";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/929426675907846227/929440368821416077/HWID_Checker.bat", @"C:\BlitzWare\HWID_Checker.bat");
            }

            var process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "HWID_Checker.bat";
            process.StartInfo.WorkingDirectory = @"C:\BlitzWare";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            Process unloadDriver = new Process();
            unloadDriver.StartInfo.FileName = "C:\\Program Files\\Cheat Engine 7.3\\Kernelmoduleunloader.exe";
            unloadDriver.Start();
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            string dir = @"C:\BlitzWare";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/929426675907846227/929440368821416077/HWID_Checker.bat", @"C:\BlitzWare\HWID_Checker.bat");
            }
            var process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "HWID_Checker.bat";
            process.StartInfo.WorkingDirectory = @"C:\BlitzWare";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            {
                string dir = @"C:\BlitzWare";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                using (WebClient webClient = new WebClient())
                { 
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/929444416039575612/hwid_spoofer.exe", @"C:\BlitzWare\hwid_spoofer.exe");
                }
                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "hwid_spoofer.exe";
                process.StartInfo.WorkingDirectory = @"C:\BlitzWare";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
               
            }
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            {
                string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/929444453830262894/NXT-G3N_SOFTWARE_HWID_SPOOFER_RICOCHET_BYPASSED.exe", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXT-G3N_SOFTWARE_HWID_SPOOFER_RICOCHET_BYPASSED.exe");
                }

                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "NXT-G3N_SOFTWARE_HWID_SPOOFER_RICOCHET_BYPASSED.exe";
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
                Thread.Sleep(80000);
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXT-G3N_SOFTWARE_HWID_SPOOFER_RICOCHET_BYPASSED.exe");
                Thread.Sleep(100000);
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\NXT-G3N_SOFTWARE_HWID_SPOOFER_RICOCHET_BYPASSED.exe");
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/929426675907846227/929440368821416077/HWID_Checker.bat", @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.bat");
            }

            var process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "HWID_Checker.bat";
            process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            Thread.Sleep(10000);
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.bat");

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }
        string pfile = "";
        public static string outputString = "Loaded";
        public static void Print(string text)
        {
            outputString += "\n" + text;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "dll file (*.dll)|*.dll|exe file (*.exe)|*.exe";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.Title = "Select a file";


                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                           
                        }
                        catch (Exception ex)
                        {

                        }
                      
                        pfile = openFileDialog.FileName;

                        Print($"Added file : {openFileDialog.SafeFileName} ({openFileDialog.FileName})");

                    }
                }
            }
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            {
                string dir = @"C:\BlitzWare";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/929444424935673916/MacTrace.bat", @"C:\BlitzWare\MacTrace.bat");
                }
                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "MacTrace.bat";
                process.StartInfo.WorkingDirectory = @"C:\BlitzWare";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Hide();
            var myForm = new Form1();
            myForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            {
                string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/932361841173233744/CODDCLEANER.bat", @"C:\BlitzWare\CODDCLEANER.bat");
                }

                var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "CODDCLEANER.bat";
                process.StartInfo.WorkingDirectory = @"C:\BlitzWare";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
            }
        }

   

        private void button3_Click_1(object sender, EventArgs e)
        {
            {
                {
                    string dir = @"C:\BlitzWare";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("https://cdn.discordapp.com/attachments/925385851599462432/932893755936227338/LeakedSpoof.exe", @"C:\BlitzWare\LeakedSpoof.exe");

                    }
                    var process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "LeakedSpoof.exe";
                    process.StartInfo.WorkingDirectory = @"C:\BlitzWare";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();

                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                {
                    string dir = @"C:\BlitzWare";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("https://cdn.discordapp.com/attachments/924784008997503086/932910774790283314/Spooof.exe", @"C:\BlitzWare\Spooof.exe");
                    }
                    var process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "Spooof.exe";
                    process.StartInfo.WorkingDirectory = @"C:\BlitzWare";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    process.Start();

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            var myForm = new Form1();
            myForm.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
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
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
               

            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            {
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
                File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
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

        private void button11_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.bat");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\Spooof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\LeakedSpoof.exe");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\HWID_Checker.bat");
            File.Delete(@"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64\CODDCLEANER.bat");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            string dir = @"C:\Program Files\Windows Defender\Offline\DGJQC-OXMP5-KZ1JU-BADKY-MRMJQ\Files\x64";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            Hide();
            var myForm = new Form1();
            myForm.Show();
        }

        private void siticoneGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }
    }
}


