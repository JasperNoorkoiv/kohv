using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohvid
{
    class Food
    {
        public int price;
        public string name;
        public string size;


        public void EatFood()
        {
            string str = Console.ReadLine();
            Console.WriteLine(" You ate " + name);
        }
        public void FoodSize()
        {
            Console.WriteLine(" You`r food size is " + size);
        }
    }
}
