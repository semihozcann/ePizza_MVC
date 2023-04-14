using ePizza.Entities.Dtos.Categories;
using ePizza.Entities.Dtos.ProductTypes;
using ePizza.Shared.Utilities.Results.Abstract;
using ePizza.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        Task<IDataResult<CategoryListDto>> GetAllWithIdAsync(int categoryId);
        Task<IDataResult<CategoryDto>> GetAsync(int categoryId);
        Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto);
        Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
        Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId);
    }
}
