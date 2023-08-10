using ProjectBoardApi.Domain.Models;

namespace ProjectBoardApi.Domain.Services;

public interface IProjectService
{
    Task<IEnumerable<Project>> GetProjectList();
}

