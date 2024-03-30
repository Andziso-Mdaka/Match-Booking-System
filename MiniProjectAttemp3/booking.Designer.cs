namespace MiniProjectAttemp3
{
    partial class booking
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
            this.label13 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSuite = new System.Windows.Forms.RadioButton();
            this.radBehindStumps = new System.Windows.Forms.RadioButton();
            this.radGeneralOpen = new System.Windows.Forms.RadioButton();
            this.radBestInStands = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalcost = new System.Windows.Forms.Label();
            this.lblNameOfMatch = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNoOftickets = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkFullHospitality = new System.Windows.Forms.CheckBox();
            this.chkParking = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmboMatch = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownNumOfPeople = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 16);
            this.label13.TabIndex = 48;
            this.label13.Text = "STARS 2024";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(973, 407);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(25, 16);
            this.lblDate.TabIndex = 47;
            this.lblDate.Text = "xxx";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSuite);
            this.groupBox1.Controls.Add(this.radBehindStumps);
            this.groupBox1.Controls.Add(this.radGeneralOpen);
            this.groupBox1.Controls.Add(this.radBestInStands);
            this.groupBox1.Location = new System.Drawing.Point(847, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 153);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seating";
            // 
            // radSuite
            // 
            this.radSuite.AutoSize = true;
            this.radSuite.Location = new System.Drawing.Point(16, 119);
            this.radSuite.Margin = new System.Windows.Forms.Padding(4);
            this.radSuite.Name = "radSuite";
            this.radSuite.Size = new System.Drawing.Size(58, 20);
            this.radSuite.TabIndex = 3;
            this.radSuite.TabStop = true;
            this.radSuite.Text = "Suite";
            this.radSuite.UseVisualStyleBackColor = true;
            // 
            // radBehindStumps
            // 
            this.radBehindStumps.AutoSize = true;
            this.radBehindStumps.Location = new System.Drawing.Point(15, 91);
            this.radBehindStumps.Margin = new System.Windows.Forms.Padding(4);
            this.radBehindStumps.Name = "radBehindStumps";
            this.radBehindStumps.Size = new System.Drawing.Size(162, 20);
            this.radBehindStumps.TabIndex = 2;
            this.radBehindStumps.TabStop = true;
            this.radBehindStumps.Text = "Behind stumps(lowest)";
            this.radBehindStumps.UseVisualStyleBackColor = true;
            // 
            // radGeneralOpen
            // 
            this.radGeneralOpen.AutoSize = true;
            this.radGeneralOpen.Location = new System.Drawing.Point(16, 63);
            this.radGeneralOpen.Margin = new System.Windows.Forms.Padding(4);
            this.radGeneralOpen.Name = "radGeneralOpen";
            this.radGeneralOpen.Size = new System.Drawing.Size(110, 20);
            this.radGeneralOpen.TabIndex = 1;
            this.radGeneralOpen.TabStop = true;
            this.radGeneralOpen.Text = "General open";
            this.radGeneralOpen.UseVisualStyleBackColor = true;
            // 
            // radBestInStands
            // 
            this.radBestInStands.AutoSize = true;
            this.radBestInStands.Location = new System.Drawing.Point(15, 35);
            this.radBestInStands.Margin = new System.Windows.Forms.Padding(4);
            this.radBestInStands.Name = "radBestInStands";
            this.radBestInStands.Size = new System.Drawing.Size(111, 20);
            this.radBestInStands.TabIndex = 0;
            this.radBestInStands.TabStop = true;
            this.radBestInStands.Text = "Best in stands";
            this.radBestInStands.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 522);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "The total cost will be";
            // 
            // lblTotalcost
            // 
            this.lblTotalcost.AutoSize = true;
            this.lblTotalcost.Location = new System.Drawing.Point(356, 522);
            this.lblTotalcost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalcost.Name = "lblTotalcost";
            this.lblTotalcost.Size = new System.Drawing.Size(31, 16);
            this.lblTotalcost.TabIndex = 44;
            this.lblTotalcost.Text = "0.00";
            // 
            // lblNameOfMatch
            // 
            this.lblNameOfMatch.AutoSize = true;
            this.lblNameOfMatch.Location = new System.Drawing.Point(640, 407);
            this.lblNameOfMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameOfMatch.Name = "lblNameOfMatch";
            this.lblNameOfMatch.Size = new System.Drawing.Size(31, 16);
            this.lblNameOfMatch.TabIndex = 43;
            this.lblNameOfMatch.Text = "XXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 407);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "ticket(s) for";
            // 
            // lblNoOftickets
            // 
            this.lblNoOftickets.AutoSize = true;
            this.lblNoOftickets.Location = new System.Drawing.Point(376, 407);
            this.lblNoOftickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOftickets.Name = "lblNoOftickets";
            this.lblNoOftickets.Size = new System.Drawing.Size(14, 16);
            this.lblNoOftickets.TabIndex = 40;
            this.lblNoOftickets.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 407);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "You have booked";
            // 
            // chkFullHospitality
            // 
            this.chkFullHospitality.AutoSize = true;
            this.chkFullHospitality.Location = new System.Drawing.Point(360, 345);
            this.chkFullHospitality.Margin = new System.Windows.Forms.Padding(4);
            this.chkFullHospitality.Name = "chkFullHospitality";
            this.chkFullHospitality.Size = new System.Drawing.Size(167, 20);
            this.chkFullHospitality.TabIndex = 38;
            this.chkFullHospitality.Text = "Full hospitality service?";
            this.chkFullHospitality.UseVisualStyleBackColor = true;
            // 
            // chkParking
            // 
            this.chkParking.AutoSize = true;
            this.chkParking.Location = new System.Drawing.Point(137, 345);
            this.chkParking.Margin = new System.Windows.Forms.Padding(4);
            this.chkParking.Name = "chkParking";
            this.chkParking.Size = new System.Drawing.Size(135, 20);
            this.chkParking.TabIndex = 37;
            this.chkParking.Text = "Parking required?";
            this.chkParking.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Number of People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Match";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 28);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.returnToolStripMenuItem.Text = "return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.processToolStripMenuItem.Text = "make a booking";
            this.processToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // cmboMatch
            // 
            this.cmboMatch.FormattingEnabled = true;
            this.cmboMatch.Location = new System.Drawing.Point(360, 122);
            this.cmboMatch.Margin = new System.Windows.Forms.Padding(4);
            this.cmboMatch.Name = "cmboMatch";
            this.cmboMatch.Size = new System.Drawing.Size(160, 24);
            this.cmboMatch.TabIndex = 50;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(360, 252);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDate.TabIndex = 51;
            // 
            // numericUpDownNumOfPeople
            // 
            this.numericUpDownNumOfPeople.Location = new System.Drawing.Point(361, 188);
            this.numericUpDownNumOfPeople.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownNumOfPeople.Name = "numericUpDownNumOfPeople";
            this.numericUpDownNumOfPeople.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownNumOfPeople.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(840, 407);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "X";
            // 
            // booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 647);
            this.Controls.Add(this.numericUpDownNumOfPeople);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.cmboMatch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotalcost);
            this.Controls.Add(this.lblNameOfMatch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNoOftickets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkFullHospitality);
            this.Controls.Add(this.chkParking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "booking";
            this.Text = "booking";
            this.Load += new System.EventHandler(this.booking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSuite;
        private System.Windows.Forms.RadioButton radBehindStumps;
        private System.Windows.Forms.RadioButton radGeneralOpen;
        private System.Windows.Forms.RadioButton radBestInStands;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalcost;
        private System.Windows.Forms.Label lblNameOfMatch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNoOftickets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkFullHospitality;
        private System.Windows.Forms.CheckBox chkParking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmboMatch;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfPeople;
        private System.Windows.Forms.Label label7;
    }
}