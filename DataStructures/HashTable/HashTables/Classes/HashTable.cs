using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashTables.Classes
{
    public class HashTable
    {
        /// <summary>
        /// The size of the HashTable array.
        /// </summary>
        /// <value></value>
        public int Size { get; set; }

        /// <summary>
        /// The array making up the HashTable.
        /// </summary>
        /// <value></value>
        public LinkList[] Table { get; set; }

        /// <summary>
        /// Constructor method to instantiate a new HashTable.
        /// </summary>
        /// <param name="size">The size of the HashTable array.</param>
        public HashTable(int size)
        {
            Size = size;
            Table = new LinkList[size];
        }

        /// <summary>
        /// Adds a Key / Value pair to the HashTable.
        /// </summary>
        /// <param name="key">The Key to add to the HashTable.</param>
        /// <param name="value">The Value to add to the HashTable.</param>
        public void Add(string key, string value)
        {
            // Hash the key to determine the index to Add to.
            int index = Hash(key);

            // If the current index is empty, instantiate a new LinkList and add a Node containing the key and value.
            if (Table[index] == null)
            {
                LinkList ll = new LinkList();
                Node newNode = new Node(key, value);
                ll.Append(newNode);
                Table[index] = ll;
            }
            // If the current index is NOT empty, append a Node containing the key and value to the end of the LinkList.
            else
            {
                Node newNode = new Node(key, value);
                Table[index].Append(newNode);
            }
        }

        /// <summary>
        /// Retrieve a value in the HashTable by its known key.
        /// </summary>
        /// <param name="key">The key to search for in the HashTable.</param>
        /// <returns>The value associated with the key.</returns>
        public string Get(string key)
        {
            int index = Hash(key);
            var bucket = Table[index];
            bucket.Current = bucket.Head;
            Node current = bucket.Current;

            while (current.Key != key)
            {
                current = current.Next;
            }

            if (current.Key == key)
            {
                return current.Value;
            }
            
            return null;
        }

        /// <summary>
        /// Determines if a Key is pre-existing in the HashTable.
        /// </summary>
        /// <param name="key">The key to search for in the HashTable.</param>
        /// <returns>True or false.</returns>
        public bool Contains(string key)
        {
            int index = Hash(key);
            var bucket = Table[index];
            bucket.Current = bucket.Head;
            Node current = bucket.Current;

            while (current.Key != key)
            {
                current = current.Next;
            }

            if (current.Key == key)
            {
                return true;
            }
            
            return false;
        }

        /// <summary>
        /// Hashes the inputted Key.
        /// </summary>
        /// <param name="key">The Key to hash.</param>
        /// <returns>The index value of the hashed Key.</returns>
        public int Hash(string key)
        {
            int count = 1;

            // Set count equal to the product of the current count and the ASCII value of each char in the key divided by three.
            foreach (char c in key)
            {
                count *= c / 3;
            }

            // Grab the remainder of the current count divided by the size of the HashTable.
            count = count % this.Size;

            return count;
        }


    }
}