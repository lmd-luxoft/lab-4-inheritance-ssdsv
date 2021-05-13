namespace Chess
{
    public abstract class ChessFigure
    {
        protected string currentCoord;

        public ChessFigure(string currentCoord)
        {
            this.currentCoord = currentCoord;
        }

        internal bool Move(string nextCoord)
        {
            if(IsMoveOutOfField(nextCoord))
                return false;

            return MoveInner(nextCoord);
        }

        internal abstract bool MoveInner(string nextCoord);

        private bool IsMoveOutOfField(string nextCoord)
        {
            return !(nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8');
        }
    }
}
