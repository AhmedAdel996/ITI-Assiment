using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass7
{
    class Point3
    {


        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }


        public Point3(int x1, int y1, int z1)
        {
            this.x = x1;
            this.y = y1;
            this.z = z1;


        }

        public override bool Equals(Object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point3 p = (Point3)obj;
                return (x == p.x) && (y == p.y);
            }
        }



        public static bool operator ==(Point3 p1, Point3 p2)
        {


            return p1.x == p2.x && p1.y == p2.y;
        }


        public override string ToString()
        {
            return base.ToString() + "x " + x.ToString() + " y" + x.ToString(); ;
        }


    }
}
