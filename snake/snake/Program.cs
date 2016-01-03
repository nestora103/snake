using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем список, который будет хранить элементы типа точки
            List<Point> pList = new List<Point>();
            //Создаем точки для вывода 
            Point p1 = new Point( 1, 3, '*');
            Point p2 = new Point( 1, 5, '#');
            Point p3 = new Point( 1, 7, '$');
            Point p4 = new Point( 1, 9, '%');
            Point p5 = new Point(1, 11, '&');
            //Добавляем точки в список
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            //Выводим поэлементно из списка
            foreach (Point p in pList)
            {
                p.Draw();
            }

            //рисуем горизонтальную линию.
            HorizontalLine lineH = new HorizontalLine(7,15,10,'£');
            lineH.DrowHline();

            //рисуем вертикальную линию.
            VerticalLine lineV = new VerticalLine(15,1,10,'£');
            lineV.DrawVline();

            Console.ReadLine();          
        }

    }
}
