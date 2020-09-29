namespace Project_2
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
            this.lblgrossincome = new System.Windows.Forms.Label();
            this.lblstatetax = new System.Windows.Forms.Label();
            this.lblfederaltax = new System.Windows.Forms.Label();
            this.lblnetincome = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttoncalculate = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.txtgrossincome = new System.Windows.Forms.TextBox();
            this.txtstatetax = new System.Windows.Forms.TextBox();
            this.txtfederaltax = new System.Windows.Forms.TextBox();
            this.txtnetincome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblgrossincome
            // 
            this.lblgrossincome.AutoSize = true;
            this.lblgrossincome.Location = new System.Drawing.Point(74, 111);
            this.lblgrossincome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgrossincome.Name = "lblgrossincome";
            this.lblgrossincome.Size = new System.Drawing.Size(156, 20);
            this.lblgrossincome.TabIndex = 6;
            this.lblgrossincome.Text = "Enter Gross Income:";
            // 
            // lblstatetax
            // 
            this.lblstatetax.AutoSize = true;
            this.lblstatetax.Location = new System.Drawing.Point(74, 170);
            this.lblstatetax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstatetax.Name = "lblstatetax";
            this.lblstatetax.Size = new System.Drawing.Size(81, 20);
            this.lblstatetax.TabIndex = 7;
            this.lblstatetax.Text = "State Tax:";
            // 
            // lblfederaltax
            // 
            this.lblfederaltax.AutoSize = true;
            this.lblfederaltax.Location = new System.Drawing.Point(74, 231);
            this.lblfederaltax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfederaltax.Name = "lblfederaltax";
            this.lblfederaltax.Size = new System.Drawing.Size(96, 20);
            this.lblfederaltax.TabIndex = 8;
            this.lblfederaltax.Text = "Federal Tax:";
            // 
            // lblnetincome
            // 
            this.lblnetincome.AutoSize = true;
            this.lblnetincome.Location = new System.Drawing.Point(74, 297);
            this.lblnetincome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnetincome.Name = "lblnetincome";
            this.lblnetincome.Size = new System.Drawing.Size(95, 20);
            this.lblnetincome.TabIndex = 9;
            this.lblnetincome.Text = "Net Income:";
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(183, 399);
            this.buttonclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(112, 36);
            this.buttonclear.TabIndex = 2;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.Buttonclear_Click);
            // 
            // buttoncalculate
            // 
            this.buttoncalculate.Location = new System.Drawing.Point(412, 398);
            this.buttoncalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttoncalculate.Name = "buttoncalculate";
            this.buttoncalculate.Size = new System.Drawing.Size(112, 36);
            this.buttoncalculate.TabIndex = 1;
            this.buttoncalculate.Text = "Calculate";
            this.buttoncalculate.UseVisualStyleBackColor = true;
            this.buttoncalculate.Click += new System.EventHandler(this.Buttoncalculate_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(605, 398);
            this.buttonclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(112, 36);
            this.buttonclose.TabIndex = 3;
            this.buttonclose.Text = "Close";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.Buttonclose_Click);
            // 
            // txtgrossincome
            // 
            this.txtgrossincome.Location = new System.Drawing.Point(412, 111);
            this.txtgrossincome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgrossincome.Name = "txtgrossincome";
            this.txtgrossincome.Size = new System.Drawing.Size(148, 26);
            this.txtgrossincome.TabIndex = 0;
            // 
            // txtstatetax
            // 
            this.txtstatetax.Location = new System.Drawing.Point(412, 170);
            this.txtstatetax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtstatetax.Name = "txtstatetax";
            this.txtstatetax.Size = new System.Drawing.Size(148, 26);
            this.txtstatetax.TabIndex = 14;
            // 
            // txtfederaltax
            // 
            this.txtfederaltax.Location = new System.Drawing.Point(412, 231);
            this.txtfederaltax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfederaltax.Name = "txtfederaltax";
            this.txtfederaltax.Size = new System.Drawing.Size(148, 26);
            this.txtfederaltax.TabIndex = 15;
            // 
            // txtnetincome
            // 
            this.txtnetincome.BackColor = System.Drawing.SystemColors.Window;
            this.txtnetincome.Location = new System.Drawing.Point(412, 297);
            this.txtnetincome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnetincome.Name = "txtnetincome";
            this.txtnetincome.Size = new System.Drawing.Size(148, 26);
            this.txtnetincome.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 537);
            this.Controls.Add(this.txtnetincome);
            this.Controls.Add(this.txtfederaltax);
            this.Controls.Add(this.txtstatetax);
            this.Controls.Add(this.txtgrossincome);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttoncalculate);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.lblnetincome);
            this.Controls.Add(this.lblfederaltax);
            this.Controls.Add(this.lblstatetax);
            this.Controls.Add(this.lblgrossincome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Project 2 – Tax Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgrossincome;
        private System.Windows.Forms.Label lblstatetax;
        private System.Windows.Forms.Label lblfederaltax;
        private System.Windows.Forms.Label lblnetincome;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttoncalculate;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.TextBox txtgrossincome;
        private System.Windows.Forms.TextBox txtstatetax;
        private System.Windows.Forms.TextBox txtfederaltax;
        private System.Windows.Forms.TextBox txtnetincome;
    }
}

