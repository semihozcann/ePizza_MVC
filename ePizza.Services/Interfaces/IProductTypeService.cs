using ePizza.Entities.Dtos.Products;
using ePizza.Entities.Dtos.ProductTypes;
using ePizza.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Services.Interfaces
{
    public interface IProductTypeService
    {
        Task<IDataResult<ProductTypeListDto>> GetAllAsync();
        Task<IDataResult<ProductTypeDto>> GetAsync(int productTypeId);
        Task<IDataResult<ProductTypeDto>> AddAsync(ProductTypeAddDto productTypeAddDto);
        Task<IDataResult<ProductTypeDto>> UpdateAsync(ProductTypeUpdateDto productTypeUpdateDto);
        Task<IDataResult<ProductTypeDto>> DeleteAsync(int productTypeId);
    }
}
