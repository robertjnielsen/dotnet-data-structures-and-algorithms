using System;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            IntTree tree = new IntTree(10);

            tree.Add(tree.Root, 5);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 4);
            tree.Add(tree.Root, 7);
            tree.Add(tree.Root, 15);
        }

        static StringTree FizzBuzzTree(IntTree tree)
        {
            StringTree newTree = new StringTree();



            return newTree;
        }
    }
}
