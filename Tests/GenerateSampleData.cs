using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using turtleEx;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class GenerateSampleData
    {
        [TestMethod]
        public void outputGameSettings()
        {
            GameSettings settings = new GameSettings();
            settings.Direction = EDirection.North;
            settings.BoardSize = new Coordinate(5, 4);
            settings.ExitPoint = new Coordinate(4,2);
            settings.StartingPoint = new Coordinate(0,1);
            settings.Mines = new List<Square>();
            settings.Mines.Add(new Square(1, 1));
            settings.Mines.Add(new Square(3, 1));
            settings.Mines.Add(new Square(3, 3));
            string jsonString = JsonConvert.SerializeObject(settings);
            Console.WriteLine(jsonString);
            

        }
    }
}
