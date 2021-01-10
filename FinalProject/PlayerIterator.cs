using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PlayerIterator : Iterator
    {
        private Player nextPlayer;

        public PlayerIterator(CollectionPlayer players)
        {
            this.players = players;
        }
        public Player NextPlayer
        {
            get
            {
                if (IsDone())
                {
                    return First();
                }
                else
                {
                    return this.players[players.IndexOf(this.currentPlayer) + 1];
                }
            }
        }
        public override Player First()
        {
            return this.players[0];
        }
        public override Player Current()
        {
            if (this.currentPlayer == null)
            {
                this.currentPlayer = First();
            }
            return this.currentPlayer;
        }
        public override bool IsDone()
        {
            return this.players.IndexOf(this.currentPlayer) > players.Count() - 2;
        }
        public override Player Next()
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
