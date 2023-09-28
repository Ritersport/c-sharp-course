
using Strategy;
using Task1;

const int numOfGames = 1000000;
var context = new Context();
context.SetStrategy(new StrategyAlwaysFirst());
var statistics = 0;

for (var i = 0; i < numOfGames; i++)
{
    if (context.PlayGame())
    {
        statistics++;
    }
}
Console.WriteLine((float) statistics / numOfGames);