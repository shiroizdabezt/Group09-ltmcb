namespace Week6
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
            this.bt_get = new System.Windows.Forms.Button();
            this.dgv_display = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_display)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_get
            // 
            this.bt_get.Location = new System.Drawing.Point(622, 87);
            this.bt_get.Name = "bt_get";
            this.bt_get.Size = new System.Drawing.Size(149, 251);
            this.bt_get.TabIndex = 7;
            this.bt_get.Text = "Get API";
            this.bt_get.UseVisualStyleBackColor = true;
            this.bt_get.Click += new System.EventHandler(this.bt_get_Click);
            // 
            // dgv_display
            // 
            this.dgv_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_display.Location = new System.Drawing.Point(12, 2);
            this.dgv_display.Name = "dgv_display";
            this.dgv_display.RowHeadersWidth = 51;
            this.dgv_display.RowTemplate.Height = 24;
            this.dgv_display.Size = new System.Drawing.Size(572, 446);
            this.dgv_display.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_get);
            this.Controls.Add(this.dgv_display);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_get;
        private System.Windows.Forms.DataGridView dgv_display;
    }
}

