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
public sealed class MovieManager : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieManager(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public void Insert(Movie entity)
    {
        _movieRepository.Add(entity);
    }

    public void Modify(Movie entity)
    {
        _movieRepository.Update(entity);
    }

    public void Remove(Movie entity)
    {
        entity.IsDeleted = true; // Soft delete
        entity.IsActive = false; // Deactivate the movie
        _movieRepository.Update(entity);
    }

    public List<Movie> GetAll()
    {
        return _movieRepository.GetAll();
    }

    public Movie GetById(Guid id)
    {
        return _movieRepository.Get(m => m.Id == id);
    }

    public IQueryable<Movie> GetQueryable()
    {
        return _movieRepository.GetQueryable();
    }

    public List<Movie> GetByIsActive()
    {
        return _movieRepository.GetAll(m => m.IsActive);
    }
  
    public List<Movie> GetByIsDeleted()
    {
        return _movieRepository.GetAll(m => m.IsDeleted);
    }

    public List<Movie> GetByName(string name)
    {
        return _movieRepository.GetAll(m => m.Name.Equals(name));
    }

    public List<Movie> GetByLessThanIMDB(decimal imdb)
    {
        return _movieRepository.GetAll(m => m.IMDB <= imdb);
    }

    public List<Movie> GetByGreaterThanIMDB(decimal imdb)
    {
        return _movieRepository.GetAll(m => m.IMDB >= imdb);
    }

    public List<Movie> GetByCategoryId(Guid categoryId)
    {
        return _movieRepository.GetAll(m => m.CategoryId == categoryId);
    }

    public List<Movie> GetByDirectorId(Guid directorId)
    {
        return _movieRepository.GetAll(m => m.DirectorId == directorId);
    }

    public List<Movie> GetMoviesWithFullInfo()
    {
        return _movieRepository.GetQueryable()
            .Include(m => m.Category)
            .Include(m => m.Director)
            .Include(m => m.Actors).ToList();
    }

    
}
