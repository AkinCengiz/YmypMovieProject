using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Categories;

public sealed record CategoryUpdateRequestDto : IUpdateDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public bool IsActive { get; init; } =true; // Default to true for active state
    public bool IsDeleted { get; init; } = false; // Default to false for soft delete
}