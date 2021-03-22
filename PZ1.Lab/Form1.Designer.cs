
namespace PZ1.Lab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ipconfig = new System.Windows.Forms.Button();
            this.arp = new System.Windows.Forms.Button();
            this.nbtstat = new System.Windows.Forms.Button();
            this.getmac = new System.Windows.Forms.Button();
            this.netsh = new System.Windows.Forms.Button();
            this.net = new System.Windows.Forms.Button();
            this.ping = new System.Windows.Forms.Button();
            this.route = new System.Windows.Forms.Button();
            this.telnet = new System.Windows.Forms.Button();
            this.tracert = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.loader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            this.SuspendLayout();
            // 
            // ipconfig
            // 
            this.ipconfig.Location = new System.Drawing.Point(12, 12);
            this.ipconfig.Name = "ipconfig";
            this.ipconfig.Size = new System.Drawing.Size(117, 29);
            this.ipconfig.TabIndex = 1;
            this.ipconfig.Text = "IPCONFIG";
            this.ipconfig.UseVisualStyleBackColor = true;
            this.ipconfig.Click += new System.EventHandler(this.ipconfig_Click);
            // 
            // arp
            // 
            this.arp.Location = new System.Drawing.Point(12, 47);
            this.arp.Name = "arp";
            this.arp.Size = new System.Drawing.Size(117, 29);
            this.arp.TabIndex = 2;
            this.arp.Text = "ARP";
            this.arp.UseVisualStyleBackColor = true;
            this.arp.Click += new System.EventHandler(this.arp_Click);
            // 
            // nbtstat
            // 
            this.nbtstat.Location = new System.Drawing.Point(12, 82);
            this.nbtstat.Name = "nbtstat";
            this.nbtstat.Size = new System.Drawing.Size(117, 29);
            this.nbtstat.TabIndex = 3;
            this.nbtstat.Text = "NBTSTAT";
            this.nbtstat.UseVisualStyleBackColor = true;
            this.nbtstat.Click += new System.EventHandler(this.nbtstat_Click);
            // 
            // getmac
            // 
            this.getmac.Location = new System.Drawing.Point(135, 12);
            this.getmac.Name = "getmac";
            this.getmac.Size = new System.Drawing.Size(117, 29);
            this.getmac.TabIndex = 4;
            this.getmac.Text = "GETMAC";
            this.getmac.UseVisualStyleBackColor = true;
            this.getmac.Click += new System.EventHandler(this.getmac_Click);
            // 
            // netsh
            // 
            this.netsh.Location = new System.Drawing.Point(135, 47);
            this.netsh.Name = "netsh";
            this.netsh.Size = new System.Drawing.Size(117, 29);
            this.netsh.TabIndex = 5;
            this.netsh.Text = "NETSH";
            this.netsh.UseVisualStyleBackColor = true;
            this.netsh.Click += new System.EventHandler(this.netsh_Click);
            // 
            // net
            // 
            this.net.Location = new System.Drawing.Point(135, 82);
            this.net.Name = "net";
            this.net.Size = new System.Drawing.Size(117, 29);
            this.net.TabIndex = 6;
            this.net.Text = "NET";
            this.net.UseVisualStyleBackColor = true;
            this.net.Click += new System.EventHandler(this.net_Click);
            // 
            // ping
            // 
            this.ping.Location = new System.Drawing.Point(258, 12);
            this.ping.Name = "ping";
            this.ping.Size = new System.Drawing.Size(117, 29);
            this.ping.TabIndex = 7;
            this.ping.Text = "PING";
            this.ping.UseVisualStyleBackColor = true;
            this.ping.Click += new System.EventHandler(this.ping_Click);
            // 
            // route
            // 
            this.route.Location = new System.Drawing.Point(258, 47);
            this.route.Name = "route";
            this.route.Size = new System.Drawing.Size(117, 29);
            this.route.TabIndex = 8;
            this.route.Text = "ROUTE";
            this.route.UseVisualStyleBackColor = true;
            this.route.Click += new System.EventHandler(this.route_Click);
            // 
            // telnet
            // 
            this.telnet.Location = new System.Drawing.Point(258, 82);
            this.telnet.Name = "telnet";
            this.telnet.Size = new System.Drawing.Size(117, 29);
            this.telnet.TabIndex = 9;
            this.telnet.Text = "TELNET";
            this.telnet.UseVisualStyleBackColor = true;
            this.telnet.Click += new System.EventHandler(this.telnet_Click);
            // 
            // tracert
            // 
            this.tracert.Location = new System.Drawing.Point(381, 12);
            this.tracert.Name = "tracert";
            this.tracert.Size = new System.Drawing.Size(117, 29);
            this.tracert.TabIndex = 10;
            this.tracert.Text = "TRACERT";
            this.tracert.UseVisualStyleBackColor = true;
            this.tracert.Click += new System.EventHandler(this.tracert_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.output.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.output.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.output.Location = new System.Drawing.Point(12, 131);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(776, 307);
            this.output.TabIndex = 11;
            // 
            // loader
            // 
            this.loader.Image = ((System.Drawing.Image)(resources.GetObject("loader.Image")));
            this.loader.Location = new System.Drawing.Point(690, 14);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(98, 97);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loader.TabIndex = 12;
            this.loader.TabStop = false;
            this.loader.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.output);
            this.Controls.Add(this.tracert);
            this.Controls.Add(this.telnet);
            this.Controls.Add(this.route);
            this.Controls.Add(this.ping);
            this.Controls.Add(this.net);
            this.Controls.Add(this.netsh);
            this.Controls.Add(this.getmac);
            this.Controls.Add(this.nbtstat);
            this.Controls.Add(this.arp);
            this.Controls.Add(this.ipconfig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ipconfig;
        private System.Windows.Forms.Button getmac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button arp;
        private System.Windows.Forms.Button nbtstat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button netsh;
        private System.Windows.Forms.Button net;
        private System.Windows.Forms.Button ping;
        private System.Windows.Forms.Button route;
        private System.Windows.Forms.Button telnet;
        private System.Windows.Forms.Button tracert;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.PictureBox loader;
    }
}

