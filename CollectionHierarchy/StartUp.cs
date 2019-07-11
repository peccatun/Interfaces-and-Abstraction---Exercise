using System;
using System.Collections.Generic;

namespace CollectionHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] insertMe = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries);

            int removeTimes = int.Parse(Console.ReadLine());

            List<int> addCollectionCount = new List<int>();
            List<int> addRemoveCollectionCount = new List<int>();
            List<int> myListCount = new List<int>();

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            for (int i = 0; i < insertMe.Length; i++)
            {
                addCollectionCount.Add(addCollection.Add(insertMe[i]));
                addRemoveCollectionCount.Add(addRemoveCollection.Add(insertMe[i]));
                myListCount.Add(myList.Add(insertMe[i]));
            }

            List<string> removeCount = new List<string>();
            List<string> myListRemoveCount = new List<string>();

            for (int i = 0; i < removeTimes; i++)
            {
                removeCount.Add(addRemoveCollection.Remove());
                myListRemoveCount.Add(myList.Remove());
            }

            Console.WriteLine(string.Join(' ',addCollectionCount));
            Console.WriteLine(string.Join(' ',addRemoveCollectionCount));
            Console.WriteLine(string.Join(' ',myListCount));
            Console.WriteLine(string.Join(' ',removeCount));
            Console.WriteLine(string.Join(' ',myListRemoveCount));

        }
    }
}
