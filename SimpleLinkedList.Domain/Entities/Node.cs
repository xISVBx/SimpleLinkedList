using SimpleLinkedList.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList.Domain.Entities
{
    public class Node<T> : INode<T?>
    {        
        public T? Data { get; set; }
        public INode<T?>? Next { get; set; }
        public Node()
        {
            Data = default(T);
            Next = null;
        }
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
        public Node(INode<T?> next)
        {
            Next = next;
            Data = default(T);
        }
        public Node(T data, INode<T?> next)
        {
            Data = data;
            Next = next;
        }

        public bool HaveEqualData(INode<T?> otherNode)
        {
            if (this == null && otherNode == null)
                return true;

            if (otherNode == null)
                return false;

            return this.Data.Equals(otherNode.Data);
        }
    }
}
