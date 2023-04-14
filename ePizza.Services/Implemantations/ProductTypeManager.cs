using AutoMapper;
using ePizza.Entities.Concrete;
using ePizza.Entities.Dtos.ProductTypes;
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
    public class ProductTypeManager : IProductTypeService
    {
        private readonly IProductTypeRepository _productTypeRepository;
        private readonly IMapper _mapper;

        public ProductTypeManager(IProductTypeRepository productTypeRepository, IMapper mapper)
        {
            _productTypeRepository = productTypeRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<ProductTypeDto>> AddAsync(ProductTypeAddDto productTypeAddDto)
        {
            var productType = _mapper.Map<ProductType>(productTypeAddDto);

            var productTypeAdded = await _productTypeRepository.AddAsync(productType);
            await _productTypeRepository.SaveAsync();
            return new DataResult<ProductTypeDto>(ResultStatus.Success, Messages.ProductTypeAdded,
                new ProductTypeDto
                {
                    ProductType = productType,
                    Message = Messages.ProductTypeAdded,
                    ResultStatus = ResultStatus.Success
                });
        }

        public async Task<IDataResult<ProductTypeDto>> DeleteAsync(int productTypeId)
        {
            var productType = await _productTypeRepository.GetAsync(x => x.Id == productTypeId);
            if (productType!=null)
            {
                var deletedProductType = await _productTypeRepository.DeleteAsync(productType);
                await _productTypeRepository.SaveAsync();
                return new DataResult<ProductTypeDto>(ResultStatus.Success, Messages.ProductTypeDeleted, new ProductTypeDto
                {
                    ProductType = deletedProductType,
                    Message = Messages.ProductTypeDeleted,
                    ResultStatus = ResultStatus.Success
                });
            }
            else
            {
                return new DataResult<ProductTypeDto>(ResultStatus.Error, Messages.ProductTypeNotFound, new ProductTypeDto
                {
                    ProductType= null,
                    Message = Messages.ProductTypeNotFound,
                    ResultStatus = ResultStatus.Error
                });
            }
        }

        public async Task<IDataResult<ProductTypeListDto>> GetAllAsync()
        {
            var productTypes = await _productTypeRepository.GetAllAsync();
            if (productTypes!=null)
            {
                return new DataResult<ProductTypeListDto>(ResultStatus.Success, new ProductTypeListDto
                {
                    ProductTypes = productTypes,
                    ResultStatus= ResultStatus.Success,
                });


            }
            else
            {
                return new DataResult<ProductTypeListDto>(ResultStatus.Error, Messages.ProductTypeNotFound, new ProductTypeListDto
                {
                    ProductTypes = null,
                    ResultStatus = ResultStatus.Error,
                    Message = Messages.ProductTypeNotFound
                });
            }
        }

        public async Task<IDataResult<ProductTypeDto>> GetAsync(int productTypeId)
        {
            var productType = await _productTypeRepository.GetAsync(x => x.Id == productTypeId);
            if (productType!=null)
            {
                return new DataResult<ProductTypeDto>(ResultStatus.Success, new ProductTypeDto
                {
                    ProductType = productType,
                    ResultStatus= ResultStatus.Success
                });
            }
            else
            {
                return new DataResult<ProductTypeDto>(ResultStatus.Error, Messages.ProductTypeNotFound, new ProductTypeDto
                {
                    ProductType= null,
                    Message = Messages.ProductTypeNotFound,
                    ResultStatus = ResultStatus.Error
                });
            }
        }

        public async Task<IDataResult<ProductTypeDto>> UpdateAsync(ProductTypeUpdateDto productTypeUpdateDto)
        {
            var oldProductType = await _productTypeRepository.GetAsync(x => x.Id == productTypeUpdateDto.Id);

            var productType = _mapper.Map<ProductTypeUpdateDto, ProductType>(productTypeUpdateDto, oldProductType);
            var updatedProductType = await _productTypeRepository.UpdateAsync(productType);
            await _productTypeRepository.SaveAsync();

            return new DataResult<ProductTypeDto>(ResultStatus.Success, new ProductTypeDto
            {
                ProductType = updatedProductType,
                Message = Messages.ProductTypeUpdated,
                ResultStatus = ResultStatus.Success
            });
        }
    }
}
