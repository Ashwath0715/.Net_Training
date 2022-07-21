using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatoroverloading
{
    class Volume
    {
        double length;   
        double breadth;  
        double height;   

        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double l)
        {
            length = l;
        }
        public void setBreadth(double b)
        {
            breadth = b;
        }
        public void setHeight(double h)
        {
            height = h;
        }

        public static Volume operator +(Volume a, Volume c)
        {
            Volume v = new Volume();
            v.length = a.length + c.length;
            v.breadth = a.breadth + c.breadth;
            v.height = a.height + c.height;
            return v;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Volume v1 = new Volume();   
            double volume = 0;    

            v1.setLength(8);
            v1.setBreadth(6);
            v1.setHeight(3);
           
            volume = v1.getVolume();
            Console.WriteLine("Volume of rectangle : {0}", volume);
        }
    }
}
