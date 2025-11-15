using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    internal class Book : Product
    {
        public string type;
        
        public Book(string type, string name, string description, float price) : base( name, description, price)
        {
            this.type = type;
        }

        public override void displayInfo()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Price: " + this.price);
            Console.WriteLine("Description: " + this.description);
            Console.WriteLine("Type: " + this.type);
        }
    }
}
