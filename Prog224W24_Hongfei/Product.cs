using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hongfei
{
    public abstract class Product
    {
        string _name;
        double _price;

        protected Product() { }

        protected Product(string name, double price)
        {
            _name=name;
            _price=price;
        }

        public string Name { get => _name; set => _name=value; }
        public double Price { get => _price; set => _price=value; }


        public override string ToString()
        {
            return $"{_name}, {_price}";
        }

        public abstract string GetProductType();
    }
}
