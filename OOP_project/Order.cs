using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    internal class Order
    {
        public int OrderId;
        public string Name;
        public DateTime OrderTime; /*This orderTime attribute must = now I don't know how to do it*/

        public Order(string name)
        {
            OrderId = 1;
            Name = name;
        }
    }
}
