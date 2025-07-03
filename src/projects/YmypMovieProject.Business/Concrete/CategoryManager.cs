using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Business.Utilites.Results;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Business.Constants;
using YmypMovieProject.Business.Validators;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete;
public sealed class CategoryManager : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    private readonly CategoryValidator _categoryValidator;



    public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
        _categoryValidator = new CategoryValidator();
    }

    public IResult Insert(CategoryAddRequestDto dto)
    {
        try
        {
            ValidationResult result = _categoryValidator.Validate(dto);
            if (!result.IsValid)
            {
                string errorMessages = string.Join(",\n ", result.Errors.Select(e => e.ErrorMessage));

                return new ErrorResult(errorMessages);
            }

            // Eğer doğrulama başarılıysa, Category nesnesine dönüştürülür.
            var category = _mapper.Map<Category>(dto);

            _categoryRepository.Add(category);
            return new SuccessResult(ResultMessages.SuccessCategoryCreated);
        }
        catch (Exception e)
        {
            return new ErrorResult($"An error occurred while adding the category: {e.Message}");
        }








        
        ////Gelen dto mapper ile category nesnesine dönüştürülür.
        ////ValidationResult result = _categoryValidator.Validate(dto);
        ////if (!result.IsValid)
        ////{
        ////    // Eğer doğrulama başarısızsa, ValidationException fırlatılır.
        ////    throw new ValidationException(result.Errors);
        ////}
        //Category category = _mapper.Map<Category>(dto);

        ////Category nesnesi veritabanına dataaccess metoduyla eklenir.
        //_categoryRepository.Add(category);
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
            throw new KeyNotFoundException(ResultMessages.ErrorCategoryGetById);
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
        var categories = _categoryRepository.GetQueryable(c => !c.IsDeleted).ToList();

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
            throw new KeyNotFoundException(ResultMessages.ErrorCategoryGetById);
        }
        // Kategori, CategoryResponseDto'ya dönüştürülür.
        var categoryDto = _mapper.Map<CategoryResponseDto>(category);
        // Dönüştürülen DTO döndürülür.
        return categoryDto;
    }

    public async Task InsertAsync(CategoryAddRequestDto dto)
    {
        try
        {
            //if (dto is null)
            //{
            //    throw new ArgumentNullException(nameof(dto), "CategoryAddRequestDto cannot be null.");
            //}
            ValidationResult result = _categoryValidator.Validate(dto);
            if (!result.IsValid)
            {
                // Eğer doğrulama başarısızsa, ValidationException fırlatılır.
                result.Errors.ForEach(error => Console.WriteLine(error.ErrorMessage));
            }
            var category = _mapper.Map<Category>(dto);
            //Category nesnesi veritabanına dataaccess metoduyla eklenir.
            await _categoryRepository.AddAsync(category);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Task ModifyAsync(CategoryUpdateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<CategoryResponseDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CategoryResponseDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}