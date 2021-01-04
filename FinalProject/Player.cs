using System;
namespace FinalProject
{
    public class Player
    {
        private State state;
        private string name;
        private int index;
        private string test;

        public string Name { get => name; set => name = value; }
        public int Index { get => index; set => index = value; }
        public State State { get => state; set => state = value; }
        public string Test { get => test; set => test = value; }

        public Player(string name)
        {
            this.name = name;
            this.index = 0;
            this.state = new FreeState(this);
        }
        public void Play()
        {
            this.state.Play(this);
        }

    }
}
