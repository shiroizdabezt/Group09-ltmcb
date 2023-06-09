﻿namespace Client
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
            this.txtMess = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lstReceived = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // txtMess
            // 
            this.txtMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMess.Location = new System.Drawing.Point(12, 345);
            this.txtMess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(452, 28);
            this.txtMess.TabIndex = 11;
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(467, 346);
            this.send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(72, 26);
            this.send.TabIndex = 12;
            this.send.Text = "Gửi";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(395, 58);
            this.connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(80, 34);
            this.connect.TabIndex = 13;
            this.connect.Text = "Kết nối";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(481, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(58, 24);
            this.exit.TabIndex = 14;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // disconnect
            // 
            this.disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect.Location = new System.Drawing.Point(395, 105);
            this.disconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(80, 34);
            this.disconnect.TabIndex = 15;
            this.disconnect.Text = "Ngắt kết nối";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(99, 53);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(161, 21);
            this.txtServerIP.TabIndex = 0;
            this.txtServerIP.Text = "127.0.0.1";
            this.txtServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstReceived
            // 
            this.lstReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReceived.FormattingEnabled = true;
            this.lstReceived.ItemHeight = 15;
            this.lstReceived.Location = new System.Drawing.Point(11, 159);
            this.lstReceived.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstReceived.Name = "lstReceived";
            this.lstReceived.Size = new System.Drawing.Size(531, 154);
            this.lstReceived.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServerIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 127);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin User";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(99, 25);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(161, 21);
            this.txt_Username.TabIndex = 4;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(99, 81);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(161, 21);
            this.txt_Port.TabIndex = 2;
            this.txt_Port.Text = "8080";
            this.txt_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // Client_Form
            // 
            this.AcceptButton = this.send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstReceived);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.send);
            this.Controls.Add(this.txtMess);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Client_Form";
            this.Text = "Chat Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.ListBox lstReceived;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label2;
    }
}

