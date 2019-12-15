using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garment_Management_System
{
    public partial class Home : Form
    {
        public string whoLoggedIn;



        public Home()
        {
            InitializeComponent();
        }

        

        private void employee_button_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeClass employeeObj = new EmployeeClass();
            employeeObj.whoLoggedIn = this.whoLoggedIn;
            employeeObj.Show();
        }

        private void inventorybutton_Click(object sender, EventArgs e)
        {
            Hide();
            InventoryClass newObj = new InventoryClass();
            newObj.whoLoggedIn = this.whoLoggedIn;
            newObj.Show();
        }

        private void currentorder_button_Click(object sender, EventArgs e)
        {
            Hide();
            CurrentOrderClass newObj = new CurrentOrderClass();
            newObj.whoLoggedIn = this.whoLoggedIn;
            newObj.Show();
        }


        private void clients_button_Click(object sender, EventArgs e)
        {
            Hide();
            ClientClass clObj = new ClientClass();
            clObj.whoLoggedIn = this.whoLoggedIn;
            clObj.Show();
        }

        private void inventory_button_Click(object sender, EventArgs e)
        {
            Hide();
            InventoryClass newObj = new InventoryClass();
            newObj.whoLoggedIn = this.whoLoggedIn;
            newObj.Show();
        }

        private void currentoders_button_Click(object sender, EventArgs e)
        {
            Hide();
            CurrentOrderClass newObj = new CurrentOrderClass();
            newObj.whoLoggedIn = this.whoLoggedIn;
            newObj.Show();
        }

        

        private void noticeboard_button_Click(object sender, EventArgs e)
        {
            Hide();
            NoticeClass newObj = new NoticeClass();
            newObj.whoLoggedIn = this.whoLoggedIn;
            newObj.Show();
        }

        

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Login newObj = new Login();
            newObj.Show();
        }

        private void gotowebsite_label_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://orbidapparels.com/");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (whoLoggedIn == "chairman")
            {
                employee_button.Visible = false;
                clients_button.Visible = true;
                inventory_button.Visible = true;
                currentoders_button.Visible = true;
                noticeboard_button.Visible = true;

                clients_button.Location = new Point(4, 151);
                inventory_button.Location = new Point(4, 229);
                currentoders_button.Location = new Point(4, 307);
                noticeboard_button.Location = new Point(4, 388);

            }
            else if(whoLoggedIn == "admin")
            {
                employee_button.Visible = true;
                clients_button.Visible = true;
                inventory_button.Visible = true;
                currentoders_button.Visible = true;
                noticeboard_button.Visible = true;

                employee_button.Location = new Point(4, 122);
                clients_button.Location = new Point(4, 192);
                inventory_button.Location = new Point(4, 262);
                currentoders_button.Location = new Point(4, 332);
                noticeboard_button.Location = new Point(4, 388);

            }
        }

        private void close_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
    }
}
