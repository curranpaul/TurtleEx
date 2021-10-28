using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using turtleEx.src.models;

namespace turtleEx
{
    public static class  Utilities
    {
    
        public static GameSettings ReadJsonGameData(string jsonFileName)
        {
            GameSettings settings = new GameSettings();

            using (StreamReader r = new StreamReader(jsonFileName))
            {
                string json = r.ReadToEnd();
                settings  = JsonConvert.DeserializeObject<GameSettings>(json);
            }
            return settings;
        }

        internal static Moves ReadListOfMoves(string textFile)
        {
            string moveString = "";
            using (StreamReader r = new StreamReader(textFile))
            {
                moveString = r.ReadToEnd();               
            }
            return new Moves(moveString);
        }
    }
}
