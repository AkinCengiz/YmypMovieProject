using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class ActorManager : IActorService
{
    private readonly IActorRepository _actorRepository;

    public ActorManager(IActorRepository actorRepository)
    {
        _actorRepository = actorRepository;
    }

    
}
