using System;
namespace FinalProject
{
    public class CustomQueue<T>
    {
        public Node<T> head { get; set; }

		public void Enqueue(Node<T> node)
		{
			Node<T> new_node = new Node<T>(node.data);

			if (head == null)
				head = new_node;

			Node<T> current = head;
			while (current.next!=null)
            {
				current = current.next;
			}
			current.next = new Node<T>(node.data);

		}

		public Node<T> Dequeue()
        {
			Node<T> temp = new Node<T>(head.data);
			head= head.next;
			return temp;
        }



	}
}
