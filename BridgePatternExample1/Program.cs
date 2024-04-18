using System;

namespace BridgePatternExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var redCircle = new Circle(new Red());
            Console.WriteLine(redCircle.ToString());
            //var blueCircle = new Circle(new Blue());

            //var redsquare = new Square(new Red());
            var bluesquare = new Square(new Blue());

            Console.WriteLine(bluesquare.ToString());
        }
    }
}
