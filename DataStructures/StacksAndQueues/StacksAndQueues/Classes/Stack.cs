using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; } = null;

        public void Push(int value)
        {
            Node newNode = new Node(value);


        }
    }
}
