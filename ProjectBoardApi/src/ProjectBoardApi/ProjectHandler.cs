using ProjectBoardApi.Domain.Services;

namespace ProjectBoardApi;

public static class ProjectHandler
{
    public static RouteGroupBuilder MapProjectHandler(this RouteGroupBuilder group)
    {
        group.MapGet("/", (IProjectService projectService) =>
        {
            return TypedResults.Ok(projectService.GetProjectList());
        })
        .WithName("GetProjectList");

        return group;
    }
}
