using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hongfei
{
    public class Merchandise : Product
    {
        string _category;

        public string Category { get => _category; set => _category=value; }

        public override string GetProductType()
        {
            return "Merchandise";
        }
    }
}
