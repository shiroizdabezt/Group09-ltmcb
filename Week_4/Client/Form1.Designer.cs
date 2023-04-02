namespace Client
{
    partial class Client_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lstReceived = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Server";
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(11, 354);
            this.txtMess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(601, 33);
            this.txtMess.TabIndex = 11;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(629, 354);
            this.send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(96, 32);
            this.send.TabIndex = 12;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(444, 67);
            this.connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(106, 42);
            this.connect.TabIndex = 13;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(657, 4);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(78, 29);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(583, 67);
            this.disconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(106, 42);
            this.disconnect.TabIndex = 15;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(36, 77);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(213, 22);
            this.txtServerIP.TabIndex = 0;
            // 
            // lstReceived
            // 
            this.lstReceived.FormattingEnabled = true;
            this.lstReceived.ItemHeight = 16;
            this.lstReceived.Location = new System.Drawing.Point(11, 124);
            this.lstReceived.Name = "lstReceived";
            this.lstReceived.Size = new System.Drawing.Size(678, 212);
            this.lstReceived.TabIndex = 16;
            // 
            // Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 396);
            this.Controls.Add(this.lstReceived);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.send);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerIP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Client_Form";
            this.Text = "Chat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.ListBox lstReceived;
    }
}

