using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class CategoryManager : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public void Insert(CategoryAddRequestDto dto)
    {
        //Gelen dto mapper ile category nesnesine dönüştürülür.
        Category category = _mapper.Map<Category>(dto);

        //Category nesnesi veritabanına dataaccess metoduyla eklenir.
        _categoryRepository.Add(category);
    }


    public void Modify(CategoryUpdateRequestDto dto)
    {
        //Gelen dto mapper ile category nesnesine dönüştürülür.
        Category category = _mapper.Map<Category>(dto);

        //Category nesnesinin güncellenme tarihi ayarlanır.
        category.UpdateAt = DateTime.Now; // Ensure UpdatedDate is set to current time

        //Category nesnesi veritabanına dataaccess metoduyla güncellenir.
        _categoryRepository.Update(category);
    }

    public void Remove(Guid id)
    {
        // ID ile kategori bulunur.
        Category category = _categoryRepository.Get(c => c.Id.Equals(id));

        // Eğer kategori bulunamazsa, KeyNotFoundException fırlatılır.
        if (category == null)
        {
            throw new KeyNotFoundException($"Category with ID {id} not found.");
        }

        // Kategori nesnesi soft delete mantığıyla işaretlenir.
        category.IsDeleted = true; // Soft delete logic
        category.IsActive = false; // Optionally set IsActive to false

        // Güncellenme tarihi ayarlanır.
        category.UpdateAt = DateTime.Now; // Ensure UpdatedDate is set to current time

        // Kategori nesnesi veritabanına dataaccess metoduyla güncellenir.
        _categoryRepository.Update(category);
    }

    public ICollection<CategoryResponseDto> GetAll()
    {
        // Tüm kategorileri veritabanından alınır.
        var categories = _categoryRepository.GetQueryable().ToList();

        // Kategoriler, CategoryResponseDto'ya dönüştürülür.
        var categoryDtos = _mapper.Map<List<CategoryResponseDto>>(categories);
        // Kategoriler DTO'ya dönüştürüldükten sonra , DTO listesi döndürülür.
        return categoryDtos;
    }

    public CategoryResponseDto GetById(Guid id)
    {
        // ID ile kategori bulunur.
        var category = _categoryRepository.Get(c => c.Id.Equals(id));
        // Eğer kategori bulunamazsa, KeyNotFoundException fırlatılır.
        if (category == null)
        {
            throw new KeyNotFoundException($"Category with ID {id} not found.");
        }
        // Kategori, CategoryResponseDto'ya dönüştürülür.
        var categoryDto = _mapper.Map<CategoryResponseDto>(category);
        // Dönüştürülen DTO döndürülür.
        return categoryDto;
    }
}