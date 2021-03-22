using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestArrayList();
            TestLinkedList();
            TestStack();
            TestQueue();
            TestDictionary();
            TestHashtable();
        }
        public static string ConvertTimeSpan(TimeSpan ts)
        {
            return String.Format("{0:%h} hours {0:%m} minutes {0:%s} seconds {0:%fffffff} milliseconds", ts);
        }
        public static void TestArrayList()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            ArrayList Collection = ArrayListCollection.ArrayListCreation(10000);
            ArrayListCollection.AddToArrayList(10000, ref Collection);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = ConvertTimeSpan(ts);
            Console.WriteLine("ArrayList add time is: " + elapsedTime);

            Stopwatch stopWatchSearch = new Stopwatch();
            stopWatchSearch.Start();
            ArrayListCollection.SearchArrayList(10000, ref Collection);
            stopWatchSearch.Stop();
            TimeSpan tsSearch = stopWatchSearch.Elapsed;
            string elapsedTimeSearch = ConvertTimeSpan(tsSearch);
            Console.WriteLine("ArrayList search time is: " + elapsedTimeSearch);

            Stopwatch stopWatchDelete = new Stopwatch();
            stopWatchDelete.Start();
            ArrayListCollection.DeleteArrayList(10000, ref Collection);
            stopWatchDelete.Stop();
            TimeSpan tsDelete = stopWatchDelete.Elapsed;
            string elapsedTimeDelete = ConvertTimeSpan(tsDelete);
            Console.WriteLine("ArrayList delete time is: " + elapsedTimeDelete);
            Console.WriteLine("Press any key to compare to the LinkedList.");
            Console.ReadKey();
        }
        public static void TestLinkedList()
        {
            Stopwatch stopWatchLinkedAdd = new Stopwatch();
            stopWatchLinkedAdd.Start();
            LinkedList<int> CollectionLinkedList = LinkedListCollection.LinkedListCreation(10000);
            LinkedListCollection.AddToLinkedList(10000, ref CollectionLinkedList);
            stopWatchLinkedAdd.Stop();
            TimeSpan tsLinkedAdd = stopWatchLinkedAdd.Elapsed;
            string elapsedTimeLinkedAdd = ConvertTimeSpan(tsLinkedAdd);
            Console.WriteLine("LinkedList add time is: " + elapsedTimeLinkedAdd);

            Stopwatch stopWatchLinkedSearch = new Stopwatch();
            stopWatchLinkedSearch.Start();
            LinkedListCollection.SearchLinkedList(10000, ref CollectionLinkedList);
            stopWatchLinkedSearch.Stop();
            TimeSpan tsLinkedSearch = stopWatchLinkedSearch.Elapsed;
            string elapsedTimeLinkedSearch = ConvertTimeSpan(tsLinkedSearch);
            Console.WriteLine("LinkedList search time is: " + elapsedTimeLinkedSearch);

            Stopwatch stopWatchLinkedDelete = new Stopwatch();
            stopWatchLinkedDelete.Start();
            LinkedListCollection.DeleteLinkedList(10000, ref CollectionLinkedList);
            stopWatchLinkedDelete.Stop();
            TimeSpan tsLinkedDelete = stopWatchLinkedDelete.Elapsed;
            string elapsedTimeLinkedDelete = ConvertTimeSpan(tsLinkedDelete);
            Console.WriteLine("LinkedList delete time is: " + elapsedTimeLinkedDelete);
            Console.WriteLine("Press any key to compare stack and queue.");
            Console.ReadKey();
        }
        public static void TestStack()
        {
            Stopwatch stopWatchStackAdd = new Stopwatch();
            stopWatchStackAdd.Start();
            Stack<int> CollectionStack = StackCollection.StackCreation(10000);
            StackCollection.AddToStack(10000, ref CollectionStack);
            stopWatchStackAdd.Stop();
            TimeSpan tsStackAdd = stopWatchStackAdd.Elapsed;
            string elapsedTimeStack = ConvertTimeSpan(tsStackAdd);
            Console.WriteLine("Stack add time is: " + elapsedTimeStack);

            Stopwatch stopWatchStackSearch = new Stopwatch();
            stopWatchStackSearch.Start();
            StackCollection.SearchStack(10000, ref CollectionStack);
            stopWatchStackSearch.Stop();
            TimeSpan tsStackSearch = stopWatchStackAdd.Elapsed;
            string elapsedTimeStackSearch = ConvertTimeSpan(tsStackSearch);
            Console.WriteLine("Stack search time is: " + elapsedTimeStackSearch);

            Stopwatch stopWatchStackDelete = new Stopwatch();
            stopWatchStackDelete.Start();
            StackCollection.DeleteStack(10000, ref CollectionStack);
            stopWatchStackDelete.Stop();
            TimeSpan tsStackDelete = stopWatchStackAdd.Elapsed;
            string elapsedTimeStackDelete = ConvertTimeSpan(tsStackDelete);
            Console.WriteLine("Stack delete time is: " + elapsedTimeStackDelete);
            Console.WriteLine("Press any key to compare to the queue.");
            Console.ReadKey();
        }
        public static void TestQueue()
        {
            Stopwatch stopWatchQueueAdd = new Stopwatch();
            stopWatchQueueAdd.Start();
            Queue<int> CollectionQueue = QueueCollection.QueueCreation(10000);
            QueueCollection.AddToQueue(10000, ref CollectionQueue);
            stopWatchQueueAdd.Stop();
            TimeSpan tsQueueAdd = stopWatchQueueAdd.Elapsed;
            string elapsedTimeQueue = ConvertTimeSpan(tsQueueAdd);
            Console.WriteLine("Queue add time is: " + elapsedTimeQueue);

            Stopwatch stopWatchQueueSearch = new Stopwatch();
            stopWatchQueueSearch.Start();
            QueueCollection.SearchQueue(10000, ref CollectionQueue);
            stopWatchQueueSearch.Stop();
            TimeSpan tsQueueSearch = stopWatchQueueSearch.Elapsed;
            string elapsedTimeQueueSearch = ConvertTimeSpan(tsQueueSearch);
            Console.WriteLine("Queue add time is: " + elapsedTimeQueueSearch);

            Stopwatch stopWatchQueueDelete = new Stopwatch();
            stopWatchQueueDelete.Start();
            QueueCollection.DeleteQueue(10000, ref CollectionQueue);
            stopWatchQueueDelete.Stop();
            TimeSpan tsQueueDelete = stopWatchQueueSearch.Elapsed;
            string elapsedTimeQueueDelete = ConvertTimeSpan(tsQueueDelete);
            Console.WriteLine("Queue delete time is: " + elapsedTimeQueueDelete);
            Console.WriteLine("Press any ket to compare dictionary and hashtable");
            Console.ReadKey();
        }

        public static void TestDictionary()
        {
            Stopwatch stopWatchDictionaryAdd = new Stopwatch();
            stopWatchDictionaryAdd.Start();
            Dictionary<int, int> CollectionDictionary = DictionaryCollection.DictionaryCreation(10000);
            DictionaryCollection.AddToDictionary(10000, ref CollectionDictionary);
            stopWatchDictionaryAdd.Stop();
            TimeSpan tsDictionaryAdd = stopWatchDictionaryAdd.Elapsed;
            string elapsedTimeDictionary = ConvertTimeSpan(tsDictionaryAdd);
            Console.WriteLine("Dictionary add time is: " + elapsedTimeDictionary);

            Stopwatch stopWatchDictionarySearch = new Stopwatch();
            stopWatchDictionarySearch.Start();
            DictionaryCollection.SearchDictionary(10000, ref CollectionDictionary);
            stopWatchDictionarySearch.Stop();
            TimeSpan tsDictionarySearch = stopWatchDictionarySearch.Elapsed;
            string elapsedTimeDictionarySearch = ConvertTimeSpan(tsDictionarySearch);
            Console.WriteLine("Dictionary search time is: " + elapsedTimeDictionarySearch);

            Stopwatch stopWatchDictionaryDelete = new Stopwatch();
            stopWatchDictionaryDelete.Start();
            DictionaryCollection.SearchDictionary(10000, ref CollectionDictionary);
            stopWatchDictionaryDelete.Stop();
            TimeSpan tsDictionaryDelete = stopWatchDictionaryDelete.Elapsed;
            string elapsedTimeDictionaryDelete = ConvertTimeSpan(tsDictionaryDelete);
            Console.WriteLine("Dictionary delete time is: " + elapsedTimeDictionaryDelete);
            Console.WriteLine("Press any key to compare to the hashtable.");
            Console.ReadKey();
        }
        public static void TestHashtable()
        {
            Stopwatch stopWatchHashtableAdd = new Stopwatch();
            stopWatchHashtableAdd.Start();
            Hashtable CollectionHashtable = HashTableCollection.HashtableCreation(10000);
            HashTableCollection.AddToHashtable(10000, ref CollectionHashtable);
            stopWatchHashtableAdd.Stop();
            TimeSpan tsHashtableAdd = stopWatchHashtableAdd.Elapsed;
            string elapsedTimeHashtable = ConvertTimeSpan(tsHashtableAdd);
            Console.WriteLine("Hashtable add time is: " + elapsedTimeHashtable);

            Stopwatch stopWatchHashtableSearch = new Stopwatch();
            stopWatchHashtableSearch.Start();
            HashTableCollection.SearchHashtable(10000, ref CollectionHashtable);
            stopWatchHashtableSearch.Stop();
            TimeSpan tsHashtableSearch = stopWatchHashtableSearch.Elapsed;
            string elapsedTimeHashtableSearch = ConvertTimeSpan(tsHashtableSearch);
            Console.WriteLine("Hashtable search time is: " + elapsedTimeHashtableSearch);

            Stopwatch stopWatchHashtableDelete = new Stopwatch();
            stopWatchHashtableDelete.Start();
            HashTableCollection.DeleteHashtable(10000, ref CollectionHashtable);
            stopWatchHashtableDelete.Stop();
            TimeSpan tsHashtableDelete = stopWatchHashtableDelete.Elapsed;
            string elapsedTimeHashtableDelete = ConvertTimeSpan(tsHashtableDelete);
            Console.WriteLine("Hashtable delete time is: " + elapsedTimeHashtableDelete);
            Console.ReadKey();
        }
    }
}
