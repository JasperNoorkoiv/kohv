using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohvid
{
    class Ekspresso : Kohvid
    {
        public Ekspresso()
        {
            name = "ekspresso";
            size = "\n1 - Small \n2 - Meduim \n3 - Large";
            price = 10;
            drinking = +10;
        }
    }
}
