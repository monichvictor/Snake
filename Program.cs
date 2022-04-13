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
            Console.SetWindowSize(80,25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;
            Horizontalline Topline = new Horizontalline(0, 78, 0, '+');
            Horizontalline Bottomline = new Horizontalline(0, 78, 24, '+');
            Verticalline leftline = new Verticalline(0,24,0,'+');
            Verticalline rightline = new Verticalline(0,24,78,'+');
            Topline.Draw();
            Bottomline.Draw();
            leftline.Draw();
            rightline.Draw();
            Console.ReadKey();

        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
