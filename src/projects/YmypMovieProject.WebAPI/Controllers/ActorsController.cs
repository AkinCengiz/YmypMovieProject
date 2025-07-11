using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Dtos.Actors;

namespace YmypMovieProject.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ActorsController : ControllerBase
{
    private readonly IActorService _actorService;

    public ActorsController(IActorService actorService)
    {
        _actorService = actorService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _actorService.GetAll();
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var result = _actorService.GetById(id);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }

    [HttpGet("[action]")]
    public IActionResult GetActorWithMovies(Guid id)
    {
        var result = _actorService.GetActorWithMovies(id);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }

    [HttpGet("[action]")]
    public IActionResult GetActorsWithMovies()
    {
        var result = _actorService.GetActorsWithMovies();
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }

    [HttpPost]
    public IActionResult Create(ActorAddRequestDto dto)
    {
        var result = _actorService.Insert(dto);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }

        return Ok(result.Message);
    }

    [HttpPut]
    public IActionResult Update(ActorUpdateRequestDto dto)
    {
        var result = _actorService.Modify(dto);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }

        return Ok(result.Message);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var result = _actorService.Remove(id);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }

        return Ok(result.Message);
    }
}
