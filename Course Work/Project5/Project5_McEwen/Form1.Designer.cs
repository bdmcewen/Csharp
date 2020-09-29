namespace Project5_McEwen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageWeight = new System.Windows.Forms.TextBox();
            this.txtShippingDistance = new System.Windows.Forms.TextBox();
            this.lblPackageWeight = new System.Windows.Forms.Label();
            this.lblShippingDistance = new System.Windows.Forms.Label();
            this.llblClear = new System.Windows.Forms.Button();
            this.grpBxCarrier = new System.Windows.Forms.GroupBox();
            this.RdoBtnUSPS = new System.Windows.Forms.RadioButton();
            this.RdoBtnFEDEX = new System.Windows.Forms.RadioButton();
            this.RdoBtnUPS = new System.Windows.Forms.RadioButton();
            this.pictBxUSPS = new System.Windows.Forms.PictureBox();
            this.pictBxFEDEX = new System.Windows.Forms.PictureBox();
            this.pictBxUPS = new System.Windows.Forms.PictureBox();
            this.lblShpncst = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lblupcharge = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBxCarrier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxUSPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxFEDEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxUPS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Two Eight Seven Shipping";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPackageWeight
            // 
            this.txtPackageWeight.Location = new System.Drawing.Point(34, 146);
            this.txtPackageWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackageWeight.Name = "txtPackageWeight";
            this.txtPackageWeight.Size = new System.Drawing.Size(109, 20);
            this.txtPackageWeight.TabIndex = 0;
            this.txtPackageWeight.Text = "5";
            this.txtPackageWeight.TextChanged += new System.EventHandler(this.TxtPackageWeight_TextChanged);
            // 
            // txtShippingDistance
            // 
            this.txtShippingDistance.Location = new System.Drawing.Point(35, 205);
            this.txtShippingDistance.Margin = new System.Windows.Forms.Padding(2);
            this.txtShippingDistance.Name = "txtShippingDistance";
            this.txtShippingDistance.Size = new System.Drawing.Size(108, 20);
            this.txtShippingDistance.TabIndex = 1;
            this.txtShippingDistance.TextChanged += new System.EventHandler(this.TxtShippingDistance_TextChanged);
            // 
            // lblPackageWeight
            // 
            this.lblPackageWeight.AutoSize = true;
            this.lblPackageWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageWeight.Location = new System.Drawing.Point(34, 128);
            this.lblPackageWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackageWeight.Name = "lblPackageWeight";
            this.lblPackageWeight.Size = new System.Drawing.Size(105, 13);
            this.lblPackageWeight.TabIndex = 3;
            this.lblPackageWeight.Text = "Package Weight:";
            // 
            // lblShippingDistance
            // 
            this.lblShippingDistance.AutoSize = true;
            this.lblShippingDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingDistance.Location = new System.Drawing.Point(34, 188);
            this.lblShippingDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShippingDistance.Name = "lblShippingDistance";
            this.lblShippingDistance.Size = new System.Drawing.Size(114, 13);
            this.lblShippingDistance.TabIndex = 4;
            this.lblShippingDistance.Text = "Shipping Distance:";
            // 
            // llblClear
            // 
            this.llblClear.AutoSize = true;
            this.llblClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.llblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblClear.Location = new System.Drawing.Point(44, 277);
            this.llblClear.Margin = new System.Windows.Forms.Padding(2);
            this.llblClear.Name = "llblClear";
            this.llblClear.Size = new System.Drawing.Size(88, 37);
            this.llblClear.TabIndex = 6;
            this.llblClear.Text = "Clear";
            this.llblClear.UseVisualStyleBackColor = false;
            this.llblClear.Click += new System.EventHandler(this.LlblClear_Click);
            // 
            // grpBxCarrier
            // 
            this.grpBxCarrier.Controls.Add(this.RdoBtnUSPS);
            this.grpBxCarrier.Controls.Add(this.RdoBtnFEDEX);
            this.grpBxCarrier.Controls.Add(this.RdoBtnUPS);
            this.grpBxCarrier.Controls.Add(this.pictBxUSPS);
            this.grpBxCarrier.Controls.Add(this.pictBxFEDEX);
            this.grpBxCarrier.Controls.Add(this.pictBxUPS);
            this.grpBxCarrier.Location = new System.Drawing.Point(204, 102);
            this.grpBxCarrier.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxCarrier.Name = "grpBxCarrier";
            this.grpBxCarrier.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxCarrier.Size = new System.Drawing.Size(179, 235);
            this.grpBxCarrier.TabIndex = 2;
            this.grpBxCarrier.TabStop = false;
            this.grpBxCarrier.Text = "Carrier";
            // 
            // RdoBtnUSPS
            // 
            this.RdoBtnUSPS.AutoSize = true;
            this.RdoBtnUSPS.Location = new System.Drawing.Point(19, 201);
            this.RdoBtnUSPS.Margin = new System.Windows.Forms.Padding(2);
            this.RdoBtnUSPS.Name = "RdoBtnUSPS";
            this.RdoBtnUSPS.Size = new System.Drawing.Size(14, 13);
            this.RdoBtnUSPS.TabIndex = 4;
            this.RdoBtnUSPS.TabStop = true;
            this.RdoBtnUSPS.UseVisualStyleBackColor = true;
            // 
            // RdoBtnFEDEX
            // 
            this.RdoBtnFEDEX.AutoSize = true;
            this.RdoBtnFEDEX.Location = new System.Drawing.Point(19, 110);
            this.RdoBtnFEDEX.Margin = new System.Windows.Forms.Padding(2);
            this.RdoBtnFEDEX.Name = "RdoBtnFEDEX";
            this.RdoBtnFEDEX.Size = new System.Drawing.Size(14, 13);
            this.RdoBtnFEDEX.TabIndex = 3;
            this.RdoBtnFEDEX.TabStop = true;
            this.RdoBtnFEDEX.UseVisualStyleBackColor = true;
            // 
            // RdoBtnUPS
            // 
            this.RdoBtnUPS.AutoSize = true;
            this.RdoBtnUPS.Location = new System.Drawing.Point(19, 53);
            this.RdoBtnUPS.Margin = new System.Windows.Forms.Padding(2);
            this.RdoBtnUPS.Name = "RdoBtnUPS";
            this.RdoBtnUPS.Size = new System.Drawing.Size(14, 13);
            this.RdoBtnUPS.TabIndex = 2;
            this.RdoBtnUPS.TabStop = true;
            this.RdoBtnUPS.UseVisualStyleBackColor = true;
            // 
            // pictBxUSPS
            // 
            this.pictBxUSPS.Image = ((System.Drawing.Image)(resources.GetObject("pictBxUSPS.Image")));
            this.pictBxUSPS.Location = new System.Drawing.Point(66, 145);
            this.pictBxUSPS.Margin = new System.Windows.Forms.Padding(2);
            this.pictBxUSPS.Name = "pictBxUSPS";
            this.pictBxUSPS.Size = new System.Drawing.Size(85, 85);
            this.pictBxUSPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictBxUSPS.TabIndex = 2;
            this.pictBxUSPS.TabStop = false;
            // 
            // pictBxFEDEX
            // 
            this.pictBxFEDEX.Image = ((System.Drawing.Image)(resources.GetObject("pictBxFEDEX.Image")));
            this.pictBxFEDEX.Location = new System.Drawing.Point(66, 83);
            this.pictBxFEDEX.Margin = new System.Windows.Forms.Padding(2);
            this.pictBxFEDEX.Name = "pictBxFEDEX";
            this.pictBxFEDEX.Size = new System.Drawing.Size(106, 50);
            this.pictBxFEDEX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictBxFEDEX.TabIndex = 1;
            this.pictBxFEDEX.TabStop = false;
            // 
            // pictBxUPS
            // 
            this.pictBxUPS.Image = ((System.Drawing.Image)(resources.GetObject("pictBxUPS.Image")));
            this.pictBxUPS.Location = new System.Drawing.Point(66, 25);
            this.pictBxUPS.Margin = new System.Windows.Forms.Padding(2);
            this.pictBxUPS.Name = "pictBxUPS";
            this.pictBxUPS.Size = new System.Drawing.Size(42, 50);
            this.pictBxUPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictBxUPS.TabIndex = 0;
            this.pictBxUPS.TabStop = false;
            // 
            // lblShpncst
            // 
            this.lblShpncst.AutoSize = true;
            this.lblShpncst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShpncst.Location = new System.Drawing.Point(447, 128);
            this.lblShpncst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShpncst.Name = "lblShpncst";
            this.lblShpncst.Size = new System.Drawing.Size(143, 24);
            this.lblShpncst.TabIndex = 7;
            this.lblShpncst.Text = "Shipping cost:";
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(483, 176);
            this.lbloutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(71, 26);
            this.lbloutput.TabIndex = 8;
            this.lbloutput.Text = "$0.00";
            // 
            // lblupcharge
            // 
            this.lblupcharge.AutoSize = true;
            this.lblupcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupcharge.Location = new System.Drawing.Point(419, 241);
            this.lblupcharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblupcharge.Name = "lblupcharge";
            this.lblupcharge.Size = new System.Drawing.Size(0, 13);
            this.lblupcharge.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(409, 275);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate Shipping Price";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblupcharge);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblShpncst);
            this.Controls.Add(this.grpBxCarrier);
            this.Controls.Add(this.llblClear);
            this.Controls.Add(this.lblShippingDistance);
            this.Controls.Add(this.lblPackageWeight);
            this.Controls.Add(this.txtShippingDistance);
            this.Controls.Add(this.txtPackageWeight);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxCarrier.ResumeLayout(false);
            this.grpBxCarrier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxUSPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxFEDEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxUPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackageWeight;
        private System.Windows.Forms.TextBox txtShippingDistance;
        private System.Windows.Forms.Label lblPackageWeight;
        private System.Windows.Forms.Label lblShippingDistance;
        private System.Windows.Forms.Button llblClear;
        private System.Windows.Forms.GroupBox grpBxCarrier;
        private System.Windows.Forms.RadioButton RdoBtnUSPS;
        private System.Windows.Forms.RadioButton RdoBtnFEDEX;
        private System.Windows.Forms.RadioButton RdoBtnUPS;
        private System.Windows.Forms.PictureBox pictBxUSPS;
        private System.Windows.Forms.PictureBox pictBxFEDEX;
        private System.Windows.Forms.PictureBox pictBxUPS;
        private System.Windows.Forms.Label lblShpncst;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lblupcharge;
        private System.Windows.Forms.Button button1;
    }
}

