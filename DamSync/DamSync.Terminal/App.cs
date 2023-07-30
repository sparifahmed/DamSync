using DamSync.Terminal.Interfeces;
using DamSync.Terminal.Managers;
using Microsoft.Extensions.Logging;

namespace DamSync.Terminal
{
    public class App
    {
        private ILogger<App> _logger;
        private readonly ISyncService _syncService;
        public App(ILogger<App> logger, ISyncService syncService)
        {
            _logger = logger;
            _syncService = syncService;
        }

        public void Run(string[] args)
        {
            Console.WriteLine(Environment.MachineName);
            DamManager.TestConnection(Environment.MachineName);

            // _logger.LogDebug("Hello");
            // _syncService.StartSyncService();
        }
    }
}
