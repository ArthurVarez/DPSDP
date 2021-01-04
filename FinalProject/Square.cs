using System;
namespace FinalProject
{
    public class Square
    {
        private string name;
        private Square nextSquare;
        private int index;
        public Square(string name, int index)
        {
            this.name = name;
            this.index = index;
        }
        public void setNextSquare(Square s)
        {
            nextSquare = s;
        }
        public Square getNextSquare()
        {
            return nextSquare;
        }
        public string getName() { return name; }
        public int getIndex() { return index; }
    }
}
