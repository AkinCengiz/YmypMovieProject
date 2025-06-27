using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.Business
{ 
    public interface IGenericService<TEntity, TResponseDto,TCreateDto,TUpdateDto> 
        where TEntity : class, IEntity, new()
        where TResponseDto : class, IDto
        where TCreateDto : class, IDto
        where TUpdateDto : class, IDto
    {
       void Insert(TCreateDto dto);
        void Modify(TUpdateDto dto);
        void Remove(Guid id);
        ICollection<TResponseDto> GetAll();
        TResponseDto GetById(Guid id);



    }
}


