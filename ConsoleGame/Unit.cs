namespace ConsoleGame
{
    public class Unit
    {
        //Default possition for unit.
        private Position position = new Position(1, 1);
        private int points;

        public Position Possition
        {
            get { return position; }
            set { position = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}
