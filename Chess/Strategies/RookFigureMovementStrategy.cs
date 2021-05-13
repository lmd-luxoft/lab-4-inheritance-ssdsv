namespace Chess
{
    internal class RookFigureMovementStrategy : IFigureMovementStrategy
    {
        public bool CanMove(string currentCoord, string nextCoord)
        {
            return !((nextCoord[0] != currentCoord[0])
                     && (nextCoord[1] != currentCoord[1])
                     || ((nextCoord[0] == currentCoord[0])
                         && (nextCoord[1] == currentCoord[1]))
                     );
        }
    }
}