using System;
using System.Collections.Generic;

namespace CollectionHierarchy
{
    class AddRemoveCollection : IAddRemoveCollectionable
    {
        private List<string> collection;

        public AddRemoveCollection()
        {
            collection = new List<string>();
        }

        public int Add(string item)
        {
            collection.Insert(0,item);

            return 0;

        }

        public string Remove()
        {
            if (collection.Count > 0)
            {
                string returnMe = collection[collection.Count - 1];
                collection.RemoveAt(collection.Count - 1);

                return returnMe;
            }

            return null;
        }
    }
}
