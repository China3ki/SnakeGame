using SnakeGame.Game;
using SnakeGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class App
    {
        private enum States { Start, Game, End };
        private readonly Snake _game;
        private readonly Food _food;
        private readonly Menu[] _menu;
        private bool run = false;
        public App(Snake game, Food food ,Menu[] menu)
        {
            _game = game;
            _food = food;
            _menu = menu;
        }
        public void Run()
        {
            Console.CursorVisible = false;
            run = true;
            bool game = true;
            while(run)
            {
                ChangeView(States.Start);
               while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
                Console.Clear();

                while(game) {
                    _game.InitSnake();
                
                    Thread.Sleep(33);
                }
                
                
            }
            

        }
        private void ChangeView(States state)
        {
            switch (state)
            {
                case States.Start:
                    _menu[1].Draw();
                    break;

            }

        }
    }
}
