using DamSync.Terminal.Interfeces;
using System;
using System.Collections.Generic;


namespace DamSync.Terminal
{
    public class App
    {
        private readonly ISyncService _syncService;
        public App(ISyncService syncService)
        {
            _syncService = syncService;
        }

        public void Run(string[] args)
        {
            _syncService.StartSyncService();
        }
    }
}
