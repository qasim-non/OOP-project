using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    internal class Customer
    {
        public string phoneNumber;
        public static int sizeOfCart;

        public static int customerId;
        public string Name { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }

        public void addToCart(int id)
        {
            cart[sizeOfCart++] = id;
        }

        public void Menu()
        {
            // Here make objects and add all elemnts
            Book Bukhary = new Book("ReligiousBook", "Sahih Bukhary", "This book is for hadith", 10000);
            Book math = new Book("EducationalBook", "math", "This book is for the first year in high school", 6000);

            Electronic phone = new Electronic("Samsoung s20 5g", "Ram 12 Giga, storage: 128 Giga", 200000, "Samsoung", "1 Year gurentee");
            Electronic laptop = new Electronic("Dell prcision 7846", "Intel(R) Core(TM) i9-9300HQ CPU @ 2.30GHz (2.30 GHz)", 2000000, "Dell", "1 Year gurentee");

            //*Here you should complete making all the objects because we want the store to be ready for customer to buy the prodcuts*//
            while (true)
            {
                Console.WriteLine("Welcome " + this.Name);
                Console.WriteLine("Choose the number for the opretion you want ");
                Console.WriteLine("1- Show all products. ");
                Console.WriteLine("2- Show your cart ");
                Console.WriteLine("3- Show your order ");
                int choose = int.Parse(Console.ReadLine());

                switch(choose)
                {
                    case 1:
                        Console.WriteLine("Choose the number for the Product type you want ");
                        Console.WriteLine("1- Books. ");
                        Console.WriteLine("2- Elictronics. ");
                        Console.WriteLine("3- Home-Living. ");
                        Console.WriteLine("4- Clothing. ");
                        Console.WriteLine("5- Fragrance. ");
                        Console.WriteLine("6- Accessories. ");
                        int choice = int.Parse(Console.ReadLine());

                        /* Complete all cases I just type books as an exapmle */
                        switch (choice)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Choose the number of book you want add to cart");

                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("1- ");
                                Bukhary.displayInfo();

                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("2- ");
                                math.displayInfo();

                                int bookNum = int.Parse(Console.ReadLine());
                                /*Here you should find any way to add the Bukhary or math opject to the cart class */

                                break;

                            case 2:
                                break;

                            case 3:
                                break;

                            case 4:
                                break;

                            case 5:
                                break;

                            case 6:
                                break;

                            default:
                                break;
                        }
                        break;

                    case 2:
                        /*type code to show customer cart*/
                        break;  

                    case 3:
                        /*Type code to show order */
                        break;

                    default:
                        break;
                }


            }
        }


    }
}
