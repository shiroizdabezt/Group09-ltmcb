
namespace Group9
{
    partial class MainMenu
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
            this.Start_btn = new System.Windows.Forms.Button();
            this.Connection_btn = new System.Windows.Forms.Button();
            this.btn_thongtin = new System.Windows.Forms.Button();
            this.btnLogout = new Cocaro.CustomButton();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(288, 189);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(132, 54);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Single Game";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Connection_btn
            // 
            this.Connection_btn.Location = new System.Drawing.Point(288, 305);
            this.Connection_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Connection_btn.Name = "Connection_btn";
            this.Connection_btn.Size = new System.Drawing.Size(132, 52);
            this.Connection_btn.TabIndex = 1;
            this.Connection_btn.Text = "Lan Game";
            this.Connection_btn.UseVisualStyleBackColor = true;
            this.Connection_btn.Click += new System.EventHandler(this.Connection_btn_Click);
            // 
            // btn_thongtin
            // 
            this.btn_thongtin.Location = new System.Drawing.Point(288, 75);
            this.btn_thongtin.Name = "btn_thongtin";
            this.btn_thongtin.Size = new System.Drawing.Size(132, 62);
            this.btn_thongtin.TabIndex = 2;
            this.btn_thongtin.Text = "Thông tin tài khoản";
            this.btn_thongtin.UseVisualStyleBackColor = true;
            this.btn_thongtin.Click += new System.EventHandler(this.btn_thongtin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.BackgroundColor = System.Drawing.Color.Red;
            this.btnLogout.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogout.BorderRadius = 20;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(288, 386);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(132, 57);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 501);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btn_thongtin);
            this.Controls.Add(this.Connection_btn);
            this.Controls.Add(this.Start_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Connection_btn;
        private System.Windows.Forms.Button btn_thongtin;
        private Cocaro.CustomButton btnLogout;
    }
}