using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DirectorsController : ControllerBase
{
    private readonly IDirectorService _directorService;

    public DirectorsController(IDirectorService directorService)
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
        var directors = _directorService.GetAllFullInfo();
        //var dto = directors.Select(d => new
        //{
        //    ID = d.Id,
        //    Adi = d.FirstName,
        //    Soyadi = d.LastName,
        //    Resim = d.ImageUrl,
        //    DogumTarihi = d.BirthDate,
        //    Aciklama = d.Description,
        //    Filmleri = d.Movies.Select(m => new
        //    {
        //        Film = m.Name,
        //        Kategori = m.Category.Name
        //    }).ToList()
        //}).ToList();
        var dto = directors.Select(d => new
        {
            d.Id,
            d.FirstName,
            d.LastName,
            d.ImageUrl,
            d.BirthDate,
            d.Description,
            Movies = d.Movies.Select(m => new
            {
                m.Name,
                Category = m.Category.Name,
                m.Category.Description
            }).ToList()
        }).ToList();
        return Ok(dto);
    }

    [HttpGet("{id}")]
    public IActionResult GetDirector(string id)
    {
        Director director = _directorService.GetById(Guid.Parse(id));
        var dto = new
        {
            director.Id,
            director.FirstName,
            director.LastName,
            director.ImageUrl,
            director.BirthDate,
            director.Description,
            Movies = director.Movies.Select(m => new
            {
                m.Name
            }).ToList()
        };
        return Ok(dto);
    }
    [HttpGet("GetAllIsActive")]
    public IActionResult GetAllIsActive()
    {
        var directors = _directorService.GetByIsActive();
        var dto = directors.Select(d => new
        {
            d.Id,
            d.FirstName,
            d.LastName,
            d.ImageUrl,
            d.BirthDate,
            d.Description,
            Movies = d.Movies.Select(m => new
            {
                m.Name
            }).ToList()
        }).ToList();
        return Ok(dto);
    }
}
//{ }