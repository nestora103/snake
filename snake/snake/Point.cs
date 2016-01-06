using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }

        //создание точки
        public Point(int x,int y,char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        //получение параметров хвостовой точки
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        //на сколько смещать хвостовую точку чтобы получить текущую и в какое направление
        public void Move(int offset, Diraction diraction)
        {
            if (diraction==Diraction.RIGHT)
            {
                x = x + offset;
            }else if(diraction == Diraction.LEFT)
            {
                x = x - offset;
            }else if(diraction == Diraction.UP)
            {
                y = y - offset;
            }
            else
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        //стираем в консоли старую хвостовую точку 
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        //проверяем совпажение координат еды и начала змейки
        public bool isHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
