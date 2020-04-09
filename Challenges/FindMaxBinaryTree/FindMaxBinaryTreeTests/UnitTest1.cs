using System;
using Xunit;
using FindMaxBinaryTree;
using FindMaxBinaryTree.Classes;

namespace FindMaxBinaryTreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateAnEmptyTree()
        {
            BinaryTree tree = new BinaryTree();

            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanInstantiateANewTreeWithARootNode()
        {
            Node node = new Node(3);
            BinaryTree tree = new BinaryTree(node);

            int expected = 3;
            int value = tree.Root.Value;

            Assert.Equal(expected, value);
        }

        [Fact]
        public void CanReturnMaxValueOfTreeWithASingleNode()
        {
            Node node = new Node(3);
            BinaryTree tree = new BinaryTree(node);

            int expected = 3;
            int maxValue = Program.FindMaxBinaryTree(tree);

            Assert.Equal(expected, maxValue);
        }

        [Fact]
        public void CanReturnMaxValueOfTreeWithMultipleNodes()
        {
            Node node = new Node(0);
            BinaryTree tree = new BinaryTree(node);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 9);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 19);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 27);

            int expected = 27;
            int maxValue = Program.FindMaxBinaryTree(tree);

            Assert.Equal(expected, maxValue);
        }
    }
}
