using SimpleLinkedList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList.Domain.Interfaces
{
    public interface ISimpleLinkedList<T>
    {
        /// <summary>
        /// The first node in the list
        /// </summary>
        public INode<T?>? Head { get; set; }
        /// <summary>
        /// The last node in the list
        /// </summary>
        public INode<T?>? Tail { get; set; }
        /// <summary>
        /// Adds a new element to the data structure.
        /// </summary>
        /// <param name="data">The item to add.</param>
        /// <returns>returns true if the element was added successfully; otherwise false.</returns>
        public bool Add(T data);
    }
}
