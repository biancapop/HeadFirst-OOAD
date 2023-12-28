using System;

namespace DougDogDoors
{
    internal class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();

            Console.WriteLine("\nFido has gone outside...");
            remote.PressButton();

            Console.WriteLine("\nFido's all done...");
            remote.PressButton();

            Console.WriteLine("\nFido's back inside...");
            remote.PressButton();

            Console.ReadLine();
        }
    }
}
