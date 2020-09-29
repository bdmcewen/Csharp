namespace Project7_McEwen
{
    partial class Tickets
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
            this.lblSOUpperlvl = new System.Windows.Forms.Label();
            this.lblSOClublvl = new System.Windows.Forms.Label();
            this.lblSOLowerlvl = new System.Windows.Forms.Label();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.comboBoxUpperDeck = new System.Windows.Forms.ComboBox();
            this.comboBoxClublvl = new System.Windows.Forms.ComboBox();
            this.comboBoxLowerlvl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUpperlvl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClublvl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLowerlvl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSOUpperlvl);
            this.groupBox1.Controls.Add(this.lblSOClublvl);
            this.groupBox1.Controls.Add(this.lblSOLowerlvl);
            this.groupBox1.Controls.Add(this.BtnBuy);
            this.groupBox1.Controls.Add(this.comboBoxUpperDeck);
            this.groupBox1.Controls.Add(this.comboBoxClublvl);
            this.groupBox1.Controls.Add(this.comboBoxLowerlvl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblUpperlvl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblClublvl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblLowerlvl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets";
            // 
            // lblSOUpperlvl
            // 
            this.lblSOUpperlvl.AutoSize = true;
            this.lblSOUpperlvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSOUpperlvl.ForeColor = System.Drawing.Color.Crimson;
            this.lblSOUpperlvl.Location = new System.Drawing.Point(151, 212);
            this.lblSOUpperlvl.Name = "lblSOUpperlvl";
            this.lblSOUpperlvl.Size = new System.Drawing.Size(136, 31);
            this.lblSOUpperlvl.TabIndex = 13;
            this.lblSOUpperlvl.Text = "Sold Out!";
            // 
            // lblSOClublvl
            // 
            this.lblSOClublvl.AutoSize = true;
            this.lblSOClublvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSOClublvl.ForeColor = System.Drawing.Color.Crimson;
            this.lblSOClublvl.Location = new System.Drawing.Point(151, 157);
            this.lblSOClublvl.Name = "lblSOClublvl";
            this.lblSOClublvl.Size = new System.Drawing.Size(136, 31);
            this.lblSOClublvl.TabIndex = 12;
            this.lblSOClublvl.Text = "Sold Out!";
            // 
            // lblSOLowerlvl
            // 
            this.lblSOLowerlvl.AutoSize = true;
            this.lblSOLowerlvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSOLowerlvl.ForeColor = System.Drawing.Color.Crimson;
            this.lblSOLowerlvl.Location = new System.Drawing.Point(151, 97);
            this.lblSOLowerlvl.Name = "lblSOLowerlvl";
            this.lblSOLowerlvl.Size = new System.Drawing.Size(136, 31);
            this.lblSOLowerlvl.TabIndex = 11;
            this.lblSOLowerlvl.Text = "Sold Out!";
            // 
            // BtnBuy
            // 
            this.BtnBuy.AutoSize = true;
            this.BtnBuy.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBuy.Location = new System.Drawing.Point(291, 305);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(75, 41);
            this.BtnBuy.TabIndex = 10;
            this.BtnBuy.Text = "Buy";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // comboBoxUpperDeck
            // 
            this.comboBoxUpperDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUpperDeck.FormattingEnabled = true;
            this.comboBoxUpperDeck.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200"});
            this.comboBoxUpperDeck.Location = new System.Drawing.Point(429, 199);
            this.comboBoxUpperDeck.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUpperDeck.MaxDropDownItems = 10;
            this.comboBoxUpperDeck.Name = "comboBoxUpperDeck";
            this.comboBoxUpperDeck.Size = new System.Drawing.Size(121, 39);
            this.comboBoxUpperDeck.TabIndex = 9;
            this.comboBoxUpperDeck.Text = "0";
            // 
            // comboBoxClublvl
            // 
            this.comboBoxClublvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClublvl.FormattingEnabled = true;
            this.comboBoxClublvl.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75"});
            this.comboBoxClublvl.Location = new System.Drawing.Point(429, 149);
            this.comboBoxClublvl.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClublvl.MaxDropDownItems = 10;
            this.comboBoxClublvl.Name = "comboBoxClublvl";
            this.comboBoxClublvl.Size = new System.Drawing.Size(121, 39);
            this.comboBoxClublvl.TabIndex = 8;
            this.comboBoxClublvl.Text = "0";
            // 
            // comboBoxLowerlvl
            // 
            this.comboBoxLowerlvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLowerlvl.FormattingEnabled = true;
            this.comboBoxLowerlvl.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200"});
            this.comboBoxLowerlvl.Location = new System.Drawing.Point(429, 97);
            this.comboBoxLowerlvl.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLowerlvl.MaxDropDownItems = 10;
            this.comboBoxLowerlvl.Name = "comboBoxLowerlvl";
            this.comboBoxLowerlvl.Size = new System.Drawing.Size(121, 39);
            this.comboBoxLowerlvl.TabIndex = 7;
            this.comboBoxLowerlvl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "$50.00";
            // 
            // lblUpperlvl
            // 
            this.lblUpperlvl.AutoSize = true;
            this.lblUpperlvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperlvl.Location = new System.Drawing.Point(75, 207);
            this.lblUpperlvl.Margin = new System.Windows.Forms.Padding(4);
            this.lblUpperlvl.Name = "lblUpperlvl";
            this.lblUpperlvl.Size = new System.Drawing.Size(177, 31);
            this.lblUpperlvl.TabIndex = 5;
            this.lblUpperlvl.Text = "Upper Deck:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "$75.00";
            // 
            // lblClublvl
            // 
            this.lblClublvl.AutoSize = true;
            this.lblClublvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClublvl.Location = new System.Drawing.Point(75, 152);
            this.lblClublvl.Margin = new System.Windows.Forms.Padding(4);
            this.lblClublvl.Name = "lblClublvl";
            this.lblClublvl.Size = new System.Drawing.Size(161, 31);
            this.lblClublvl.TabIndex = 3;
            this.lblClublvl.Text = "Club Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "$125.00";
            // 
            // lblLowerlvl
            // 
            this.lblLowerlvl.AutoSize = true;
            this.lblLowerlvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerlvl.Location = new System.Drawing.Point(75, 100);
            this.lblLowerlvl.Margin = new System.Windows.Forms.Padding(4);
            this.lblLowerlvl.Name = "lblLowerlvl";
            this.lblLowerlvl.Size = new System.Drawing.Size(180, 31);
            this.lblLowerlvl.TabIndex = 1;
            this.lblLowerlvl.Text = "Lower Level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity:";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUpperlvl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClublvl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLowerlvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUpperDeck;
        private System.Windows.Forms.ComboBox comboBoxClublvl;
        private System.Windows.Forms.ComboBox comboBoxLowerlvl;
        private System.Windows.Forms.Label lblSOUpperlvl;
        private System.Windows.Forms.Label lblSOClublvl;
        private System.Windows.Forms.Label lblSOLowerlvl;
        private System.Windows.Forms.Button BtnBuy;
    }
}