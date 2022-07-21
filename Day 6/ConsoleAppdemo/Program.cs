using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppdemo
{
    class student
    {
        
        public string address;
        public string city;
        public string state;
        public string country;
        public int phoneno;
        public int mobileno;
        public string emailid;
      
        public student(string address, string city, string country, string state,int phoneno, int mobileno, string emailid)
        {
            
            this.address = address;
            this.city = city;
            this.state = state;
            this.country = country;
            this.phoneno = phoneno;
            this.mobileno = mobileno;
            this.emailid = emailid;
        }
        public void displayData()
        {
            Console.WriteLine("Student ="+address);
            Console.WriteLine("Student =" + city);
            Console.WriteLine("Student =" + state);
            Console.WriteLine("Student =" + country);
            Console.WriteLine("Student =" + phoneno);
            Console.WriteLine("Student =" + mobileno);
            Console.WriteLine("Student =" + emailid);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            student s = new student("Utsav Hall", "Pune","India","asfcsa",892,849,"rahul@gmail.com");
            s.displayData();
            Console.ReadKey();
        }
    }
}
