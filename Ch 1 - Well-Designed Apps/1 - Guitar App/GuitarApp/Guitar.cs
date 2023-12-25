namespace GuitarApp
{
    internal class Guitar
    {
        public string serialNumber { get; }
        public Builder builder { get; }
        public string model { get; }
        public Type type { get; }
        public Wood backWood { get; }
        public Wood topWood { get; }
        public double price { get; }

        public Guitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
            this.price = price;
        }
    }
}
