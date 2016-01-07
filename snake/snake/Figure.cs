using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
       protected List<Point> pLine = new List<Point>();

        //делаем метод виртуальным чтобы наследники класса могли его переопределить
        public virtual void Draw()
        {
            foreach (Point p in pLine)
            {
                p.Draw();
            }
        }
    }
}
