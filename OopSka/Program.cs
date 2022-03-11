namespace OopSka
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(sideLength: 5);
            var triangle = new Triangle(side1: 5, side2: 5, side3: 5);
            var circle = new Circle(radius: 5);

            square.PrintArea();
            triangle.PrintArea();
            circle.PrintArea();
        }
    }
}