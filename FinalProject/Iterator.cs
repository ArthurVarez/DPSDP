using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Iterator
    {
        public CollectionPlayer players;
        public Player currentPlayer;
        public abstract Player First();
        public abstract Player Current();
        public abstract Player Next();
        public abstract bool IsDone();

    }
}
