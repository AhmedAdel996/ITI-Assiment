using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass7
{
   abstract class Shape
    {
        public int fdim = 1;
        public int sdim = 2;
        public int area = 0;



        public abstract int clcArea()
        {
            return area;

        }


    }
}
