
namespace Group9
{
    partial class InGameForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbCompetitorName = new System.Windows.Forms.Label();
            this.btnBack = new Cocaro.CustomButton();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(299, 747);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 16);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "You: ";
            // 
            // lbCompetitorName
            // 
            this.lbCompetitorName.AutoSize = true;
            this.lbCompetitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompetitorName.ForeColor = System.Drawing.Color.White;
            this.lbCompetitorName.Location = new System.Drawing.Point(299, 24);
            this.lbCompetitorName.Name = "lbCompetitorName";
            this.lbCompetitorName.Size = new System.Drawing.Size(90, 16);
            this.lbCompetitorName.TabIndex = 18;
            this.lbCompetitorName.Text = "Competitor: ";
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
            this.btnBack.Size = new System.Drawing.Size(41, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<--";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // InGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(804, 781);
            this.ControlBox = false;
            this.Controls.Add(this.lbCompetitorName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InGameForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InGameForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cocaro.CustomButton btnBack;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCompetitorName;
    }
}

