using System;
namespace FinalProject
{
    public class Player
    {
        private State state;
        private string name;
        private string whatsMyState;
        private Square index;
        private Board board;

        public string Name { get => name; set => name = value; }
        public State State { get => state; set => state = value; }
        public string WhatsMyState { get => whatsMyState; set => whatsMyState = value; }
        public Square Index { get => index; set => index = value; }

        public Player(string name, Board board)
        {
            this.name = name;
            this.index = board.Start;
            this.state = new FreeState(this);
            this.board = board;
        }
        public void Play()
        {
            this.state.Play(this);
        }

    }
}
