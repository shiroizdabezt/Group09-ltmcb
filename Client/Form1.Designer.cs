namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.txtMessShow = new System.Windows.Forms.TextBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(46, 55);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(239, 26);
            this.txtServerIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port:";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(370, 55);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(95, 26);
            this.txtServerPort.TabIndex = 4;
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(370, 134);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(95, 26);
            this.txtClientPort.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "IP:";
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(46, 134);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(239, 26);
            this.txtClientIP.TabIndex = 5;
            // 
            // txtMessShow
            // 
            this.txtMessShow.Location = new System.Drawing.Point(12, 179);
            this.txtMessShow.Multiline = true;
            this.txtMessShow.Name = "txtMessShow";
            this.txtMessShow.Size = new System.Drawing.Size(804, 245);
            this.txtMessShow.TabIndex = 10;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(12, 443);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(676, 40);
            this.txtMess.TabIndex = 11;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(708, 443);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(108, 40);
            this.send.TabIndex = 12;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(499, 84);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(119, 52);
            this.connect.TabIndex = 13;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(739, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(88, 36);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(656, 84);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(119, 52);
            this.disconnect.TabIndex = 15;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 495);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.send);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.txtMessShow);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClientIP);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.TextBox txtMessShow;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button disconnect;
    }
}

