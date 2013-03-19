namespace ConsoleGame
{
    public class Unit
    {
        Position position = new Position(1, 1);

        public Position GetPossition()
        {
            return position;
        }

        public void SetPosition(Position position)
        {
            this.position = position;
        }
    }
}
