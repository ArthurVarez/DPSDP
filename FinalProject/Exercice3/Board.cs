using System;
using System.Collections.Generic;


namespace FinalProject
{
    public class Board
    {
        private int size;
        List<Square> listSquares = new List<Square>();
        private Square start;

        public Square Start { get => start; set => start = value; }

        public Board(int size)
        {
            this.size = size;
            buildSquares();
            linkSquares();
        }



        public void buildSquares()
        {
            for(int i=0; i<this.size;i++)
            {
                Square square = new Square("square" + i, i);
                listSquares.Add(square);
            }
            this.start = listSquares[0];
        }
        public void linkSquares()
        {
            for (int i = 0; i < this.size; i++)
            {
                Square current = listSquares[i];
                Square next = listSquares[(i + 1) % this.size];
                current.setNextSquare(next);
            }

        }
    }
}
