using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_task
{
    class Program
    {
        static void Main(string[] args)
        {
            FulltimeEmployee FTE = new FulltimeEmployee();
            FTE.Firstname = "Thenn";
            FTE.Lastname = "Arasu";
            FTE.Email = "thennarasu@gmail.com";
            FTE.YearlySalary = 5000; //Full Time Employee Specific Fields   
            FTE.printfulName();    //called print the Name to printfulName base class Method


            ParttimeEmployee PTE = new ParttimeEmployee();
            PTE.Firstname = "Karthi";
            PTE.Lastname = "Keyan";
            PTE.Email = "karthi@gmail.com";
            PTE.HourlySalary = 5000;
            PTE.printfulName();  // called print the Name  to printfulName base class  Method
        }
    }
}
