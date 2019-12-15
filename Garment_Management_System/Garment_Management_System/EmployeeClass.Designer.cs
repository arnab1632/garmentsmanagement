namespace Garment_Management_System
{
    partial class EmployeeClass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allemployee_button = new System.Windows.Forms.Button();
            this.employeedetails_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullname_textBox = new System.Windows.Forms.TextBox();
            this.position_textBox = new System.Windows.Forms.TextBox();
            this.dob_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addemployee_button = new System.Windows.Forms.Button();
            this.deleteemployee_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.updateemployee_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_pictureBox = new System.Windows.Forms.PictureBox();
            this.salary_label = new System.Windows.Forms.Label();
            this.salary_textbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.close_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1487, 49);
            this.panel1.TabIndex = 0;
            // 
            // close_label
            // 
            this.close_label.AutoSize = true;
            this.close_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_label.ForeColor = System.Drawing.Color.White;
            this.close_label.Location = new System.Drawing.Point(1444, 11);
            this.close_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close_label.Name = "close_label";
            this.close_label.Size = new System.Drawing.Size(28, 26);
            this.close_label.TabIndex = 5;
            this.close_label.Text = "X";
            this.close_label.Click += new System.EventHandler(this.close_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(578, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orbid Apparels Ltd.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 356);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 313);
            this.dataGridView1.TabIndex = 1;
            // 
            // allemployee_button
            // 
            this.allemployee_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.allemployee_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allemployee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allemployee_button.ForeColor = System.Drawing.Color.White;
            this.allemployee_button.Location = new System.Drawing.Point(16, 278);
            this.allemployee_button.Margin = new System.Windows.Forms.Padding(4);
            this.allemployee_button.Name = "allemployee_button";
            this.allemployee_button.Size = new System.Drawing.Size(223, 69);
            this.allemployee_button.TabIndex = 2;
            this.allemployee_button.Text = "All Employees";
            this.allemployee_button.UseVisualStyleBackColor = false;
            this.allemployee_button.Click += new System.EventHandler(this.allemployee_button_Click);
            // 
            // employeedetails_comboBox
            // 
            this.employeedetails_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.employeedetails_comboBox.ForeColor = System.Drawing.Color.White;
            this.employeedetails_comboBox.FormattingEnabled = true;
            this.employeedetails_comboBox.Location = new System.Drawing.Point(270, 188);
            this.employeedetails_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.employeedetails_comboBox.Name = "employeedetails_comboBox";
            this.employeedetails_comboBox.Size = new System.Drawing.Size(240, 24);
            this.employeedetails_comboBox.TabIndex = 3;
            this.employeedetails_comboBox.SelectedIndexChanged += new System.EventHandler(this.employeedetails_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(263, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee Details";
            // 
            // fullname_textBox
            // 
            this.fullname_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.fullname_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname_textBox.ForeColor = System.Drawing.Color.White;
            this.fullname_textBox.Location = new System.Drawing.Point(806, 142);
            this.fullname_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.fullname_textBox.Multiline = true;
            this.fullname_textBox.Name = "fullname_textBox";
            this.fullname_textBox.Size = new System.Drawing.Size(384, 54);
            this.fullname_textBox.TabIndex = 8;
            this.fullname_textBox.Text = " ";
            this.fullname_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // position_textBox
            // 
            this.position_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.position_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_textBox.ForeColor = System.Drawing.Color.White;
            this.position_textBox.Location = new System.Drawing.Point(806, 244);
            this.position_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.position_textBox.Multiline = true;
            this.position_textBox.Name = "position_textBox";
            this.position_textBox.Size = new System.Drawing.Size(384, 54);
            this.position_textBox.TabIndex = 9;
            this.position_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dob_textBox
            // 
            this.dob_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.dob_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_textBox.ForeColor = System.Drawing.Color.White;
            this.dob_textBox.Location = new System.Drawing.Point(806, 348);
            this.dob_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.dob_textBox.Multiline = true;
            this.dob_textBox.Name = "dob_textBox";
            this.dob_textBox.Size = new System.Drawing.Size(384, 54);
            this.dob_textBox.TabIndex = 10;
            this.dob_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email_textBox
            // 
            this.email_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.email_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textBox.ForeColor = System.Drawing.Color.White;
            this.email_textBox.Location = new System.Drawing.Point(806, 454);
            this.email_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.email_textBox.Multiline = true;
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(384, 54);
            this.email_textBox.TabIndex = 11;
            this.email_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address_textBox
            // 
            this.address_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.address_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_textBox.ForeColor = System.Drawing.Color.White;
            this.address_textBox.Location = new System.Drawing.Point(806, 532);
            this.address_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.address_textBox.Multiline = true;
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(384, 54);
            this.address_textBox.TabIndex = 12;
            this.address_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(570, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Full Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(607, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(536, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 39);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date Of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(632, 469);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 39);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(607, 537);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 39);
            this.label9.TabIndex = 17;
            this.label9.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1304, 368);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 42);
            this.label11.TabIndex = 19;
            this.label11.Text = "Image";
            // 
            // addemployee_button
            // 
            this.addemployee_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.addemployee_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemployee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_button.ForeColor = System.Drawing.Color.White;
            this.addemployee_button.Location = new System.Drawing.Point(16, 708);
            this.addemployee_button.Margin = new System.Windows.Forms.Padding(4);
            this.addemployee_button.Name = "addemployee_button";
            this.addemployee_button.Size = new System.Drawing.Size(223, 63);
            this.addemployee_button.TabIndex = 20;
            this.addemployee_button.Text = "Add Employee";
            this.addemployee_button.UseVisualStyleBackColor = false;
            this.addemployee_button.Click += new System.EventHandler(this.addemployee_button_Click);
            // 
            // deleteemployee_button
            // 
            this.deleteemployee_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.deleteemployee_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteemployee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteemployee_button.ForeColor = System.Drawing.Color.White;
            this.deleteemployee_button.Location = new System.Drawing.Point(253, 708);
            this.deleteemployee_button.Margin = new System.Windows.Forms.Padding(4);
            this.deleteemployee_button.Name = "deleteemployee_button";
            this.deleteemployee_button.Size = new System.Drawing.Size(257, 63);
            this.deleteemployee_button.TabIndex = 21;
            this.deleteemployee_button.Text = "Delete Employee";
            this.deleteemployee_button.UseVisualStyleBackColor = false;
            this.deleteemployee_button.Click += new System.EventHandler(this.deleteemployee_button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(80, 81);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 42);
            this.label12.TabIndex = 22;
            this.label12.Text = "Home";
            // 
            // updateemployee_button
            // 
            this.updateemployee_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.updateemployee_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateemployee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateemployee_button.ForeColor = System.Drawing.Color.White;
            this.updateemployee_button.Location = new System.Drawing.Point(826, 708);
            this.updateemployee_button.Margin = new System.Windows.Forms.Padding(4);
            this.updateemployee_button.Name = "updateemployee_button";
            this.updateemployee_button.Size = new System.Drawing.Size(258, 63);
            this.updateemployee_button.TabIndex = 23;
            this.updateemployee_button.Text = "Update Employee";
            this.updateemployee_button.UseVisualStyleBackColor = false;
            this.updateemployee_button.Click += new System.EventHandler(this.updateemployee_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1261, 129);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // home_pictureBox
            // 
            this.home_pictureBox.Image = global::Garment_Management_System.Properties.Resources.arrow2;
            this.home_pictureBox.Location = new System.Drawing.Point(12, 80);
            this.home_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.home_pictureBox.Name = "home_pictureBox";
            this.home_pictureBox.Size = new System.Drawing.Size(60, 42);
            this.home_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_pictureBox.TabIndex = 30;
            this.home_pictureBox.TabStop = false;
            this.home_pictureBox.Click += new System.EventHandler(this.home_pictureBox_Click);
            // 
            // salary_label
            // 
            this.salary_label.AutoSize = true;
            this.salary_label.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_label.ForeColor = System.Drawing.Color.White;
            this.salary_label.Location = new System.Drawing.Point(607, 620);
            this.salary_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(103, 39);
            this.salary_label.TabIndex = 32;
            this.salary_label.Text = "Salary";
            // 
            // salary_textbox
            // 
            this.salary_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.salary_textbox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_textbox.ForeColor = System.Drawing.Color.White;
            this.salary_textbox.Location = new System.Drawing.Point(806, 615);
            this.salary_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.salary_textbox.Multiline = true;
            this.salary_textbox.Name = "salary_textbox";
            this.salary_textbox.Size = new System.Drawing.Size(384, 54);
            this.salary_textbox.TabIndex = 31;
            this.salary_textbox.Text = " ";
            this.salary_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmployeeClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1487, 794);
            this.Controls.Add(this.salary_label);
            this.Controls.Add(this.salary_textbox);
            this.Controls.Add(this.home_pictureBox);
            this.Controls.Add(this.updateemployee_button);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.deleteemployee_button);
            this.Controls.Add(this.addemployee_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.dob_textBox);
            this.Controls.Add(this.position_textBox);
            this.Controls.Add(this.fullname_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeedetails_comboBox);
            this.Controls.Add(this.allemployee_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.EmployeeClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button allemployee_button;
        private System.Windows.Forms.ComboBox employeedetails_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox fullname_textBox;
        private System.Windows.Forms.TextBox position_textBox;
        private System.Windows.Forms.TextBox dob_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addemployee_button;
        private System.Windows.Forms.Button deleteemployee_button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button updateemployee_button;
        private System.Windows.Forms.PictureBox home_pictureBox;
        private System.Windows.Forms.Label salary_label;
        private System.Windows.Forms.TextBox salary_textbox;
    }
}