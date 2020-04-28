namespace HashTable.Classes
{
    public class Node
    {
        /// <summary>
        /// The Key for the Node data.
        /// </summary>
        /// <value></value>
        public string Key { get; set; }

        /// <summary>
        /// The Value of the Node data.
        /// </summary>
        /// <value></value>
        public T Value { get; set; }

        /// <summary>
        /// The next Node in the LinkedList.
        /// </summary>
        /// <value></value>
        public Node Next { get; set; }

        /// <summary>
        /// Constructor method to instantiate a new Node.
        /// </summary>
        /// <param name="key">The Key for the new Node's data.</param>
        /// <param name="value">The Value of the new Node's data.</param>
        public Node(string key, t value)
        {
            Key = key;
            Value = value;
        }
    }
}