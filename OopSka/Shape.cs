using System;

namespace OopSka
{
    internal abstract class Shape
    {
        protected abstract SquareCentimeter CalcArea();

        public SquareCentimeter GetArea()
        {
            return CalcArea();
        }

        public void PrintArea()
        {
            Console.WriteLine(GetArea().Value);
        }
    }
}