using System.Collections.Generic;

namespace Chess
{
    public class ChessFigure
    {
        private IDictionary<Type, IFigureMovementStrategy> _strategies = new Dictionary<Type, IFigureMovementStrategy>();

        private Type type;
        private string currentCoord;

        public ChessFigure(Type type, string currentCoord)
        {
            this.type = type;
            this.currentCoord = currentCoord;
            AddMovementRules();
        }

        private void AddMovementRules()
        {
            _strategies.Add(Type.BISHOP, new BishopFigureMovementStrategy());
            _strategies.Add(Type.KING, new KingFigureMovementStrategy());
            _strategies.Add(Type.KNIGHT, new KnightFigureMovementStrategy());
            _strategies.Add(Type.PAWN, new PawnFigureMovementStrategy());
            _strategies.Add(Type.QUEEN, new QueenFigureMovementStrategy());
            _strategies.Add(Type.ROOK, new RookFigureMovementStrategy());
        }

        public enum Type
        {
            ROOK,
            KNIGHT,
            BISHOP,
            PAWN,
            KING,
            QUEEN
        }

        internal bool Move(string nextCoord)
        {
            IFigureMovementStrategy strategy;

            if (!_strategies.TryGetValue(type, out strategy))
                return false;

            if (IsMoveOutOfField(nextCoord))
                return false;

            return strategy.CanMove(currentCoord, nextCoord);
		}

        private bool IsMoveOutOfField(string nextCoord)
        {
            return !(nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8');
        }
    }
}
