using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.SetCursorPosition(foodPos[foodPos.Count - 1][0], foodPos[foodPos.Count - 1][1]);
            Console.Write("#");
        }
        public void ClearFood()
        {
            if (foodPos.Count <= 0) return;
            Console.SetCursorPosition(foodPos[0][0], foodPos[0][1]);
            Console.Write(" ");
            foodPos.RemoveAt(0);
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
