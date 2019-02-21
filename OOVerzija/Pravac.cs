using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOVerzija
{
    class Pravac
    {
        public Pravac(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public Točka[] Sjecišta(Pravac p)
        {
            if (a == p.a)
                return new Točka[] { };
            double x = (p.b - b) / (a - p.a);
            double y = a * x + b;
            return new Točka[] { new Točka(x, y) };
        }

        public static IEnumerable<Točka> operator /(Pravac p1, Pravac p2)
        {
            return p1.Sjecišta(p2);
        }

        private double a;
        private double b;
    }
}
