namespace Group9
{
    partial class ChangeUserNameForm
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
            this.txt_NewUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_NewUsername
            // 
            this.txt_NewUsername.Location = new System.Drawing.Point(105, 32);
            this.txt_NewUsername.Name = "txt_NewUsername";
            this.txt_NewUsername.Size = new System.Drawing.Size(192, 20);
            this.txt_NewUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Username";
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(91, 68);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(99, 44);
            this.btn_Change.TabIndex = 2;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // ChangeUserNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 132);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NewUsername);
            this.Name = "ChangeUserNameForm";
            this.Text = "ChangeUserNameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NewUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Change;
    }
}