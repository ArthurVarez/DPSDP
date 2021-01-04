using System;
namespace FinalProject
{
    public class FreeState:State
    {
        private Player player;

        public FreeState(Player player)
        {
            this.player = player;
            this.player.Test = "Free";
        }
        public override void Play(Player player)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            player.Index += die1.DieValue + die2.DieValue;
            if (player.Index == 30)
            {
                this.player.State = new JailState(this.player);
            }
            else if (player.Index > 39)
            {
                player.Index = player.Index - 40;
            }
        }
    }
}
