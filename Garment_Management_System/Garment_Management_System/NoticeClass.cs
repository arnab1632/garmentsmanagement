using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OP;
using VAR;


namespace Garment_Management_System
{
    public partial class NoticeClass : Form
    {
        public string whoLoggedIn;

        Operation op = new Operation();
        

        public NoticeClass()
        {
            InitializeComponent();
        }

        private void NoticeClass_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.notice();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            deletenotice_comboBox.DataSource = op.notice();
            deletenotice_comboBox.DisplayMember = "Date";
            deletenotice_comboBox.ValueMember = "id";

            if (whoLoggedIn == "admin")
            {
                postnotice__button.Visible = false;
                deletenotice_button.Visible = false;
                textBox1.Visible = false;
                deletenotice_comboBox.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }



        }

        private void close_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeObj = new Home();
            homeObj.whoLoggedIn = this.whoLoggedIn;
            homeObj.Show();
        }

        private void postnotice__button_Click(object sender, EventArgs e)
        {
            //posting Notice
            string postedby = whoLoggedIn;
            string mesaage = textBox1.Text;
            string date = DateTime.Now.ToString();
            op.insertNotice(postedby, mesaage, date);
            MessageBox.Show("Notice Posted");

            Hide();
            NoticeClass newObj = new NoticeClass();
            newObj.whoLoggedIn = this.whoLoggedIn;
            newObj.Show();

        }

        private void deletenotice_button_Click(object sender, EventArgs e)
        {
            ///delete notice
            string time = deletenotice_comboBox.Text;
            op.deleteNotice(time);
            MessageBox.Show("Notice Deleted");

            //opening this window by refershing again
            Hide();
            NoticeClass nObj = new NoticeClass();
            nObj.whoLoggedIn = this.whoLoggedIn;
            nObj.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletenotice_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
