namespace Project7_McEwen
{
    partial class AccountCreation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TxtBoxAge = new System.Windows.Forms.TextBox();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxName.Location = new System.Drawing.Point(338, 104);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(300, 38);
            this.TxtBoxName.TabIndex = 4;
            // 
            // TxtBoxAge
            // 
            this.TxtBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxAge.Location = new System.Drawing.Point(338, 168);
            this.TxtBoxAge.Name = "TxtBoxAge";
            this.TxtBoxAge.Size = new System.Drawing.Size(300, 38);
            this.TxtBoxAge.TabIndex = 5;
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxEmail.Location = new System.Drawing.Point(338, 232);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(300, 38);
            this.TxtBoxEmail.TabIndex = 6;
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPassword.Location = new System.Drawing.Point(338, 296);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.Size = new System.Drawing.Size(300, 38);
            this.TxtBoxPassword.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(338, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtBoxPassword);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.TxtBoxAge);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountCreation";
            this.Text = "Account Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.TextBox TxtBoxAge;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.TextBox TxtBoxPassword;
        private System.Windows.Forms.Button button1;
    }
}