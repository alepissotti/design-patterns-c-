using DesignPatterns.AbstractFactory.Products.AbstractProducts;

namespace DesignPatterns.AbstractFactory.Products.ConcreteProducts
{
    public class MinimalistChair : IChair
    {
        public string GetChair()
        {
            return "Minimalist Chair";
        }
    }
}
