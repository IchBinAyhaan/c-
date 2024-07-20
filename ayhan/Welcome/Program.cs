class Program
{
    static void Main()
    {
        string name = "Ayhan";
        string surname = "Qasimli";
        string result = PrintWelcome(name,surname);
        Console.WriteLine("Netice: " + result);

    }
    static string PrintWelcome(string name,string surname)
    {
        return "Welcome," + name + " " + surname;
    }
}