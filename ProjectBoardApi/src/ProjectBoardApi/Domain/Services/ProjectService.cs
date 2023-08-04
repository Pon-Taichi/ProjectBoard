using ProjectBoardApi.Domain.Models;

namespace ProjectBoardApi.Domain.Services;

public class ProjectService : IProjectService
{
    public ProjectService()
    {
    }

    public IEnumerable<Project> GetProjectList()
    {
        return new List<Project>
        {
            new Project("1", "LCA"),
            new Project("2", "FBX")
        };
    }
}