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
        var result = _directorService.GetAll(false);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }

    [HttpGet("[action]")]
    public IActionResult GetAllDeleted()
    {
        var result = _directorService.GetAll(true);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }


    [HttpGet("FullInfo")]
    public IActionResult GetFullInfo()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetDirector(Guid id)
    {
        var result = _directorService.GetById(id);
        if (!result.Success)
        {
            return NotFound(result.Message);
        }
        return Ok(result.Data);
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