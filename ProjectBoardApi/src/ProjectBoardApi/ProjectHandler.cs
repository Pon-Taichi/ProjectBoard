using System;

namespace ProjectBoardApi
{
  public static class ProjectHandler
  {
    public static RouteGroupBuilder MapProjectHandler(this RouteGroupBuilder group)
    {
      group.MapGet("/", () => TypedResults.Ok(new List<Project>
      {
        new Project("1", "LCA"),
        new Project("2", "FBX")
      })).WithName("GetProjectList");

      return group;
    }
  }
}
