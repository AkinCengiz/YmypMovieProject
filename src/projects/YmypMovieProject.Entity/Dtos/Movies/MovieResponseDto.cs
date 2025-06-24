using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Movies;
public sealed record MovieResponseDto : IResponseDto
{
    public Guid Id { get; init; }
    public string? Name { get; init; }
    public string? Description { get; init; }
    public decimal IMDB { get; init; }
    public DateTime PublishDate { get; init; }
    public string? ImageUrl { get; init; }
    public bool IsActive { get; init; }
    public string CategoryName { get; init; } = string.Empty;
    public string DirectorFirstName { get; init; } = string.Empty;
    public string DirectorLastName { get; init; } = string.Empty;
}