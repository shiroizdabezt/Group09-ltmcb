namespace Lab5
{
    partial class Main_Menu
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
            this.btnBai3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBai1
            // 
            this.btBai1.Location = new System.Drawing.Point(56, 54);
            this.btBai1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBai1.Name = "btBai1";
            this.btBai1.Size = new System.Drawing.Size(165, 54);
            this.btBai1.TabIndex = 0;
            this.btBai1.Text = "Bài 1";
            this.btBai1.UseVisualStyleBackColor = true;
            this.btBai1.Click += new System.EventHandler(this.btBai1_Click);
            // 
            // btBai2
            // 
            this.btBai2.Location = new System.Drawing.Point(277, 54);
            this.btBai2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBai2.Name = "btBai2";
            this.btBai2.Size = new System.Drawing.Size(165, 54);
            this.btBai2.TabIndex = 1;
            this.btBai2.Text = "Bài 2";
            this.btBai2.UseVisualStyleBackColor = true;
            this.btBai2.Click += new System.EventHandler(this.btBai2_Click);
            // 
            // btn_Bai4
            // 
            this.btn_Bai4.Location = new System.Drawing.Point(277, 172);
            this.btn_Bai4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Bai4.Name = "btn_Bai4";
            this.btn_Bai4.Size = new System.Drawing.Size(165, 54);
            this.btn_Bai4.TabIndex = 2;
            this.btn_Bai4.Text = "Bài 4";
            this.btn_Bai4.UseVisualStyleBackColor = true;
            this.btn_Bai4.Click += new System.EventHandler(this.btn_Bai4_Click);
            // 
            // btnBai3
            // 
            this.btnBai3.Location = new System.Drawing.Point(56, 172);
            this.btnBai3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBai3.Name = "btnBai3";
            this.btnBai3.Size = new System.Drawing.Size(165, 54);
            this.btnBai3.TabIndex = 3;
            this.btnBai3.Text = "Bài 3";
            this.btnBai3.UseVisualStyleBackColor = true;
            this.btnBai3.Click += new System.EventHandler(this.btnBai3_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 274);
            this.Controls.Add(this.btnBai3);
            this.Controls.Add(this.btn_Bai4);
            this.Controls.Add(this.btBai2);
            this.Controls.Add(this.btBai1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBai1;
        private System.Windows.Forms.Button btBai2;
        private System.Windows.Forms.Button btn_Bai4;
        private System.Windows.Forms.Button btnBai3;
    }
}

