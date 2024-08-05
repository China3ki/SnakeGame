using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.GUI
{
    class Menu
    {
        protected readonly int width;
        protected readonly int height;

        public Menu(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public virtual void Draw()
        {
            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    if ((x > 1 && x < width - 2 && y > 1 && y < height - 2)) continue;
                    Console.SetCursorPosition(x, y);
                    Console.Write("=");
                }
            }
        }
    }
}
