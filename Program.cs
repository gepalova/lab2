using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            Circle c = new Circle(10.10101, 15.15151, 5.54545);
            Console.WriteLine("It is your circle");
            c.ShowCircle();
            Console.ReadKey();
        }
    }
}