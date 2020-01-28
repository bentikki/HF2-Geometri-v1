using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF2GeometriV1.Classes
{
    class Rectangular : GeometriForm
    {
        public Rectangular(int a, int b) : base(a)
        {
            this.sideB = b;
        }

        public override double GetPerimiter()
        {
            double perimeter = (2 * this.sideA) + (2 * this.sideB);
            return perimeter;
        }
        public override double GetArea()
        {
            return this.sideB * this.sideA;
        }
    }
}
