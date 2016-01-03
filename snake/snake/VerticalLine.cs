using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine
    {
        List<Point> pLine = new List<Point>();

        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            for(int y= yTop; y <= yBottom; y++)
            {
                Point point = new Point(x,y,sym);
                pLine.Add(point);
            }
        }

        public void DrawVline()
        {
            foreach(Point p in pLine)
            {
                p.Draw();
            }
        }
    }
}
