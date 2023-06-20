namespace DamSync.Terminal.Models
{
    public abstract class SyncJob
    {
        public abstract void SyncAlgorithom();

        public void Sync()
        {
            SyncAlgorithom();
        }
    }
}
