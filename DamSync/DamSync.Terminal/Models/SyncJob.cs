namespace DamSync.Terminal.Models
{
    public abstract class SyncJob
    {
        public string? Id { get; set; }
        public string? JobName { get; set; }
        public string? MachineName { get; set; }
        public string? VolumeName { get; set; }
        public string? VolumePath { get; set; }
        public string? VolumeId { get; set; }
        public string? ListId { get; set; }
        public string? FolderFieldId { get; set; }
        public long JobStartTime { get; set; }
        public int JobInterVal { get; set; }
        public string? SyncDirection { get; set; }
        public string? DestinationPath { get; set; }
        public object? JobStatus { get; set; }
        public long LastRunTime { get; set; }
        public long NextRunTime { get; set; }
        public bool IsActive { get; set; }
        public string? PrimaryLocation { get; set; }
        public string? LiveLogApi { get; set; }

        public abstract void SyncAlgorithom();

        public void Sync()
        {
            SyncAlgorithom();
        }
    }
}
