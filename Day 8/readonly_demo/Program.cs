using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_demo
{
    class User
    {
        //Initialize Read Only Field
        public readonly string name = "Aswath";
        public readonly string location;
        public readonly int age;
        public User()
        {
            location = "Bangalore";
            age = 21;
        }
    }
   

    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            //This will throw compile time error
            //u.name="Prakash";
            Console.WriteLine("Name: {0}", u.name);
            Console.WriteLine("Location: {0}", u.location);
            Console.WriteLine("Age: {0}", u.age);
            Console.WriteLine("\n Press Enter Key to exit....");
            Console.ReadLine();
        }
    }
}
