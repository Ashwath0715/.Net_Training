using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    //Rectangle
    static double Area(double l, double w)
    {
        return l * w;
    }
    //circle,overload area
    static double Area(double R)
    {
        const double PI = 3.14159;
            return R * R * PI;
    }
    class Program
    {
        static void Main(string[] args)
        {
            double length, width;
            double Radius;
            Console.WriteLine("Enter the sides of Rectangle");
            Console.WriteLine("Length:");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("width:");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of rectangle:");
            Console.WriteLine(Area(length, width));

            //Area
            Console.WriteLine("Enter the radius");
            Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Area of circle ");
            Console.WriteLine(Area(Radius));
            Console.ReadKey();
        }

        private static bool Area(double length, double width)
        {
            throw new NotImplementedException();
        }

        private static bool Area(double radius)
        {
            throw new NotImplementedException();
        }
    }
}
