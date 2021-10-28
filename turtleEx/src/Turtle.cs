using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleEx
{


    public class Turtle
    {
        private MoveableCoordinate _position;
        public  MoveableCoordinate Position {
            get { return _position; }
        }
        EDirection Direction;
        Coordinate BoardSize = new Coordinate();

        public override string ToString() {
            return $"Dir: {Direction.ToString()} position: { Position.ToString()}";
        }
        public Turtle(Coordinate start, EDirection facing)
        {
            this._position = new MoveableCoordinate(start);
            Direction = facing;
        }

        public Turtle(Coordinate start, EDirection facing, Coordinate boardSize)
            : this(start, facing)
        {
            this.BoardSize = boardSize;
        }

        public void Turn()
        {
            if (Direction == EDirection.West)
            {
                Direction = EDirection.North;
            }
            else Direction++;
        }

        // going to  try a move if it is out of bounds  then we will throw an exception
        // this is to always keep the turtle on the board instead of futher possible moves
        //  that are out of bounds 
        public MoveableCoordinate NewPosition()
        {
            MoveableCoordinate newPosition = this.Position;

            switch (this.Direction) { 
               case EDirection.North: newPosition = Position.Up();
                    break;
                case EDirection.East:
                    newPosition = Position.Right();
                    break;
                case EDirection.South:
                    newPosition = Position.Down();
                    break;
                case EDirection.West:
                    newPosition = Position.Left();
                    break;
            }

            return newPosition;
        }

        public void MoveTo(MoveableCoordinate newPosition)
        {
            this._position = newPosition;
        }
    }
    


    public enum EDirection
    {
        North,
        East,
        South,
        West
    }
}

