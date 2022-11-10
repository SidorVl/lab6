namespace MyClass;

public class MyClass
{
    public static T FabricMethod<T>()where T :notnull, new() 
    {
        return new T();
    }
}