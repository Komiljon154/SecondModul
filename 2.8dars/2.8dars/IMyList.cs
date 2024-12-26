namespace _2._8dars;

public interface IMyList <T>
{
    void AddItem(T item); 
    T GetItemAt(int index); 
    void RemoveItemAt(int index); 
    void AddItemsRange(T[] nums); 
    void ReplaceAllItems(T oldElement, T newElement); 
    int GetItemIndex(T item); 
    int GetCount(); 
    int GetCapacity();
    bool Contains(T item);
    void Clear();
    T[] ToArray();
    void InsertAt(int index, T item);
    void Reverse();
    T[] GetRange(int startIndex, int count);
    void Sort();
    int GetLastIndex(T item);
}
