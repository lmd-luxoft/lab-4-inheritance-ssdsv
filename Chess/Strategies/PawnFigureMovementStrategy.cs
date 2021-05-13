namespace Chess
{
    internal class PawnFigureMovementStrategy : IFigureMovementStrategy
    {
        public bool CanMove(string currentCoord, string nextCoord)
        {
            return !(nextCoord[0] != currentCoord[0]
                     || nextCoord[1] <= currentCoord[1]
                     || (nextCoord[1] - currentCoord[1] != 1
                         && (currentCoord[1] != '2' || nextCoord[1] != '4'))
                );
        }
    }
}