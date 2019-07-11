using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : IAddCollectionable
    {
        private List<string> collection;

        public AddCollection()
        {
            collection = new List<string>();
        }

        public int Add(string item)
        {
            collection.Add(item);

            return collection.Count - 1;
        }
    }
}
