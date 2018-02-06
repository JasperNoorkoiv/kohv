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

        public void EatFood()
        {
            Console.WriteLine("You ate " + name);
        }
    }
}
