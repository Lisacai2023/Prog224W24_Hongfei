using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Prog224W24_Hongfei
{
    public class Inventory : IEnumerable
    {
        List<Product> _products = new List<Product>();

        public List<Product> Products { get => _products; set => _products=value; }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }



        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }

        public void SaveToJson(string filePath)
        {
            JsonSerializerOptions jso = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(Products,jso);
            File.WriteAllText(filePath, json);
            Console.WriteLine(json);
        }

        public void LoadFromJson(string filePath)
        {
            string listFormFile = File.ReadAllText(filePath);
            Products = JsonSerializer.Deserialize<List<Product>>(listFormFile);
            Console.WriteLine(Products.Count);
            foreach (Product product in Products)
            {
                Console.WriteLine(product);
            }
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
