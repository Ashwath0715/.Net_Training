using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_task
{

    public class Student
    {
        public string name, city;
        public int sno, totalMarks = 0;

        public Student(int sno, string name, string city, int totalMarks)
        {
            this.sno = sno;
            this.name = name.ToLower();
            this.city = city.ToLower();
            this.totalMarks = totalMarks;
        }
    }

    public class Program
    {
        static List<Student> students = new List<Student>();
        static int sno, totalMarks;
        static string name, city;

        public static void Main(string[] args)
        {
            string ch;
            Console.WriteLine("\n\tSTUDENT DETAILS");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("1. Create Student\n2. Update Student\n3. Delete Student\n4. View Student\n5. Exit\n");

            do
            {

                Console.Write("\nSelect your choice : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        enterDetails();
                        students.Add(new Student(sno, name, city, totalMarks)); break;

                    case 2:
                        updateStudent(); break;

                    case 3:
                        deleteStudent(); break;

                    case 4:
                        enterSno();
                        viewStudent(sno); break;

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

        public static void enterDetails()
        {
            Console.WriteLine("\n\nPlease provide the details below");
            Console.WriteLine("------------------------------------------------");

            enterSno();
            enterName();
            enterCity();
            enterTotalMarks();

        }

        public static void enterSno()
        {
            Console.Write("\nEnter Sno : ");
            sno = int.Parse(Console.ReadLine());
        }

        public static void enterName()
        {
            Console.Write("\nEnter Name : ");
            name = Console.ReadLine().ToLower();
        }

        public static void enterCity()
        {
            Console.Write("\nEnter City : ");
            city = Console.ReadLine().ToLower();
        }

        public static void enterTotalMarks()
        {
            Console.Write("\nEnter Total Marks : ");
            totalMarks = int.Parse(Console.ReadLine());
        }


        public static void updateStudent()
        {
            enterDetails();
            Student student = students.Find(x => x.sno == sno && x.name == name && x.city == city && x.totalMarks == totalMarks);

            if (student == null)
                Console.Write("\n\n\t *No matchng records found...");

            else
            {
                Console.WriteLine("\n\nStudent Details");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"Sno : {student.sno}\nName : {student.name}\nCity : {student.city}\nTotal Marks : {student.totalMarks}");

                Console.WriteLine("\n1. Update Sno\n2. Update Name\n3. Update City\n4. Update Total Marks\n");
                string ch;

                do
                {
                    Console.Write("\nSelect the detail which you want to update : ");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            enterSno();
                            student.sno = sno; break;

                        case 2:
                            enterName();
                            student.name = name; break;

                        case 3:
                            enterCity();
                            student.city = city; break;

                        case 4:
                            enterTotalMarks();
                            student.totalMarks = totalMarks; break;

                        default:
                            Console.WriteLine("\nInvalid Choice"); break;
                    }

                    do
                    {
                        Console.WriteLine("\n\nDo you want to continue to update, Say (yes or no)");
                        ch = Console.ReadLine().Trim().ToLower();

                        if (ch != "yes" && ch != "no")
                            Console.Write("\n\nInvalid Choice, Please say (yes or no)");

                    } while (ch != "yes" && ch != "no");

                } while (ch == "yes");

            }

        }

        public static void deleteStudent()
        {
            enterSno();
            Student student = students.Find(x => x.sno == sno);

            bool res = students.Remove(student);

            if (res)
                Console.Write($"\n  *{student.sno}* removed successfully !!");
            else
                Console.Write("\n\n\t *No matching records found...");

        }

        public static Student viewStudent(int sno)
        {
            Student student = students.Find(x => x.sno == sno);

            if (student == null)
            {
                Console.WriteLine("\n\n\t *No matchng records found...");
                return null;
            }
            else
            {
                Console.WriteLine("\n\nStudent Details");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine($"Sno : {student.sno}\nName : {student.name}\nCity : {student.city}\nTotal Marks : {student.totalMarks}");

                return student;
            }

        }

    


    }


}