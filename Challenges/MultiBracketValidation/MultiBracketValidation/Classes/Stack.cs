using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
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
        public void Push(char value)
        {
            // Instantiate a new Node instance to add to the Stack.
            Node newNode = new Node(value);

            // Tell the new Node to reference the current Top Node.
            newNode.Next = Top;

            // Make the new Node the Top of the Stack.
            Top = newNode;
        }

        /// <summary>
        /// Pops the current Top Node off of the Stack.
        /// </summary>
        /// <returns>Returns the Value of the Node that was removed from the Stack.</returns>
        public int Pop()
        {
            // Throw an Exception if the Stack is empty.
            if (IsEmpty())
            {
                throw new Exception("Nothing to Pop! The Stack is empty.");
            }

            // Create a temporary Node reference to the current Top Node.
            Node temp = Top;

            // Assign Top to the Next Node below it.
            Top = Top.Next;

            // Tell the temp Node (was Top) to not reference anything anymore.
            temp.Next = null;

            return temp.Value;
        }

        /// <summary>
        /// Gives us the Value of the current Top Node of the Stack.
        /// </summary>
        /// <returns>Returns the Value of the Top Node of the Stack.</returns>
        public int Peek()
        {
            // Throw an Exception if the Stack is empty.
            if (IsEmpty())
            {
                throw new Exception("Nothing to Peek! The Stack is empty.");
            }

            return Top.Value;
        }

        /// <summary>
        /// Tells us if the Stack is empty or not.
        /// </summary>
        /// <returns>A boolean value determined by whether or not the Stack is empty.</returns>
        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}
