using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        /// <summary>
        /// Constructor to create an empty instance.
        /// </summary>
        public BinarySearchTree()
        {
            Root = null;
        }

        /// <summary>
        /// Constructor to create an instance with a new Root Node.
        /// </summary>
        /// <param name="value">The value to pass into the new Root Node.</param>
        public BinarySearchTree(int value)
        {
            Root = new Node(value);
        }

        /// <summary>
        /// Adds a new Node to the Binary Search Tree in the correct location.
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
            else if (value < root.Value)
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
        /// Traverses a Tree and determines if it contains a Node with the given Value.
        /// </summary>
        /// <param name="root">The Node to determine Tree traversal.</param>
        /// <param name="value">The value to search for in the Tree.</param>
        /// <returns>Returns a boolean determined by whether or not the Tree contains a Node with the given Value.</returns>
        public bool Contains(Node root, int value)
        {
            if (root.Value == value)
            {
                return true;
            }
            else if (root.Value > value)
            {
                return Contains(root.LeftChild, value);
            }
            else if (root.Value < value)
            {
                return Contains(root.RightChild, value);
            }

            return false;
        }
    }
}
