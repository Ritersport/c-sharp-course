
using Strategy;
using Task1;

const int numOfGames = 1000000;
var experimentWorker = new CollisiumExperimentWorker();
experimentWorker.SetStrategy(new StrategyAlwaysFirst());
var statistics = 0;

for (var i = 0; i < numOfGames; i++)
{
    if (experimentWorker.PlayGame())
    {
        statistics++;
    }
}
Console.WriteLine("Winning percentage: " + (float) statistics / numOfGames + "%");