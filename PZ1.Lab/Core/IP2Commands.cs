
using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PZ1.Lab.Core
{
    class IP2Commands
    {

        private TextBox _Output;
        private PictureBox _Loader;
        public CancellationToken Token { get; set; }

        public IP2Commands(TextBox output, PictureBox loader)
        {
            _Output = output;
            _Loader = loader;
        }

        public void Arp()
        {
            SendCommand("arp -a");
        }
        public void Ipconfig()
        {
            SendCommand("ipconfig /all");
        }
        public void Getmac()
        {
           SendCommand("getmac");
        }
        public void Nbtsat()
        {
            SendCommand("NBTSTAT -a 127.0.0.1");
        }
        public void Netsh()
        {
            SendCommand("netsh interface ip show config");
        }
        public void Net()
        {
            SendCommand("net accounts");
        }
        public void Ping()
        {
            SendCommand("ping 127.0.0.1");
        }
        public void Telnet()
        {
            SendCommand("telnet 127.0.0.1 83");
        }
        public void Tracert()
        {
            SendCommand("tracert 2ip.ru");
        }
        public void Route()
        {
            SendCommand("route print 10.*");
        }

        public void SendCommand(string command)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                StandardOutputEncoding = Encoding.GetEncoding(866),
                FileName = "cmd.exe",
                Arguments = "/C " + command,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            while(process.HasExited == false && Token.IsCancellationRequested == false)
            {
                string message = process.StandardOutput.ReadLine();
                if (string.IsNullOrEmpty(message) == false)
                {
                    _Output.Invoke((MethodInvoker)delegate
                    {
                        _Output.Text += message + Environment.NewLine;
                    });
                }

            }
            process.WaitForExit();
        }
    }
}
