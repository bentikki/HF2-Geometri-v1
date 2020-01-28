using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF2GeometriV1.Classes
{
    class Parallelogram : GeometriForm
    {
        private int sideV;

        public Parallelogram(int a, int b, int v) : base(a)
        {
            this.sideB = b;
            this.sideV = v;
        }

        public override double GetArea()
        {
            double sin = Math.Sin(DegreeToRadian(sideV));
            double areaInt = this.sideA * sideB * sin;
            return areaInt;
        }

        public override double GetPerimiter()
        {
            double perimeter = (2 * this.sideA) + (2 * this.sideB);
            return perimeter;
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }


    }
}
