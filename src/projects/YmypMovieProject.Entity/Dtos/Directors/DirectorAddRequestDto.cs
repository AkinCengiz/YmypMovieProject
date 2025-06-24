using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Directors;

public sealed record DirectorAddRequestDto(
    string FirstName,
    string LastName,
    string ImageUrl,//IFormFile olarak değiştirilecek.
    DateTime BirthDate,
    string Description
) : ICreateDto;