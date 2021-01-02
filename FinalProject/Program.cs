using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularList<Player> l = new CircularList<Player>();
            Player player1 = new Player("1");
            Player player2 = new Player("2");
            Player player3 = new Player("3");
            Node<Player> node1 = new Node<Player>(player1);
            Node<Player> node2 = new Node<Player>(player2);
            Node<Player> node3 = new Node<Player>(player3);

            l.AddNode(node1);
            l.AddNode(node2);
            l.AddNode(node3);
            Console.WriteLine("root " + l.root);
            Console.WriteLine("root next :" + l.root.next);
            Console.WriteLine("tail " + l.tail);

        }
    }
}
