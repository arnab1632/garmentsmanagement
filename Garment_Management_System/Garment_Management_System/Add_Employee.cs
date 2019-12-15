using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAR;
using OP;



namespace Garment_Management_System
{
    public partial class Add_Employee : Form
    {
        public string whoLoggedIn;
        Operation op = new Operation();
        EmployeeInfo em = new EmployeeInfo();

        public Add_Employee()
        {
            InitializeComponent();
        }

        private void loadimage_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            dlg.Title = "Select an image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               
                em.Image= dlg.FileName.ToString();
                pictureBox1.ImageLocation = em.Image;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(fullname_textBox.Text == "") { throw new Exception(); }
                if (position_textBox.Text == "") { throw new Exception(); }
                if (email_textBox.Text == "") { throw new Exception(); }
                if (dob_textBox.Text == "") { throw new Exception(); }
                if (mobileno_textBox.Text == null) { throw new Exception(); }
                if (address_textBox.Text == "") { throw new Exception(); }
                if (bloodgroup_textBox.Text == "") { throw new Exception(); }
                if (salary_textBox.Text == null) { throw new Exception(); }


                em.Full_name = fullname_textBox.Text;
                em.Position = position_textBox.Text;
                em.Email = email_textBox.Text;
                em.Dob = dob_textBox.Text;
                em.Mobile_no = int.Parse(mobileno_textBox.Text);
                em.Address = address_textBox.Text;
                em.Blood_group = bloodgroup_textBox.Text;
                em.Salary = double.Parse(salary_textBox.Text);

                op.insertEmployee(em);
                MessageBox.Show("Sucesfully Added ","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Hide();
                Add_Employee addem = new Add_Employee();
                addem.whoLoggedIn = this.whoLoggedIn;
                addem.Show();


            }
            catch (Exception)
            {
                MessageBox.Show("Failure the information", "Waring !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeeClass em = new EmployeeClass();
            em.Show();
        }

        private void close_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
