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
    public partial class Add_Order : Form
    {

        public string whoLoggedIn;
        Operation op = new Operation();
        string sample;

        public Add_Order()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            try
            {

                if (ordername_textBox.Text == "") { throw new Exception(); }
                if (client_comboBox.Text == "") { throw new Exception(); }
                if (sample == "" ) { throw new Exception(); }
                if (quantity_textBox.Text == "") { throw new Exception(); }
                if (shipmentdate_textBox.Text == "") { throw new Exception(); }
                if (buyerpays_textBox.Text == "") { throw new Exception(); }
                if (estimatedcost_textBox.Text == "") { throw new Exception(); }

                string orderName = ordername_textBox.Text;
                string client = client_comboBox.Text;
                int quantity = int.Parse(quantity_textBox.Text);
                string shipmentDate = shipmentdate_textBox.Text;
                double buyerPays = double.Parse(buyerpays_textBox.Text);
                double estimatedCost = double.Parse(estimatedcost_textBox.Text);

                op.insertOder(client, orderName, sample, quantity, shipmentDate, estimatedCost, buyerPays);
                MessageBox.Show("Sucesfully Added ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                Add_Order addor = new Add_Order();
                addor.whoLoggedIn = this.whoLoggedIn;
                addor.Show();

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

                sample = dlg.FileName.ToString();
                pictureBox1.ImageLocation = sample;
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            CurrentOrderClass i = new CurrentOrderClass();
            i.Show();
        }

        private void close_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Order_Load(object sender, EventArgs e)
        {
            client_comboBox.DataSource = op.comboboxShow();
            client_comboBox.DisplayMember = "buyer_name";
            client_comboBox.ValueMember = "id";
        }
    }
}
