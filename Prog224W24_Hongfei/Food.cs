using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hongfei
{
    public class Food : Product
    {
        DateTime _expirationDate;

        public Food() { }

        public Food(string name, double price) : base(name, price)
        {
        }

        public Food(string name, double price, DateTime expirationDate) : base(name, price)
        {
            _expirationDate = expirationDate;
        }

        public DateTime ExpirationDate { get => _expirationDate; set => _expirationDate=value; }

        public override string GetProductType()
        {
            return "Food";
        }
    }
}
