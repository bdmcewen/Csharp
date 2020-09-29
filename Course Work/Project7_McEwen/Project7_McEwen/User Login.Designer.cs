namespace Project7_McEwen
{
    partial class User_Login
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
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblPassWord = new System.Windows.Forms.Label();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.linkLabelCreateAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(159, 133);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(37, 13);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "e-mail:";
            // 
            // LblPassWord
            // 
            this.LblPassWord.AutoSize = true;
            this.LblPassWord.Location = new System.Drawing.Point(162, 179);
            this.LblPassWord.Name = "LblPassWord";
            this.LblPassWord.Size = new System.Drawing.Size(55, 13);
            this.LblPassWord.TabIndex = 1;
            this.LblPassWord.Text = "password:";
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(226, 125);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxEmail.TabIndex = 2;
            this.TxtBoxEmail.Text = "phil@unco.edu";
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.Location = new System.Drawing.Point(226, 171);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxPassword.TabIndex = 3;
            this.TxtBoxPassword.Text = "************";
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogin.Location = new System.Drawing.Point(439, 167);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(122, 41);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // linkLabelCreateAccount
            // 
            this.linkLabelCreateAccount.AutoSize = true;
            this.linkLabelCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateAccount.Location = new System.Drawing.Point(29, 266);
            this.linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            this.linkLabelCreateAccount.Size = new System.Drawing.Size(106, 13);
            this.linkLabelCreateAccount.TabIndex = 5;
            this.linkLabelCreateAccount.TabStop = true;
            this.linkLabelCreateAccount.Text = "Create User Account";
            this.linkLabelCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCreateAccount_LinkClicked);
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 373);
            this.Controls.Add(this.linkLabelCreateAccount);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtBoxPassword);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.LblPassWord);
            this.Controls.Add(this.LblEmail);
            this.Name = "User_Login";
            this.Text = "User_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblPassWord;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.TextBox TxtBoxPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel linkLabelCreateAccount;
    }
}