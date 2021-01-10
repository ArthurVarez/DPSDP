using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace FinalProject
{
    public class CustomQueue<T>: IEnumerable, IEnumerator
	{
		//here we implement  IEnumerable, IEnumerator two allow us to interate on our list

		private Node<T> head; /// here is the first element of our custom queue
		public Node<T> Head { get => head; set => head = value; }


		// 2 constructors if we want to instanciate with a head or not 
		public CustomQueue(Node<T> head)
		{
			this.head = head;
		}

		public CustomQueue()
		{
		}

		public void Enqueue(T val)
		{
			//method to add an node 
			Node<T> new_node = new Node<T>(val);

			if (head == null)
            {
				// if the queue as no node we insert in first position
				head = new_node;
			}

			Node<T> current = head;
			// interation to find the last node
			while (current.next!=null)
            {
				current = current.next;
			}
			//addind the element to the last previous one 
			current.next = new_node;

		}

		//method to pop the last node
		public Node<T> Dequeue()
        {
			// FIFO -> the fisrt node inserted is returnde
			Node<T> temp = new Node<T>(head.data);
			head= head.next;
			return temp;
        }

		public IEnumerator GetEnumerator()
		{
			//implementation of the interface to loop on the queue
			return (IEnumerator)this;
		}

		public bool MoveNext()

		{	//method to know if there's a next node or not (end of the queue)
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
			// access the current element 
		{
			get { return Dequeue(); }
		}

	}
}
