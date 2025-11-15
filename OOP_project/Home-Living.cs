using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    class Home_Living : Product
    {
        /*You must apply oop here the code must be deleted and you apply the attrbuie of this class and maybe make methods*/
        public List<string> Kirchen;
        public List<string> Bed_room;
        public List<string> Bath_room;
        public List<string> Living_room;
        public List<string> Dinging_room;

        public Home_Living(string name, string description, float price) : base(name, description, price)
        {

        }
    }
}
