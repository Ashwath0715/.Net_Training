using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application to check Laptop features ");
            Console.WriteLine("Select the Laptop");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display Contact by number");
            Console.WriteLine("3 View all Contact");


            var userInput = Console.ReadLine();

            var Laptop = new Laptop();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Laptop name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Laptop id number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        Laptop.AddContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Laptop id no to search");
                        var searchNumber = Console.ReadLine();
                        Laptop.DisplayContact(searchNumber);

                        break;
                    case "3":
                        Laptop.DisplayAllContact();
                        break;

                    default:
                        Console.WriteLine("Select the Option");
                        break;
                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
            

        }
    }
}
