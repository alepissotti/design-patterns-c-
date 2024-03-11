using DesignPatterns.AbstractFactory.Products.AbstractProducts;
using DesignPatterns.AbstractFactory.Products.ConcreteProducts;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class ModernLivingFactory : LivingFactory
    {
        public override IChair CreateChair()
        {
            return new ModernChair();
        }

        public override ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
