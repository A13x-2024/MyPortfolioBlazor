using Labb3FullstackBlazor.Models;

public class AdminService
{
    private readonly HttpClient _httpClient;
    private readonly AdminUser _adminUser;

    public AdminService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _adminUser = new AdminUser
        {
            UserName = "admin",
            Password = "admin"
        };
    }

    // PROJECTS CRUD
    public async Task<List<Project>> GetProjects()
    {
        var projects = await _httpClient.GetFromJsonAsync<List<Project>>("https://alexlab3api-apevdzadbfgea8bs.westeurope-01.azurewebsites.net/projects");
        return projects ?? new List<Project>();
    }

    public async Task AddProject(Project project)
    {
        await _httpClient.PostAsJsonAsync("https://alexlab3api-apevdzadbfgea8bs.westeurope-01.azurewebsites.net/project", project);
    }

    // SKILLS CRUD
    public async Task<List<Skill>> GetSkills()
    {
        var skills = await _httpClient.GetFromJsonAsync<List<Skill>>("https://alexlab3api-apevdzadbfgea8bs.westeurope-01.azurewebsites.net/skills");
        return skills ?? new List<Skill>();
    }

    public async Task AddSkill(Skill skill)
    {
        await _httpClient.PostAsJsonAsync("https://alexlab3api-apevdzadbfgea8bs.westeurope-01.azurewebsites.net/skill", skill);
    }

    // Admin User Authentication
    public bool IsAuthenticated(string userName, string password)
    {
        return _adminUser != null && _adminUser.UserName == userName && _adminUser.Password == password;
    }
}
