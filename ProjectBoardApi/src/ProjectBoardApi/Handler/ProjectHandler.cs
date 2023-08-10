using ProjectBoardApi.Domain.Services;

namespace ProjectBoardApi.Handler;

public static class ProjectHandler
{
    public static RouteGroupBuilder MapProjectHandler(this RouteGroupBuilder group)
    {
        group.MapGet("/", async (IProjectService projectService) =>
        {
            return TypedResults.Ok(await projectService.GetProjectList());
        })
        .WithName("GetProjectList");

        return group;
    }
}
