using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hongfei
{
    public class Order
    {
        List<Product> products;
        double _totalPrice;

        public Order()
        {
            products = new List<Product>();
            TotalPrice = CalculateTotalPrice();
        }

        public List<Product> Products { get => products; set => products=value; }
        public double TotalPrice { get => _totalPrice; set => _totalPrice=value; }

        public double CalculateTotalPrice()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
