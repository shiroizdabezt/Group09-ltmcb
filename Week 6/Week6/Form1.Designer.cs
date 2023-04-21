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
            this.cbbAPI = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_display)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_get
            // 
            this.bt_get.Location = new System.Drawing.Point(756, 12);
            this.bt_get.Margin = new System.Windows.Forms.Padding(2);
            this.bt_get.Name = "bt_get";
            this.bt_get.Size = new System.Drawing.Size(112, 26);
            this.bt_get.TabIndex = 7;
            this.bt_get.Text = "Get API";
            this.bt_get.UseVisualStyleBackColor = true;
            this.bt_get.Click += new System.EventHandler(this.bt_get_Click);
            // 
            // dgv_display
            // 
            this.dgv_display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_display.Location = new System.Drawing.Point(11, 42);
            this.dgv_display.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_display.Name = "dgv_display";
            this.dgv_display.RowHeadersWidth = 51;
            this.dgv_display.RowTemplate.Height = 24;
            this.dgv_display.Size = new System.Drawing.Size(859, 555);
            this.dgv_display.TabIndex = 5;
            // 
            // cbbAPI
            // 
            this.cbbAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAPI.FormattingEnabled = true;
            this.cbbAPI.Items.AddRange(new object[] {
            "https://jsonplaceholder.typicode.com/todos",
            "https://jsonplaceholder.typicode.com/comments",
            "https://jsonplaceholder.typicode.com/albums"});
            this.cbbAPI.Location = new System.Drawing.Point(148, 12);
            this.cbbAPI.Name = "cbbAPI";
            this.cbbAPI.Size = new System.Drawing.Size(603, 24);
            this.cbbAPI.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chose API link:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbAPI);
            this.Controls.Add(this.bt_get);
            this.Controls.Add(this.dgv_display);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_get;
        private System.Windows.Forms.DataGridView dgv_display;
        private System.Windows.Forms.ComboBox cbbAPI;
        private System.Windows.Forms.Label label1;
    }
}

