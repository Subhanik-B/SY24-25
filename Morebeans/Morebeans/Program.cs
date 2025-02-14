using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morebeans
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static Class1 car(int speed, double toH, int cylinders, int rpm, int horsepower, int cylinderSize)
        {
            Class1 b = new Class1();
            b.rpm = rpm;
            b.maxSpeed = speed;
            b.sizeOfCylinders = cylinderSize;
            b.cylinders = cylinders;
            b.toHundred = toH;

        }
    }
}
