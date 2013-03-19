using System;

namespace ConsoleGame
{
    public class Map
    {
        char[,] map = new char[20, 40];

        public Unit unit = new Unit();

        public Map()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    map[i, j] = (char)0;

                    if (i == 0 || i == 19)
                    {
                        map[i, j] = '-';
                    }
                    if (j == 0 || j == 39)
                    {
                        map[i, j] = '|';

                    }
                }
            }
        }

        public void AddElement(char element, Position pos)
        {
            map[pos.X, pos.Y] = element;
        }

        public void AddElement(int element, Position pos)
        {
            AddElement((char)element, pos);
        }

        public void MoveUnit(ConsoleKeyInfo keyInfo)
        {
            Position possition = unit.GetPossition();
            map[possition.X, possition.Y] = (char) 0;

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                possition.X = possition.X - 1;
                unit.SetPosition(possition);
            }
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                possition.X = possition.X + 1;
                unit.SetPosition(possition);
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                possition.Y = possition.Y - 1;
                unit.SetPosition(possition);
            }
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                possition.Y = possition.Y + 1;
                unit.SetPosition(possition);
            }

        }

        public void Print()
        {
            Console.Clear();

            Position possition = unit.GetPossition();
            
            map[possition.X, possition.Y] = (char) 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
