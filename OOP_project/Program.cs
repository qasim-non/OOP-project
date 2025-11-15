using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mahmod store");
            Console.WriteLine("Type your name here: ");
            string name = Console.ReadLine();

            Customer customer = new Customer(name);
            customer.Menu();



        }
    }


}
