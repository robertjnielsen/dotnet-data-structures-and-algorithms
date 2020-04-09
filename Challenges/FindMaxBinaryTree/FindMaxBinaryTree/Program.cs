using System;
using FindMaxBinaryTree.Classes;

namespace FindMaxBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(0);
            BinaryTree tree = new BinaryTree(node);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 9);
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 19);
            tree.Add(tree.Root, 5);
            tree.Add(tree.Root, 27);

            int maxValue = FindMaxBinaryTree(tree);

            Console.WriteLine(maxValue);
        }

        /// <summary>
        /// Traverses a Binary Tree and returns the max int value within the Tree.
        /// </summary>
        /// <param name="tree">The Binary Tree to search.</param>
        /// <returns>The maximum int value within the Tree.</returns>
        public static int FindMaxBinaryTree(BinaryTree tree)
        {
            // Declare MaxValue as the lowest possible int value.
            int MaxValue = int.MinValue;

            // Call the traversal and compare method on the Tree, passing in MaxValue.
            MaxValue = PreOrderMax(tree.Root, MaxValue);

            return MaxValue;
        }

        /// <summary>
        /// Recursively traverses the Tree, comparing the MaxValue to each Node's Value.
        /// </summary>
        /// <param name="root">The Node being compared.</param>
        /// <param name="maxValue">The current MaxValue.</param>
        /// <returns>The updated MaxValue.</returns>
        public static int PreOrderMax(Node root, int maxValue)
        {
            // Compares current maxValue to value of the Node.
            if (root.Value > maxValue)
            {
                // If Node value is greater, assign maxValue as Node value.
                maxValue = root.Value;
            }

            // Recursively call PreOrderMax on any child Nodes in Pre-Order fashion.
            if (root.LeftChild != null)
            {
                PreOrderMax(root.LeftChild, maxValue);
            }

            if (root.RightChild != null)
            {
                PreOrderMax(root.RightChild, maxValue);
            }

            return maxValue;
        }
    }
}
