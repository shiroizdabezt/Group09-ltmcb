namespace Lab5
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
            this.btBai1 = new System.Windows.Forms.Button();
            this.btBai2 = new System.Windows.Forms.Button();
            this.btn_Bai4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBai1
            // 
            this.btBai1.Location = new System.Drawing.Point(42, 44);
            this.btBai1.Name = "btBai1";
            this.btBai1.Size = new System.Drawing.Size(124, 44);
            this.btBai1.TabIndex = 0;
            this.btBai1.Text = "Bài 1";
            this.btBai1.UseVisualStyleBackColor = true;
            this.btBai1.Click += new System.EventHandler(this.btBai1_Click);
            // 
            // btBai2
            // 
            this.btBai2.Location = new System.Drawing.Point(208, 44);
            this.btBai2.Name = "btBai2";
            this.btBai2.Size = new System.Drawing.Size(124, 44);
            this.btBai2.TabIndex = 1;
            this.btBai2.Text = "Bài 2";
            this.btBai2.UseVisualStyleBackColor = true;
            this.btBai2.Click += new System.EventHandler(this.btBai2_Click);
            // 
            // btn_Bai4
            // 
            this.btn_Bai4.Location = new System.Drawing.Point(208, 140);
            this.btn_Bai4.Name = "btn_Bai4";
            this.btn_Bai4.Size = new System.Drawing.Size(124, 44);
            this.btn_Bai4.TabIndex = 2;
            this.btn_Bai4.Text = "Bài 4";
            this.btn_Bai4.UseVisualStyleBackColor = true;
            this.btn_Bai4.Click += new System.EventHandler(this.btn_Bai4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 223);
            this.Controls.Add(this.btn_Bai4);
            this.Controls.Add(this.btBai2);
            this.Controls.Add(this.btBai1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBai1;
        private System.Windows.Forms.Button btBai2;
        private System.Windows.Forms.Button btn_Bai4;
    }
}

