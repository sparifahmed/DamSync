
using DamSync.Terminal.Interfeces;
using DamSync.Terminal.Models;
using DamSync.Terminal.ResponseModels;
using Newtonsoft.Json;
using System.Text;

namespace DamSync.Terminal.Managers
{
    public class DamManager : IApiService
    {
        public async void GetSyncJobs(string machineName)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-ApiKey", "MReCg7XzMPa9R5QqMgmwcQ8fDs7QpYlMcRltXpXiTbkmO/wx6FXG7lpDBmYWy5wUhY66POH1XgbfY9D9GT6JsiKcaFdzDT0LRC4WvrwrNAOfdfiLOZD7J/biSnzonfBM");


            var payload = new { machineName };
            var createProofResponsePaylaod = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");


            var response = httpClient.PostAsync("http://ronydemo.sashiimi.local/FileSyncJob/GetJobList", createProofResponsePaylaod).Result;

            response.EnsureSuccessStatusCode();

            string pagedListItemsRef = await response.Content.ReadAsStringAsync();
            var pagedListItemsResult = JsonConvert.DeserializeObject<JobListResponseModel>(pagedListItemsRef);

        }

        public async Task<bool> TestConnection(string machineName)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-ApiKey", "MReCg7XzMPa9R5QqMgmwcQ8fDs7QpYlMcRltXpXiTbkmO/wx6FXG7lpDBmYWy5wUhY66POH1XgbfY9D9GT6JsiKcaFdzDT0LRC4WvrwrNAOfdfiLOZD7J/biSnzonfBM");


            var payload = new { machineName };
            var createProofResponsePaylaod = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");


            var response = httpClient.PostAsync("http://ronydemo.sashiimi.local/FileSyncMachine/TestConnection", createProofResponsePaylaod).Result;

            response.EnsureSuccessStatusCode();

            string pagedListItemsRef = await response.Content.ReadAsStringAsync();
            var pagedListItemsResult = JsonConvert.DeserializeObject<bool>(pagedListItemsRef);
            return pagedListItemsResult;
        }
    }
}
