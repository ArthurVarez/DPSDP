using System;
namespace FinalProject
{
    public class Die
    {
        private int dieValue;
        public Die()
        {
            this.dieValue = DiceRoll();
        }

        public int DieValue { get => dieValue; set => dieValue = value; }

        public int DiceRoll()// Changes the value of the die into a random number between 1 and 6
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

    }
}
