using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Lab1.Server.App
{
    public class AppServer
    {

        public const string IP = "127.0.0.1";

        public int Port { get; private set; }

        public DataGridView List { get; set; }

        public void UpdateServerPoint(string port)
        {
            Port = int.Parse(port);
        }

        public void OutputInfo(string message)
        {
            List.Invoke((MethodInvoker)delegate {
                List.Rows.Add(message);
            });
        }

        public void Start()
        {
            TcpListener server = null;
            try
            {
                IPAddress localAddr = IPAddress.Parse(IP);
                server = new TcpListener(localAddr, Port);
                server.Start();
                OutputInfo("Текущий порт: " + Port.ToString());
                while (true)
                {
                    OutputInfo("Ожидание подключений... ");
                    TcpClient client = server.AcceptTcpClient();
                    OutputInfo("Подключен клиент. Выполнение запроса...");
                    NetworkStream stream = client.GetStream();
                    string response = "Привет мир";
                    byte[] data = Encoding.UTF8.GetBytes(response);
                    stream.Write(data, 0, data.Length);
                    OutputInfo(string.Format("Отправлено сообщение: {0}", response));
                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception e)
            {
                OutputInfo(e.Message);
            }
            finally
            {
                if (server != null)
                    server.Stop();
            }
        }
    }
}
