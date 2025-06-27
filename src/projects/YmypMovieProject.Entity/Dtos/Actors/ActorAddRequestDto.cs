using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Actors;

public sealed record ActorAddRequestDto(
    string FirstName,
    string LastName,
    string? ImageUrl,
    DateTime? BirthDate,
    string? Description
) :ICreateDto;