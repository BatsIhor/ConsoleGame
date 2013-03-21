namespace ConsoleGame
{
    public class Unit
    {
	    //Default possition for unit.
        Position position = new Position(1, 1);

        public int Points;

        public Position GetPossition()
        {
            return position;
        }
    }
}
