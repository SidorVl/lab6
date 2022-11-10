namespace Program;

class Program
{
    static void Main()
    {
        var list = new MyList<int>(new int[]{1 , 2 , 3 , 4});
        list.Add(5);
        list.Add(6);
        var array = list.GetArray();
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
      
    }
}
