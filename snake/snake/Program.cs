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
            int x1 = 1;
            int y1 = 3;
            char symb = '*';
            Draw(x1,y1,symb);
        }
        static void Draw(int x,int y,char sym)
        {
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
            Console.ReadLine();
        }
    }
}
