using System;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new IntTree and populate it with Nodes.
            IntTree tree = new IntTree();
            tree.Add(tree.Root, 10);
            tree.Add(tree.Root, 5);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 4);
            tree.Add(tree.Root, 7);
            tree.Add(tree.Root, 15);

            // Convert the IntTree Nodes to an array of int values.
            int[] TreeArray = tree.PreOrder(tree.Root);

            // Output the int array to the console.
            foreach (int value in TreeArray)
            {
                Console.Write($"{value}, ");
            }
            Console.WriteLine();

            // Convert the IntTree to a FizzBuzz StringTree.
            StringTree st = FizzBuzzTree(tree);

            // Convert the StringTree Nodes to an array of string values.
            string[] FizzArray = st.PreOrder(st.Root);

            // Output the string array to the console.
            foreach (string value in FizzArray)
            {
                Console.Write($"{value}, ");
            }
            Console.WriteLine();
        }

        static StringTree FizzBuzzTree(IntTree tree)
        {
            StringTree NewTree = new StringTree();

            PreOrderFizzBuzz(tree.Root, NewTree);

            return NewTree;
        }

        static void PreOrderFizzBuzz(Node root, StringTree newTree)
        {
            if (root.IntValue % 3 == 0 && root.IntValue % 5 == 0)
            {
                newTree.Add(root, "FizzBuzz", root.IntValue);
            }
            else if (root.IntValue % 3 == 0)
            {
                newTree.Add(root, "Fizz", root.IntValue);
            }
            else if (root.IntValue % 5 == 0)
            {
                newTree.Add(root, "Buzz", root.IntValue);
            }
            else
            {
                newTree.Add(root, root.IntValue.ToString(), root.IntValue);
            }

            PreOrderFizzBuzz(root.LeftChild, newTree);

            PreOrderFizzBuzz(root.RightChild, newTree);
        }
    }
}
