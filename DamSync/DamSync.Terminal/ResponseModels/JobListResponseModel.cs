using DamSync.Terminal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamSync.Terminal.ResponseModels
{
    public class JobListResponseModel
    {
        public bool Success { get; set; }
        public List<SyncJobModel> Jobs = new List<SyncJobModel>();
    }

    public class SyncJobModel
    {
        public string Id { get; set; }
        public string JobName { get; set; }
        public string MachineName { get; set; }
        public string VolumeName { get; set; }
        public string VolumePath { get; set; }
        public string VolumeId { get; set; }
        public string ListId { get; set; }
        public string FolderFieldId { get; set; }
        public long JobStartTime { get; set; }
        public int JobInterVal { get; set; }
        public string SyncDirection { get; set; }
        public string DestinationPath { get; set; }
        public object JobStatus { get; set; }
        public long LastRunTime { get; set; }
        public long NextRunTime { get; set; }
        public bool IsActive { get; set; }
        public string PrimaryLocation { get; set; }
        public string LiveLogApi { get; set; }
    }

}
