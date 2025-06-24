using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Movies;

public sealed record MovieUpdateRequestDto : IUpdateDto
{
    public Guid Id { get; init; }
    public string? Name { get; init; }
    public string? Description { get; init; }
    public decimal IMDB { get; init; }
    public DateTime PublishDate { get; init; }
    public string? ImageUrl { get; init; }
    public Guid CategoryId { get; init; }
    public Guid DirectorId { get; init; }
    public bool IsActive { get; init; } = true;
    public bool IsDeleted { get; init; } = false;
}