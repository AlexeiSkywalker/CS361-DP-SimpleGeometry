using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public class Square : Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            if (side <= 0)
                throw new ArgumentOutOfRangeException();
            Side = side;
        }

        public override string Print()
        {
            return String.Format($"Square: radius = {Side}, area = {this.GetArea()}");
        }
        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
