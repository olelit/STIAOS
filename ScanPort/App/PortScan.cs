using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ScanPort.App
{
    class PortScan
    {
        public void Output(int port, string status, DataGridView component, Color color) {
            component.Invoke((MethodInvoker)delegate {
                component.Rows.Add(port.ToString(), status);
                component.Rows[component.Rows.Count-1].Cells[1].Style.BackColor = color;
            });
        }

        public void Scan(string ip, int[] range, DataGridView dataGridView, CancellationTokenSource ct)
        {
            while (ct.Token.IsCancellationRequested == false)
            {
                string status = "";
                Color color = Color.Red;
                for (int i = range[0]; i <= range[1]; i++)
                {
                    using (TcpClient tcpClient = new TcpClient())
                    {
                        try
                        {
                            tcpClient.Connect(ip, i);
                            status = "Доступен";
                            color = Color.GreenYellow;
                        }
                        catch (Exception)
                        {
                            status = "Недоступен";
                            color = Color.Red;
                        }
                    }
                    if (ct.Token.IsCancellationRequested)
                        break;
                    Output(i, status, dataGridView, color);
                }
                break;
            }

        }
    }
}
