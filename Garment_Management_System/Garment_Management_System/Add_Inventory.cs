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
    public partial class Add_Inventory : Form
    {
        public string whoLoggedIn;
        Operation op = new Operation();

        

        public Add_Inventory()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (productname_textBox.Text == "") { throw new Exception(); }
                if (unitprice_textBox.Text == null) { throw new Exception(); }
                if (stockamount_textBox.Text == null) { throw new Exception(); }
                if (totalstockcost_textBox.Text == null) { throw new Exception(); }
                if (amountneed_textBox.Text == null) { throw new Exception(); }
                if (costrequired_textBox.Text == null) { throw new Exception(); }

                string productName = productname_textBox.Text;
                int unitPrice = int.Parse(unitprice_textBox.Text);
                int stockAmount = int.Parse(stockamount_textBox.Text);
                int totalStockCost = int.Parse(totalstockcost_textBox.Text);
                int amountNedeed = int.Parse(amountneed_textBox.Text);
                int costRequired = int.Parse(costrequired_textBox.Text);

                op.insertInventory(productName, unitPrice, stockAmount, totalStockCost, amountNedeed, costRequired);
                MessageBox.Show("Sucesfully Added ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                Add_Inventory addin = new Add_Inventory();
                addin.whoLoggedIn = this.whoLoggedIn;
                addin.Show();


            }
            catch (Exception)
            {
                MessageBox.Show("Failure the information", "Waring !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryClass i = new InventoryClass();
            i.Show();
        }

        private void close_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void totalstockcostgenerate_button_Click(object sender, EventArgs e)
        {
            int totalCost = 0;
            totalCost = Convert.ToInt32(unitprice_textBox.Text) * Convert.ToInt32(stockamount_textBox.Text);
            totalstockcost_textBox.Text = totalCost.ToString();

        }

        private void costrequiredgenerate_button_Click(object sender, EventArgs e)
        {
            int totalCost = 0;
            totalCost = Convert.ToInt32(unitprice_textBox.Text) * Convert.ToInt32(amountneed_textBox.Text);
            costrequired_textBox.Text = totalCost.ToString();
        }
    }
}
