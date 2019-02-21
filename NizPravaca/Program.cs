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
            List<double> k = new List<double> { 1.0, -1.0, 2.0 };
            List<double> l = new List<double> { 0.0, 2.0, -3.0 };

            Sjecište(k[0], l[0], k[2], l[2]);
            Sjecište(k[1], l[1], k[2], l[2]);

            Console.ReadKey(true);
        }

        static void Sjecište(double k1, double l1, double k2, double l2)
        {
            if (k1 == k2)
                Console.WriteLine("Pravci su paralelni");
            else
            {
                double x = (l2 - l1) / (k1 - k2);
                double y = k1 * x + l1;
                Console.WriteLine($"Sjecište: ({x}, {y})");
            }
        }
    }
}
