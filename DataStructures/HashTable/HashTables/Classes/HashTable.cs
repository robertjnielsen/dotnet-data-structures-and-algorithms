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
        public LinkedList<Node>[] Table { get; set; }

        /// <summary>
        /// Constructor method to instantiate a new HashTable.
        /// </summary>
        /// <param name="size">The size of the HashTable array.</param>
        public HashTable(int size)
        {
            Size = size;
            Table = new LinkedList<Node>[size];
        }

        /// <summary>
        /// Adds a Key / Value pair to the HashTable.
        /// </summary>
        /// <param name="key">The Key to add to the HashTable.</param>
        /// <param name="value">The Value to add to the HashTable.</param>
        public void Add(string key, string value)
        {
            int index = Hash(key);

            if (Table[index] == null)
            {
                LinkedList<Node> ll = new LinkedList<Node>();
                Node newNode = new Node(key, value);
                ll.AddFirst(newNode);
                Table[index] = ll;
            }
            else
            {
                Node newNode = new Node(key, value);
                Table[index].Append(newNode);
            }
        }

        /// <summary>
        /// Hashes the inputted Key.
        /// </summary>
        /// <param name="key">The Key to hash.</param>
        /// <returns>The index value of the hashed Key.</returns>
        public int Hash(string key)
        {
            int count = 1;

            foreach (char c in key)
            {
                count *= c / 3;
            }

            count = count % this.Size;

            return count;
        }


    }
}