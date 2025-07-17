using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Users;

public sealed record UserUpdateRequestDto(
    string FirstName,
    string LastName,
    string Email,
    string Password,
    bool IsActive,
    bool IsDelete
    ) : IUpdateDto;
