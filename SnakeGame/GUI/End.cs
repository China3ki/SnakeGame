using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.GUI
{
    internal class End : Menu
    {
        public End(int width, int height) : base(width, height) { }

        public override void Draw()
        {
            int top = 0;
            int left = 0;
            base.Draw();
            string[] header = {
                "░█▀▀░█▀█░█▄█░█▀▀░░░█▀█░█░█░█▀▀░█▀▄",
                "░█░█░█▀█░█░█░█▀▀░░░█░█░▀▄▀░█▀▀░█▀▄",
                "░▀▀▀░▀░▀░▀░▀░▀▀▀░░░▀▀▀░░▀░░▀▀▀░▀░▀"
            };
          

            


            for (int i = 0; i < header.Length; i++)
            {
                top = (height - header.Length) / 2 + i;
                left = (width - header[i].Length) / 2;
                Console.SetCursorPosition(left, top);
                foreach (char key in header[i])
                {
                    Console.Write(key);
                }
            }
         
        }
    }
}
