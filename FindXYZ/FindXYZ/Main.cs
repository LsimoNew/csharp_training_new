using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindXYZ
{
    class Program
    {
        static void Main()
        {
            Point p1 = new Point(1.0, 2.0);
            Point p2 = new Point(-10, 0);
            Console.WriteLine(p1.Matematika(p1, p2));

            p1.X = 1000;
            p1.Y = 100;
            p2.X = 2000;
            p2.Y = 200;
            Console.WriteLine(p1.Matematika(p1, p2));
        }
    }
}
