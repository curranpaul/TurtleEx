using Newtonsoft.Json;
using System;

namespace turtleEx
{
    [Serializable]
    public class Coordinate
    {
        protected int _x;
        protected int _y;

        public int X { get { return _x; } }
        public int Y { get { return _y; } }

        public override string ToString()
        {
            return $"[{X},{Y}]";
        }

        // making a choice to default a coordinate to the bottom
        public Coordinate()
            : this(0,0)
        {
        }

        [JsonConstructor]
        public Coordinate(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public bool  Equals( Coordinate another)
        {
            return (this.X == another.X)
                && (this.Y == another.Y);
        }
    }
}