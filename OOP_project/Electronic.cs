using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    internal class Electronic : Product
    {

        public string brand;
        public string gurentee;

        public Electronic(string name, string description, float price, string brand, string gurentee) : base(name, description, price)
        {
            this.brand = brand;
            this.gurentee = gurentee;
        }

        public override void displayInfo()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Price: " + this.price);
            Console.WriteLine("Description: " + this.description);
            Console.WriteLine("Brand: " + this.brand);
            Console.WriteLine("Gurentee: " + this.gurentee);
        }
    }    
}
