using AutoMapper;
using ePizza.Entities.Concrete;
using ePizza.Entities.Dtos.Products;
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
    public class ProductManager : IProductService
    {

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductManager(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        

        public async Task<IDataResult<ProductDto>> AddAsync(ProductAddDto productAddDto )
        {

            var product = _mapper.Map<Product>(productAddDto);// öncelikle gelen datayı dto olarak maplememiz gerekmektedir. aksi halde ananymous type olarak giden data hata cozulmeyecektir. 
            var productAdded = await _productRepository.AddAsync(product);
            await _productRepository.SaveAsync();
           
            return new DataResult<ProductDto>(ResultStatus.Success, Messages.ProductAdded, new ProductDto
            {

                Product = productAdded,
                Message = Messages.ProductAdded,
                ResultStatus = ResultStatus.Success
            });


        }

        public async Task<IDataResult<ProductDto>> DeleteAsync(int productId)
        {
            var product = await _productRepository.GetAsync(x => x.Id == productId);
            if (product!=null)
            {
                var deletedProduct = await _productRepository.DeleteAsync(product);
                await _productRepository.SaveAsync();
                return new DataResult<ProductDto>(ResultStatus.Success, Messages.ProductDeleted, new ProductDto
                {
                    Product = deletedProduct,
                    Message = Messages.ProductDeleted, 
                    ResultStatus = ResultStatus.Success
                });
            }
            else
            {
                return new DataResult<ProductDto>(ResultStatus.Error, Messages.ProductNotFound, new ProductDto
                {
                    Product = null,
                    Message = Messages.ProductNotFound,
                    ResultStatus = ResultStatus.Error
                });
            }
        }

        public  async Task<IDataResult<ProductListDto>> GetAllAsync()
        {
            var product =await  _productRepository.GetAllAsync();
            if (product!=null)
            {

                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                   Products=product

                });
            }
            else
            {
                return new DataResult<ProductListDto>(ResultStatus.Error,Messages.ProductNotFound, new ProductListDto
                {
                    Products = null,
                    Message= Messages.ProductNotFound,
                     ResultStatus=ResultStatus.Error

                });
            }
        }

        public async Task<IDataResult<ProductDto>> GetAsync(int productId)
        {
            var product = await _productRepository.GetAsync(x => x.Id == productId);

            if (product!=null)
            {
                return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
                {
                    Product = product,
                    ResultStatus = ResultStatus.Success
                });
            }
            else
            {
                return new DataResult<ProductDto>(ResultStatus.Error, Messages.ProductNotFound, new ProductDto
                {
                    Product = null,
                    Message = Messages.ProductNotFound,
                    ResultStatus = ResultStatus.Error
                });
            }
        }

        public async Task<IDataResult<ProductDto>> UpdateAsync(ProductUpdateDto productUpdateDto)
        {
            var oldProduct = await _productRepository.GetAsync(x => x.Id == productUpdateDto.Id);


            var product = _mapper.Map<ProductUpdateDto, Product>(productUpdateDto, oldProduct);
            var updatedProduct = await _productRepository.UpdateAsync(product);
            await _productRepository.SaveAsync();

            return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
            {
                Product = updatedProduct,
                Message = Messages.ProductUpdated, 
                ResultStatus = ResultStatus.Success,
            });
         
        }
    }
}
