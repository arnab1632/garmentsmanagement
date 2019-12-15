using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAR
{
   public class CurrentOrderInfo
    {
        string client;
        string order_name;
        string sample;
        int quantity;
        string shipment_date;
        double estimated_cost;
        double buyer_pays;

        public string Client { get => client; set => client = value; }
        public string Order_name { get => order_name; set => order_name = value; }
        public string Sample { get => sample; set => sample = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Shipment_date { get => shipment_date; set => shipment_date = value; }
        public double Estimated_cost { get => estimated_cost; set => estimated_cost = value; }
        public double Buyer_pays { get => buyer_pays; set => buyer_pays = value; }
    }
}
