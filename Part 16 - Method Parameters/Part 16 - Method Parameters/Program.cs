class Program
{
    public static void Main(string[] args)
    {
        int i = 0;

        SimpleMethod(ref i);

        Saluta();

        // i = 0;

        Console.WriteLine(i);
    }

    public static void SimpleMethod(ref int j)
    {
        j = 100;
    }

    static void Saluta()
    {
        Console.WriteLine("Ciao");
    }
}