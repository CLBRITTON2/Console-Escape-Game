using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeGame
{
    class RoomObject //Creates the RoomObject class with 2 data members: name and description
    {
        private string Name;
        private string Description;
        public RoomObject(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public void DisplayInfo() // Prints the info about each room object
        {
            Console.ForegroundColor = ConsoleColor.Blue; // Sets all object interaction color to blue

            Console.WriteLine($"You examine the {Name}...");
            Thread.Sleep(2000); // Adds a 2 second delay between examining the object and returning description
            Console.WriteLine(Description);
            Console.WriteLine("(Press any key to continue)");
            Console.ReadKey(true);

            Console.ResetColor(); // Resets console color after you examine an object
        }
    }
}
