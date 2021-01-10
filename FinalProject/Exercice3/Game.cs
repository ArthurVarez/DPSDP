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
            this.board = new Board(size); // A game is defined by a board
            this.nbRounds = nbRounds; // A game has a number of rounds
            this.playerList = new CollectionPlayer(); // We use a collection a player to save the list
            this.iterator = this.playerList.CreateIterator(); // We add an iterator pattern to iterate within the collection
            CreatePlayer(nbPlayers); // Method to create players 
        }

        public void CreatePlayer(int nb)
        {
            for(int i=0; i<nb;i++)
            {
                Player player = new Player("" + (i+1), this.board); // Create players by give them the board of the game
                this.playerList.Add(player); // Add the player to the collection
            }
        }

        public void PlayGame() // Method to play the game
        {
            for (int i =0; i< nbRounds; i++) 
            {
                PlayRound(); // Call the method to play rounds
            }
        }

        public void PlayRound() // Method to play a round 
        {
            Player playerCurrent = iterator.Current(); // Get the current player, start on the first in the list (see PlayerIterator class for more explanations)
            int temp = playerCurrent.Index.Index; // Save the index of the current player in a temp var 
            iterator.Current().Play(); // Call the play method in the player class (see player class for more explanations)
            Console.WriteLine("Player: " + playerCurrent.Name + " move from :" + temp +
                                "   to " + playerCurrent.Index.Index + " and his state is : " + playerCurrent.WhatsMyState);
            iterator.Next(); // Get the next player               
        }

    }
}
