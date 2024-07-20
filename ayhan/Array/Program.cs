class Program
{
    static void Main()
    {
        int[] Array = { 1, 2, 3, 4, 5, };
        int result = FindSum(Array);
        Console.WriteLine("Netice:"+result);

    }
    static int FindSum(int[] Array)
    {
        int sum = 0;
        foreach (int number in Array)
        {  sum += number; }
        return sum;

    }
}