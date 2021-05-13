using System;

namespace Chess
{
    internal class KingFigureMovementStrategy : IFigureMovementStrategy
    {
        public bool CanMove(string currentCoord, string nextCoord)
        {
            return Math.Abs(nextCoord[0] - currentCoord[0]) <= 1 && Math.Abs(nextCoord[1] - currentCoord[1]) <= 1;
        }
    }
}