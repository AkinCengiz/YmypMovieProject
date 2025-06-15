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
public sealed class EfMovieRepository : EfGenericRepository<Movie,MovieDbContext>,IMovieRepository
{
    public EfMovieRepository(MovieDbContext context) : base(context)
    {
    }
}