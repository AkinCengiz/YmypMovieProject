using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business;
public interface IGenericService<T> where T : class, IEntity, new()
{
    void Insert(T entity);
    void Modify(T entity);
    void Remove(T entity);
    List<T> GetAll();
    T GetById(Guid id);
}
