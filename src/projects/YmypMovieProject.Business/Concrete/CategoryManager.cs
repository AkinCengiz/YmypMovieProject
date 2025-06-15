using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class CategoryManager : ICategoryService
{
    //private readonly ICar
    public List<Category> GetAll()
    {
        throw new NotImplementedException();
    }

    public Category GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Category> GetQueryable()
    {
        throw new NotImplementedException();
    }

    public void Insert(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Modify(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(Category entity)
    {
        throw new NotImplementedException();
    }
}
