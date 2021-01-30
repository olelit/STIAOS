using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

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
                byte[] data = new byte[256];
                OutputInfo("Текущий порт: " + Port.ToString());
                while (true)
                {
                    OutputInfo("Ожидание подключений... ");
                    TcpClient client = server.AcceptTcpClient();
                    OutputInfo("Подключен клиент. Выполнение запроса...");
                    NetworkStream stream = client.GetStream();
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string mes = builder.ToString();


                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(mes);
                    XmlNodeList ints = xmlDoc.GetElementsByTagName("int");
                    int output = 1;
                    foreach (XmlElement item in ints)
                    {
                        output *= int.Parse(item.InnerText);
                        OutputInfo(item.InnerText);
                    }

                    data = Encoding.Unicode.GetBytes("result: "+ output);
                    stream.Write(data, 0, data.Length);

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
