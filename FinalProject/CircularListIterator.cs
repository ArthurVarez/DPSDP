using System;
namespace FinalProject
{
    public class CircularListIterator<T>:Iterator
    {
        private CircularList<T> l;
        private Node<T> current;

        public CircularListIterator(CircularList<T>l)
        {
            this.l = l;
        }
        public bool hasNext()
        {
            if (current == null)
                return (l.root != null);
            else
                return (current.next != null);
        }

        public object next()
        {
            if (current == null)
                current = l.root;
            else if (hasNext())
                current = current.next;

            return current;
        }
    }
}
