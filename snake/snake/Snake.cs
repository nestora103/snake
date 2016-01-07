using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    //Змейка это фигура, т.е список точек
    class Snake:Figure
    {   //будем хранить переданное направление для перемещения
        Diraction diractionM;
        //параметры хвост тоесть точка, размер змейки, и направление в которое она перемещается
        public Snake(Point tail,int length,Diraction diraction)
        {
            //запомним направление для перемещения
            diractionM = diraction;
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

        internal void Move()
        {
            //получим хвостовую точку, первая строка списка, метод описан в библиотеке
            Point tail = pLine.First();
            //удаляем хвостовую точку из списка,т.к она должна переместиться на одну точку по направлению движения
            pLine.Remove(tail);
            //получаем головную точку, которую надо будет добавить в список точек для отрисовки змейки
            Point head = GetNextPoint();
            //добавляем головную точку в конец списка точек
            pLine.Add(head);
            //надо стереть из консоли не нужную хвостовую точку змеи
            tail.Clear();
            //надо дорисовать новую головную точку змеи
            head.Draw();
        }

        public void GetDiraction(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                diractionM = Diraction.LEFT;
            }else if(key == ConsoleKey.RightArrow)
            {
                diractionM = Diraction.RIGHT;
            }else if (key==ConsoleKey.DownArrow)
            {
                diractionM = Diraction.DOWN;
            }
            else
            {
                diractionM = Diraction.UP;
            }
        }

        internal bool Eat(Point food)
        {
            //получаем головную точку змеи
            Point head = GetNextPoint();
            //проверяем находится ли голова в той же точек что и еда
            if (head.isHit(food))
            {
                food.sym = head.sym;
                pLine.Add(food);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public Point GetNextPoint()
        {   
            //получим последнюю точку списка
            Point head = pLine.Last();
            //на основе посл. точки получим параметры посл. точки
            Point nextPoint = new Point(head);
            //сдвинем посл. точку на 1 в переданном направлении
            nextPoint.Move(1,diractionM);
            //вернем головную точку
            return nextPoint;
        }



    }
}
