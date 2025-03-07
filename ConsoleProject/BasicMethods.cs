using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class BasicMethods
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public string ReverseString(string input)
        {
            // Stack follows LIFO
            Stack<char> stack = new Stack<char>();
            StringBuilder sb = new StringBuilder();

            // Push each character onto the stack
            foreach (char c in input)
            {
                stack.Push(c);
            }

            // Pop characters to reverse the string
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            return sb.ToString();
        }

        public bool IsPalindrome(string input)
        {
            return input.Equals(ReverseString(input));
        }
    }
}
