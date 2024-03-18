using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hongfei
{
    public class Receipt
    {
        public Order order;
        public double totalPrice;

        public Order Order { get => order; set => order=value; }
        public double TotalPrice { get => Order.TotalPrice; }

        public override string ToString()
        {
            return $"Receipt: Order Totoal:${TotalPrice}";
        }
    }
}
