namespace LoginForm
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
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(260, 124);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(146, 16);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Tên đăng nhập (Email):";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(260, 190);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(113, 16);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Mật khẩu (MSSV):";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(263, 152);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(202, 22);
			this.txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(263, 220);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(202, 22);
			this.txtPassword.TabIndex = 3;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLogin.Location = new System.Drawing.Point(319, 264);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(87, 41);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Đăng Nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(342, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "HUCE";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
    }
}

