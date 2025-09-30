namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            listuni = new ListBox();
            uni = new Label();
            checkjava = new CheckBox();
            checkpython = new CheckBox();
            checkc = new CheckBox();
            label1 = new Label();
            check = new Button();
            checkrus = new CheckBox();
            checkeng = new CheckBox();
            checkturk = new CheckBox();
            label4 = new Label();
            country = new Label();
            comboCountry = new ComboBox();
            listcity = new ListBox();
            city = new Label();
            gender = new Label();
            other = new RadioButton();
            female = new RadioButton();
            male = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(listuni);
            groupBox1.Controls.Add(uni);
            groupBox1.Controls.Add(checkjava);
            groupBox1.Controls.Add(checkpython);
            groupBox1.Controls.Add(checkc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(check);
            groupBox1.Controls.Add(checkrus);
            groupBox1.Controls.Add(checkeng);
            groupBox1.Controls.Add(checkturk);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(country);
            groupBox1.Controls.Add(comboCountry);
            groupBox1.Controls.Add(listcity);
            groupBox1.Controls.Add(city);
            groupBox1.Controls.Add(gender);
            groupBox1.Controls.Add(other);
            groupBox1.Controls.Add(female);
            groupBox1.Controls.Add(male);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(47, 23);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(824, 451);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listuni
            // 
            listuni.FormattingEnabled = true;
            listuni.ItemHeight = 25;
            listuni.Items.AddRange(new object[] { "BMU ", "ADU", "AZMIU", "ADNSU", "UNEC" });
            listuni.Location = new Point(53, 299);
            listuni.Margin = new Padding(3, 4, 3, 4);
            listuni.Name = "listuni";
            listuni.Size = new Size(158, 79);
            listuni.TabIndex = 18;
            // 
            // uni
            // 
            uni.AutoSize = true;
            uni.BackColor = Color.FromArgb(255, 255, 192);
            uni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            uni.Location = new Point(53, 255);
            uni.Name = "uni";
            uni.Size = new Size(107, 25);
            uni.TabIndex = 17;
            uni.Text = "University";
            // 
            // checkjava
            // 
            checkjava.AutoSize = true;
            checkjava.BackColor = Color.Silver;
            checkjava.Location = new Point(651, 321);
            checkjava.Margin = new Padding(3, 4, 3, 4);
            checkjava.Name = "checkjava";
            checkjava.Size = new Size(74, 29);
            checkjava.TabIndex = 16;
            checkjava.Text = "java";
            checkjava.UseVisualStyleBackColor = false;
            // 
            // checkpython
            // 
            checkpython.AutoSize = true;
            checkpython.BackColor = Color.Silver;
            checkpython.Location = new Point(554, 321);
            checkpython.Margin = new Padding(3, 4, 3, 4);
            checkpython.Name = "checkpython";
            checkpython.Size = new Size(99, 29);
            checkpython.TabIndex = 15;
            checkpython.Text = "python";
            checkpython.UseVisualStyleBackColor = false;
            // 
            // checkc
            // 
            checkc.AutoSize = true;
            checkc.BackColor = Color.Silver;
            checkc.Location = new Point(499, 321);
            checkc.Margin = new Padding(3, 4, 3, 4);
            checkc.Name = "checkc";
            checkc.Size = new Size(57, 29);
            checkc.TabIndex = 14;
            checkc.Text = "c#";
            checkc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(485, 255);
            label1.Name = "label1";
            label1.Size = new Size(252, 25);
            label1.TabIndex = 13;
            label1.Text = "Programming Languages";
            // 
            // check
            // 
            check.BackColor = Color.FromArgb(255, 255, 128);
            check.Cursor = Cursors.Hand;
            check.Location = new Point(685, 404);
            check.Margin = new Padding(3, 4, 3, 4);
            check.Name = "check";
            check.Size = new Size(122, 39);
            check.TabIndex = 12;
            check.Text = "yoxladaa";
            check.UseVisualStyleBackColor = false;
            check.Click += button1_Click;
            // 
            // checkrus
            // 
            checkrus.AutoSize = true;
            checkrus.BackColor = Color.Silver;
            checkrus.Location = new Point(651, 138);
            checkrus.Margin = new Padding(3, 4, 3, 4);
            checkrus.Name = "checkrus";
            checkrus.Size = new Size(111, 29);
            checkrus.TabIndex = 11;
            checkrus.Text = "Russian";
            checkrus.UseVisualStyleBackColor = false;
            // 
            // checkeng
            // 
            checkeng.AutoSize = true;
            checkeng.BackColor = Color.Silver;
            checkeng.Location = new Point(554, 138);
            checkeng.Margin = new Padding(3, 4, 3, 4);
            checkeng.Name = "checkeng";
            checkeng.Size = new Size(105, 29);
            checkeng.TabIndex = 10;
            checkeng.Text = "English";
            checkeng.UseVisualStyleBackColor = false;
            // 
            // checkturk
            // 
            checkturk.AutoSize = true;
            checkturk.BackColor = Color.Silver;
            checkturk.Location = new Point(450, 138);
            checkturk.Margin = new Padding(3, 4, 3, 4);
            checkturk.Name = "checkturk";
            checkturk.Size = new Size(106, 29);
            checkturk.TabIndex = 9;
            checkturk.Text = "Turkish";
            checkturk.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(554, 73);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 8;
            label4.Text = "Languages";
            // 
            // country
            // 
            country.AutoSize = true;
            country.BackColor = Color.FromArgb(255, 255, 192);
            country.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            country.Location = new Point(259, 255);
            country.Name = "country";
            country.Size = new Size(88, 25);
            country.TabIndex = 7;
            country.Text = "Country";
            country.Click += label3_Click_1;
            // 
            // comboCountry
            // 
            comboCountry.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCountry.FormattingEnabled = true;
            comboCountry.Items.AddRange(new object[] { "Russia", "Azerbaijan", "Turkey", "Georgia" });
            comboCountry.Location = new Point(259, 317);
            comboCountry.Margin = new Padding(3, 4, 3, 4);
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(179, 33);
            comboCountry.TabIndex = 6;
            comboCountry.Text = "select your country";
            // 
            // listcity
            // 
            listcity.FormattingEnabled = true;
            listcity.ItemHeight = 25;
            listcity.Items.AddRange(new object[] { "Balaken", "Sheki", "Baku" });
            listcity.Location = new Point(259, 120);
            listcity.Margin = new Padding(3, 4, 3, 4);
            listcity.Name = "listcity";
            listcity.Size = new Size(158, 79);
            listcity.TabIndex = 5;
            listcity.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // city
            // 
            city.AutoSize = true;
            city.BackColor = Color.FromArgb(255, 255, 192);
            city.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            city.Location = new Point(259, 73);
            city.Name = "city";
            city.Size = new Size(50, 25);
            city.TabIndex = 4;
            city.Text = "City";
            city.Click += label2_Click;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.BackColor = Color.FromArgb(255, 255, 192);
            gender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            gender.Location = new Point(53, 73);
            gender.Name = "gender";
            gender.Size = new Size(83, 25);
            gender.TabIndex = 3;
            gender.Text = "Gender";
            gender.Click += label1_Click;
            // 
            // other
            // 
            other.AutoSize = true;
            other.BackColor = Color.Silver;
            other.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            other.Location = new Point(53, 194);
            other.Margin = new Padding(3, 4, 3, 4);
            other.Name = "other";
            other.Size = new Size(105, 29);
            other.TabIndex = 2;
            other.TabStop = true;
            other.Text = "Other...";
            other.UseVisualStyleBackColor = false;
            other.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // female
            // 
            female.AutoSize = true;
            female.BackColor = Color.Silver;
            female.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            female.Location = new Point(53, 157);
            female.Margin = new Padding(3, 4, 3, 4);
            female.Name = "female";
            female.Size = new Size(104, 29);
            female.TabIndex = 1;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = false;
            // 
            // male
            // 
            male.AutoSize = true;
            male.BackColor = Color.Silver;
            male.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            male.Location = new Point(53, 120);
            male.Margin = new Padding(3, 4, 3, 4);
            male.Name = "male";
            male.Size = new Size(80, 29);
            male.TabIndex = 0;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = false;
            male.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton other;
        private RadioButton female;
        private RadioButton male;
        private Label gender;
        private ListBox listcity;
        private Label city;
        private ComboBox comboCountry;
        private Label country;
        private CheckBox checkturk;
        private Label label4;
        private CheckBox checkrus;
        private CheckBox checkeng;
        private Button check;
        private ListBox listuni;
        private Label uni;
        private CheckBox checkjava;
        private CheckBox checkpython;
        private CheckBox checkc;
        private Label label1;
    }
}
