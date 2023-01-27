namespace personInfomation
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
            this.lblRegis = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.comMonth = new System.Windows.Forms.ComboBox();
            this.comDay = new System.Windows.Forms.ComboBox();
            this.comYear = new System.Windows.Forms.ComboBox();
            this.comGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddres = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblSteAdd = new System.Windows.Forms.Label();
            this.txtStreAdd = new System.Windows.Forms.TextBox();
            this.lblstreAdd2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblPostal = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblstudMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegis
            // 
            this.lblRegis.AutoSize = true;
            this.lblRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegis.Location = new System.Drawing.Point(12, 9);
            this.lblRegis.Name = "lblRegis";
            this.lblRegis.Size = new System.Drawing.Size(222, 29);
            this.lblRegis.TabIndex = 0;
            this.lblRegis.Text = "Registration Form";
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(17, 74);
            this.txtFirst.Multiline = true;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(194, 36);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.Text = "First Name";
            // 
            // txtMiddle
            // 
            this.txtMiddle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddle.Location = new System.Drawing.Point(287, 74);
            this.txtMiddle.Multiline = true;
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(194, 36);
            this.txtMiddle.TabIndex = 2;
            this.txtMiddle.Text = "Middle Name";
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(545, 74);
            this.txtLast.Multiline = true;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(194, 36);
            this.txtLast.TabIndex = 3;
            this.txtLast.Text = "Last Name";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(13, 125);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(100, 24);
            this.lblBirth.TabIndex = 5;
            this.lblBirth.Text = "Birth Date";
            // 
            // comMonth
            // 
            this.comMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comMonth.FormattingEnabled = true;
            this.comMonth.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "October",
            "November",
            "December"});
            this.comMonth.Location = new System.Drawing.Point(17, 152);
            this.comMonth.Name = "comMonth";
            this.comMonth.Size = new System.Drawing.Size(194, 24);
            this.comMonth.TabIndex = 6;
            this.comMonth.Text = "Month";
            // 
            // comDay
            // 
            this.comDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDay.FormattingEnabled = true;
            this.comDay.Items.AddRange(new object[] {
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
            "31"});
            this.comDay.Location = new System.Drawing.Point(217, 152);
            this.comDay.Name = "comDay";
            this.comDay.Size = new System.Drawing.Size(100, 24);
            this.comDay.TabIndex = 7;
            this.comDay.Text = "Day";
            // 
            // comYear
            // 
            this.comYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comYear.FormattingEnabled = true;
            this.comYear.Items.AddRange(new object[] {
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.comYear.Location = new System.Drawing.Point(323, 152);
            this.comYear.Name = "comYear";
            this.comYear.Size = new System.Drawing.Size(91, 24);
            this.comYear.TabIndex = 8;
            this.comYear.Text = "Year";
            // 
            // comGender
            // 
            this.comGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGender.FormattingEnabled = true;
            this.comGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comGender.Location = new System.Drawing.Point(545, 152);
            this.comGender.Name = "comGender";
            this.comGender.Size = new System.Drawing.Size(194, 24);
            this.comGender.TabIndex = 9;
            this.comGender.Text = "Chose Gender";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(541, 125);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 24);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddres.Location = new System.Drawing.Point(13, 191);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(87, 24);
            this.lblAddres.TabIndex = 11;
            this.lblAddres.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(17, 219);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(722, 40);
            this.txtAddress.TabIndex = 12;
            // 
            // lblSteAdd
            // 
            this.lblSteAdd.AutoSize = true;
            this.lblSteAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteAdd.Location = new System.Drawing.Point(14, 272);
            this.lblSteAdd.Name = "lblSteAdd";
            this.lblSteAdd.Size = new System.Drawing.Size(96, 16);
            this.lblSteAdd.TabIndex = 13;
            this.lblSteAdd.Text = "Street Address";
            // 
            // txtStreAdd
            // 
            this.txtStreAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreAdd.Location = new System.Drawing.Point(17, 291);
            this.txtStreAdd.Multiline = true;
            this.txtStreAdd.Name = "txtStreAdd";
            this.txtStreAdd.Size = new System.Drawing.Size(722, 40);
            this.txtStreAdd.TabIndex = 14;
            // 
            // lblstreAdd2
            // 
            this.lblstreAdd2.AutoSize = true;
            this.lblstreAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstreAdd2.Location = new System.Drawing.Point(17, 343);
            this.lblstreAdd2.Name = "lblstreAdd2";
            this.lblstreAdd2.Size = new System.Drawing.Size(134, 16);
            this.lblstreAdd2.TabIndex = 15;
            this.lblstreAdd2.Text = "Street Address Line 2";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Haripur",
            "Abbottabad",
            "Mansehra ",
            "Nowshera",
            "DI Khan",
            "Battagram"});
            this.comboBox1.Location = new System.Drawing.Point(17, 362);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "City";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "KPK",
            "Punjab",
            "Balochistan",
            "Sindh",
            "Gilgit Baltistan"});
            this.comboBox2.Location = new System.Drawing.Point(258, 362);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(211, 28);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Provicne";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostal.Location = new System.Drawing.Point(542, 343);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(104, 16);
            this.lblPostal.TabIndex = 18;
            this.lblPostal.Text = "Postal/Zip Code";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(545, 362);
            this.txtPostalCode.Multiline = true;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(194, 28);
            this.txtPostalCode.TabIndex = 19;
            // 
            // lblstudMail
            // 
            this.lblstudMail.AutoSize = true;
            this.lblstudMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudMail.Location = new System.Drawing.Point(16, 404);
            this.lblstudMail.Name = "lblstudMail";
            this.lblstudMail.Size = new System.Drawing.Size(139, 24);
            this.lblstudMail.TabIndex = 20;
            this.lblstudMail.Text = "Student Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.lblstudMail);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblstreAdd2);
            this.Controls.Add(this.txtStreAdd);
            this.Controls.Add(this.lblSteAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddres);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comGender);
            this.Controls.Add(this.comYear);
            this.Controls.Add(this.comDay);
            this.Controls.Add(this.comMonth);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtMiddle);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblRegis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegis;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.ComboBox comMonth;
        private System.Windows.Forms.ComboBox comDay;
        private System.Windows.Forms.ComboBox comYear;
        private System.Windows.Forms.ComboBox comGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddres;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblSteAdd;
        private System.Windows.Forms.TextBox txtStreAdd;
        private System.Windows.Forms.Label lblstreAdd2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblstudMail;
    }
}

