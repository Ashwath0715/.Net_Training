using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();

            int result = obj.sub(5, 3);
            Console.WriteLine("result {0}", result);

            Console.ReadLine();

        }
    }
}
