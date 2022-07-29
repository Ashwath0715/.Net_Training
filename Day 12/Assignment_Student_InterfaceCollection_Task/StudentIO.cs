using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_InterfaceCollection_Task
{
    class StudentIO
    {
        StudentService studentService = new StudentService();

        public byte Menu()
        {
            Console.WriteLine("1 : Add student");
            Console.WriteLine("2 : Display student");
            Console.WriteLine("3 : Update student");
            Console.WriteLine("4 : delete student");
            Console.WriteLine("0 : Exit");
            byte option = Convert.ToByte(Console.ReadLine());
            return option;

        }
        public void AddStudent()
        {
            Console.Write("Enter Name ");
            string name = Console.ReadLine();

            Console.Write("Enter Age ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter standard ");
            byte standard = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Address ");
            string address = Console.ReadLine();

            StudentIO student = studentService.AddStudent(name, age, standard, address);
            Display(student);
            Console.WriteLine("----------------------");
        }

        private void Display(StudentIO student)
        {
            if (student == null)
            {
                Console.WriteLine("student not found");
            }
            else
            {
                Console.WriteLine("------------------");
                Console.WriteLine("id: " + student.GetId());
                Console.WriteLine("name: " + student.GetName());
                Console.WriteLine("age: " + student.GetAge());
                Console.WriteLine("standard: " + student.GetStandard());
                Console.WriteLine("address: " + student.GetAddress());
            }
        }

        public void DisplayStudent()
        {
            Console.WriteLine("1: Display student by id");
            Console.WriteLine("2: Display student by name");
            //Console.WriteLine("3: Display student by id");
            Console.WriteLine("Enter option:");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Write("Enter id");
                        Student student = studentService.GetStudentById(Console.ReadLine());
                        Display(student);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter name");
                        Student student = studentService.GetStudentById(Console.ReadLine());
                        Display(student);
                        break;
                    }
                case 3:
                    {
                        List<Student> students = studentService.GetStudentsSortedByStandard();                      
                        Display(students);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter valid option");
                        break;
                    }
            }
        }

        private void Display(List<Student> students)
        {
            if(students.Count == 0)
            {
                Console.WriteLine("no student found");

            }
            else
            {
                    foreach(Student student in students)
                    {
                    Display(student);
                    }
                    Console.WriteLine("-------------------")
            }
        }

        public void DeleteStudent()
        {
            Console.Write("Enter id ");
            string id = Console.ReadLine();
            if (studentService.DeleteStudent(id))
            {
                Console.WriteLine("student deleted successfully");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        public void UpdateStudent()
        {
            Console.WriteLine("1: Update age");
            Console.WriteLine("2: Update address");
            Console.Write("Enter option");
            switch (Convert.ToByte(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Write("enter id: ");
                        string id = Console.ReadLine();
                        Console.Write("enter new age: ");
                        byte age = Convert.ToByte(Console.ReadLine());
                        Display(studentService.UpdateStudentAge(id, age));
                        break;
                    }
                case 2:
                    {
                        Console.Write("enter id: ");
                        string id = Console.ReadLine();
                        Console.Write("enter new address: ");
                        byte address = Convert.ToByte(Console.ReadLine());
                        //Display(studentService.UpdateStudentAddress(id,address));
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Enter valid option");
                        break;
                    }
            }
        }
    }
}
