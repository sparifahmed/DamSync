using DamSync.Terminal.ResponseModels;

namespace DamSync.Terminal.Interfeces
{
    public interface IApiService
    {
       Task<List<SyncJobModel>> GetSyncJobs(string machineId);
    }
}
