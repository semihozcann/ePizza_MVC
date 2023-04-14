using ePizza.Entities.Dtos.Products;
using ePizza.Services.Interfaces;
using ePizza.Shared.Utilities.Results.ComplexType;
using ePizza.UI.Helpers.Interfaces;
using ePizza.UI.Interfaces;
using ePizza.UI.Models.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePizza.UI.Areas.Admin.Controllers
{
    public class ProductsController : BaseController
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private IProductTypeService _productTypeService;
        private readonly IFileHelper _fileHelper;

        public ProductsController(IUserAccessor userAccessor, IProductService productService, ICategoryService categoryService, IProductTypeService productTypeService, IFileHelper fileHelper) : base(userAccessor)
        {
            _productService = productService;
            _categoryService = categoryService;
            _productTypeService = productTypeService;
            _fileHelper = fileHelper;
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

        public async Task<IActionResult> Add()
        {
            var model = new ProductAddViewModel();

            var category = await _categoryService.GetAllAsync();

            List<SelectListItem> categories = (from x in category.Data.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString()
                                               }).ToList();
            model.CategoriesForDr = categories;


            var productType = await _productTypeService.GetAllAsync();

            List<SelectListItem> productTypes = (from x in productType.Data.ProductTypes.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.Id.ToString()
                                                 }).ToList();
            model.ProductTypesForDr = productTypes;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductAddViewModel productAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = new ProductAddDto
                {
                    Name = productAddViewModel.Name,
                    Description = productAddViewModel.Description,
                    UnitPrice = productAddViewModel.UnitPrice,
                    CategoryId = productAddViewModel.CategoryId,
                    ProductTypeId = productAddViewModel.ProductTypeId
                };
                var fileName = productAddViewModel.ImageUrl;
                var imageFile = _fileHelper.UploadFile(fileName);
                product.ImageUrl = imageFile;

                var result = await _productService.AddAsync(product);
                productAddViewModel.Message = result.Message;

                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("GetAllProducts");
                }
                ViewBag.ProductResultMessage = result.Message;
                return View(productAddViewModel);
            }
            return View(productAddViewModel);
        }


        public async Task<IActionResult> Update(int Id)
        {
            var result = await _productService.GetAsync(Id);

            var product = new ProductUpdateViewModel
            {
                Id = result.Data.Product.Id,
                Name = result.Data.Product.Name,
                Description = result.Data.Product.Description,
                UnitPrice = result.Data.Product.UnitPrice,
                CategoryId = result.Data.Product.CategoryId,
                ProductTypeId = result.Data.Product.ProductTypeId,
                Message = result.Message
            };

            var category = await _categoryService.GetAllAsync();

            List<SelectListItem> categories = (from x in category.Data.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString()
                                               }).ToList();
            product.CategoriesForDr = categories;

            var productType = await _productTypeService.GetAllAsync();

            List<SelectListItem> productTypes = (from x in productType.Data.ProductTypes.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.Id.ToString()
                                                 }).ToList();
            product.ProductTypesForDr = productTypes;

            return View(product);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProductUpdateViewModel productUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = new ProductUpdateDto
                {
                    Id = productUpdateViewModel.Id,
                    Name = productUpdateViewModel.Name,
                    Description = productUpdateViewModel.Description,
                    UnitPrice = productUpdateViewModel.UnitPrice,
                    CategoryId = productUpdateViewModel.CategoryId,
                    ProductTypeId = productUpdateViewModel.ProductTypeId
                };

                var result = await _productService.UpdateAsync(product);
                productUpdateViewModel.Message = result.Message;
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("GetAllProducts");
                }
                return View();
            }
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _productService.DeleteAsync(Id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return RedirectToAction("GetAllProducts");
            }
            return View();
        }

    }
}
