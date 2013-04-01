namespace ConsoleGame
{
    public class Unit
    {
        private Position position = new Position(1, 1);
       
        public Position Possition
        {
            get { return position; }
            set { position = value; }
        }

        public char Face { get; set; }
    }
}
