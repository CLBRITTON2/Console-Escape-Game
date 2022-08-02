using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeGame
{
    class EscapeRoom
    {
        private RoomObject Ladder;
        private RoomObject BriefCase;
        private RoomObject Desk;
        private RoomObject Bottle;
        private Door LockedDoor;
        private bool HasEscaped;
        public EscapeRoom() // Constructs the objects found in the escape room
        {
          Ladder = new RoomObject("ladder", "You notice it has three rails. You're unsure if it's significant...");
          BriefCase = new RoomObject("briefcase", "The briefcase has the word \"wise\" printed on the outside in gold.");
          Desk = new RoomObject("desk", "You don't seem to find anything of value inside or around the desk.");
          Bottle = new RoomObject("bottle", "You find a small note inside the bottle that contains the word \"men\" with a picture of a star");
          LockedDoor = new Door("three wise men");
          HasEscaped = false;
        }
        public void InitRoom()
        {
            Console.Title = "How fast can you escape?";

            Room1Greeting(); //Calls the Room1Greeting method (for readability)

            while (!HasEscaped) // Loop that runs while user has not escaped
            {
                string choice = Navigate(); // Calls the navigation method to bring up nav menu and passes choice

                switch (choice) // Comes from the navigation method
                {
                    case "1":
                        Ladder.DisplayInfo();
                        break;

                    case "2":
                        BriefCase.DisplayInfo();
                        break;

                    case "3":
                        Desk.DisplayInfo();
                        break;

                    case "4":
                        Bottle.DisplayInfo();
                        break;

                    case "5":
                        bool wasSuccessful = LockedDoor.AttemptEscape();
                        HasEscaped = wasSuccessful; // Breaks out of the loop structure because user escaped
                        break;

                    default:
                        DisplayInvalidEntry();
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nGood work! Make your way to the next room...");
            Console.ResetColor();

            Console.WriteLine("(Press any key to continue)\n");
            Console.ReadKey(true);
        }
        private void DisplayInvalidEntry() // Method to print error message for the nav menu
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Invalid entry: please enter a number 1 - 5.");
            Console.WriteLine("(press any key to continue)");
            Console.ReadKey(true);
            Console.ResetColor();
        }
        private string Navigate()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n**************************");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("  1) examine the ladder\n  2) examine the briefcase\n  3) examine the desk\n  4) examine the bottle\n  5) attempt to escape");
            string navChoice = Console.ReadLine().Trim();
            Console.WriteLine("**************************\n");
            Console.ResetColor();
            return navChoice;

        }
        private void Room1Greeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Welcome to room 1, good luck!");
            Console.WriteLine("(Press any key to continue)");
            Console.ReadKey(true); // Reads user input to continue when a key is pressed
            Console.ResetColor();
        }
    }
}
