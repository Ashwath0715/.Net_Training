using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_task
{
    class Cot : Furniture
    {
        public string cotType;
        int rate;
        public string capacity;
        

        public void GetData()
        {
            Console.WriteLine(" Capacity of chair :");
            capacity = Console.ReadLine();

            Console.WriteLine("What is the type of chair you want", cotType);

            Console.ReadLine();
            if (cotType == "wood")
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

            else 
            {
                Console.WriteLine("Press 1 for choosing Gray steel");
                Console.WriteLine("Press 2 for choosing green steel");
                Console.WriteLine("Press 3 for choosing brown steel");
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
          
        }

    }
}
