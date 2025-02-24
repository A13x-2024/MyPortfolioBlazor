using Labb3FullstackBlazor.Models;

namespace Labb3FullstackBlazor.Services
{
    public class SkillService
    {
        private readonly HttpClient _httpClient;

        public SkillService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Skill>> GetSkills()
        {
            var skills = await _httpClient.GetFromJsonAsync<List<Skill>>("https://alexlab3api-apevdzadbfgea8bs.westeurope-01.azurewebsites.net/skills");
            return skills ?? new List<Skill>();
        }
    }
}

