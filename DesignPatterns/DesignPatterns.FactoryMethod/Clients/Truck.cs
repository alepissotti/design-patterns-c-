using DesignPatterns.Products;

namespace DesignPatterns.Clients
{
    public class Truck : Transport
    {
        public override IDelivery GetDelivery()
        {
            return new TruckDelivery();
        }
    }
}
