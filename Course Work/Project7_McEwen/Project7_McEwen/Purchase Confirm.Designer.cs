namespace Project7_McEwen
{
    partial class Purchase_Confirm
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
            this.LblTotCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtboxCCnumber = new System.Windows.Forms.TextBox();
            this.TxtboxCCName = new System.Windows.Forms.TextBox();
            this.TxtboxCCcsv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTotCost
            // 
            this.LblTotCost.AutoSize = true;
            this.LblTotCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotCost.ForeColor = System.Drawing.Color.Crimson;
            this.LblTotCost.Location = new System.Drawing.Point(260, 52);
            this.LblTotCost.Name = "LblTotCost";
            this.LblTotCost.Size = new System.Drawing.Size(239, 31);
            this.LblTotCost.TabIndex = 0;
            this.LblTotCost.Text = "Total Cost: $0.00";
            this.LblTotCost.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Credit Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name on card:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "CSV:";
            // 
            // TxtboxCCnumber
            // 
            this.TxtboxCCnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxCCnumber.Location = new System.Drawing.Point(362, 135);
            this.TxtboxCCnumber.Name = "TxtboxCCnumber";
            this.TxtboxCCnumber.Size = new System.Drawing.Size(400, 35);
            this.TxtboxCCnumber.TabIndex = 4;
            // 
            // TxtboxCCName
            // 
            this.TxtboxCCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxCCName.Location = new System.Drawing.Point(362, 204);
            this.TxtboxCCName.Name = "TxtboxCCName";
            this.TxtboxCCName.Size = new System.Drawing.Size(400, 35);
            this.TxtboxCCName.TabIndex = 5;
            // 
            // TxtboxCCcsv
            // 
            this.TxtboxCCcsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxCCcsv.Location = new System.Drawing.Point(362, 273);
            this.TxtboxCCcsv.Name = "TxtboxCCcsv";
            this.TxtboxCCcsv.Size = new System.Drawing.Size(400, 35);
            this.TxtboxCCcsv.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(332, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Purchase_Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtboxCCcsv);
            this.Controls.Add(this.TxtboxCCName);
            this.Controls.Add(this.TxtboxCCnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTotCost);
            this.Name = "Purchase_Confirm";
            this.Text = "Purchase Confirm";
     
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTotCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtboxCCnumber;
        private System.Windows.Forms.TextBox TxtboxCCName;
        private System.Windows.Forms.TextBox TxtboxCCcsv;
        private System.Windows.Forms.Button button1;
    }
}