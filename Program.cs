﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Horizontalline Hline = new Horizontalline(5, 10, 8, '+');
            Hline.Draw();
            Verticalline Vline = new Verticalline(5,10, 8, '-');
            Vline.Draw();
            Console.ReadLine();

        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
