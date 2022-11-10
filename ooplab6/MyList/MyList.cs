namespace Program;

public class MyList<T>
{
    private T[] _items;

    public MyList()
    {
        _items = new T[]{};
    }

    public MyList(T[] items)
    {
        _items = items;
    }

    public void Add(T item)
    {
        var newItemsList = new T[_items.Length + 1];

        _items.CopyTo(newItemsList, 0);

        newItemsList[_items.Length] = item;

        _items = newItemsList;
    }
    public T this[int index]
    {
        get { return _items[index]; }
        set { _items[index] = value; }
    }
    public int Count => _items.Length;
}