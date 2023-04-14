using ePizza.Services.Interfaces;
using ePizza.Shared.Utilities.Results.ComplexType;
using ePizza.UI.Interfaces;
using ePizza.UI.Models.Products;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ePizza.UI.Areas.User.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProductTypeService _productTypeService;

        public ProductsController(IUserAccessor userAccessor, IProductService productService, ICategoryService categoryService, IProductTypeService productTypeService) : base(userAccessor)
        {
            _productService = productService;
            _categoryService = categoryService;
            _productTypeService = productTypeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllProducts()
        {
            var category = await _categoryService.GetAllAsync();
            var productType = await _productTypeService.GetAllAsync();
            var result = await _productService.GetAllAsync();

            var products = new ProductListViewModel
            {
                ProductListDto = result.Data,
                Message = result.Message
            };

            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(products);
            }
            return View();
        }

        public async Task<IActionResult> GetAllPizzas()
        {
            var category = await _categoryService.GetAllAsync();
            var productType = await _productTypeService.GetAllAsync();
            var result = await _productService.GetAllAsync();

            var products = new ProductListViewModel
            {
                ProductListDto = result.Data,
                Message = result.Message
            };

            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(products);
            }
            return View();
        }

        public async Task<IActionResult> GetAllDesserts()
        {
            var category = await _categoryService.GetAllAsync();
            var productType = await _productTypeService.GetAllAsync();
            var result = await _productService.GetAllAsync();

            var products = new ProductListViewModel
            {
                ProductListDto = result.Data,
                Message = result.Message
            };

            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(products);
            }
            return View();
        }

        public async Task<IActionResult> GetAllDrinks()
        {
            var category = await _categoryService.GetAllAsync();
            var productType = await _productTypeService.GetAllAsync();
            var result = await _productService.GetAllAsync();

            var products = new ProductListViewModel
            {
                ProductListDto = result.Data,
                Message = result.Message
            };

            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(products);
            }
            return View();
        }
    }
}
