using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleEx
{
    [Serializable]
    class Mines
    {
        private List<Square> MinesList = new List<Square>();

        public Mines(List<Square> minesList)
        {
            this.MinesList = minesList;
        }

        public Square IsMineHit(Coordinate coord )
        {
            foreach(Square mine in MinesList)
            {
                if (mine.Hit(coord))
                    return mine;
            }
            return null;
        }
    }
}
