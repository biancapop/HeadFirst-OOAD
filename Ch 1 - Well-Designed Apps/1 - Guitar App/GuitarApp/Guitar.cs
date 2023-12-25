namespace GuitarApp
{
    internal class Guitar
    {
        public string serialNumber { get; }
        public string builder { get; }
        public string model { get; }
        public string type { get; }
        public string backWood { get; }
        public string topWood { get; }
        public double price { get; }

        public Guitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
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
