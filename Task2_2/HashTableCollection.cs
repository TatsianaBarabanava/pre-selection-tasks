using System.Collections;
using System;

namespace Task2_2
{
    class HashTableCollection
    {
        public static Hashtable HashtableCreation(int i)
        {
            Hashtable NewHashtable = new Hashtable();
            Random ranNum = new Random();
            for (int j = 0; j < i; j++)
            {
                NewHashtable.Add(j, ranNum.Next(1, 10000));
            }
            return NewHashtable;
        }

        public static void AddToHashtable(int i, ref Hashtable NewHashtable)
        {
            NewHashtable.Add(i, i);
        }

        public static void SearchHashtable(int i, ref Hashtable NewHashtable)
        {
            NewHashtable.Contains(i);
        }

        public static void DeleteHashtable(int i, ref Hashtable NewHashtable)
        {
            NewHashtable.Remove(i);
        }
    }
}
