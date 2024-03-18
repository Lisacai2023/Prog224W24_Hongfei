using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hongfei
{
    public class Inventory : IEnumerable
    {
        List<Product> _products = new List<Product>();

        //public Inventory(List<Product> products)
        //{
        //    Products= new List<Product>();
        //}

        public List<Product> Products { get => _products; set => _products=value; }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }



        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }

        public void SaveToJson()
        {

        }

        public void LoadFromJson()
        {
        }

        public IEnumerator GetEnumerator()
        {
            return new InventoryEnumerator(ref _products);
        }

        //Create interal class
        private class InventoryEnumerator : IEnumerator
        {
            //Field
            int index = -1;
            List<Product> Products;

            //Constructor
            public InventoryEnumerator(ref List<Product> products)
            {
                Products=products;
            }

            //Property
            public object Current => Products[index];

            public bool MoveNext()
            {
                index++;
                if (index >=  Products.Count)
                {
                    return false;
                }
                else { return true; }
            }

            //Reset sets the index back to before the first element
            public void Reset()
            {
                index = -1;
            }
        }



    }//class
}//namespace
