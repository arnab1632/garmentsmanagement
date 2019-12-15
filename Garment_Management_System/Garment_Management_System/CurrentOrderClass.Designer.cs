namespace Garment_Management_System
{
    partial class CurrentOrderClass
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
            this.home_label = new System.Windows.Forms.Label();
            this.orders_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buyerspays_textBox = new System.Windows.Forms.TextBox();
            this.shipmentdate_textBox = new System.Windows.Forms.TextBox();
            this.quantity_textBox = new System.Windows.Forms.TextBox();
            this.buyer_textBox = new System.Windows.Forms.TextBox();
            this.odername_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.estimatedcost_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.profit_textBox = new System.Windows.Forms.TextBox();
            this.profitcalculate_button = new System.Windows.Forms.Button();
            this.neworder_button = new System.Windows.Forms.Button();
            this.updateorder_button = new System.Windows.Forms.Button();
            this.deleteorder_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1415, 49);
            this.panel1.TabIndex = 2;
            // 
            // close_label
            // 
            this.close_label.AutoSize = true;
            this.close_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_label.ForeColor = System.Drawing.Color.White;
            this.close_label.Location = new System.Drawing.Point(1376, 11);
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
            this.label2.Size = new System.Drawing.Size(239, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(686, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orbid Apparels Ltd.";
            // 
            // home_label
            // 
            this.home_label.AutoSize = true;
            this.home_label.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label.ForeColor = System.Drawing.Color.White;
            this.home_label.Location = new System.Drawing.Point(84, 71);
            this.home_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(108, 42);
            this.home_label.TabIndex = 31;
            this.home_label.Text = "Home";
            // 
            // orders_comboBox
            // 
            this.orders_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.orders_comboBox.ForeColor = System.Drawing.Color.White;
            this.orders_comboBox.FormattingEnabled = true;
            this.orders_comboBox.Location = new System.Drawing.Point(25, 244);
            this.orders_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.orders_comboBox.Name = "orders_comboBox";
            this.orders_comboBox.Size = new System.Drawing.Size(257, 24);
            this.orders_comboBox.TabIndex = 46;
            this.orders_comboBox.SelectedIndexChanged += new System.EventHandler(this.orders_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 42);
            this.label3.TabIndex = 47;
            this.label3.Text = "Orders";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1208, 301);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 42);
            this.label11.TabIndex = 59;
            this.label11.Text = "Sample";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(356, 452);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 42);
            this.label9.TabIndex = 58;
            this.label9.Text = "Buyer Pays";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(299, 359);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 42);
            this.label8.TabIndex = 57;
            this.label8.Text = "Shipment Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(396, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 42);
            this.label7.TabIndex = 56;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(435, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 42);
            this.label6.TabIndex = 55;
            this.label6.Text = "Buyer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(339, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 42);
            this.label5.TabIndex = 48;
            this.label5.Text = "Order Name";
            // 
            // buyerspays_textBox
            // 
            this.buyerspays_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.buyerspays_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerspays_textBox.ForeColor = System.Drawing.Color.White;
            this.buyerspays_textBox.Location = new System.Drawing.Point(592, 451);
            this.buyerspays_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.buyerspays_textBox.Multiline = true;
            this.buyerspays_textBox.Name = "buyerspays_textBox";
            this.buyerspays_textBox.Size = new System.Drawing.Size(384, 54);
            this.buyerspays_textBox.TabIndex = 54;
            this.buyerspays_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shipmentdate_textBox
            // 
            this.shipmentdate_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.shipmentdate_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipmentdate_textBox.ForeColor = System.Drawing.Color.White;
            this.shipmentdate_textBox.Location = new System.Drawing.Point(592, 358);
            this.shipmentdate_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.shipmentdate_textBox.Multiline = true;
            this.shipmentdate_textBox.Name = "shipmentdate_textBox";
            this.shipmentdate_textBox.Size = new System.Drawing.Size(384, 54);
            this.shipmentdate_textBox.TabIndex = 53;
            this.shipmentdate_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantity_textBox
            // 
            this.quantity_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.quantity_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_textBox.ForeColor = System.Drawing.Color.White;
            this.quantity_textBox.Location = new System.Drawing.Point(592, 268);
            this.quantity_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantity_textBox.Multiline = true;
            this.quantity_textBox.Name = "quantity_textBox";
            this.quantity_textBox.Size = new System.Drawing.Size(384, 54);
            this.quantity_textBox.TabIndex = 52;
            this.quantity_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buyer_textBox
            // 
            this.buyer_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.buyer_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyer_textBox.ForeColor = System.Drawing.Color.White;
            this.buyer_textBox.Location = new System.Drawing.Point(592, 179);
            this.buyer_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.buyer_textBox.Multiline = true;
            this.buyer_textBox.Name = "buyer_textBox";
            this.buyer_textBox.ReadOnly = true;
            this.buyer_textBox.Size = new System.Drawing.Size(384, 54);
            this.buyer_textBox.TabIndex = 51;
            this.buyer_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // odername_textBox
            // 
            this.odername_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.odername_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odername_textBox.ForeColor = System.Drawing.Color.White;
            this.odername_textBox.Location = new System.Drawing.Point(592, 90);
            this.odername_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.odername_textBox.Multiline = true;
            this.odername_textBox.Name = "odername_textBox";
            this.odername_textBox.Size = new System.Drawing.Size(384, 54);
            this.odername_textBox.TabIndex = 50;
            this.odername_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(295, 540);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 42);
            this.label10.TabIndex = 61;
            this.label10.Text = "Estimated Cost";
            // 
            // estimatedcost_textBox
            // 
            this.estimatedcost_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.estimatedcost_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedcost_textBox.ForeColor = System.Drawing.Color.White;
            this.estimatedcost_textBox.Location = new System.Drawing.Point(592, 540);
            this.estimatedcost_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.estimatedcost_textBox.Multiline = true;
            this.estimatedcost_textBox.Name = "estimatedcost_textBox";
            this.estimatedcost_textBox.Size = new System.Drawing.Size(384, 54);
            this.estimatedcost_textBox.TabIndex = 60;
            this.estimatedcost_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(440, 628);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 42);
            this.label13.TabIndex = 63;
            this.label13.Text = "Profit";
            // 
            // profit_textBox
            // 
            this.profit_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.profit_textBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profit_textBox.ForeColor = System.Drawing.Color.White;
            this.profit_textBox.Location = new System.Drawing.Point(592, 628);
            this.profit_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.profit_textBox.Multiline = true;
            this.profit_textBox.Name = "profit_textBox";
            this.profit_textBox.Size = new System.Drawing.Size(384, 54);
            this.profit_textBox.TabIndex = 62;
            this.profit_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profitcalculate_button
            // 
            this.profitcalculate_button.BackColor = System.Drawing.Color.Gray;
            this.profitcalculate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profitcalculate_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitcalculate_button.ForeColor = System.Drawing.Color.White;
            this.profitcalculate_button.Location = new System.Drawing.Point(1000, 637);
            this.profitcalculate_button.Margin = new System.Windows.Forms.Padding(4);
            this.profitcalculate_button.Name = "profitcalculate_button";
            this.profitcalculate_button.Size = new System.Drawing.Size(83, 37);
            this.profitcalculate_button.TabIndex = 64;
            this.profitcalculate_button.Text = "Calculate";
            this.profitcalculate_button.UseVisualStyleBackColor = false;
            this.profitcalculate_button.Click += new System.EventHandler(this.profitcalculate_button_Click);
            // 
            // neworder_button
            // 
            this.neworder_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.neworder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neworder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworder_button.ForeColor = System.Drawing.Color.White;
            this.neworder_button.Location = new System.Drawing.Point(1172, 452);
            this.neworder_button.Margin = new System.Windows.Forms.Padding(4);
            this.neworder_button.Name = "neworder_button";
            this.neworder_button.Size = new System.Drawing.Size(232, 63);
            this.neworder_button.TabIndex = 66;
            this.neworder_button.Text = "New Order";
            this.neworder_button.UseVisualStyleBackColor = false;
            this.neworder_button.Click += new System.EventHandler(this.neworder_button_Click);
            // 
            // updateorder_button
            // 
            this.updateorder_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.updateorder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateorder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateorder_button.ForeColor = System.Drawing.Color.White;
            this.updateorder_button.Location = new System.Drawing.Point(1172, 530);
            this.updateorder_button.Margin = new System.Windows.Forms.Padding(4);
            this.updateorder_button.Name = "updateorder_button";
            this.updateorder_button.Size = new System.Drawing.Size(232, 63);
            this.updateorder_button.TabIndex = 67;
            this.updateorder_button.Text = "Update Order";
            this.updateorder_button.UseVisualStyleBackColor = false;
            this.updateorder_button.Click += new System.EventHandler(this.updateorder_button_Click);
            // 
            // deleteorder_button
            // 
            this.deleteorder_button.BackColor = System.Drawing.Color.Gray;
            this.deleteorder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteorder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteorder_button.ForeColor = System.Drawing.Color.White;
            this.deleteorder_button.Location = new System.Drawing.Point(1172, 609);
            this.deleteorder_button.Margin = new System.Windows.Forms.Padding(4);
            this.deleteorder_button.Name = "deleteorder_button";
            this.deleteorder_button.Size = new System.Drawing.Size(232, 63);
            this.deleteorder_button.TabIndex = 68;
            this.deleteorder_button.Text = "Delete Order";
            this.deleteorder_button.UseVisualStyleBackColor = false;
            this.deleteorder_button.Click += new System.EventHandler(this.deleteorder_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1172, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // home_pictureBox
            // 
            this.home_pictureBox.Image = global::Garment_Management_System.Properties.Resources.arrow2;
            this.home_pictureBox.Location = new System.Drawing.Point(16, 70);
            this.home_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.home_pictureBox.Name = "home_pictureBox";
            this.home_pictureBox.Size = new System.Drawing.Size(60, 42);
            this.home_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_pictureBox.TabIndex = 32;
            this.home_pictureBox.TabStop = false;
            this.home_pictureBox.Click += new System.EventHandler(this.home_pictureBox_Click);
            // 
            // CurrentOrderClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1415, 729);
            this.Controls.Add(this.deleteorder_button);
            this.Controls.Add(this.updateorder_button);
            this.Controls.Add(this.neworder_button);
            this.Controls.Add(this.profitcalculate_button);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.profit_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.estimatedcost_textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buyerspays_textBox);
            this.Controls.Add(this.shipmentdate_textBox);
            this.Controls.Add(this.quantity_textBox);
            this.Controls.Add(this.buyer_textBox);
            this.Controls.Add(this.odername_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orders_comboBox);
            this.Controls.Add(this.home_pictureBox);
            this.Controls.Add(this.home_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentOrderClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrentOrderClass";
            this.Load += new System.EventHandler(this.CurrentOrderClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox home_pictureBox;
        private System.Windows.Forms.Label home_label;
        private System.Windows.Forms.ComboBox orders_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buyerspays_textBox;
        private System.Windows.Forms.TextBox shipmentdate_textBox;
        private System.Windows.Forms.TextBox quantity_textBox;
        private System.Windows.Forms.TextBox buyer_textBox;
        private System.Windows.Forms.TextBox odername_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox estimatedcost_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox profit_textBox;
        private System.Windows.Forms.Button profitcalculate_button;
        private System.Windows.Forms.Button neworder_button;
        private System.Windows.Forms.Button updateorder_button;
        private System.Windows.Forms.Button deleteorder_button;
    }
}