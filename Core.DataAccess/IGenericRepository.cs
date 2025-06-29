using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.DataAccess;

public interface IGenericRepository<T> where T : class, IEntity, new()
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    T Get(Expression<Func<T, bool>>? filter);
    List<T> GetAll(Expression<Func<T, bool>>? filter = null);
    IQueryable<T> GetQueryable(Expression<Func<T, bool>>? filter = null);
}

