using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashTable.Classes
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


    }
}