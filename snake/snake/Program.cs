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

           

           /* //создали типизированный список
            List < int > list= new List<int>();
            //добавляем в начало списка число 0;
            list.Add(0);
            //след. элемент 
            list.Add(1);
            //обращение к 1 элементу масства, нулевому
            int i = list[0];

            foreach (int k in list)
            {
                Console.WriteLine(k);
                Console.ReadLine();
            }*/

            
             
        }
        
    }
}
