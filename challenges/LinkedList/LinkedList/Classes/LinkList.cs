using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }

        private Node Current { get; set; }

        /// <summary>
        /// Inserts a new Node into the beginning of the LinkList.
        /// </summary>
        /// <param name="value">The value of the new Node.</param>
        public void Insert(int value)
        {
            // Instantiate a new Node object.
            Node newNode = new Node();

            // Set the Value of the new Node to the inputted value.
            newNode.Value = value;

            // Specify that the Next property references the current Head of the LinkList.
            newNode.Next = Head;

            // Set the new Node object as the Head.
            Head = newNode;
        }

        /// <summary>
        /// Appends a new Node into the end of the LinkList.
        /// </summary>
        /// <param name="value">The value of the new Node.</param>
        public void Append(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            newNode.Next = null;
            Current.Next = newNode;
        }

        /// <summary>
        /// Traverse through the LinkList to determine if any Node objects hold a desired value.
        /// </summary>
        /// <param name="value">The value to search for within the LinkList.</param>
        /// <returns>Returns true if the value is found, or false if the value is not found.</returns>
        public bool Includes(int value)
        {
            // Set Current as the Head to initiate LinkList traversal.
            Current = Head;

            // Traverse the LinkList
            while (Current != null)
            {
                // Check if inputted value is equal to Value of Current.
                if (Current.Value == value)
                {
                    return true;
                }

                // Set Current to Next, to continue traversal.
                Current = Current.Next;
            }

            // Return false if the value does not exist on any Node in the LinkList.
            return false;
        }

        /// <summary>
        /// Traverses through the LinkList, and utilizes StringBuilder to return a string that contains the value of each Node object in the list.
        /// </summary>
        /// <returns>A string containing the value of each Node object in the LinkList.</returns>
        public override string ToString()
        {
            // Specify Current as the Head to initate traversal of LinkList.
            Current = Head;

            // Instantiate a StringBuilder object.
            StringBuilder sb = new StringBuilder();

            // Traverse the LinkList
            while (Current != null)
            {
                // Append the current value to our StringBuilder object.
                sb.Append($"{Current.Value} -> ");

                // Move to the next Node object.
                Current = Current.Next;
            }

            sb.Append("NULL");
            return sb.ToString();
        }
    }
}
