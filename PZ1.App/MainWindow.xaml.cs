
using PZ1.App.Core;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace PZ1.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly IP2Commands _Command;
        delegate void String();

        public MainWindow()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
            _Command = new IP2Commands();
        }

        private void Ipconfig_ClickAsync(object sender, RoutedEventArgs e) => SendAsync(_Command.Ipconfig());
        private void Arp_Click(object sender, RoutedEventArgs e) => SendAsync(_Command.Arp());
        private void NBTSTAT_Click(object sender, RoutedEventArgs e) => SendAsync(_Command.Nbtsat());
        private void GETMAC_Click(object sender, RoutedEventArgs e) => SendAsync(_Command.Getmac());
        private void NETSH_Click(object sender, RoutedEventArgs e) => SendAsync(_Command.Netsh());
        private void NET_Click(object sender, RoutedEventArgs e) => SendAsync(_Command.Net());
        private void PING_Click(object sender, RoutedEventArgs e) => SendAsync(_Command.Ping());
        private void ROUTE_Click(object sender, RoutedEventArgs e) => SendAsync(_Command.Route());
        private void TELNET_Click(object sender, RoutedEventArgs e) => SendAsync(_Command.Telnet());
        private void TRACERT_ClickAsync(object sender, RoutedEventArgs e) => SendAsync(_Command.Tracert());

        private void SendAsync(string command)
        {
            output.Dispatcher.Invoke(() => output.Text = command);
            //Task.Run(() => {
            //    string a = command;
            //});
        }
    }
}
