namespace Lab5
{
    partial class Choose_Protocol
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
            this.IMAP = new System.Windows.Forms.Button();
            this.POP3 = new System.Windows.Forms.Button();
            this.lb_choose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IMAP
            // 
            this.IMAP.Location = new System.Drawing.Point(80, 133);
            this.IMAP.Name = "IMAP";
            this.IMAP.Size = new System.Drawing.Size(232, 138);
            this.IMAP.TabIndex = 0;
            this.IMAP.Text = "IMAP";
            this.IMAP.UseVisualStyleBackColor = true;
            this.IMAP.Click += new System.EventHandler(this.IMAP_Click);
            // 
            // POP3
            // 
            this.POP3.Location = new System.Drawing.Point(498, 133);
            this.POP3.Name = "POP3";
            this.POP3.Size = new System.Drawing.Size(232, 138);
            this.POP3.TabIndex = 1;
            this.POP3.Text = "POP3";
            this.POP3.UseVisualStyleBackColor = true;
            this.POP3.Click += new System.EventHandler(this.POP3_Click);
            // 
            // lb_choose
            // 
            this.lb_choose.AutoSize = true;
            this.lb_choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_choose.Location = new System.Drawing.Point(194, 55);
            this.lb_choose.Name = "lb_choose";
            this.lb_choose.Size = new System.Drawing.Size(423, 29);
            this.lb_choose.TabIndex = 2;
            this.lb_choose.Text = "Choose your protocol to read email";
            // 
            // Choose_Protocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_choose);
            this.Controls.Add(this.POP3);
            this.Controls.Add(this.IMAP);
            this.Name = "Choose_Protocol";
            this.Text = "Choose Protocol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IMAP;
        private System.Windows.Forms.Button POP3;
        private System.Windows.Forms.Label lb_choose;
    }
}