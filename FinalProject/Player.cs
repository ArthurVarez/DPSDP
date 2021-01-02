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

        public void PlayDice()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            this.index += die1.DieValue + die2.DieValue;
            if (this.index > 39)
            {
                this.index = this.index - 40;
            }

        }

    }
}
