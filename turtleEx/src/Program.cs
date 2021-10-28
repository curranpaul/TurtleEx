using System;

namespace turtleEx
{
    class Program
    {
        private static Game game;
        static void Main(string[] args)
        {
             try
            {
                var gameSettings = Utilities.ReadJsonGameData(args[0]);
                var moves = Utilities.ReadListOfMoves(args[1]);
                game = new Game(gameSettings, moves);
                game.Play();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Error reading imnput files");
                Console.WriteLine("run command is: TurtleEx <game-settings.json> <movesList.txt> ");

            }
            Console.WriteLine("Game over - press any key to exit");
            Console.ReadKey();

        }
    }
}
