using System;

namespace BridgePatternExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Abstraction(new ImplementationA()).Operation());

            var impA = new ImplementationA();

            var absA = new Abstraction(impA);
            absA.Operation();

            Console.WriteLine(new Abstraction(new ImplementationB()).Operation());
        }
    }
}
