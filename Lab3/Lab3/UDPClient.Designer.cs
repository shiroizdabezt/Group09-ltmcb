namespace BTTuan3
{
    partial class UDPClient
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
            listTinNhan=new ListBox();
            groupBox1=new GroupBox();
            txtTen=new TextBox();
            label3=new Label();
            btnKetNoi=new Button();
            txtPort=new TextBox();
            txtIP=new TextBox();
            label2=new Label();
            label1=new Label();
            txtTinNhan=new TextBox();
            btnGui=new Button();
            btnThoat=new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listTinNhan
            // 
            listTinNhan.FormattingEnabled=true;
            listTinNhan.ItemHeight=15;
            listTinNhan.Location=new Point(14, 14);
            listTinNhan.Margin=new Padding(4, 3, 4, 3);
            listTinNhan.Name="listTinNhan";
            listTinNhan.Size=new Size(443, 394);
            listTinNhan.TabIndex=0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnKetNoi);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(txtIP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location=new Point(483, 14);
            groupBox1.Margin=new Padding(4, 3, 4, 3);
            groupBox1.Name="groupBox1";
            groupBox1.Padding=new Padding(4, 3, 4, 3);
            groupBox1.Size=new Size(292, 233);
            groupBox1.TabIndex=1;
            groupBox1.TabStop=false;
            groupBox1.Text="Thông tin kết nối";
            // 
            // txtTen
            // 
            txtTen.Location=new Point(144, 48);
            txtTen.Margin=new Padding(4, 3, 4, 3);
            txtTen.Name="txtTen";
            txtTen.Size=new Size(116, 23);
            txtTen.TabIndex=6;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(41, 52);
            label3.Margin=new Padding(4, 0, 4, 0);
            label3.Name="label3";
            label3.Size=new Size(89, 15);
            label3.TabIndex=5;
            label3.Text="Tên máy khách:";
            // 
            // btnKetNoi
            // 
            btnKetNoi.Location=new Point(103, 177);
            btnKetNoi.Margin=new Padding(4, 3, 4, 3);
            btnKetNoi.Name="btnKetNoi";
            btnKetNoi.Size=new Size(88, 27);
            btnKetNoi.TabIndex=4;
            btnKetNoi.Text="Kết nối";
            btnKetNoi.UseVisualStyleBackColor=true;
            btnKetNoi.Click+=btnKetNoi_Click;
            // 
            // txtPort
            // 
            txtPort.Location=new Point(144, 115);
            txtPort.Margin=new Padding(4, 3, 4, 3);
            txtPort.Name="txtPort";
            txtPort.Size=new Size(116, 23);
            txtPort.TabIndex=3;
            txtPort.Text="8080";
            // 
            // txtIP
            // 
            txtIP.Location=new Point(144, 81);
            txtIP.Margin=new Padding(4, 3, 4, 3);
            txtIP.Name="txtIP";
            txtIP.Size=new Size(116, 23);
            txtIP.TabIndex=2;
            txtIP.Text="127.0.0.1";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(41, 119);
            label2.Margin=new Padding(4, 0, 4, 0);
            label2.Name="label2";
            label2.Size=new Size(88, 15);
            label2.TabIndex=1;
            label2.Text="Cổng máy chủ:";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(41, 84);
            label1.Margin=new Padding(4, 0, 4, 0);
            label1.Name="label1";
            label1.Size=new Size(69, 15);
            label1.TabIndex=0;
            label1.Text="IP máy chủ:";
            // 
            // txtTinNhan
            // 
            txtTinNhan.Location=new Point(14, 432);
            txtTinNhan.Margin=new Padding(4, 3, 4, 3);
            txtTinNhan.Name="txtTinNhan";
            txtTinNhan.Size=new Size(348, 23);
            txtTinNhan.TabIndex=2;
            // 
            // btnGui
            // 
            btnGui.Location=new Point(370, 429);
            btnGui.Margin=new Padding(4, 3, 4, 3);
            btnGui.Name="btnGui";
            btnGui.Size=new Size(88, 27);
            btnGui.TabIndex=3;
            btnGui.Text="Gửi";
            btnGui.UseVisualStyleBackColor=true;
            btnGui.Click+=btnGui_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location=new Point(586, 429);
            btnThoat.Margin=new Padding(4, 3, 4, 3);
            btnThoat.Name="btnThoat";
            btnThoat.Size=new Size(88, 27);
            btnThoat.TabIndex=4;
            btnThoat.Text="Thoát";
            btnThoat.UseVisualStyleBackColor=true;
            btnThoat.Click+=btnThoat_Click;
            // 
            // UDPClient
            // 
            AcceptButton=btnGui;
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(803, 482);
            Controls.Add(btnThoat);
            Controls.Add(btnGui);
            Controls.Add(txtTinNhan);
            Controls.Add(groupBox1);
            Controls.Add(listTinNhan);
            Margin=new Padding(4, 3, 4, 3);
            Name="UDPClient";
            Text="Máy khách";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listTinNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTinNhan;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
    }
}

