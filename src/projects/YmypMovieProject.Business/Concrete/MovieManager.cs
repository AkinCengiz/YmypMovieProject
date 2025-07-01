using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Movies;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class MovieManager //: IMovieService
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;

    public MovieManager(IMovieRepository movieRepository, IMapper mapper)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
    }

    public void Insert(MovieAddRequestDto dto)
    {
        Movie movie = _mapper.Map<Movie>(dto);
        _movieRepository.Add(movie);
    }

    public void Modify(MovieUpdateRequestDto dto)
    {
        var movie = _mapper.Map<Movie>(dto);
        movie.UpdateAt = DateTime.Now; // Ensure UpdatedDate is set to current time
        _movieRepository.Update(movie);
    }

    public void Remove(Guid id)
    {
        var movie = _movieRepository.Get(m => m.Id.Equals(id));
        if (movie == null)
        {
            throw new KeyNotFoundException($"Movie with ID {id} not found.");
        }
        movie.IsDeleted = true; // Soft delete logic
        movie.IsActive = false; // Optionally set IsActive to false
        movie.UpdateAt = DateTime.Now; // Ensure UpdatedDate is set to current time
        _movieRepository.Update(movie);
    }

    public ICollection<MovieResponseDto> GetAll()
    {
        var movies = _movieRepository.GetAll(m => !m.IsDeleted);
        var movieDtos = _mapper.Map<ICollection<MovieResponseDto>>(movies);
        return movieDtos;
    }

    public MovieResponseDto GetById(Guid id)
    {
        var movie = _movieRepository.Get(m => m.Id.Equals(id));

        if (movie == null)
        {
            throw new KeyNotFoundException($"Movie with ID {id} not found.");
        }
        var movieDto = _mapper.Map<MovieResponseDto>(movie);
        return movieDto;
    }

    public List<MovieDetailDto> GetMoviesWithFullInfo()
    {
        var movies = _movieRepository.GetQueryable(m => !m.IsDeleted)
            .Include(m => m.Category)
            .Include(m => m.Director)
            .Include(m => m.Actors).ToList();

        var movieDetails = _mapper.Map<List<MovieDetailDto>>(movies);
        return movieDetails;
    }

    public async Task InsertAsync(MovieAddRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task ModifyAsync(MovieUpdateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<MovieResponseDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<MovieResponseDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
