using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class ActorManager : IActorService
{
    public List<Actor> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Actor> GetByFirstName(string firstname)
    {
        throw new NotImplementedException();
    }

    public Actor GetByFullName(string firstname, string lastname)
    {
        throw new NotImplementedException();
    }

    public Actor GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Actor> GetByLastName(string lastname)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Actor> GetQueryable()
    {
        throw new NotImplementedException();
    }

    public void Insert(Actor entity)
    {
        throw new NotImplementedException();
    }

    public void Modify(Actor entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(Actor entity)
    {
        throw new NotImplementedException();
    }
}
