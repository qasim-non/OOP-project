using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    internal class Cart
    {

        public List<int> Products; /* Here you may change the logic because this is defcault to work make the attrbuie that work well here */
        public double TotalPrice;

        public Cart()
        {
            Products = new List<int>();
            TotalPrice = 0;
        }
    }
}
