using Competitor;
using Experiment;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shuffler;
using Strategy;

namespace Task2;

class Program
{
    
    public static void Main(string[] args)
    {
        CreateHostBuilder(args)
            .Build()
            .Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<CollisiumExperimentWorker>();
                services.AddScoped<Sandbox>();
                services.AddScoped<IDeckShuffler, DeckShuffler>();
                services.AddScoped<ICompetitor>(x => new Competitor.Competitor(new StrategyAlwaysFirst()));
                services.AddScoped<ICompetitor>(x => new Competitor.Competitor(new StrategyAlwaysFirst()));

            });
    }
}