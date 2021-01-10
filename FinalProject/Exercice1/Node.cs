using System;
namespace FinalProject
{
	public class Node<T> : IEquatable<Node<T>>
	{
		// here we have a generic node class implementing IEquatable for generic nodes 
		public Node(T val)
		{	//constructor for generic node
			data = val;
			next = null;
		}

		public T data { get; set; }
		public Node<T> next { get; set; }

		public bool Equals(Node<T> other)
		{
			/// implemeting the inteface to compare 2 node
			return this.GetHashCode() == other.GetHashCode();
		}

		public override int GetHashCode()
		{
			// thank's to this method we can get the hashcode
			return data.GetHashCode();
		}
    }

}