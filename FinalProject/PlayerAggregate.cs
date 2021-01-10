using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PlayerAggregate: Aggregate
    {
        private List<Player> players;

        public List<Player> Players { get => players; set => players = value; }


        public PlayerAggregate()
        {
            this.players = new List<Player>();
        }

        public override PlayerIterator CreateIterator()
        {
            return new PlayerIterator(this);
        }


        // Gets item count
        public int Count()
        {
            return this.players.Count;
        }

        // Indexer
        public Player this[int index]
        {
            get { return players[index]; }
            set { players.Insert(index, value); }
        }
        public int IndexOf(Player player)
        {
            return players.IndexOf(player);
        }
        public void Add(Player player)
        {
            players.Add(player);
        }
        public void RemoveAt(int index)
        {
            players.RemoveAt(index);
        }
    }
}
