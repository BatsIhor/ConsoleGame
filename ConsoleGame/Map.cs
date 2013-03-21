using System;

namespace ConsoleGame
{
    /// <summary>
    /// our map logic
    /// </summary>
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

            //Clear current position.
            map[possition.X, possition.Y] = (char)0;

            if (keyInfo.Key == ConsoleKey.UpArrow && possition.X - 1 != 0 && NextIsNotTree(possition, keyInfo.Key))
            {
                possition.X = possition.X - 1;
            }
            if (keyInfo.Key == ConsoleKey.DownArrow && possition.X + 1 != 19 && NextIsNotTree(possition, keyInfo.Key))
            {
                possition.X = possition.X + 1;
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow && possition.Y - 1 != 0 && NextIsNotTree(possition, keyInfo.Key))
            {
                possition.Y = possition.Y - 1;
            }
            if (keyInfo.Key == ConsoleKey.RightArrow && possition.Y + 1 != 39 && NextIsNotTree(possition, keyInfo.Key))
            {
                possition.Y = possition.Y + 1;
            }
        }

        private bool NextIsNotTree(Position pos, ConsoleKey key)
        {
            bool isTree = false;
            bool isItem = false;

            if (key == ConsoleKey.UpArrow)
            {
                isTree = map[pos.X - 1, pos.Y] != (char)15;
                isItem = map[pos.X - 1, pos.Y] == (char)14;

            }
            if (key == ConsoleKey.DownArrow)
            {
                isTree = map[pos.X + 1, pos.Y] != (char)15;
                isItem = map[pos.X + 1, pos.Y] == (char)14;

            }
            if (key == ConsoleKey.LeftArrow)
            {
                isTree = map[pos.X, pos.Y - 1] != (char)15;
                isItem = map[pos.X, pos.Y - 1] == (char)14;

            }
            if (key == ConsoleKey.RightArrow)
            {
                isTree = map[pos.X, pos.Y + 1] != (char)15;
                isItem = map[pos.X, pos.Y + 1] == (char)14;

            }
            if (isItem)
            {
                unit.Points = unit.Points + 100;
            }

            return isTree;
        }

        public void Print()
        {
            Console.Clear();

            Position possition = unit.GetPossition();

            map[possition.X, possition.Y] = (char)1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(unit.Points);
        }

    }
}
