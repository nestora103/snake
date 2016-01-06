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
        /*[DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);
        public const int SM_CXSCREEN = 0;
        public const int SM_CYSCREEN = 1;*/

        static void Main(string[] args)
        {   
            
            /*int screenW = GetSystemMetrics(SM_CXSCREEN);
            int screenH = GetSystemMetrics(SM_CYSCREEN);*/

            Console.SetBufferSize(80,25);
            
            //Отрисуем рамку
            HorizontalLine lineH1 = new HorizontalLine(1,78,0,'#');
            lineH1.Draw();
            HorizontalLine lineH2 = new HorizontalLine(1, 78, 24, '#');
            lineH2.Draw();
            VerticalLine lineV1 = new VerticalLine(1,0,24,'#');
            lineV1.Draw();
            VerticalLine lineV2 = new VerticalLine(78, 0, 24,'#');
            lineV2.Draw();

            //создаем стартовую точку для змейки
            Point p = new Point(4, 5, '*');
            //создаем змейку.
            Snake snake = new Snake(p,4,Diraction.RIGHT);
            //рисуем змейку
            snake.Draw();
            //переместим змейку по выбраннаму ранее направлению
            snake.Move();
            //зададим задержку 300 мс, использую встроенный класс и системную задержку
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            Console.ReadLine();     

        }

    }
}
