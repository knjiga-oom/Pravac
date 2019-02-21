using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaVerzija
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 4)
            {
                Console.WriteLine("Nespravan broj argumenata");
                return;
            }
            try
            {
                double k1 = double.Parse(args[0]);
                double l1 = double.Parse(args[1]);
                double k2 = double.Parse(args[2]);
                double l2 = double.Parse(args[3]);

                if (k1 == k2)
                    Console.WriteLine("Pravci su paralelni");
                else
                {
                    double x = (l2 - l1) / (k1 - k2);
                    double y = k1 * x + l1;
                    Console.WriteLine($"Sjecište: ({x}, {y})");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Nespravan upis");
            }

            Console.ReadKey(true);
        }
    }
}
