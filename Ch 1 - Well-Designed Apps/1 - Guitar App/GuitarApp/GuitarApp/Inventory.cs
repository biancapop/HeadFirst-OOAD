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

        public void addGuitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
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

        public List<Guitar> search(Guitar searchGuitar)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
                // Ignore serial number since that's unique
                // Ignore price since that's unique
                Builder builder = searchGuitar.builder;
                if (!builder.Equals(guitar.builder))
                {
                    continue;
                }
                string model = searchGuitar.model.ToLower();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.model.ToLower())))
                {
                    continue;
                }
                Type type = searchGuitar.type;
                if (!type.Equals(guitar.type))
                {
                    continue;
                }
                Wood backWood = searchGuitar.backWood;
                if (!backWood.Equals(guitar.backWood))
                {
                    continue;
                }
                Wood topWood = searchGuitar.topWood;
                if (!topWood.Equals(guitar.topWood))
                {
                    continue;
                }
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
