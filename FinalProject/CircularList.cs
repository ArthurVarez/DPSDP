using System;
namespace FinalProject
{


    public class CircularList<T>
    {
        public Node<T> root { get; set; }
        public Node<T> tail { get; set; }
        public int sizeofList;


        public CircularList()
        {
            this.sizeofList = 0;
        }

        /*public CircularList(T value)
        {
            this.value = value;
            this.root = new Node<T>(value);
            var node = new Node<T>(value);
            node.next = node;
            this.root = node;
            this.tail = node;
            sizeofList = 1;


        }
        */
        public void AddNode(Node<T> node)
        {
            Node<T> new_node = new Node<T>(node.data);
            if (this.root == null)
            {
                new_node.next = this.root;
                this.root = new_node;
                sizeofList++;

            }
            new_node.next = this.root;
            this.tail = new_node;
            this.tail.next = this.root;
            sizeofList++;

        }

        public void DeleteNode(Node<T> node)
        {
            Node<T> temp = this.root;
            if (node == this.root)
            {
                this.root = this.root.next;
                this.tail.next = this.root;
                sizeofList--;
            }

            for (int i = 0; i < sizeofList - 1; i++)
            {
                if(node == temp)
                {
                    temp = temp.next;
                    sizeofList--;
                }
                temp = temp.next;

            }
        }


        public void TraverseCircularLL()
        {
            if (this.root == null) return;
            Node<T> tempNode = this.root;
            for (int i = 0; i < sizeofList; i++)
            {
                Console.Write(tempNode.data);
                if (i != sizeofList - 1)
                    Console.Write("-->");
                tempNode = tempNode.next;
            }
            Console.WriteLine("\n");

        }

    }
}
