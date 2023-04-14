using ePizza.Entities.Dtos.ProductTypes;
using ePizza.Services.Interfaces;
using ePizza.Shared.Utilities.Results.ComplexType;
using ePizza.UI.Interfaces;
using ePizza.UI.Models.Categories;
using ePizza.UI.Models.ProductTypes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ePizza.UI.Areas.Admin.Controllers
{
    public class ProductTypesController : BaseController
    {
        private readonly IProductTypeService _productTypeService;

        public ProductTypesController(IUserAccessor userAccessor, IProductTypeService productTypeService) : base(userAccessor)
        {
            _productTypeService = productTypeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllProductTypes()
        {
            var result = await _productTypeService.GetAllAsync();

            var productType = new ProductTypeListViewModel
            {
                ProductTypeListDto = result.Data,
            };

            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(productType);
            }
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductTypeAddViewModel productTypeAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var productType = new ProductTypeAddDto
                {
                    Name = productTypeAddViewModel.Name
                };

                var result = await _productTypeService.AddAsync(productType);
                productTypeAddViewModel.Message = result.Message;

                if (result.ResultStatus == ResultStatus.Success)
                {
                    ViewBag.ProductTypeResultMessage = result.Message;
                    return RedirectToAction("GetAllProductTypes");
                }
                ViewBag.ProductTypeResultMessage = result.Message;
                return View(productTypeAddViewModel);
            }
            return View(productTypeAddViewModel);
        }


        public async Task<IActionResult> Update(int Id)
        {
            var productType = await _productTypeService.GetAsync(Id);

            var oldProductType = new ProductTypeUpdateViewModel
            {
                Id = productType.Data.ProductType.Id,
                Name = productType.Data.ProductType.Name,
                Message = productType.Message
            };
            return View(oldProductType);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProductTypeUpdateViewModel productTypeUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var updatedProductType = new ProductTypeUpdateDto
                {
                    Id = productTypeUpdateViewModel.Id,
                    Name = productTypeUpdateViewModel.Name
                };
                var result = await _productTypeService.UpdateAsync(updatedProductType);
                productTypeUpdateViewModel.Message = result.Message;

                if (result.ResultStatus == ResultStatus.Success)
                {
                    ViewBag.ProductTypeResultMessage = result.Message;
                    return RedirectToAction("GetAllProductTypes");
                }
                ViewBag.ProductTypeResultMessage = result.Message;
                return View(productTypeUpdateViewModel);
            }
            return View(productTypeUpdateViewModel);
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _productTypeService.DeleteAsync(Id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return RedirectToAction("GetAllProductTypes");
            }
            return View();
        }
    }
}
