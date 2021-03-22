using System.Collections.Generic;
using System;

namespace Task2_2
{
    class StackCollection
    {
        public static Stack<int> StackCreation(int i)
        {
            Stack<int> newStack = new Stack<int>();
            Random ranNum = new Random();

            for (int j = 0; j < i; j++)
            {
                newStack.Push(ranNum.Next(1, 10000));
            }
            return newStack;
        }
        public static void AddToStack(int i, ref Stack<int> newStack)
        {
            newStack.Push(i);
        }
        public static void SearchStack(int i, ref Stack<int> newStack)
        {
            newStack.Contains(i);
        }
        public static void DeleteStack(int i, ref Stack<int> newStack)
        {
            newStack.Pop();
        }
    }
}
