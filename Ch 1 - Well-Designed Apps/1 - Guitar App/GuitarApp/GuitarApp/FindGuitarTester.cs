using System;
using System.Collections.Generic;
using System.Linq;

namespace GuitarApp
{
    public class FindGuitarTester
    {


        public void testErin()
        {
            // Set up Rick's guitar inventory
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            GuitarSpec guitarSpec = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 6);

            List<Guitar> guitars = inventory.search(guitarSpec);
            if (!guitars.Any())
            {
                string msgFail = "Sorry, Erin, we have nothing for you.";
                Console.WriteLine(msgFail);
            }
            else
            {
                string msgSuccess = "Erin, you might like this: \n";
                foreach (Guitar guitar in guitars)
                {
                    msgSuccess = msgSuccess + "- " +
                        guitar.guitarSpec.builder + "\n" + guitar.guitarSpec.model + " " +
                        guitar.guitarSpec.type + " guitar:\n     " +
                        guitar.guitarSpec.backWood + " back and sides,\n   " +
                        guitar.guitarSpec.topWood + " top.\nYou can have it for only $" +
                        guitar.price + "!\n";

                }
                Console.WriteLine(msgSuccess);
            }
            Console.ReadKey();

        }
        private void initializeInventory(Inventory inventory)
        {
            // Add Guitars to the inventory ...
            inventory.addGuitar("V12345", 0, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 6);
            inventory.addGuitar("A21457", 0, Builder.COLLINGS, "OakTown Goove", Type.ACOUSTIC, Wood.BRAZILIAN_ROSEWOOD, Wood.CEDAR, 6);
            inventory.addGuitar("V95693", 1499.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 6);
            inventory.addGuitar("X54321", 0, Builder.MARTIN, "Stratocastor Light", Type.ELECTRIC, Wood.INDIAN_ROSEWOOD, Wood.MAPLE, 6);
            inventory.addGuitar("X99876", 0, Builder.PRS, "Stratocastor FeatherWeight", Type.ELECTRIC, Wood.SITKA, Wood.COCOBOLO, 6);
        }

    }
}