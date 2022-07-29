using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_InterfaceCollection_Task
{
    class StudentService : IStudentService
    {
        List<Student> students = new List<Student>();

        private Student AddStudent(string name, byte age, byte standard, string address)
        {
            Student student = new Student(GenerateId(standard), name, age, standard, address);
            students.Add(student);
            return student;
        }

        public bool DeleteStudent(string id)
        {
            Student student = GetStudentById(id);
            if(student == null)
            {
                return false;
            }
            else
            {
                students.Remove(student);
                return true;
            }
         
        }

      

        public List<student> GetStudentsSortedByStandard()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(string id)
        {
            foreach (Student student in students)
            {
                if (student.GetID() == id)
                {
                    return student;
                }
            }
        }

        public Student GetStudentByName(string name)
        {
            foreach (Student student in students)
            {
                if (student.GetName() == name)
                {
                    return student;
                }
            }
        }

        public Student UpdateStudentAge(string id, byte age)
        {
            Student student = GetStudentById(id);
            if (student == null)
            {
                return null;
            }
            else
            {
                student.SetAge(age);
                return student;
            }
        }

        public Student UpdateStudentAddress(string id, string address)
        {
            Student student = GetStudentById(id);
            if (student == null)
            {
                return null;
            }
            else
            {
                student.SetAddress(address);
                return student;
            }
        }
    }
}
