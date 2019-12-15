namespace Garment_Management_System
{
    partial class Add_Client
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
            this.loadimage_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.company_textbox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buyername_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.country_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contact_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.skype_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.close_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 63);
            this.panel1.TabIndex = 1;
            // 
            // close_label
            // 
            this.close_label.AutoSize = true;
            this.close_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_label.ForeColor = System.Drawing.Color.White;
            this.close_label.Location = new System.Drawing.Point(703, 11);
            this.close_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close_label.Name = "close_label";
            this.close_label.Size = new System.Drawing.Size(28, 26);
            this.close_label.TabIndex = 26;
            this.close_label.Text = "X";
            this.close_label.Click += new System.EventHandler(this.close_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Client";
            // 
            // loadimage_button
            // 
            this.loadimage_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadimage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadimage_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadimage_button.ForeColor = System.Drawing.Color.White;
            this.loadimage_button.Location = new System.Drawing.Point(287, 257);
            this.loadimage_button.Margin = new System.Windows.Forms.Padding(4);
            this.loadimage_button.Name = "loadimage_button";
            this.loadimage_button.Size = new System.Drawing.Size(199, 36);
            this.loadimage_button.TabIndex = 28;
            this.loadimage_button.Text = "Load Image";
            this.loadimage_button.UseVisualStyleBackColor = false;
            this.loadimage_button.Click += new System.EventHandler(this.loadimage_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "Company";
            // 
            // company_textbox
            // 
            this.company_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.company_textbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_textbox.ForeColor = System.Drawing.Color.Black;
            this.company_textbox.Location = new System.Drawing.Point(216, 367);
            this.company_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.company_textbox.Multiline = true;
            this.company_textbox.Name = "company_textbox";
            this.company_textbox.Size = new System.Drawing.Size(421, 31);
            this.company_textbox.TabIndex = 30;
            this.company_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(86, 811);
            this.add_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(237, 43);
            this.add_button.TabIndex = 31;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(395, 811);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(237, 43);
            this.cancel_button.TabIndex = 32;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 427);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buyer Name";
            // 
            // buyername_textbox
            // 
            this.buyername_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.buyername_textbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyername_textbox.ForeColor = System.Drawing.Color.Black;
            this.buyername_textbox.Location = new System.Drawing.Point(216, 425);
            this.buyername_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.buyername_textbox.Multiline = true;
            this.buyername_textbox.Name = "buyername_textbox";
            this.buyername_textbox.Size = new System.Drawing.Size(421, 31);
            this.buyername_textbox.TabIndex = 34;
            this.buyername_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 486);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "Country";
            // 
            // country_textBox
            // 
            this.country_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.country_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_textBox.ForeColor = System.Drawing.Color.Black;
            this.country_textBox.Location = new System.Drawing.Point(216, 484);
            this.country_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.country_textBox.Multiline = true;
            this.country_textBox.Name = "country_textBox";
            this.country_textBox.Size = new System.Drawing.Size(421, 31);
            this.country_textBox.TabIndex = 36;
            this.country_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 543);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 37;
            this.label4.Text = "Address";
            // 
            // address_textBox
            // 
            this.address_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.address_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_textBox.ForeColor = System.Drawing.Color.Black;
            this.address_textBox.Location = new System.Drawing.Point(216, 543);
            this.address_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.address_textBox.Multiline = true;
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(421, 31);
            this.address_textBox.TabIndex = 38;
            this.address_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 602);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 27);
            this.label6.TabIndex = 39;
            this.label6.Text = "Contact";
            // 
            // contact_textBox
            // 
            this.contact_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.contact_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_textBox.ForeColor = System.Drawing.Color.Black;
            this.contact_textBox.Location = new System.Drawing.Point(216, 599);
            this.contact_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.contact_textBox.Multiline = true;
            this.contact_textBox.Name = "contact_textBox";
            this.contact_textBox.Size = new System.Drawing.Size(421, 31);
            this.contact_textBox.TabIndex = 40;
            this.contact_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(32, 662);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 27);
            this.label7.TabIndex = 41;
            this.label7.Text = "Skype";
            // 
            // skype_textBox
            // 
            this.skype_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.skype_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skype_textBox.ForeColor = System.Drawing.Color.Black;
            this.skype_textBox.Location = new System.Drawing.Point(216, 662);
            this.skype_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.skype_textBox.Multiline = true;
            this.skype_textBox.Name = "skype_textBox";
            this.skype_textBox.Size = new System.Drawing.Size(421, 31);
            this.skype_textBox.TabIndex = 42;
            this.skype_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(32, 726);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 27);
            this.label8.TabIndex = 43;
            this.label8.Text = "Email";
            // 
            // email_textBox
            // 
            this.email_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.email_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textBox.ForeColor = System.Drawing.Color.Black;
            this.email_textBox.Location = new System.Drawing.Point(216, 720);
            this.email_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.email_textBox.Multiline = true;
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(421, 31);
            this.email_textBox.TabIndex = 44;
            this.email_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(37, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 881);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.skype_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contact_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.country_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buyername_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.company_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadimage_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadimage_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox company_textbox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buyername_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox country_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contact_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox skype_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email_textBox;
    }
}