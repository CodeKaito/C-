class Program
{

    public static void Main()
    {
        EvenNumbers(30);

        Program P = new Program();
        int Sum = P.Add(10, 20);

        Console.WriteLine("Sum = {0}", Sum);
    }

    public int Add (int FN, int SN)
    {
        return FN + SN;
    }

    public static void EvenNumbers(int Target)
    {
        int Start = 0;

        while (Start <= Target)
        {
            Console.WriteLine(Start);
            Start++;
        }
    }
}