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

namespace Garment_Management_System
{
    public partial class Login : Form
    {
       
        public string whoLoggedIn;
        //int i;

        Operation op = new Operation();


        public Login()
        {
            InitializeComponent();
            
        }

        private void username_textBox_Enter(object sender, EventArgs e)
        {
            if (username_textBox.Text == "User Name")
            {
                username_textBox.Text = "";

                username_textBox.ForeColor = Color.Silver;
            }
        }

        private void username_textBox_Leave(object sender, EventArgs e)
        {
            if (username_textBox.Text == "")
            {
                username_textBox.Text = "User Name";

                username_textBox.ForeColor = Color.Silver;
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

        private void signup_label_Click(object sender, EventArgs e)
        {
            Hide();
            Sign_Up su = new Sign_Up();
            su.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            string username = username_textBox.Text;
            string password = password_textBox.Text;

            int i = op.loginCheck(username, password);

            if ( i == 1 && username_textBox.Text != "User Name" && password_textBox.Text != "Password")
            {
                whoLoggedIn = op.WhologgedIn(username, password);
                Hide();
                Home h = new Home();
                h.whoLoggedIn = this.whoLoggedIn;
                h.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password");
            }
            
        }

        private void close_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string username = username_textBox.Text;
                string password = password_textBox.Text;

                int i = op.loginCheck(username, password);
                if (i == 1)
                {
                    whoLoggedIn = op.WhologgedIn(username, password);
                    Hide();
                    Home h = new Home();
                    h.whoLoggedIn = this.whoLoggedIn;
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                }

            }
        }
    }
}
