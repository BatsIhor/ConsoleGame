using System;

namespace ConsoleGame
{
    /// <summary>
    /// Our map logic
    /// </summary>
    public class Map
    {
        char[,] map = new char[20, 40];

        public bool gameOver = false;

        public Unit[] units = new Unit[3];

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
            Position possition = units[0].Possition;

            //Clear current position.
            map[possition.X, possition.Y] = (char)0;

            if (keyInfo.Key == ConsoleKey.UpArrow && possition.X - 1 != 0 && NextIsNotTree(possition, keyInfo.Key, false))
            {
                possition.X = possition.X - 1;
            }
            if (keyInfo.Key == ConsoleKey.DownArrow && possition.X + 1 != 19 && NextIsNotTree(possition, keyInfo.Key, false))
            {
                possition.X = possition.X + 1;
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow && possition.Y - 1 != 0 && NextIsNotTree(possition, keyInfo.Key, false))
            {
                possition.Y = possition.Y - 1;
            }
            if (keyInfo.Key == ConsoleKey.RightArrow && possition.Y + 1 != 39 && NextIsNotTree(possition, keyInfo.Key, false))
            {
                possition.Y = possition.Y + 1;
            }
        }

        public void MoveBots()
        {
            Position possition = units[0].Possition;

            for (int i = 1; i < units.Length; i++)
            {
                Position bot_possition = units[i].Possition;

                map[bot_possition.X, bot_possition.Y] = (char)0;

                if (possition.X > bot_possition.X)
                {
                    ConsoleKeyInfo fictionKey = new ConsoleKeyInfo('0', ConsoleKey.DownArrow, false, false, false);

                    if (NextIsNotTree(bot_possition, fictionKey.Key, true))
                    {
                        bot_possition.X = bot_possition.X + 1;
                        continue;
                    }
                }
                else if (possition.X < bot_possition.X)
                {
                    ConsoleKeyInfo fictionKey = new ConsoleKeyInfo('0', ConsoleKey.UpArrow, false, false, false);

                    if (NextIsNotTree(bot_possition, fictionKey.Key, true))
                    {
                        bot_possition.X = bot_possition.X - 1;
                        continue;
                    }
                }

                if (possition.Y > bot_possition.Y)
                {
                    ConsoleKeyInfo fictionKey = new ConsoleKeyInfo('0', ConsoleKey.RightArrow, false, false, false);

                    if (NextIsNotTree(bot_possition, fictionKey.Key, true))
                    {
                        bot_possition.Y = bot_possition.Y + 1;
                        continue;
                    }
                }
                else if (possition.Y < bot_possition.Y)
                {
                    ConsoleKeyInfo fictionKey = new ConsoleKeyInfo('0', ConsoleKey.LeftArrow, false, false, false);

                    if (NextIsNotTree(bot_possition, fictionKey.Key, true))
                    {
                        bot_possition.Y = bot_possition.Y - 1;
                        continue;
                    }
                }

            }
        }

        private void IsKilled()
        {
            for (int i = 1; i < units.Length; i++)
            {
                if (units[0].Possition.X == units[i].Possition.X && units[0].Possition.Y == units[i].Possition.Y)
                {
                    gameOver = true;
                }
            }
        }

        public void Print()
        {
            if (!gameOver)
            {
                for (int x = 0; x < units.Length; x++)
                {
                    Console.SetCursorPosition(0, 0);

                    map[units[x].Possition.X, units[x].Possition.Y] = units[x].Face;

                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 40; j++)
                        {
                            Console.Write(map[i, j]);
                        }
                        Console.WriteLine();
                    }

                    Player player = (Player)units[0];

                    Console.WriteLine(player.Points);
                }
            }
            else
            {
                Console.SetCursorPosition(12, 10);
                Console.Write("-= Game Over =-");
            }

            IsKilled();
        }

        private bool NextIsNotTree(Position pos, ConsoleKey key, bool isBot)
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
            if (isItem && !isBot)
            {
                Player player = (Player)units[0];
                player.Points = player.Points + 100;
            }

            return isTree;
        }
    }
}
