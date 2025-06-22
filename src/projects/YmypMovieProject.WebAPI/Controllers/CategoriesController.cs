using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Business.Mappers.Categories;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Dtos.Movies;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private readonly ICategoryMapper _mapper;

    public CategoriesController(ICategoryService categoryService,ICategoryMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper; 
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var categories = _categoryService.GetAll();
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var category = _categoryService.GetById(id);
        return Ok(category);
    }

    [HttpPost]
    public IActionResult Create(Category category)
    {
        _categoryService.Insert(category);
        return Ok(category);
    }

    [HttpPut]
    public IActionResult Update(Category category)
    {
        _categoryService.Modify(category);
        return Content("Kategori güncelleme işlemi başarılı...");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var category = _categoryService.GetById(id);
        _categoryService.Remove(category);
        return Content("Kategori silme işlemi başarılı...");
    }

    [HttpGet("active")]
    public IActionResult GetActiveCategories()
    {
        return Ok();
    }

    [HttpGet("GetAllFullInfo")]
    public IActionResult GetAllFullInfo()
    {
        var categories = _categoryService.GetQueryable().Include(c => c.Movies).ToList();
        
        //List<CategoryResponseDto> dtos = new List<CategoryResponseDto>();
        //foreach (var category in categories)
        //{
        //    dtos.Add(new CategoryResponseDto()
        //    {
        //        Id = category.Id,
        //        Name = category.Name ?? string.Empty,
        //        Description = category.Description ?? string.Empty
        //    });
        //}
       
        var dtos = _mapper.ConvertToResponseList(categories);
        return Ok(dtos);
    }
}
