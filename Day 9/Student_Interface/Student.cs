using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Interface
{
    class Student : IStudent
    {
        string city;
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        int sno;
        public int SNO
        {
            get
            {
                return sno;
            }

            set
            {
                sno = value;
            }
        }

        int totalMarks;
        public int TotalMarks
        {
            get
            {
                return totalMarks;
            }

            set
            {
                totalMarks = value;
            }
        }


        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("SNO: " + SNO);
            Console.WriteLine("City: " + City);
            Console.WriteLine("TotalMarks : " + TotalMarks);

        }
    }
}
