using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        /// <summary>
        /// Determines the Front Node in the Queue.
        /// </summary>
        public Node Front { get; set; } = null;

        /// <summary>
        /// Determines the Rear Node in the Queue.
        /// </summary>
        private Node Rear { get; set; } = null;

        /// <summary>
        /// Adds a new Node to the Rear of the Queue.
        /// </summary>
        /// <param name="value">The value passed to the new Node object.</param>
        public void Enqueue(int value)
        {
            // Instantiate a new Node object with the given value.
            Node newNode = new Node(value);

            // Tell the current Rear Node to reference the new Node.
            Rear.Next = newNode;

            // Tell the Queue that the new Node is now the Rear.
            Rear = newNode;
        }

        /// <summary>
        /// Determines if the Queue is empty or not.
        /// </summary>
        /// <returns>Returns a boolean value determined by whether or not the Queue is empty.</returns>
        public bool IsEmpty()
        {
            return Front == null;
        }
    }
}
