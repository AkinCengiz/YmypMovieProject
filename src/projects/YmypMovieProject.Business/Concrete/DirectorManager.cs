using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class DirectorManager //: IDirectorService
{
    private readonly IDirectorRepository _directorRepository;
    private readonly IMapper _mapper;

    public void Insert(DirectorAddRequestDto dto)
    {
        Director director = _mapper.Map<Director>(dto);
        _directorRepository.Add(director);
    }

    public void Modify(DirectorUpdateRequestDto dto)
    {
        Director director = _mapper.Map<Director>(dto);
        director.UpdateAt = DateTime.UtcNow;
        _directorRepository.Update(director);
    }

    public void Remove(Guid id)
    {
        Director director = _directorRepository.Get(d => d.Id == id);
        if (director == null)
        {
            throw new KeyNotFoundException("Director not found.");
        }
        director.IsActive = false;
        director.IsDeleted = true;
        director.UpdateAt = DateTime.UtcNow;
        _directorRepository.Update(director);
    }

    public ICollection<DirectorResponseDto> GetAll()
    {
        var directors = _directorRepository.GetQueryable().ToList();
        if (directors is null)
        {
            return new List<DirectorResponseDto>();
        }
        List<DirectorResponseDto> dtos = _mapper.Map<List<DirectorResponseDto>>(directors);
        return dtos;
    }

    public DirectorResponseDto GetById(Guid id)
    {
        var director = _directorRepository.Get(d => d.Id == id);
        if (director is null)
        {
            throw new KeyNotFoundException("Director not found.");
        }
        DirectorResponseDto dto = _mapper.Map<DirectorResponseDto>(director);
        return dto;
    }

    public Task InsertAsync(DirectorAddRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task ModifyAsync(DirectorUpdateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<DirectorResponseDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DirectorResponseDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
