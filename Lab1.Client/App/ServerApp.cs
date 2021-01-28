using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lab1.Client.App
{
    public class ServerApp
    {
        public Label Output { get; set; }

        public void OutputInfo(string text)
        {
            Output.Invoke((MethodInvoker)delegate {
                Output.Text = text;
            });
        }
    }
}
