using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
           {
            const string name = "ashwath";
            const string location = "Pune";
            const int age = 22;


            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("\nPress Enter key to exit..");
            Console.ReadLine();
        }

    }
}

