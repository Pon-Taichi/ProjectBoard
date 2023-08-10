using ProjectBoardApi.Domain.Models;

namespace ProjectBoardApi.Domain.Services;

public class ProjectService : IProjectService
{
    public ProjectService()
    {
    }

    public async Task<IEnumerable<Project>> GetProjectList()
    {
        await Task.Delay(100);
        return new List<Project>
        {
            new Project
            {
                Id = "1",
                Name = "LCA"
            },
            new Project
            {
                Id = "2",
                Name = "FBX"
            }
        };
    }
}