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
            Position position6 = new Position(17, 2);
            Position position7 = new Position(17, 3);
            Position position8 = new Position(17, 4);
            Position position9 = new Position(17, 5);
            Position position10 = new Position(17, 6);
            Position position11 = new Position(17, 7);
            Position position12 = new Position(17, 8);
            Position position13 = new Position(17, 9);
            Position position14 = new Position(17, 10);
            Position position15 = new Position(17, 11);
            Position position16 = new Position(17, 12);
            Position position17 = new Position(17, 13);
            Position position18 = new Position(17, 14);
            Position position19 = new Position(17, 15);
            Position position20 = new Position(17, 16);
            Position position21 = new Position(17, 17);
            Position position22 = new Position(17, 37);
            Position position23 = new Position(17, 36);
            Position position24 = new Position(17, 35);
            Position position25 = new Position(17, 34);
            Position position26 = new Position(17, 33);
            Position position27 = new Position(17, 32);
            Position position28 = new Position(17, 31);
            Position position29 = new Position(17, 30);
            Position position30 = new Position(17, 29);
            Position position31 = new Position(17, 28);
            Position position32 = new Position(17, 27);
            Position position33 = new Position(17, 26);
            Position position34 = new Position(17, 25);
            Position position35 = new Position(17, 24);
            Position position36 = new Position(17, 23);
            Position position37 = new Position(17, 22);
            
            // Walls
            map.AddElement(15, position);
            map.AddElement(15, position1);
            map.AddElement(15, position2);
            map.AddElement(15, position3);
            map.AddElement(15, position4);
            map.AddElement(15, position5);
            map.AddElement(15, position6);
            map.AddElement(15, position7);
            map.AddElement(15, position8);
            map.AddElement(15, position9);
            map.AddElement(15, position10);
            map.AddElement(15, position11);
            map.AddElement(15, position12);
            map.AddElement(15, position13);
            map.AddElement(15, position14);
            map.AddElement(15, position15);
            map.AddElement(15, position16);
            map.AddElement(15, position17);
            map.AddElement(15, position18);
            map.AddElement(15, position19);
            map.AddElement(15, position20);
            map.AddElement(15, position21);
            map.AddElement(15, position22);
            map.AddElement(15, position23);
            map.AddElement(15, position24);
            map.AddElement(15, position25);
            map.AddElement(15, position26);
            map.AddElement(15, position27);
            map.AddElement(15, position28);
            map.AddElement(15, position29);
            map.AddElement(15, position30);
            map.AddElement(15, position31);
            map.AddElement(15, position32);
            map.AddElement(15, position33);
            map.AddElement(15, position34);
            map.AddElement(15, position35);
            map.AddElement(15, position36);
            map.AddElement(15, position37);

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
