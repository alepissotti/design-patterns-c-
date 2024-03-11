using DesignPatterns.AbstractFactory.Products.AbstractProducts;
using DesignPatterns.AbstractFactory.Products.ConcreteProducts;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class MinimalistLivingFactory : LivingFactory
    {
        public override IChair CreateChair()
        {
            return new MinimalistChair();
        }

        public override ISofa CreateSofa()
        {
            return new MinimalistSofa();
        }
    }
}
