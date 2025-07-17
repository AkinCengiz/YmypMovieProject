using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Dtos.Users;

namespace YmypMovieProject.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public IActionResult Register(UserForRegisterDto userForRegisterDto)
    {
        var userExists = _authService.UserExists(userForRegisterDto.Email);
        if (!userExists.Success)
        {
            return BadRequest(userExists.Message);
        }

        var registerResult = _authService.Register(userForRegisterDto);
        var tokenResult = _authService.CreateAccessToken(registerResult.Data);
        if (!tokenResult.Success)
        {
            return BadRequest(tokenResult.Message);
        }
        return Ok(tokenResult.Data);
    }

    [HttpPost("login")]
    public IActionResult Login(UserForLoginDto userForLoginDto)
    {
        var result = _authService.Login(userForLoginDto);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }

        var accessTokenResult = _authService.CreateAccessToken(result.Data);
        if (!accessTokenResult.Success)
        {
            return BadRequest(accessTokenResult.Message);
        }
        return Ok(result.Data);
    }
}
