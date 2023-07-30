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
        public SyncJob[] Jobs;
    }
}
