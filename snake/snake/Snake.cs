using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    //Змейка это фигура, т.е список точек
    class Snake:Figure
    {
        //параметры хвост тоесть точка, размер змейки, и направление в которое она перемещается
        public Snake(Point tail,int length,Diraction diraction)
        {
            //заполнение списка точек змейки
            for (int i=0;i<length;i++)
            {
                //на основе хвостовой точки будем получать ост. точки змейки
                Point p = new Point(tail);
                //каждую точку будем получать сдвигом от хвоста
                p.Move(i, diraction);
                //получ. точку в список.
                pLine.Add(p);
            }
        }
    }
}
