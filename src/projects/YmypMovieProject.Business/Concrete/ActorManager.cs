using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Actors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class ActorManager : IActorService
{
    private readonly IActorRepository _actorRepository;

    public ActorManager(IActorRepository actorRepository)
    {
        _actorRepository = actorRepository;
    }


    public void Insert(ActorAddRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public void Modify(ActorUpdateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public void Remove(Guid id)
    {
        throw new NotImplementedException();
    }

    public ICollection<ActorResponseDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public ActorResponseDto GetById(Guid id)
    {
        throw new NotImplementedException();
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
}
