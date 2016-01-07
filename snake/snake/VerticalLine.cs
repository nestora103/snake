using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine:Figure
    {
        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            for(int y= yTop; y <= yBottom; y++)
            {
                Point point = new Point(x,y,sym);
                pLine.Add(point);
            }
        }

        //переопределение метода отрисовки фигуры как надо для вертикальной линии
        public override void Draw()
        {
            //устанавливаем цвет символов
            Console.ForegroundColor = ConsoleColor.Green;
            //базовая отрисовка фигуры
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
