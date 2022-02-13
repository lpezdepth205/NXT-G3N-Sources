using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//dont touch this it will Fuck it all up
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        static string name = "NXT-G3NS-BOT-LOBBY"; //use Your Thing For Your Name 
        static string ownerid = "Fz3gVsv2vZ"; // Owner Id 
        static string secret = "0bcc981d006d7c1308929a2ce049e27347d28bc4e66f554c36436c00bd38eaa6"; // Your Secret For Your key Thing 
        static string version = "1.0"; // Version Keep 1,0 Sice You DOnt You Use THis 
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public static api KeyAuthApp = new api(name, ownerid, secret, version);

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SetDNS("1.1.1.1");//dont touch 
            KeyAuthApp.init();//dont touch 
            password.PasswordChar = Check.Checked ? '\0' : '*';//dont touch 

        }

        private void UpgradeBtn_Click(object sender, EventArgs e)
        {


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (KeyAuthApp.login(username.Text, password.Text))
            {
                KeyAuthApp.log("Some one Just Loged In");
                MessageBox.Show("....");// Put Your Custom Message You want Lol 
                System.Threading.Thread.Sleep(2000);//take time to load Menu
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void RgstrBtn_Click(object sender, EventArgs e)
        {

        }

        private void LicBtn_Click(object sender, EventArgs e)
        {

        }

        public static NetworkInterface GetActiveEthernetOrWifiNetworkInterface()
        {
            var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
                a => a.OperationalStatus == OperationalStatus.Up &&
                (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
                a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork"));

            return Nic;
        }

        public static void SetDNS(string DnsString)
        {
            string[] Dns = { DnsString };
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Description"].ToString().Equals(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = Dns;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }

        public static void UnsetDNS()
        {
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Description"].ToString().Equals(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = null;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }

        private void key_TextChanged(object sender, EventArgs e)
        {

        }
        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void username_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = Check.Checked ? '\0' : '*';//dont touch 

        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = Check.Checked ? '\0' : '*';//dont touch 
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            if (KeyAuthApp.login(username.Text, password.Text))
            {
                KeyAuthApp.log(""); //Useing webhook To send When Some one Send In <3 
                MessageBox.Show("...."); //Custom Message Once They Log In
                System.Threading.Thread.Sleep(2000);//This is So It take Time To Load Menu
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void RgstrBtn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Please Make A Ticket in Server Thanks");// You can Link Your Discord Here And It Will Make them Join
        }

        private void UpgradeBtn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Make A Ticket in Server To Upgrade You're Member Ship Thanks");// You can Link Your Discord Here And It Will Make them Join
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();//Rainbow Buttons 
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
          
            UpgradeBtn.BorderColor = Color.FromArgb(A, R, G, B);
            password.ForeColor = Color.FromArgb(A, R, G, B);
            username.ForeColor = Color.FromArgb(A, R, G, B);
          
        }

        private void siticoneRoundedButton7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/7e4qeWkEn6%22");// Put Your discord Here 
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            {
                System.Diagnostics.Process.Start("https://nxt-g3n-software.com/%22");// Put Your discord Here 
            }
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            {
                System.Diagnostics.Process.Start("https://t.me/NXTG3N%22");// Put Your discord Here 
            }
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCQJjN_MpPd0jM2l2D_HLN6A%22");// Put Your discord Here 
            }
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void username_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Make A Ticket in Server Thanks");// You can Link Your Discord Here And It Will Make them Join
        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            if (KeyAuthApp.login(username.Text, password.Text))
            {
                KeyAuthApp.log(""); //Useing webhook To send When Some one Send In <3 
                MessageBox.Show("...."); //Custom Message Once They Log In
                System.Threading.Thread.Sleep(2000);//This is So It take Time To Load Menu
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(38, 36);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(210, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.guna2Button1);
            this.Name = "Login";
            this.ResumeLayout(false);

        }
    }
}
