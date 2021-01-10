using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CollectionPlayer : Aggregate // Players collection using the Iterator pattern
    {
        private List<Player> listPlayers;

        public List<Player> Players { get => listPlayers; set => listPlayers = value; }

        public CollectionPlayer()
        {
            this.listPlayers = new List<Player>();
        }

        public override PlayerIterator CreateIterator()
        {
            return new PlayerIterator(this);
        }

        public int Count() // Gets players count
        {
            return this.listPlayers.Count;
        }

        public int IndexOf(Player player)
        {
            return this.listPlayers.IndexOf(player);
        }

        public void Add(Player player)
        {
            this.listPlayers.Add(player);
        }
        public void RemoveAt(int index)
        {
            this.listPlayers.RemoveAt(index);
        }

        public Player this[int index] // Indexer
        {
            get { return this.listPlayers[index]; }
            set { this.listPlayers.Insert(index, value); }
        }
    }
}
