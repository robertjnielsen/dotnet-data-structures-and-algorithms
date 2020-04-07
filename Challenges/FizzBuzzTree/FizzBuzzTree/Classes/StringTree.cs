using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class StringTree
    {
        /// <summary>
        /// The root Node of the Tree.
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// An integer List that will be converted to an array for return upon Tree traversal.
        /// </summary>
        public List<string> NodeValues = new List<string>();

        /// <summary>
        /// Constructor method if no Node is passed as Root.
        /// </summary>
        public StringTree()
        {
            Root = null;
        }

        /// <summary>
        /// Constructor method if a Node is passed as Root.
        /// </summary>
        /// <param name="root">The Node to become the Root of the Tree.</param>
        public StringTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Adds a new Node to the Tree.
        /// </summary>
        /// <param name="root">The Node being added to the Tree.</param>
        /// <param name="stringValue">The string Value of the Node being added to the Tree.</param>
        /// <param name="intValue">The int Value of the Node being added to the Tree.</param>
        /// <returns>Returns the Node being added to the Tree.</returns>
        public Node Add(Node root, string stringValue, int intValue)
        {
            if (root == null)
            {
                root = new Node(stringValue);
            }
            else if (intValue < root.IntValue)
            {
                root.LeftChild = Add(root.LeftChild, stringValue, intValue);
            }
            else
            {
                root.RightChild = Add(root.RightChild, stringValue, intValue);
            }

            return root;
        }

        /// <summary>
        /// Traverses the Tree in Pre-Order fashion and returns an array of all Node values.
        /// </summary>
        /// <param name="root">The Node that is being checked for a value.</param>
        /// <returns>Returns an array of all Node values within the Tree.</returns>
        public string[] PreOrder(Node root)
        {
            if (root == null)
            {
                return NodeValues.ToArray();
            }

            NodeValues.Add(root.StringValue);

            PreOrder(root.LeftChild);

            PreOrder(root.RightChild);

            return NodeValues.ToArray();
        }
    }
}
