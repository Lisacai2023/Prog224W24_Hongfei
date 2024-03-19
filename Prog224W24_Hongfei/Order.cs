using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hongfei
{
    public class Order
    {
        List<Product> Orderproducts;
        double _totalPrice;

        public Order()
        {
            Orderproducts = new List<Product>();
            _totalPrice = CalculateTotalPrice();
        }

        public List<Product> Products { get => Orderproducts; set => Orderproducts=value; }
        public double TotalPrice { get => _totalPrice; set => _totalPrice=value; }

        public double CalculateTotalPrice()
        {
            double total = 0;
            foreach (var product in Orderproducts)
            {
                total += product.Price;
            }
            return total;
        }

        public void AddProduct(Product product)
        {
            Orderproducts.Add(product);
        }
    }
}
