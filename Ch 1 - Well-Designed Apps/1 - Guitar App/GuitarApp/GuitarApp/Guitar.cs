namespace GuitarApp
{
    internal class Guitar
    {
        public string serialNumber { get; }
        public double price { get; }
        public GuitarSpec guitarSpec { get; }

        public Guitar(string serialNumber, double price, GuitarSpec guitarSpec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.guitarSpec = guitarSpec;
        }
    }
}
