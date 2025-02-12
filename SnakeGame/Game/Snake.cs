﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Game
{
    internal class Snake : Main
    {
        enum Directions { Up, Down, Right, Left }
        private Directions direction = Directions.Right;
        public Snake(int width, int height) : base(width, height)
        {
            int halfWidth = width / 2;
            int halfHeight = height / 2;
            playerPos.Add([halfWidth, halfHeight]);
            playerPos.Add([halfWidth - 1, halfHeight]);
            playerPos.Add([halfWidth - 2, halfHeight]);
            playerPos.Add([halfWidth - 3, halfHeight]);
        }
        public void InitSnake()
        {
            DrawScore();
            ClearSnake();
            ChangeDirection();
            MoveSnake();
            DrawSnake();
            CheckColisionWithTail();
            CheckTheCollisionWithFood();
        }
        
        public void EndAnimation()
        {
            Thread.Sleep(100);
            for(int i = playerPos.Count - 1; i >= 0; i--)
            {
                Console.SetCursorPosition(playerPos[i][0], playerPos[i][1]);
                Console.Write(" ");
                Thread.Sleep(50);
            } 
        }
        private void DrawSnake()
        {
            for (int i = 0; i < playerPos.Count  ; i++)
            {
                Console.SetCursorPosition(playerPos[i][0], playerPos[i][1]);
                Console.Write("█");
            }

        }
        private void ClearSnake()
        {
         
            for(int i = 0; i < playerPos.Count; i++)
            {
                Console.SetCursorPosition(playerPos[i][0], playerPos[i][1]);
                Console.Write(" ");
            }
           
        }
        private void MoveSnake()
        {
            for (int i = playerPos.Count - 1; i > 0; i--)
            {
                playerPos[i][0] = playerPos[i - 1][0];
                playerPos[i][1] = playerPos[i - 1][1];
            }

            switch (direction)
            {
                case Directions.Up:
                    if (playerPos[0][1] == 1) playerPos[0][1] = height - 1 ;
                    else playerPos[0][1]--;
                    break;
                case Directions.Down:
                    if (playerPos[0][1] == height - 1) playerPos[0][1] = 1;
                    else playerPos[0][1]++;
                    break;
                case Directions.Right:
                    if (playerPos[0][0] == width - 1) playerPos[0][0] = 1;
                    else playerPos[0][0]++;
                    break;
                case Directions.Left:
                    if (playerPos[0][0] == 1) playerPos[0][0] = width - 1;
                    else playerPos[0][0]--;
                    break;
            }
        }
       private void ChangeDirection()
        {
            ConsoleKey key;
            while (Console.KeyAvailable) {
               key =  Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (direction == Directions.Down) continue;
                        direction = Directions.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        if (direction == Directions.Up) continue;
                        direction = Directions.Down;
                        break;
                    case ConsoleKey.RightArrow:
                        if (direction == Directions.Left) continue;
                        direction = Directions.Right;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (direction == Directions.Right) continue;
                        direction = Directions.Left;
                        break;
                }
            }
        }
        private void CheckTheCollisionWithFood()
        {
            for (int i = 0; i < playerPos.Count; i++)
            {
                for (int j = 0; j < foodPos.Count; j++)
                {
                    if (playerPos[i][0] == foodPos[j][0] && playerPos[i][1] == foodPos[j][1])
                    {
                        foodPos.RemoveAt(j);
                        points++;
                        AddTail();
                    }
                }
            }
        }
        public bool CheckColisionWithTail()
        {
            for(int i = 1; i < playerPos.Count; i++)
            {
                if (playerPos[0][0] == playerPos[i][0] && playerPos[0][1] == playerPos[i][1])
                {
                    return false;
                }
            }
            return true;
        }
        private void AddTail()
        {
            int[] lastIndex = playerPos[playerPos.Count - 1];
            int diffX = playerPos[playerPos.Count - 1][0] - playerPos[playerPos.Count - 2][0];
            int diffY = playerPos[playerPos.Count - 1][1] - playerPos[playerPos.Count - 2][1];
            if (diffX > 0 && diffY == 0)
            {
                playerPos.Add([lastIndex[0] - 1, lastIndex[1]]);
            } else if(diffX < 0 && diffY == 0)
            {
                playerPos.Add([lastIndex[0] + 1, lastIndex[1]]);
            } else if(diffX == 0 && diffX > 0)
            {
                playerPos.Add([lastIndex[0], lastIndex[1] + 1]);
            } else if(diffX == 0 && diffY < 0 )
            {
                playerPos.Add([lastIndex[0], lastIndex[1] - 1]);
            }
        }
    }
}
