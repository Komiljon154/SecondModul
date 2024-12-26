using _2._8dars;

public class MyList<T> : IMyList<T>
{
    private List<T> _items = new List<T>();

    public bool Contains(T item)
    {
        return _items.Contains(item);
    }

    public void Clear()
    {
        _items.Clear();
    }

    public T[] ToArray()
    {
        return _items.ToArray();
    }

    public void InsertAt(int index, T item)
    {
        _items.Insert(index, item);
    }

    public void Sort()
    {
        _items.Sort();
    }

    public int GetLastIndex(T item)
    {
        return _items.LastIndexOf(item);
    }

    public void Reverse()
    {
        throw new NotImplementedException();
    }

    public T[] GetRange(int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    internal void RemoveItemAt(int index)
    {
        throw new NotImplementedException();
    }

    public void AddItem(T item)
    {
        throw new NotImplementedException();
    }

    public T GetItemAt(int index)
    {
        throw new NotImplementedException();
    }

    void IMyList<T>.RemoveItemAt(int index)
    {
        throw new NotImplementedException();
    }

    public void AddItemsRange(T[] nums)
    {
        throw new NotImplementedException();
    }

    public void ReplaceAllItems(T oldElement, T newElement)
    {
        throw new NotImplementedException();
    }

    public int GetItemIndex(T item)
    {
        throw new NotImplementedException();
    }

    public int GetCount()
    {
        throw new NotImplementedException();
    }

    public int GetCapacity()
    {
        throw new NotImplementedException();
    }
}