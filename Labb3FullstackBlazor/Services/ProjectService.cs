using Labb3FullstackBlazor.Models;

namespace Labb3FullstackBlazor.Services
{
    public class ProjectService
    {
        private readonly HttpClient _httpClient;

        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Project>> GetProjects()
        {
            var projects = await _httpClient.GetFromJsonAsync<List<Project>>("https://alexlab3api-apevdzadbfgea8bs.westeurope-01.azurewebsites.net/projects");
            return projects ?? new List<Project>();
        }
    }
}
