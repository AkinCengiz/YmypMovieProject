using Core.Business;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business.Utilites.Results;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Abstract;
public interface IDirectorService : IGenericService<Director,DirectorResponseDto,DirectorAddRequestDto,DirectorUpdateRequestDto>,IGenericServiceAsync<Director, DirectorResponseDto, DirectorAddRequestDto, DirectorUpdateRequestDto>
{
    //List<Director> GetByFirstName(string firstname);
    //List<Director> GetByLastName(string lastname);
    //Director GetByFullName(string firstname, string lastname);
    IDataResult<List<DirectorDetailDto>> GetAllFullInfo();
    //void Insert(DirectorAddRequestDto dto);
    //void Modify(DirectorUpdateRequestDto dto);
    //void Remove(Guid id);
    //ICollection<DirectorResponseDto> GetAll();
    //DirectorResponseDto GetById(Guid id);
}
