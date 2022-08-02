using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeGame
{
    internal class Door
    {
        private string PassWord;

        public Door (string passWord)
        {
            PassWord = passWord;
        }
        public bool AttemptEscape()
        {
            GuessThePassword(); // Calls method to prompt user to guess the password
            string playerGuess = Console.ReadLine().ToLower().Trim(); // removes the white space from players guess and converts it to lower case

            Thread.Sleep(2000); // 2 second delay

            if (playerGuess == PassWord)
            {
                LockColor(ConsoleColor.Green, "\nThe guard unlocks the door allowing you to pass to the next room...");
            }
            else
            {
                LockColor(ConsoleColor.Red, "\nThe guard doesn't unlock the door...");
                Thread.Sleep(2000); // 2 second delay
                Console.WriteLine("\nMaybe you should have another look around the room...");

            }
            Console.WriteLine("(press any key to continue)");
            Console.ReadKey(true);
            return playerGuess == PassWord; // 2 lines above will execute regardless of playerGuess being T or F
        }
        private void LockColor(ConsoleColor color, string message) // Method to set the color of the guards action
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
        private void GuessThePassword()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("You attempt to open the door...");
            Thread.Sleep(2000); // 2 second delay between attempt and result
            Console.WriteLine("A guard refuses to unlock the door until you guess the password.");
            Console.WriteLine(); // Spacer
            Console.Write("Please enter the password: ");
            Console.ResetColor();
        }
    }
}
