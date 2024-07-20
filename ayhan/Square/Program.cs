class Program
{
    static void Main()
    {
        Console.WriteLine("Eded daxil edin");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = FindSquare(number);
        Console.WriteLine("Netice: " + result);
    }
    static int FindSquare(int number)
    {
        return number * number;
    }
}