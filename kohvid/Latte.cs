using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohvid
{
    class Latte : Kohvid
    {
        public Latte()
        {
            name = "latte";
            size = "\n1 - Small \n2 - Meduim \n3 - Large";
            price = 20;
            drinking = +10;
        }
        
    }
}
