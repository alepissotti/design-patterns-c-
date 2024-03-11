using DesignPatterns.AbstractFactory.Products.AbstractProducts;

namespace DesignPatterns.AbstractFactory.Products.ConcreteProducts
{
    public class ModernChair : IChair
    {
        public string GetChair()
        {
            return "Modern Chair";
        }
    }
}
