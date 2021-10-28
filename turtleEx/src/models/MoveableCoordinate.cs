namespace turtleEx
{

    // Immutable - returns new instance
    public class MoveableCoordinate :Coordinate
    {
       
        public MoveableCoordinate( int x, int y)
            : base (x,y)
        {

        }

        public MoveableCoordinate(Coordinate start) : base( start.X, start.Y )
        {
  
        }

        public MoveableCoordinate Up()
        {
            return new MoveableCoordinate(this.X, this.Y - 1);
        }

        public MoveableCoordinate Down()
        {
            return new MoveableCoordinate(this.X, this.Y + 1);
        }

        public MoveableCoordinate Left()
        {
            return new MoveableCoordinate(this.X - 1, Y);
        }

        public MoveableCoordinate Right()
        {
            return new MoveableCoordinate(this.X + 1, Y);
        }

    }
}