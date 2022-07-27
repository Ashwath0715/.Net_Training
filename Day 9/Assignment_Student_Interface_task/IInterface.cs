using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Interface
{
    interface student1
    {
        Student[] createContact(Student[] arr);
    }

    interface student2
    {
        void Update(Student[] array);
    }

    interface student3
    {
        void Delete1(Student[] array);
    }
}
