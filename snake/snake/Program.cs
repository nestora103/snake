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

            Walls walls = new Walls(80,25);
            walls.Draw();
            
            //создаем стартовую точку для змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p,4,Diraction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80,25,'$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if ((walls.IsHit(snake)) || (snake.IsHitTail()))
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.GetDiraction(key.Key);
                } 
            }  
        }
               
    }
}
