using System;
namespace FinalProject
{
    public class JailState: State
    {
        private int round;
        private State state;

        public JailState(State state)
        {
            this.round = 0;
            this.state = state;
        }

        public override void Play(Player player)
        {
            player.Index = 30;
            if (TryToBeFree(player))
            {
                //this.state = FreeState();
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
                    return true;
                }
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
                        return true;
                    }

                }

            }
            return false;

        }
    }
}
