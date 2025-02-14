using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Morebeans;

namespace Morebeans
{
    internal class Program
    {
        Class1 car1 = car("Banana Car",550,2.2,6,350,1000,5);
        Class1 car2 = car("Apple Car", 550, 2.2, 6, 350, 1000, 5);
        Class1 car3 = car("Orange Car", 550, 2.2, 6, 350, 1000, 5);
        Class1 car4 = car("Grape Car", 550, 2.2, 6, 350, 1000, 5);
        Class1 car5 = car("Cherry Car", 250, 3.5, 4, 350, 368, 8);
        static void Main(string[] args)
        {
            
        }

        static Class1 car(String name, int speed, double toH, int cylinders, int rpm, int horsepower, int cylinderSize)
        {
            Class1 b = new Class1();
            b.name = name;
            b.rpm = rpm;
            b.maxSpeed = speed;
            b.sizeOfCylinders = cylinderSize;
            b.cylinders = cylinders;
            b.toHundred = toH;
            return b;
        }
        public override string ToString()
        {
            return "";
        }
    }
    
}
