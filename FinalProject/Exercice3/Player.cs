using System;
namespace FinalProject
{
    public class Player
    {
        private State state; // State of the player (FreeState or JailState)
        private string name;
        private string whatsMyState; // "Free" or "In Jail"
        private Square index;
        private Board board;

        public string Name { get => name; set => name = value; }
        public State State { get => state; set => state = value; }
        public string WhatsMyState { get => whatsMyState; set => whatsMyState = value; }
        public Square Index { get => index; set => index = value; }

        public Player(string name, Board board)
        {
            this.name = name;
            this.index = board.Start; // // Initial position of a player
            this.state = new FreeState(this);
            this.board = board;
        }
        public void Play() // Plays the player's turn according to his state
        {
            this.state.Play(this);
        }

    }
}
