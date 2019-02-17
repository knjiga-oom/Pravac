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
                double a1 = double.Parse(args[0]);
                double b1 = double.Parse(args[1]);
                double a2 = double.Parse(args[2]);
                double b2 = double.Parse(args[3]);

                if (a1 == a2)
                {
                    if (b1 == b2)
                        Console.WriteLine("Pravci se podudaraju");
                    else
                        Console.WriteLine("Pravci su paralelni");
                }
                else
                {
                    double x = (b2 - b1) / (a1 - a2);
                    double y = a1 * x + b1;
                    Console.WriteLine($"Presjecište: ({x}, {y})");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Nespravan upis");
            }
        }
    }
}
