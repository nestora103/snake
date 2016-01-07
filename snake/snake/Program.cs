using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.SetBufferSize(80,25);

            //создаем линии рамки
            VerticalLine lineV1 = new VerticalLine(1, 0, 24, '%');
            VerticalLine lineV2 = new VerticalLine(78, 0, 24, '%');
            HorizontalLine lineH1 = new HorizontalLine(1, 78, 0, '#');
            HorizontalLine lineH2 = new HorizontalLine(1, 78, 24, '#');

            //создаем стартовую точку для змейки
            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p,4,Diraction.RIGHT);
            //Отрисовка змеи как просто фигуры. Методы змеи ей не доступны
            Draw(fSnake);
            //приведение типа фигура к типу змеи. 
            Snake snake = (Snake)fSnake;

            //создаем список фигур в который положим линии рамки и саму змейку, для вывода в цикле
            List<Figure> figures = new List<Figure>();

            figures.Add(lineV1);
            figures.Add(lineV2);
            figures.Add(lineH1);
            figures.Add(lineH2);

            foreach (var f in figures)
            {
                f.Draw();
            }
            Console.ReadLine();
              
        }
        //отрисовка переданной фигуры
        static void Draw(Figure figure)
        {
            figure.Draw();
        }
        
    }
}
