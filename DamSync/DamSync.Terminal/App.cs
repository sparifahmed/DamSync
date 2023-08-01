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

                 
                var syncJobs = await damManager.GetSyncJobs(Environment.MachineName);

                List<Task> tasks = new List<Task>();


                Task task1 = StartTask(1, 1000);
                Task task2 = StartTask(2, 3000);
                Task task3 = StartTask(3, 10000);
                Task task4 = StartTask(4, 8000);
                Task task5 = StartTask(5, 5000);

                Task.WaitAll(task1, task2, task3, task4, task5);

                // You will not get here until all tasks are finished (in 10 seconds)
                Console.WriteLine("Done!");

                // _syncService.StartSyncService();
            }
            else
            {
                Console.WriteLine("Server connection failed");
            }

            // _logger.LogDebug("Hello");
            // _syncService.StartSyncService();
        }

        private static Task StartTask(int taskId, int timeToWait)
        {
            return Task.Run(async () =>
            {
                //Console.WriteLine($"Waiting {timeToWait}");
                //await Task.Delay(timeToWait);
                //Console.WriteLine($"Done waiting {timeToWait}");

                while(true)
                {
                    Console.WriteLine($"Syncing............ {taskId}");
                    await Task.Delay(timeToWait);
                }
            });
        }
    }
}
