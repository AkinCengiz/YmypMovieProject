using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Abstract;
public interface IActorService : IGenericService<Actor>
{
    List<Actor> GetByFirstName(string firstname);
    List<Actor> GetByLastName(string lastname);
    Actor GetByFullName(string firstname, string lastname);
    List<Actor> GetAllByWithMovie();
}
