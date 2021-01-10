using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Iterator // Abstract class for the iterator pattern
    {
        public CollectionPlayer players;
        public Player currentPlayer;
        public abstract Player First(); // Return the first player of the aggregate
        public abstract Player Current(); // Return the current player of the aggregate
        public abstract Player Next(); // Return the next player of the aggregate
        public abstract bool IsDone(); // Return if the current player is the last one

    }
}
