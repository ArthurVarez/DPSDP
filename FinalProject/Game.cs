using System;
namespace FinalProject
{
    public class Game<T>
    {
        public Node<T> root { get; set; }
        public Node<T> tail { get; set; }
        public int size { get; set; }
        public CircularList<Player> plateau = new CircularList<Player>();


    }
}
