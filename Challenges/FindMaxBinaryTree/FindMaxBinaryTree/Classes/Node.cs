using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxBinaryTree.Classes
{
    public class Node
    {
        /// <summary>
        /// The int Value that the Node holds.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// The reference to the LeftChild Node.
        /// </summary>
        public Node LeftChild { get; set; }

        /// <summary>
        /// The reference to the RightChild Node.
        /// </summary>
        public Node RightChild { get; set; }

        /// <summary>
        /// Constructor method to instantiate a new Node object.
        /// </summary>
        /// <param name="value">The value that the Node will hold.</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
