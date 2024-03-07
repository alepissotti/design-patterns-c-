namespace DesignPatterns.Products
{
    public class ShipDelivery : IDelivery
    {
        public string Deliver()
        {
            return "Orders send by Ship";
        }
    }
}
