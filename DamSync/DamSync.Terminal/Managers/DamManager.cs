
using Newtonsoft.Json;
using System.Text;

namespace DamSync.Terminal.Managers
{
    public class DamManager
    {
        public static void TestConnection(string machineName)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-ApiKey", "MReCg7XzMPa9R5QqMgmwcQ8fDs7QpYlMcRltXpXiTbkmO/wx6FXG7lpDBmYWy5wUhY66POH1XgbfY9D9GT6JsiKcaFdzDT0LRC4WvrwrNAOfdfiLOZD7J/biSnzonfBM");
            // var createProofResponsePaylaod = new StringContent(JsonConvert.SerializeObject(htmlAnnotationResponseMessage), Encoding.UTF8, "application/json");

            var payload = new { machineName };
            var createProofResponsePaylaod = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            var result = httpClient.PostAsync("http://ronydemo.sashiimi.local/FileSyncMachine/TestConnection", createProofResponsePaylaod).Result;

            string listItemEditInformationCSVModelsRef = result.Content.ReadAsStringAsync().Result;
            var listItemEditInformationCSVModels = JsonConvert.DeserializeObject<bool>(listItemEditInformationCSVModelsRef);
        }
    }
}
