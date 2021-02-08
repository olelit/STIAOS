using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PZ1.App.Core
{
    class IP2Commands
    {
        public IP2Commands()
        {

        }

        public void Arp()
        {

        }
        public void Ipconfig()
        {
            SendCommand("ipconfig /all");
        }
        public void Getmac()
        {

        }
        public void Nbtsat()
        {

        }
        public void Netsh()
        {

        }
        public void Net()
        {

        }
        public void Ping()
        {

        }
        public void Route()
        {

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
            MessageBox.Show(process.StandardOutput.ReadToEnd());
            //_Output.Text = ;

            process.WaitForExit();
        }
    }
}
