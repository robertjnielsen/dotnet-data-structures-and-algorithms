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
        /// Removes the Front Node from the Queue.
        /// </summary>
        /// <returns>Returns the Value of the current Front Node.</returns>
        public int Dequeue()
        {
            // Throw an Exception if the Queue is empty.
            if (IsEmpty())
            {
                throw new Exception("Cannot Dequeue! The Queue is empty.");
            }

            // Create a temporary reference to the Front Node.
            Node temp = Front;

            // Tell the current Front Node to reference the Next Node in the Queue.
            Front = Front.Next;

            // Remove any Next reference from the temporary Node.
            temp.Next = null;

            return temp.Value;
        }

        /// <summary>
        /// Returns the Value of the Front Node in the Queue.
        /// </summary>
        /// <returns>Returns the Value of the Front Node in the Queue.</returns>
        public int Peek()
        {
            // Throw an Exception if the Queue is empty.
            if (IsEmpty())
            {
                throw new Exception("Cannot Peek! The Queue is empty.");
            }

            return Front.Value;

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
