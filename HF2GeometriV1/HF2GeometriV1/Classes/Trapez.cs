using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF2GeometriV1.Classes
{
    class Trapez : GeometriForm
    {

        public Trapez(int a, int b, int c, int d) : base(a)
        {
            this.sideB = b;
            this.sideC = c;
            this.sideD = d;
        }

        public override double GetArea()
        {
            double area;
            //double eith = s * (s - sideA + sideC) * (s - sideB) * (s - sideD);
            //double h0 = sideA - sideC;
            //double h1 = 2 / h0;
            //double h2 = Math.Sqrt(eith);
            //double h = h1 * h2;
            //area = 0.5 * h0 * h;

            double s = (sideA + sideB - sideC + sideD) / 2;
            double h = 2 / (sideA - sideC) * Math.Sqrt( s * ( s - sideA + sideC ) * (s - sideB) * (s - sideD) );
            area = 0.5 * (sideA - sideC) * h;

            return area;
        }

        public override double GetPerimiter()
        {
            return sideA + sideB + sideC + sideC;
        }
    }
}
