using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        /// <summary>
        /// The TOP reference of the Stack.
        /// </summary>
        public Node Top { get; set; } = null;

        /// <summary>
        /// Pushes a new Node to the Top of the Stack.
        /// </summary>
        /// <param name="value">The value the new Node will hold.</param>
        public void Push(int value)
        {
            Node newNode = new Node(value);

            newNode.Next = Top;
            Top = newNode;
        }

        /// <summary>
        /// Tells us if the Stack is empty or not.
        /// </summary>
        /// <returns>A boolean value determined by whether or not the Stack is empty.</returns>
        public bool IsEmpty()
        {
            return Top != null;
        }
    }
}
