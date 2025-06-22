using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Mappers.Categories;
public sealed class ManuelCategoryMapper : ICategoryMapper
{
    public Category ConvertToEntity(CategoryAddRequestDto dto)
    {
        return new Category
        {
            Name = dto.Name,
            Description = dto.Description
        };
    }
    public Category ConvertToEntity(CategoryUpdateRequestDto dto)
    {
        return new Category
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            IsActive = dto.IsActive,
            IsDeleted = dto.IsDeleted
        };
    }

    public CategoryResponseDto ConvertToResponse(Category category)
    {
        return new CategoryResponseDto
        {
            Id = category.Id,
            Name = category.Name ?? string.Empty,
            Description = category.Description ?? string.Empty
        };
    }

    public List<CategoryResponseDto> ConvertToResponseList(List<Category> categories)
    {
        //List<CategoryResponseDto> responseList = new List<CategoryResponseDto>();
        //foreach (var category in categories)
        //{
        //    responseList.Add(ConvertToResponse(category));
        //}
        //return responseList;
        return categories.Select(x => ConvertToResponse(x)).ToList();
    }
}


//      string Yaz(string firstname){
/*          return"Merhaba " + firstname + "!";
 *      }
 **
 *      string Yaz(int age){
   *          return age.ToString() + " yaşındasınız!";
   *     }
 *
 *      string Yaz(string firstname, string lastname){
 *          return "Merhaba " + firstname + " " + lastname + "!";
 *      }
 *
 *      string Yaz(int ay, int yil){
   *          return yil.ToString() + " yılının " + ay.ToString() + ". ayında doğdunuz!";
   *      }
 
 * 
 *      Yaz("Ahmet"); // "Merhaba Ahmet!"
 *      Yaz("Ahmet", "Yılmaz"); // "Merhaba Ahmet Yılmaz!"
 *
 * 
 * 
 * 
 * */