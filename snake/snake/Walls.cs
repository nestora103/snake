using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{       
    class Walls
    {
        List<Figure> wallList;
        
        public Walls(int mapWidth,int mapHeight)
        {
            wallList = new List<Figure>();
            
            //создаем линии рамки
            VerticalLine lineV1 = new VerticalLine(1, 0, mapHeight-1, '%');
            VerticalLine lineV2 = new VerticalLine(mapWidth-2, 0, mapHeight-1, '%');
            HorizontalLine lineH1 = new HorizontalLine(1, mapWidth-2, 0, '#');
            HorizontalLine lineH2 = new HorizontalLine(1, mapWidth-2, mapHeight-1, '#');

            //добавляем линии в список фигур, так как они являютс фигурами
            wallList.Add(lineV1);
            wallList.Add(lineV2);
            wallList.Add(lineH1);
            wallList.Add(lineH2);
        }

        //метод проверки столкновения змейки с фигурами из рамки
        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                } 
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
