using System.Collections.Generic;
using System;

namespace Task2_2
{
    public class LinkedListCollection
    {
        public static LinkedList<int> LinkedListCreation(int i)
        {
            LinkedList<int> NewLinkedList = new LinkedList<int>();
            Random ranNum = new Random();
            for (int j = 0; j < i; j++)
            {
                NewLinkedList.AddFirst(ranNum.Next(1, 10000));
            }
            return NewLinkedList;
        }

        public static void AddToLinkedList(int i, ref LinkedList<int> NewLinkedList)
        {
            NewLinkedList.AddLast(i);
        }
        public static void SearchLinkedList(int i, ref LinkedList<int> NewLinkedList)
        {
            NewLinkedList.Contains(i);
        }
        public static void DeleteLinkedList(int i, ref LinkedList<int> NewLinkedList)
        {
            NewLinkedList.Remove(i);
        }
    }
}
