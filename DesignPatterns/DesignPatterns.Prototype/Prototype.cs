using DesignPatterns.Prototype.Prototypes;

namespace DesignPatterns.Prototype
{
    public static class Prototype
    {
        public static void GetResult()
        {
            ConcretePrototype real = new ConcretePrototype(1,2);
            ConcretePrototype copy = (ConcretePrototype)real.Clone();

            Console.WriteLine("Real:");
            Console.WriteLine(real.GetConcretePrototype());
            Console.WriteLine("Copy:");
            Console.WriteLine(copy.GetConcretePrototype());
            Console.WriteLine();

            Console.WriteLine("Copy modified:");
            copy.prop1 = 3;
            copy.prop2 = 4;
            Console.WriteLine("Real:");
            Console.WriteLine(real.GetConcretePrototype());
            Console.WriteLine("Copy:");
            Console.WriteLine(copy.GetConcretePrototype());
        }
    }
}
