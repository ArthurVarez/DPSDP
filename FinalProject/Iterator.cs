using System;
using System.Collections.Generic;

namespace FinalProject
{
    public abstract class Iterator
    {
        public PlayerAggregate players;
        public Player currentPlayer;
        public abstract Player First();
        public abstract Player Current();
        public abstract Player Next();
        public abstract bool IsDone();

    }
}
