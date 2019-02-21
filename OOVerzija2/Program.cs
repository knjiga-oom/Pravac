using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOVerzija2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pravac p1 = new Pravac(1, 0);
            Pravac p2 = new Pravac(-1, 2);

            var sjecišta = p1.Sjecišta(p2);
            if (sjecišta.Length == 0)
                Console.WriteLine("Pravci su paralelni");
            else
            {
                Točka s = sjecišta[0];
                Console.WriteLine($"Sjecište: ({s.x}, {s.y})");
            }

            Pravac p3 = new Pravac(2, -3);
            sjecišta = p1.Sjecišta(p3);
            if (sjecišta.Length == 0)
                Console.WriteLine("Pravci su paralelni");
            else
            {
                Točka s = sjecišta[0];
                Console.WriteLine($"Sjecište: ({s.x}, {s.y})");
            }

            Console.ReadKey(true);
        }
    }
}
