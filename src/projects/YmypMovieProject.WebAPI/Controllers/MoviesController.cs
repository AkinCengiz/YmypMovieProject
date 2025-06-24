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
        var movies = _movieService.GetAll();
        return Ok(movies);
    }

    [HttpGet("FullInfo")]
    public IActionResult GetAllFullInfo()
    {
        //var movies = _movieService.GetMoviesWithFullInfo();
        //var dto = movies.Select(m => new
        //{
        //    m.Id,
        //    m.Name,
        //    m.Description,
        //    m.IMDB,
        //    Category = new
        //    {
        //        m.Category.Name,
        //    },
        //    Director = new
        //    {
        //        m.Director.FirstName,
        //        m.Director.LastName,
        //        m.Director.ImageUrl
        //    },
        //    Actors = m.Actors.Select(a => new
        //    {
        //        a.FirstName,
        //        a.LastName,
        //        a.ImageUrl
        //    }).ToList(),
        //}).ToList();
        //List<MovieDetailDto> dto = _mapper.Map<List<MovieDetailDto>>(movies);
        return Ok();
    }
}
