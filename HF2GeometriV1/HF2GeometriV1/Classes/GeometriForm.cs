using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF2GeometriV1.Classes
{
    public abstract class GeometriForm
    {
        protected int sideA;
        protected int sideB;
        protected int sideC;
        protected int sideD;

        public int SideA { get { return this.sideA; }  }
        public int SideB { get { return this.sideB; } }
        public int SideC { get { return this.sideC; } }
        public int SideD { get { return this.sideB; } }

        public GeometriForm(int a)
        {
            this.sideA = a;
            this.sideB = a;
        }
        public abstract double GetPerimiter();
        public abstract double GetArea();
    }
}
