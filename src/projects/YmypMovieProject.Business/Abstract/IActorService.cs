using Core.Business;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business.Utilites.Results;
using YmypMovieProject.Entity.Dtos.Actors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Abstract;
public interface IActorService : IGenericService<Actor,ActorResponseDto,ActorAddRequestDto,ActorUpdateRequestDto>,
    IGenericServiceAsync<Actor, ActorResponseDto, ActorAddRequestDto, ActorUpdateRequestDto>
{
    //List<Actor> GetByFirstName(string firstname);
    //List<Actor> GetByLastName(string lastname);
    //Actor GetByFullName(string firstname, string lastname);
    IDataResult<ActorDetailDto> GetActorWithMovies(Guid id);

    IDataResult<ICollection<ActorDetailDto>> GetActorsWithMovies();
    //void Insert(Actor dto);
    //void Modify(Actor dto);
    //void Remove(Guid id);

    //ICollection<Actor> GetAll();
    //Actor GetById(Guid id);
}
