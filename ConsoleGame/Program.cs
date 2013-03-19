using System;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();

            Position position = new Position(10, 20);
            Position position1 = new Position(11, 20);
            Position position2 = new Position(12, 20);
            Position position3 = new Position(13, 20);
            Position position4 = new Position(14, 20);
            Position position5 = new Position(15, 20);

            map.AddElement(15, position);
            map.AddElement(15, position1);
            map.AddElement(15, position2);
            map.AddElement(15, position3);
            map.AddElement(15, position4);
            map.AddElement(15, position5);

            map.Print();

            for (; ; )
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                
                map.MoveUnit(consoleKeyInfo);
                
                map.Print();
            }
        }
    }
}
