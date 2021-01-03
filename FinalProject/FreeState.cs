using System;
namespace FinalProject
{
    public class FreeState:State
    {
        private State state;

        public FreeState(State state)
        {
            this.state = state;
        }
        public override void Play(Player player)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            player.Index += die1.DieValue + die2.DieValue;
            if (player.Index == 30)
            {
                //this.state = JailState;
            }
            else if (player.Index > 39)
            {
                player.Index = player.Index - 40;
            }
        }
    }
}
