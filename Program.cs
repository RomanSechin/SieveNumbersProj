internal partial class Program
{
    public static void Main(string[] args)
    {
        Func<int, bool> Delegat;            
        Console.WriteLine("-----------Sieve filter-----------");
        string line = "";
        do
        {
            Console.WriteLine("Pick the filter:\n(1) returns true for even numbers\n" +
            "(2) returns true for positive numbers\n(3) returns true for multiples of 10");
        } while (false == ((line = Console.ReadLine()) == "1" || line == "2" || line == "3"));


        switch (line){
            case "1": Delegat = IsEven; break;
            case "2": Delegat = IsPositive; break;
            case "3": Delegat = IsMultipleOfTen; break;
            default:  Delegat = IsPositive;  break;
        };
        Sieve sieve = new Sieve(Delegat);
        Console.WriteLine("Input numbers:");
        while (int.TryParse(Console.ReadLine(), out int num) == true)
        {            
            Console.WriteLine($"filter {line} - result {sieve.Delegat.Invoke(num)}");
            Console.WriteLine("Input numbers:");
        }
    }  

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    public static bool IsPositive(int number)
    {
        return number > 0;
    }
    public static bool IsMultipleOfTen(int number)
    {
        return number % 10 == 0;
    }
}
