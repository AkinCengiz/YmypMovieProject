using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YmypMovieProject.Business.Abstract;

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
        var dto = directors.Select(d => new
        {
            ID = d.Id,
            Adi = d.FirstName,
            Soyadi = d.LastName,
            Resim = d.ImageUrl,
            DogunTarihih = d.BirthDate,
            Aciklama = d.Description,
            Filmleri = d.Movies.Select(m => new
            {
                Film = m.Name,
                Kategori = m.Category.Name
            }).ToList()
        }).ToList();
        return Ok(dto);
    }
}
