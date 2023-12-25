using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp
{
    internal class Inventory
    {
        private LinkedList<Guitar> guitars;

        public Inventory()
        {
            guitars = new LinkedList<Guitar>();
        }

        public void addGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
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

        public Guitar search(Guitar searchGuitar)
        {
            Guitar matchingGuitar = null;
            foreach (Guitar guitar in guitars)
            {
                // Ignore serial number since that's unique
                // Ignore price since that's unique
                string builder = searchGuitar.builder;
                if ((builder != null) && (!builder.Equals("")) && (!builder.Equals(guitar.builder)))
                {
                    continue;
                }
                string model = searchGuitar.model;
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.model)))
                {
                    continue;
                }
                string type = searchGuitar.type;
                if ((type != null) && (!searchGuitar.Equals("")) && (!type.Equals(guitar.type)))
                {
                    continue;
                }
                string backWood = searchGuitar.backWood;
                if ((backWood != null) && (!backWood.Equals("")) && (!backWood.Equals(guitar.backWood)))
                {
                    continue;
                }
                string topWood = searchGuitar.topWood;
                if ((topWood != null) && (!topWood.Equals("")) && (!topWood.Equals(guitar.topWood)))
                {
                    continue;
                }
                matchingGuitar = guitar;
            }
            return matchingGuitar;
        }
    }
}
