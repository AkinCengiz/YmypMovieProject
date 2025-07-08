using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Business.Utilites.Results;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Business.Constants;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class DirectorManager : IDirectorService
{
    private readonly IDirectorRepository _directorRepository;
    private readonly IMapper _mapper;

    public DirectorManager(IDirectorRepository directorRepository, IMapper mapper)
    {
        _directorRepository = directorRepository;
        _mapper = mapper;
    }


    public IResult Insert(DirectorAddRequestDto dto)
    {
        try
        {
            var director = _mapper.Map<Director>(dto);
            _directorRepository.Add(director);
            return new SuccessResult(ResultMessages.SuccessCreated);
        }
        catch (Exception e)
        {
            return new ErrorResult($"An error occurred while retrieving directors: {e.Message}");
        }
    }

    public IResult Modify(DirectorUpdateRequestDto dto)
    {
        try
        {
            var director = _mapper.Map<Director>(dto);
            director.UpdateAt = DateTime.Now;
            _directorRepository.Update(director);
            return new SuccessResult(ResultMessages.SuccessUpdated);
        }
        catch (Exception e)
        {
            return new ErrorResult($"An error occurred while retrieving directors: {e.Message}");
        }
    }

    public IResult Remove(Guid id)
    {
        try
        {
            var director = _directorRepository.Get(d => d.Id == id);
            if (director is null)
            {
                return new ErrorResult(ResultMessages.ErrorGetById);
            }

            director.IsDeleted = true;
            director.IsActive = false;
            director.UpdateAt = DateTime.Now;
            _directorRepository.Update(director);
            return new SuccessResult(ResultMessages.SuccessDeleted);
        }
        catch (Exception e)
        {
            return new ErrorResult($"An error occurred while retrieving directors: {e.Message}");
        }
    }

    public IDataResult<ICollection<DirectorResponseDto>> GetAll(bool deleted)
    {
        try
        {
            var directors = _directorRepository.GetAll(d => d.IsDeleted == deleted);
            if (directors is null || !directors.Any())
            {
                return new ErrorDataResult<ICollection<DirectorResponseDto>>(ResultMessages.ErrorListed);
            }
            var dtos = _mapper.Map<ICollection<DirectorResponseDto>>(directors);
            return new SuccessDataResult<ICollection<DirectorResponseDto>>(dtos, ResultMessages.SuccessListed);
        }
        catch (Exception e)
        {
            return new ErrorDataResult<ICollection<DirectorResponseDto>>($"An error occurred while retrieving directors: {e.Message}");
        }
    }

    //public IDataResult<ICollection<DirectorResponseDto>> GetAllDeleted()
    //{
    //    try
    //    {
    //        var directors = _directorRepository.GetAll(d => d.IsDeleted);
    //        if (directors is null || !directors.Any())
    //        {
    //            return new ErrorDataResult<ICollection<DirectorResponseDto>>(ResultMessages.ErrorListed);
    //        }
    //        var dtos = _mapper.Map<ICollection<DirectorResponseDto>>(directors);
    //        return new SuccessDataResult<ICollection<DirectorResponseDto>>(dtos, ResultMessages.SuccessListed);
    //    }
    //    catch (Exception e)
    //    {
    //        return new ErrorDataResult<ICollection<DirectorResponseDto>>($"An error occurred while retrieving directors: {e.Message}");
    //    }
    //}

    public IDataResult<DirectorResponseDto> GetById(Guid id)
    {
        try
        {
            var director = _directorRepository.Get(d => d.Id == id);
            if (director is null)
            {
                return new ErrorDataResult<DirectorResponseDto>(ResultMessages.ErrorGetById);
            }
            var dto = _mapper.Map<DirectorResponseDto>(director);

            return new SuccessDataResult<DirectorResponseDto>(dto, ResultMessages.SuccessGetById);
        }
        catch (Exception e)
        {
            return new ErrorDataResult<DirectorResponseDto>($"An error occurred while retrieving the director: {e.Message}");
        }
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

    public IDataResult<List<DirectorDetailDto>> GetAllFullInfo()
    {
        try
        {
            var directors = _directorRepository.GetQueryable().Include(d => d.Movies).ThenInclude(m => m.Actors).ToList();
            if (directors is null)
            {
                return new ErrorDataResult<List<DirectorDetailDto>>(ResultMessages.ErrorListed);
            }

            var directorsDto = _mapper.Map<List<DirectorDetailDto>>(directors);
            return new SuccessDataResult<List<DirectorDetailDto>>(directorsDto, ResultMessages.SuccessListed);
        }
        catch (Exception e)
        {
            return new ErrorDataResult<List<DirectorDetailDto>>($"An error occurred while retrieving the director: {e.Message}");
        }
    }
}
