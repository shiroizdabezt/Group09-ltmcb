namespace Client
{
    partial class MulTCPClient
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
            label1=new Label();
            txtMess=new TextBox();
            send=new Button();
            connect=new Button();
            exit=new Button();
            disconnect=new Button();
            txtServerIP=new TextBox();
            lstReceived=new ListBox();
            groupBox1=new GroupBox();
            txt_Username=new TextBox();
            label3=new Label();
            txt_Port=new TextBox();
            label2=new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(8, 65);
            label1.Margin=new Padding(2, 0, 2, 0);
            label1.Name="label1";
            label1.Size=new Size(21, 15);
            label1.TabIndex=1;
            label1.Text="IP:";
            // 
            // txtMess
            // 
            txtMess.Font=new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMess.Location=new Point(14, 398);
            txtMess.Margin=new Padding(2);
            txtMess.Multiline=true;
            txtMess.Name="txtMess";
            txtMess.Size=new Size(527, 32);
            txtMess.TabIndex=11;
            // 
            // send
            // 
            send.Font=new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            send.Location=new Point(545, 399);
            send.Margin=new Padding(2);
            send.Name="send";
            send.Size=new Size(84, 30);
            send.TabIndex=12;
            send.Text="Gửi";
            send.UseVisualStyleBackColor=true;
            send.Click+=send_Click;
            // 
            // connect
            // 
            connect.Font=new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            connect.Location=new Point(461, 67);
            connect.Margin=new Padding(2);
            connect.Name="connect";
            connect.Size=new Size(93, 39);
            connect.TabIndex=13;
            connect.Text="Kết nối";
            connect.UseVisualStyleBackColor=true;
            connect.Click+=connect_Click;
            // 
            // exit
            // 
            exit.Font=new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            exit.Location=new Point(561, 13);
            exit.Margin=new Padding(2);
            exit.Name="exit";
            exit.Size=new Size(68, 28);
            exit.TabIndex=14;
            exit.Text="Thoát";
            exit.UseVisualStyleBackColor=true;
            exit.Click+=exit_Click;
            // 
            // disconnect
            // 
            disconnect.Font=new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            disconnect.Location=new Point(461, 121);
            disconnect.Margin=new Padding(2);
            disconnect.Name="disconnect";
            disconnect.Size=new Size(93, 39);
            disconnect.TabIndex=15;
            disconnect.Text="Ngắt kết nối";
            disconnect.UseVisualStyleBackColor=true;
            disconnect.Click+=disconnect_Click;
            // 
            // txtServerIP
            // 
            txtServerIP.Location=new Point(115, 61);
            txtServerIP.Margin=new Padding(2);
            txtServerIP.Name="txtServerIP";
            txtServerIP.Size=new Size(187, 21);
            txtServerIP.TabIndex=0;
            txtServerIP.Text="127.0.0.1";
            txtServerIP.TextAlign=HorizontalAlignment.Center;
            // 
            // lstReceived
            // 
            lstReceived.Font=new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lstReceived.FormattingEnabled=true;
            lstReceived.ItemHeight=15;
            lstReceived.Location=new Point(13, 183);
            lstReceived.Margin=new Padding(2);
            lstReceived.Name="lstReceived";
            lstReceived.Size=new Size(619, 169);
            lstReceived.TabIndex=16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Username);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_Port);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtServerIP);
            groupBox1.Controls.Add(label1);
            groupBox1.Font=new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location=new Point(14, 13);
            groupBox1.Margin=new Padding(4, 3, 4, 3);
            groupBox1.Name="groupBox1";
            groupBox1.Padding=new Padding(4, 3, 4, 3);
            groupBox1.Size=new Size(341, 147);
            groupBox1.TabIndex=17;
            groupBox1.TabStop=false;
            groupBox1.Text="Thông tin User";
            // 
            // txt_Username
            // 
            txt_Username.Location=new Point(115, 29);
            txt_Username.Margin=new Padding(2);
            txt_Username.Name="txt_Username";
            txt_Username.Size=new Size(187, 21);
            txt_Username.TabIndex=4;
            txt_Username.TextAlign=HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(8, 32);
            label3.Margin=new Padding(2, 0, 2, 0);
            label3.Name="label3";
            label3.Size=new Size(68, 15);
            label3.TabIndex=5;
            label3.Text="Username:";
            // 
            // txt_Port
            // 
            txt_Port.Location=new Point(115, 93);
            txt_Port.Margin=new Padding(2);
            txt_Port.Name="txt_Port";
            txt_Port.Size=new Size(187, 21);
            txt_Port.TabIndex=2;
            txt_Port.Text="8080";
            txt_Port.TextAlign=HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(8, 97);
            label2.Margin=new Padding(2, 0, 2, 0);
            label2.Name="label2";
            label2.Size=new Size(32, 15);
            label2.TabIndex=3;
            label2.Text="Port:";
            // 
            // MulTCPClient
            // 
            AcceptButton=send;
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(645, 443);
            Controls.Add(groupBox1);
            Controls.Add(lstReceived);
            Controls.Add(disconnect);
            Controls.Add(exit);
            Controls.Add(connect);
            Controls.Add(send);
            Controls.Add(txtMess);
            Margin=new Padding(2);
            Name="MulTCPClient";
            Text="Chat Client";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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

