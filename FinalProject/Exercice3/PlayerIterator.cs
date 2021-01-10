using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PlayerIterator : Iterator // Iterator of the player aggregate
    {
        public PlayerIterator(CollectionPlayer players)
        {
            this.players = players;
        }
        
        public override Player First() // Returns the first player to play
        {
            return this.players[0];
        }
        public override Player Current() // Returns the current player playing
        {
            if (this.currentPlayer == null)
            {
                this.currentPlayer = First();
            }
            return this.currentPlayer;
        }
        public override bool IsDone() // Returns if the current player was the last one to play the game round
        {
            return this.players.IndexOf(this.currentPlayer) > players.Count() - 2;
        }
        public override Player Next() // Play the turn of the currrent player and return the next player to play
        {
            if (IsDone())
            {
                this.currentPlayer = First();
            }
            else
            {
                this.currentPlayer = this.players[players.IndexOf(this.currentPlayer) + 1];
            }
            return this.currentPlayer;
        }
    }
}
