﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine
    {
        List<Point> pLine = new List<Point>();

        //начало линии по x, конец линии по x, позиция линии по y, каким символом рисовать
        public HorizontalLine(int xLeft,int xRight,int y,char sym)
        {
            for (int x=xLeft;x<=xRight;x++)
            {
                //создаем и добавляем точки в список точек для посл. вывода
                Point point = new Point(x,y,sym);
                pLine.Add(point);
            }
        }

        public void DrowHline()
        {
            foreach(Point p in pLine)
            {
                p.Draw();
            }
        }
    }
}
