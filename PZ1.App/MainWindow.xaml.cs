
using PZ1.App.Core;
using System.Text;
using System.Windows;

namespace PZ1.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly IP2Commands _Command;

        public MainWindow()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
            _Command = new IP2Commands();
        }

        private void Ipconfig_Click(object sender, RoutedEventArgs e)
        {
            _Command.Ipconfig();
        }
    }
}
