using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Database;
using VAR;


namespace OP
{
    public class Operation
    {
        public ClientInfo ci = new ClientInfo();
        public DbConnection dbc = new DbConnection();
        public EmployeeInfo ei = new EmployeeInfo();
        public CreateAccount ca = new CreateAccount();
        public CurrentOrderInfo c = new CurrentOrderInfo();
       



        string lastname;
        public SqlConnection sql = new SqlConnection("Data Source=DESKTOP-5RG0DNB\\FOESQL;Initial Catalog=GarmentManagementSystem;Integrated Security=True");


        public int insertClient(ClientInfo ci)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Clients values ('" + ci.Buyer_name + "','" + ci.Company + "','" + ci.Image + "','" + ci.Country + "', '" + ci.Address + "','" + ci.Mobile_no + "','" + ci.Skype + "', '" + ci.Email + "')";
            return dbc.ExNonQuery(cmd);

        }

        public int insertEmployee(EmployeeInfo ei)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employee values ('" + ei.Full_name + "','" + ei.Image + "','" + ei.Position + "', '" + ei.Email + "','" + ei.Dob + "','" + ei.Mobile_no + "','" + ei.Address + "','" + ei.Blood_group + "','" + ei.Salary + "')";
            return dbc.ExNonQuery(cmd);


        }

        public int insertInventory(string productName, int unitPrice, int stockAmount, int totalStockCost, int amountNedeed, int costRequired)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Inventory values('" + productName + "','" + unitPrice + "','" + stockAmount + "', '" + totalStockCost + "','" + amountNedeed + "','" + costRequired + "')";
            return dbc.ExNonQuery(cmd);

        }

        public int insertOder(string client, string orderName, string sample, int quantity, string shipmentDate, double estimatedCost, double buyerPays)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into CurrentOrders values('" + client + "','" + orderName + "','" + sample + "','" + quantity + "','" + shipmentDate + "', '" + estimatedCost + "','" + buyerPays + "')";
            return dbc.ExNonQuery(cmd);

        }

        public DataTable sp(string s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Inventory  where product_name Like ('%"+ s +"%')";
            return dbc.ExeReader(cmd);
        }

        public DataTable comboboxShow()  // used in Add_Order Class client combobox and ClientClass clients combobox
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Clients";
            return dbc.ExeReader(cmd);
        }

        

        public DataTable notice()  // used in noticeClass
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Notice";
            return dbc.ExeReader(cmd);
        }


        public int insertNotice(string postedBy, string Message, string Date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Notice  values('" + postedBy + "','" + Message + "','" + Date + "')";
            return dbc.ExNonQuery(cmd);

        }
        public int deleteNotice(string date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Notice where Date LIKE ('%" + date + "%')";
            return dbc.ExNonQuery(cmd);

        }
        public int deleteClient(string cli)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Clients where buyer_name LIKE ('%" + cli + "%')";
            return dbc.ExNonQuery(cmd);

        }
        

        public DataTable showClientInfo(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Clients where buyer_name LIKE ('%" + name + "%') ";
            return dbc.ExeReader(cmd);
        }

        public ClientInfo ShowClient2(string name)
        {
            try
            {
                
                string q = "Select * from Clients where buyer_name LIKE ('%" + name + "%') ";
                SqlCommand cmd = new SqlCommand(q, sql);
                sql.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        ci.Buyer_name = reader.GetString(1);
                        ci.Company = reader.GetString(2);
                        ci.Image = reader.GetString(3);
                        ci.Country = reader.GetString(4);
                        ci.Address = reader.GetString(5);
                        ci.Mobile_no = Convert.ToInt32(reader.GetString(6));
                        ci.Skype = reader.GetString(7);
                        ci.Email = reader.GetString(8);

                    }
                    


                }
                return ci;
            }
            finally { sql.Close(); }
        }


        public DataTable orderscomboboxShow()  // used in CurrentOrderClass Orders combobox
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CurrentOrders";
            return dbc.ExeReader(cmd);
        }

        public DataTable employeedetailsscomboboxShow()  // used in EmployeeClass Employee Details combobox
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee";
            return dbc.ExeReader(cmd);
        }


        public DataTable showEmployee()  // used in EmployeeClass Employee Details combobox
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee ";
            return dbc.ExeReader(cmd);
        }

        public int deleteEmployee(string cli)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Employee where full_name LIKE ('%" + cli + "%')";
            return dbc.ExNonQuery(cmd);
        }



        public EmployeeInfo showAllEmp(string name)
        {
            try
            {

                string q = "Select * from Employee where full_name LIKE ('%" + name + "%') ";
                SqlCommand cmd = new SqlCommand(q, sql);
                sql.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        ei.Full_name = reader.GetString(1);
                        ei.Image= reader.GetString(2);
                        ei.Position = reader.GetString(3);
                        ei.Email= reader.GetString(4);
                        ei.Dob = reader.GetString(5);
                        ei.Address = reader.GetString(7);
                        ei.Blood_group = reader.GetString(8);
                        ei.Salary = reader.GetDouble(9);

                       

                    }

                }
                return ei;
            }
            finally { sql.Close(); }
        }


        public void updateEmployee(string fn,string p, string d, string e, string a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("Update Employee SET full_name = {0} position ='{1}', dob='{2}',  address='{3}' where  email={4} ", fn, p, d, a,e );
            dbc.ExeQuery(cmd);

        }

        public int deleteOrder(string cli)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from CurrentOrders where order_name LIKE ('%" + cli + "%')";
            return dbc.ExNonQuery(cmd);
        }

        public int login(CreateAccount ca)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Login values('" + ca.Username + "','" + ca.Password + "','" + ca.Position +"')";
            return dbc.ExNonQuery(cmd);

        }

        public int createAccount(CreateAccount ca)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Account values('" + ca.Username + "','" + ca.FirstName + "','" + ca.Lastname + "', '" + ca.Password + "','" + ca.Email + "','" + ca.Mobileno + "','" + ca.Image + "','" + ca.Position + "')";
            return dbc.ExNonQuery(cmd);

        }

        public int loginCheck(string un, string pass)
        {
           
            string query = "select * from Login where username  = '" + un + "' and password = '" + pass + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql);
            DataTable dbl = new DataTable();
            sda.Fill(dbl);
            if (dbl.Rows.Count == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }



        public CurrentOrderInfo showAllcurrentOrder(string name)
        {
            try
            {

                string q = "Select * from CurrentOrders where order_name LIKE ('%" + name + "%') ";
                SqlCommand cmd = new SqlCommand(q, sql);
                sql.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        c.Client = reader.GetString(1);
                        c.Order_name = reader.GetString(2);
                        
                        c.Sample = reader.GetString(3);
                        c.Quantity = reader.GetInt32(4);
                        c.Shipment_date= reader.GetString(5);
                        c.Estimated_cost = reader.GetDouble(6);
                        c.Buyer_pays = reader.GetDouble(7);


                    }
                    sql.Close();


                }
                return c;
            }
            finally { sql.Close(); }
        }

        public string WhologgedIn(string un, string pass)
        {
            try
            {
                
                string q = "select * from Login where username  = '" + un + "' and password = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(q, sql);
                sql.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                     lastname= reader.GetString(2);

                    }


                }
                return lastname;
            }
            finally { sql.Close(); }
        }


        public DataTable allproduct()  // used in noticeClass
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Inventory";
            return dbc.ExeReader(cmd);
        }

        public int deleteProduct(string cli)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Inventory where product_name LIKE ('%" + cli + "%')";
            return dbc.ExNonQuery(cmd);
        }

        public int updateEmp(EmployeeInfo ca, string a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Employee SET full_name = '" + ca.Full_name + "',position = '"+ca.Position+"' ,email = '"+ca.Email+"',dob = '"+ca.Dob+"',address = '"+ca.Address+"',salary ='"+ca.Salary+"' WHERE full_name = '"+a+"'";
            return dbc.ExNonQuery(cmd);
        }


        public int currentOrderUpdate(CurrentOrderInfo oi,string a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE CurrentOrders SET client = '" + oi.Client + "',order_name = '" + oi.Order_name + "' ,quantity= '" + oi.Quantity + "',shipment_date = '" + oi.Shipment_date + "',estimated_cost = '" + oi.Estimated_cost + "',buyer_pays ='" + oi.Buyer_pays + "' WHERE order_name = '" + a + "'";
            return dbc.ExNonQuery(cmd);
        }

    }
}
