using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business.Utilites.Results;
using Core.Business.Utilites.Security.Jwt;
using Core.Entity.Concrete;
using YmypMovieProject.Entity.Dtos.Users;

namespace YmypMovieProject.Business.Abstract;
public interface IAuthService
{
    IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
    IDataResult<User> Login(UserForLoginDto userForLoginDto);
    IResult UserExists(string email);
    IDataResult<AccessToken> CreateAccessToken(User user);
}
