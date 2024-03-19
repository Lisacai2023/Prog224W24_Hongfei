using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hongfei
{
    public class Beverage : Product
    {
        string _size;

        public Beverage() { }

        public Beverage(string name, double price,string size) : base(name, price)
        {
            _size = size;
        }

        public string Size { get => _size; set => _size=value; }

        public override string GetProductType()
        {
            return "Beverage";
        }
    }
}
