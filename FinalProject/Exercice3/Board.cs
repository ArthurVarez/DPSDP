using System;
using System.Collections.Generic;


namespace FinalProject
{
    public class Board
    {
        private int size; // Size of the board
        List<Square> listSquares = new List<Square>(); // A board is composed with a list of squares 
        private Square start; // Start is the first square, means square index 0

        public Square Start { get => start; set => start = value; }

        public Board(int size)
        {
            this.size = size;
            buildSquares();
            linkSquares();
        }

        public void buildSquares() // Function to build the board by building squares objects
        {
            for(int i=0; i<this.size;i++)
            {
                Square square = new Square("square" + i, i); // Create len(size) squares with i for index
                listSquares.Add(square); // Add them to the list of squares 
            }
            this.start = listSquares[0]; // Set the start square on the first create square
        }
        public void linkSquares() // Method to link the squares as a circular list
        {
            for (int i = 0; i < this.size; i++)
            {
                // Links the square with the next one looking to their index
                Square current = listSquares[i];
                Square next = listSquares[(i + 1) % this.size]; // %size allow to join the last one next with the first one because size%size = 0
                current.setNextSquare(next); // Use square method to set the current next
            }

        }
    }
}
