using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOVerzija
{
    class Pravac
    {
        public Pravac(double k, double l)
        {
            this.k = k;
            this.l = l;
        }

        public Točka[] Sjecišta(Pravac p)
        {
            if (k == p.k)
                return new Točka[] { };
            double x = (p.l - l) / (k - p.k);
            double y = k * x + l;
            return new Točka[] { new Točka(x, y) };
        }

        public static IEnumerable<Točka> operator /(Pravac p1, Pravac p2)
        {
            return p1.Sjecišta(p2);
        }

        private double k;
        private double l;
    }
}
