namespace OopSka
{
    internal class Square : Shape
    {
        private readonly double _sideLength;

        public Square(double sideLength)
        {
            _sideLength = sideLength;
        }

        protected override SquareCentimeter CalcArea()
        {
            var value = _sideLength * _sideLength;
            return new SquareCentimeter(value);
        }
    }
}