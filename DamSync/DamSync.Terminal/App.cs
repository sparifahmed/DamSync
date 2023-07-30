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

        public async void Run(string[] args)
        {
            Console.WriteLine(Environment.MachineName);

            var damManager = new DamManager();

            var isConnected = await damManager.TestConnection(Environment.MachineName);

            if(isConnected)
            {
                Console.WriteLine("Connected to server");

                damManager.GetSyncJobs(Environment.MachineName);

                // _syncService.StartSyncService();
            }
            else
            {
                Console.WriteLine("Server connection failed");
            }

            // _logger.LogDebug("Hello");
            // _syncService.StartSyncService();
        }
    }
}
