namespace Project7_McEwen
{
    partial class Admin
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
            this.lblttlcost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblud = new System.Windows.Forms.Label();
            this.lblcl = new System.Windows.Forms.Label();
            this.lblll = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtconfirmsearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerlvlSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClublvlSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperlvlSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblttlcost
            // 
            this.lblttlcost.AutoSize = true;
            this.lblttlcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttlcost.ForeColor = System.Drawing.Color.Crimson;
            this.lblttlcost.Location = new System.Drawing.Point(52, 42);
            this.lblttlcost.Name = "lblttlcost";
            this.lblttlcost.Size = new System.Drawing.Size(340, 31);
            this.lblttlcost.TabIndex = 0;
            this.lblttlcost.Text = "Total Sales: $000,000.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblud);
            this.groupBox1.Controls.Add(this.lblcl);
            this.groupBox1.Controls.Add(this.lblll);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(58, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seats Remaining";
            // 
            // lblud
            // 
            this.lblud.AutoSize = true;
            this.lblud.Location = new System.Drawing.Point(257, 74);
            this.lblud.Name = "lblud";
            this.lblud.Size = new System.Drawing.Size(25, 13);
            this.lblud.TabIndex = 8;
            this.lblud.Text = "200";
            // 
            // lblcl
            // 
            this.lblcl.AutoSize = true;
            this.lblcl.Location = new System.Drawing.Point(137, 73);
            this.lblcl.Name = "lblcl";
            this.lblcl.Size = new System.Drawing.Size(19, 13);
            this.lblcl.TabIndex = 7;
            this.lblcl.Text = "75";
            // 
            // lblll
            // 
            this.lblll.AutoSize = true;
            this.lblll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblll.Location = new System.Drawing.Point(31, 71);
            this.lblll.Name = "lblll";
            this.lblll.Size = new System.Drawing.Size(25, 13);
            this.lblll.TabIndex = 6;
            this.lblll.Text = "200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lower Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Club Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Upper Deck:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtconfirmsearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(423, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guest Lookup";
            // 
            // txtconfirmsearch
            // 
            this.txtconfirmsearch.Location = new System.Drawing.Point(151, 24);
            this.txtconfirmsearch.Name = "txtconfirmsearch";
            this.txtconfirmsearch.Size = new System.Drawing.Size(100, 20);
            this.txtconfirmsearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(114, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Confirmation Number:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.email,
            this.TotalCost,
            this.ConfNumber,
            this.LowerlvlSeats,
            this.ClublvlSeats,
            this.UpperlvlSeats});
            this.dataGridView1.Location = new System.Drawing.Point(58, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 251);
            this.dataGridView1.TabIndex = 2;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.MaxInputLength = 377654;
            this.Customer.Name = "Customer";
            this.Customer.Width = 80;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            // 
            // ConfNumber
            // 
            this.ConfNumber.HeaderText = "Confirmation Number";
            this.ConfNumber.Name = "ConfNumber";
            // 
            // LowerlvlSeats
            // 
            this.LowerlvlSeats.HeaderText = "Lower Level Seats";
            this.LowerlvlSeats.Name = "LowerlvlSeats";
            this.LowerlvlSeats.Width = 80;
            // 
            // ClublvlSeats
            // 
            this.ClublvlSeats.HeaderText = "Club Level Seats";
            this.ClublvlSeats.Name = "ClublvlSeats";
            this.ClublvlSeats.Width = 80;
            // 
            // UpperlvlSeats
            // 
            this.UpperlvlSeats.HeaderText = "Upper Deck Seats";
            this.UpperlvlSeats.Name = "UpperlvlSeats";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblttlcost);
            this.Name = "Admin";
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblttlcost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblud;
        private System.Windows.Forms.Label lblcl;
        private System.Windows.Forms.Label lblll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtconfirmsearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowerlvlSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClublvlSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperlvlSeats;
    }
}