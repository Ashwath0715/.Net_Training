using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_valuedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 30;
            int p = 0;
            int q = 0;
            Calc(a, b, out p, out q);
            Console.WriteLine("Division is: {0} remainder is: {1}", p, q);
            Console.ReadLine();
        }

        static void Calc(int x,int y,out int Divider,out int remainder)
        {
            Divider = x / y;
            remainder = x % y;
        }
    }
}
