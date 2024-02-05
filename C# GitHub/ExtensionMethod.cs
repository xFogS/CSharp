using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension
{
    static class ExtensionMethod
    {
        public static bool Fibonacci(this int value)
        {
            int f1 = 0, f2 = 1, f3 = f1 + f2;
            while (f3 <= value)
            {
                if (value == f3) return true;
                f1 = f2; f2 = f3; f3 = f1 + f2;
            }
            return false;
        }
        public static int Symbols(this string str)
        {
            return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count();
        }
        public static int LenghtLine(this string str) //можливо і скоротити моно, але у мене якось так
        {
            int count = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[str.Length - 1 - i] != ' ') count++;
                else break;
            }
            return count;
        }
        public static bool BracketsLine(this string str) //Недороблене в плані закр душки. ([{{})}])str[i]. А так вроді норм працює
        {
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == '[' || str[i] == '{' || str[i] == '(')
                {
                    stack.Push(str[i].ToString());
                }
                if (stack.Peek() == "[" && str[i] == ']') stack.Pop();
                else if (stack.Peek() == "{" && str[i] == '}') stack.Pop();
                else if (stack.Peek() == "(" && str[i] == ')') stack.Pop();
            }
            if (stack.Count == 0) return true;
            return false;
        }
        //складно уявити завдання.
        public static bool logicReturn(this int[] arr)
        {
            return true;
        }
    }
}
