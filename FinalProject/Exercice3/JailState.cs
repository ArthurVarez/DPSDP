using System;
namespace FinalProject
{
    public class JailState: State
    {
        private int round;
        private Player player;

        public JailState(Player player) // This is the state for the player when he is in jail
        {
            this.round = 0;
            this.player = player;
            this.player.WhatsMyState = "In Jail";
        }

        public override void Play(Player player) // Play method calling in Game (PlayRound)
        {
            if (TryToBeFree(player)) // The Player try to being free 
            {
                this.player.State = new FreeState(this.player); // Is the method return true, he is free and his state change to FreeState
            }
        }
        public bool TryToBeFree(Player player)
        {
            Die die1 = new Die(); // Throw first die
            Die die2 = new Die(); // Throw the second one

            if (die1.DieValue == die2.DieValue) // If the value of the two dice are the same 
            {
                int move = die1.DieValue + die2.DieValue; // Move equal the value 
                for (int i = 0; i < move; i++)
                {
                    player.Index = player.Index.NextSquare; // Moving on the squares 
                }
                Console.WriteLine("die 1 = " + die1.DieValue + " die 2 = " + die2.DieValue); // Display the two values 
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
