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
        public int eating;


        public void EatFood()
        {
            Console.WriteLine(" You ´ate " + name);
        }
        public void FoodSize()
        {
            Console.WriteLine(" You`r food size is " + size);
        }
    }
}
