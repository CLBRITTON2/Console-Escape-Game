namespace EscapeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO make a public (press any key to continue) function to clean up code - all classes

            EscapeRoom theRoom = new EscapeRoom();

            theRoom.InitRoom();

            EscapeRoom2 nextRoom = new EscapeRoom2();

            nextRoom.InitRoom();
        }
    }
}