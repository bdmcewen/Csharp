namespace blank
{
    partial class frm_Project
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
            this.lbl_Display = new System.Windows.Forms.Label();
            this.radio_Blue = new System.Windows.Forms.RadioButton();
            this.radio_White = new System.Windows.Forms.RadioButton();
            this.radio_Red = new System.Windows.Forms.RadioButton();
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.grpSelection = new System.Windows.Forms.GroupBox();
            this.radHello = new System.Windows.Forms.RadioButton();
            this.radBonjour = new System.Windows.Forms.RadioButton();
            this.radHola = new System.Windows.Forms.RadioButton();
            this.radClear = new System.Windows.Forms.RadioButton();
            this.txtDisplayText = new System.Windows.Forms.TextBox();
            this.grpSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Display
            // 
            this.lbl_Display.AutoSize = true;
            this.lbl_Display.Location = new System.Drawing.Point(35, 30);
            this.lbl_Display.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(164, 17);
            this.lbl_Display.TabIndex = 0;
            this.lbl_Display.Text = "Pick a background color.";
            // 
            // radio_Blue
            // 
            this.radio_Blue.AutoSize = true;
            this.radio_Blue.Location = new System.Drawing.Point(51, 87);
            this.radio_Blue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_Blue.Name = "radio_Blue";
            this.radio_Blue.Size = new System.Drawing.Size(54, 21);
            this.radio_Blue.TabIndex = 1;
            this.radio_Blue.TabStop = true;
            this.radio_Blue.Text = "&Blue";
            this.radio_Blue.UseVisualStyleBackColor = true;
            // 
            // radio_White
            // 
            this.radio_White.AutoSize = true;
            this.radio_White.Location = new System.Drawing.Point(355, 87);
            this.radio_White.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_White.Name = "radio_White";
            this.radio_White.Size = new System.Drawing.Size(62, 21);
            this.radio_White.TabIndex = 2;
            this.radio_White.TabStop = true;
            this.radio_White.Text = "&White";
            this.radio_White.UseVisualStyleBackColor = true;
            // 
            // radio_Red
            // 
            this.radio_Red.AutoSize = true;
            this.radio_Red.Location = new System.Drawing.Point(201, 87);
            this.radio_Red.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_Red.Name = "radio_Red";
            this.radio_Red.Size = new System.Drawing.Size(52, 21);
            this.radio_Red.TabIndex = 3;
            this.radio_Red.TabStop = true;
            this.radio_Red.Text = "&Red";
            this.radio_Red.UseVisualStyleBackColor = true;
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(741, 62);
            this.btn_Display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(100, 28);
            this.btn_Display.TabIndex = 4;
            this.btn_Display.Text = "&Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(741, 97);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 28);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "&Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(451, 492);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 28);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "&Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // grpSelection
            // 
            this.grpSelection.Controls.Add(this.txtDisplayText);
            this.grpSelection.Controls.Add(this.radClear);
            this.grpSelection.Controls.Add(this.radHola);
            this.grpSelection.Controls.Add(this.radBonjour);
            this.grpSelection.Controls.Add(this.radHello);
            this.grpSelection.Location = new System.Drawing.Point(38, 173);
            this.grpSelection.Name = "grpSelection";
            this.grpSelection.Size = new System.Drawing.Size(926, 283);
            this.grpSelection.TabIndex = 7;
            this.grpSelection.TabStop = false;
            this.grpSelection.Text = "Select One Option";
            // 
            // radHello
            // 
            this.radHello.AutoSize = true;
            this.radHello.Location = new System.Drawing.Point(71, 200);
            this.radHello.Name = "radHello";
            this.radHello.Size = new System.Drawing.Size(108, 21);
            this.radHello.TabIndex = 0;
            this.radHello.TabStop = true;
            this.radHello.Text = "Display &Hello";
            this.radHello.UseVisualStyleBackColor = true;
            this.radHello.CheckedChanged += new System.EventHandler(this.radHello_CheckedChanged);
            // 
            // radBonjour
            // 
            this.radBonjour.AutoSize = true;
            this.radBonjour.Location = new System.Drawing.Point(287, 200);
            this.radBonjour.Name = "radBonjour";
            this.radBonjour.Size = new System.Drawing.Size(125, 21);
            this.radBonjour.TabIndex = 1;
            this.radBonjour.TabStop = true;
            this.radBonjour.Text = "Display &Bonjour";
            this.radBonjour.UseVisualStyleBackColor = true;
            this.radBonjour.CheckedChanged += new System.EventHandler(this.radBonjou_CheckedChanged);
            // 
            // radHola
            // 
            this.radHola.AutoSize = true;
            this.radHola.Location = new System.Drawing.Point(506, 200);
            this.radHola.Name = "radHola";
            this.radHola.Size = new System.Drawing.Size(105, 21);
            this.radHola.TabIndex = 2;
            this.radHola.TabStop = true;
            this.radHola.Text = "Display &Hola";
            this.radHola.UseVisualStyleBackColor = true;
            this.radHola.CheckedChanged += new System.EventHandler(this.radHola_CheckedChanged);
            // 
            // radClear
            // 
            this.radClear.AutoSize = true;
            this.radClear.Location = new System.Drawing.Point(703, 203);
            this.radClear.Name = "radClear";
            this.radClear.Size = new System.Drawing.Size(59, 21);
            this.radClear.TabIndex = 3;
            this.radClear.TabStop = true;
            this.radClear.Text = "&Clear";
            this.radClear.UseVisualStyleBackColor = true;
            this.radClear.CheckedChanged += new System.EventHandler(this.radClear_CheckedChanged);
            // 
            // txtDisplayText
            // 
            this.txtDisplayText.Location = new System.Drawing.Point(357, 53);
            this.txtDisplayText.Name = "txtDisplayText";
            this.txtDisplayText.Size = new System.Drawing.Size(178, 23);
            this.txtDisplayText.TabIndex = 4;
            // 
            // frm_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpSelection);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.radio_Red);
            this.Controls.Add(this.radio_White);
            this.Controls.Add(this.radio_Blue);
            this.Controls.Add(this.lbl_Display);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Project";
            this.Text = "Project 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSelection.ResumeLayout(false);
            this.grpSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Display;
        private System.Windows.Forms.RadioButton radio_Blue;
        private System.Windows.Forms.RadioButton radio_White;
        private System.Windows.Forms.RadioButton radio_Red;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox grpSelection;
        private System.Windows.Forms.TextBox txtDisplayText;
        private System.Windows.Forms.RadioButton radClear;
        private System.Windows.Forms.RadioButton radHola;
        private System.Windows.Forms.RadioButton radBonjour;
        private System.Windows.Forms.RadioButton radHello;
    }
}

