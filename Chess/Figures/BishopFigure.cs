using System;

namespace Chess.Figures
{
    internal class BishopFigure : ChessFigure
    {
        public BishopFigure(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool MoveInner(string nextCoord)
        {
            return Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1]);
        }
    }
}
