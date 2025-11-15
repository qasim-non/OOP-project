using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    class Fragrance : Product
    {
        /*All of this must be deleted and you must add things like country of the fraqrance or other things about fraqrance*/
        public List<string> Men_fragranse;
        public List<string> Women_fragranse;
        public List<string> Unisex_fragranse;
        public List<string> Boy_fragranse;

        public Fragrance(string name, string description, float price) : base(name, description, price)
        {

        }
    }


}
