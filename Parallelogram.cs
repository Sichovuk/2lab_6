using System;

namespace _2lab_6
{
    public class Parallelogram : Shape
    {
        public double Basis { get; set; }
        public double Height { get; set; }

        public Parallelogram(double basis, double height)
        {
            Basis = basis;
            Height = height;
        }

        public override double GetArea()
        {
            return Basis * Height;
        }
    }
}
