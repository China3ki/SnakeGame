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
                _menu[1].Draw();
               while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
                Console.Clear();
                Task.Run(() =>
                {
                    while (game)
                    {
                        _food.InitFood();
                        Thread.Sleep(1500);
                    }
                });
                Task.Run(() =>
                {
                    while (game)
                    {
                        Thread.Sleep(3500);
                        _food.ClearFood();
                    }
                });

                while (game) {
                    _game.InitSnake();
                    game = _game.CheckColisionWithTail();
                    Thread.Sleep(33);
                }
                _game.EndAnimation();
                Thread.Sleep(200);
                Console.Clear();
                _menu[2].Draw();
                Thread.Sleep(1000);
                return;
            }

        }
     
    }
}
