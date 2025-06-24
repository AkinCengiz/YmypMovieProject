using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using AutoMapper;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DirectorsController : ControllerBase
{
    private readonly IDirectorService _directorService;


    public DirectorsController(IDirectorService directorService, IMapper mapper)
    {
        _directorService = directorService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var directors = _directorService.GetAll();
        return Ok(directors);
    }
    [HttpGet("FullInfo")]
    public IActionResult GetFullInfo()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetDirector(string id)
    {
        var director = _directorService.GetById(Guid.Parse(id));
        return Ok(director);
    }
    [HttpGet("GetAllIsActive")]
    public IActionResult GetAllIsActive()
    {
        //var directors = _directorService.GetByIsActive();
        //var dto = directors.Select(d => new
        //{
        //    d.Id,
        //    d.FirstName,
        //    d.LastName,
        //    d.ImageUrl,
        //    d.BirthDate,
        //    d.Description,
        //    Movies = d.Movies.Select(m => new
        //    {
        //        m.Name
        //    }).ToList()
        //}).ToList();
        return Ok();
    }
}
//{ }