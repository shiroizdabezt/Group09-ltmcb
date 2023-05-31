namespace Group9
{
    partial class InformationForm
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
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.btnBack = new Cocaro.CustomButton();
            this.SuspendLayout();
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.Location = new System.Drawing.Point(46, 329);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(130, 62);
            this.btn_ChangePass.TabIndex = 0;
            this.btn_ChangePass.Text = "Thay đổi mật khẩu";
            this.btn_ChangePass.UseVisualStyleBackColor = true;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.BackgroundColor = System.Drawing.Color.Red;
            this.btnBack.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnBack.BorderRadius = 20;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 32);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "<--";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_ChangePass);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangePass;
        private Cocaro.CustomButton btnBack;
    }
}