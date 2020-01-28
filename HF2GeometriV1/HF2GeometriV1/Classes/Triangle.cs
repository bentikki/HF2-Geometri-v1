using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF2GeometriV1.Classes
{
    class Triangle : GeometriForm
    {
        public Triangle(int a, int b, int c) : base(a)
        {
            this.sideB = b;
            this.sideC = c;
        }

        public override double GetArea()
        {
            return 0.5 * sideA * sideB;
        }

        public override double GetPerimiter()
        {
            return sideA + sideB + sideC;
        }
    }
}
