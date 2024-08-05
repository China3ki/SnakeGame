using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace SnakeGame.Game
{
    internal class Food : Main
    {
        public Food(int width, int height) : base(width, height) {}

        public void InitFood()
        {
     
                RandomFood();
                DrawFood();
        }
        private void DrawFood()
        {
            for(int i = 0; i < foodPos.Count / 2; i++)
            {
                Console.SetCursorPosition(foodPos[i][0], foodPos[i][1]);
                Console.Write("#");
            }
        }
        private void RandomFood()
        {
            int x = Random(1, this.width - 1);
            int y = Random(1, this.height - 1);
            foodPos.Add([x, y]);   
        }
        private int Random(int min, int max)
        {
            Random number = new Random();
            return number.Next(min,max);
        }
      
        
    }
}
