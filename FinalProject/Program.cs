using System;
using System.Collections.Generic;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------");

            Game game = new Game(40,2,50);

            game.PlayGame();
        }
    }
}
