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

        public int DiceRoll()
        {
            Random random = new Random();
            return random.Next(0, 6);
        }

    }
}
