namespace ProjectBoardApi.Domain.Models;

public record Project
{
    public required string Id { get; init; }
    public required string Name { get; init; }
};
