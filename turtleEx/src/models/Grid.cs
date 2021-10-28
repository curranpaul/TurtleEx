using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleEx
{
    class Grid
    {
        private Coordinate boardSize;
       

        public Grid(Coordinate boardSize)
        {
            this.boardSize = boardSize;
        }

        internal bool OutOfBounds(MoveableCoordinate newPosition)
        {
            return  (   newPosition.X < 0 || 
                        newPosition.Y < 0 || 
                        newPosition.X >= boardSize.X || 
                        newPosition.Y >= boardSize.Y 
                        );
        }
    }
}
