using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Business.Utilites.Results;
using Core.Entity.Concrete;
using YmypMovieProject.Entity.Dtos.Users;

namespace YmypMovieProject.Business.Abstract;
public interface IUserService : IGenericService<User,UserResponseDto,UserForRegisterDto,UserUpdateRequestDto>
{
    IDataResult<List<OperationClaim>> GetClaims(User user);
    IDataResult<User> GetByMail(string email);
}
