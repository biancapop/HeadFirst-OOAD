using System.Collections.Generic;

namespace GuitarApp
{
    internal class Inventory
    {
        private LinkedList<Guitar> guitars;

        public Inventory()
        {
            guitars = new LinkedList<Guitar>();
        }

        public void addGuitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood, int numString)
        {
            GuitarSpec guitarSpec = new GuitarSpec(builder, model, type, backWood, topWood, numString);
            Guitar guitar = new Guitar(serialNumber, price, guitarSpec);
            guitars.AddLast(guitar);
        }

        public Guitar getGuitar(string serialNumber)
        {
            foreach (Guitar guitar in guitars)
            {
                if (guitar.serialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> search(GuitarSpec searchGuitarSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
                if (guitar.guitarSpec.Matches(searchGuitarSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
