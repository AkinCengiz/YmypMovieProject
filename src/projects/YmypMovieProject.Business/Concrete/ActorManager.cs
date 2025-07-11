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
using YmypMovieProject.Entity.Dtos.Actors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class ActorManager : IActorService
{
    private readonly IActorRepository _actorRepository;
    private readonly IMapper _mapper;

    public ActorManager(IActorRepository actorRepository, IMapper mapper)
    {
        _actorRepository = actorRepository;
        _mapper = mapper;
    }


    public IResult Insert(ActorAddRequestDto dto)
    {
        try
        {
            var actor = _mapper.Map<Actor>(dto);
            _actorRepository.Add(actor);
            return new SuccessResult(ResultMessages.SuccessCreated);
        }
        catch (Exception e)
        {
            return new ErrorResult($"An error occurred while retrieving directors: {e.Message}");
        }
    }

    public IResult Modify(ActorUpdateRequestDto dto)
    {
        try
        {
            var actor = _mapper.Map<Actor>(dto);
            actor.UpdateAt = DateTime.Now;
            _actorRepository.Update(actor);
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
            var actor = _actorRepository.Get(a => a.Id == id);
            if (actor is null)
            {
                return new ErrorResult(ResultMessages.ErrorGetById);
            }
            actor.IsDeleted = true;
            actor.IsActive = false;
            actor.UpdateAt = DateTime.Now;
            _actorRepository.Update(actor);
            return new SuccessResult(ResultMessages.SuccessDeleted);
        }
        catch (Exception e)
        {
            return new ErrorResult($"An error occurred while retrieving directors: {e.Message}");
        }
    }

    public IDataResult<ICollection<ActorResponseDto>> GetAll(bool deleted = false)
    {
        try
        {
            var actors = _actorRepository.GetAll(a => a.IsDeleted == deleted);
            if (actors is null)
            {
                return new ErrorDataResult<ICollection<ActorResponseDto>>(ResultMessages.ErrorListed);
            }

            var actorsDto = _mapper.Map<ICollection<ActorResponseDto>>(actors);
            return new SuccessDataResult<ICollection<ActorResponseDto>>(actorsDto, ResultMessages.SuccessListed);
        }
        catch (Exception e)
        {
            return new ErrorDataResult<ICollection<ActorResponseDto>>($"An error occurred while retrieving directors: {e.Message}");
        }
    }

    public IDataResult<ActorResponseDto> GetById(Guid id)
    {
        try
        {
            var actor = _actorRepository.Get(a => a.Id.Equals(id));
            if (actor == null)
            {
                return new ErrorDataResult<ActorResponseDto>(ResultMessages.ErrorGetById);
            }

            var dto = _mapper.Map<ActorResponseDto>(actor);
            return new SuccessDataResult<ActorResponseDto>(dto, ResultMessages.SuccessGetById);
        }
        catch (Exception e)
        {
            return new ErrorDataResult<ActorResponseDto>($"An error occurred while retrieving directors: {e.Message}");
        }
    }

    public Task InsertAsync(ActorAddRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task ModifyAsync(ActorUpdateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<ActorResponseDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ActorResponseDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public IDataResult<ActorDetailDto> GetActorWithMovies(Guid id)
    {
        try
        {
            //var actor = _actorRepository.GetQueryable(a => a.Id == id).Include(a => a.Movies);
            var actor = _actorRepository.GetQueryable().Include(a => a.Movies).SingleOrDefault(a => a.Id == id);
            if (actor == null)
            {
                return new ErrorDataResult<ActorDetailDto>(ResultMessages.ErrorGetById);
            }

            var dto = _mapper.Map<ActorDetailDto>(actor);
            return new SuccessDataResult<ActorDetailDto>(dto, ResultMessages.SuccessGetById);
        }
        catch (Exception e)
        {
            return new ErrorDataResult<ActorDetailDto>($"An error occurred while retrieving directors: {e.Message}");
        }
    }

    public IDataResult<ICollection<ActorDetailDto>> GetActorsWithMovies()
    {
        try
        {
            var actors = _actorRepository.GetQueryable(a => !a.IsDeleted).Include(a => a.Movies).ToList();
            if (actors is null)
            {
                return new ErrorDataResult<ICollection<ActorDetailDto>>(ResultMessages.ErrorListed);
            }

            var actorsDto = _mapper.Map<ICollection<ActorDetailDto>>(actors);
            return new SuccessDataResult<ICollection<ActorDetailDto>>(actorsDto, ResultMessages.SuccessListed);
        }
        catch (Exception e)
        {
            return new ErrorDataResult<ICollection<ActorDetailDto>>($"An error occurred while retrieving directors: {e.Message}");
        }
    }
}
