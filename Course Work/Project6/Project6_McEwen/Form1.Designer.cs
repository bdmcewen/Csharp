namespace Project6_McEwen
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
            this.lstBxOutput = new System.Windows.Forms.ListBox();
            this.lblnumTeams = new System.Windows.Forms.Label();
            this.btnAscending = new System.Windows.Forms.Button();
            this.btnDescending = new System.Windows.Forms.Button();
            this.btnShowYears = new System.Windows.Forms.Button();
            this.btnRemoveDups = new System.Windows.Forms.Button();
            this.btn1xChamps = new System.Windows.Forms.Button();
            this.lblchamps = new System.Windows.Forms.Label();
            this.TxtBoxChamps = new System.Windows.Forms.TextBox();
            this.btnCalcChamp = new System.Windows.Forms.Button();
            this.btnCalcYears = new System.Windows.Forms.Button();
            this.TxtBoxYear = new System.Windows.Forms.TextBox();
            this.lblEnteryear = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxOutput
            // 
            this.lstBxOutput.FormattingEnabled = true;
            this.lstBxOutput.Location = new System.Drawing.Point(13, 56);
            this.lstBxOutput.Name = "lstBxOutput";
            this.lstBxOutput.Size = new System.Drawing.Size(263, 381);
            this.lstBxOutput.TabIndex = 0;
            // 
            // lblnumTeams
            // 
            this.lblnumTeams.AutoSize = true;
            this.lblnumTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumTeams.Location = new System.Drawing.Point(12, 22);
            this.lblnumTeams.Name = "lblnumTeams";
            this.lblnumTeams.Size = new System.Drawing.Size(218, 29);
            this.lblnumTeams.TabIndex = 1;
            this.lblnumTeams.Text = "How Many Teams?";
            this.lblnumTeams.Click += new System.EventHandler(this.lblnumTeams_Click);
            // 
            // btnAscending
            // 
            this.btnAscending.AutoSize = true;
            this.btnAscending.Location = new System.Drawing.Point(407, 56);
            this.btnAscending.Name = "btnAscending";
            this.btnAscending.Size = new System.Drawing.Size(75, 23);
            this.btnAscending.TabIndex = 4;
            this.btnAscending.Text = "Ascending";
            this.btnAscending.UseVisualStyleBackColor = true;
            this.btnAscending.Click += new System.EventHandler(this.BtnAscending_Click);
            // 
            // btnDescending
            // 
            this.btnDescending.AutoSize = true;
            this.btnDescending.Location = new System.Drawing.Point(407, 86);
            this.btnDescending.Name = "btnDescending";
            this.btnDescending.Size = new System.Drawing.Size(75, 23);
            this.btnDescending.TabIndex = 5;
            this.btnDescending.Text = "Descending";
            this.btnDescending.UseVisualStyleBackColor = true;
            this.btnDescending.Click += new System.EventHandler(this.BtnDescending_Click);
            // 
            // btnShowYears
            // 
            this.btnShowYears.AutoSize = true;
            this.btnShowYears.Location = new System.Drawing.Point(407, 116);
            this.btnShowYears.Name = "btnShowYears";
            this.btnShowYears.Size = new System.Drawing.Size(167, 23);
            this.btnShowYears.TabIndex = 6;
            this.btnShowYears.Text = "Show Years and Winning Team";
            this.btnShowYears.UseVisualStyleBackColor = true;
            this.btnShowYears.Click += new System.EventHandler(this.BtnShowYears_Click);
            // 
            // btnRemoveDups
            // 
            this.btnRemoveDups.AutoSize = true;
            this.btnRemoveDups.Location = new System.Drawing.Point(407, 146);
            this.btnRemoveDups.Name = "btnRemoveDups";
            this.btnRemoveDups.Size = new System.Drawing.Size(140, 23);
            this.btnRemoveDups.TabIndex = 7;
            this.btnRemoveDups.Text = "Remove Team Duplicates";
            this.btnRemoveDups.UseVisualStyleBackColor = true;
            this.btnRemoveDups.Click += new System.EventHandler(this.BtnRemoveDups_Click);
            // 
            // btn1xChamps
            // 
            this.btn1xChamps.Location = new System.Drawing.Point(407, 176);
            this.btn1xChamps.Name = "btn1xChamps";
            this.btn1xChamps.Size = new System.Drawing.Size(75, 23);
            this.btn1xChamps.TabIndex = 8;
            this.btn1xChamps.Text = "One Time Champs";
            this.btn1xChamps.UseVisualStyleBackColor = true;
            this.btn1xChamps.Click += new System.EventHandler(this.btn1xChamps_Click);
            // 
            // lblchamps
            // 
            this.lblchamps.AutoSize = true;
            this.lblchamps.Location = new System.Drawing.Point(306, 205);
            this.lblchamps.Name = "lblchamps";
            this.lblchamps.Size = new System.Drawing.Size(99, 13);
            this.lblchamps.TabIndex = 7;
            this.lblchamps.Text = "# of championships";
            // 
            // TxtBoxChamps
            // 
            this.TxtBoxChamps.Location = new System.Drawing.Point(407, 206);
            this.TxtBoxChamps.Name = "TxtBoxChamps";
            this.TxtBoxChamps.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxChamps.TabIndex = 0;
            // 
            // btnCalcChamp
            // 
            this.btnCalcChamp.Location = new System.Drawing.Point(512, 202);
            this.btnCalcChamp.Name = "btnCalcChamp";
            this.btnCalcChamp.Size = new System.Drawing.Size(75, 23);
            this.btnCalcChamp.TabIndex = 2;
            this.btnCalcChamp.Text = "Calculate";
            this.btnCalcChamp.UseVisualStyleBackColor = true;
            this.btnCalcChamp.Click += new System.EventHandler(this.btnCalcChamp_Click);
            // 
            // btnCalcYears
            // 
            this.btnCalcYears.Location = new System.Drawing.Point(514, 245);
            this.btnCalcYears.Name = "btnCalcYears";
            this.btnCalcYears.Size = new System.Drawing.Size(75, 23);
            this.btnCalcYears.TabIndex = 3;
            this.btnCalcYears.Text = "Calculate";
            this.btnCalcYears.UseVisualStyleBackColor = true;
            this.btnCalcYears.Click += new System.EventHandler(this.btnCalcYears_Click);
            // 
            // TxtBoxYear
            // 
            this.TxtBoxYear.Location = new System.Drawing.Point(408, 248);
            this.TxtBoxYear.Name = "TxtBoxYear";
            this.TxtBoxYear.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxYear.TabIndex = 1;
            // 
            // lblEnteryear
            // 
            this.lblEnteryear.AutoSize = true;
            this.lblEnteryear.Location = new System.Drawing.Point(306, 248);
            this.lblEnteryear.Name = "lblEnteryear";
            this.lblEnteryear.Size = new System.Drawing.Size(60, 13);
            this.lblEnteryear.TabIndex = 10;
            this.lblEnteryear.Text = "Enter Year:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(309, 347);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(514, 346);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcYears);
            this.Controls.Add(this.TxtBoxYear);
            this.Controls.Add(this.lblEnteryear);
            this.Controls.Add(this.btnCalcChamp);
            this.Controls.Add(this.TxtBoxChamps);
            this.Controls.Add(this.lblchamps);
            this.Controls.Add(this.btn1xChamps);
            this.Controls.Add(this.btnRemoveDups);
            this.Controls.Add(this.btnShowYears);
            this.Controls.Add(this.btnDescending);
            this.Controls.Add(this.btnAscending);
            this.Controls.Add(this.lblnumTeams);
            this.Controls.Add(this.lstBxOutput);
            this.Name = "Form1";
            this.Text = "Project 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxOutput;
        private System.Windows.Forms.Label lblnumTeams;
        private System.Windows.Forms.Button btnAscending;
        private System.Windows.Forms.Button btnDescending;
        private System.Windows.Forms.Button btnShowYears;
        private System.Windows.Forms.Button btnRemoveDups;
        private System.Windows.Forms.Button btn1xChamps;
        private System.Windows.Forms.Label lblchamps;
        private System.Windows.Forms.TextBox TxtBoxChamps;
        private System.Windows.Forms.Button btnCalcChamp;
        private System.Windows.Forms.Button btnCalcYears;
        private System.Windows.Forms.TextBox TxtBoxYear;
        private System.Windows.Forms.Label lblEnteryear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnclose;
    }
}

