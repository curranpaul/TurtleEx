using Microsoft.VisualStudio.TestTools.UnitTesting;
using turtleEx.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleEx.src.models.Tests
{
    [TestClass()]
    public class MovesTests
    {
        string testData = "mMrRmrrrmmrmmmrrrmrrrm";


        [TestMethod()]
        public void GetNextMoveTest()
        {
            Moves moves = new Moves(testData);
            var move = moves.GetNextMove();
            Assert.AreEqual(EMoves.Move, move);
            move = moves.GetNextMove();
            Assert.AreEqual(EMoves.Move, move);
            move = moves.GetNextMove();
            Assert.AreEqual(EMoves.Rotate, move);
        }
    }

     
    
}