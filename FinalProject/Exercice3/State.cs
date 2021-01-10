using System;
namespace FinalProject
{
    public abstract class State // Abstract class of a player's state (State pattern)
    {
        public abstract void Play(Player player);
    }
}
