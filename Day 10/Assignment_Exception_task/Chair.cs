using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_task
{

    class Chair : Furniture
    {
        public string chairType;
        int rate;
        public string capacity;


        public void getData()
        {
            Console.WriteLine(" Purpose for chair :");
            capacity = Console.ReadLine();

            Console.WriteLine("What is the type of chair you want", chairType);

            Console.ReadLine();
            if (chairType == "wood")
            {
                Console.WriteLine("1 for  Teak wood");
                Console.WriteLine(" 2 for  rose wood");
                Console.WriteLine("Enter your option");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("you chose Teak wood");
                        break;
                    case 2:
                        Console.WriteLine("you chose rose wood");
                        break;
                    default:
                        Console.WriteLine("you didn't choose any chair type");
                        break;
                }

            }

            else if (chairType == "steel")
            {
                Console.WriteLine("1 for  Gray steel");
                Console.WriteLine(" 2 for  green steel");
                Console.WriteLine(" 3 for  brown steel");
                Console.WriteLine("Enter your option");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("you chose gray steel");
                        break;
                    case 2:
                        Console.WriteLine("you chose green steel");
                        break;
                    case 3:
                        Console.WriteLine("you chose brown steel");
                        break;
                    default:
                        Console.WriteLine("you didn't choose any chair type");
                        break;
                }
            }
             else 
            {
                Console.WriteLine(" 1 for  Green Color Plastic");
                Console.WriteLine(" 2 for  Red Color Plastic");
                Console.WriteLine(" 3 for  Brown Color Plastic");
                Console.WriteLine("Enter your option");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine(" Red color");
                        break;
                    case 2:
                        Console.WriteLine(" green color");
                        break;
                    case 3:
                        Console.WriteLine(" Brown color");
                        break;
                    default:
                        Console.WriteLine("didn't choose any chair type");
                        break;
                }
            }
        }

    }
}
