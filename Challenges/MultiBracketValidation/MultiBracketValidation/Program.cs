using System;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Determines if a string containing opening and closing brackets contains valid matching pairs of brackets.
        /// </summary>
        /// <param name="input">A string containing any combination of opening and closing brackets.</param>
        /// <returns>Returns a boolean value whether the input string contains valid bracket pairs or not.</returns>
        static bool MultiBracketValidation(string input)
        {
            // Instantiate a bool to return if brackets are validated or not.
            bool validated;

            // Convert string to a char array.
            char[] chars = input.ToCharArray();

            // Instantiate a new Stack object to hold our opening brackets.
            Stack stack = new Stack();

            // Instantiate counters for opening and closing brackets.
            int OpenCount = 0;
            int CloseCount = 0;

            // Increment through the string for brackets.
            for (int i = 0; i < chars.Length; i++)
            {
                // Check if the char at index 'i' is an opening bracket or closing bracket.
                if (chars[i] == '{' || chars[i] == '(' || chars[i] == '[')
                {
                    // Push opening brackets to the stack and increment 'OpenCount'.
                    stack.Push(chars[i]);
                    OpenCount++;
                }
                else if (chars[i] == '}' || chars[i] == ')' || chars[i] == ']')
                {
                    // Increment 'CloseCount', and determine if opening bracket on stack matches closing bracket at 'chars[i]'.
                    // If not validated, return false.
                    CloseCount++;
                    if (!ValidateOnPop(stack.Pop(), chars[i]))
                    {
                        validated = false;
                        return validated;
                    }
                }
            }

            // Compare if count of open and closing brackets are equal after incrementing through entire char array.
            // If not equal, return false, because there's an extra somewhere that doesn't match.
            if (OpenCount != CloseCount)
            {
                validated = false;
                return validated;
            }

            // No false validation has been detected, must be true.
            validated = true;
            return validated;
        }

        /// <summary>
        /// Determines if opening and closing brackets are matched as they find them.
        /// </summary>
        /// <param name="a">Opening bracket on the Top of the Stack object.</param>
        /// <param name="b">Closing bracket located at 'chars[i]' position.</param>
        /// <returns>Returns a boolean if the brackets match or not.</returns>
        static bool ValidateOnPop(char a, char b)
        {
            return (a == '{' && b == '}') || (a == '(' && b == ')') || (a == '[' && b == ']');
        }
    }
}
