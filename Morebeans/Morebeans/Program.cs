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
        
        static void Main(string[] args)
        {
            Class1 car1 = new Class1("Banana Car", 550, 2.2, 6, 350, 1000, 5);
            Class1 car2 = new Class1("Apple Car", 550, 2.2, 6, 350, 1000, 5);
            Class1 car3 = new Class1("Orange Car", 550, 2.2, 6, 350, 1000, 5);
            Class1 car4 = new Class1("Grape Car", 550, 2.2, 6, 350, 1000, 5);
            Class1 car5 = new Class1("Cherry Car", 250, 3.5, 4, 350, 368, 8);
        }

        public override string ToString()
        {
            return "";
        }
    }
    
}
