using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougDogDoorAPP.Models
{
    internal class ViewController
    {
        public static void Controller()
        {
            DogDoor door = DogDoor.GetInstance();
            Remote remote = new Remote(door);
            Dog dog = new Dog("Dog");

            Console.WriteLine($"{dog.GetName()} wants to go outside...\n" +
                $"{dog.Bark()}\n" +
                $"Press remote button(type any key) \n");
            Console.ReadLine();

            Console.WriteLine($"Pressing the remote control button...\n" +
                $"The dog door opens.");
            remote.PressButton();
            Console.WriteLine($"{dog.GetName()} has gone outside...\n");

            //wait 7 seconds so dog can go out
            Thread.Sleep(7000); // Wait for more than the door's auto-close time

            Console.WriteLine($"{dog.GetName()} wants to come back inside...\n" +
                $"{dog.Bark()}\n" +
                $"Press remote button(type any key) \n");
            Console.ReadLine();

            Console.WriteLine("Pressing the remote control button...");
            remote.PressButton();

            Thread.Sleep(5000); // Wait for 5 seconds

            Console.WriteLine($"{dog.GetName()} has come back inside...\n" +
                $"The dog door closes.");
        }

    }
}
