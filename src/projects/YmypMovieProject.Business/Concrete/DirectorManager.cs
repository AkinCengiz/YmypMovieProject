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
public sealed class DirectorManager : IDirectorService
{
    private readonly IDirectorRepository _directorRepository;

    public DirectorManager(IDirectorRepository directorRepository)
    {
        _directorRepository = directorRepository;
    }

    public void Insert(Director entity)
    {
        _directorRepository.Add(entity);
    }

    public void Modify(Director entity)
    {
        _directorRepository.Update(entity);
    }

    public void Remove(Director entity)
    {
        _directorRepository.Delete(entity);
    }

    public List<Director> GetAll()
    {
        return _directorRepository.GetAll();
    }

    public Director GetById(Guid id)
    {
        return _directorRepository.Get(d => d.Id == id);
    }

    public IQueryable<Director> GetQueryable()
    {
        return _directorRepository.GetQueryable();
    }

    public List<Director> GetByIsActive()
    {
        return _directorRepository.GetAll(d => d.IsActive);
    }

    public List<Director> GetByIsDeleted()
    {
        return _directorRepository.GetAll(d => d.IsDeleted);
        //return _directorRepository.GetQueryable(d => d.IsDeleted).Include(d => d.Movies).ToList();
    }

    public List<Director> GetByFirstName(string firstname)
    {
        return _directorRepository.GetAll(d => d.FirstName == firstname);
    }

    public List<Director> GetByLastName(string lastname)
    {
        return _directorRepository.GetAll(d => d.LastName == lastname);
    }

    public Director GetByFullName(string firstname, string lastname)
    {
        return _directorRepository.Get(d => d.FirstName == firstname && d.LastName == lastname);
    }
}
