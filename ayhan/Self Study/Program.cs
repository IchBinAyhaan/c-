
    class Program
{
    static void Main()
    {
        Console.WriteLine("Birinci ededi daxil edin");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ikinci ededi daxil edin");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int result = FindMultiply( number1, number2);
        Console.WriteLine("Netice: " + result);

    }
    static int FindMultiply(int number1, int number2)
    {
        return number1 * number2;
    }
}
   


