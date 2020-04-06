using System;
using Trees.Classes;
using Xunit;

namespace TreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateAnEmptyTree()
        {
            BinarySearchTree tree = new BinarySearchTree();

            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanInstantiateNewTreeWithARootNode()
        {
            BinarySearchTree tree = new BinarySearchTree(3);

            int expected = 3;

            Assert.Equal(expected, tree.Root.Value);
        }

        [Fact]
        public void CanSuccessfullyAddANodeToTheLeftChild()
        {
            BinarySearchTree tree = new BinarySearchTree(5);

            tree.Add(tree.Root, 3);
            int expected = 3;

            Assert.Equal(expected, tree.Root.LeftChild.Value);
        }
    }
}
