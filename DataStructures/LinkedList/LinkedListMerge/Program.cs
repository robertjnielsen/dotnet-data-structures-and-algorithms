using System;
using LinkedList.Classes;

namespace LinkedListMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static LinkList MergeLists(LinkList list1, LinkList list2)
        {
            // Declare two "current" Nodes for each list.
            Node c1 = list1.Head;
            Node c2 = list2.Head;

            // Declare two temporary Nodes.
            Node t1;
            Node t2;

            // Loop while either list has more Nodes.
            while (c1.Next != null || c2.Next != null)
            {
                // Check that both lists have more Nodes.
                if (c1.Next != null && c2.Next != null)
                {
                    // Assign the temp Nodes to Next in each list.
                    t1 = c1.Next;
                    t2 = c2.Next;

                    // Tell list2 to reference the Next Node in list1.
                    c2.Next = t1;

                    // Tell list1 to reference current Node in list2.
                    c1.Next = c2;

                    // Move the current Node in each list forward.
                    c1 = t1;
                    c2 = t2;
                }
                // Check if list1 is running on empty...
                else if (c1.Next == null)
                {
                    // Tell list1 to append the remainder of c2 to itself.
                    c1.Next = c2;

                    // Break out of the loop, it's not needed any more.
                    break;
                }
                // Check if list2 is running on empty...
                else if (c2.Next == null)
                {
                    // Add the last Node in list2 to list1, then carry on with list1.
                    c2.Next = c1.Next;
                    c1.Next = c2;

                    // Break out of the loop, it's not needed any more.
                    break;
                }
            }

            // Check if both lists are running on empty...
            if (c1.Next == null && c2.Next == null)
            {
                c1.Next = c2;
            }

            // Return the completely merged list1.
            return list1;
        }
    }
}
