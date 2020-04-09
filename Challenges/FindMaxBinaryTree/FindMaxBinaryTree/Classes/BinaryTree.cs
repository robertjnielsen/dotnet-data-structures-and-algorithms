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
    }
}
