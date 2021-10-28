using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turtleEx.src.models;

namespace turtleEx
{
    public class Game
    {

        private GameSettings gameSettings;
        private Moves moves;
        private Turtle turtle;
        private Grid grid;
        private Mines mines;
        private Coordinate ExitPoint;

        public Game(GameSettings settingsToUse, Moves movesToPlay)
        {
            gameSettings = settingsToUse;
            moves = movesToPlay;
            turtle = new Turtle(gameSettings.StartingPoint,gameSettings.Direction, gameSettings.BoardSize);
            grid = new Grid(gameSettings.BoardSize);
            mines = new Mines(gameSettings.Mines);
            ExitPoint = gameSettings.ExitPoint;

        }

        // we will play until all moves exhausted
        public void Play()
        {
            WriteOutput("Starting");
            var nextMove = moves.GetNextMove();
            while ( nextMove != EMoves.Finished  &&
                    nextMove != EMoves.Invalid )
            {
                nextMove = DoMove(nextMove);
                if (nextMove != EMoves.Finished)
                {
                    nextMove = moves.GetNextMove();
                }
            }
        }

        private EMoves CheckMove( EMoves nextMove, MoveableCoordinate newPosition)
        {
            int sequence = moves.Sequence;
            EMoves moveStatus = nextMove;
            if (nextMove == EMoves.Rotate)
            {
                WriteOutput($"Sequence {sequence}: Success!");
                return nextMove;
            }

            else
            if (newPosition.Equals(this.ExitPoint))
            {
                WriteOutput($"Sequence {sequence}: Exit!");
                moveStatus = EMoves.Finished;
            }
            else
            if (grid.OutOfBounds( newPosition))
            {
                WriteOutput($"Sequence {sequence}: Still In Danger!");
                moveStatus = EMoves.Invalid;
            }
            else
            if (mines.IsMineHit(newPosition) != null)
            {
                WriteOutput($"Sequence {sequence}: Mine Hit!");
            }
           return moveStatus;
        }

        private EMoves DoMove(EMoves moveType)
        {
            EMoves moveStatus = moveType;
            switch (moveType)
            {
                case EMoves.Move:                    
                    moveStatus = CheckMove(moveType, turtle.NewPosition());
                    if (moveStatus != EMoves.Invalid)
                    {
                        turtle.MoveTo(turtle.NewPosition());
                    }

                    break;
                case EMoves.Rotate:
                    turtle.Turn();
                    moveStatus = CheckMove(moveType, turtle.Position);
                    break;

            }

            return moveStatus;
        }

       private void WriteOutput(string message)
        {
            Console.WriteLine(message);
            Debug.WriteLine($"Turtle at: {turtle.ToString()}");
        }

    }
}
