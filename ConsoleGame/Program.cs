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

            
            // Walls
            map.AddElement(15, position);
            map.AddElement(15, position1);
            map.AddElement(15, position2);
            map.AddElement(15, position3);
            map.AddElement(15, position4);
            map.AddElement(15, position5);

            //Items
            Position item_position = new Position(10, 10);
            Position item_position1 = new Position(11, 10);
            Position item_position2 = new Position(12, 10);
            Position item_position3 = new Position(13, 10);
            Position item_position4 = new Position(14, 10);
            Position item_position5 = new Position(15, 10);

            map.AddElement(14, item_position);
            map.AddElement(14, item_position1);
            map.AddElement(14, item_position2);
            map.AddElement(14, item_position3);
            map.AddElement(14, item_position4);
            map.AddElement(14, item_position5);

            map.Print();

            for (; ; )
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                
                //move 
                map.MoveUnit(consoleKeyInfo);
                
                //print
                map.Print();
            }
        }
    }
}
