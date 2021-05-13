namespace Chess
{
    internal interface IFigureMovementStrategy
    {
        bool CanMove(string from, string to);
    }
}