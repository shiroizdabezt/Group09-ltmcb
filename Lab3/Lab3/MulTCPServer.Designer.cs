namespace Server
{
    partial class MulTCPServer
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
            label1 = new Label();
            txtIPServer = new TextBox();
            btnKhoiTao = new Button();
            txtPortServer = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            lst_Chat = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 16);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // txtIPServer
            // 
            txtIPServer.Location = new Point(122, 42);
            txtIPServer.Margin = new Padding(4, 3, 4, 3);
            txtIPServer.Name = "txtIPServer";
            txtIPServer.Size = new Size(157, 22);
            txtIPServer.TabIndex = 1;
            txtIPServer.TextAlign = HorizontalAlignment.Center;
            // 
            // btnKhoiTao
            // 
            btnKhoiTao.Location = new Point(322, 75);
            btnKhoiTao.Margin = new Padding(4, 3, 4, 3);
            btnKhoiTao.Name = "btnKhoiTao";
            btnKhoiTao.Size = new Size(88, 29);
            btnKhoiTao.TabIndex = 2;
            btnKhoiTao.Text = "Khởi tạo";
            btnKhoiTao.UseVisualStyleBackColor = true;
            btnKhoiTao.Click += btnKhoiTao_Click;
            // 
            // txtPortServer
            // 
            txtPortServer.Location = new Point(122, 78);
            txtPortServer.Margin = new Padding(4, 3, 4, 3);
            txtPortServer.Name = "txtPortServer";
            txtPortServer.Size = new Size(157, 22);
            txtPortServer.TabIndex = 4;
            txtPortServer.Text = "8080";
            txtPortServer.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 16);
            label2.TabIndex = 5;
            label2.Text = "Port:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtIPServer);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPortServer);
            groupBox1.Controls.Add(btnKhoiTao);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(444, 128);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Server";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(322, 36);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(88, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lst_Chat
            // 
            lst_Chat.FormattingEnabled = true;
            lst_Chat.ItemHeight = 15;
            lst_Chat.Location = new Point(14, 149);
            lst_Chat.Margin = new Padding(4, 3, 4, 3);
            lst_Chat.Name = "lst_Chat";
            lst_Chat.Size = new Size(444, 424);
            lst_Chat.TabIndex = 9;
            // 
            // MulTCPServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 592);
            Controls.Add(lst_Chat);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MulTCPServer";
            Text = "Server";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Button btnKhoiTao;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_Chat;
        private Button btnThoat;
    }
}

