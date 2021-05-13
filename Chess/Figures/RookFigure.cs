namespace Chess.Figures
{
    internal class RookFigure : ChessFigure
    {
        public RookFigure(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool MoveInner(string nextCoord)
        {
            return !((nextCoord[0] != currentCoord[0])
                     && (nextCoord[1] != currentCoord[1])
                     || ((nextCoord[0] == currentCoord[0])
                         && (nextCoord[1] == currentCoord[1]))
                );
        }
    }
}