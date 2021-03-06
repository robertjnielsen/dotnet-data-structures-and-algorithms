﻿using System;
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
        /// Inserts a new Node object to the LinkList before a specified existing Node.
        /// </summary>
        /// <param name="existingValue">The value of the Node to insert before.</param>
        /// <param name="newValue">The value of the new Node object.</param>
        public void InsertBefore(int existingValue, int newValue)
        {
            try
            {
                // Instantiate a new Node object.
                Node newNode = new Node();

                // Assign the new Node object's value to the inputted value.
                newNode.Value = newValue;

                // Assign Current to the Head of the LinkList.
                Current = Head;

                // Traverse the LinkList until we reach the Node we want to insert before.
                while (Current.Next.Value != existingValue)
                {
                    Current = Current.Next;
                }

                // Assign the new Node's Next property to the Node with the value we want to insert before.
                newNode.Next = Current.Next;

                // Assign Current's Next property to the new Node object.
                Current.Next = newNode;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Inserts a new Node object to the LinkList after a specified existing Node.
        /// </summary>
        /// <param name="existingValue">The value of the Node to insert after.</param>
        /// <param name="newValue">The value of the new Node object.</param>
        public void InsertAfter(int existingValue, int newValue)
        {
            try
            {
                // Instantiate a new Node object.
                Node newNode = new Node();

                // Assign the new Node object's value to the inputted value.
                newNode.Value = newValue;

                // Assign Current to the Head of the LinkList.
                Current = Head;

                // Traverse the LinkList to find the Node to insert after.
                while (Current.Value != existingValue)
                {
                    Current = Current.Next;
                }

                // Assign the new Node's Next property to the Node after the Current Node.
                newNode.Next = Current.Next;

                // Assign the Current Node's Next property to the new Node object.
                Current.Next = newNode;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Appends a new Node into the end of the LinkList.
        /// </summary>
        /// <param name="value">The value of the new Node.</param>
        public void Append(int value)
        {
            // Instantiate a new Node object.
            Node newNode = new Node();

            // Set the new Node object's value to the inputted value.
            newNode.Value = value;

            // Assign Current to the Head of the LinkList.
            Current = Head;

            // Traverse the LinkList until we reach the last Node object.
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            // Assign the new Node object's Next value as null.
            newNode.Next = null;

            // Assign Current's Next value as the new Node object.
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
        /// Traverses a LinkList and returns the value of the Node object K elements from the end of the List (where K is the search paramater passed).
        /// </summary>
        /// <param name="numFromEnd">The number of elements from the end of the List to locate.</param>
        /// <returns>Returns the value of the Node object K elements from the end of the List.</returns>
        public int KthFromEnd(int numFromEnd)
        {
            // Throw exception if value passed is a negative integer.
            if (numFromEnd < 0)
            {
                throw new ArgumentOutOfRangeException("Your search parameter must be a positive number.");
            }

            // Specify Current as the Head to initiate traversal of LinkList.
            Current = Head;

            // Declare an integer to count the length of the LinkList.
            int listLength = 0;

            // Traverse the LinkList and increment listLength for each Node object.
            while (Current != null)
            {
                listLength++;
                Current = Current.Next;
            }

            // Throw exception if value passed is larger than the length of the LinkList.
            if (numFromEnd > listLength)
            {
                throw new ArgumentOutOfRangeException("Your search parameter is larger than the total number of Node objects in the List.");
            }

            // Reset Current back to the Head to traverse the List again.
            Current = Head;

            // Traverse the List to the specified Node element.
            for (int i = 1; i < listLength - numFromEnd; i++)
            {
                Current = Current.Next;
            }

            return Current.Value;
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
