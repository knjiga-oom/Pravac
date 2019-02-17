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

        public IEnumerable<Točka> Presjecište(Pravac p)
        {
            List<Točka> rezultat = new List<Točka>();
            if (a != p.a)
            {
                double x = (p.b - b) / (a - p.a);
                double y = a * x + b;
                rezultat.Add(new Točka(x, y));
            }
            return rezultat;
        }

        private double a;
        private double b;
    }
}
