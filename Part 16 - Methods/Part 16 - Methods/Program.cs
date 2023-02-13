class Program
{
    static void EvenNumbers()
    {
        int Start = 0;

        while (Start < 20)
        {
            Console.WriteLine(Start);

            Start = Start + 1;
        }
    }
    static void Main(string[] args)
    {
        EvenNumbers();
    }
}