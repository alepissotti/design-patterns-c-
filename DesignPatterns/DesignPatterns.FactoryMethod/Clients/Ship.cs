using DesignPatterns.Products;

namespace DesignPatterns.Clients
{
    internal class Ship : Transport
    {
        public override IDelivery GetDelivery()
        {
            return new ShipDelivery();
        }
    }
}
