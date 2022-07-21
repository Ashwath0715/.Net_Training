using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Details
    {
        public string processor { get; set; }
        public string SSD { get; set; }

        public string getDetails()
        {
            return "processor is " + processor + " SSD is" + SSD;
        }
    }

    public class Student : Details
    {
        public string Laptopid { get; set; }
    }
    public class Client :Details
    {
        public string Subject { get; set; }
    }
}
