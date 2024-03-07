using DesignPatterns.Products;

namespace DesignPatterns.Clients
{
    public abstract class Transport
    {
        public abstract IDelivery GetDelivery();

        public string SendDelivery()
        {
            IDelivery delivery = GetDelivery();

            return delivery.Deliver();
        }
    }
}
