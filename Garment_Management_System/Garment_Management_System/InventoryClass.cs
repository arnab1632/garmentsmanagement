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
    public partial class InventoryClass : Form
    {
        public string whoLoggedIn;

        Operation op = new Operation();
        
        

        public InventoryClass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Inventory adde = new Add_Inventory();
            adde.whoLoggedIn = this.whoLoggedIn;
            adde.Show();
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

        private void allproducts_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.allproduct();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            ///delete product
            string pro = deleteproduct_comboBox.Text;
            op.deleteProduct(pro);
            MessageBox.Show("Product Deleted");

            Hide();
            InventoryClass inv = new InventoryClass();
            inv.whoLoggedIn = this.whoLoggedIn;
            inv.Show();
        }

        private void InventoryClass_Load(object sender, EventArgs e)
        {
            deleteproduct_comboBox.DataSource = op.allproduct();
            deleteproduct_comboBox.DisplayMember = "product_name";
            deleteproduct_comboBox.ValueMember = "id";
        }

        

        private void searchbyproduct_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string s = searchbyproduct_textBox.Text;
                DataTable dt = new DataTable();
                dt = op.sp(s);
                dataGridView1.DataSource = dt;

            }
        }

    }
}
