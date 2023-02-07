using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Among Us!");
            Console.WriteLine("The game starts, which role are you?");
            Console.WriteLine("Enter 'crewmate' or 'impostor':");

            string role = Console.ReadLine();

            if (role == "crewmate")
            {
                Console.WriteLine("You only have two tasks to do, which one do you choose?");
                Console.WriteLine("Enter 'keycard' or 'fuel':");

                string choice = Console.ReadLine();

                if (choice == "keycard")
                {
                    Console.WriteLine("You go to admin and swipe your keycard first try!");
                }
                else if (choice == "fuel")
                {
                    Console.WriteLine("You refill the jerry can, and go to fuel the engines.");
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
            }
            else if (role == "impostor")
            {
                Console.WriteLine("You can choose someone to follow, who do you choose?");
                Console.WriteLine("Enter 'yellow' or 'blue':");

                string choice = Console.ReadLine();

                if (choice == "yellow")
                {
                    Console.WriteLine("You follow yellow, but they stay around a group and you can't get a kill.");
                }
                else if (choice == "blue")
                {
                    Console.WriteLine("You followed blue and they went to communications. You get the kill and run away!");
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
            Console.WriteLine("Thanks for playing Among Us!");
            Console.ReadLine();
        }
    }
}
