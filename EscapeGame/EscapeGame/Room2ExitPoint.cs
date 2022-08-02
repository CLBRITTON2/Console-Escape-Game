using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeGame
{
    internal class Room2ExitPoint
    {
        private string FinalChoice;
        public Room2ExitPoint(string finalChoice)
        {
            FinalChoice = finalChoice;
        }
        public bool AttemptAnotherEscape()
        {
            FinalChoiceMenu();
            string playerChoice = Console.ReadLine().Trim();

            Thread.Sleep(2000); // 2 sec pause between user input and displaying results

            if (playerChoice == "1")
            {
                BreaksGlass();
            }
            else if (playerChoice == "2")
            {
                ClimbsRope();
            }
            else if (playerChoice == "3")
            {
                MovesBookcase();
            }
            else
            {
                Console.WriteLine("Please enter a valid number 1 - 3");
            }

            return playerChoice == FinalChoice;

        }
        private void WinLoseColor(ConsoleColor color, string message) // Method to set the color of the Win or Lose message
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
        private void BreaksGlass() // Method to print results of user breaking the glass. ActionResult and WinLose just change colors.
        {
            ActionResult(ConsoleColor.Red, "\nYou break the glass... You are apprehended by the digital escape room employees and must pay for the digital window...");
            Thread.Sleep(2000); // 2 sec pause
            WinLoseColor(ConsoleColor.Red, "\nYOU LOSE!");
        }
        private void ClimbsRope() // Method to print results of user climbing the rope. ActionResult and WinLose just change colors.
        {
            ActionResult(ConsoleColor.Red, "\nYou attempt to climb the rope... but the rope snaps and you fall injuring your leg. You're unable to continue...");
            Thread.Sleep(2000); // 2 sec pause
            WinLoseColor(ConsoleColor.Red, "\nYOU LOSE!");
        }
        private void MovesBookcase() // Method to print results of user moving the bookcase. ActionResult and WinLose just change colors.
        {
            ActionResult(ConsoleColor.Green, "\nYou push the bookcase off to the side and enter the hole in the wall which leads to an exit sign...");
            Thread.Sleep(2000);// 2 sec pause
            WinLoseColor(ConsoleColor.Green, "\nYOU WIN!");
        }
        private void FinalChoiceMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write("Well... the choice is yours... how will you escape?");
            Console.WriteLine(); // Spacer
            Console.WriteLine("\n  1) the window\n  2) the rope\n  3) the bookcase");
            Console.ResetColor();
        }
        private void ActionResult(ConsoleColor color, string message) // Method to set the color of the guards action
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
