using Lab1.Client.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Client
{
    public partial class Form1 : Form
    {

        private readonly ServerApp _Server;

        public Form1()
        {
            InitializeComponent();
            _Server = new ServerApp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string ip = textBox1.Text;
                string port = textBox2.Text;
                _Server.SetParams(ip, port, textBox3);
                _Server.Send(new int[] { (int)numericUpDown1.Value, (int)numericUpDown2.Value });
            }
);
        }
    }
}
