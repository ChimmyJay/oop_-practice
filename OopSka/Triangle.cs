using System;

namespace OopSka
{
    internal class Triangle : Shape
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        protected override SquareCentimeter CalcArea()
        {
            var semiperimeter = (_side1 + _side2 + _side3) / 2;
            var value = Math.Sqrt(
                semiperimeter
                * (semiperimeter - _side1)
                * (semiperimeter - _side2)
                * (semiperimeter - _side3));
            return new SquareCentimeter(value);
        }
    }
}