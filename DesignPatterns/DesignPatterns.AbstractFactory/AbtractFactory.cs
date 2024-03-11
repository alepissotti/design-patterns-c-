using DesignPatterns.AbstractFactory.Factories;

namespace DesignPatterns.AbstractFactory
{
    public static class AbtractFactory
    {
        public static void GetResult()
        {
            ModernLivingFactory modernLiving = new ModernLivingFactory();
            MinimalistLivingFactory minimalistLivingFactory = new MinimalistLivingFactory();

            Console.WriteLine("Modern:");
            Console.WriteLine(modernLiving.GetLiving());
            Console.WriteLine("Minimal:");
            Console.WriteLine(minimalistLivingFactory.GetLiving());
        }
    }
}
