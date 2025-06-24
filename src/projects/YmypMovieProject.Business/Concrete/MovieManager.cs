using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Movies;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class MovieManager : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieManager(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public void Insert(MovieAddRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public void Modify(MovieUpdateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public void Remove(Guid id)
    {
        throw new NotImplementedException();
    }

    public ICollection<MovieResponseDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public MovieResponseDto GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}
