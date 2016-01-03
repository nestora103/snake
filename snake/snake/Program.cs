using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
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

            Console.ReadLine();     
            
                 
        }

    }
}
