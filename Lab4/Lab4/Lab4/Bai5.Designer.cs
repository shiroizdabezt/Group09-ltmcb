namespace Lab4
{
    partial class Bai5
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
            txtUrl=new TextBox();
            txtEmail=new TextBox();
            txtPassword=new TextBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            btnPost=new Button();
            rtxtToken=new RichTextBox();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location=new Point(119, 25);
            txtUrl.Name="txtUrl";
            txtUrl.Size=new Size(246, 23);
            txtUrl.TabIndex=0;
            txtUrl.Text="https://reqres.in/api/register";
            // 
            // txtEmail
            // 
            txtEmail.Location=new Point(119, 56);
            txtEmail.Name="txtEmail";
            txtEmail.Size=new Size(141, 23);
            txtEmail.TabIndex=1;
            txtEmail.Text="eve.holt@reqres.in";
            // 
            // txtPassword
            // 
            txtPassword.Location=new Point(119, 92);
            txtPassword.Name="txtPassword";
            txtPassword.Size=new Size(141, 23);
            txtPassword.TabIndex=2;
            txtPassword.Text="pistol";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(33, 25);
            label1.Name="label1";
            label1.Size=new Size(32, 17);
            label1.TabIndex=3;
            label1.Text="URL";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(33, 56);
            label2.Name="label2";
            label2.Size=new Size(69, 17);
            label2.TabIndex=4;
            label2.Text="Username";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(33, 92);
            label3.Name="label3";
            label3.Size=new Size(66, 17);
            label3.TabIndex=5;
            label3.Text="Password";
            // 
            // btnPost
            // 
            btnPost.Font=new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPost.Location=new Point(290, 57);
            btnPost.Name="btnPost";
            btnPost.Size=new Size(75, 58);
            btnPost.TabIndex=6;
            btnPost.Text="POST";
            btnPost.UseVisualStyleBackColor=true;
            btnPost.Click+=btnPost_Click;
            btnPost.KeyDown+=btnPost_KeyDown;
            // 
            // rtxtToken
            // 
            rtxtToken.Location=new Point(12, 130);
            rtxtToken.Name="rtxtToken";
            rtxtToken.Size=new Size(381, 201);
            rtxtToken.TabIndex=7;
            rtxtToken.Text="";
            rtxtToken.TextChanged+=rtxtToken_TextChanged;
            // 
            // Bai5
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(405, 343);
            Controls.Add(rtxtToken);
            Controls.Add(btnPost);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUrl);
            Name="Bai5";
            Text="Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnPost;
        private RichTextBox rtxtToken;
    }
}