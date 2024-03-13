namespace DesignPatterns.Prototype.Prototypes
{
    public class ConcretePrototype : IPrototype
    {
        public int prop1 { get; set; }
        public int prop2 { get; set; }

        public ConcretePrototype(int prop1, int prop2)
        {
            this.prop1 = prop1;
            this.prop2 = prop2;
        }

        public IPrototype Clone()
        {
            return MemberwiseClone() as IPrototype;
        }

        public string GetConcretePrototype()
        {
            return $"Concrete prototype: prop1 = {prop1}, prop2 = {prop2}";
        }
    }
}
