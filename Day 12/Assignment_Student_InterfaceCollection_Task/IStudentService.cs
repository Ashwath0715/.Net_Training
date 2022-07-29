using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_InterfaceCollection_Task
{
    interface IStudentService
    {
        Student AddStudent(string name, byte age, byte standard, string address);

        List<Student> GetStudentsSortedByStandard();

        Student GetStudentById(String id);
        Student GetStudentByName(String name);

        Student UpdateStudentAge(String id, byte age);

        Student UpdateStudentAddress(String id, String address);

        Boolean DeleteStudent(String id);

    }
}
