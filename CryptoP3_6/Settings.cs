using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace CryptoP3_6
{
    public partial class SettingsForm : Form
    {
        Form1 parForm;
        public SettingsForm(Form1 f)
        {
            InitializeComponent();
            textBoxIp.Text = GetLocalIp();
            textBoxIp2.Text = GetLocalIp();
            ipTrentTB.Text = GetLocalIp();
            parForm = f;
        }

        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                EndPoint localPoint = new IPEndPoint(IPAddress.Parse(textBoxIp.Text), Convert.ToInt32(textBoxPort.Text));
                EndPoint remotePoint = new IPEndPoint(IPAddress.Parse(textBoxIp2.Text), Convert.ToInt32(textBoxPort2.Text));
                EndPoint trentPoint = new IPEndPoint(IPAddress.Parse(ipTrentTB.Text), Convert.ToInt32(portTrentTB.Text));
                parForm.setLocalPont = localPoint;
                parForm.setRemotePoint = remotePoint;
                parForm.setTrentPoint = trentPoint;
                parForm.StartButton.Enabled = true;
                parForm.setNames(nameTB1.Text, nameTB2.Text);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
