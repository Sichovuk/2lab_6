using System;

namespace _2lab_6
{
    public class Trapezium : Shape
    {
        public double UpBasis { get; set; }
        public double DownBasis { get; set; }
        public double Height { get; set; }

        public Trapezium(double upBasis, double downBasis, double height)
        {
            UpBasis = upBasis;
            DownBasis = downBasis;
            Height = height;
        }

        public override double GetArea()
        {
            return 0.5 * (UpBasis + DownBasis) * Height;
        }
    }
}

