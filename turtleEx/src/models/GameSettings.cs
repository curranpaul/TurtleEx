using System;
using System.Collections.Generic;

namespace turtleEx
{
    [Serializable]
    public class GameSettings
    {
        public Coordinate BoardSize;
        public Coordinate StartingPoint;
        public EDirection Direction;
        public Coordinate ExitPoint;
        public List<Square> Mines;

        // set example default for testing to be overwritten from file input
        public GameSettings()
        {
            this.BoardSize = new Coordinate(5, 4);
            this.StartingPoint = new Coordinate( 0, 1);
            this.Direction = EDirection.North;
            this.ExitPoint = new Coordinate(4, 2);
            this.Mines = new List<Square>();
        }
    }
}