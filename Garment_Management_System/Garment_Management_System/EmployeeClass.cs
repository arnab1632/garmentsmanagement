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
    public partial class EmployeeClass : Form
    {
        string emp;
        public string whoLoggedIn;
        Operation op = new Operation();
        EmployeeInfo ei = new EmployeeInfo();
        

        public EmployeeClass()
        {
            InitializeComponent();
        }

        private void EmployeeClass_Load(object sender, EventArgs e)
        {
            employeedetails_comboBox.DataSource = op.employeedetailsscomboboxShow();
            employeedetails_comboBox.DisplayMember = "full_name";
            employeedetails_comboBox.ValueMember = "id";
        }

        private void allemployee_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.showEmployee();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void addemployee_button_Click(object sender, EventArgs e)
        {
            Add_Employee adde = new Add_Employee();
            adde.whoLoggedIn = this.whoLoggedIn;
            adde.Show();
        }

        private void deleteemployee_button_Click(object sender, EventArgs e)
        {
            ///delete employee
            string client = employeedetails_comboBox.Text;
            op.deleteEmployee(client);
            MessageBox.Show("Employee Deleted");

            Hide();
            EmployeeClass emp = new EmployeeClass();
            emp.whoLoggedIn = this.whoLoggedIn;
            emp.Show();
        }

        private void employeedetails_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeedetails_comboBox.Text != null)
            {
                emp = employeedetails_comboBox.Text;


                ei = op.showAllEmp(emp);
                fullname_textBox.Text = ei.Full_name;
                position_textBox.Text = ei.Position;
                dob_textBox.Text = ei.Dob;
                address_textBox.Text = ei.Address;
                email_textBox.Text = ei.Email;
                salary_textbox.Text = Convert.ToString(ei.Salary);
                
                
                pictureBox1.ImageLocation = ei.Image;
                pictureBox1.Show();

            }
        }

        private void updateemployee_button_Click(object sender, EventArgs e)
        {
            
            
            
            try
            {
                if (fullname_textBox.Text == "") { throw new Exception(); }
                if (position_textBox.Text == "") { throw new Exception(); }
                if (dob_textBox.Text == "") { throw new Exception(); }
                if (email_textBox.Text == "") { throw new Exception(); }
                if (address_textBox.Text == "") { throw new Exception(); }
                
                if (salary_textbox.Text ==null) { throw new Exception(); }

                ei.Full_name = fullname_textBox.Text;
                ei.Position = position_textBox.Text;
                ei.Dob = dob_textBox.Text;
                ei.Email = email_textBox.Text;
                ei.Address = address_textBox.Text;
                ei.Salary = Convert.ToDouble(salary_textbox.Text);



                op.updateEmp(ei,emp);
               MessageBox.Show("Employee Successfully Updated", "Confirmation ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //opening this window by refershing again
                Hide();
                EmployeeClass emObj = new EmployeeClass();
                emObj.whoLoggedIn = this.whoLoggedIn;
                emObj.Show();



            }
            catch (Exception)
            {
                MessageBox.Show("Some Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //opening this window by refershing again
                Hide();
                EmployeeClass emObj = new EmployeeClass();
                emObj.whoLoggedIn = this.whoLoggedIn;
                emObj.Show();
            }
        }

        private void home_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeObj = new Home();
            homeObj.whoLoggedIn = this.whoLoggedIn;
            homeObj.Show();
        }

        private void close_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
