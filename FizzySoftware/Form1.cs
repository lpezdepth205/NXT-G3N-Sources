using System;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using KeyAuth;
using COD2019TOOL;

namespace Reblunted_Cross_Camos
{
    public partial class Form1 : Form
	{
        private bool mouseDown;
        private Point lastLocation;

        static string name = ""; // application name. right above the blurred text aka the secret on the licenses tab among other tabs
        static string ownerid = ""; // ownerid, found in account settings. click your profile picture on top right of dashboard and then account settings.
        static string secret = ""; // app secret, the blurred text on licenses tab and other tabs
        static string version = "1.0"; // leave alone unless you've changed version on website

        public static api KeyAuthApp = new api(name, ownerid, secret, version);

        public Form1()
		{
			InitializeComponent();
		}

		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{
            if (KeyAuthApp.register(userTB.Text, passTB.Text, tokenTB.Text))
            {
                Form1 main = new Form1();
                MessageBox.Show("Your Info Was Valid! | SKYWALKER");
                main.Show();
                this.Hide();
            }
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			SetDNS("1.1.1.1"); // this should resolve any issues with people who are getting blocked by their ISP. you could also change DNS manually or go to 1.1.1.1 and download their app, though this is the best way for your clients I presume
			KeyAuthApp.init();
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (KeyAuthApp.login(username.Text, password.Text))
            {
                MainForm main = new MainForm();
                MessageBox.Show("Your Info Was Valid! | SKYWALKER");
                main.Show();
                this.Hide();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Register.Show();
            Login.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Login.Show();
            Register.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}