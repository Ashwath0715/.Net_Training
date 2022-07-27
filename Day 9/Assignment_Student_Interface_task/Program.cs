using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Student_Interface.MyException;

namespace Student_Interface
{
    class Program
    {
        public static Student[] array = new Student[0];
        public static void Main(string[] args)
        {
            string ch;
            Console.WriteLine("\n\tSTUDENT DETAILS");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("1. Create Student\n2. Update Student\n3. Display Student\n4. Delete Student\n5. Exit\n");

            do
            {

                Console.Write("\nSelect your choice : ");
                int choice = int.Parse(Console.ReadLine());
                Method m1 = new Method();
                switch (choice)
                {
                    case 1:
                        array = m1.DynamicArray(array);
                        array = m1.createContact(array);
                        break;

                    case 2:
                        m1.Update(array);
                        break;
                    case 3:
                        m1.Display(array);
                        break;
                    case 4:
                        m1.Delete1(array);
                        break;

                    default:
                        Console.Write("\nInvalid Choice");
                        break;
                }

                do
                {
                    Console.Write("\n\nDo you want to continue to the Application, Say (yes or no) ");
                    ch = Console.ReadLine().Trim().ToLower();

                    if (ch != "yes" && ch != "no")
                        Console.Write("\n\nInvalid Choice, Please say (yes or no)");

                } while (ch != "yes" && ch != "no");

            } while (ch == "yes");

            Console.WriteLine("\n\n  *** Program Terminated *** ");
        }
    }

}
