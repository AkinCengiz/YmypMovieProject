using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;
using YmypMovieProject.Entity.Dtos.Movies;

namespace YmypMovieProject.Entity.Dtos.Categories;
public sealed record CategoryDetailDto : IResponseDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public List<MovieResponseDto> Movies { get; set; }
}
