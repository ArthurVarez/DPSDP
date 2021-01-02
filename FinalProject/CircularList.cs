using System;
namespace FinalProject
{


    public class CircularList<T>
    {
        public int value { get; set; }
        public Node<T> root { get; set; }
        public Node<T> tail { get; set; }


        public CircularList()
        {
        }
        public CircularList(int value, Node<T> root, Node<T> tail)
        {
            this.value = value;
            this.root = root;
            this.tail = tail;


        }
        public void AddNode(Node<T> node)
        {
            Node<T> new_node = new Node<T>(node.data);

            if (root == null)
                root = new_node;

            Node<T> temp = 
            this.tail.next = new_node;
            new_node.next = root;

        }


        //Test


    }
}
