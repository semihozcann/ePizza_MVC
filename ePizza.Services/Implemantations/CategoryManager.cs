using AutoMapper;
using ePizza.Entities.Concrete;
using ePizza.Entities.Dtos.Categories;
using ePizza.Repositories.Interfaces;
using ePizza.Services.Constants;
using ePizza.Services.Interfaces;
using ePizza.Shared.Utilities.Results.Abstract;
using ePizza.Shared.Utilities.Results.ComplexType;
using ePizza.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Services.Implemantations
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto)
        {
            var category = _mapper.Map<Category>(categoryAddDto);

            var categoryAdded = await _categoryRepository.AddAsync(category);

            await _categoryRepository.SaveAsync();

            return new DataResult<CategoryDto>(ResultStatus.Success, Messages.CategoryAdded, new CategoryDto
            {
                Category = categoryAdded,
                Message = Messages.CategoryAdded,
                ResultStatus = ResultStatus.Success
            });
        }

        public async Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId)
        {
            var category = await _categoryRepository.GetAsync(x => x.Id == categoryId);
            if (category != null)
            {
                var deletedCategory = await _categoryRepository.DeleteAsync(category);
                await _categoryRepository.SaveAsync();
                return new DataResult<CategoryDto>(ResultStatus.Success, Messages.CategoryDeleted, new CategoryDto
                {
                    Category = deletedCategory,
                    Message = Messages.CategoryDeleted,
                    ResultStatus = ResultStatus.Error
                });
            }
            else
            {
                return new DataResult<CategoryDto>(ResultStatus.Error, Messages.CategoryNotFound, new CategoryDto
                {
                    Category = null,
                    Message = Messages.CategoryNotFound,
                    ResultStatus = ResultStatus.Error
                });
            }
        }

        public async Task<IDataResult<CategoryListDto>> GetAllAsync()
        {
            var categories =await _categoryRepository.GetAllAsync();
            if (categories!=null)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success

                });
            }
            else
            {
                return new DataResult<CategoryListDto>(ResultStatus.Error, Messages.CategoryNotFound, new CategoryListDto
                {
                    Categories = null,
                    Message= Messages.CategoryNotFound,
                    ResultStatus=ResultStatus.Error
                     
                });
            }

        }

        public async Task<IDataResult<CategoryListDto>> GetAllWithIdAsync(int categoryId)
        {
            var categories = await _categoryRepository.GetAllAsync(x => x.Id == categoryId);
            if (categories != null)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success

                });
            }
            else
            {
                return new DataResult<CategoryListDto>(ResultStatus.Error, Messages.CategoryNotFound, new CategoryListDto
                {
                    Categories = null,
                    Message = Messages.CategoryNotFound,
                    ResultStatus = ResultStatus.Error

                });
            }
        }

        public async Task<IDataResult<CategoryDto>> GetAsync(int categoryId)
        {
            var category = await _categoryRepository.GetAsync(x => x.Id == categoryId);

            if (category != null)
            {
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto
                {
                    Category = category,
                    ResultStatus = ResultStatus.Success
                });
            }
            else
            {
                return new DataResult<CategoryDto>(ResultStatus.Error, Messages.CategoryNotFound, new CategoryDto
                {
                    Category = null,
                    Message = Messages.CategoryNotFound,
                    ResultStatus = ResultStatus.Error
                });
            }
        }

        public async Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
            var oldCategory = await _categoryRepository.GetAsync(x => x.Id == categoryUpdateDto.Id);

            var category = _mapper.Map<CategoryUpdateDto, Category>(categoryUpdateDto, oldCategory);

            var updatedCategory = await _categoryRepository.UpdateAsync(category);
            await _categoryRepository.SaveAsync();
            return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto
            {
                Category = updatedCategory,
                Message = Messages.CategoryUpdated,
                ResultStatus = ResultStatus.Success
            });
        }
    }
}
   