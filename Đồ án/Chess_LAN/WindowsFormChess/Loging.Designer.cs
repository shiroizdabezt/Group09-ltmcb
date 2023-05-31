namespace Group9
{
    partial class Loging
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
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForgot = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(319, 287);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(319, 339);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(203, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PhoneNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(203, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btnForgot
            // 
            this.btnForgot.Location = new System.Drawing.Point(242, 397);
            this.btnForgot.Name = "btnForgot";
            this.btnForgot.Size = new System.Drawing.Size(75, 23);
            this.btnForgot.TabIndex = 6;
            this.btnForgot.Text = "Forgot";
            this.btnForgot.UseVisualStyleBackColor = true;
            this.btnForgot.Click += new System.EventHandler(this.btnForgot_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(386, 397);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin1
            // 
            this.btnLogin1.Location = new System.Drawing.Point(478, 311);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(75, 23);
            this.btnLogin1.TabIndex = 8;
            this.btnLogin1.Text = "Lủm";
            this.btnLogin1.UseVisualStyleBackColor = true;
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click);
            // 
            // Loging
            // 
            this.AcceptButton = this.btnLogin1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group9.Properties.Resources.Anhnen;
            this.ClientSize = new System.Drawing.Size(809, 620);
            this.Controls.Add(this.btnLogin1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnForgot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhoneNumber);
            this.Name = "Loging";
            this.Text = "Loging";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loging_FormClosing);
            this.Load += new System.EventHandler(this.Loging_Load);
            this.Enter += new System.EventHandler(this.btnLogin1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnForgot;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin1;
    }
}