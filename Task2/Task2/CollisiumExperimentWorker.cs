using Experiment;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Shuffler;

namespace Task2;

public class CollisiumExperimentWorker : BackgroundService
{
    private readonly ILogger<CollisiumExperimentWorker> _logger;
    private readonly Sandbox _sandbox;
    private const int NumOfGames = 1000000;
    
    public CollisiumExperimentWorker(Sandbox sandbox, ILogger<CollisiumExperimentWorker> logger)
    {
        _logger = logger;
        _sandbox = sandbox;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Experiment started: {time}", DateTime.Now);
        int counter = 0;
        for (int i = 0; i < NumOfGames; i++)
        {
            if (_sandbox.PlayGame())
            {
                counter++;
            }
        }
        Console.WriteLine("Statistics: " + (float) counter / NumOfGames);
        return Task.CompletedTask;
    }

    public override Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    
}