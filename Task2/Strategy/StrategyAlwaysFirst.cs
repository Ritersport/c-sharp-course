namespace Strategy;

public class StrategyAlwaysFirst : IStrategy
{
    public int GetCardNumber()
    {
        return 1;
    }

    public object? GetService(Type serviceType)
    {
        throw new NotImplementedException();
    }
}