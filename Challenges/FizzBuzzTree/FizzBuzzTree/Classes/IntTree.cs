using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class IntTree
    {
        /// <summary>
        /// The root Node of the Tree.
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// An integer List that will be converted to an array for return upon Tree traversal.
        /// </summary>
        public List<int> NodeValues = new List<int>();

        /// <summary>
        /// Constructor method if no Node is passed as Root.
        /// </summary>
        public IntTree()
        {
            Root = null;
        }

        /// <summary>
        /// Constructor method if a Node is passed as Root.
        /// </summary>
        /// <param name="root">The Node to become the Root of the Tree.</param>
        public IntTree(int rootValue)
        {
            Root = new Node(rootValue);
        }

        /// <summary>
        /// Adds a new Node to the Tree in the correct location.
        /// </summary>
        /// <param name="root">The Node used to locate the correct position to add a new Node.</param>
        /// <param name="value">The value to pass to the new Node being added.</param>
        /// <returns>Returns the Node being passed for recursion.</returns>
        public Node Add(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else if (value < root.IntValue)
            {
                root.LeftChild = Add(root.LeftChild, value);
            }
            else
            {
                root.RightChild = Add(root.RightChild, value);
            }

            return root;
        }

        /// <summary>
        /// Traverses the Tree in Pre-Order fashion and returns an array of all Node values.
        /// </summary>
        /// <param name="root">The Node that is being checked for a value.</param>
        /// <returns>Returns an array of all Node values within the Tree.</returns>
        public int[] PreOrder(Node root)
        {
            if (root == null)
            {
                return NodeValues.ToArray();
            }

            NodeValues.Add(root.IntValue);

            PreOrder(root.LeftChild);

            PreOrder(root.RightChild);

            return NodeValues.ToArray();
        }
    }
}
