using SimpleLinkedList.Domain.Interfaces;

namespace SimpleLinkedList.Domain.Entities
{
    public class SimpleLinkedList<T> : ISimpleLinkedList<T>
    {
        public INode<T?>? Head { get; set; }
        public INode<T?>? Tail { get; set; }

        public bool Add(T? data)
        {
            INode<T?> newNode = new Node<T?>(data);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return true;
            }
            Tail!.Next = newNode;
            Tail = newNode;
            return true;
        }
    }
}
