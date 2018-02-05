using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohvid
{
    class Apple : Food
    {
        public Apple()
        {
            name = "apple";
            size = "\n1 - Small \n2 - Meduim \n3 - Large";
            price = 20;
            eating = +10;
        }
    }
}
