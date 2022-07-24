using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Interface
{
    interface IStudent
    {
        int SNO
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        string City
        {
            get;
            set;
        }

        int TotalMarks
        {
            get;
            set;
        }

        void Display();
    }
}