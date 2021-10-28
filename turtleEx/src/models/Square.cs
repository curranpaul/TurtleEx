using Newtonsoft.Json;
using System;

namespace turtleEx
{
    [Serializable]
    public  class Square 
    {
        private Coordinate _position;
        public Coordinate Position {
            get { return _position; }
        }

        public Square(int x, int y)
        {
            this._position = new Coordinate(x, y);
        }
        
        [JsonConstructor]
        public Square(Coordinate position)
        {
            this._position = position;
        }

        public  bool Hit(Coordinate position)
       {
          return Position.Equals(position);
      }
   }
}