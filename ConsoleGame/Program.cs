using System;
using System.Threading;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = CreateMap();

            Player unit = new Player();
            Unit bot = new Unit();
            Unit bot1 = new Unit();
            
            map.units[0] = unit;
            map.units[1] = bot;
            map.units[2] = bot1;

            unit.Face = (char)1;

            bot.Face = (char)2;
            bot.Possition = new Position(15, 15);

            bot1.Face = (char)3;
            bot1.Possition = new Position(16, 16);

            map.Print();

            for (; ; )
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                while (!Console.KeyAvailable)
                {
                    map.MoveUnit(consoleKeyInfo);

                    map.MoveBots();

                    map.Print();

                    Thread.Sleep(50);
                    //if (map.gameOver)
                    //{
                    //    break;
                    //}
                }
            }
        }

        /// <summary>
        /// Add walls and points
        /// </summary>
        /// <returns></returns>
        private static Map CreateMap()
        {
            Map map = new Map();

            Position position = new Position(10, 20);
            Position position1 = new Position(11, 20);
            Position position2 = new Position(12, 20);
            Position position3 = new Position(13, 20);
            Position position4 = new Position(14, 20);
            Position position5 = new Position(15, 20);
            Position position6 = new Position(16, 20);
            Position position7 = new Position(17, 20);
            Position position8 = new Position(10, 19);
            Position position9 = new Position(11, 19);
            Position position10 = new Position(12, 19);
            Position position11 = new Position(13, 19);
            Position position12 = new Position(14, 19);
            Position position13 = new Position(15, 19);
            Position position14 = new Position(16, 19);
            Position position15 = new Position(17, 19);
            Position position16 = new Position(17, 2);
            Position position17 = new Position(17, 3);
            Position position18 = new Position(17, 4);
            Position position19 = new Position(17, 5);
            Position position20 = new Position(17, 6);
            Position position21 = new Position(17, 7);
            Position position22 = new Position(17, 8);
            Position position23 = new Position(17, 9);
            Position position24 = new Position(17, 10);
            Position position25 = new Position(17, 11);
            Position position26 = new Position(17, 12);
            Position position27 = new Position(17, 13);
            Position position28 = new Position(17, 14);
            Position position29 = new Position(17, 15);
            Position position30 = new Position(17, 16);
            Position position31 = new Position(17, 17);
            Position position32 = new Position(17, 37);
            Position position33 = new Position(17, 36);
            Position position34 = new Position(17, 35);
            Position position35 = new Position(17, 34);
            Position position36 = new Position(17, 33);
            Position position37 = new Position(17, 32);
            Position position38 = new Position(17, 31);
            Position position39 = new Position(17, 30);
            Position position40 = new Position(17, 29);
            Position position41 = new Position(17, 28);
            Position position42 = new Position(17, 27);
            Position position43 = new Position(17, 26);
            Position position44 = new Position(17, 25);
            Position position45 = new Position(17, 24);
            Position position46 = new Position(17, 23);
            Position position47 = new Position(17, 22);
            Position position48 = new Position(2, 2);
            Position position49 = new Position(2, 3);
            Position position50 = new Position(2, 4);
            Position position51 = new Position(2, 5);
            Position position52 = new Position(2, 6);
            Position position53 = new Position(2, 7);
            Position position54 = new Position(2, 8);
            Position position55 = new Position(2, 9);
            Position position56 = new Position(2, 10);
            Position position57 = new Position(2, 11);
            Position position58 = new Position(2, 12);
            Position position59 = new Position(2, 13);
            Position position60 = new Position(2, 14);
            Position position61 = new Position(2, 15);
            Position position62 = new Position(2, 16);
            Position position63 = new Position(2, 17);
            Position position64 = new Position(2, 37);
            Position position65 = new Position(2, 36);
            Position position66 = new Position(2, 35);
            Position position67 = new Position(2, 34);
            Position position68 = new Position(2, 33);
            Position position69 = new Position(2, 32);
            Position position70 = new Position(2, 31);
            Position position71 = new Position(2, 30);
            Position position72 = new Position(2, 29);
            Position position73 = new Position(2, 28);
            Position position74 = new Position(2, 27);
            Position position75 = new Position(2, 26);
            Position position76 = new Position(2, 25);
            Position position77 = new Position(2, 24);
            Position position78 = new Position(2, 23);
            Position position79 = new Position(2, 22);

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
            map.AddElement(15, position38);
            map.AddElement(15, position39);
            map.AddElement(15, position40);
            map.AddElement(15, position41);
            map.AddElement(15, position42);
            map.AddElement(15, position43);
            map.AddElement(15, position44);
            map.AddElement(15, position45);
            map.AddElement(15, position46);
            map.AddElement(15, position47);
            map.AddElement(15, position48);
            map.AddElement(15, position49);
            map.AddElement(15, position50);
            map.AddElement(15, position51);
            map.AddElement(15, position52);
            map.AddElement(15, position53);
            map.AddElement(15, position54);
            map.AddElement(15, position55);
            map.AddElement(15, position56);
            map.AddElement(15, position57);
            map.AddElement(15, position58);
            map.AddElement(15, position59);
            map.AddElement(15, position60);
            map.AddElement(15, position61);
            map.AddElement(15, position62);
            map.AddElement(15, position63);
            map.AddElement(15, position64);
            map.AddElement(15, position65);
            map.AddElement(15, position66);
            map.AddElement(15, position67);
            map.AddElement(15, position68);
            map.AddElement(15, position69);
            map.AddElement(15, position70);
            map.AddElement(15, position71);
            map.AddElement(15, position72);
            map.AddElement(15, position73);
            map.AddElement(15, position74);
            map.AddElement(15, position75);
            map.AddElement(15, position76);
            map.AddElement(15, position77);
            map.AddElement(15, position78);
            map.AddElement(15, position79);

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

           return map;
        }
    }
}
