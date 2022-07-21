using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Program
    {
        static void Main(string[] args)
        {

            Order o = new Order();
            o.Laptop = "HP";
            o.Ram = "8";
            o.Generation = "11";
            Console.WriteLine("Laptop: {0}", o.Laptop);
            Console.WriteLine("RAM: {0}", o.Ram);
            Console.WriteLine("Gen: {0}", o.Generation);
            o.CreateOrder();

            Student student = new Student();
            student.processor = "Intel core i5";
            student.SSD = "256";
            student.Laptopid = " 31a5c46";
            student.getDetails();
            //o.validateOrdervalue();
            //o.validateOrderCountry();
            Console.WriteLine("Processor: " + student.processor);
            Console.WriteLine("SSD: " + student.SSD);
            Console.WriteLine("ID: " + student.Laptopid);
        }
    }
}
