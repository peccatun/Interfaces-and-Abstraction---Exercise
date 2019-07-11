

namespace CollectionHierarchy
{
    public  interface IMylistable
    {
        int Add(string item);

        string Remove();

        int Used { get; }
    }
}
