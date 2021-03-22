using System.Collections.Generic;
using System;

namespace Task2_2
{
    class QueueCollection
    {
        public static Queue<int> QueueCreation(int i)
        {
            Queue<int> newQueue = new Queue<int>();
            Random ranNum = new Random();

            for (int j = 0; j < i; j++)
            {
                newQueue.Enqueue(ranNum.Next(1, 10000));
            }
            return newQueue;
        }

        public static void AddToQueue(int i, ref Queue<int> NewQueue)
        {
            NewQueue.Enqueue(i);
        }

        public static void SearchQueue(int i, ref Queue<int> newQueue)
        {
            newQueue.Contains(i);
        }

        public static void DeleteQueue(int i, ref Queue<int> newQueue)
        {
            newQueue.Dequeue();
        }
    }
}
