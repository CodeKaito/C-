class Program
{
    static void Main()
    {
        Program p = new Program();
        p.EvenNumbers();
    }
    public void EvenNumbers()
    {
        int Start = 0;

        while (Start < 20)
        {
            Console.WriteLine(Start);

            Start = Start + 1;
        }
    }
}