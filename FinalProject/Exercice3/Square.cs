using System;
namespace FinalProject
{
    public class Square // Square associate to an index on the board, it acts like a node of a linked list
    {
        private string name;
        private Square nextSquare;
        private int index;

        public Square NextSquare { get => nextSquare; set => nextSquare = value; }
        public string Name { get => name; set => name = value; }
        public int Index { get => index; set => index = value; }

        public Square(string name, int index)
        {
            this.name = name;
            this.index = index;
        }
        public void setNextSquare(Square square)
        {
            this.nextSquare = square;
        }

    }
}
