using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Interface
{
    class Program
    {
        static Dictionary<int, Student> listDictionary = new Dictionary<int, Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("+----------------------------+");
                Console.WriteLine("|       STUDENTS DETAILS     |");
                Console.WriteLine("+----------------------------+");
                Console.WriteLine("|1. Create Student           |");
                Console.WriteLine("|2. View list of Students    |");
                Console.WriteLine("|3. Search Students          |");
                Console.WriteLine("|4. Exit                     |");
                Console.WriteLine("+----------------------------+");

                Console.Write("Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertStudent();
                        break;
                    case 2:
                        ViewList();
                        break;
                    case 3:
                        Search();
                        break;
                    case 4:
                        return;
                }
            }
        }

        private static void Search()
        {
            bool found = false;
            Console.Write("Input City: ");
            String search = Console.ReadLine();
            Console.WriteLine("All student of City " + search);
            foreach (Student student in listDictionary.Values)
            {
                if (student.City.Equals(search))

                {
                    Console.WriteLine("----------------------------");
                    student.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No students were found!");
            }
        }



        private static void ViewList()
        {
            foreach (Student i in listDictionary.Values)
            {
                Console.WriteLine("----------------------------");
                i.Display();
            }
        }

        private static void InsertStudent()
        {
            Student student = new Student();

            //Increament ID
            student.SNO = listDictionary.Count + 1;

            //Input name
            Console.Write("Enter Student Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter SNO : ");
            student.SNO = int.Parse(Console.ReadLine());

            //Input City
            Console.Write("Enter City: ");
            student.City = Console.ReadLine();

            Console.Write("Enter Total Marks : ");
            student.TotalMarks = int.Parse(Console.ReadLine());

            listDictionary.Add(student.SNO, student);
            Console.WriteLine("Successfully inserted a student!");
        }

    }

}
