using Lab1.Server.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Server
{
    public partial class Form1 : Form
    {

        private readonly AppServer _Server;
        public Form1()
        {
            _Server = new AppServer();
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string port = textBox2.Text;
            Task.Run(() =>
                {
                    _Server.List = dataGridView1;
                    _Server.UpdateServerPoint(port);
                    _Server.Start();
                }
            );

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
