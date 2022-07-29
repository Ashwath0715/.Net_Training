using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_InterfaceCollection_Task
{
    class StudentManagement
    {
        static void Main(string[] args)
        {
            StudentIO studentIO = new StudentIO();
            Boolean toExit = true;
            do
            {
                switch (studentIO.Menu())
                {
                    case 1:
                        {
                            studentIO.AddStudent();
                            break;
                        }
                    case 2:
                        {
                            studentIO.DisplayStudent();
                            break;
                        }
                    case 3:
                        {
                            studentIO.UpdateStudent();
                            break;
                        }
                    case 4:
                        {
                            studentIO.DeleteStudent();
                            break;
                        }
                    case 0:
                        {
                            toExit = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter valid option");
                            break;
                        }
                }
            } while (toExit);
        }
    }
}
