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
        private const int port = 5000;
        private const string server = "93.80.69.26";
        Thread PassiveWaiter = null;
        TcpClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(server, port);
                PassiveWaiter = new Thread(new ThreadStart(() => AcceptMessage(client)));
                PassiveWaiter.Start();
            }
            catch (SocketException k)
            {
                Chat_TB.Text = k.ToString();
            }
            catch (Exception k)
            {
                Chat_TB.Text = k.ToString();
            }

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PassiveWaiter != null) if(PassiveWaiter.IsAlive)PassiveWaiter.Abort();        
            client.Close();
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
    }
}
