using System.Collections.Generic;
using System;

namespace Task2_2
{
    class DictionaryCollection
    {
        public static Dictionary<int, int> DictionaryCreation(int i)
        {
            Dictionary<int, int> NewDictionary = new Dictionary<int, int>();
            Random ranNum = new Random();
            for (int j = 0; j < i; j++)
            {
                NewDictionary.Add(j, ranNum.Next(1, 10000));
            }
            return NewDictionary;
        }

        public static void AddToDictionary(int i, ref Dictionary<int, int> NewDictionary)
        {
            NewDictionary.Add(i, i);
        }

        public static void SearchDictionary(int i, ref Dictionary<int, int> NewDictionary)
        {
            NewDictionary.ContainsKey(i);
        }

        public static void DeleteDictionary(int i, ref Dictionary<int, int> NewDictionary)
        {
            NewDictionary.Remove(i);
        }
    }
}
