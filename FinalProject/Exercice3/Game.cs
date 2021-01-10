using System;
using System.Collections.Generic;

namespace FinalProject
{
    public class Game
    {

        private Board board;
        private int nbRounds;
        private CollectionPlayer playerList;
        private Iterator iterator;

        public Game(int size,int nbPlayers,int nbRounds)
        {
            this.board = new Board(size);
            this.nbRounds = nbRounds;
            this.playerList = new CollectionPlayer();
            this.iterator = this.playerList.CreateIterator();
            CreatePlayer(nbPlayers);
        }

        public void CreatePlayer(int nb)
        {
            for(int i=0; i<nb;i++)
            {
                Player player = new Player("" + (i+1), this.board);
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
            Player playerCurrent = iterator.Current();
            int temp = playerCurrent.Index.Index;
            iterator.Current().Play();
            Console.WriteLine("Player: " + playerCurrent.Name + " move from :" + temp +
                                "   to " + playerCurrent.Index.Index + " and his state is : " + playerCurrent.WhatsMyState);
            iterator.Next();                
            
        }

    }
}
