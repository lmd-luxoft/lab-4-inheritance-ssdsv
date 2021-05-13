using System;

namespace Chess.Figures
{
    internal class QueenFigure : ChessFigure
    {
        public QueenFigure(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool MoveInner(string nextCoord)
        {
            return Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1]) || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1];
        }
    }
}