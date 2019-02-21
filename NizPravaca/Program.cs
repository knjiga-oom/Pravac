using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NizPravaca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> a = new List<double> { 1.0, -1.0, 2.0 };
            List<double> b = new List<double> { 0.0, 2.0, -3.0 };

            Sjecište(a[0], b[0], a[2], b[2]);
        }

        static void Sjecište(double a1, double b1, double a2, double b2)
        {
            if (a1 == a2)
                Console.WriteLine("Pravci su paralelni");
            else
            {
                double x = (b2 - b1) / (a1 - a2);
                double y = a1 * x + b1;
                Console.WriteLine($"Presjecište: ({x}, {y})");
            }
        }
    }
}
