using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
       public List<Point> pLine = new List<Point>();

        public void Draw()
        {
            foreach (Point p in pLine)
            {
                p.Draw();
            }
        }
    }
}
