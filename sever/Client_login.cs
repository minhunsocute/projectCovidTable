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
    public partial class Client_login : Form
    {
        int check = 0;
        string table_data = "";
        public SimpleTcpClient Client;
        public Client_login()
        {
            InitializeComponent();
        }

        private void creatIP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textIP.Text))
            {
                Client = new SimpleTcpClient($"{textIP.Text}:{textPort.Text}");
                Client.Events.Connected += Events_Connected;
                Client.Events.Disconnected += Event_DisConnected;
                Client.Events.DataReceived += Event_DataReceived;
                btnConnect.Enabled = true;
                creatIP.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ip server is null", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void open()
        {
            //((Control)this.show).Enabled = true;
            ((Control)this.show).Invoke(new Action(() =>
            {
                ((Control)this.show).Enabled = true;
            }));
            Client.Send("Allresult");
            mainControl.Invoke(new Action(() =>
            {
                mainControl.SelectedTab = mainControl.TabPages["show"];
            }));
            ((Control)this.Loginpage).Invoke(new Action(() =>
            {
                ((Control)this.Loginpage).Enabled = false;
            }));
            ((Control)this.createPage).Invoke(new Action(() =>
            {
                ((Control)this.createPage).Enabled = false;
            }));
        }
        private void Event_DataReceived(object sender, DataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            //textInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            string Str_check = Encoding.UTF8.GetString(e.Data);
            if(Encoding.UTF8.GetString(e.Data)== "Invalid")
            {
                MessageBox.Show("Username or Password is Invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            }
            else if(Encoding.UTF8.GetString(e.Data)== "Invalid1")
            {
                MessageBox.Show("Registration failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            }
            else if(Encoding.UTF8.GetString(e.Data)== "Success1")
            {
                MessageBox.Show("Registration successed", "Mesaage", MessageBoxButtons.OK, MessageBoxIcon.None);
                //textInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                user.Invoke(new Action(() =>{user.Text = string.Empty;}));
                pass.Invoke(new Action(() =>{pass.Text = string.Empty;}));
                re_pass.Invoke(new Action(() =>{re_pass.Text = string.Empty;}));
            }
            else if (Str_check == "Success")
            {
                //((Control)show).Enabled = true;
                //mainControl.SelectedTab = mainControl.TabPages["show"];
                check = -1;
                open();
            }
            else if (Str_check.Contains("All_result*"))
            {
                LoadData(11, Str_check);
            }
            else if (Str_check.Contains("All_result1*"))
            {
                LoadData(12, Str_check);
            }
            else if (Str_check.Contains("show2") == true)
            {
                LoadData(6, Str_check);
            }
            //           else if(Encoding.UTF8.GetString(e.Data)=="")
        }

        private void Event_DisConnected(object sender, ClientDisconnectedEventArgs e)
        {
            try
            {
                textInfo.Text += $"Server Disconnected. {Environment.NewLine}";
            }
            catch { MessageBox.Show("Server is disconnected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);this.Close(); }
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            textInfo.Text += $"Server connected. {Environment.NewLine}";
        }

        private void Client_login_Load(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            btnSignIn.Enabled = false;
            btnConnect.Enabled = false;
            ((Control)show).Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Client.Connect();
                btnCreate.Enabled = true;
                btnSignIn.Enabled = true;
                btnConnect.Enabled = false;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userName.Text) && (!string.IsNullOrEmpty(passWord.Text)))
            {
                
                    Client.Send($"LogIn:{userName.Text}%{passWord.Text}");
                    textInfo.Text += $"Me:LogIn:{userName.Text}%{passWord.Text}{Environment.NewLine}";
                
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(user.Text) && !string.IsNullOrEmpty(pass.Text) && !string.IsNullOrEmpty(re_pass.Text))
            {
                if (re_pass.Text.ToString() == pass.Text.ToString())
                {
                    Client.Send($"Create:{user.Text}%{pass.Text}");
                    textInfo.Text += $"Me:Create:{user.Text}%{pass.Text}{Environment.NewLine}";
                }
                else
                    MessageBox.Show("re_pass is Invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Input is empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ((Control)show).Enabled = false;
            mainControl.SelectedTab = mainControl.TabPages["Loginpage"];
            ((Control)Loginpage).Enabled = true;
            ((Control)createPage).Enabled = true;
            check = 0;
            table_data = "";
        }
        // Load data grid view 
        private void LoadData(int h,string check_string)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            List<tabledata> resultList = listData.Instance.load(h, check_string);
            int i = 0;
            /*DataGridViewRow rowFirst = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            rowFirst.Cells[0].Value = "ID";
            rowFirst.Cells[1].Value = "Quốc Gia";
            rowFirst.Cells[2].Value = "Ca Nhiễm";
            rowFirst.Cells[3].Value = "Đang Điều Trị";
            rowFirst.Cells[4].Value = "Hồi Phục";
            rowFirst.Cells[5].Value = "Tử Vong";*/
            //dataGridView1.Refresh();
            
            dataGridView1.Invoke(new Action(() => { dataGridView1.Rows.Clear(); }));
            dataGridView1.Invoke(new Action(() => { dataGridView1.Refresh(); }));
            foreach (tabledata item in resultList)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = item.ID.ToString();
                row.Cells[1].Value = item.Name;
                row.Cells[2].Value = item.Cn.ToString();
                row.Cells[3].Value = item.Ddt.ToString();
                row.Cells[4].Value = item.Hp.ToString();
                row.Cells[5].Value = item.Tv.ToString();
                dataGridView1.Invoke(new Action(() => { dataGridView1.Rows.Add(row); }));
            }

            dataGridView1.Columns["id"].DefaultCellStyle.BackColor = Color.Cyan;
            dataGridView1.Columns["name"].DefaultCellStyle.BackColor = Color.Cyan;
            dataGridView1.Columns["ddt"].DefaultCellStyle.BackColor = Color.Cyan;
            dataGridView1.Columns["tv"].DefaultCellStyle.BackColor = Color.Cyan;
            dataGridView1.Columns["cn"].DefaultCellStyle.BackColor = Color.Cyan;
            dataGridView1.Columns["hp"].DefaultCellStyle.BackColor = Color.Cyan;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string send_string = "show2*";
            send_string += search_string.Text.ToString() + "|";
            send_string += guna2DateTimePicker1.Text.ToString();
            Client.Send(send_string);
        }
    }
}
