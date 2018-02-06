using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohvid
{
    class Kohvid
    {
        public int price;
        public string name;
        public string size;


        public void DrinkCoffe()
        {
            string str = Console.ReadLine();
            Console.WriteLine("You drank coffe " + name);
        }
        public void CoffeSize()
        {
            Console.WriteLine("You`r coffe size is " + size);
        }
    }
}


