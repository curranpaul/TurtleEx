using Microsoft.VisualStudio.TestTools.UnitTesting;
using turtleEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turtleEx.src.models;

namespace turtleEx.Tests
{
    [TestClass()]
    public class GameTests
    {

        private static GameSettings settings;
        private static Turtle turtle;
        private static Game game;
        private static Moves moves;

        [ClassInitialize]
        public static void Initialise(TestContext tc)
        {
            settings = new GameSettings();
            settings.Direction = EDirection.North;
            settings.BoardSize = new Coordinate(5, 4);
            settings.ExitPoint = new Coordinate(4, 2);
            settings.StartingPoint = new Coordinate(0, 1);
            settings.Mines = new List<Square>();
            settings.Mines.Add(new Square(1, 1));
            settings.Mines.Add(new Square(3, 1));
            settings.Mines.Add(new Square(3, 3));

            moves = new Moves("mmrmrmrrrmmrmmmrrrmrrrm");

            game = new Game(settings, moves);

        }

        [TestMethod()]
        public void TestForMineHit()
        {
            
        }


        [TestMethod()]
        public void TestForExitHit()
        {

        }


        [TestMethod()]
        public void TestForAllMovesCompleted()
        {

        }
    }
}