using System;
namespace FinalProject
{
    public class JailState: State
    {
        private int round;
        private Player player;

        public JailState(Player player)
        {
            this.round = 0;
            this.player = player;
            this.player.WhatsMyState = "In Jail";

        }

        public override void Play(Player player)
        {
            player.Index = 30;
            if (TryToBeFree(player))
            {
                this.player.State = new FreeState(this.player);
            }

        }
        public bool TryToBeFree(Player player)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            if(die1.DieValue == die2.DieValue)
            {
                player.Index += die1.DieValue + die2.DieValue;
                if (player.Index > 39)
                {
                    player.Index = player.Index - 40;
                }
                return true;

            }
            else
            {
                this.round += 1;
                if (this.round==3)
                {
                    player.Index += die1.DieValue + die2.DieValue;
                    if (player.Index > 39)
                    {
                        player.Index = player.Index - 40;
                    }
                    return true;

                }

            }
            return false;

        }
    }
}
