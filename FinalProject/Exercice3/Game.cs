using System;
using System.Collections.Generic;

namespace FinalProject
{
    public class Game
    {
        private List<Player> playerList=new List<Player>();
        private Board board;
        private int nbRounds;

        public Game(int size,int nbPlayers,int nbRounds)
        {
            this.board = new Board(size);
            this.nbRounds = nbRounds;
            CreatePlayer(nbPlayers);
        }

        public void CreatePlayer(int nb)
        {
            for(int i=0; i<nb;i++)
            {
                Player player = new Player("" + i, this.board);
                this.playerList.Add(player);

            }
        }

        public void PlayGame()
        {
            for (int i =0; i< nbRounds; i++)
            {
                PlayRound();
            }
        }

        public void PlayRound()
        {
            foreach (Player player in this.playerList)
            {
                int temp = player.Index.Index;
                player.Play();
                Console.WriteLine("Player: " + player.Name + " move from :" + temp +
                    "   to " + player.Index.Index + " and his state is : " + player.WhatsMyState);
                
            }
        }

    }
}
