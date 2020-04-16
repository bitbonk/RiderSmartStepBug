using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorkerService
{
    using ClassLibrary1;

    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ISomeService _service;

        public Worker(ILogger<Worker> logger, ISomeService service)
        {
            _logger = logger;
            _service = service;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
                await GetService().DoSomethingAsync(stoppingToken);
            }
        }

        private ISomeService GetService()
        {
            return _service;
        }
    }
}