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
    }
}
