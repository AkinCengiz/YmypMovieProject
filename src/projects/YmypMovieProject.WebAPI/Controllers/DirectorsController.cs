﻿using Microsoft.AspNetCore.Http;
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
        var result = _directorService.GetAllFullInfo();
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }

        return Ok(result);
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

    [HttpPost]
    public IActionResult CreateDirector(DirectorAddRequestDto dto)
    {
        var result = _directorService.Insert(dto);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Message);
    }

    [HttpPut]
    public IActionResult UpdateDirector(DirectorUpdateRequestDto dto)
    {
        var result = _directorService.Modify(dto);
        if (result.Success)
        {
            return Ok(result.Message);
        }

        return BadRequest(result.Message);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteDirector(Guid id)
    {
        var result = _directorService.Remove(id);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Message);
    }

}
//{ }