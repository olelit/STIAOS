using PZ1.Lab.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ1.Lab
{
    public partial class Form1 : Form
    {

        private bool _IsTreadRun = false;
        private readonly IP2Commands _Command;
        delegate void Method();

        private CancellationTokenSource _CancelTokenSource;
        private CancellationToken _Token;

        public Form1()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
            _Command = new IP2Commands(output, loader);
            ResetToken();
        }

        private void ResetToken()
        {
            _CancelTokenSource = new CancellationTokenSource();
            _Token = _CancelTokenSource.Token;
        }

        private void ipconfig_Click(object sender, EventArgs e) => Send(_Command.Ipconfig);

        private void getmac_Click(object sender, EventArgs e) => Send(_Command.Getmac);

        private void ping_Click(object sender, EventArgs e) => Send(_Command.Ping);

        private void tracert_Click(object sender, EventArgs e) => Send(_Command.Tracert);

        private void arp_Click(object sender, EventArgs e) => Send(_Command.Arp);

        private void netsh_Click(object sender, EventArgs e) => Send(_Command.Netsh);

        private void route_Click(object sender, EventArgs e) => Send(_Command.Route);
        private void nbtstat_Click(object sender, EventArgs e) => Send(_Command.Nbtsat);

        private void net_Click(object sender, EventArgs e) => Send(_Command.Net);

        private void telnet_Click(object sender, EventArgs e) => Send(_Command.Telnet);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Send(Method command)
        {
            output.Text = "";
            if(_IsTreadRun)
            {
                _CancelTokenSource.Cancel();
                ResetToken();
                _IsTreadRun = false;
            }
            
            Task.Run(() =>
            {
                _IsTreadRun = true;
                if (!_CancelTokenSource.Token.IsCancellationRequested)
                {
                    command();
                }
            }, _CancelTokenSource.Token);

        }
    }
}
