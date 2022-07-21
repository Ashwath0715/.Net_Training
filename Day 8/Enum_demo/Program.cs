using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_demo
{
   
    class Program
    {
        enum Week
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thrusday,
            Friday,
            Saturday
        }

        enum color
        {
            red=1,
            blue=2,
            yellow=3
        }
        static void Main(string[] args)
        {
            int a = (int)Week.Sunday;
            int b = (int)Week.Monday;
            int c = (int)Week.Tuesday;
            int x = (int)color.yellow;
            Console.WriteLine(Week.Sunday);
            Console.WriteLine(Week.Monday);
            Console.WriteLine("Sunday: {0}", a);
            Console.WriteLine("Monday: {0}", b);
            Console.WriteLine("Tuesday: {0}", c);
            Console.WriteLine("Yellow: {0}", x);
            Console.WriteLine("\n Press Enter key to exit.....");
            Console.ReadKey();

        }
    }
}
