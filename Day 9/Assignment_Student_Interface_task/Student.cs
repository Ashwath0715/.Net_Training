using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Interface
{
    class MyException : ApplicationException
    {
        public void mywrongException()
        {
            Console.WriteLine("Select valid Option");
        }

        public class Method : student1, student2, student3
        {
            public Student[] array = new Student[0];

            //Update

            public void Update(Student[] array)
            {
                Console.WriteLine();

                Console.WriteLine("Press 1 :Name");
                Console.WriteLine("Press 2 :ID");
                Console.WriteLine("Press 3 :Marks");
                Console.WriteLine("Press 4 :Address");

                try
                {
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (n > 4)
                    {
                        throw new MyException();
                    }
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Enter ID");
                            int p = int.Parse(Console.ReadLine());
                            array[0].SetID(p);
                            break;
                        case 2:
                            Console.WriteLine("Enter Name");
                            string s = Console.ReadLine();

                            array[0].SetName(s);
                            break;
                        case 3:
                            Console.WriteLine("Enter Marks");
                            int m = int.Parse(Console.ReadLine());

                            array[0].SetMarks(m);
                            break;
                        case 4:
                            Console.WriteLine("Enter Address");
                            string a = Console.ReadLine();

                            array[0].SetAddress(a);
                            break;

                        default:
                            Console.WriteLine("Thank u for updating");
                            break;


                    }
                }
                catch (MyException e)
                {
                    e.mywrongException();
                    Console.WriteLine();
                }

            }
            public void mywrongException()
            {
                Console.WriteLine("Exception occured,Choice correctly");
                Console.WriteLine();
                Console.WriteLine("Please Select valid Option ");
                Console.WriteLine();
            }
            //Delete

            public void Delete1(Student[] array)
            {
                Console.WriteLine();
                Console.WriteLine("Press 1 :ID");
                Console.WriteLine("Press 2 :Name");
                Console.WriteLine("Press 3 :Total Marks");
                Console.WriteLine("Press 4 :Address");

                try
                {
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (n > 4)
                    {
                        throw new MyException();
                    }
                    switch (n)
                    {
                        case 1:
                            array[0].SetID(0);
                            break;
                        case 2:
                            array[0].SetName(null);
                            break;
                        case 3:
                            array[0].SetMarks(0);
                            break;
                        case 4:
                            array[0].SetAddress(null);
                            break;
                        default:
                            Console.WriteLine("Thank you");
                            break;
                    }
                }
                catch (MyException e)
                {
                    e.mywrongException();
                    Console.WriteLine();
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }

            //Create

            public Student[] createContact(Student[] arr)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the student details");
                Console.WriteLine();
                for (int i = arr.Length - 1; i < arr.Length; i++)
                {
                    arr[i] = new Student();
                    Console.WriteLine("Enter student name");
                    String name = Console.ReadLine();
                    arr[i].SetName(name);
                    Console.WriteLine("Enter student id");
                    int id = int.Parse(Console.ReadLine());
                    arr[i].SetID(id);
                    Console.WriteLine("Enter student marks");
                    int mar = int.Parse(Console.ReadLine());
                    arr[i].SetMarks(mar);
                    Console.WriteLine("Enter student address");
                    String address = Console.ReadLine();
                    arr[i].SetAddress(address);

                }
                return arr;

            }
            public Student[] DynamicArray(Student[] arr)
            {
                Student[] temp = new Student[arr.Length + 1];
                for (int i = 0; i < arr.Length; i++)
                {
                    temp[i] = arr[i];
                }
                return temp;
            }

            //Display

            public void Display(Student[] arr)
            {
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i].GetName() + "   " + arr[i].GetID() + "   " + arr[i].GetMarks() + "   " + arr[i].GetAddress());
                }
            }
        }
    }
}
