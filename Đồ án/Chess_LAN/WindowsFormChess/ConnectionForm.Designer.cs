
namespace Group9
{
    partial class ConnectionForm
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
            this.btnConnect = new Cocaro.CustomButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack1 = new Cocaro.CustomButton();
            this.btnHost = new Cocaro.CustomButton();
            this.customButton1 = new Cocaro.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConnect.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.btnConnect.BorderColor = System.Drawing.Color.Black;
            this.btnConnect.BorderRadius = 13;
            this.btnConnect.BorderSize = 2;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(327, 190);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 36);
            this.btnConnect.TabIndex = 51;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextColor = System.Drawing.Color.Black;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(178, 196);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Code";
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.Color.Transparent;
            this.btnBack1.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBack1.BackgroundImage = global::Group9.Properties.Resources.btnback_removebg_preview;
            this.btnBack1.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack1.BorderRadius = 20;
            this.btnBack1.BorderSize = 0;
            this.btnBack1.FlatAppearance.BorderSize = 0;
            this.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack1.Location = new System.Drawing.Point(12, 12);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(40, 40);
            this.btnBack1.TabIndex = 49;
            this.btnBack1.TextColor = System.Drawing.Color.Transparent;
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // btnHost
            // 
            this.btnHost.BackColor = System.Drawing.Color.PaleGreen;
            this.btnHost.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.btnHost.BorderColor = System.Drawing.Color.Black;
            this.btnHost.BorderRadius = 13;
            this.btnHost.BorderSize = 2;
            this.btnHost.FlatAppearance.BorderSize = 0;
            this.btnHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHost.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHost.ForeColor = System.Drawing.Color.Black;
            this.btnHost.Location = new System.Drawing.Point(180, 74);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(137, 37);
            this.btnHost.TabIndex = 50;
            this.btnHost.Text = "Host Game";
            this.btnHost.TextColor = System.Drawing.Color.Black;
            this.btnHost.UseVisualStyleBackColor = false;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.customButton1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.customButton1.BorderColor = System.Drawing.Color.Black;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 2;
            this.customButton1.Enabled = false;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(69, 38);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(369, 222);
            this.customButton1.TabIndex = 51;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 30);
            this.label2.TabIndex = 52;
            this.label2.Text = "OR";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(507, 306);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnHost);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.customButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectionForm";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Cocaro.CustomButton btnBack1;
        private Cocaro.CustomButton btnHost;
        private Cocaro.CustomButton btnConnect;
        private Cocaro.CustomButton customButton1;
        private System.Windows.Forms.Label label2;
    }
}