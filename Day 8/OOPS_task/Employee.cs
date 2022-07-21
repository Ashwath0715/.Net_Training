using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_task
{
    public string Firstname;
    public string Lastname;
    public string Email;

    public void Work()
    {
        Console.WriteLine("I am working");
        Console.ReadLine();
    }
}

public class FulltimeEmployee : Empolyee
{
    public float YearlySalary;

}

public class ParttimeEmployee : Empolyee
{
    public float HourlySalary;

}
class Employee
    {
    }
}
