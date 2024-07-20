using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList.Domain.Interfaces
{
    public interface INode<T>
    {
        public T? Data { get; set; }
        public INode<T>? Next { get; set; }

        public bool HaveEqualData(INode<T> node);
    }
}
