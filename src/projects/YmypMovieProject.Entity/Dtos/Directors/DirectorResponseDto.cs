using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Directors;

public sealed record DirectorResponseDto(
    Guid id,
    string FirstName,
    string LastName,
    string ImageUrl,
    DateTime BirthDate, 
    string Description):IResponseDto;

//DirectorResponseDto(id,firstName, lastName, imageUrl, birthDate, description) ;