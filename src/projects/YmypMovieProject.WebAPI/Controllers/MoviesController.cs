using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Dtos.Movies;

namespace YmypMovieProject.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService, IMapper mapper)
    {
        _movieService = movieService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var movies = _movieService.GetAll(false);
        return Ok(movies);
    }

    [HttpGet("FullInfo")]
    public IActionResult GetAllFullInfo()
    {
        var movies = _movieService.GetMoviesWithFullInfo();
        return Ok(movies);
    }
    [HttpGet("{id:guid}")]
    public IActionResult GetById([FromRoute(Name = "id")]Guid id)
    {
        var movie = _movieService.GetById(id);
        return Ok(movie);
    }

    [HttpPost]
    public IActionResult Insert([FromBody] MovieAddRequestDto dto)
    {
        _movieService.Insert(dto);
        return StatusCode(201,dto);
    }
    [HttpPut]
    public IActionResult Update([FromBody] MovieUpdateRequestDto dto)
    {
        _movieService.Modify(dto);
        return Ok(dto);
    }
    [HttpDelete("{id:guid}")]
    public IActionResult Delete([FromRoute(Name = "id")] Guid id)
    {
        _movieService.Remove(id);
        return Content("Movie deleted successfuly");
    }
}
