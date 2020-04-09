using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxBinaryTree.Classes
{
    public class BinaryTree
    {
        /// <summary>
        /// The Root Node of the Tree.
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        ///  Instantiates an empty Tree.
        /// </summary>
        public BinaryTree()
        {

        }

        /// <summary>
        /// Instantiates a new Tree with a Root Node.
        /// </summary>
        /// <param name="root"></param>
        public BinaryTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Adds a new Node to the Tree.
        /// </summary>
        /// <param name="node">The Node used to traverse the Tree.</param>
        /// <param name="value">The value to add to the Tree.</param>
        /// <returns>The Node being acted upon.</returns>
        public Node Add(Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value);
            }
            else if (value < node.Value)
            {
                node.LeftChild = Add(node.LeftChild, value);
            }
            else
            {
                node.RightChild = Add(node.RightChild, value);
            }

            return node;
        }
    }
}
