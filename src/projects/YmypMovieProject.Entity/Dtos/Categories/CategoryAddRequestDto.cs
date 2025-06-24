using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Categories;

public sealed record CategoryAddRequestDto : ICreateDto
{
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
}