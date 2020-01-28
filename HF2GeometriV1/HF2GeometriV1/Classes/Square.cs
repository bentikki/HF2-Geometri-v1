using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF2GeometriV1.Classes
{
    class Square : GeometriForm
    {
        public Square(int a) : base(a)
        {
        }

        public override double GetPerimiter()
        {
            double perimeter = 4 * this.sideA;
            return perimeter;
        }

        public override double GetArea()
        {
            double area = this.sideA * this.sideA;
            return area;
        }

    }
}
