using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    internal class Product
    {
        static int ProductId;
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }

        public Product(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public virtual void displayInfo()
        {
            Console.WriteLine("The product name is " + this.name);
            Console.WriteLine("The product price is " + this.price);
            Console.WriteLine("The product description is " + this.description);
        }



    }
}
