using DesignPatterns.AbstractFactory.Products.AbstractProducts;

namespace DesignPatterns.AbstractFactory.Products.ConcreteProducts
{
    public class MinimalistSofa : ISofa
    {
        public string GetSofa()
        {
            return "Minimalist Sofa";
        }
    }
}
