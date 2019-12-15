namespace Garment_Management_System
{
    partial class Sign_Up
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
            this.loadimage_button = new System.Windows.Forms.Button();
            this.signup_button = new System.Windows.Forms.Button();
            this.mobileno_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.lastname_textBox = new System.Windows.Forms.TextBox();
            this.firstname_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.login_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // loadimage_button
            // 
            this.loadimage_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loadimage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadimage_button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadimage_button.Location = new System.Drawing.Point(291, 238);
            this.loadimage_button.Margin = new System.Windows.Forms.Padding(4);
            this.loadimage_button.Name = "loadimage_button";
            this.loadimage_button.Size = new System.Drawing.Size(163, 38);
            this.loadimage_button.TabIndex = 29;
            this.loadimage_button.Text = "Load Image";
            this.loadimage_button.UseVisualStyleBackColor = false;
            this.loadimage_button.Click += new System.EventHandler(this.loadimage_button_Click);
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(79, 710);
            this.signup_button.Margin = new System.Windows.Forms.Padding(4);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(384, 53);
            this.signup_button.TabIndex = 26;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // mobileno_textBox
            // 
            this.mobileno_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.mobileno_textBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileno_textBox.ForeColor = System.Drawing.Color.Silver;
            this.mobileno_textBox.Location = new System.Drawing.Point(79, 549);
            this.mobileno_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.mobileno_textBox.Multiline = true;
            this.mobileno_textBox.Name = "mobileno_textBox";
            this.mobileno_textBox.Size = new System.Drawing.Size(372, 40);
            this.mobileno_textBox.TabIndex = 23;
            this.mobileno_textBox.Text = "Mobile No";
            this.mobileno_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileno_textBox.Enter += new System.EventHandler(this.mobileno_textBox_Enter);
            this.mobileno_textBox.Leave += new System.EventHandler(this.mobileno_textBox_Leave);
            // 
            // email_textBox
            // 
            this.email_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.email_textBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textBox.ForeColor = System.Drawing.Color.Silver;
            this.email_textBox.Location = new System.Drawing.Point(79, 482);
            this.email_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.email_textBox.Multiline = true;
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(375, 42);
            this.email_textBox.TabIndex = 22;
            this.email_textBox.Text = "Someone@example.com";
            this.email_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email_textBox.Enter += new System.EventHandler(this.email_textBox_Enter);
            this.email_textBox.Leave += new System.EventHandler(this.email_textBox_Leave);
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.password_textBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.ForeColor = System.Drawing.Color.Silver;
            this.password_textBox.Location = new System.Drawing.Point(79, 419);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(375, 38);
            this.password_textBox.TabIndex = 21;
            this.password_textBox.Text = "Password";
            this.password_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            this.password_textBox.Enter += new System.EventHandler(this.password_textBox_Enter);
            this.password_textBox.Leave += new System.EventHandler(this.password_textBox_Leave);
            // 
            // lastname_textBox
            // 
            this.lastname_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.lastname_textBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_textBox.ForeColor = System.Drawing.Color.Silver;
            this.lastname_textBox.Location = new System.Drawing.Point(267, 294);
            this.lastname_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastname_textBox.Multiline = true;
            this.lastname_textBox.Name = "lastname_textBox";
            this.lastname_textBox.Size = new System.Drawing.Size(189, 41);
            this.lastname_textBox.TabIndex = 20;
            this.lastname_textBox.Text = "Last Name";
            this.lastname_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastname_textBox.Enter += new System.EventHandler(this.lastname_textBox_Enter);
            this.lastname_textBox.Leave += new System.EventHandler(this.lastname_textBox_Leave);
            // 
            // firstname_textBox
            // 
            this.firstname_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.firstname_textBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_textBox.ForeColor = System.Drawing.Color.Silver;
            this.firstname_textBox.Location = new System.Drawing.Point(79, 294);
            this.firstname_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstname_textBox.Multiline = true;
            this.firstname_textBox.Name = "firstname_textBox";
            this.firstname_textBox.Size = new System.Drawing.Size(168, 41);
            this.firstname_textBox.TabIndex = 19;
            this.firstname_textBox.Text = "First Name";
            this.firstname_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstname_textBox.Enter += new System.EventHandler(this.firstname_textBox_Enter);
            this.firstname_textBox.Leave += new System.EventHandler(this.firstname_textBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(286, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Garment_Management_System.Properties.Resources.login_orbid_logo2;
            this.pictureBox4.Location = new System.Drawing.Point(18, 17);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(199, 103);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.White;
            this.login_label.Location = new System.Drawing.Point(234, 780);
            this.login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(84, 34);
            this.login_label.TabIndex = 31;
            this.login_label.Text = "Login";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "admin",
            "chairman"});
            this.comboBox1.Location = new System.Drawing.Point(79, 610);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 37);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Text = "                       Position";
            // 
            // username_textBox
            // 
            this.username_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.username_textBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textBox.ForeColor = System.Drawing.Color.Silver;
            this.username_textBox.Location = new System.Drawing.Point(79, 358);
            this.username_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.username_textBox.Multiline = true;
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(375, 38);
            this.username_textBox.TabIndex = 33;
            this.username_textBox.Text = "User Name";
            this.username_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username_textBox.Enter += new System.EventHandler(this.username_textBox_Enter);
            this.username_textBox.Leave += new System.EventHandler(this.username_textBox_Leave);
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(539, 841);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.loadimage_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.mobileno_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.lastname_textBox);
            this.Controls.Add(this.firstname_textBox);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadimage_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.TextBox mobileno_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox lastname_textBox;
        private System.Windows.Forms.TextBox firstname_textBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox username_textBox;
    }
}