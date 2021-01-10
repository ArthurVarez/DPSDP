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
            if (TryToBeFree(player))
            {
                this.player.State = new FreeState(this.player);
            }
        }
        public bool TryToBeFree(Player player)
        {
            Die die1 = new Die();
            Die die2 = new Die();

            if (die1.DieValue == die2.DieValue)
            {
                int move = die1.DieValue + die2.DieValue;
                for (int i = 0; i < move; i++)
                {
                    player.Index = player.Index.NextSquare;
                }
                Console.WriteLine("move= " + move);
                return true;
            }
            else
            {
                this.round += 1;
                if (this.round==3)
                {
                    int move = die1.DieValue + die2.DieValue;
                    for (int i = 0; i < move; i++)
                    {
                        player.Index = player.Index.NextSquare;
                    }

                    return true;
                }
            }
            return false;
        }
    }
}
