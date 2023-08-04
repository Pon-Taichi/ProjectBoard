using ProjectBoardApi.Domain.Models;

namespace ProjectBoardApi.Domain.Services;

public interface IProjectService
{
    IEnumerable<Project> GetProjectList();
}

