using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass7
{
    class Picture :Shape
    {

        Shape[] arr=new Picture[5];


        public override int clcArea()
        {
            return fdim*sdim;

        }

        public void printarea( Shape s ) {

            for (int i = 0; i < arr.Length; i++) {

                arr[i] = new Picture();
            }
            Console.WriteLine(s.clcArea());
            
        }
        
        
    }
}
