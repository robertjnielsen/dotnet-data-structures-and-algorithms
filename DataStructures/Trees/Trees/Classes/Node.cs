using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Node
    {
        /// <summary>
        /// The value of the Node.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// A reference to the left child of the Node in the Tree.
        /// </summary>
        public Node LeftChild { get; set; }

        /// <summary>
        /// A reference to the right child of the Node in the Tree.
        /// </summary>
        public Node RightChild { get; set; }

        /// <summary>
        /// Constructor method for a new Node object.
        /// </summary>
        /// <param name="value">The integer value that the Node will hold.</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
