using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleEx.src.models
{
    public class Moves
    {
        string moveCharacters = "";
        int moveIndex = 0;

        public Moves( string data)
        {
            moveCharacters = data.ToLower();
        }

        public  int Sequence {
            get { return moveIndex; }
        }

        public EMoves GetNextMove()
        {

            EMoves result;

            if (moveIndex >= moveCharacters.Length)
            {
                return EMoves.Finished;
            }
            else
            {
                char ch = moveCharacters[moveIndex];

                switch (ch)
                {
                   case 'r': result = EMoves.Rotate;
                     break;
                    case 'm': result = EMoves.Move;
                        break;
                    default: result = EMoves.Invalid;
                        break;

                }
            }

            moveIndex++;
            return result;
        }

    }

    public enum EMoves
    {
        Rotate,
        Move,
        Invalid,
        Finished
    }
}
