using System;
using System.Collections;

namespace Task2_2
{
    public class ArrayListCollection
    {
        public static ArrayList ArrayListCreation(int i)
        {
            ArrayList NewArrayList = new ArrayList();
            Random ranNum = new Random();
            for (int j = 0; j < i; j++)
            {
                NewArrayList.Add(ranNum.Next(1, 10000));
            }
            return NewArrayList;
        }
        public static void AddToArrayList(int i, ref ArrayList NewArrayList)
        {
            NewArrayList.Add(i);
        }
        public static void SearchArrayList(int i, ref ArrayList NewArrayList)
        {
            NewArrayList.Contains(i);
        }
        public static void DeleteArrayList(int i, ref ArrayList NewArrayList)
        {
            NewArrayList.RemoveAt(i);
        }
    }
}
