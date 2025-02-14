using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morebeans
{
    internal class Class1
    {
        public String name {  get; set; }
        public int maxSpeed { get; set; }
        public double toHundred { get; set; }
        public int cylinders { get; set; }
        public int rpm { get; set; }
        public int horsepower { get; set; }
        public int sizeOfCylinders { get; set; }

        public Class1(string name, int maxspeed, double zerotosixty, int hp, int cc, int cylinders, int rpm)
        {
            this.name = name;
            this.maxSpeed = maxspeed;
            this.toHundred = zerotosixty;
            this.horsepower = hp;
            this.sizeOfCylinders = cc;
            this.cylinders = cylinders;
            this.rpm = rpm;
        }
    }
}
