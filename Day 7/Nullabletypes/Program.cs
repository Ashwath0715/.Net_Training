using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabletypes
{
    class Myclass
    {
        public Nullable<int> i;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // In C#, if we try to assign a null value to the value type variables,then we will get compile time error.

            //int ?g = null;
            //bool y=true;
            //Console.writeline("x={0},y={1}",x,y);
            //Console.ReadLine();

            Myclass cls = new Myclass();
            if (cls.i == null)
            {
                Console.WriteLine("Null");
            }
            else
            {
                Console.WriteLine(cls.i.Value);
            }
            //----------------------------------------------------------------------------------
            int? a = null;
            if (a.HasValue)
            {
                Console.WriteLine("x={0}", a.Value);
            }
            else
            {
                Console.WriteLine("Value is Empty");
            }
            Console.ReadLine();
            //-----------------------------------------------------------------------------------
         
            int? x = null;
            // Nullable<int> z;
            //int? z= null;
            //y=x if x is not null,y=0 if x is null
            int y = x ?? 0;
            Console.WriteLine("y={0}", y);
            Console.ReadLine();

        }
    }
}
