using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point()
        {

        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int Offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT: x = x-Offset; break;
                case Direction.RIGHT: x = x+Offset; break;
                case Direction.UP: y = y-Offset; break;
                case Direction.DOWN: y = y+Offset; break;
            }
        }

        public void Draw()
        { 
                Console.SetCursorPosition(x, y);
                Console.Write(sym);
        }
        
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
