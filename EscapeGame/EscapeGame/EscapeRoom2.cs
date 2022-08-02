using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeGame
{
    internal class EscapeRoom2
    {
        private RoomObject Window;
        private RoomObject Rope;
        private RoomObject BookCase;
        private Room2ExitPoint WinPoint;
        private bool TheEnd; // Bool to end the game
        public EscapeRoom2()
        {
            Window = new RoomObject("window", "It's locked... you consider breaking the glass...");
            Rope = new RoomObject("rope", "You notice a rope hanging from what seems to be a hole in the ceiling....");
            BookCase = new RoomObject("bookcase", "You notice a hole in the wall behind the bookcase...");
            WinPoint = new Room2ExitPoint("3");
            TheEnd = false; // Allows game to loop until final choice is made
        }
        public void InitRoom()
        {
            Console.Title = "Oh boy, here we go again";
            Room2Greeting(); // Calling another greeting method (readability)

            while (!TheEnd) 
            {
                string choice2 = Navigate2();

                switch (choice2) // Choice is made inside the navigation menu 2
                {
                    case "1":
                        Window.DisplayInfo();
                        break;

                    case "2":
                        Rope.DisplayInfo();
                        break;

                    case "3":
                        BookCase.DisplayInfo();
                        break;

                    case "4":
                        bool didWin = WinPoint.AttemptAnotherEscape();
                        TheEnd = true; // Breaks out of the loop structure when a final choice is made to end game
                        break;

                    default:
                        DisplayInvalidEntry();
                        break;
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
        private string Navigate2() // Navigation menu for the second room
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n**************************");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("  1) examine the window\n  2) examine the rope\n  3) examine the bookcase\n  4) attempt to escape");
            string navChoice = Console.ReadLine().Trim();
            Console.WriteLine("**************************\n");
            Console.ResetColor();
            return navChoice;
        }
        private void DisplayInvalidEntry() // If user doesn't enter a valid nav menu entry
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Invalid entry: please enter a number 1 - 4.");
            Console.WriteLine("(press any key to continue)");
            Console.ReadKey(true);
            Console.ResetColor();
        }
        private void Room2Greeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\nWelcome to room 2, good luck!");
            Console.WriteLine("(Press any key to continue)");
            Console.ReadKey(true); // Reads user input to continue when a key is pressed
            Console.ResetColor();
        }
    }
}
