namespace Garment_Management_System
{
    partial class Add_Inventory
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productname_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unitprice_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stockamount_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalstockcost_textBox = new System.Windows.Forms.TextBox();
            this.totalstockcostgenerate_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.amountneed_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.costrequired_textBox = new System.Windows.Forms.TextBox();
            this.costrequiredgenerate_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Products";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Garment_Management_System.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 449);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product Name";
            // 
            // productname_textBox
            // 
            this.productname_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.productname_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname_textBox.ForeColor = System.Drawing.Color.Black;
            this.productname_textBox.Location = new System.Drawing.Point(231, 447);
            this.productname_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.productname_textBox.Multiline = true;
            this.productname_textBox.Name = "productname_textBox";
            this.productname_textBox.Size = new System.Drawing.Size(421, 31);
            this.productname_textBox.TabIndex = 10;
            this.productname_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 508);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Unit Price";
            // 
            // unitprice_textBox
            // 
            this.unitprice_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.unitprice_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitprice_textBox.ForeColor = System.Drawing.Color.Black;
            this.unitprice_textBox.Location = new System.Drawing.Point(231, 506);
            this.unitprice_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitprice_textBox.Multiline = true;
            this.unitprice_textBox.Name = "unitprice_textBox";
            this.unitprice_textBox.Size = new System.Drawing.Size(421, 31);
            this.unitprice_textBox.TabIndex = 12;
            this.unitprice_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 565);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stock Amount";
            // 
            // stockamount_textBox
            // 
            this.stockamount_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.stockamount_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockamount_textBox.ForeColor = System.Drawing.Color.Black;
            this.stockamount_textBox.Location = new System.Drawing.Point(231, 565);
            this.stockamount_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockamount_textBox.Multiline = true;
            this.stockamount_textBox.Name = "stockamount_textBox";
            this.stockamount_textBox.Size = new System.Drawing.Size(421, 31);
            this.stockamount_textBox.TabIndex = 14;
            this.stockamount_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 626);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total Stock Cost";
            // 
            // totalstockcost_textBox
            // 
            this.totalstockcost_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.totalstockcost_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalstockcost_textBox.ForeColor = System.Drawing.Color.Black;
            this.totalstockcost_textBox.Location = new System.Drawing.Point(231, 626);
            this.totalstockcost_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalstockcost_textBox.Multiline = true;
            this.totalstockcost_textBox.Name = "totalstockcost_textBox";
            this.totalstockcost_textBox.Size = new System.Drawing.Size(235, 31);
            this.totalstockcost_textBox.TabIndex = 16;
            this.totalstockcost_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalstockcostgenerate_button
            // 
            this.totalstockcostgenerate_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.totalstockcostgenerate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalstockcostgenerate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalstockcostgenerate_button.ForeColor = System.Drawing.Color.White;
            this.totalstockcostgenerate_button.Location = new System.Drawing.Point(475, 626);
            this.totalstockcostgenerate_button.Margin = new System.Windows.Forms.Padding(4);
            this.totalstockcostgenerate_button.Name = "totalstockcostgenerate_button";
            this.totalstockcostgenerate_button.Size = new System.Drawing.Size(99, 31);
            this.totalstockcostgenerate_button.TabIndex = 25;
            this.totalstockcostgenerate_button.Text = "Generate";
            this.totalstockcostgenerate_button.UseVisualStyleBackColor = false;
            this.totalstockcostgenerate_button.Click += new System.EventHandler(this.totalstockcostgenerate_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(39, 683);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 27);
            this.label6.TabIndex = 26;
            this.label6.Text = "Amount Need";
            // 
            // amountneed_textBox
            // 
            this.amountneed_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.amountneed_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountneed_textBox.ForeColor = System.Drawing.Color.Black;
            this.amountneed_textBox.Location = new System.Drawing.Point(231, 677);
            this.amountneed_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.amountneed_textBox.Multiline = true;
            this.amountneed_textBox.Name = "amountneed_textBox";
            this.amountneed_textBox.Size = new System.Drawing.Size(421, 31);
            this.amountneed_textBox.TabIndex = 27;
            this.amountneed_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(39, 738);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 27);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cost Required";
            // 
            // costrequired_textBox
            // 
            this.costrequired_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.costrequired_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costrequired_textBox.ForeColor = System.Drawing.Color.Black;
            this.costrequired_textBox.Location = new System.Drawing.Point(231, 738);
            this.costrequired_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.costrequired_textBox.Multiline = true;
            this.costrequired_textBox.Name = "costrequired_textBox";
            this.costrequired_textBox.Size = new System.Drawing.Size(235, 31);
            this.costrequired_textBox.TabIndex = 29;
            this.costrequired_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // costrequiredgenerate_button
            // 
            this.costrequiredgenerate_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.costrequiredgenerate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costrequiredgenerate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costrequiredgenerate_button.ForeColor = System.Drawing.Color.White;
            this.costrequiredgenerate_button.Location = new System.Drawing.Point(475, 738);
            this.costrequiredgenerate_button.Margin = new System.Windows.Forms.Padding(4);
            this.costrequiredgenerate_button.Name = "costrequiredgenerate_button";
            this.costrequiredgenerate_button.Size = new System.Drawing.Size(99, 31);
            this.costrequiredgenerate_button.TabIndex = 30;
            this.costrequiredgenerate_button.Text = "Generate";
            this.costrequiredgenerate_button.UseVisualStyleBackColor = false;
            this.costrequiredgenerate_button.Click += new System.EventHandler(this.costrequiredgenerate_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(83, 836);
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
            this.cancel_button.Location = new System.Drawing.Point(404, 836);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(237, 43);
            this.cancel_button.TabIndex = 32;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // Add_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 929);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.costrequiredgenerate_button);
            this.Controls.Add(this.costrequired_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.amountneed_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalstockcostgenerate_button);
            this.Controls.Add(this.totalstockcost_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stockamount_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitprice_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productname_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Inventory";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productname_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unitprice_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockamount_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalstockcost_textBox;
        private System.Windows.Forms.Button totalstockcostgenerate_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amountneed_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox costrequired_textBox;
        private System.Windows.Forms.Button costrequiredgenerate_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button cancel_button;
    }
}