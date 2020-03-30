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
        private Node Rear { get; set; }

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
