using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace FinalProject
{
    public class CustomQueue<T>: IEnumerable, IEnumerator
	{
        private Node<T> head;
		public Node<T> Head { get => head; set => head = value; }


		public CustomQueue(Node<T> head)
		{
			this.head = head;
		}

		public CustomQueue()
		{
		}

		public void Enqueue(T val)
		{
			Node<T> new_node = new Node<T>(val);

			if (head == null)
            {
				head = new_node;
			}

			Node<T> current = head;
			while (current.next!=null)
            {
				current = current.next;
			}
			current.next = new_node;

		}

		public Node<T> Dequeue()
        {
			Node<T> temp = new Node<T>(head.data);
			head= head.next;
			return temp;
        }

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)this;
		}

		public bool MoveNext()
		{
			if (this.head == null)
			{
				return false;
			}
			return true;
		}
		public void Reset()
		{

		}
		public object Current
		{
			get { return Dequeue(); }
		}

	}
}
