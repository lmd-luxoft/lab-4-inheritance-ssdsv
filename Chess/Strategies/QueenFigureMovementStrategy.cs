using System;

namespace Chess
{
    internal class QueenFigureMovementStrategy : IFigureMovementStrategy
    {
        public bool CanMove(string currentCoord, string nextCoord)
        {
            return Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1]) || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1];
        }
    }
}