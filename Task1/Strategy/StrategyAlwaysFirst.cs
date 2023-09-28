
namespace Strategy;

public class StrategyAlwaysFirst : IStrategy
{
    public int GetCardNumber(int competitorNumber)
    {
        return 1;
    }
}