namespace Dingson_Oswell
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
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.middlename = new System.Windows.Forms.TextBox();
            this.MALE = new System.Windows.Forms.RadioButton();
            this.FEMALE = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Programs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(12, 100);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(294, 22);
            this.lastname.TabIndex = 0;
            this.lastname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(12, 157);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(294, 22);
            this.firstname.TabIndex = 1;
            // 
            // middlename
            // 
            this.middlename.Location = new System.Drawing.Point(12, 217);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(294, 22);
            this.middlename.TabIndex = 2;
            // 
            // MALE
            // 
            this.MALE.AutoSize = true;
            this.MALE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MALE.Location = new System.Drawing.Point(81, 252);
            this.MALE.Name = "MALE";
            this.MALE.Size = new System.Drawing.Size(61, 22);
            this.MALE.TabIndex = 3;
            this.MALE.TabStop = true;
            this.MALE.Text = "Male";
            this.MALE.UseVisualStyleBackColor = true;
            // 
            // FEMALE
            // 
            this.FEMALE.AutoSize = true;
            this.FEMALE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FEMALE.Location = new System.Drawing.Point(152, 254);
            this.FEMALE.Name = "FEMALE";
            this.FEMALE.Size = new System.Drawing.Size(78, 22);
            this.FEMALE.TabIndex = 4;
            this.FEMALE.TabStop = true;
            this.FEMALE.Text = "Female";
            this.FEMALE.UseVisualStyleBackColor = true;
            this.FEMALE.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "First name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Middle name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Program to apply";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(378, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 209);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Register student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Day
            // 
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "1",
            "",
            "2",
            "",
            "3",
            "",
            "4",
            "",
            "5",
            "",
            "6",
            "",
            "7",
            "",
            "8",
            "",
            "9",
            "",
            "10",
            "",
            "11",
            "",
            "12",
            "",
            "13",
            "",
            "14",
            "",
            "15",
            "",
            "16",
            "",
            "17",
            "18",
            "",
            "19",
            "",
            "20",
            "21",
            "",
            "22",
            "",
            "23",
            "",
            "24",
            "",
            "25",
            "",
            "26",
            "",
            "27",
            "",
            "28",
            "",
            "29",
            "",
            "30"});
            this.Day.Location = new System.Drawing.Point(12, 302);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(66, 24);
            this.Day.TabIndex = 15;
            this.Day.Text = "Day";
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "January",
            "",
            "February",
            "",
            "March",
            "",
            "April",
            "",
            "May",
            "",
            "June",
            "",
            "July",
            "",
            "August",
            "",
            "September",
            "",
            "October",
            "",
            "November",
            "",
            "December"});
            this.Month.Location = new System.Drawing.Point(84, 302);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(114, 24);
            this.Month.TabIndex = 16;
            this.Month.Text = "Month";
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "1990",
            "",
            "1991",
            "",
            "1992",
            "",
            "1993",
            "",
            "1994",
            "",
            "1995",
            "",
            "1996",
            "",
            "1997",
            "",
            "1998",
            "",
            "1999",
            "",
            "2000",
            "",
            "2001",
            "",
            "2002",
            "",
            "2003",
            "",
            "2004",
            "",
            "2005",
            "",
            "2006",
            "",
            "2007",
            "",
            "2008",
            "",
            "2009",
            "",
            "2010",
            "",
            "2011",
            "",
            "2012",
            "",
            "2013",
            "",
            "2014",
            "",
            "2015",
            "",
            "2016",
            "",
            "2017",
            "",
            "2018",
            "",
            "2019",
            "",
            "2020",
            "",
            "2021",
            "",
            "2022",
            "",
            "2023",
            "",
            "2024"});
            this.Year.Location = new System.Drawing.Point(204, 302);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(102, 24);
            this.Year.TabIndex = 17;
            this.Year.Text = "Year";
            // 
            // Programs
            // 
            this.Programs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programs.FormattingEnabled = true;
            this.Programs.Items.AddRange(new object[] {
            "BS in Computer Science (BSCS)",
            "",
            "BS in Information Technology (BSIT)",
            "",
            "BS in Hospitality Management (BSHM)",
            "",
            "BSin Tourism Management (BSTM)",
            "",
            "Bachelor of Multimedia Arts (BMMA)",
            "",
            "Bachelor of Arts in Communication (BACOMM)",
            "",
            "BS in Accountancy (BSA)",
            "",
            "BS in Business Administration (BSBA)"});
            this.Programs.Location = new System.Drawing.Point(12, 357);
            this.Programs.Name = "Programs";
            this.Programs.Size = new System.Drawing.Size(333, 24);
            this.Programs.TabIndex = 18;
            this.Programs.Text = "Choose Course";
            this.Programs.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 481);
            this.Controls.Add(this.Programs);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FEMALE);
            this.Controls.Add(this.MALE);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.lastname);
            this.Name = "Form1";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.RadioButton MALE;
        private System.Windows.Forms.RadioButton FEMALE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Programs;
        private System.Windows.Forms.ComboBox Year;
    }
}

