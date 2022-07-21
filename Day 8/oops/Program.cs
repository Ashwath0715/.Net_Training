using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{

    class HRDepartment
    {
        public string location;
        public string work;
        public void Manage()
        {

            
            Console.WriteLine("I am managing");
        }
    }

    class Employee : HRDepartment
    {

        
        public void Work()
        {

            Console.WriteLine("I am working");
        }

        public void ShowWork()
        {

            Console.WriteLine("OOPs PRoject");
        }
    }

    class Department : HRDepartment
    {

        

        public void Location(string l)
        {

            location = l;
            Console.WriteLine("location which is given :" +location);
           
        }

        public void SetWork(string w)
        {

            work = w;
            Console.WriteLine("My setwork " +work);
            
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            Department d = new Department();
            Employee e = new Employee();
            d.Location("Nagpur");
            d.SetWork(".Net");
            d.Manage();
            e.Work();
            e.ShowWork();
            Console.ReadLine();

        }
    }
}
