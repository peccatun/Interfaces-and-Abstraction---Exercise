using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : IMylistable
    {
        private List<string> collection;

        public MyList()
        {
            collection = new List<string>();
        }

        public int Used
        {
            get
            {
                return this.collection.Count;
            }
        }

        public int Add(string item)
        {
            collection.Insert(0, item);

            return 0;
        }

        public string Remove()
        {
            if (collection.Count > 0)
            {
                string currentItem = collection[0];
                collection.RemoveAt(0);

                return currentItem;
            }
            return null;
        }
    }
}
