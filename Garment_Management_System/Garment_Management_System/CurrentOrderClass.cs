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
    public partial class CurrentOrderClass : Form
    {
        string order;
        public string whoLoggedIn;
        Operation op = new Operation();
        CurrentOrderInfo co = new CurrentOrderInfo();


        public CurrentOrderClass()
        {
            InitializeComponent();
        }

        private void CurrentOrderClass_Load(object sender, EventArgs e)
        {
            orders_comboBox.DataSource = op.orderscomboboxShow();
            orders_comboBox.DisplayMember = "order_name";
            orders_comboBox.ValueMember = "id";

            if (whoLoggedIn == "admin")
            {
                profitcalculate_button.Visible = false;
                profit_textBox.Visible = false;
                label13.Visible = false;

            }





        }

        private void orders_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (orders_comboBox.Text != null)
            {
                order = orders_comboBox.Text;


                co = op.showAllcurrentOrder(order);


                odername_textBox.Text = co.Order_name;
                buyer_textBox.Text = co.Client;
                quantity_textBox.Text = Convert.ToString(co.Quantity);
                shipmentdate_textBox.Text = co.Shipment_date;
                buyerspays_textBox.Text = Convert.ToString(co.Buyer_pays);
                estimatedcost_textBox.Text = Convert.ToString(co.Estimated_cost);


                pictureBox1.ImageLocation = co.Sample;
                pictureBox1.Show();

            }







        }

        private void neworder_button_Click(object sender, EventArgs e)
        {
            Add_Order addo = new Add_Order();
            addo.whoLoggedIn = this.whoLoggedIn;
            addo.Show();

        }
        

        private void updateorder_button_Click(object sender, EventArgs e)
        {
           
            try
            {

                if (odername_textBox.Text == "") { throw new Exception(); }
                if (buyer_textBox.Text == "") { throw new Exception(); }
                if (quantity_textBox.Text == "") { throw new Exception(); }
                if (shipmentdate_textBox.Text == "") { throw new Exception(); }
                if (buyerspays_textBox.Text == "") { throw new Exception(); }
                if (estimatedcost_textBox.Text ==" " ) { throw new Exception(); }


                co.Order_name = odername_textBox.Text;
                co.Client = buyer_textBox.Text;
                co.Quantity = Convert.ToInt32(quantity_textBox.Text);
                co.Shipment_date = shipmentdate_textBox.Text;
                co.Buyer_pays = Convert.ToDouble(buyerspays_textBox.Text);
                co.Estimated_cost = Convert.ToDouble(estimatedcost_textBox.Text);

                op.currentOrderUpdate(co, order);
                MessageBox.Show("Order Successfully Updated", "Confirmation ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //opening this window by refershing again
                Hide();
                CurrentOrderClass newObj = new CurrentOrderClass();
                newObj.whoLoggedIn = this.whoLoggedIn;
                newObj.Show();
            }

            catch (Exception)
            {
                MessageBox.Show("Some Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //opening this window by refershing again
                Hide();
                CurrentOrderClass newObj = new CurrentOrderClass();
                newObj.whoLoggedIn = this.whoLoggedIn;
                newObj.Show();
            }

        }

        private void deleteorder_button_Click(object sender, EventArgs e)
        {
            //Delete order
            order = orders_comboBox.Text;
            op.deleteOrder(order);
            MessageBox.Show("Client Deleted");

            //opening this window by refershing again
            Hide();
            CurrentOrderClass cObj = new CurrentOrderClass();
            cObj.whoLoggedIn = this.whoLoggedIn;
            cObj.Show();
        }

        

        private void profitcalculate_button_Click(object sender, EventArgs e)
        {
            profit_textBox.Text = (Convert.ToInt32(buyerspays_textBox.Text) - Convert.ToInt32(estimatedcost_textBox.Text)).ToString();
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
