using System;

namespace Chess.Figures
{
    internal class KingFigure : ChessFigure
    {
        public KingFigure(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool MoveInner(string nextCoord)
        {
            return Math.Abs(nextCoord[0] - currentCoord[0]) <= 1 && Math.Abs(nextCoord[1] - currentCoord[1]) <= 1;
        }
    }
}