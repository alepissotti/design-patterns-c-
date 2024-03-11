using DesignPatterns.AbstractFactory.Products.AbstractProducts;

namespace DesignPatterns.AbstractFactory.Factories
{
    public abstract class LivingFactory
    {
        public abstract ISofa CreateSofa();
        public abstract IChair CreateChair();

        public string GetLiving()
        {
            ISofa sofa = CreateSofa();
            IChair chair = CreateChair();

            return $"{sofa.GetSofa()} - {chair.GetChair()}";
        }

    }
}
