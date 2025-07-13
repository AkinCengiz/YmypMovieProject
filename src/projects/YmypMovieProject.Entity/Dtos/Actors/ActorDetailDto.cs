using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;
using YmypMovieProject.Entity.Dtos.Movies;

namespace YmypMovieProject.Entity.Dtos.Actors;

public sealed record ActorDetailDto(
    Guid Id,
    string FirstName,
    string LastName,
    string? ImageUrl,
    DateTime? BirthDate,
    string Description,
    bool IsActive,
    List<MovieResponseDto> Movies) : IResponseDto;

