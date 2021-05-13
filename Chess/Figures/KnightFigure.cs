using System;

namespace Chess.Figures
{
    internal class KnightFigure : ChessFigure
    {
        public KnightFigure(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool MoveInner(string nextCoord)
        {
            int dx, dy;
            dx = Math.Abs(nextCoord[0] - currentCoord[0]);
            dy = Math.Abs(nextCoord[1] - currentCoord[1]);
            return Math.Abs(nextCoord[0] - currentCoord[0]) == 1
                   && Math.Abs(nextCoord[1] - currentCoord[1]) == 2
                   || Math.Abs(nextCoord[0] - currentCoord[0]) == 2
                   && Math.Abs(nextCoord[1] - currentCoord[1]) == 1;
        }
    }
}