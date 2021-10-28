using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace turtleEx.Tests
{
    [TestClass()]
    public class TurtleTests
    {

        private static GameSettings settings;
        private static Turtle turtle;

        [ClassInitialize]
        public static void Initialise( TestContext tc)
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

            
        }

        [TestMethod()]
        public void ToStringTest_ReturnsInitialPosition()
        {
            turtle = new Turtle(settings.StartingPoint, settings.Direction, settings.BoardSize);
            string expected = "Dir: North position: [0,1]";
            string target = turtle.ToString();
            Assert.AreEqual(expected, target );
        }


        [TestMethod()]
        public void TurnTest_FullyRotates()
        {
            turtle = new Turtle(settings.StartingPoint, settings.Direction, settings.BoardSize);
            turtle.Turn();
            Assert.AreEqual("Dir: East position: [0,1]", turtle.ToString());
            turtle.Turn();
            Assert.AreEqual("Dir: South position: [0,1]", turtle.ToString());
            turtle.Turn();
            Assert.AreEqual("Dir: West position: [0,1]", turtle.ToString());
            turtle.Turn();
            Assert.AreEqual("Dir: North position: [0,1]", turtle.ToString());
            turtle.Turn();
            Assert.AreEqual("Dir: East position: [0,1]", turtle.ToString());
        }

        [TestMethod()]
        public void NewPositionTest()
        {
            turtle = new Turtle(settings.StartingPoint, settings.Direction, settings.BoardSize);
            MoveableCoordinate pos = turtle.NewPosition();
            // move up to fiorst row
            Assert.AreEqual( 0, pos.Y);
            //Try to move up again - out of bounts
            pos = turtle.NewPosition();
            turtle.MoveTo(turtle.NewPosition());
            Assert.AreEqual(pos.Y, 0);
            // Move to edge of grid
            turtle.Turn();
            string status = turtle.ToString();
            turtle.MoveTo(turtle.NewPosition());
            turtle.MoveTo(turtle.NewPosition());
            turtle.MoveTo(turtle.NewPosition());
            pos = turtle.NewPosition();
            Assert.AreEqual(4, pos.X);
            // check out of bounds - stays the same
            turtle.MoveTo(turtle.NewPosition());
            Assert.AreEqual(4, pos.X);
            Assert.AreEqual(0, pos.Y);

            // repeat  test for Grid y - turn and move

            // check for outo fo bounds

            // turn west and repeat for left edge of grid

        }


    }
}