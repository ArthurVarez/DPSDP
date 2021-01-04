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
            CircularList<int> l = new CircularList<int>();
            List<Player> listPlayer = new List<Player>();
            for (int i =0; i<39; i++)
            {
                Node<int> node = new Node<int>(i);
                l.AddNode(node);
            }
            for (int i=0; i<3;i++)
            {
                Player player = new Player("" + i);
                listPlayer.Add(player);
            }
            Game game = new Game(listPlayer);
            game.PlayGame();
        }
    }
}
