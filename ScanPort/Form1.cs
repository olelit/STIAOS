using ScanPort.App;
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

namespace ScanPort
{
    public partial class Form1 : Form
    {
            private readonly PortScan _Scan;
            private CancellationTokenSource _Cts;
            private Task _ScanTask;
            public Form1()
            {
                _Scan = new PortScan();
                _Cts = new CancellationTokenSource();
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                int[] range = { (int)numericUpDown1.Value, (int)numericUpDown2.Value };
                string ip = textBox1.Text;

                if (_ScanTask != null && _ScanTask.Status.Equals(TaskStatus.Running))
                {
                    _Cts.Cancel();
                    _Cts = new CancellationTokenSource();
                }

                dataGridView1.Rows.Clear();
                _ScanTask = Task.Run(() =>
                    {
                        _Scan.Scan(ip, range, dataGridView1, _Cts);
                    }, _Cts.Token
                );

                
            }

            private void button2_Click(object sender, EventArgs e)
            {
                if (_ScanTask != null && _ScanTask.Status.Equals(TaskStatus.Running))
                {
                    _Cts.Cancel();
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
