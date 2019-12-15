using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OP;
using VAR;

namespace Garment_Management_System
{


    public partial class ClientClass : Form
    {

        
        public string whoLoggedIn;
        string client;
        Operation op = new Operation();
        ClientInfo ci = new ClientInfo();
       

        public ClientClass()
        {
            InitializeComponent();
        }

        private void clients_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            if (clients_comboBox.Text != null)
            {
                client = clients_comboBox.Text;
                

                ci = op.ShowClient2(client);
                company_textBox.Text = ci.Company;
                buyername_textBox.Text = ci.Buyer_name;
                country_textBox.Text = ci.Country;
                address_textBox.Text = ci.Address;
                contact_textBox.Text = Convert.ToString(ci.Mobile_no);
                skype_textBox.Text = ci.Skype;
                email_textBox.Text = ci.Email;
                pictureBox2.ImageLocation = ci.Image;
                pictureBox2.Show();

            }

        }

        private void ClientClass_Load(object sender, EventArgs e)
        {
            clients_comboBox.DataSource = op.comboboxShow();
            clients_comboBox.DisplayMember = "buyer_name";
            clients_comboBox.ValueMember = "id";

        }

        private void home_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeObj = new Home();
            homeObj.whoLoggedIn = this.whoLoggedIn;
            homeObj.Show();
        }

        private void deleteclient_button_Click(object sender, EventArgs e)
        {
            //Delete Client
            client = clients_comboBox.Text;
            op.deleteClient(client);
            MessageBox.Show("Client Deleted");

            //opening this window by refershing again
            Hide();
            ClientClass cObj = new ClientClass();
            cObj.whoLoggedIn = this.whoLoggedIn;
            cObj.Show();
        }

        private void close_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addclient_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Client addc = new Add_Client();
            addc.whoLoggedIn = this.whoLoggedIn;
            addc.Show();

        }
        
    }
}
