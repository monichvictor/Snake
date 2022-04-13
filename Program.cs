using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80,25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

            Horizontalline Topline = new Horizontalline(0, 78, 0, '*');
            Horizontalline Bottomline = new Horizontalline(0, 78, 24, '*');
            Verticalline leftline = new Verticalline(0,24,0,'*');
            Verticalline rightline = new Verticalline(0,24,78,'*');
            Topline.Draw();
            Bottomline.Draw();
            leftline.Draw();
            rightline.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p,4,Direction.DOWN);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
               

            }
            Console.ReadKey();

        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
