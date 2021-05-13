namespace Chess.Figures
{
    internal class PawnFigure : ChessFigure
    {
        public PawnFigure(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool MoveInner(string nextCoord)
        {
            return !(nextCoord[0] != currentCoord[0]
                     || nextCoord[1] <= currentCoord[1]
                     || (nextCoord[1] - currentCoord[1] != 1
                         && (currentCoord[1] != '2' || nextCoord[1] != '4'))
                );
        }
    }
}