using System;
namespace FinalProject
{
    public class Player
    {

        private string name;
        private int index;

        public string Name { get => name; set => name = value; }
        public int Index { get => index; set => index = value; }

        public Player(string name)
        {
            this.name = name;
            this.index = 0;
        }
    }
}
