using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Chat
{
    public partial class Form1 : Form
    {
        private int port;
        private string serverip;
        Thread PassiveWaiter = null;
        TcpClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        

        public void AcceptMessage(TcpClient cl)
        {
            NetworkStream stream;
            StringBuilder response;

            while (true)
            {               
                byte[] data = new byte[256];
                response = new StringBuilder();
                stream = cl.GetStream();
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable); // пока данные есть в потоке
                if(response.ToString() != "")
                {
                    if (Chat_TB.InvokeRequired)
                    {
                        Chat_TB.Invoke(new Action<string>((s) => Chat_TB.Text += s), response.ToString().Trim() + Environment.NewLine);
                    }
                    else
                    {
                        Chat_TB.Text += response.ToString().Trim() + Environment.NewLine;
                    }                   
                    response.Remove(0, response.Length);
                }
            }

        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            if (NickName_TB.Text != "" && Message_TB.Text != "" && client != null && client.Connected)
            {
                string response = NickName_TB.Text + ": " + Message_TB.Text;
                byte[] data = Encoding.UTF8.GetBytes(response);
                try
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);
                    Message_TB.ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели никнейм или сообщение или вы не подключены к серверу");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PassiveWaiter != null) if(PassiveWaiter.IsAlive)PassiveWaiter.Abort();        
            if (client != null && client.Connected)client.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Enter)
            {
                if (NickName_TB.Text != "" && Message_TB.Text != "")
                {
                    string response = NickName_TB.Text + ": " + Message_TB.Text;
                    byte[] data = Encoding.UTF8.GetBytes(response);
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        stream.Write(data, 0, data.Length);
                        Message_TB.ResetText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Вы не ввели никнейм или сообщение");
                }
            }
        }

        private void Send_Button_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            if (IP_TB.Text != "" && Port_TB.Text != "")
            {
                serverip = IP_TB.Text;
                port = int.Parse(Port_TB.Text);
                try
                {
                    client = new TcpClient();
                    client.Connect(serverip, port);
                    ConnectionStatus_label.Text = "Сервер подключен";
                    ConnectionStatus_label.ForeColor = System.Drawing.Color.Green;
                    PassiveWaiter = new Thread(new ThreadStart(() => AcceptMessage(client)));
                    PassiveWaiter.Start();
                }
                catch (SocketException k)
                {
                    Chat_TB.Text = k.ToString();
                    ConnectionStatus_label.Text = "Проблемы";
                    ConnectionStatus_label.ForeColor = System.Drawing.Color.Red;
                }
                catch (Exception k)
                {
                    Chat_TB.Text = k.ToString();
                    ConnectionStatus_label.Text = "Проблемы";
                    ConnectionStatus_label.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Заполните поля <Port> и <IP>");
            }
        }

        private void DisConnect_button_Click(object sender, EventArgs e)
        {
            if(client != null && client.Connected)
            {
                PassiveWaiter.Abort();
                client.Close();
                ConnectionStatus_label.Text = "Соединение отключено";
                ConnectionStatus_label.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                MessageBox.Show("Вы не подключены или у вас проблемы =) ");
            }
        }
    }
}
