using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Server
{
    class Program
    {
        static int port;
        static string ip;
        public static List<ClientObject> Clients = new List<ClientObject>();

        static void Main(string[] args)
        {
            begin:
            Console.WriteLine("Введите ваш локальный IP");
            ip = Console.ReadLine();
            Console.WriteLine("Введите порт");
            port = int.Parse(Console.ReadLine());

            TcpListener server = null;
            try
            {
                try
                {
                    IPAddress localAddr = IPAddress.Parse(ip);
                    server = new TcpListener(localAddr, port);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    goto begin;
                }

                server.Start();

                while (true)
                {
                    Console.WriteLine("Ожидание подключений... ");

                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Подключен клиент. Добавляем в клиенты...");

                    Clients.Add(new ClientObject(client));
                    Clients[Clients.Count - 1].StartProcess();


                    NetworkStream stream = client.GetStream();

                    string response = "Вы подключились! Время сервера - " + DateTime.Now.ToString();
                    byte[] data = Encoding.UTF8.GetBytes(response);

                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                goto begin;
            }
            finally
            {
                if (server != null)
                    server.Stop();
                Console.ReadKey();
            }
        }

        void CheckActivity ()
        {
            foreach(ClientObject c in Clients)
            {
                if (!c.client.Connected)
                {
                    Clients.Remove(c);
                    Console.WriteLine("Удалил неактивное соединение");
                    Thread.Sleep(5000);
                }
            }
        }
    }

    public class ClientObject
    {
        public TcpClient client;
        Thread thr; 
        public ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
        }
        ~ClientObject()
        {
            StopProcess();
        }

        public void StartProcess()
        {
            thr = new Thread(Process);
            thr.Start();
        }
        public void StopProcess()
        {
            if (thr.IsAlive)
            {
                thr.Abort();
                client.Close();
                client = null;
            }
        }

        private void Process()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[64]; // буфер для получаемых данных
                while (true)
                {
                    if (client.Connected)
                    {
                        // получаем сообщение                 
                        StringBuilder builder = new StringBuilder();
                        int bytes = 0;
                        do
                        {
                            bytes = stream.Read(data, 0, data.Length);
                            builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                        }
                        while (stream.DataAvailable);
                        Console.WriteLine("Здесь происходит какое-то говно");
                        string message = builder.ToString();
                        Console.WriteLine(message);
                        // Рассылаем сообщение всем клиентам
                        foreach (ClientObject c in Program.Clients)
                        {
                            NetworkStream str = c.client.GetStream();
                            data = Encoding.UTF8.GetBytes(builder.ToString());
                            str.Write(data, 0, data.Length);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }
    }
}
