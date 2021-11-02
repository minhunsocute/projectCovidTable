using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sever
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }
        SimpleTcpClient Client;

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (Client.IsConnected)
            {
                if (!string.IsNullOrEmpty(textMessage.Text))
                {
                    Client.Send(textMessage.Text);
                    textInfo.Text += $"Me: {textMessage.Text}{Environment.NewLine}";
                    textMessage.Text = string.Empty;
                }
            }   
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void inputIP()
        {
            
        }
        private void client_Load(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnSend.Enabled = false;
        }

        private void Event_DataReceived(object sender, DataReceivedEventArgs e)
        {
            textInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
        }

        private void Event_DisConnected(object sender, ClientDisconnectedEventArgs e)
        {
            textInfo.Text += $"Server disconnected. {Environment.NewLine}";
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            textInfo.Text += $"Server connected. {Environment.NewLine}";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textIP.Text))
            {
                Client = new SimpleTcpClient($"{textIP.Text}:{textPort.Text}");
                Client.Events.Connected += Events_Connected;
                Client.Events.Disconnected += Event_DisConnected;
                Client.Events.DataReceived += Event_DataReceived;
                btnSend.Enabled = false;
                btnConnect.Enabled = true;
                guna2Button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("IP server is null", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
