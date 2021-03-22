using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Controls;
using System.Windows.Threading;

namespace PZ1.App.Core
{
    class IP2Commands
    {
        public string Arp()
        {
            return SendCommand("arp -a");
        }
        public string Ipconfig()
        {
            return SendCommand("ipconfig /all");
        }
        public string Getmac()
        {
            return SendCommand("getmac");
        }
        public string Nbtsat()
        {
            return SendCommand("NBTSTAT -a 127.0.0.1");
        }
        public string Netsh()
        {
            return SendCommand("netsh interface ip show config");
        }
        public string Net()
        {
            return SendCommand("net accounts");
        }
        public string Ping()
        {
            return SendCommand("ping 127.0.0.1");
        }
        public string Telnet()
        {
            return SendCommand("telnet 127.0.0.1 83");
        }

        public string Tracert()
        {
            return SendCommand("tracert 2ip.ru");
        }
        public string Route()
        {
            return SendCommand("route print 10.*");
        }
        public string SendCommand(string command)
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
            string message = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return message;
        }
    }
}
