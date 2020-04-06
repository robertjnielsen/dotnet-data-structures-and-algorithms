using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public abstract class BinaryTree
    {
        /// <summary>
        /// The Root Node of the Tree.
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// An integer List that will be converted to an array for return upon Tree traversal.
        /// </summary>
        public List<int> NodeValues = new List<int>();

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

            NodeValues.Add(root.Value);

            PreOrder(root.LeftChild);

            PreOrder(root.RightChild);

            return NodeValues.ToArray();
        }

    }
}
