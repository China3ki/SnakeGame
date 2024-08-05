using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.GUI
{
    internal class Start : Menu
    {
        public Start(int width, int height) : base(width, height) { }
        
        public override void Draw()
        {
            int top = 0;
            int left = 0;
            base.Draw();
            string[] header = {
                "░█▀▀░█▀█░█▀█░█░█░█▀▀",
                "░▀▀█░█░█░█▀█░█▀▄░█▀▀",
                "░▀▀▀░▀░▀░▀░▀░▀░▀░▀▀▀" 
            };
            string prompt = "Kliknij enter aby zacząć!";


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
            left = (width - prompt.Length) / 2;
            Console.SetCursorPosition(left, top + 4);
            Console.Write(prompt);

        }
       
    }
}
