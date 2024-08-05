using SnakeGame.GUI;
using SnakeGame.Game;

namespace SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 20);

            Snake game = new Snake(80, 20);
            Menu[] menu = [ new Menu(80,20), new Start(80,20) ];
            Food food = new Food(80, 20);
            App app = new App(game,food,menu);

            app.Run();
            
        }
    }
}

