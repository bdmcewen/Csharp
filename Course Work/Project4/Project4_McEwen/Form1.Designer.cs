namespace Project4_McEwen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblSumSeries = new System.Windows.Forms.TextBox();
            this.lblProductSum = new System.Windows.Forms.TextBox();
            this.lblDivisionSum = new System.Windows.Forms.TextBox();
            this.lblSumLimit = new System.Windows.Forms.TextBox();
            this.txtProductSum = new System.Windows.Forms.TextBox();
            this.txtDivisionSum = new System.Windows.Forms.TextBox();
            this.txtSumSeries = new System.Windows.Forms.TextBox();
            this.lblSumOdd = new System.Windows.Forms.TextBox();
            this.lblProductOdd = new System.Windows.Forms.TextBox();
            this.txtSumLimit = new System.Windows.Forms.TextBox();
            this.txtSumOdd = new System.Windows.Forms.TextBox();
            this.txtProductOdd = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(403, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(293, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Number:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(87, 41);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(132, 22);
            this.txtInput.TabIndex = 0;
            this.txtInput.Tag = "0";
            // 
            // lblSumSeries
            // 
            this.lblSumSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumSeries.Location = new System.Drawing.Point(111, 212);
            this.lblSumSeries.Margin = new System.Windows.Forms.Padding(4);
            this.lblSumSeries.Name = "lblSumSeries";
            this.lblSumSeries.Size = new System.Drawing.Size(132, 26);
            this.lblSumSeries.TabIndex = 1;
            this.lblSumSeries.Text = "Sum of Series";
            // 
            // lblProductSum
            // 
            this.lblProductSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSum.Location = new System.Drawing.Point(111, 274);
            this.lblProductSum.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductSum.Name = "lblProductSum";
            this.lblProductSum.Size = new System.Drawing.Size(132, 26);
            this.lblProductSum.TabIndex = 2;
            this.lblProductSum.Text = "Product of Sum";
            this.lblProductSum.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // lblDivisionSum
            // 
            this.lblDivisionSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisionSum.Location = new System.Drawing.Point(111, 348);
            this.lblDivisionSum.Margin = new System.Windows.Forms.Padding(4);
            this.lblDivisionSum.Name = "lblDivisionSum";
            this.lblDivisionSum.Size = new System.Drawing.Size(132, 26);
            this.lblDivisionSum.TabIndex = 3;
            this.lblDivisionSum.Text = "Division of Sum";
            // 
            // lblSumLimit
            // 
            this.lblSumLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumLimit.Location = new System.Drawing.Point(545, 210);
            this.lblSumLimit.Margin = new System.Windows.Forms.Padding(4);
            this.lblSumLimit.Name = "lblSumLimit";
            this.lblSumLimit.Size = new System.Drawing.Size(132, 26);
            this.lblSumLimit.TabIndex = 4;
            this.lblSumLimit.Text = "Sum of Limit";
            // 
            // txtProductSum
            // 
            this.txtProductSum.Location = new System.Drawing.Point(339, 273);
            this.txtProductSum.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductSum.Name = "txtProductSum";
            this.txtProductSum.Size = new System.Drawing.Size(132, 22);
            this.txtProductSum.TabIndex = 5;
            // 
            // txtDivisionSum
            // 
            this.txtDivisionSum.Location = new System.Drawing.Point(339, 348);
            this.txtDivisionSum.Margin = new System.Windows.Forms.Padding(4);
            this.txtDivisionSum.Name = "txtDivisionSum";
            this.txtDivisionSum.Size = new System.Drawing.Size(132, 22);
            this.txtDivisionSum.TabIndex = 6;
            // 
            // txtSumSeries
            // 
            this.txtSumSeries.Location = new System.Drawing.Point(339, 212);
            this.txtSumSeries.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumSeries.Name = "txtSumSeries";
            this.txtSumSeries.Size = new System.Drawing.Size(132, 22);
            this.txtSumSeries.TabIndex = 7;
            // 
            // lblSumOdd
            // 
            this.lblSumOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumOdd.Location = new System.Drawing.Point(545, 273);
            this.lblSumOdd.Margin = new System.Windows.Forms.Padding(4);
            this.lblSumOdd.Name = "lblSumOdd";
            this.lblSumOdd.Size = new System.Drawing.Size(132, 26);
            this.lblSumOdd.TabIndex = 8;
            this.lblSumOdd.Text = "Sum of Odd";
            // 
            // lblProductOdd
            // 
            this.lblProductOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductOdd.Location = new System.Drawing.Point(545, 347);
            this.lblProductOdd.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductOdd.Name = "lblProductOdd";
            this.lblProductOdd.Size = new System.Drawing.Size(132, 26);
            this.lblProductOdd.TabIndex = 9;
            this.lblProductOdd.Text = "Product of Odd";
            // 
            // txtSumLimit
            // 
            this.txtSumLimit.Location = new System.Drawing.Point(760, 210);
            this.txtSumLimit.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumLimit.Name = "txtSumLimit";
            this.txtSumLimit.Size = new System.Drawing.Size(132, 22);
            this.txtSumLimit.TabIndex = 10;
            // 
            // txtSumOdd
            // 
            this.txtSumOdd.Location = new System.Drawing.Point(760, 273);
            this.txtSumOdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumOdd.Name = "txtSumOdd";
            this.txtSumOdd.Size = new System.Drawing.Size(132, 22);
            this.txtSumOdd.TabIndex = 11;
            // 
            // txtProductOdd
            // 
            this.txtProductOdd.Location = new System.Drawing.Point(760, 347);
            this.txtProductOdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductOdd.Name = "txtProductOdd";
            this.txtProductOdd.Size = new System.Drawing.Size(132, 22);
            this.txtProductOdd.TabIndex = 12;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(489, 418);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(111, 491);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(792, 480);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(0, 0);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(272, 196);
            this.lstOutput.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtProductOdd);
            this.Controls.Add(this.txtSumOdd);
            this.Controls.Add(this.txtSumLimit);
            this.Controls.Add(this.lblProductOdd);
            this.Controls.Add(this.lblSumOdd);
            this.Controls.Add(this.txtSumSeries);
            this.Controls.Add(this.txtDivisionSum);
            this.Controls.Add(this.txtProductSum);
            this.Controls.Add(this.lblSumLimit);
            this.Controls.Add(this.lblDivisionSum);
            this.Controls.Add(this.lblProductSum);
            this.Controls.Add(this.lblSumSeries);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Project 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox lblSumSeries;
        private System.Windows.Forms.TextBox lblProductSum;
        private System.Windows.Forms.TextBox lblDivisionSum;
        private System.Windows.Forms.TextBox lblSumLimit;
        private System.Windows.Forms.TextBox txtProductSum;
        private System.Windows.Forms.TextBox txtDivisionSum;
        private System.Windows.Forms.TextBox txtSumSeries;
        private System.Windows.Forms.TextBox lblSumOdd;
        private System.Windows.Forms.TextBox lblProductOdd;
        private System.Windows.Forms.TextBox txtSumLimit;
        private System.Windows.Forms.TextBox txtSumOdd;
        private System.Windows.Forms.TextBox txtProductOdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

