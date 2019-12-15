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
    public partial class Add_Client : Form
    {
        public string whoLoggedIn;

        public ClientInfo ci = new ClientInfo();
        Operation op = new Operation();

        public Add_Client()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (buyername_textbox.Text == " ") { throw new Exception(); }
                if (company_textbox.Text == " ") { throw new Exception(); }
                if (country_textBox.Text == " ") { throw new Exception(); }
                if (contact_textBox.Text == null) { throw new Exception(); }
                if (address_textBox.Text == " ") { throw new Exception(); }
                if (skype_textBox.Text == " ") { throw new Exception(); }
                if (email_textBox.Text == " ") { throw new Exception(); }

                ci.Company = company_textbox.Text;
                ci.Buyer_name = buyername_textbox.Text;
                ci.Country = country_textBox.Text;
                ci.Address = address_textBox.Text;
                ci.Mobile_no = int.Parse(contact_textBox.Text);
                ci.Skype = skype_textBox.Text;
                ci.Email = email_textBox.Text;

                op.insertClient(ci);
                MessageBox.Show("Sucesfully Added ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                Add_Client addcl = new Add_Client();
                addcl.whoLoggedIn = this.whoLoggedIn;
                addcl.Show();


            }
            catch (Exception)
            {
                MessageBox.Show("Failure the information", "Waring !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void loadimage_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            dlg.Title = "Select an image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                ci.Image = dlg.FileName.ToString();
                pictureBox1.ImageLocation = ci.Image;
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientClass c = new ClientClass();
            c.Show();
        }

        private void close_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            
        }
    }
}
