using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class Node
    {
        /// <summary>
        /// The string value the Node holds.
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// The int value the Node holds.
        /// </summary>
        public int IntValue { get; set; }

        /// <summary>
        /// The reference to the left child of the Node.
        /// </summary>
        public Node LeftChild { get; set; }

        /// <summary>
        /// The reference to the right child of the Node.
        /// </summary>
        public Node RightChild { get; set; }

        /// <summary>
        /// Constructor method to instantiate a new Node with no Values.
        /// </summary>
        public Node()
        {
        }

        /// <summary>
        /// Constructor method to instantiate a new Node with a string Value.
        /// </summary>
        /// <param name="value">The string Value to instantiate the Node with.</param>
        public Node(string value)
        {
            StringValue = value;
        }

        /// <summary>
        /// Constructor method to instantiate a new Node with an int Value.
        /// </summary>
        /// <param name="value">The int Value to instantiate the Node with.</param>
        public Node(int value)
        {
            IntValue = value;
        }

        /// <summary>
        /// Constructor method to instantiate a new Node with string and int Values.
        /// </summary>
        /// <param name="stringValue">The string Value of the new Node.</param>
        /// <param name="intValue">The int Value of the new Node.</param>
        public Node(string stringValue, int intValue)
        {
            StringValue = stringValue;
            IntValue = intValue;
        }
    }
}
