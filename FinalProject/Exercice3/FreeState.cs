using System;
namespace FinalProject
{
    public class FreeState:State
    {
        private Player player;

        public FreeState(Player player)
        {
            this.player = player;
            this.player.WhatsMyState = "Free";
        }
        public override void Play(Player player)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            int move = die1.DieValue + die2.DieValue;
            for (int i = 0; i < move; i++)
            {
                player.Index = player.Index.NextSquare;
            }
            if (player.Index.Index == 30) // If the player arrives on the "Go to jail" square he goes in jail and his state changes.
            {
                this.player.State = new JailState(this.player);
            }
        }
    }
}
