using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.DataAccess.Repositories.Abstract;
public interface IDirectorRepository : IGenericRepository<Director>, IGenericRepositoryAsync<Director>
{
}
