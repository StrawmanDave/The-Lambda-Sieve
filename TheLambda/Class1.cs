namespace TheLambda;

public class Sieve
{
    private Func<int, bool> _operation;
    public Sieve(Func<int, bool> operations)
    {
        _operation = operations;
    }

    public bool IsGood(int numbers)
    {
        return _operation(numbers);
    }

}