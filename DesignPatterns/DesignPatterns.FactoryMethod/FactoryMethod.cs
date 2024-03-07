using DesignPatterns.Clients;

namespace DesignPatterns.FactoryMethod
{
    public static class FactoryMethod
    {
        public static void GetResult() {
            
            Truck truck = new Truck();
            Ship ship = new Ship();

            Console.WriteLine("Factory Method:");
            Console.WriteLine(truck.SendDelivery());
            Console.WriteLine(ship.SendDelivery());
        }
    }
}
