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
    public partial class Sign_Up : Form
    {
        public string whoLoggedIn;
        Operation op = new Operation();
        CreateAccount ca = new CreateAccount();

        public Sign_Up()
        {
            InitializeComponent();
        }

        private void firstname_textBox_Enter(object sender, EventArgs e)
        {
            if (firstname_textBox.Text == "First Name")
            {
                firstname_textBox.Text = "";

                firstname_textBox.ForeColor = Color.White;
            }
        }

        private void firstname_textBox_Leave(object sender, EventArgs e)
        {
            if (firstname_textBox.Text == "")
            {
                firstname_textBox.Text = "First Name";

                firstname_textBox.ForeColor = Color.Silver;
            }
        }

        private void lastname_textBox_Enter(object sender, EventArgs e)
        {
            if (lastname_textBox.Text == "Last Name")
            {
                lastname_textBox.Text = "";

                lastname_textBox.ForeColor = Color.White;
            }
        }

        private void lastname_textBox_Leave(object sender, EventArgs e)
        {
            if (lastname_textBox.Text == "")
            {
                lastname_textBox.Text = "Last Name";

                lastname_textBox.ForeColor = Color.Silver;
            }
        }

        private void password_textBox_Enter(object sender, EventArgs e)
        {
            if (password_textBox.Text == "Password")
            {
                password_textBox.Text = "";

                password_textBox.ForeColor = Color.White;
            }
        }

        private void password_textBox_Leave(object sender, EventArgs e)
        {
            if (password_textBox.Text == "")
            {
                password_textBox.Text = "Password";

                password_textBox.ForeColor = Color.Silver;
            }
        }

        private void email_textBox_Enter(object sender, EventArgs e)
        {
            if (email_textBox.Text == "Someone@example.com")
            {
                email_textBox.Text = "";

                email_textBox.ForeColor = Color.White;
            }
        }

        private void email_textBox_Leave(object sender, EventArgs e)
        {
            if (email_textBox.Text == "")
            {
                email_textBox.Text = "Someone@example.com";

                email_textBox.ForeColor = Color.Silver;
            }
        }

        private void mobileno_textBox_Enter(object sender, EventArgs e)
        {
            if (mobileno_textBox.Text == "Mobile No")
            {
                mobileno_textBox.Text = "";

                mobileno_textBox.ForeColor = Color.White;
            }
        }

        private void mobileno_textBox_Leave(object sender, EventArgs e)
        {
            if (mobileno_textBox.Text == "")
            {
                mobileno_textBox.Text = "Mobile No";

                mobileno_textBox.ForeColor = Color.Silver;
            }
        }

        

        private void loadimage_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            dlg.Title = "Select an image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ca.Image = dlg.FileName.ToString();
                pictureBox1.ImageLocation = ca.Image;
            }
        }

        private void signup_button_Click(object sender, EventArgs e)
        {

            try
            {
                if (firstname_textBox.Text == "" && firstname_textBox.Text == "First Name") { throw new Exception(); }
                if (lastname_textBox.Text == "" && lastname_textBox.Text == "Last Name") { throw new Exception(); }
                if (username_textBox.Text == "" && username_textBox.Text == "User Name") { throw new Exception(); }
                if (password_textBox.Text == "" && password_textBox.Text == "Password") { throw new Exception(); }
                if (email_textBox.Text == "" && email_textBox.Text == "Someone@example.com") { throw new Exception(); }
                if (mobileno_textBox.Text == null && mobileno_textBox.Text == "Mobile No") { throw new Exception(); }
                if (comboBox1.Text == "" && comboBox1.Text == "Position") { throw new Exception(); }

                ca.FirstName = firstname_textBox.Text;
                ca.Lastname = lastname_textBox.Text;
                ca.Username = username_textBox.Text;
                ca.Password = password_textBox.Text;
                ca.Email = email_textBox.Text;
                ca.Mobileno = int.Parse(mobileno_textBox.Text);
                ca.Position = comboBox1.Text;

                op.createAccount(ca);
                op.login(ca);

                MessageBox.Show("Sucesfully Added ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                Sign_Up siup = new Sign_Up();
                siup.whoLoggedIn = this.whoLoggedIn;
                siup.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Failure the information", "Waring !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }   
            

        private void login_label_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
            
        }

        private void username_textBox_Enter(object sender, EventArgs e)
        {
            if (username_textBox.Text == "User Name")
            {
                username_textBox.Text = "";

                username_textBox.ForeColor = Color.White;
            }
        }

        private void username_textBox_Leave(object sender, EventArgs e)
        {
            if (username_textBox.Text == "")
            {
                username_textBox.Text = "User Name";

                username_textBox.ForeColor = Color.White;
            }
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
