public class Sieve
{
    public Func<int, bool> Delegat;
    public bool IsGood(int number)
    {
        return Delegat.Invoke(number);
    }
    public Sieve(Func<int, bool> deleg)
    {
        Delegat += deleg;
    }
    
}