using DesignPatterns.AbstractFactory.Products.AbstractProducts;

namespace DesignPatterns.AbstractFactory.Products.ConcreteProducts
{
    public class ModernSofa : ISofa
    {
        public string GetSofa()
        {
            return "Modern Sofa";
        }
    }
}
