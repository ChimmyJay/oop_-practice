using System;

namespace OopSka
{
    internal class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        protected override SquareCentimeter CalcArea()
        {
            var value = Math.PI * _radius * _radius;
            return new SquareCentimeter(value);
        }
    }
}