namespace HashTables.Classes
{
    public class LinkList
    {
        /// <summary>
        /// The first Node in the LinkList. Acts as the entry point in the LinkList.
        /// </summary>
        /// <value></value>
        public Node Head { get; set; } = null;

        /// <summary>
        /// A temporary Node used to traverse through the LinkList.
        /// </summary>
        /// <value></value>
        public Node Current { get; set; }

        /// <summary>
        /// Constructor method to instantiate an empty LinkList.
        /// </summary>
        public LinkList(){}

        /// <summary>
        /// Constructor method to instantiate a LinkList with a Head Node.
        /// </summary>
        /// <param name="node"></param>
        public LinkList(Node node)
        {
            Head = node;
        }

        /// <summary>
        /// Adds a new Node to the end of the LinkList.
        /// </summary>
        /// <param name="node">The Node to add to the LinkList.</param>
        public void Append(Node node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Current = Head;

                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                Current.Next = node;
            }
        }
    }
}