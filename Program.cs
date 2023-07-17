using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0712
{
    internal class Program
    {
        static ConsoleKeyInfo Input()
        {
            return Console.ReadKey(true);
        }

        static void Process(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.LeftArrow:
                    playerX--;
                    break;
                case ConsoleKey.RightArrow:
                    playerX++;
                    break;
                case ConsoleKey.UpArrow:
                    playerY--;
                    break;
                case ConsoleKey.DownArrow:
                    playerY++;
                    break;
            }
        }

        static void Render()
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (playerX == x && playerY == y)
                    {
                        Console.Write("P" + " ");
                    }
                    else if (map[y, x] == 0)
                    {
                        Console.Write(" " + " ");
                    }
                    else if (map[y, x] == 1)
                    {
                        Console.Write("*" + " ");
                    }
                }
                Console.WriteLine();
            }
        }

            /* static 자료형 함수이름 (인자1,인자 2....)
             {
                 return 자료형;
             }*/
        static int[,] map = {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            };
            static int playerY = 1;
            static int playerX = 1;
        static void Main(string[] args)
        {   
            while (true)
            {

                ConsoleKeyInfo info = Input();

                Process(info.Key);

                Console.Clear();

                Render();
                
            }
        }
    }
}
