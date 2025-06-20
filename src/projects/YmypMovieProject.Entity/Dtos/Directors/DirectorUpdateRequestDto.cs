using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Directors;

public sealed record DirectorUpdateRequestDto(
    Guid Id,
    string FirstName,
    string LastName,
    string ImageUrl,//IFormFile olarak değiştirilecek.
    DateTime BirthDate,
    string Description,
    bool IsActive = true, // Default to true for active state
    bool IsDeleted = false // Default to false for soft delete
) : IDto;