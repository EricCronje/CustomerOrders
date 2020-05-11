namespace WindowsFormsSales
{
    partial class FrmLogin
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
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(38, 45);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(32, 13);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "User:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(38, 72);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(56, 13);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password:";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(100, 109);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "&Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TbUser
            // 
            this.TbUser.Location = new System.Drawing.Point(100, 42);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(190, 20);
            this.TbUser.TabIndex = 0;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(100, 72);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(190, 20);
            this.TbPassword.TabIndex = 1;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.TextBox TbPassword;
    }
}

