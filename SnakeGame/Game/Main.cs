using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Game
{
    internal class Main
    {
        protected static List<int[]> playerPos = new List<int[]>();
        protected static List<int[]> foodPos = new List<int[]>();
        protected static int points;
        protected readonly int width;
        protected readonly int height;
        public Main(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        protected void DrawScore()
        {
            string word = $"Score: {points}";
            for(int i = 0; i < word.Length; i++)
            {
                Console.SetCursorPosition(width - 10 + i, 1);
                Console.Write(' ');
                Console.SetCursorPosition(width - 10 + i, 1);
                Console.Write(word[i]);
            }
        }
    }
}
