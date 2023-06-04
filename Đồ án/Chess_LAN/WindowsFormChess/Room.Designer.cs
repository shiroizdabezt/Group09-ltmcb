namespace Group9
{
    partial class Room
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
            this.lb_room_code = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack1 = new Cocaro.CustomButton();
            this.btnStart = new Cocaro.CustomButton();
            this.SuspendLayout();
            // 
            // lb_room_code
            // 
            this.lb_room_code.AutoSize = true;
            this.lb_room_code.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_room_code.Location = new System.Drawing.Point(398, 54);
            this.lb_room_code.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_room_code.Name = "lb_room_code";
            this.lb_room_code.Size = new System.Drawing.Size(76, 38);
            this.lb_room_code.TabIndex = 4;
            this.lb_room_code.Text = "code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your room code is:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 93);
            this.label2.TabIndex = 5;
            this.label2.Text = "Send this code to your friends and invite them to join the game";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnBack1.TabIndex = 53;
            this.btnBack1.TextColor = System.Drawing.Color.Transparent;
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStart.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.btnStart.BorderColor = System.Drawing.Color.Black;
            this.btnStart.BorderRadius = 20;
            this.btnStart.BorderSize = 2;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(270, 283);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 41);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.TextColor = System.Drawing.Color.Black;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(643, 363);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_room_code);
            this.Controls.Add(this.label1);
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_room_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Cocaro.CustomButton btnStart;
        private Cocaro.CustomButton btnBack1;
    }
}