using System;

namespace GuitarApp
{
    public class FindGuitarTester
    {

        public static void testErin()
        {
            // Set up Rick's guitar inventory
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Guitar whatErinLikes = new Guitar("", 0, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            Guitar guitar = inventory.search(whatErinLikes);
            if (guitar != null)
            {
                string msgSuccess = "Erin, you might like this " +
                    guitar.builder + " " + guitar.model + " " +
                    guitar.type + " guitar:\n     " +
                    guitar.backWood + " back and sides,\n   " +
                    guitar.topWood + " top.\nYou can have it for only $" +
                    guitar.price + "!";

                Console.WriteLine(msgSuccess);
                Console.ReadKey();
            }
            else
            {
                string msgFail = "Sorry, Erin, we have nothing for you.";
                Console.WriteLine(msgFail);
                Console.ReadKey();
            }
        }
        private static void initializeInventory(Inventory inventory)
        {
            // Add Guitars to the inventory ...
            inventory.addGuitar("V12345", 0, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ADIRONDACK);
            inventory.addGuitar("A21457", 0, Builder.COLLINGS, "OakTown Goove", Type.ACOUSTIC, Wood.BRAZILIAN_ROSEWOOD, Wood.CEDAR);
            inventory.addGuitar("V95693", 1499.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventory.addGuitar("X54321", 0, Builder.MARTIN, "Stratocastor Light", Type.ELECTRIC, Wood.INDIAN_ROSEWOOD, Wood.MAPLE);
            inventory.addGuitar("X99876", 0, Builder.PRS, "Stratocastor FeatherWeight", Type.ELECTRIC, Wood.SITKA, Wood.COCOBOLO);
        }

    }
}