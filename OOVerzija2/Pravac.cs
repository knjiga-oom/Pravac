using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOVerzija2
{
    class Pravac
    {
        public Pravac(double k, double l)
        {
            a = k;
            b = -1;
            c = l;
        }

        public Pravac(double a, double b, double c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Točka[] Sjecišta(Pravac p)
        {
            double nazivnik = a * p.b - p.a * b;
            if (nazivnik == 0)
                return new Točka[] { };
            double x = (b * p.c - p.b * c) / nazivnik;
            double y = (p.a * c - a * p.c) / nazivnik;
            return new Točka[] { new Točka(x, y) };
        }

        public static Točka[] operator /(Pravac p1, Pravac p2)
        {
            return p1.Sjecišta(p2);
        }

        private double a;
        private double b;
        private double c;
    }
}
