using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass7
{
    class Program
    {
        static void Main(string[] args)
        {


            Point3 p1 = new Point3(1, 2, 0);
            Point3 p2 = new Point3(1, 2, 0);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1 == p2);
            Picture pic = new Picture();
            pic.fdim = 12;
            pic.sdim = 22;
            pic.clcArea();

            Console.ReadKey();
        }
    }
}
