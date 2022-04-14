using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Walls
    {
        List<Figure> walllist = new List<Figure>();

        public Walls(int MapWidth, int MapHeight)
        {
            Horizontalline Topline = new Horizontalline(0, MapWidth-2, 0, '*');
            Horizontalline Bottomline = new Horizontalline(0, MapWidth-2, MapHeight-1, '*');
            Verticalline leftline = new Verticalline(0, MapHeight-1, 0, '*');
            Verticalline rightline = new Verticalline(0, MapHeight - 1, MapWidth-2, '*');

            walllist.Add(Topline);
            walllist.Add(Bottomline);
            walllist.Add(rightline);
            walllist.Add(leftline);
            
        }

        public void Draw()
        {
            foreach (var wall in walllist)
               wall.Draw();
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in walllist)
            {
                if(wall.IsHit(figure))
                    return true;
            }
            return false;
        }
        
    }
}
