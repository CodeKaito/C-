class Program
{
    public static void Main()
    {
        int i = 0;

        SimpleMethod(ref i);

        // i = 0;

        Console.WriteLine(i);
    }

    public static void SimpleMethod(ref int j)
    {
        j = 100;
    }
}