namespace MyDictionary;

public class MyDictionary<Key, Value>
{
    private List<Key> keys;
    private List<Value> values;

    public Value? this[Key key]
    {
        get
        {
            var index = keys.IndexOf(key);

            return values[index];
        }
        set
        {
            Add(key, value);
        }
    }

    public int Count
    {
        get
        {
            return keys.Count;
        }
    }

    public MyDictionary()
    {
        keys = new List<Key>();
        values = new List<Value>();
    }

    private void Add(Key key, Value value)
    {
        var index = keys.IndexOf(key);
        if (index == -1) 
        {
            keys.Add(key);
            values.Add(value);
        }
        else
        {
            values[index] = value;
        }
    }
  
}