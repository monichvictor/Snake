using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : Figure
    {
        Direction direction;
        public int Speed = 4;
        public Snake(Point tail, int lenght, Direction dir)
        {
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, dir);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1,direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow: direction = Direction.LEFT; break;
                case ConsoleKey.RightArrow: direction = Direction.RIGHT; break;
                case ConsoleKey.UpArrow: direction = Direction.UP; break;
                case ConsoleKey.DownArrow: direction = Direction.DOWN; break;
            }
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                SetSpeed(Length());
                return true;
            }
            else return false;
        }
        public bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count-1; i++)
            {
                if (head.IsHit(pList[i])) return true;
               
            }
            return false;

        }
        public int Length()
        { return pList.Count; }

        private void SetSpeed(int length)
        {
            Speed = 4+length/4;
        }
    }
}
