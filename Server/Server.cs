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
using System.Data.SqlClient;

namespace Server
{
    public partial class Server : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=socket_account;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        public Server()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            textInfo.Text += $"Startting .....{Environment.NewLine}";// create new line when have messsage;
            btnStart.Enabled = false;// cannot click when have this method
            btnSend.Enabled = true;// cannot click when have this method
        }
        // checkString and activity 
        private int return_trueFalseStringLogin(string string_check,int i)
        {
            Int32 count = 0;
            int j = i;
            string userN = "";
            string passW = "";
            for(; ; j++)
            {
                if (string_check[j] != '%')
                {
                    userN += string_check[j];
                }
                else
                {
                    j++;
                    break;
                }
            }
            for (; j < string_check.Length; j++)
            {
                passW += string_check[j];
            }
            textInfo.Text += $"{userN}--{passW}{Environment.NewLine}";
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "SELECT COUNT(*) FROM account WHERE username='"+userN+"' AND pass='"+passW+"'";
            comm = new SqlCommand(sqlString, conn);
            count = (Int32)comm.ExecuteScalar();
            conn.Close();
            return count;
        }        
        private void insertAccount(string string_check)
        {
            int j = 7;
            string userN = "";
            string passW = "";
            for (; ; j++)
            {
                if (string_check[j] != '%')
                {
                    userN += string_check[j];
                }
                else
                {
                    j++;
                    break;
                }
            }
            for (; j < string_check.Length; j++)
            {
                passW += string_check[j];
            }
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "INSERT INTO account VALUES('" + userN + "','" + passW + "')";
            comm = new SqlCommand(sqlString, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        string bult_string(DataTable dt, string header)
        {
            string result = "";
            result += header;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string check_null = "";
                result += dt.Rows[i]["id"].ToString() + "|";
                result += dt.Rows[i]["name_country"].ToString() + "|";
                check_null = dt.Rows[i]["sum_cn"].ToString();
                if (check_null != "")
                {
                    result += dt.Rows[i]["sum_cn"].ToString() + "|";
                }
                else
                    result += "0" + "|";
                check_null = "";
                check_null += dt.Rows[i]["sum_ddt"].ToString();
                if (check_null != "")
                    result += check_null + "|";
                else
                    result += "0" + "|";
                check_null = "";
                check_null += dt.Rows[i]["sum_hp"].ToString();
                if (check_null != "")
                    result += check_null + "|";
                else
                    result += "0" + "|";
                check_null = "";
                check_null += dt.Rows[i]["sum_tv"].ToString();
                if (check_null != "")
                    result += check_null + "*";
                else
                    result += "0" + "*";
            }
            return result;
        }
        private void checkString(string string_check,DataReceivedEventArgs e)
        {
            if (string_check.Contains("LogIn:"))
            {
                if (return_trueFalseStringLogin(string_check,6) == 0)
                {
                    textInfo.Text += $"{e.IpPort}:username and password are invalid{Environment.NewLine}";
                    server.Send(e.IpPort, "Invalid");
                }
                else
                {
                    textInfo.Text += $"{e.IpPort}:username and password are Success{Environment.NewLine}";
                    server.Send(e.IpPort, "Success");
                }
            }
            else if (string_check.Contains("Create:"))  
            {
                if (return_trueFalseStringLogin(string_check, 7) == 0)
                {
                    insertAccount(string_check);
                    textInfo.Text += $"{e.IpPort}:successful registration{Environment.NewLine}";
                    server.Send(e.IpPort, "Success1");
                }
                else
                {
                    //Account already exists
                    textInfo.Text += $"{e.IpPort}:Account already exists{Environment.NewLine}";
                    server.Send(e.IpPort, "Invalid1");
                }
            }
            else if (string_check.Contains("Allresult"))
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sqlString = "exec select_allresult"; 
                myAdapter = new SqlDataAdapter(sqlString, conn);
                ds = new DataSet();
                myAdapter.Fill(ds, "id");
                dt = ds.Tables["id"];
                string send_result = bult_string(dt, "All_result*");    
                server.Send(e.IpPort, send_result);
                conn.Close();
            }
            else if (string_check.Contains("show2"))
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                int i = 6;
                string name = "";
                while (string_check[i] != '|')
                {
                    name += string_check[i];
                    i++;
                }
                i++;
                string date_time = "";
                for (; i < string_check.Length; i++)
                {
                    date_time += string_check[i];
                }
                string sqlString = "exec select_result N'" + name + "','" + date_time + "'";
                myAdapter = new SqlDataAdapter(sqlString, conn);
                ds = new DataSet();
                myAdapter.Fill(ds, "id");
                dt = ds.Tables["id"];
                string send_result = bult_string(dt, "show2*");
                server.Send(e.IpPort, send_result);
                conn.Close();
            }
        }
        private void Server_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false; // cannot click when have this method 
            server = new SimpleTcpServer(textIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataRecceived; 
        }

        private void Events_DataRecceived(object sender, DataReceivedEventArgs e)
        {
            textInfo.Text += $"{e.IpPort}:{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            string string_check = Encoding.UTF8.GetString(e.Data);
            checkString(string_check,e);
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                ListClientIP.Items.Remove(e.IpPort);
            });
            //remve list when have one port disconnected;
        }

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            textInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
            ListClientIP.Items.Add(e.IpPort);
            //remve list when have one port disconnected;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if(!string.IsNullOrEmpty(textMessage.Text)&&ListClientIP.SelectedItem != null)// check message && select client ip from listbox
                {
                    server.Send(ListClientIP.SelectedItem.ToString(), textMessage.Text);
                    textInfo.Text += $"Server: {textMessage.Text}. {Environment.NewLine}";
                    textMessage.Text = string.Empty;
                }    
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            change_table f = new change_table();
            f.ShowDialog();
        }
    }
}
