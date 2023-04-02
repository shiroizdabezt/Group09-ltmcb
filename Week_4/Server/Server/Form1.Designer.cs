namespace Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(105, 36);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(135, 26);
            this.txtIPServer.TabIndex = 1;
            this.txtIPServer.Text = "127.0.0.1";
            this.txtIPServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Location = new System.Drawing.Point(283, 51);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(75, 37);
            this.btnKhoiTao.TabIndex = 2;
            this.btnKhoiTao.Text = "Khởi tạo";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 129);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(396, 377);
            this.txtMessage.TabIndex = 3;
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(105, 68);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(135, 26);
            this.txtPortServer.TabIndex = 4;
            this.txtPortServer.Text = "8080";
            this.txtPortServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIPServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPortServer);
            this.groupBox1.Controls.Add(this.btnKhoiTao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Button btnKhoiTao;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

