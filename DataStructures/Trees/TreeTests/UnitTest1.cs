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
            BinarySearchTree tree = new BinarySearchTree();
            Node node = new Node(3);

            tree.Root = node;
            int expected = 3;

            Assert.Equal(expected, tree.Root.Value);
        }
    }
}
