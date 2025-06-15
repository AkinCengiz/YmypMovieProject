using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using YmypMovieProject.DataAccess.Contexts;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.DataAccess.Repositories.Concrete.EntityFramework;
public sealed class EfActorRepository : EfGenericRepository<Actor, MovieDbContext>, IActorRepository
{
    public EfActorRepository(MovieDbContext context) : base(context)
    {
    }
}
