using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Lab1.Client.App
{
    public class ServerApp
    {
        public TextBox Output { get; set; }
        public string Ip { get; private set; }
        public int Port { get; private set; }

        public void OutputInfo(string text)
        {
            Output.Invoke((MethodInvoker)delegate {
                Output.Text = text.Replace("\0", string.Empty); ;
            });
        }

        public void SetParams(string ip, string port, TextBox output)
        {
            Ip = ip;
            Port = int.Parse(port);
            Output = output;
        }

        public void Send(int[] inputData)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(Ip, Port);
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();
                byte[] data = new byte[255];

                XDocument doc = new XDocument();
                doc.Add(new XElement("root", inputData.Select(x => new XElement("int", x))));

                string xml = doc.ToString();
                data = Encoding.Unicode.GetBytes(xml);

                client.Client.Send(data);
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                OutputInfo(response.ToString());
                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                OutputInfo(string.Format("SocketException: {0}", e));
            }
            catch (Exception e)
            {
                OutputInfo(string.Format("Exception: {0}", e.Message));
            }
        }
    }
}
