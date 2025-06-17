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
public sealed class CategoryManager : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryManager(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public List<Category> GetAll()
    {
        //_categoryRepository.GetQueryable().ToList();
        //_categoryRepository.GetAll();
        //return _categoryRepository.GetAll(c => !c.IsDeleted);
        return _categoryRepository.GetAll();
    }

    public Category GetById(Guid id)
    {
        return _categoryRepository.Get(c => c.Id == id);
    }

    public IQueryable<Category> GetQueryable()
    {
        return _categoryRepository.GetQueryable();
    }

    public List<Category> GetByIsActive()
    {
        return _categoryRepository.GetAll(c => c.IsActive);
    }

    public List<Category> GetByIsDeleted()
    {
        return _categoryRepository.GetAll(c => c.IsDeleted);
    }

    public void Insert(Category entity)
    {
        _categoryRepository.Add(entity);
    }

    public void Modify(Category entity)
    {
        entity.UpdateAt = DateTime.Now; // Ensure UpdatedDate is set to current time
        _categoryRepository.Update(entity);
    }

    public void Remove(Category entity)
    {
        entity.IsDeleted = true; // Soft delete logic
        entity.IsActive = false; // Optionally set IsActive to false
        _categoryRepository.Delete(entity);
    }
}
