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
) : IUpdateDto;

// new DirectorUpdateRequestDto(Guid.NewGuid(), "John", "Doe", "image.jpg", DateTime.Now, "Description here", true, false); // Example usage