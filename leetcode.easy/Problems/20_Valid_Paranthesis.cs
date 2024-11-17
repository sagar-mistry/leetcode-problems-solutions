using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy.Problems
{
    internal class _20_Valid_Paranthesis
    {
        public bool IsValid(string str)
        {
            // Dictionary to store matching pairs of brackets
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                {')', '('},
                {'}', '{'},
                {']', '['}
            };
            Stack<char> charStack = new Stack<char>();
            foreach (char character in str)
            {
                if (bracketPairs.ContainsKey(character))
                {
                    char topElement = charStack.Count() > 0 ? charStack.Pop() : '#';
                    if (topElement != bracketPairs[character])
                    {
                        return false;
                    }
                }
                else
                {
                    charStack.Push(character);
                }
            }
            return charStack.Count() == 0;
        }
    }
}
